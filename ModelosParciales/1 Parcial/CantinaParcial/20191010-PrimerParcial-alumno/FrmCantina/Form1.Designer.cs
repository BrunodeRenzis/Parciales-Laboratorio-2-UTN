
namespace FrmCantina
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMarca = new System.Windows.Forms.Label();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.txtboxMarca = new System.Windows.Forms.TextBox();
            this.cmbBoxTipoBotella = new System.Windows.Forms.ComboBox();
            this.radioButtonCerveza = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.radioButtonAgua = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.numContenido = new System.Windows.Forms.NumericUpDown();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.barra1 = new ControlCantina.Barra();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(159, 400);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 17);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Click += new System.EventHandler(this.label1_Click);
            // 
            // numCapacidad
            // 
            this.numCapacidad.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numCapacidad.Location = new System.Drawing.Point(162, 480);
            this.numCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Size = new System.Drawing.Size(94, 22);
            this.numCapacidad.TabIndex = 2;
            this.numCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCapacidad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtboxMarca
            // 
            this.txtboxMarca.Location = new System.Drawing.Point(162, 420);
            this.txtboxMarca.Name = "txtboxMarca";
            this.txtboxMarca.Size = new System.Drawing.Size(241, 22);
            this.txtboxMarca.TabIndex = 3;
            this.txtboxMarca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbBoxTipoBotella
            // 
            this.cmbBoxTipoBotella.FormattingEnabled = true;
            this.cmbBoxTipoBotella.Location = new System.Drawing.Point(488, 418);
            this.cmbBoxTipoBotella.Name = "cmbBoxTipoBotella";
            this.cmbBoxTipoBotella.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxTipoBotella.TabIndex = 4;
            this.cmbBoxTipoBotella.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTipoBotella_SelectedIndexChanged);
            // 
            // radioButtonCerveza
            // 
            this.radioButtonCerveza.AutoSize = true;
            this.radioButtonCerveza.Location = new System.Drawing.Point(12, 420);
            this.radioButtonCerveza.Name = "radioButtonCerveza";
            this.radioButtonCerveza.Size = new System.Drawing.Size(81, 21);
            this.radioButtonCerveza.TabIndex = 5;
            this.radioButtonCerveza.TabStop = true;
            this.radioButtonCerveza.Text = "Cerveza";
            this.radioButtonCerveza.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(488, 460);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 50);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // radioButtonAgua
            // 
            this.radioButtonAgua.AutoSize = true;
            this.radioButtonAgua.Location = new System.Drawing.Point(15, 469);
            this.radioButtonAgua.Name = "radioButtonAgua";
            this.radioButtonAgua.Size = new System.Drawing.Size(62, 21);
            this.radioButtonAgua.TabIndex = 7;
            this.radioButtonAgua.TabStop = true;
            this.radioButtonAgua.Text = "Agua";
            this.radioButtonAgua.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "lblBotellaTipo";
            // 
            // numContenido
            // 
            this.numContenido.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numContenido.Location = new System.Drawing.Point(288, 480);
            this.numContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numContenido.Name = "numContenido";
            this.numContenido.Size = new System.Drawing.Size(78, 22);
            this.numContenido.TabIndex = 9;
            this.numContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(285, 460);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(72, 17);
            this.lblContenido.TabIndex = 10;
            this.lblContenido.Text = "Contenido";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(159, 460);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(75, 17);
            this.lblCapacidad.TabIndex = 11;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(12, 0);
            this.barra1.Margin = new System.Windows.Forms.Padding(4);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(547, 363);
            this.barra1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 600);
            this.Controls.Add(this.barra1);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.numContenido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonAgua);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.radioButtonCerveza);
            this.Controls.Add(this.cmbBoxTipoBotella);
            this.Controls.Add(this.txtboxMarca);
            this.Controls.Add(this.numCapacidad);
            this.Controls.Add(this.lblMarca);
            this.Name = "Form1";
            this.Text = "Bruno de Renzis";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.NumericUpDown numCapacidad;
        private System.Windows.Forms.TextBox txtboxMarca;
        private System.Windows.Forms.ComboBox cmbBoxTipoBotella;
        private System.Windows.Forms.RadioButton radioButtonCerveza;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton radioButtonAgua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numContenido;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblCapacidad;
        private ControlCantina.Barra barra1;
    }
}

