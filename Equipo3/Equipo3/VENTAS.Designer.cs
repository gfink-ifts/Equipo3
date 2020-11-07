namespace Equipo3
{
    partial class VENTAS
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dtgvDisponible = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecioU = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.gpbxSeleccion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.dtgvListaProductos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTotalAcumulado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDisponible)).BeginInit();
            this.gpbxSeleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(740, 500);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(210, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(829, 120);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(121, 23);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dtgvDisponible
            // 
            this.dtgvDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDisponible.Location = new System.Drawing.Point(12, 42);
            this.dtgvDisponible.Name = "dtgvDisponible";
            this.dtgvDisponible.Size = new System.Drawing.Size(471, 481);
            this.dtgvDisponible.TabIndex = 2;
            this.dtgvDisponible.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvDisponible_RowHeaderMouseClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID: ";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 49);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(91, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo de producto:";
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
            // lblPrecioU
            // 
            this.lblPrecioU.AutoSize = true;
            this.lblPrecioU.Location = new System.Drawing.Point(6, 93);
            this.lblPrecioU.Name = "lblPrecioU";
            this.lblPrecioU.Size = new System.Drawing.Size(80, 13);
            this.lblPrecioU.TabIndex = 6;
            this.lblPrecioU.Text = "Precio unitario: ";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(6, 115);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 13);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Stock: ";
            // 
            // gpbxSeleccion
            // 
            this.gpbxSeleccion.Controls.Add(this.label1);
            this.gpbxSeleccion.Controls.Add(this.label2);
            this.gpbxSeleccion.Controls.Add(this.label3);
            this.gpbxSeleccion.Controls.Add(this.label4);
            this.gpbxSeleccion.Controls.Add(this.label5);
            this.gpbxSeleccion.Controls.Add(this.lblNombre);
            this.gpbxSeleccion.Controls.Add(this.lblStock);
            this.gpbxSeleccion.Controls.Add(this.lblID);
            this.gpbxSeleccion.Controls.Add(this.lblPrecioU);
            this.gpbxSeleccion.Controls.Add(this.lblTipo);
            this.gpbxSeleccion.Location = new System.Drawing.Point(512, 15);
            this.gpbxSeleccion.Name = "gpbxSeleccion";
            this.gpbxSeleccion.Size = new System.Drawing.Size(311, 144);
            this.gpbxSeleccion.TabIndex = 8;
            this.gpbxSeleccion.TabStop = false;
            this.gpbxSeleccion.Text = "Producto seleccionado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Location = new System.Drawing.Point(9, 12);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(110, 13);
            this.lblDisponible.TabIndex = 9;
            this.lblDisponible.Text = "Productos disponibles";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(829, 79);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(829, 60);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(96, 13);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad deseada:";
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(512, 500);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(210, 23);
            this.btnAvanzar.TabIndex = 12;
            this.btnAvanzar.Text = "AVANZAR";
            this.btnAvanzar.UseVisualStyleBackColor = true;
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
            this.dtgvListaProductos.Location = new System.Drawing.Point(512, 176);
            this.dtgvListaProductos.Name = "dtgvListaProductos";
            this.dtgvListaProductos.Size = new System.Drawing.Size(438, 274);
            this.dtgvListaProductos.TabIndex = 13;
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
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(807, 456);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(143, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(350, 12);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(111, 13);
            this.lblCliente.TabIndex = 15;
            this.lblCliente.Text = "Cliente seleccionado: ";
            // 
            // lblTotalAcumulado
            // 
            this.lblTotalAcumulado.AutoSize = true;
            this.lblTotalAcumulado.Location = new System.Drawing.Point(509, 466);
            this.lblTotalAcumulado.Name = "lblTotalAcumulado";
            this.lblTotalAcumulado.Size = new System.Drawing.Size(92, 13);
            this.lblTotalAcumulado.TabIndex = 16;
            this.lblTotalAcumulado.Text = "Total acumulado: ";
            // 
            // VENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 532);
            this.Controls.Add(this.lblTotalAcumulado);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dtgvListaProductos);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.gpbxSeleccion);
            this.Controls.Add(this.dtgvDisponible);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnVolver);
            this.Name = "VENTAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTAS - Agregar lista de productos";
            this.Load += new System.EventHandler(this.VENTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDisponible)).EndInit();
            this.gpbxSeleccion.ResumeLayout(false);
            this.gpbxSeleccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dtgvDisponible;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecioU;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.GroupBox gpbxSeleccion;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.DataGridView dtgvListaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_concepto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTotalAcumulado;
    }
}