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
    public partial class CLIENTES : Form
    {
        string cadenaConex = @"data source=.\SQLEXPRESS; initial catalog = CARNICERIA; integrated security= SSPI";
        SqlConnection cn;
        private bool edicion = false;
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
            mostrarClientes();
        }

        private void CLIENTES_Load(object sender, EventArgs e)
        {
            mostrarClientes();
        }

        private void mostrarClientes()
        {
            cn = new SqlConnection(cadenaConex);
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string query = "select * from cliente";
            cn.Open();
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);
            cn.Close();
            dtgvClientes.DataSource = dt;
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
            string tipo_cliente, CUIT, nombre, direccion, telefono, email;
            tipo_cliente = cmbTipoCliente.Text;
            CUIT = txt_CUIT.Text;
            nombre = txtNombre.Text;
            direccion = txtDireccion.Text;
            telefono = txtTelefono.Text;
            email = txtEmail.Text;

            if (edicion == false) {
                string cmd = "insert into cliente (tipo_cliente,cuit,nombre,direccion,telefono,email)" + "values ( @tipo_cliente, @CUIT, @nombre, @direccion, @telefono, @email )";
                SqlCommand comando = new SqlCommand(cmd, cn);
                comando.Parameters.AddWithValue("@tipo_cliente", tipo_cliente);
                comando.Parameters.AddWithValue("@CUIT", CUIT);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@email", email);
                cn.Open();
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                cn.Close();
                MessageBox.Show("Usuario creado correctamente");            
            }
            if (edicion == true)
            {
                string ID = dtgvClientes.CurrentRow.Cells["id_cliente"].Value.ToString();
                string cmd = "update cliente set tipo_cliente=@tipo_cliente, cuit=@CUIT, nombre=@nombre, direccion=@direccion, telefono=@telefono, email=@email where id_cliente="+ID;
                SqlCommand comando = new SqlCommand(cmd, cn);
                comando.Parameters.AddWithValue("@tipo_cliente", tipo_cliente);
                comando.Parameters.AddWithValue("@CUIT", CUIT);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@email", email);
                cn.Open();
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                cn.Close();
                MessageBox.Show("Usuario editado correctamente");
                edicion = false;            
            }
            vaciarCampos();
            mostrarClientes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dtgvClientes.SelectedRows.Count > 0)
            {
                edicion = true;
                cmbTipoCliente.Text = dtgvClientes.CurrentRow.Cells["tipo_cliente"].Value.ToString();
                txt_CUIT.Text = dtgvClientes.CurrentRow.Cells["cuit"].Value.ToString();
                txtNombre.Text = dtgvClientes.CurrentRow.Cells["nombre"].Value.ToString();
                txtDireccion.Text = dtgvClientes.CurrentRow.Cells["direccion"].Value.ToString();
                txtTelefono.Text = dtgvClientes.CurrentRow.Cells["telefono"].Value.ToString();
                txtEmail.Text = dtgvClientes.CurrentRow.Cells["email"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor.");
        }
    }
}
