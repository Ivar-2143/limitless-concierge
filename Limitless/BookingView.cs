using Limitless.Classes;
using Limitless.Views;
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
        private int _selectedRow;
        private List<Booking> _bookings = new List<Booking>();

        public BookingView(frmFrontPage ownerForm, SqlConnection db)
        {
            _ownerForm= ownerForm;
            _db= db;
            InitializeComponent();
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
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    int guests = reader.GetInt32(1);
                    int roomNum = reader.GetInt32(2);
                    int numberOfNights = reader.GetInt32(3);
                    DateTime dateIn = DateTime.Parse(reader.GetString(4));
                    DateTime dateOut = DateTime.Parse(reader.GetString(5));
                    string name = reader.GetString(6);

                    _bookings.Add(new Booking(id,guests,roomNum,numberOfNights,dateIn,dateOut,name));
                }
            }

            _db.Close();
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

<<<<<<< HEAD
        public void RefreshGridView()
        {
            LoadGridView();
        }
=======
            _db.Close();
        }
         
>>>>>>> master

        private void btnDelete_Click(object sender, EventArgs e)
        {

<<<<<<< HEAD
            _db.Open();
            SqlCommand cmd = _db.CreateCommand();
            cmd.CommandText = "DELETE FROM Bookings WHERE Id = '" + dgbBookingData[0, _selectedRow].Value + "'";
            cmd.ExecuteNonQuery();
            _db.Close();
            
            MessageBox.Show("Successfully Deleted Data!", "MESSAGE");
            LoadGridView();
=======


            //_db.Open();
            //SqlCommand cmd = _db.CreateCommand();
            //cmd.CommandText = "Delete FROM Bookings WHERE Id";
            //cmd.ExecuteNonQuery();
            //_db.Close();
>>>>>>> master
        }

        private void dgbBookingData_SelectionChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            _selectedRow = dgbBookingData.CurrentCell.RowIndex;
            Console.WriteLine("SELECTED: " + dgbBookingData[0,_selectedRow].Value.ToString());
        }

        private void btnBookingUpdate_Click(object sender, EventArgs e)
        {
            Booking _selectedBooking = new Booking();
            foreach(Booking booking in _bookings)
            {
                if(booking.ID == dgbBookingData[0, _selectedRow].Value.ToString())
                {
                    _selectedBooking.ID = booking.ID;
                    _selectedBooking.Guests = booking.Guests;
                    _selectedBooking.Room = booking.Room;
                    _selectedBooking.NumberOfNights = booking.NumberOfNights;
                    _selectedBooking.CheckIn = booking.CheckIn;
                    _selectedBooking.CheckOut = booking.CheckOut;
                    _selectedBooking.GuestName =booking.GuestName;
                }
            }
            if (_selectedBooking != null)
            {
                ModifyBookingForm bookingForm = new ModifyBookingForm(this, _db, _selectedBooking, _bookings);
                bookingForm.ShowDialog();
            }
            
=======
            Console.WriteLine("SELECTED: " + dgbBookingData.CurrentCell.RowIndex);
>>>>>>> master
        }
    }
}

