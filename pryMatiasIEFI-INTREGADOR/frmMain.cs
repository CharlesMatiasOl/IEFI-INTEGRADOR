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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevosSocios objVentanaNuevosClientes = new frmNuevosSocios();
            objVentanaNuevosClientes.ShowDialog();
        }

        private void buscarSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarSocio objVentanaBuscarSocio = new frmBuscarSocio();
            objVentanaBuscarSocio.ShowDialog();
        }

        private void consultaSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoDeSocios objVentana = new frmListadoDeSocios();
            objVentana.ShowDialog();
        }

        private void consultaSocioPorSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSucursal objVentana = new frmListadoSucursal();
            objVentana.ShowDialog();
        }

        private void consultaTodosSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoDeTodosSocios objVentana = new frmListadoDeTodosSocios();
            objVentana.ShowDialog();
        }

        private void consultaPorActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoActividad objVentana = new frmListadoActividad();
            objVentana.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
