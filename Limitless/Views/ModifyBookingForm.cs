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

        public ModifyBookingForm(BookingView parentView,SqlConnection db,Booking details, List<Booking> bookings)
        {
            _db = db;
            _bookings = bookings;
            _details= details;
            _parentView= parentView;
            InitializeComponent();

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
        private void LoadData()
        {
            _db.Open();
            SqlCommand cmd = _db.CreateCommand();
            cmd.CommandText = "SELECT * FROM Bookings";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            _db.Close();
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
            _db.Open();
            SqlCommand cmd = _db.CreateCommand();
            cmd.CommandText = "UPDATE Bookings " +
            "SET GuestName = '" + _details.GuestName +
                "', Room = '" + _details.Room +
                "', NumberOfNights = '" + Convert.ToInt32(lblNights.Text) +
                "', CheckIn = '" + dtCheckIn.Value.ToString(DATE_FORMAT) +
                "', CheckOut = '" + dtCheckOut.Value.ToString(DATE_FORMAT) +
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

    }
}
