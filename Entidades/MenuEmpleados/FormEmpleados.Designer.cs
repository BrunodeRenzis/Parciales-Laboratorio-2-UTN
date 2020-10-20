namespace MenuEmpleados
{
    partial class FormEmpleados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtboxUsuario = new System.Windows.Forms.TextBox();
            this.txtboxContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 455);
            this.panel1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(235, 64);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(84, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "USUARIO";
            // 
            // txtboxUsuario
            // 
            this.txtboxUsuario.Location = new System.Drawing.Point(360, 64);
            this.txtboxUsuario.Name = "txtboxUsuario";
            this.txtboxUsuario.Size = new System.Drawing.Size(211, 26);
            this.txtboxUsuario.TabIndex = 1;
            // 
            // txtboxContraseña
            // 
            this.txtboxContraseña.Location = new System.Drawing.Point(360, 116);
            this.txtboxContraseña.Name = "txtboxContraseña";
            this.txtboxContraseña.Size = new System.Drawing.Size(211, 26);
            this.txtboxContraseña.TabIndex = 3;
            this.txtboxContraseña.TextChanged += new System.EventHandler(this.txtboxContraseña_TextChanged);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(235, 119);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(119, 20);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "CONTRASEÑA";
            this.lblContraseña.Click += new System.EventHandler(this.lblContraseña_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.Window;
            this.btnIngresar.Location = new System.Drawing.Point(300, 180);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(237, 37);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(643, 261);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtboxContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtboxUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Empleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtboxUsuario;
        private System.Windows.Forms.TextBox txtboxContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnIngresar;
    }
}

