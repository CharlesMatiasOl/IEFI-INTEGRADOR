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
    public partial class frmListadoDeSocios : Form
    {
        public frmListadoDeSocios()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsSocio objCliente = new clsSocio();//Variable que utilizamos 
            objCliente.ListarSocios(dgvGrilla); // Nombre de la grilla que utilizamos 
            lblTotalSueldos.Text = objCliente.TotalSaldo.ToString();
            lblInscripciones.Text = objCliente.cantidadSocios.ToString();
            lblPromedioSaldos.Text = objCliente.promedioSaldo.ToString();
        }

        private void frmListadoDeSocios_Load(object sender, EventArgs e)
        {

        }
    }
}
