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
    public partial class ALTA_CLIENTE : Form
    {
        string cadenaConex = @"data source=.\SQLEXPRESS; initial catalog = CARNICERIA; integrated security= SSPI";
        SqlConnection cn;
        public ALTA_CLIENTE()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            string tipo_cliente, CUIT, nombre, direccion, telefono, email;
            tipo_cliente = cmbTipoCliente.Text;
            CUIT = txt_CUIT.Text;
            nombre = txtNombre.Text;
            direccion = txtDireccion.Text;
            telefono = txtTelefono.Text;
            email = txtEmail.Text;
            string cmd = "insert into cliente (tipo_cliente,cuit,nombre,direccion,telefono,email)"+"values ( @tipo_cliente, @CUIT, @nombre, @direccion, @telefono, @email )";
            SqlCommand comando = new SqlCommand(cmd, cn);
            comando.Parameters.AddWithValue("@tipo_cliente", tipo_cliente);
            comando.Parameters.AddWithValue("@CUIT", CUIT);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@email", email);
            cn.Open();
            comando.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Usuario creado correctamente");
            this.Close();            
        }

        private void ALTA_CLIENTE_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
        }
    }
}
