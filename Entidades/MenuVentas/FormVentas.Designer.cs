namespace MenuVentas
{
    partial class FormVentas
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
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.boxProducto = new System.Windows.Forms.ComboBox();
            this.txtboxApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblCantida = new System.Windows.Forms.Label();
            this.txtboxCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.Location = new System.Drawing.Point(91, 4);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(177, 26);
            this.txtboxNombre.TabIndex = 0;
            // 
            // boxProducto
            // 
            this.boxProducto.FormattingEnabled = true;
            this.boxProducto.Location = new System.Drawing.Point(91, 105);
            this.boxProducto.Name = "boxProducto";
            this.boxProducto.Size = new System.Drawing.Size(177, 28);
            this.boxProducto.TabIndex = 1;
            this.boxProducto.SelectedIndexChanged += new System.EventHandler(this.boxProducto_SelectedIndexChanged);
            // 
            // txtboxApellido
            // 
            this.txtboxApellido.Location = new System.Drawing.Point(91, 53);
            this.txtboxApellido.Name = "txtboxApellido";
            this.txtboxApellido.Size = new System.Drawing.Size(177, 26);
            this.txtboxApellido.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 7);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 56);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(12, 108);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(73, 20);
            this.lblProducto.TabIndex = 5;
            this.lblProducto.Text = "Producto";
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(136, 214);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(95, 39);
            this.btnVenta.TabIndex = 6;
            this.btnVenta.Text = "Aceptar";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 214);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 39);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(259, 214);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 39);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblCantida
            // 
            this.lblCantida.AutoSize = true;
            this.lblCantida.Location = new System.Drawing.Point(12, 159);
            this.lblCantida.Name = "lblCantida";
            this.lblCantida.Size = new System.Drawing.Size(73, 20);
            this.lblCantida.TabIndex = 9;
            this.lblCantida.Text = "Cantidad";
            // 
            // txtboxCantidad
            // 
            this.txtboxCantidad.Location = new System.Drawing.Point(91, 159);
            this.txtboxCantidad.Name = "txtboxCantidad";
            this.txtboxCantidad.Size = new System.Drawing.Size(177, 26);
            this.txtboxCantidad.TabIndex = 10;
            this.txtboxCantidad.TextChanged += new System.EventHandler(this.txtboxCantidad_TextChanged);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(377, 428);
            this.Controls.Add(this.txtboxCantidad);
            this.Controls.Add(this.lblCantida);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtboxApellido);
            this.Controls.Add(this.boxProducto);
            this.Controls.Add(this.txtboxNombre);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.ComboBox boxProducto;
        private System.Windows.Forms.TextBox txtboxApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblCantida;
        private System.Windows.Forms.TextBox txtboxCantidad;
    }
}

