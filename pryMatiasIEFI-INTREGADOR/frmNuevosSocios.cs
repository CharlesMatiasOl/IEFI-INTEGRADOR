using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace pryMatiasIEFI_INTREGADOR
{
    public partial class frmNuevosSocios : Form
    {
        public frmNuevosSocios()
        {
            InitializeComponent();
        }

        private void frmNuevosSocios_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // aca le pido que agrege los datos en la base de datos 

            clsSocio agregado = new clsSocio();// Variable que ultilizamos
            agregado.Dni_Socio = Convert.ToInt32(mskDni.Text);
            agregado.Nombre_Apellido = txtNombre.Text;
            agregado.Direccion = txtDireccion.Text;
            agregado.CodigoSucursal = Convert.ToInt32(mskCodigoSucursal.Text);
            agregado.CodigoActividad = Convert.ToInt32(mskActividad.Text);
            agregado.Saldo = Convert.ToInt32(mskSaldo.Text);
            agregado.RegistroClientes();
             
            
        }

        
        

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void mskDni_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mskCodigoSucursal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void mskActividad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void mskSaldo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}
