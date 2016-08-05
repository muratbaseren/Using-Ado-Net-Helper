using AdoNetHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingAdoNetHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            Database db = new Database("connection_string");

            //db.RunQuery("INSERT INTO Tablom VALUES(@param1, @param2)", null);

            db.RunQuery("INSERT INTO Tablom VALUES(@param1, @param2)",
                new SqlParameter("@param1", "Murat"),
                new SqlParameter("@param2", "Başeren"));
        }

        private void btnGetTable_Click(object sender, EventArgs e)
        {
            Database db = new Database("connection_string");

            DataTable dt = db.GetTable("SELECT * FROM Tablom WHERE Adi=@param1",
                new SqlParameter("@param1", "Murat"));
        }

        private void btnRunProc_Click(object sender, EventArgs e)
        {
            Database db = new Database("connection_string");

            // Geriye tablo dönmüyorsa..
            db.RunProc("Procedure_Name", 
                new SqlParameter("@param1", "Murat"),
                new SqlParameter("@param2", "Başeren"));

            // Geriye tablo dönüyorsa..
            DataTable dt = db.RunProc("Procedure_Name", 
                new SqlParameter("@param1", "Murat"),
                new SqlParameter("@param2", "Başeren"));
        }
    }
}
