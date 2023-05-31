using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AccesoaBaseDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbCommand ComandoBD = null;
        OleDbConnection ConexionBD = null;
        OleDbDataReader LectorBD = null;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionBD = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BIBLIO.accdb; Persist Security Info = False");

            ConexionBD.Open();

            MessageBox.Show("conexion exitosa");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComandoBD = new OleDbCommand();

            ComandoBD.Connection = ConexionBD;
            ComandoBD.CommandType = CommandType.TableDirect;
            ComandoBD.CommandText = "TITULO";

            LectorBD = ComandoBD.ExecuteReader();
            while (LectorBD.Read())
            {
                dgvDatos.Rows.Add(LectorBD[0]);
            

           }

         }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
