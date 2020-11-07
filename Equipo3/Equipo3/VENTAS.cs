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
        int id_persona;
        decimal total_acumulado = 0;

        public VENTAS(int id_cliente)
        {
            InitializeComponent();
            id_persona = id_cliente;            
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
            lblCliente.Text = "Cliente seleccionado: " + id_persona;
            lblTotalAcumulado.Text = "Total acumulado: $ 0.00";
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
            bool producto_repetido = false;


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
                    total_acumulado = total_acumulado + total_eleccion;
                    lblTotalAcumulado.Text = "Total acumulado: $ " + total_acumulado;
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
        /*
        private bool CHEQUEO_SI_REPITE(DataGridView tabla, string eleccion)
        {
            bool se_repite = false;

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                string comparacion = tabla.Rows[i].Cells[2].ToString();
                MessageBox.Show("se compara eleccion: " + eleccion + " contra valor de datagrid: " + comparacion);
                if (eleccion == comparacion)
                {
                    se_repite = true;
                }
            }

            return se_repite;
        }
        */
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvListaProductos.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection fila = dtgvListaProductos.SelectedRows;
                decimal parcial_eliminado = Convert.ToDecimal(dtgvListaProductos.SelectedRows[0].Cells[4].Value.ToString());
                total_acumulado = total_acumulado - parcial_eliminado;
                dtgvListaProductos.Rows.RemoveAt(dtgvListaProductos.SelectedRows[0].Index);
                lblTotalAcumulado.Text = "Total acumulado: $ " + total_acumulado;
            }
            else
                MessageBox.Show("Seleccione la fila del producto que quiere eliminar por favor.");
        }
    }
}
