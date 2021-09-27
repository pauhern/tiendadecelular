namespace Win.tiendadecelulares
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiendaDeCelularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevosCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderCelularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoriosDeCelularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesYQuejasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quejasDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiendaDeCelularesToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.reportesYQuejasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiendaDeCelularesToolStripMenuItem
            // 
            this.tiendaDeCelularesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevosCToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.venderCelularToolStripMenuItem});
            this.tiendaDeCelularesToolStripMenuItem.Name = "tiendaDeCelularesToolStripMenuItem";
            this.tiendaDeCelularesToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.tiendaDeCelularesToolStripMenuItem.Text = "Tienda de Celulares";
            // 
            // nuevosCToolStripMenuItem
            // 
            this.nuevosCToolStripMenuItem.Name = "nuevosCToolStripMenuItem";
            this.nuevosCToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.nuevosCToolStripMenuItem.Text = "Nuevos Celulares";
            this.nuevosCToolStripMenuItem.Click += new System.EventHandler(this.nuevosCToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // venderCelularToolStripMenuItem
            // 
            this.venderCelularToolStripMenuItem.Name = "venderCelularToolStripMenuItem";
            this.venderCelularToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.venderCelularToolStripMenuItem.Text = "Vender Celular";
            this.venderCelularToolStripMenuItem.Click += new System.EventHandler(this.venderCelularToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevosProductosToolStripMenuItem,
            this.accesoriosDeCelularesToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.inventarioToolStripMenuItem.Text = "Reportes";
            // 
            // nuevosProductosToolStripMenuItem
            // 
            this.nuevosProductosToolStripMenuItem.Name = "nuevosProductosToolStripMenuItem";
            this.nuevosProductosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.nuevosProductosToolStripMenuItem.Text = "Reportes de Clientes";
            // 
            // accesoriosDeCelularesToolStripMenuItem
            // 
            this.accesoriosDeCelularesToolStripMenuItem.Name = "accesoriosDeCelularesToolStripMenuItem";
            this.accesoriosDeCelularesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.accesoriosDeCelularesToolStripMenuItem.Text = "Reportes de Proveedores";
            // 
            // reportesYQuejasToolStripMenuItem
            // 
            this.reportesYQuejasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quejasDeClientesToolStripMenuItem});
            this.reportesYQuejasToolStripMenuItem.Name = "reportesYQuejasToolStripMenuItem";
            this.reportesYQuejasToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.reportesYQuejasToolStripMenuItem.Text = "Seguridad";
            this.reportesYQuejasToolStripMenuItem.Click += new System.EventHandler(this.reportesYQuejasToolStripMenuItem_Click);
            // 
            // quejasDeClientesToolStripMenuItem
            // 
            this.quejasDeClientesToolStripMenuItem.Name = "quejasDeClientesToolStripMenuItem";
            this.quejasDeClientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quejasDeClientesToolStripMenuItem.Text = "Login";
            this.quejasDeClientesToolStripMenuItem.Click += new System.EventHandler(this.quejasDeClientesToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 290);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menú Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiendaDeCelularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevosCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venderCelularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevosProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesoriosDeCelularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesYQuejasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quejasDeClientesToolStripMenuItem;
    }
}