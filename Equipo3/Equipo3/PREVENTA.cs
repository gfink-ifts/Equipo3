using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Equipo3
{
    public partial class PREVENTA : Form
    {
        string cadenaConex = @"data source=.\SQLEXPRESS; initial catalog = CARNICERIA; integrated security= SSPI";
        SqlConnection cn;
        public PREVENTA()
        {
            InitializeComponent();
        }

        private void PREVENTA_Load(object sender, EventArgs e)
        {
            mostrarClientesDisponibles();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";            
        }

        private void mostrarClientesDisponibles()
        {
            cn = new SqlConnection(cadenaConex);
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "select tipo_cliente as Tipo, cuit as CUIT, nombre as Cliente from cliente";
            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);
            cn.Close();
            dtgvClienteDisponible.DataSource = dt;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            ALTA_CLIENTE formAlta = new ALTA_CLIENTE();
            formAlta.ShowDialog();
            mostrarClientesDisponibles();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            VENTAS formVenta = new VENTAS();
            this.Hide();
            formVenta.ShowDialog();
            this.Show();
        }

        private void dtgvClienteDisponible_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dtgvClienteDisponible.CurrentRow.Cells["CUIT"].Value.ToString();
            label2.Text = dtgvClienteDisponible.CurrentRow.Cells["Tipo"].Value.ToString();
            label3.Text = dtgvClienteDisponible.CurrentRow.Cells["Cliente"].Value.ToString();


            cn = new SqlConnection(cadenaConex);
            string query = "select * from cliente WHERE cuit = " + label1.Text;
            SqlCommand comando = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                label4.Text = (dr["direccion"].ToString());
                label5.Text = (dr["telefono"].ToString());
                label6.Text = (dr["email"].ToString());
            }
            dr.Close();
            comando.Parameters.Clear();
            cn.Close();
            /*
            try
            {
                con.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CustID.Text = (read["Customer_ID"].ToString());
                        CustName.Text = (read["Customer_Name"].ToString());
                        Add1.Text = (read["Address_1"].ToString());
                        Add2.Text = (read["Address_2"].ToString());
                        PostBox.Text = (read["Postcode"].ToString());
                        PassBox.Text = (read["Password"].ToString());
                        DatBox.Text = (read["Data_Important"].ToString());
                        LanNumb.Text = (read["Landline"].ToString());
                        MobNumber.Text = (read["Mobile"].ToString());
                        FaultRep.Text = (read["Fault_Report"].ToString());
                    }
                }
            }

            /*
            label4.Text = dtgvClienteDisponible.CurrentRow.Cells["CUIT"].Value.ToString();
            label5.Text = dtgvClienteDisponible.CurrentRow.Cells["CUIT"].Value.ToString();
            label6.Text = dtgvClienteDisponible.CurrentRow.Cells["CUIT"].Value.ToString();
            */
        }
    }
}
