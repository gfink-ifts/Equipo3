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
    public partial class ALTA_PRODUCTO : Form
    {
        string cadenaConex = @"data source=.\SQLEXPRESS; initial catalog = CARNICERIA; integrated security= SSPI";
        SqlConnection cn;
        public ALTA_PRODUCTO()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            string nombre;
            decimal precio_unitario;
            decimal stock;
            string id_tipo_producto;

            nombre = txtNombre.Text;
            precio_unitario = Convert.ToInt32 (txtprecio.Text);
            stock = Convert.ToInt32 (txtstock.Text);
            id_tipo_producto = txttipo.Text;
            string cmd = "insert into producto ( id_tipo_producto,nombre,precio_unitario,stock)" + "values ( @id_tipo_producto, @nombre, @precio_unitario, @stock  )";
            SqlCommand comando = new SqlCommand(cmd, cn);
            
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@precio_unitario", precio_unitario);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@id_tipo_producto", id_tipo_producto);

            cn.Open();
            comando.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Producto creado correctamente");
            foreach (Control variable in this.Controls)
            {
                if (variable is TextBox)
                {
                    (variable as TextBox).Clear();
                }
            }
        }

        private void ALTA_PRODUCTO_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
