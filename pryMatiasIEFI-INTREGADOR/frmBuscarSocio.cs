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
    public partial class frmBuscarSocio : Form
    {
        clsActividad ObjActividad = new clsActividad();
        public frmBuscarSocio()
        {
            InitializeComponent();
        }

        private void frmBuscarSocio_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Int32 DniCliente = Convert.ToInt32(txtDni.Text);
            clsSocio objCliente = new clsSocio();
            objCliente.Buscar(DniCliente);

            if (DniCliente !=0)
            {
                
               
                txtNombre.Text = objCliente.Nombre_Apellido; //Comando que utilizamos para llamar los datos 
                mskDni.Text = objCliente.Dni_Socio.ToString();
                txtDireccion.Text = objCliente.Direccion;
                ObjActividad.BuscarActivid(objCliente.CodigoActividad);
                txtCodigoActividad.Text = ObjActividad.NombreActividad;
                mskCodigoSucursal.Text = objCliente.CodigoSucursal.ToString();
                mskSaldo.Text = objCliente.Saldo.ToString();

            }
            else
            {
                MessageBox.Show("Dni no encontrado");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 DniCliente = Convert.ToInt32(txtDni.Text);
            clsSocio eliminar = new clsSocio();
            eliminar.Dni_Socio = DniCliente;
            eliminar.BajaDeSocios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 dni = (Convert.ToInt32(mskDni.Text));
                string nombre = txtNombre.Text;
                string direccion = txtDireccion.Text;
                Int32 codigoSuc = (Convert.ToInt32(mskCodigoSucursal.Text));
                int codigoAct = Convert.ToInt32(txtCodigoActividad.Text);
                Int32 saldo = (Convert.ToInt32(mskSaldo.Text));
                clsSocio modificar = new clsSocio();
                modificar.Dni_Socio = dni;
                modificar.Nombre_Apellido = nombre;
                modificar.Direccion = direccion;
                modificar.CodigoSucursal = codigoSuc;
                modificar.CodigoActividad = codigoAct;
                modificar.Saldo = saldo;
                modificar.ModificarSocios(dni);

            }
            catch
            {
                MessageBox.Show("Asegurese de ingresar valores numéricos en el campo de actividad.", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            



        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
