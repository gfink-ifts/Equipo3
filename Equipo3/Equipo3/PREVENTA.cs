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
            /*
            label4.Text = dtgvClienteDisponible.CurrentRow.Cells["CUIT"].Value.ToString();
            label5.Text = dtgvClienteDisponible.CurrentRow.Cells["CUIT"].Value.ToString();
            label6.Text = dtgvClienteDisponible.CurrentRow.Cells["CUIT"].Value.ToString();
            */
        }
    }
}
