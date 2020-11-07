namespace Equipo3
{
    partial class FORMAS_PAGO
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
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtFormaPago = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtgvFormasPago = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFormasPago)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(99, 57);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(114, 20);
            this.txtDescuento.TabIndex = 41;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(108, 135);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(58, 27);
            this.btnVolver.TabIndex = 38;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtFormaPago
            // 
            this.txtFormaPago.Location = new System.Drawing.Point(99, 28);
            this.txtFormaPago.Margin = new System.Windows.Forms.Padding(2);
            this.txtFormaPago.Name = "txtFormaPago";
            this.txtFormaPago.Size = new System.Drawing.Size(114, 20);
            this.txtFormaPago.TabIndex = 36;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(13, 64);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(82, 13);
            this.lblDescuento.TabIndex = 32;
            this.lblDescuento.Text = "Descuento (%): ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 35);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 13);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Forma de pago: ";
            // 
            // dtgvFormasPago
            // 
            this.dtgvFormasPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFormasPago.Location = new System.Drawing.Point(270, 12);
            this.dtgvFormasPago.Name = "dtgvFormasPago";
            this.dtgvFormasPago.Size = new System.Drawing.Size(275, 150);
            this.dtgvFormasPago.TabIndex = 42;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(140, 98);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(125, 30);
            this.btnBorrar.TabIndex = 43;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(11, 98);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 30);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FORMAS_PAGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 174);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dtgvFormasPago);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtFormaPago);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblNombre);
            this.Name = "FORMAS_PAGO";
            this.Text = "Formas de Pago";
            this.Load += new System.EventHandler(this.FORMAS_PAGO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFormasPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtFormaPago;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dtgvFormasPago;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
    }
}