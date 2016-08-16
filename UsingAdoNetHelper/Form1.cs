using AdoNetHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingAdoNetHelper
{
    public partial class Form1 : Form
    {
        // Reading connection string from app.config..
        private string ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseContext"].ConnectionString;

        private AdoNetHelper.Database DB = null;


        public Form1()
        {
            InitializeComponent();

            if (ConnectionString.Contains("*****"))
            {
                MessageBox.Show("Please modify Connection String for yourself in App.config file", "Required modify app.config file", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Application.Exit();
            }

            // Database will be create..
            DatabaseContext db = new DatabaseContext();
            if (db.Database.CreateIfNotExists())
            {
                // Generate sample data...
                MyDatabaseInitializer.GenerateSampleData(db);
            }

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create instance for Database object.
            DB = new Database(ConnectionString);
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            // RunQuery method runs queries. Return affected row count value.

            int result =
                DB.RunQuery("INSERT INTO Books(Name, Author, Description, Price) VALUES(@Name, @Author, @Desc, @Price)",
                    new ParamItem() { ParamName = "@Name", ParamValue = "Jungle Book" },
                    new ParamItem() { ParamName = "@Author", ParamValue = "K. Murat Başeren" },
                    new ParamItem() { ParamName = "@Desc", ParamValue = "About book subject" },
                    new ParamItem() { ParamName = "@Price", ParamValue = 25 });

            // Shows affected row count in output window.
            Debug.WriteLine("Affected row(s) count (RunQuery - Insert) : " + result);
        }

        private void btnGetTable_Click(object sender, EventArgs e)
        {
            // Get Datatable with sql datas
            // I use generic ParamItem<T>

            DataTable dt =
                DB.GetTable("SELECT Id, Name, Author, Description, Price FROM Books WHERE Price > @PriceVal",
                    new ParamItem() { ParamName = "@PriceVal", ParamValue = 25m });

            // Shows rows count in output window.
            Debug.WriteLine("Result table row count(RunQuery - GetTable) : " + dt.Rows.Count);
        }

        private void btnRunProc_Click(object sender, EventArgs e)
        {
            // Add MyStoredProc1 and MyStoredProc2 sample procedures..

            /* Sample Procedures DDLs
             
                CREATE PROCEDURE MyStoredProc1
	                @MinPrice decimal(18,2),
	                @MaxPrice decimal(18,2)
                AS
                BEGIN
	                SELECT [Id], [Name], [Author], [Description], [Price] 
	                FROM Books
	                WHERE Price > @MinPrice AND Price < @MaxPrice
                END
                GO

                CREATE PROCEDURE MyStoredProc2
	                @NewPrice decimal(18,2)
                AS
                BEGIN
	                UPDATE Books SET Price = @NewPrice
	                WHERE Author LIKE '%Charles%'
                END
                GO

             */

            // After...

            // Get Table..
            DataTable dt = DB.RunProc("MyStoredProc1",
                new ParamItem() { ParamName = "@MinPrice", ParamValue = 20m },
                new ParamItem() { ParamName = "@MaxPrice", ParamValue = 25m });

            // Shows rows count in output window.
            Debug.WriteLine("Result table row count(RunProc - MyStoredProc1) : " + dt.Rows.Count);


            // No return value..
            DB.RunProc("MyStoredProc2",
                new ParamItem() { ParamName = "@NewPrice", ParamValue = 29m });
        }
    }
}
