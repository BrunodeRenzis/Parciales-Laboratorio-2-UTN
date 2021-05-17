
namespace FrmTest
{
    partial class frmTester
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
            this.btnVender = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstStock = new System.Windows.Forms.ListBox();
            this.rtbInforme = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(12, 292);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(384, 49);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(12, 347);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(384, 49);
            this.btnInforme.TabIndex = 1;
            this.btnInforme.Text = "Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 402);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(384, 49);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstStock
            // 
            this.lstStock.FormattingEnabled = true;
            this.lstStock.ItemHeight = 16;
            this.lstStock.Location = new System.Drawing.Point(0, 0);
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(396, 292);
            this.lstStock.TabIndex = 3;
            // 
            // rtbInforme
            // 
            this.rtbInforme.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtbInforme.Location = new System.Drawing.Point(402, 0);
            this.rtbInforme.Name = "rtbInforme";
            this.rtbInforme.Size = new System.Drawing.Size(400, 470);
            this.rtbInforme.TabIndex = 4;
            this.rtbInforme.Text = "";
            // 
            // frmTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.rtbInforme);
            this.Controls.Add(this.lstStock);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnVender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testear App De Bruno de Renzis";
            this.Load += new System.EventHandler(this.FrmTester_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstStock;
        private System.Windows.Forms.RichTextBox rtbInforme;
    }
}

