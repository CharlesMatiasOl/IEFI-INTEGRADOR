namespace pryMatiasIEFI_INTREGADOR
{
    partial class frmNuevosSocios
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
            this.gpNuevosocio = new System.Windows.Forms.GroupBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.mskSaldo = new System.Windows.Forms.MaskedTextBox();
            this.mskDni = new System.Windows.Forms.MaskedTextBox();
            this.lblNombreyApellido = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblDniSocio = new System.Windows.Forms.Label();
            this.mskActividad = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mskCodigoSucursal = new System.Windows.Forms.MaskedTextBox();
            this.lblCodigodeSucursal = new System.Windows.Forms.Label();
            this.lblDirrecion = new System.Windows.Forms.Label();
            this.gpNuevosocio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpNuevosocio
            // 
            this.gpNuevosocio.Controls.Add(this.btnAgregarCliente);
            this.gpNuevosocio.Controls.Add(this.mskSaldo);
            this.gpNuevosocio.Controls.Add(this.mskDni);
            this.gpNuevosocio.Controls.Add(this.lblNombreyApellido);
            this.gpNuevosocio.Controls.Add(this.lblSaldo);
            this.gpNuevosocio.Controls.Add(this.lblDniSocio);
            this.gpNuevosocio.Controls.Add(this.mskActividad);
            this.gpNuevosocio.Controls.Add(this.txtNombre);
            this.gpNuevosocio.Controls.Add(this.lblActividad);
            this.gpNuevosocio.Controls.Add(this.txtDireccion);
            this.gpNuevosocio.Controls.Add(this.mskCodigoSucursal);
            this.gpNuevosocio.Controls.Add(this.lblCodigodeSucursal);
            this.gpNuevosocio.Controls.Add(this.lblDirrecion);
            this.gpNuevosocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpNuevosocio.Location = new System.Drawing.Point(12, 12);
            this.gpNuevosocio.Name = "gpNuevosocio";
            this.gpNuevosocio.Size = new System.Drawing.Size(366, 269);
            this.gpNuevosocio.TabIndex = 1;
            this.gpNuevosocio.TabStop = false;
            this.gpNuevosocio.Text = "Nuevo socio";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(278, 238);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(88, 25);
            this.btnAgregarCliente.TabIndex = 24;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // mskSaldo
            // 
            this.mskSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSaldo.Location = new System.Drawing.Point(136, 231);
            this.mskSaldo.Mask = "0000000000";
            this.mskSaldo.Name = "mskSaldo";
            this.mskSaldo.Size = new System.Drawing.Size(108, 21);
            this.mskSaldo.TabIndex = 23;
            // 
            // mskDni
            // 
            this.mskDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDni.Location = new System.Drawing.Point(136, 67);
            this.mskDni.Mask = "0000000000";
            this.mskDni.Name = "mskDni";
            this.mskDni.Size = new System.Drawing.Size(108, 21);
            this.mskDni.TabIndex = 18;
            // 
            // lblNombreyApellido
            // 
            this.lblNombreyApellido.AutoSize = true;
            this.lblNombreyApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreyApellido.Location = new System.Drawing.Point(6, 29);
            this.lblNombreyApellido.Name = "lblNombreyApellido";
            this.lblNombreyApellido.Size = new System.Drawing.Size(107, 15);
            this.lblNombreyApellido.TabIndex = 13;
            this.lblNombreyApellido.Text = "Nombre y apellido";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(6, 234);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(42, 15);
            this.lblSaldo.TabIndex = 17;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblDniSocio
            // 
            this.lblDniSocio.AutoSize = true;
            this.lblDniSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniSocio.Location = new System.Drawing.Point(6, 70);
            this.lblDniSocio.Name = "lblDniSocio";
            this.lblDniSocio.Size = new System.Drawing.Size(61, 15);
            this.lblDniSocio.TabIndex = 12;
            this.lblDniSocio.Text = "Dni socio:";
            // 
            // mskActividad
            // 
            this.mskActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskActividad.Location = new System.Drawing.Point(136, 190);
            this.mskActividad.Mask = "0";
            this.mskActividad.Name = "mskActividad";
            this.mskActividad.Size = new System.Drawing.Size(108, 21);
            this.mskActividad.TabIndex = 22;
            this.mskActividad.ValidatingType = typeof(int);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(136, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 21);
            this.txtNombre.TabIndex = 19;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(6, 193);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(58, 15);
            this.lblActividad.TabIndex = 16;
            this.lblActividad.Text = "Actividad:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(136, 108);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(108, 21);
            this.txtDireccion.TabIndex = 20;
            // 
            // mskCodigoSucursal
            // 
            this.mskCodigoSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCodigoSucursal.Location = new System.Drawing.Point(136, 149);
            this.mskCodigoSucursal.Mask = "0";
            this.mskCodigoSucursal.Name = "mskCodigoSucursal";
            this.mskCodigoSucursal.Size = new System.Drawing.Size(108, 21);
            this.mskCodigoSucursal.TabIndex = 21;
            this.mskCodigoSucursal.ValidatingType = typeof(int);
            // 
            // lblCodigodeSucursal
            // 
            this.lblCodigodeSucursal.AutoSize = true;
            this.lblCodigodeSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigodeSucursal.Location = new System.Drawing.Point(6, 152);
            this.lblCodigodeSucursal.Name = "lblCodigodeSucursal";
            this.lblCodigodeSucursal.Size = new System.Drawing.Size(115, 15);
            this.lblCodigodeSucursal.TabIndex = 15;
            this.lblCodigodeSucursal.Text = "Codigo de sucursal:";
            // 
            // lblDirrecion
            // 
            this.lblDirrecion.AutoSize = true;
            this.lblDirrecion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirrecion.Location = new System.Drawing.Point(6, 111);
            this.lblDirrecion.Name = "lblDirrecion";
            this.lblDirrecion.Size = new System.Drawing.Size(62, 15);
            this.lblDirrecion.TabIndex = 14;
            this.lblDirrecion.Text = "Direccion:";
            // 
            // frmNuevosSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 292);
            this.Controls.Add(this.gpNuevosocio);
            this.Name = "frmNuevosSocios";
            this.Text = "frmNuevosSocios";
            this.Load += new System.EventHandler(this.frmNuevosSocios_Load);
            this.gpNuevosocio.ResumeLayout(false);
            this.gpNuevosocio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpNuevosocio;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.MaskedTextBox mskSaldo;
        private System.Windows.Forms.MaskedTextBox mskDni;
        private System.Windows.Forms.Label lblNombreyApellido;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblDniSocio;
        private System.Windows.Forms.MaskedTextBox mskActividad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox mskCodigoSucursal;
        private System.Windows.Forms.Label lblCodigodeSucursal;
        private System.Windows.Forms.Label lblDirrecion;
    }
}