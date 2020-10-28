namespace Equipo3
{
    partial class PRODUCTOS
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgvProducto = new System.Windows.Forms.DataGridView();
            this.cmbtipoproducto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(397, 508);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(378, 25);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(613, 364);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(98, 59);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "ELIMINAR";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(455, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 59);
            this.button3.TabIndex = 4;
            this.button3.Text = "MODIFICAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgvProducto
            // 
            this.dtgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProducto.Location = new System.Drawing.Point(12, 12);
            this.dtgvProducto.Name = "dtgvProducto";
            this.dtgvProducto.Size = new System.Drawing.Size(763, 269);
            this.dtgvProducto.TabIndex = 6;
            // 
            // cmbtipoproducto
            // 
            this.cmbtipoproducto.FormattingEnabled = true;
            this.cmbtipoproducto.Items.AddRange(new object[] {
            "CARNICERIA",
            "GRANJA"});
            this.cmbtipoproducto.Location = new System.Drawing.Point(126, 298);
            this.cmbtipoproducto.Name = "cmbtipoproducto";
            this.cmbtipoproducto.Size = new System.Drawing.Size(114, 21);
            this.cmbtipoproducto.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Tipo de Poducto :";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(126, 438);
            this.txtstock.Margin = new System.Windows.Forms.Padding(2);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(114, 20);
            this.txtstock.TabIndex = 36;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(126, 403);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(114, 20);
            this.txtprecio.TabIndex = 35;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 368);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(114, 20);
            this.txtNombre.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 445);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 410);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Precio :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 375);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 508);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(378, 25);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // PRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 545);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbtipoproducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvProducto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnCerrar);
            this.Name = "PRODUCTOS";
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.PRODUCTO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtgvProducto;
        private System.Windows.Forms.ComboBox cmbtipoproducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
    }
}