namespace Equipo3
{
    partial class REPORTES
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
            this.dataGridViewreporte = new System.Windows.Forms.DataGridView();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.cmbproducto = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btlborrar = new System.Windows.Forms.Button();
            this.cliente = new System.Windows.Forms.Label();
            this.producto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewreporte)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewreporte
            // 
            this.dataGridViewreporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewreporte.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewreporte.Name = "dataGridViewreporte";
            this.dataGridViewreporte.Size = new System.Drawing.Size(776, 232);
            this.dataGridViewreporte.TabIndex = 0;
            // 
            // cmbcliente
            // 
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(321, 271);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(121, 21);
            this.cmbcliente.TabIndex = 1;
            // 
            // cmbproducto
            // 
            this.cmbproducto.FormattingEnabled = true;
            this.cmbproducto.Location = new System.Drawing.Point(321, 317);
            this.cmbproducto.Name = "cmbproducto";
            this.cmbproducto.Size = new System.Drawing.Size(121, 21);
            this.cmbproducto.TabIndex = 2;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(513, 293);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btlborrar
            // 
            this.btlborrar.Location = new System.Drawing.Point(643, 293);
            this.btlborrar.Name = "btlborrar";
            this.btlborrar.Size = new System.Drawing.Size(75, 23);
            this.btlborrar.TabIndex = 4;
            this.btlborrar.Text = "BORRAR";
            this.btlborrar.UseVisualStyleBackColor = true;
            this.btlborrar.Click += new System.EventHandler(this.btlborrar_Click);
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.Location = new System.Drawing.Point(202, 278);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(52, 13);
            this.cliente.TabIndex = 5;
            this.cliente.Text = "CLIENTE";
            // 
            // producto
            // 
            this.producto.AutoSize = true;
            this.producto.Location = new System.Drawing.Point(205, 324);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(68, 13);
            this.producto.TabIndex = 6;
            this.producto.Text = "PRODUCTO";
            // 
            // REPORTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.producto);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.btlborrar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.cmbproducto);
            this.Controls.Add(this.cmbcliente);
            this.Controls.Add(this.dataGridViewreporte);
            this.Name = "REPORTES";
            this.Text = "REPORTES";
            this.Load += new System.EventHandler(this.REPORTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewreporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewreporte;
        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.ComboBox cmbproducto;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btlborrar;
        private System.Windows.Forms.Label cliente;
        private System.Windows.Forms.Label producto;
    }
}