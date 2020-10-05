namespace MenuProductos
{
    partial class FormProductos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosConMásDe10UnidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockTotalDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgvProductos = new System.Windows.Forms.DataGridView();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 33);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.verToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.productosToolStripMenuItem.Text = "&Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agregarToolStripMenuItem.Text = "&Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosConMásDe10UnidadesToolStripMenuItem,
            this.todosLosProductosToolStripMenuItem,
            this.stockTotalDeProductosToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verToolStripMenuItem.Text = "&Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // productosConMásDe10UnidadesToolStripMenuItem
            // 
            this.productosConMásDe10UnidadesToolStripMenuItem.Name = "productosConMásDe10UnidadesToolStripMenuItem";
            this.productosConMásDe10UnidadesToolStripMenuItem.Size = new System.Drawing.Size(415, 34);
            this.productosConMásDe10UnidadesToolStripMenuItem.Text = "&Productos con menos de 10 unidades";
            this.productosConMásDe10UnidadesToolStripMenuItem.Click += new System.EventHandler(this.productosConMásDe10UnidadesToolStripMenuItem_Click);
            // 
            // todosLosProductosToolStripMenuItem
            // 
            this.todosLosProductosToolStripMenuItem.Name = "todosLosProductosToolStripMenuItem";
            this.todosLosProductosToolStripMenuItem.Size = new System.Drawing.Size(415, 34);
            this.todosLosProductosToolStripMenuItem.Text = "&Todos los productos";
            this.todosLosProductosToolStripMenuItem.Click += new System.EventHandler(this.todosLosProductosToolStripMenuItem_Click);
            // 
            // stockTotalDeProductosToolStripMenuItem
            // 
            this.stockTotalDeProductosToolStripMenuItem.Name = "stockTotalDeProductosToolStripMenuItem";
            this.stockTotalDeProductosToolStripMenuItem.Size = new System.Drawing.Size(415, 34);
            this.stockTotalDeProductosToolStripMenuItem.Text = "Stock total de productos";
            this.stockTotalDeProductosToolStripMenuItem.Click += new System.EventHandler(this.stockTotalDeProductosToolStripMenuItem_Click);
            // 
            // dtgvProductos
            // 
            this.dtgvProductos.AllowUserToAddRows = false;
            this.dtgvProductos.AllowUserToDeleteRows = false;
            this.dtgvProductos.AllowUserToResizeColumns = false;
            this.dtgvProductos.AllowUserToResizeRows = false;
            this.dtgvProductos.ColumnHeadersHeight = 34;
            this.dtgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvProductos.EnableHeadersVisualStyles = false;
            this.dtgvProductos.Location = new System.Drawing.Point(0, 37);
            this.dtgvProductos.Name = "dtgvProductos";
            this.dtgvProductos.ReadOnly = true;
            this.dtgvProductos.RowHeadersWidth = 62;
            this.dtgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvProductos.RowTemplate.Height = 28;
            this.dtgvProductos.Size = new System.Drawing.Size(800, 400);
            this.dtgvProductos.TabIndex = 2;
            this.dtgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.dtgvProductos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosConMásDe10UnidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosProductosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgvProductos;
        private System.Windows.Forms.ToolStripMenuItem stockTotalDeProductosToolStripMenuItem;
    }
}

