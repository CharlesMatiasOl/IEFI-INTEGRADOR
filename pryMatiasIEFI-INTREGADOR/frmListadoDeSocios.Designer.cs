namespace pryMatiasIEFI_INTREGADOR
{
    partial class frmListadoDeSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoDeSocios));
            this.grpConsultaDatos = new System.Windows.Forms.GroupBox();
            this.lblPromedioSaldos = new System.Windows.Forms.Label();
            this.lblTotalSueldos = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblInscripciones = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblTotalsaldo = new System.Windows.Forms.Label();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConsultaDatos
            // 
            this.grpConsultaDatos.Controls.Add(this.lblPromedioSaldos);
            this.grpConsultaDatos.Controls.Add(this.btnListar);
            this.grpConsultaDatos.Controls.Add(this.lblTotalSueldos);
            this.grpConsultaDatos.Controls.Add(this.lblInscripciones);
            this.grpConsultaDatos.Controls.Add(this.label3);
            this.grpConsultaDatos.Controls.Add(this.lblPromedio);
            this.grpConsultaDatos.Controls.Add(this.lblTotalsaldo);
            this.grpConsultaDatos.Controls.Add(this.dgvGrilla);
            this.grpConsultaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsultaDatos.Location = new System.Drawing.Point(11, 10);
            this.grpConsultaDatos.Name = "grpConsultaDatos";
            this.grpConsultaDatos.Size = new System.Drawing.Size(457, 320);
            this.grpConsultaDatos.TabIndex = 3;
            this.grpConsultaDatos.TabStop = false;
            this.grpConsultaDatos.Text = "Consulta de datos";
            // 
            // lblPromedioSaldos
            // 
            this.lblPromedioSaldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioSaldos.Location = new System.Drawing.Point(149, 286);
            this.lblPromedioSaldos.Name = "lblPromedioSaldos";
            this.lblPromedioSaldos.Size = new System.Drawing.Size(148, 25);
            this.lblPromedioSaldos.TabIndex = 11;
            // 
            // lblTotalSueldos
            // 
            this.lblTotalSueldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalSueldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSueldos.Location = new System.Drawing.Point(149, 225);
            this.lblTotalSueldos.Name = "lblTotalSueldos";
            this.lblTotalSueldos.Size = new System.Drawing.Size(148, 25);
            this.lblTotalSueldos.TabIndex = 10;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(375, 286);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(76, 25);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblInscripciones
            // 
            this.lblInscripciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInscripciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscripciones.Location = new System.Drawing.Point(149, 256);
            this.lblInscripciones.Name = "lblInscripciones";
            this.lblInscripciones.Size = new System.Drawing.Size(148, 25);
            this.lblInscripciones.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Inscripciones";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(13, 287);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(61, 15);
            this.lblPromedio.TabIndex = 2;
            this.lblPromedio.Text = "Promedio";
            // 
            // lblTotalsaldo
            // 
            this.lblTotalsaldo.AutoSize = true;
            this.lblTotalsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalsaldo.Location = new System.Drawing.Point(13, 226);
            this.lblTotalsaldo.Name = "lblTotalsaldo";
            this.lblTotalsaldo.Size = new System.Drawing.Size(90, 15);
            this.lblTotalsaldo.TabIndex = 1;
            this.lblTotalsaldo.Text = "Total de saldos";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvGrilla.Location = new System.Drawing.Point(6, 20);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(445, 201);
            this.dgvGrilla.TabIndex = 0;
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
            this.Column2.Width = 203;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Saldo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmListadoDeSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 342);
            this.Controls.Add(this.grpConsultaDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoDeSocios";
            this.Text = "Listado de socios";
            this.Load += new System.EventHandler(this.frmListadoDeSocios_Load);
            this.grpConsultaDatos.ResumeLayout(false);
            this.grpConsultaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpConsultaDatos;
        private System.Windows.Forms.Label lblPromedioSaldos;
        private System.Windows.Forms.Label lblTotalSueldos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblInscripciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblTotalsaldo;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}