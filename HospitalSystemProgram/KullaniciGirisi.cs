using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace HospitalSystemProgram
{
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }

        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = "Data Source=(DESCRIPTION = " +
"(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
"(CONNECT_DATA =" +
 "(SERVER = DEDICATED)" +
  "(SERVICE_NAME = oracle.murat.com)" +
")" +
");User Id = MURAT;password=dal;";
            con.Open();
        }
        //selam
    }
}
