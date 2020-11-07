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
    public partial class FORMAS_PAGO : Form
    {
        string cadenaConex = @"data source=.\SQLEXPRESS; initial catalog = CARNICERIA; integrated security= SSPI";
        SqlConnection cn;        
        public FORMAS_PAGO()
        {
            InitializeComponent();
        }

        private void FORMAS_PAGO_Load(object sender, EventArgs e)
        {
            mostrar_formas_pago();
        }

        private void mostrar_formas_pago()
        {
            cn = new SqlConnection(cadenaConex);
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "select * from forma_pago";
            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);
            cn.Close();
            dtgvFormasPago.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string forma_pago, descuento;
            forma_pago = txtFormaPago.Text;
            descuento = txtDescuento.Text;
            string cmd = "insert into forma_pago (forma_pago,descuento)" + "values ( @forma_pago, @descuento)";
            SqlCommand comando = new SqlCommand(cmd, cn);
            comando.Parameters.AddWithValue("@forma_pago", forma_pago);
            comando.Parameters.AddWithValue("@descuento", descuento);            
            cn.Open();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            cn.Close();
            MessageBox.Show("Forma de Pago creada correctamente");
            mostrar_formas_pago();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dtgvFormasPago.SelectedRows.Count > 0)
            {
                string ID = dtgvFormasPago.CurrentRow.Cells["id_forma_pago"].Value.ToString();
                string cmd = "delete from forma_pago where id_forma_pago=" + ID;
                SqlCommand comando = new SqlCommand(cmd, cn);
                cn.Open();
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                cn.Close();
                MessageBox.Show("Forma de Pago eliminada correctamente");
                vaciarCampos();
                mostrar_formas_pago();
            }
            else
                MessageBox.Show("Seleccione una fila por favor.");
        }

        private void vaciarCampos()
        {
            foreach (Control variable in this.Controls)
            {
                if (variable is TextBox)
                {
                    (variable as TextBox).Clear();
                }
                if (variable is ComboBox)
                {
                    (variable as ComboBox).Items.Clear();
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
