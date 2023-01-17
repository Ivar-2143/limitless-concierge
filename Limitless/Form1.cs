using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limitless
{
    public partial class frmFrontPage : Form
    {
        string dbPath;
        string imgsPath;
        string connection;
        SqlConnection db;
        public frmFrontPage()
        {
            imgsPath = Path.GetFullPath("Images");
            Console.WriteLine(imgsPath);
            dbPath = Path.GetFullPath("dbLimitless.mdf");
            connection = $"Data Source=(LocalDB)\\MSSQLLocalDB;\\AttachDbFilename={dbPath};Integrated Security=True";
            db = new SqlConnection(connection);
            InitializeComponent();
        }

        private void frmFrontPage_Load(object sender, EventArgs e)
        {

        }
    }
}
