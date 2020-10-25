using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipo3
{
    public partial class CLIENTES : Form
    {
        public CLIENTES()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            ALTA_CLIENTE formAltaCliente = new ALTA_CLIENTE();
            formAltaCliente.ShowDialog();
        }
    }
}
