
namespace PrimerParcialBrunoDeRenzis
{
    partial class FrmBuscador
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
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rtbPersonaje = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombre.Location = new System.Drawing.Point(7, 49);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(266, 30);
            this.txtBoxNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(3, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(323, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Ingrese el nombre del personaje a buscar:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 85);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 32);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rtbPersonaje
            // 
            this.rtbPersonaje.Location = new System.Drawing.Point(7, 123);
            this.rtbPersonaje.Name = "rtbPersonaje";
            this.rtbPersonaje.Size = new System.Drawing.Size(427, 251);
            this.rtbPersonaje.TabIndex = 3;
            this.rtbPersonaje.Text = "";
            // 
            // FrmBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 386);
            this.Controls.Add(this.rtbPersonaje);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBoxNombre);
            this.Name = "FrmBuscador";
            this.Text = "FrmBuscador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RichTextBox rtbPersonaje;
    }
}