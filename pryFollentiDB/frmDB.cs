using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;


namespace pryFollentiDB
{

   
    public partial class Form1 : Form
    {
        OleDbConnection conexionDB;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            conexionDB = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Alumno\\source\\repos\\pryFollentiDB\\pryFollentiDB\\base\\EL_CLUB.accdb");
            conexionDB.Open();

            //si aparece el error que el proveedor no esta registaado en el euqipo ir a propertities--> compilacion ---> plataforma de destino x64


            lblResultado.Text = "conectado a la base";
            lblResultado.BackColor = Color.Green;

         }
    }
}
