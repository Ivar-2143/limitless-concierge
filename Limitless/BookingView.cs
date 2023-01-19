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

namespace Limitless
{
    public partial class BookingView : Form
    {
        private frmFrontPage _ownerForm;
        private SqlConnection _db;

        public BookingView(frmFrontPage ownerForm, SqlConnection db)
        {
            _ownerForm= ownerForm;
            _db= db;
            InitializeComponent();
        }
        private void BookingView_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }
        private void LoadGridView()
        {
            _db.Open();
            SqlCommand cmd = _db.CreateCommand();
            cmd.CommandText = "SELECT * FROM Bookings";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgbBookingData.DataSource = dt;

            _db.Close();
        }
         

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _db.Open();
            SqlCommand cmd = _db.CreateCommand();
            cmd.CommandText = "Delete FROM Bookings WHERE Id";
            cmd.ExecuteNonQuery();
            _db.Close();
        }
    }
}

