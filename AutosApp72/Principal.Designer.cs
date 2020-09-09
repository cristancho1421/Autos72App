namespace AutosApp72
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxRevision = new System.Windows.Forms.PictureBox();
            this.pictureBoxVentas = new System.Windows.Forms.PictureBox();
            this.pictureBoxInventario = new System.Windows.Forms.PictureBox();
            this.pictureBoxVehiculo = new System.Windows.Forms.PictureBox();
            this.pictureBoxClientes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRevision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(594, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Revisiones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(859, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inventario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1122, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vehiculos";
            // 
            // pictureBoxRevision
            // 
            this.pictureBoxRevision.Image = global::AutosApp72.Properties.Resources.Revision1;
            this.pictureBoxRevision.InitialImage = global::AutosApp72.Properties.Resources.Revision1;
            this.pictureBoxRevision.Location = new System.Drawing.Point(537, 12);
            this.pictureBoxRevision.Name = "pictureBoxRevision";
            this.pictureBoxRevision.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxRevision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRevision.TabIndex = 4;
            this.pictureBoxRevision.TabStop = false;
            this.pictureBoxRevision.Click += new System.EventHandler(this.pictureBoxRevision_Click);
            // 
            // pictureBoxVentas
            // 
            this.pictureBoxVentas.Image = global::AutosApp72.Properties.Resources.Venta1;
            this.pictureBoxVentas.Location = new System.Drawing.Point(275, 12);
            this.pictureBoxVentas.Name = "pictureBoxVentas";
            this.pictureBoxVentas.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxVentas.TabIndex = 3;
            this.pictureBoxVentas.TabStop = false;
            this.pictureBoxVentas.Click += new System.EventHandler(this.pictureBoxVentas_Click);
            // 
            // pictureBoxInventario
            // 
            this.pictureBoxInventario.Image = global::AutosApp72.Properties.Resources.Inventario1;
            this.pictureBoxInventario.Location = new System.Drawing.Point(799, 12);
            this.pictureBoxInventario.Name = "pictureBoxInventario";
            this.pictureBoxInventario.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxInventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxInventario.TabIndex = 2;
            this.pictureBoxInventario.TabStop = false;
            this.pictureBoxInventario.Click += new System.EventHandler(this.pictureBoxInventario_Click);
            // 
            // pictureBoxVehiculo
            // 
            this.pictureBoxVehiculo.Image = global::AutosApp72.Properties.Resources.Vehiculo1;
            this.pictureBoxVehiculo.Location = new System.Drawing.Point(1061, 12);
            this.pictureBoxVehiculo.Name = "pictureBoxVehiculo";
            this.pictureBoxVehiculo.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxVehiculo.TabIndex = 1;
            this.pictureBoxVehiculo.TabStop = false;
            this.pictureBoxVehiculo.Click += new System.EventHandler(this.pictureBoxVehiculo_Click);
            // 
            // pictureBoxClientes
            // 
            this.pictureBoxClientes.ErrorImage = null;
            this.pictureBoxClientes.Image = global::AutosApp72.Properties.Resources.Cliente;
            this.pictureBoxClientes.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxClientes.Name = "pictureBoxClientes";
            this.pictureBoxClientes.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxClientes.TabIndex = 0;
            this.pictureBoxClientes.TabStop = false;
            this.pictureBoxClientes.Click += new System.EventHandler(this.pictureBoxClientes_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1327, 324);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxRevision);
            this.Controls.Add(this.pictureBoxVentas);
            this.Controls.Add(this.pictureBoxInventario);
            this.Controls.Add(this.pictureBoxVehiculo);
            this.Controls.Add(this.pictureBoxClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autos 72 - Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRevision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClientes;
        private System.Windows.Forms.PictureBox pictureBoxVehiculo;
        private System.Windows.Forms.PictureBox pictureBoxInventario;
        private System.Windows.Forms.PictureBox pictureBoxVentas;
        private System.Windows.Forms.PictureBox pictureBoxRevision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

