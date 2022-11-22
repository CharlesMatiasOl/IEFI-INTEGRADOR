namespace pryMatiasIEFI_INTREGADOR
{
    partial class frmListadoActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoActividad));
            this.btnListar = new System.Windows.Forms.Button();
            this.gpListadoSuc = new System.Windows.Forms.GroupBox();
            this.dgvListadoActividad = new System.Windows.Forms.DataGridView();
            this.lstActividades = new System.Windows.Forms.ComboBox();
            this.llblSelecione = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpListadoSuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(300, 6);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 27);
            this.btnListar.TabIndex = 17;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // gpListadoSuc
            // 
            this.gpListadoSuc.Controls.Add(this.dgvListadoActividad);
            this.gpListadoSuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpListadoSuc.Location = new System.Drawing.Point(2, 39);
            this.gpListadoSuc.Name = "gpListadoSuc";
            this.gpListadoSuc.Size = new System.Drawing.Size(435, 187);
            this.gpListadoSuc.TabIndex = 16;
            this.gpListadoSuc.TabStop = false;
            this.gpListadoSuc.Text = "Listado de clientes";
            // 
            // dgvListadoActividad
            // 
            this.dgvListadoActividad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvListadoActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoActividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvListadoActividad.Location = new System.Drawing.Point(6, 20);
            this.dgvListadoActividad.Name = "dgvListadoActividad";
            this.dgvListadoActividad.Size = new System.Drawing.Size(423, 162);
            this.dgvListadoActividad.TabIndex = 0;
            // 
            // lstActividades
            // 
            this.lstActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstActividades.FormattingEnabled = true;
            this.lstActividades.Items.AddRange(new object[] {
            "Crossfit",
            "Musculacion",
            "Pilates",
            "Funcional",
            "Boxing",
            "Zumba",
            "Karate"});
            this.lstActividades.Location = new System.Drawing.Point(157, 9);
            this.lstActividades.Name = "lstActividades";
            this.lstActividades.Size = new System.Drawing.Size(125, 23);
            this.lstActividades.TabIndex = 15;
            // 
            // llblSelecione
            // 
            this.llblSelecione.AutoSize = true;
            this.llblSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSelecione.Location = new System.Drawing.Point(23, 12);
            this.llblSelecione.Name = "llblSelecione";
            this.llblSelecione.Size = new System.Drawing.Size(130, 15);
            this.llblSelecione.TabIndex = 14;
            this.llblSelecione.Text = "Seleccione un deporte";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DNI";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Direccion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Saldo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // frmListadoActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 229);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gpListadoSuc);
            this.Controls.Add(this.lstActividades);
            this.Controls.Add(this.llblSelecione);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoActividad";
            this.Text = "Listado por actividad";
            this.Load += new System.EventHandler(this.frmListadoActividad_Load);
            this.gpListadoSuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoActividad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox gpListadoSuc;
        private System.Windows.Forms.DataGridView dgvListadoActividad;
        private System.Windows.Forms.ComboBox lstActividades;
        private System.Windows.Forms.Label llblSelecione;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}