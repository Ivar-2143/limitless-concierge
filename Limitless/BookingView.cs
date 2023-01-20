using Limitless.Classes;
using Limitless.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
        public string DATE_FORMAT = "MM-dd-yyyy hh:mm tt";

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
                    DateTime dateIn;
                    DateTime.TryParseExact(reader.GetString(4),DATE_FORMAT,new CultureInfo("en"),DateTimeStyles.None,out dateIn);
                    //DateTime dateIn = DateTime.Parse(reader.GetString(4));
                    DateTime dateOut;
                    DateTime.TryParseExact(reader.GetString(5), DATE_FORMAT, new CultureInfo("en"), DateTimeStyles.None, out dateOut);
                    string name = reader.GetString(6);
                    string amenities = reader.GetString(7);

                    _bookings.Add(new Booking(id,guests,roomNum,numberOfNights,dateIn,dateOut,name,amenities));
                }
            }

            _db.Close();
        }

        public void RefreshGridView()
        {
            LoadGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            _db.Open();
            SqlCommand cmd = _db.CreateCommand();
            cmd.CommandText = "DELETE FROM Bookings WHERE Id = '" + dgbBookingData[0, _selectedRow].Value + "'";
            cmd.ExecuteNonQuery();
            _db.Close();
            
            MessageBox.Show("Successfully Deleted Data!", "MESSAGE");
            LoadGridView();
        }

        private void dgbBookingData_SelectionChanged(object sender, EventArgs e)
        {
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
                    _selectedBooking.Amenities = booking.Amenities;
                }
            }
            if (_selectedBooking != null)
            {
                ModifyBookingForm bookingForm = new ModifyBookingForm(this, _db, _selectedBooking, _bookings);
                bookingForm.ShowDialog();
            }
            
        }
    }
}

