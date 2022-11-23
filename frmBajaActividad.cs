using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGordilloIEFIv1
{
    public partial class frmBajaActividad : Form
    {
        string ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.mdb";
        OleDbConnection conexion = new OleDbConnection();

        public frmBajaActividad()
        {
            InitializeComponent();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBajaActividad_Load(object sender, EventArgs e)
        {
            cmdEliminar.Enabled = false;
            agregarListas();
            lstActividad.SelectedIndex = -1;
        }

        private void lstActividad_TextChanged(object sender, EventArgs e)
        {
            if(lstActividad.Text != string.Empty)
            {
                cmdEliminar.Enabled = true;
            }
            else
            {
                cmdEliminar.Enabled = false;
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string actividad = lstActividad.Text;
            conexion.ConnectionString = ruta;

            string delete = "DELETE FROM Actividad WHERE Detalle_Actividad='" + actividad + "'";
            OleDbCommand cmd = new OleDbCommand(delete, conexion);
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Actividad Eliminada Existosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lstActividad.SelectedIndex = -1;
        }

        private void agregarListas()
        {
            conexion.ConnectionString = ruta;
            conexion.Open();

            DataTable tablaActividad = new DataTable();
            string selectActividad = "Select * From Actividad";
            OleDbCommand cmdActividad = new OleDbCommand(selectActividad, conexion);
            OleDbDataAdapter daActividad = new OleDbDataAdapter(cmdActividad);
            daActividad.SelectCommand = cmdActividad;
            daActividad.Fill(tablaActividad);
            lstActividad.DisplayMember = "Detalle_Actividad";
            lstActividad.ValueMember = "Codigo_Actividad";
            lstActividad.DataSource = tablaActividad;

            conexion.Close();
        }
    }
}
