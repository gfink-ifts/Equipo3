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
    public partial class PRODUCTOS : Form
    {
        
        string cadenaConex = @"data source=.\SQLEXPRESS; initial catalog = CARNICERIA; integrated security= SSPI";
        SqlConnection cn;
        private bool edicion = false;
        public PRODUCTOS()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            ALTA_PRODUCTO formAltaProducto = new ALTA_PRODUCTO();
            formAltaProducto.ShowDialog();
            mostrarProducto();
        }

        private void PRODUCTO_Load(object sender, EventArgs e)
        {
            mostrarProducto();
        }

        private void mostrarProducto()
        {
            cn = new SqlConnection(cadenaConex);
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "select * from producto";
            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);
            cn.Close();
            dtgvProducto.DataSource = dt;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string tipo_producto, nombre;
            decimal precio_unitario, stock; 

            tipo_producto = cmbtipoproducto.Text;
            nombre = txtNombre.Text;
            precio_unitario = Convert.ToInt32 (txtprecio.Text);
            stock = Convert.ToInt32(txtstock.Text); 
            

            if (edicion == false)
            {
                string cmd = "insert into producto (tipo_producto, nombre, precio_unitario, stock)" + "values ( @tipo_producto,  @nombre, @precio_unitario , @stock )";
                SqlCommand comando = new SqlCommand(cmd, cn);
                comando.Parameters.AddWithValue("@tipo_producto", tipo_producto);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@precio_unitario", precio_unitario);
                comando.Parameters.AddWithValue("@stock", stock);
                cn.Open();
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                cn.Close();
                MessageBox.Show("Producto creado correctamente");
            }
            if (edicion == true)
            {
                string ID = dtgvProducto.CurrentRow.Cells["id_producto"].Value.ToString();
                string cmd = "update producto set tipo_producto=@tipo_producto, nombre=@nombre, precio_unitario=@precio_unitario, stock=@stock where id_producto=" + ID;
                SqlCommand comando = new SqlCommand(cmd, cn);
                comando.Parameters.AddWithValue("@tipo_producto", tipo_producto);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@precio_unitario", precio_unitario);
                comando.Parameters.AddWithValue("@stock", stock);
                cn.Open();
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                cn.Close();
                MessageBox.Show("Producto editado correctamente");
                edicion = false;
            }
            vaciarCampos();
            mostrarProducto();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dtgvProducto.SelectedRows.Count > 0)
            {
                edicion = true;
                cmbtipoproducto.Text = dtgvProducto.CurrentRow.Cells["tipo_producto"].Value.ToString();
                txtNombre.Text = dtgvProducto.CurrentRow.Cells["nombre"].Value.ToString();
                txtprecio.Text = dtgvProducto.CurrentRow.Cells["precio_unitario"].Value.ToString();
                txtstock.Text = dtgvProducto.CurrentRow.Cells["stock"].Value.ToString();
                
            }
            else
                MessageBox.Show("Seleccione una fila por favor.");
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dtgvProducto.SelectedRows.Count > 0)
            {
                string ID = dtgvProducto.CurrentRow.Cells["id_producto"].Value.ToString();
                string cmd = "delete from producto where id_producto=" + ID;
                SqlCommand comando = new SqlCommand(cmd, cn);
                cn.Open();
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                cn.Close();
                MessageBox.Show("Producto eliminado correctamente");
                vaciarCampos();
                mostrarProducto();
            }
            else
                MessageBox.Show("Seleccione una fila por favor.");

        }
    }
}
