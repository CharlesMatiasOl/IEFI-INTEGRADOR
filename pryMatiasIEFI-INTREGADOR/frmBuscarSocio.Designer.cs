namespace pryMatiasIEFI_INTREGADOR
{
    partial class frmBuscarSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarSocio));
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gpDatos = new System.Windows.Forms.GroupBox();
            this.txtCodigoActividad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mskDni = new System.Windows.Forms.MaskedTextBox();
            this.mskSaldo = new System.Windows.Forms.MaskedTextBox();
            this.mskCodigoSucursal = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblCodigoAct = new System.Windows.Forms.Label();
            this.lblCodigoSuc = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDnii = new System.Windows.Forms.Label();
            this.gpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(164, 288);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 26);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(248, 288);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 26);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(234, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 26);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gpDatos
            // 
            this.gpDatos.Controls.Add(this.txtCodigoActividad);
            this.gpDatos.Controls.Add(this.txtDireccion);
            this.gpDatos.Controls.Add(this.mskDni);
            this.gpDatos.Controls.Add(this.mskSaldo);
            this.gpDatos.Controls.Add(this.mskCodigoSucursal);
            this.gpDatos.Controls.Add(this.txtNombre);
            this.gpDatos.Controls.Add(this.lblSaldo);
            this.gpDatos.Controls.Add(this.lblCodigoAct);
            this.gpDatos.Controls.Add(this.lblCodigoSuc);
            this.gpDatos.Controls.Add(this.lblNombre);
            this.gpDatos.Controls.Add(this.lbldireccion);
            this.gpDatos.Controls.Add(this.lblDni);
            this.gpDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDatos.Location = new System.Drawing.Point(12, 39);
            this.gpDatos.Name = "gpDatos";
            this.gpDatos.Size = new System.Drawing.Size(311, 243);
            this.gpDatos.TabIndex = 27;
            this.gpDatos.TabStop = false;
            this.gpDatos.Text = "Datos del cliente";
            // 
            // txtCodigoActividad
            // 
            this.txtCodigoActividad.Location = new System.Drawing.Point(153, 177);
            this.txtCodigoActividad.Name = "txtCodigoActividad";
            this.txtCodigoActividad.Size = new System.Drawing.Size(144, 21);
            this.txtCodigoActividad.TabIndex = 22;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(153, 98);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(144, 21);
            this.txtDireccion.TabIndex = 21;
            // 
            // mskDni
            // 
            this.mskDni.Location = new System.Drawing.Point(153, 25);
            this.mskDni.Name = "mskDni";
            this.mskDni.Size = new System.Drawing.Size(144, 21);
            this.mskDni.TabIndex = 20;
            this.mskDni.ValidatingType = typeof(int);
            // 
            // mskSaldo
            // 
            this.mskSaldo.Location = new System.Drawing.Point(152, 212);
            this.mskSaldo.Name = "mskSaldo";
            this.mskSaldo.Size = new System.Drawing.Size(145, 21);
            this.mskSaldo.TabIndex = 19;
            // 
            // mskCodigoSucursal
            // 
            this.mskCodigoSucursal.Location = new System.Drawing.Point(153, 139);
            this.mskCodigoSucursal.Name = "mskCodigoSucursal";
            this.mskCodigoSucursal.Size = new System.Drawing.Size(144, 21);
            this.mskCodigoSucursal.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(153, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 21);
            this.txtNombre.TabIndex = 15;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(0, 215);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(42, 15);
            this.lblSaldo.TabIndex = 13;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblCodigoAct
            // 
            this.lblCodigoAct.AutoSize = true;
            this.lblCodigoAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAct.Location = new System.Drawing.Point(0, 177);
            this.lblCodigoAct.Name = "lblCodigoAct";
            this.lblCodigoAct.Size = new System.Drawing.Size(120, 15);
            this.lblCodigoAct.TabIndex = 12;
            this.lblCodigoAct.Text = "Codigo de actividad :";
            // 
            // lblCodigoSuc
            // 
            this.lblCodigoSuc.AutoSize = true;
            this.lblCodigoSuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoSuc.Location = new System.Drawing.Point(0, 139);
            this.lblCodigoSuc.Name = "lblCodigoSuc";
            this.lblCodigoSuc.Size = new System.Drawing.Size(98, 15);
            this.lblCodigoSuc.TabIndex = 11;
            this.lblCodigoSuc.Text = "Codigo sucursal:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(0, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 15);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(0, 101);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(62, 15);
            this.lbldireccion.TabIndex = 9;
            this.lbldireccion.Text = "Direccion:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(0, 25);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(31, 15);
            this.lblDni.TabIndex = 8;
            this.lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(72, 12);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(156, 20);
            this.txtDni.TabIndex = 23;
            // 
            // lblDnii
            // 
            this.lblDnii.AutoSize = true;
            this.lblDnii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDnii.Location = new System.Drawing.Point(38, 13);
            this.lblDnii.Name = "lblDnii";
            this.lblDnii.Size = new System.Drawing.Size(28, 15);
            this.lblDnii.TabIndex = 21;
            this.lblDnii.Text = "DNI";
            // 
            // frmBuscarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 322);
            this.Controls.Add(this.gpDatos);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDnii);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarSocio";
            this.Text = "Buscar socio";
            this.Load += new System.EventHandler(this.frmBuscarSocio_Load);
            this.gpDatos.ResumeLayout(false);
            this.gpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gpDatos;
        private System.Windows.Forms.TextBox txtCodigoActividad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox mskDni;
        private System.Windows.Forms.MaskedTextBox mskSaldo;
        private System.Windows.Forms.MaskedTextBox mskCodigoSucursal;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblCodigoAct;
        private System.Windows.Forms.Label lblCodigoSuc;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDnii;
    }
}