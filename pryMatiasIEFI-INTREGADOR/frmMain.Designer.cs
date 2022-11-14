namespace pryMatiasIEFI_INTREGADOR
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaTodosSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaSocioPorSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPorActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(337, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevosClientesToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.consultaToolStripMenuItem.Text = "Registro";
            // 
            // agregarNuevosClientesToolStripMenuItem
            // 
            this.agregarNuevosClientesToolStripMenuItem.Name = "agregarNuevosClientesToolStripMenuItem";
            this.agregarNuevosClientesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.agregarNuevosClientesToolStripMenuItem.Text = "Agregar nuevos clientes";
            this.agregarNuevosClientesToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevosClientesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarSocioToolStripMenuItem,
            this.consultaSocioToolStripMenuItem,
            this.consultaTodosSociosToolStripMenuItem,
            this.consultaSocioPorSucursalToolStripMenuItem,
            this.consultaPorActividadToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.salirToolStripMenuItem.Text = "Consulta";
            // 
            // buscarSocioToolStripMenuItem
            // 
            this.buscarSocioToolStripMenuItem.Name = "buscarSocioToolStripMenuItem";
            this.buscarSocioToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.buscarSocioToolStripMenuItem.Text = "Buscar socio";
            this.buscarSocioToolStripMenuItem.Click += new System.EventHandler(this.buscarSocioToolStripMenuItem_Click);
            // 
            // consultaSocioToolStripMenuItem
            // 
            this.consultaSocioToolStripMenuItem.Name = "consultaSocioToolStripMenuItem";
            this.consultaSocioToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultaSocioToolStripMenuItem.Text = "Consultar socio";
            this.consultaSocioToolStripMenuItem.Click += new System.EventHandler(this.consultaSocioToolStripMenuItem_Click);
            // 
            // consultaTodosSociosToolStripMenuItem
            // 
            this.consultaTodosSociosToolStripMenuItem.Name = "consultaTodosSociosToolStripMenuItem";
            this.consultaTodosSociosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultaTodosSociosToolStripMenuItem.Text = "Consultar todos socios";
            this.consultaTodosSociosToolStripMenuItem.Click += new System.EventHandler(this.consultaTodosSociosToolStripMenuItem_Click);
            // 
            // consultaSocioPorSucursalToolStripMenuItem
            // 
            this.consultaSocioPorSucursalToolStripMenuItem.Name = "consultaSocioPorSucursalToolStripMenuItem";
            this.consultaSocioPorSucursalToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultaSocioPorSucursalToolStripMenuItem.Text = "Consultar por sucursal";
            this.consultaSocioPorSucursalToolStripMenuItem.Click += new System.EventHandler(this.consultaSocioPorSucursalToolStripMenuItem_Click);
            // 
            // consultaPorActividadToolStripMenuItem
            // 
            this.consultaPorActividadToolStripMenuItem.Name = "consultaPorActividadToolStripMenuItem";
            this.consultaPorActividadToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.consultaPorActividadToolStripMenuItem.Text = "Consultar por actividad";
            this.consultaPorActividadToolStripMenuItem.Click += new System.EventHandler(this.consultaPorActividadToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 243);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Sistema";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevosClientesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem buscarSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaTodosSociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaSocioPorSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPorActividadToolStripMenuItem;
    }
}

