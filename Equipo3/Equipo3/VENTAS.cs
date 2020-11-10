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
        decimal descuento = 0;
        decimal precio_final = 0;
        int id_pago;

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
            cargarCliente();
            lblTotalAcumulado.Text = "Total acumulado: $ 0.00";
            lblDescuento.Text = "Descuento: $ 0.00";
            lblPrecioFinal.Text = "Precio Final: $ 0.00";
            lblTarjeta.Text = " ";
            cmbFormasPago.Enabled = false;
            btnCalcularDescuento.Enabled = false;
        }

        private void cargarCliente()
        {
            string query = "select * from cliente where id_cliente = " + id_persona;
            SqlCommand comando = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader lectura = comando.ExecuteReader();
            while (lectura.Read())
            {
                lblIDCliente.Text = lectura[0].ToString();
                lblTipoCliente.Text = lectura[1].ToString();
                lblCUITCliente.Text = lectura[2].ToString();
                lblNombreCliente.Text = lectura[3].ToString();
                lblDireCliente.Text = lectura[4].ToString();
                lblTelCliente.Text = lectura[5].ToString();
                lblEmailCliente.Text = lectura[6].ToString();
            }
            cn.Close();
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
            bool producto_repetido = CHEQUEO_SI_REPITE(dtgvListaProductos, label1.Text);


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
                    actualizar_precio_final();
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

            for (int i = 0; i < tabla.Rows.Count -1 ; i++)
            {
                string comparacion = tabla.Rows[i].Cells[0].Value.ToString();
                if (eleccion == comparacion)
                {
                    se_repite = true;
                }
            }

            return se_repite;
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvListaProductos.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection fila = dtgvListaProductos.SelectedRows;
                decimal parcial_eliminado = Convert.ToDecimal(dtgvListaProductos.SelectedRows[0].Cells[4].Value.ToString());
                total_acumulado = total_acumulado - parcial_eliminado;
                dtgvListaProductos.Rows.RemoveAt(dtgvListaProductos.SelectedRows[0].Index);
                lblTotalAcumulado.Text = "Total acumulado: $ " + total_acumulado;
                descuento = 0;
                MessageBox.Show("Al eliminar un producto debe recalcular el descuento aplicado.");
                actualizar_precio_final();
            }
            else
                MessageBox.Show("Seleccione la fila del producto que quiere eliminar por favor.");
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            if (total_acumulado == 0)
            {
                MessageBox.Show("Cargue artículos en la lista para avanzar por favor");
            }
            else
            {
                if (rdbEfectivo.Checked)
                {
                    confeccionFactura();
                    this.Close();
                }
                if (rdbTarjeta.Checked)
                {
                    if (descuento == 0)
                    {
                        MessageBox.Show("Calcule el descuento que obtiene con la forma de pago elegida.");
                    }
                    else
                    {
                        confeccionFactura();
                        this.Close();
                    }
                }
                if (rdbTarjeta.Checked == false && rdbEfectivo.Checked == false)
                {
                    MessageBox.Show("Elija un método de pago.");
                }
                
            }
        }

        private void rdbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTarjeta.Checked)
            {
                lblTarjeta.Text = "Elija una opción:";
                cmbFormasPago.Enabled = true;
                btnCalcularDescuento.Enabled = true;
                fill_combo();
            }
            else
            {
                descuento = 0;         
                lblTarjeta.Text = " ";
                cmbFormasPago.Enabled = false;
                btnCalcularDescuento.Enabled = false;
            }
            actualizar_precio_final();
        }

        private void actualizar_precio_final()
        {
            precio_final = total_acumulado - descuento;
            lblDescuento.Text = "Descuento: $ " + descuento;
            lblPrecioFinal.Text = "Precio Final: $ " + precio_final;
        }

        private void fill_combo()
        {
            cn = new SqlConnection(cadenaConex);
            string query = "select * from forma_pago";
            SqlDataAdapter lectura;
            DataTable dt = new DataTable();
            cn.Open();
            lectura = new SqlDataAdapter(query, cn);
            lectura.Fill(dt);
            cmbFormasPago.DataSource = dt;
            cmbFormasPago.ValueMember = "id_forma_pago";
            cmbFormasPago.DisplayMember = "forma_pago";
            cn.Close();
        }

        private void btnCalcularDescuento_Click(object sender, EventArgs e)
        {
            string forma_pago;
            decimal porcentaje_desc;
            string query = "select * from forma_pago where forma_pago = '" + cmbFormasPago.Text + "'";
            SqlCommand comando = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader lectura = comando.ExecuteReader();
            while (lectura.Read())
            {
                MessageBox.Show("El descuento para esta forma de pago es: "+ lectura[2].ToString() + "%");
                id_pago = Convert.ToInt32(lectura[0].ToString());
                forma_pago = lectura[1].ToString();
                porcentaje_desc = Convert.ToDecimal(lectura[2].ToString());
                descuento = (total_acumulado * porcentaje_desc) / 100;
            }
            cn.Close();
            actualizar_precio_final();
            
        }

        private void confeccionFactura()
        {
            //ARMADO FACTURA
            string consultita = "select count(*) from venta";
            SqlCommand id_de_la_venta = new SqlCommand(consultita, cn);
            cn.Open();
            int id_venta = int.Parse(id_de_la_venta.ExecuteScalar().ToString());
            cn.Close();
            DateTime fecha = DateTime.Now;
            int el_cliente = id_persona;
            int id_forma_pago = id_pago;
            decimal subtotal = total_acumulado;
            decimal total = precio_final;

            /*
            //muestra de los datos
            string fechita = Convert.ToString(fecha);
            MessageBox.Show("Los valores son.. id_venta= " + id_venta + "  fecha:" + fechita + " idcliente.idformapago: " + el_cliente + id_forma_pago + "   " + subtotal + total);
            */
            
            string cmd = "insert into venta (id_venta,fecha,id_cliente,id_forma_pago,subtotal,total)" + "values ( @id_venta,@fecha, @id_cliente, @id_forma_pago, @subtotal, @total )";
            SqlCommand comando = new SqlCommand(cmd, cn);
            comando.Parameters.AddWithValue("@id_venta", id_venta);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@id_cliente", el_cliente);
            comando.Parameters.AddWithValue("@id_forma_pago", id_forma_pago);
            comando.Parameters.AddWithValue("@subtotal", subtotal);
            comando.Parameters.AddWithValue("@total", total);            
            cn.Open();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            cn.Close();            

            //ARMADO CONCEPTOS DE FACTURA
            int limite = dtgvListaProductos.Rows.Count;
            for (int i = 0; i < limite - 1 ; i++)
            {
                int id_venta_query = id_venta;
                int id_producto_query = Convert.ToInt32(dtgvListaProductos.Rows[i].Cells[0].Value.ToString());
                decimal cantidad_query = Convert.ToDecimal(dtgvListaProductos.Rows[i].Cells[2].Value.ToString());
                decimal precio_unitario_query = Convert.ToDecimal(dtgvListaProductos.Rows[i].Cells[3].Value.ToString());
                decimal importe_query = Convert.ToDecimal(dtgvListaProductos.Rows[i].Cells[4].Value.ToString());

                /*
                MessageBox.Show("fila "+i+"  valor  id_venta= " + id_venta_query + "  id_prodcuto:" + id_producto_query + "  cantidad: " + cantidad_query + "   precuo_Uni: " +precio_unitario_query  + " importe  " + importe_query);
                */
                                
                string query_conceptos = "insert into concepto (id_venta,id_producto,cantidad,precio_unitario,importe)" + "values ( @id_venta,@id_producto,@cantidad,@precio_unitario,@importe )";
                SqlCommand comando_conceptos = new SqlCommand(query_conceptos, cn);
                comando_conceptos.Parameters.AddWithValue("@id_venta", id_venta_query);
                comando_conceptos.Parameters.AddWithValue("@id_producto", id_producto_query);
                comando_conceptos.Parameters.AddWithValue("@cantidad", cantidad_query);
                comando_conceptos.Parameters.AddWithValue("@precio_unitario", precio_unitario_query);
                comando_conceptos.Parameters.AddWithValue("@importe", importe_query);
                cn.Open();
                comando_conceptos.ExecuteNonQuery();
                comando_conceptos.Parameters.Clear();
                cn.Close();
            }


            MessageBox.Show("La venta se ha realizado con éxito.");            
        }
    }
}
