namespace pryMatiasIEFI_INTREGADOR
{
    partial class frmListadoDeTodosSocios
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
            this.cmdListar = new System.Windows.Forms.Button();
            this.dgvListadoSocios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(370, 382);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(103, 23);
            this.cmdListar.TabIndex = 3;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            // 
            // dgvListadoSocios
            // 
            this.dgvListadoSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoSocios.Location = new System.Drawing.Point(12, 12);
            this.dgvListadoSocios.Name = "dgvListadoSocios";
            this.dgvListadoSocios.ReadOnly = true;
            this.dgvListadoSocios.Size = new System.Drawing.Size(461, 364);
            this.dgvListadoSocios.TabIndex = 2;
            // 
            // frmListadoDeTodosSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 415);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.dgvListadoSocios);
            this.Name = "frmListadoDeTodosSocios";
            this.Text = "frmListadoDeTodosSocios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoSocios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.DataGridView dgvListadoSocios;
    }
}