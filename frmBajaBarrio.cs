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
    public partial class frmBajaBarrio : Form
    {
        string ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.mdb";
        OleDbConnection conexion = new OleDbConnection();
        public frmBajaBarrio()
        {
            InitializeComponent();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string barrio = lstBarrio.Text;
            conexion.ConnectionString = ruta;

            string delete = "DELETE FROM Barrio WHERE Detalle_Barrio='" + barrio + "'";
            OleDbCommand cmd = new OleDbCommand(delete, conexion);
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Barrio Eliminado Existosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lstBarrio.SelectedIndex = -1;
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstBarrio_TextChanged(object sender, EventArgs e)
        {
            if (lstBarrio.Text != string.Empty)
            {
                cmdEliminar.Enabled = true;
            }
            else
            {
                cmdEliminar.Enabled = false;
            }
        }

        private void frmBajaBarrio_Load(object sender, EventArgs e)
        {
            cmdEliminar.Enabled = false;
            agregarLista();
            lstBarrio.SelectedIndex = -1;
        }
        
        private void agregarLista()
        {
            conexion.ConnectionString = ruta;
            conexion.Open();

            DataTable tabla = new DataTable();
            string select = "Select * From Barrio";
            OleDbCommand cmd = new OleDbCommand(select, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.SelectCommand = cmd;
            da.Fill(tabla);
            lstBarrio.DisplayMember = "Detalle_Barrio";
            lstBarrio.ValueMember = "Codigo_Barrio";
            lstBarrio.DataSource = tabla;

            conexion.Close();
        }
    }
}
