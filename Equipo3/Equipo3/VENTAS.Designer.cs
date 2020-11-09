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
            this.lblTotalAcumulado = new System.Windows.Forms.Label();
            this.gpbxCliente = new System.Windows.Forms.GroupBox();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.lblCUITCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblDireCliente = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTelCliente = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.gpbxFormaPago = new System.Windows.Forms.GroupBox();
            this.cmbFormasPago = new System.Windows.Forms.ComboBox();
            this.rdbEfectivo = new System.Windows.Forms.RadioButton();
            this.rdbTarjeta = new System.Windows.Forms.RadioButton();
            this.lblTarjeta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDisponible)).BeginInit();
            this.gpbxSeleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaProductos)).BeginInit();
            this.gpbxCliente.SuspendLayout();
            this.gpbxFormaPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(756, 526);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(210, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(753, 120);
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
            this.dtgvDisponible.Size = new System.Drawing.Size(402, 507);
            this.dtgvDisponible.TabIndex = 2;
            this.dtgvDisponible.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvDisponible_RowHeaderMouseClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID: ";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 49);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(108, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo de producto:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblPrecioU
            // 
            this.lblPrecioU.AutoSize = true;
            this.lblPrecioU.Location = new System.Drawing.Point(6, 93);
            this.lblPrecioU.Name = "lblPrecioU";
            this.lblPrecioU.Size = new System.Drawing.Size(97, 13);
            this.lblPrecioU.TabIndex = 6;
            this.lblPrecioU.Text = "Precio unitario: ";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(6, 115);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(48, 13);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Stock: ";
            // 
            // gpbxSeleccion
            // 
            this.gpbxSeleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
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
            this.gpbxSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxSeleccion.Location = new System.Drawing.Point(436, 15);
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
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
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
            this.txtCantidad.Location = new System.Drawing.Point(753, 79);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(753, 60);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(96, 13);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad deseada:";
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(936, 466);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(311, 23);
            this.btnAvanzar.TabIndex = 12;
            this.btnAvanzar.Text = "CONFIRMAR COMPRA";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
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
            this.dtgvListaProductos.Location = new System.Drawing.Point(436, 176);
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
            this.btnEliminar.Location = new System.Drawing.Point(526, 466);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(250, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "ELIMINAR PRODUCTO DE LA LISTA";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTotalAcumulado
            // 
            this.lblTotalAcumulado.AutoSize = true;
            this.lblTotalAcumulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAcumulado.Location = new System.Drawing.Point(931, 227);
            this.lblTotalAcumulado.Name = "lblTotalAcumulado";
            this.lblTotalAcumulado.Size = new System.Drawing.Size(177, 24);
            this.lblTotalAcumulado.TabIndex = 16;
            this.lblTotalAcumulado.Text = "Total acumulado: ";
            // 
            // gpbxCliente
            // 
            this.gpbxCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gpbxCliente.Controls.Add(this.lblTelCliente);
            this.gpbxCliente.Controls.Add(this.lblEmailCliente);
            this.gpbxCliente.Controls.Add(this.label18);
            this.gpbxCliente.Controls.Add(this.label19);
            this.gpbxCliente.Controls.Add(this.lblIDCliente);
            this.gpbxCliente.Controls.Add(this.lblTipoCliente);
            this.gpbxCliente.Controls.Add(this.lblCUITCliente);
            this.gpbxCliente.Controls.Add(this.lblNombreCliente);
            this.gpbxCliente.Controls.Add(this.lblDireCliente);
            this.gpbxCliente.Controls.Add(this.label11);
            this.gpbxCliente.Controls.Add(this.label12);
            this.gpbxCliente.Controls.Add(this.label13);
            this.gpbxCliente.Controls.Add(this.label14);
            this.gpbxCliente.Controls.Add(this.label15);
            this.gpbxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxCliente.Location = new System.Drawing.Point(936, 15);
            this.gpbxCliente.Name = "gpbxCliente";
            this.gpbxCliente.Size = new System.Drawing.Size(311, 184);
            this.gpbxCliente.TabIndex = 13;
            this.gpbxCliente.TabStop = false;
            this.gpbxCliente.Text = "Cliente seleccionado";
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Location = new System.Drawing.Point(119, 27);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(41, 13);
            this.lblIDCliente.TabIndex = 10;
            this.lblIDCliente.Text = "label6";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(119, 49);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(41, 13);
            this.lblTipoCliente.TabIndex = 12;
            this.lblTipoCliente.Text = "label7";
            // 
            // lblCUITCliente
            // 
            this.lblCUITCliente.AutoSize = true;
            this.lblCUITCliente.Location = new System.Drawing.Point(119, 71);
            this.lblCUITCliente.Name = "lblCUITCliente";
            this.lblCUITCliente.Size = new System.Drawing.Size(41, 13);
            this.lblCUITCliente.TabIndex = 8;
            this.lblCUITCliente.Text = "label8";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(119, 93);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(41, 13);
            this.lblNombreCliente.TabIndex = 11;
            this.lblNombreCliente.Text = "label9";
            // 
            // lblDireCliente
            // 
            this.lblDireCliente.AutoSize = true;
            this.lblDireCliente.Location = new System.Drawing.Point(119, 115);
            this.lblDireCliente.Name = "lblDireCliente";
            this.lblDireCliente.Size = new System.Drawing.Size(48, 13);
            this.lblDireCliente.TabIndex = 9;
            this.lblDireCliente.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Nombre: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Dirección:  ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "ID: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "CUIT: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Tipo de cliente: ";
            // 
            // lblTelCliente
            // 
            this.lblTelCliente.AutoSize = true;
            this.lblTelCliente.Location = new System.Drawing.Point(119, 138);
            this.lblTelCliente.Name = "lblTelCliente";
            this.lblTelCliente.Size = new System.Drawing.Size(48, 13);
            this.lblTelCliente.TabIndex = 16;
            this.lblTelCliente.Text = "label16";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(119, 160);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(48, 13);
            this.lblEmailCliente.TabIndex = 15;
            this.lblEmailCliente.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Teléfono: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 160);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "E-mail: ";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioFinal.Location = new System.Drawing.Point(931, 426);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(134, 24);
            this.lblPrecioFinal.TabIndex = 17;
            this.lblPrecioFinal.Text = "Precio Final: ";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(932, 377);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(122, 24);
            this.lblDescuento.TabIndex = 18;
            this.lblDescuento.Text = "Descuento: ";
            // 
            // gpbxFormaPago
            // 
            this.gpbxFormaPago.Controls.Add(this.lblTarjeta);
            this.gpbxFormaPago.Controls.Add(this.rdbTarjeta);
            this.gpbxFormaPago.Controls.Add(this.rdbEfectivo);
            this.gpbxFormaPago.Controls.Add(this.cmbFormasPago);
            this.gpbxFormaPago.Location = new System.Drawing.Point(936, 254);
            this.gpbxFormaPago.Name = "gpbxFormaPago";
            this.gpbxFormaPago.Size = new System.Drawing.Size(311, 120);
            this.gpbxFormaPago.TabIndex = 19;
            this.gpbxFormaPago.TabStop = false;
            this.gpbxFormaPago.Text = "Forma de pago";
            // 
            // cmbFormasPago
            // 
            this.cmbFormasPago.FormattingEnabled = true;
            this.cmbFormasPago.Location = new System.Drawing.Point(100, 66);
            this.cmbFormasPago.Name = "cmbFormasPago";
            this.cmbFormasPago.Size = new System.Drawing.Size(205, 21);
            this.cmbFormasPago.TabIndex = 2;
            // 
            // rdbEfectivo
            // 
            this.rdbEfectivo.AutoSize = true;
            this.rdbEfectivo.Location = new System.Drawing.Point(9, 47);
            this.rdbEfectivo.Name = "rdbEfectivo";
            this.rdbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdbEfectivo.TabIndex = 3;
            this.rdbEfectivo.TabStop = true;
            this.rdbEfectivo.Text = "Efectivo";
            this.rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rdbTarjeta
            // 
            this.rdbTarjeta.AutoSize = true;
            this.rdbTarjeta.Location = new System.Drawing.Point(9, 70);
            this.rdbTarjeta.Name = "rdbTarjeta";
            this.rdbTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rdbTarjeta.TabIndex = 4;
            this.rdbTarjeta.TabStop = true;
            this.rdbTarjeta.Text = "Tarjeta";
            this.rdbTarjeta.UseVisualStyleBackColor = true;
            this.rdbTarjeta.CheckedChanged += new System.EventHandler(this.rdbTarjeta_CheckedChanged);
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(97, 47);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(35, 13);
            this.lblTarjeta.TabIndex = 5;
            this.lblTarjeta.Text = "label6";
            // 
            // VENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.gpbxFormaPago);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.gpbxCliente);
            this.Controls.Add(this.lblTotalAcumulado);
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
            this.Text = "VENTA";
            this.Load += new System.EventHandler(this.VENTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDisponible)).EndInit();
            this.gpbxSeleccion.ResumeLayout(false);
            this.gpbxSeleccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaProductos)).EndInit();
            this.gpbxCliente.ResumeLayout(false);
            this.gpbxCliente.PerformLayout();
            this.gpbxFormaPago.ResumeLayout(false);
            this.gpbxFormaPago.PerformLayout();
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
        private System.Windows.Forms.Label lblTotalAcumulado;
        private System.Windows.Forms.GroupBox gpbxCliente;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label lblCUITCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblDireCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTelCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.GroupBox gpbxFormaPago;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.RadioButton rdbTarjeta;
        private System.Windows.Forms.RadioButton rdbEfectivo;
        private System.Windows.Forms.ComboBox cmbFormasPago;
    }
}