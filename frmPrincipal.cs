using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGordilloIEFIv1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsiAgregar_Click(object sender, EventArgs e)
        {
            new frmAgregarCliente().ShowDialog();
        }

        private void tsiModificar_Click(object sender, EventArgs e)
        {
            new frmBusqueda().ShowDialog();
        }

        private void tsiListadoClientes_CLick(object sender, EventArgs e)
        {
            new frmClientesTotal().ShowDialog();
        }

        private void tsiListadoSaldoClientes_Click(object sender, EventArgs e)
        {
            new frmClientesSaldo().ShowDialog();
        }

        private void tsiListadoClientesBarrio_Click(object sender, EventArgs e)
        {
            new frmClientesBarrio().ShowDialog();
        }

        private void tsiListadoClientesActividad_Click(object sender, EventArgs e)
        {
            new frmClientesActividad().ShowDialog();
        }

        private void tsiListadoClientesDeudores_Click(object sender, EventArgs e)
        {
            new frmClientesDeudores().ShowDialog();
        }

        private void tsiConsultaCliente_Click(object sender, EventArgs e)
        {
            new frmConsultaUnCliente().ShowDialog();
        }

        private void tsiAgregarBarrio_Click(object sender, EventArgs e)
        {
            new frmAgregarBarrio().ShowDialog();
        }

        private void tsiEliminarbarrio_Click(object sender, EventArgs e)
        {
            new frmBajaBarrio().ShowDialog();
        }

        private void tsiAgregarActividad_Click(object sender, EventArgs e)
        {
            new frmAgregarActividad().ShowDialog();
        }

        private void tsiEliminarActividad_Click(object sender, EventArgs e)
        {
            new frmBajaActividad().ShowDialog();
        }
    }
}
