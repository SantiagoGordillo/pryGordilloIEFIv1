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
    public partial class frmClientesTotal : Form
    {
        string ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.mdb";
        OleDbConnection conexion = new OleDbConnection();

        public frmClientesTotal()
        {
            InitializeComponent();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.ConnectionString = ruta;
                conexion.Open();

                string select = @"SELECT * FROM Socio";
                OleDbCommand cmd = new OleDbCommand(select, conexion);
                OleDbDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Dni_Socio");
                dt.Columns.Add("Nombre_Apellido");

                while (reader.Read())
                {
                    DataRow row = dt.NewRow();
                    row["Dni_Socio"] = reader["Dni_Socio"];
                    row["Nombre_Apellido"] = reader["Nombre_Apellido"];
                    dt.Rows.Add(row);
                }

                dgvClientes.DataSource = dt;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
