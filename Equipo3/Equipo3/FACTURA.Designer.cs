namespace Equipo3
{
    partial class FACTURA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbxSeleccion = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dtgvListaProductos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalAcumulado = new System.Windows.Forms.Label();
            this.gpbxSeleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbxSeleccion
            // 
            this.gpbxSeleccion.Controls.Add(this.label4);
            this.gpbxSeleccion.Controls.Add(this.label3);
            this.gpbxSeleccion.Controls.Add(this.label2);
            this.gpbxSeleccion.Controls.Add(this.label1);
            this.gpbxSeleccion.Controls.Add(this.lblNombre);
            this.gpbxSeleccion.Controls.Add(this.lblTipoCliente);
            this.gpbxSeleccion.Controls.Add(this.lblIDCliente);
            this.gpbxSeleccion.Controls.Add(this.lblCUIT);
            this.gpbxSeleccion.Location = new System.Drawing.Point(21, 34);
            this.gpbxSeleccion.Name = "gpbxSeleccion";
            this.gpbxSeleccion.Size = new System.Drawing.Size(438, 123);
            this.gpbxSeleccion.TabIndex = 17;
            this.gpbxSeleccion.TabStop = false;
            this.gpbxSeleccion.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(6, 27);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(38, 13);
            this.lblTipoCliente.TabIndex = 3;
            this.lblTipoCliente.Text = "CUIT: ";
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new System.Drawing.Point(6, 93);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(59, 13);
            this.lblIDCliente.TabIndex = 6;
            this.lblIDCliente.Text = "ID Cliente: ";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(6, 49);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(80, 13);
            this.lblCUIT.TabIndex = 4;
            this.lblCUIT.Text = "Tipo de cliente:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(209, 485);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(210, 23);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(437, 485);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(210, 23);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // dtgvListaProductos
            // 
            this.dtgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.producto,
            this.cantidad,
            this.precio_unitario,
            this.total_concepto});
            this.dtgvListaProductos.Location = new System.Drawing.Point(21, 163);
            this.dtgvListaProductos.Name = "dtgvListaProductos";
            this.dtgvListaProductos.Size = new System.Drawing.Size(438, 274);
            this.dtgvListaProductos.TabIndex = 20;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 40;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.Width = 120;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 75;
            // 
            // precio_unitario
            // 
            this.precio_unitario.HeaderText = "Precio U.";
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.Width = 75;
            // 
            // total_concepto
            // 
            this.total_concepto.HeaderText = "Total";
            this.total_concepto.Name = "total_concepto";
            this.total_concepto.Width = 75;
            // 
            // lblTotalAcumulado
            // 
            this.lblTotalAcumulado.AutoSize = true;
            this.lblTotalAcumulado.Location = new System.Drawing.Point(506, 43);
            this.lblTotalAcumulado.Name = "lblTotalAcumulado";
            this.lblTotalAcumulado.Size = new System.Drawing.Size(92, 13);
            this.lblTotalAcumulado.TabIndex = 21;
            this.lblTotalAcumulado.Text = "Total acumulado: ";
            // 
            // FACTURA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 520);
            this.Controls.Add(this.lblTotalAcumulado);
            this.Controls.Add(this.dtgvListaProductos);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gpbxSeleccion);
            this.Name = "FACTURA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURA";
            this.gpbxSeleccion.ResumeLayout(false);
            this.gpbxSeleccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxSeleccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dtgvListaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_concepto;
        private System.Windows.Forms.Label lblTotalAcumulado;
    }
}