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
using System.Windows.Forms.VisualStyles;

namespace Equipo3
{
    public partial class REPORTES : Form
    {
       
        string cadenaConex = @"data source=.\SQLEXPRESS; initial catalog = CARNICERIA; integrated security= SSPI";
        SqlConnection cn;   
        public REPORTES()
        {
            InitializeComponent();
        }

        private void reporte()
        {
            string cliente, tipo_producto;
            cliente = cmbcliente.Text;
                                        
            cn = new SqlConnection(cadenaConex);
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            
         
            string cmd = "select ve.id_venta, ve.fecha,  cl.tipo_cliente as TIPO_CLIENTE , cl.nombre as CLIENTE, pr.nombre, cp.cantidad , cp.importe from cliente as cl, venta as ve, concepto as cp, producto as pr where cl.nombre ='" + cliente + "' and cl.id_cliente = ve.id_cliente AND ve.id_venta = cp.id_venta AND cp.id_producto = pr.id_producto";
            cn.Open();
            da = new SqlDataAdapter(cmd,  cn);
            da.Fill(dt);
            cn.Close();
            dataGridViewreporte.DataSource = dt;
        }
        private void REPORTES_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
            SqlCommand busqueda = new SqlCommand("select * from cliente", cn);
            cn.Open();
            SqlDataReader registro = busqueda.ExecuteReader();
            while (registro.Read())
            {
                cmbcliente.Items.Add(registro["nombre"].ToString());
               
            }
            cn.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            reporte();
        }

        
    }
}
