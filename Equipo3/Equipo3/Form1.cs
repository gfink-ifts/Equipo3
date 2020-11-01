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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            CLIENTES formClientes = new CLIENTES();
            this.Hide();
            formClientes.ShowDialog();
            this.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            PRODUCTOS formClientes = new PRODUCTOS();
            this.Hide();
            formClientes.ShowDialog();
            this.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            PREVENTA formPreventa = new PREVENTA();
            this.Hide();
            formPreventa.ShowDialog();
            this.Show();
        }
    }
}
