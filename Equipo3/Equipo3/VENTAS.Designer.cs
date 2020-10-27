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
            this.lblDisponible = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDisponible)).BeginInit();
            this.gpbxSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(573, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(216, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(350, 415);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(216, 23);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // dtgvDisponible
            // 
            this.dtgvDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDisponible.Location = new System.Drawing.Point(12, 39);
            this.dtgvDisponible.Name = "dtgvDisponible";
            this.dtgvDisponible.Size = new System.Drawing.Size(324, 399);
            this.dtgvDisponible.TabIndex = 2;
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
            this.gpbxSeleccion.Controls.Add(this.lblNombre);
            this.gpbxSeleccion.Controls.Add(this.lblStock);
            this.gpbxSeleccion.Controls.Add(this.lblID);
            this.gpbxSeleccion.Controls.Add(this.lblPrecioU);
            this.gpbxSeleccion.Controls.Add(this.lblTipo);
            this.gpbxSeleccion.Location = new System.Drawing.Point(350, 12);
            this.gpbxSeleccion.Name = "gpbxSeleccion";
            this.gpbxSeleccion.Size = new System.Drawing.Size(438, 144);
            this.gpbxSeleccion.TabIndex = 8;
            this.gpbxSeleccion.TabStop = false;
            this.gpbxSeleccion.Text = "Producto seleccionado";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Location = new System.Drawing.Point(120, 12);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(110, 13);
            this.lblDisponible.TabIndex = 9;
            this.lblDisponible.Text = "Productos disponibles";
            // 
            // VENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.gpbxSeleccion);
            this.Controls.Add(this.dtgvDisponible);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnVolver);
            this.Name = "VENTAS";
            this.Text = "VENTAS - Agregar lista de productos";
            this.Load += new System.EventHandler(this.VENTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDisponible)).EndInit();
            this.gpbxSeleccion.ResumeLayout(false);
            this.gpbxSeleccion.PerformLayout();
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
    }
}