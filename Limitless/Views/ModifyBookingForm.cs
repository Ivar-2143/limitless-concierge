using Limitless.Classes;
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
using static System.Net.Mime.MediaTypeNames;

namespace Limitless.Views
{
    public partial class ModifyBookingForm : Form
    {
        private SqlConnection _db;
        private Booking _details;
        private List<Booking> _bookings;  
        private DateTime _checkIn, _checkOut;
        public string DATE_FORMAT = "MM-dd-yyyy hh:mm tt";
        private BookingView _parentView;
        private List<Amenity> _amenities;

        public ModifyBookingForm(BookingView parentView,SqlConnection db,Booking details, List<Booking> bookings)
        {
            _db = db;
            _bookings = bookings;
            _details= details;
            _parentView= parentView;
            _amenities = new List<Amenity>();
            InitializeComponent();
            fetchAmenities();
            lblBookingID.Text = details.ID;
            lblName.Text = details.GuestName;
            lblRoomNum.Text = details.Room.ToString();
            txtGuests.Text = details.Guests.ToString();
            lblNights.Text = details.NumberOfNights.ToString();
            dtCheckIn.Value = details.CheckIn;
            dtCheckOut.Value = details.CheckOut;
            dtCheckIn.Format = DateTimePickerFormat.Custom;
            dtCheckIn.CustomFormat = DATE_FORMAT;
            dtCheckOut.Format = DateTimePickerFormat.Custom;
            dtCheckOut.CustomFormat = DATE_FORMAT;
        }
        private void LoadData(string[] names)
        {
            _db.Open();
            SqlCommand cmd = _db.CreateCommand();
            cmd.CommandText = "SELECT * FROM Amenities";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    bool isChecked = false;
                    foreach(string name in names)
                    {
                        if (name == reader.GetString(0))
                        {
                            isChecked = true;
                        }
                    }
                    if (isChecked)
                    {
                        _amenities.Add(new Amenity(reader.GetString(0), Convert.ToDouble(reader.GetDecimal(1)), reader.GetString(2)));
                    }
                }
            }
            
            _db.Close();
            dtgAmenities.DataSource = _amenities.ToList();
            
        }
        private void EvaluateDate(DateTime dateIn, DateTime dateOut)
        {
            foreach (Booking booking in _bookings)
            {
                Console.WriteLine(!booking.ID.Equals(_details.ID));
                if (!booking.ID.Equals(_details.ID))
                {
                    if (dateIn > booking.CheckIn && dateIn < booking.CheckOut || dateOut > booking.CheckIn && dateOut < booking.CheckOut)
                    {
                        throw new BookingDateException($"There is an existing BOOKING in the Date Range [ {booking.CheckIn} - {booking.CheckOut} ]!");
                    }
                    if (booking.CheckOut > dateIn && booking.CheckOut < dateOut)
                    {
                        throw new BookingDateException($"There is an existing BOOKING in the Date Range [ {booking.CheckIn} - {booking.CheckOut} ]!");
                    }
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            _checkIn = dtCheckIn.Value;
            _checkOut = dtCheckOut.Value;

            try
            {
                if (_checkIn < DateTime.Now)
                {
                    throw new BookingDateException("Date is earlier than today!");
                }
                if (_checkOut < _checkIn)
                {
                    throw new BookingDateException("Check Out date is earlier than Check In!");
                }
                Console.WriteLine(_bookings.Count);
                if (_bookings != null && _bookings.Count > 0)
                {
                    EvaluateDate(_checkIn, _checkOut);
                }

                UpdateData();
                _parentView.RefreshGridView();
                MessageBox.Show("Successfully Updated Booking!", "MESSAGE");

            }
            catch (BookingDateException bde)
            {
                MessageBox.Show(bde.Message, "ERROR MESSAGE!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR MESSAGE!");
            }

        }

        private void UpdateData()
        {
            string listOfAmenities = "";
            if (_amenities.Count > 0)
            {
                foreach (Amenity amenity in _amenities)
                {
                    listOfAmenities = listOfAmenities + amenity.Name + ",";
                }
            }

            _db.Open();
            SqlCommand cmd = _db.CreateCommand();
            cmd.CommandText = "UPDATE Bookings " +
            "SET GuestName = '" + _details.GuestName +
                "', Room = '" + _details.Room +
                "', NumberOfNights = '" + Convert.ToInt32(lblNights.Text) +
                "', CheckIn = '" + dtCheckIn.Value.ToString(DATE_FORMAT) +
                "', CheckOut = '" + dtCheckOut.Value.ToString(DATE_FORMAT) +
                "', ListOfAmenities = '" + listOfAmenities +
                "' WHERE Id = '" + _details.ID + "'";
            cmd.ExecuteNonQuery();
            _db.Close();
        }

        private void dtCheckIn_ValueChanged(object sender, EventArgs e)
        {
            if (dtCheckOut.Value < dtCheckIn.Value || dtCheckOut.Value.Subtract(dtCheckIn.Value).TotalHours <= 23)
            {
                dtCheckOut.Value = dtCheckIn.Value.AddHours(23);
            }

            lblNights.Text = Convert.ToString(Convert.ToInt32(dtCheckOut.Value.Subtract(dtCheckIn.Value).TotalDays));
        }

        private void dtCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (dtCheckOut.Value < dtCheckIn.Value || dtCheckOut.Value.Subtract(dtCheckIn.Value).TotalHours <= 23)
            {
                dtCheckOut.Value = dtCheckIn.Value.AddHours(23);
            }

            lblNights.Text = Convert.ToString(Convert.ToInt32(dtCheckOut.Value.Subtract(dtCheckIn.Value).TotalDays));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAmenities  _amenitiesForm = new frmAmenities(this, _amenities);
            _amenitiesForm.ShowDialog();
        }

        private void fetchAmenities()
        {
            string[] listOfAmenities = _details.Amenities.Split(',');
            LoadData(listOfAmenities);
            Console.WriteLine(listOfAmenities.Length);
        }

        public void loadGridView(List<Amenity> amenities)
        {
            dtgAmenities.DataSource = amenities.ToList();
        }
    }
}
