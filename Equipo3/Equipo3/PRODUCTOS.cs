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
    public partial class PRODUCTOS : Form
    {
        public PRODUCTOS()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            ALTA_PRODUCTO formAltaCliente = new ALTA_PRODUCTO();
            formAltaCliente.ShowDialog();
        }

        private void PRODUCTOS_Load(object sender, EventArgs e)
        {

        }
    }
}
