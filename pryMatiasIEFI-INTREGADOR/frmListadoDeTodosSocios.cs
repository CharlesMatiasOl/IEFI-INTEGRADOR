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
    public partial class frmListadoDeTodosSocios : Form
    {
        public frmListadoDeTodosSocios()
        {
            InitializeComponent();
        }

        private void frmListadoDeTodosSocios_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsSocio listar = new clsSocio();
            listar.Listar(dgvListadoSocios);
        }
    }
}
