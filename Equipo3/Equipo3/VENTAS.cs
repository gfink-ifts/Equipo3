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
    public partial class VENTAS : Form
    {
        string cadenaConex = @"data source=.\SQLEXPRESS; initial catalog = CARNICERIA; integrated security= SSPI";
        SqlConnection cn;

        public VENTAS()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mostrarProductosDisponibles()
        {
            cn = new SqlConnection(cadenaConex);
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "select nombre as Producto, precio_unitario as Precio, stock as Stock from producto";           
            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);
            cn.Close();
            dtgvDisponible.DataSource = dt;
        }

        private void VENTAS_Load(object sender, EventArgs e)
        {
            mostrarProductosDisponibles();
            label1.Text = " ";
            label2.Text = " ";
            label3.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
        }

        private void dtgvDisponible_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {   //RELLENO DE LOS LABELS SEGUN LA SELECCION DE LA FILA

            string query = "select * from producto where nombre = '" + dtgvDisponible.CurrentRow.Cells["Producto"].Value.ToString() + "'";
            SqlCommand comando = new SqlCommand(query,cn);
            cn.Open();
            SqlDataReader lectura = comando.ExecuteReader();
            while (lectura.Read())
            {                
                label1.Text = lectura[0].ToString(); //ID DEL PRODUCTO
                label2.Text = lectura[1].ToString(); //TIPO DE PRODUCTO
                label3.Text = lectura[2].ToString(); //NOMBRE DEL PRODUCTO
                label4.Text = lectura[3].ToString(); //PRECIO UNITARIO DEL PRODUCTO
                label5.Text = lectura[4].ToString(); //STOCK DEL PRODUCTO
            }
            cn.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {   //RELLENO DE LA LISTA DE PRODUCTOS SELECCIONADOS, CON CALCULO DE STOCK

            decimal cantidad = Convert.ToDecimal(txtCantidad.Text);
            bool se_puede_agregar = CHEQUEO_STOCK(cantidad);
            bool producto_repetido = CHEQUEO_SI_REPITE(dtgvListaProductos, label3.Text);
            if (producto_repetido)
            {
                MessageBox.Show("Ya se eligió el producto.");
            }
            else
            {
                if (se_puede_agregar)
                {
                    decimal total_eleccion = cantidad * Convert.ToDecimal(label4.Text);
                    dtgvListaProductos.Rows.Add(label1.Text, label3.Text, cantidad, label4.Text, total_eleccion);
                }
                else
                    MessageBox.Show("La cantidad elegida supera el stock del producto.");
            }
            
        }

        private bool CHEQUEO_STOCK (decimal cantidad_elegida)
        {
            bool resultado = true;            
            decimal stock = Convert.ToDecimal(label5.Text);
            if (stock < cantidad_elegida)
            {
                resultado = false;
            }
            return resultado;
        }

        private bool CHEQUEO_SI_REPITE(DataGridView tabla, string eleccion)
        {
            bool se_repite = false;

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (eleccion == tabla.Rows[i].Cells[1].ToString())
                {
                    se_repite = true;
                    break;
                }
            }

            return se_repite;
        }
    }
}
