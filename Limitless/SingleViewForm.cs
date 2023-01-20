using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Limitless.Classes;
using Limitless.Components;

namespace Limitless
{
    public partial class frmSingleViewForm : Form
    {
        private frmFrontPage _prevForm;
        private BookingView _parentForm;
        private frmAmenities _amenitiesForm;
        private List<Amenity> _selectedAmenities;
        private DateTime _checkIn, _checkOut;
        private SqlConnection _db;
        private Room _room;
        private List<Booking> _bookings = new List<Booking>();
        private double _TotalAmenityPrice = 0;
        public string DATE_FORMAT = "MM-dd-yyyy hh:mm tt";
        private string path, workingDirectory;
        public frmSingleViewForm(Room room, frmFrontPage form,SqlConnection db)
        {
            _selectedAmenities = new List<Amenity>();
            _room = room;
            _db = db;
            _prevForm = form;
            workingDirectory = Environment.CurrentDirectory;
            path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            InitializeComponent();

            dtCheckIn.Value = DateTime.Now;
            dtCheckOut.Value = DateTime.Now.AddDays(1);
            dtCheckIn.Format = DateTimePickerFormat.Custom;
            dtCheckIn.CustomFormat = DATE_FORMAT;
            dtCheckOut.Format = DateTimePickerFormat.Custom;
            dtCheckOut.CustomFormat = DATE_FORMAT;


            lblBedCap.Text = Convert.ToString(room.BedCapacity);
            lblRoomName.Text = room.RoomName;
            lblRoomPrice.Text = $"Price: {Convert.ToString(room.Price)}/per night";
            lblRoomID.Text = $"{room.RoomName}-{room.RoomNum}";
            ptbPictureSingle.Image = Image.FromFile($"{path}\\Limitless\\Graphics\\{room.Image}");
            lblRoomNum.Text = Convert.ToString(room.RoomNum);
        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            _prevForm.Visible = true;
        }

        private void btnEditAmenities_Click(object sender, EventArgs e)
        {

            if(_selectedAmenities.Count > 0 && _selectedAmenities != null)
            {
                _amenitiesForm = new frmAmenities(this,_selectedAmenities);
            }
            else
            {

                _amenitiesForm  = new frmAmenities(this);
            }
            _amenitiesForm.ShowDialog();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _checkIn = dtCheckIn.Value;
            _checkOut = dtCheckOut.Value;
            Console.WriteLine(_checkIn.ToString(DATE_FORMAT));
            Console.WriteLine(_checkOut.ToString(DATE_FORMAT));
            Console.WriteLine(DateTime.Today.ToString());

            try
            {
                loadBookingDates();
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
                    EvaluateDate(_checkIn,_checkOut);
                }

                //When there are no error or conflicts checked RUN this code
                ConfirmBooking();
                MessageBox.Show("Successfully Added Booking!", "MESSAGE");
                Close();
                _prevForm.Visible = true;
            }
            catch (BookingDateException bde)
            {
                MessageBox.Show(bde.Message, "ERROR MESSAGE!");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR MESSAGE!");
            }

            
           
        }
        

        private void EvaluateDate(DateTime dateIn, DateTime dateOut)
        {
            foreach (Booking booking in _bookings)
            {
                Console.WriteLine(dateIn);
                Console.WriteLine(booking.CheckOut);

                Console.WriteLine(dateIn.Subtract(booking.CheckOut).TotalDays );
                if (dateIn > booking.CheckIn && dateIn < booking.CheckOut || dateOut > booking.CheckIn && dateOut < booking.CheckOut)
                {
                    throw new BookingDateException($"There is an existing BOOKING in the Date Range [ {booking.CheckIn} - {booking.CheckOut} ]!");
                }
                if (booking.CheckOut > dateIn && booking.CheckOut < dateOut)
                {
                    throw new BookingDateException($"There is an existing BOOKING in the Date Range [ {booking.CheckIn} - {booking.CheckOut} ]!");
                }
                //if (dateIn > booking.CheckIn && dateIn < booking.CheckOut || dateOut > booking.CheckIn && dateOut < booking.CheckOut)
                //{
                //    throw new BookingDateException($"There is an existing BOOKING in the Date Range [ {booking.CheckIn} - {booking.CheckOut} ]!");
                //}
                //if (booking.CheckOut > dateIn && booking.CheckOut < dateOut)
                //{
                //    throw new BookingDateException($"There is an existing BOOKING in the Date Range [ {booking.CheckIn} - {booking.CheckOut} ]!");
                //}
            }
        }


        private void loadBookingDates()
        {
            _db.Open();
            SqlCommand cmd = _db.CreateCommand();
            cmd.CommandText = $"SELECT * FROM Bookings WHERE Room = {_room.RoomNum}";
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
                    DateTime.TryParseExact(reader.GetString(4), DATE_FORMAT, new CultureInfo("en"), DateTimeStyles.None, out dateIn);
                    //DateTime dateIn = DateTime.Parse(reader.GetString(4));
                    DateTime dateOut;
                    DateTime.TryParseExact(reader.GetString(5), DATE_FORMAT, new CultureInfo("en"), DateTimeStyles.None, out dateOut);
                    //DateTime dateIn = DateTime.Parse(reader.GetString(4));

                    //DateTime dateOut = DateTime.Parse(reader.GetString(5));
                    string name = reader.GetString(6); 
                   
                    Console.WriteLine($"ID: {id}\n" +
                        $"Room Num: {roomNum}\n" +
                        $"Guests: {guests}\n" +
                        $"Nights: {numberOfNights}\n" +
                        $"Date-in: {dateIn}\n" +
                        $"Date-out: {dateOut}\n");
                    _bookings.Add(new Booking(id,guests,roomNum,numberOfNights,dateIn,dateOut,name));
                }
            }
            _db.Close();
        }

        private void dtCheckIn_ValueChanged(object sender, EventArgs e)
        {
            if(dtCheckOut.Value < dtCheckIn.Value || dtCheckOut.Value.Subtract(dtCheckIn.Value).TotalHours <= 23)
            {
                dtCheckOut.Value = dtCheckIn.Value.AddHours(24);
            }

            lblNights.Text = Convert.ToString(Convert.ToInt32(dtCheckOut.Value.Subtract(dtCheckIn.Value).TotalDays));
            lblTotalPrice.Text = $"Php {(Convert.ToDouble(lblNights.Text) * _room.Price) + _TotalAmenityPrice}";
        }

        private void dtCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (dtCheckOut.Value < dtCheckIn.Value || dtCheckOut.Value.Subtract(dtCheckIn.Value).TotalHours <= 23)
            {
                dtCheckOut.Value = dtCheckIn.Value.AddHours(24);
            }

            //lblNights.Text = Convert.ToString(dtCheckOut.Value.Subtract(dtCheckIn.Value).TotalDays);
            lblNights.Text = Convert.ToString(Convert.ToInt32(dtCheckOut.Value.Subtract(dtCheckIn.Value).TotalDays));
            lblTotalPrice.Text = $"Php {(Convert.ToDouble(lblNights.Text) * _room.Price) + _TotalAmenityPrice}";

        }


        private void ConfirmBooking()
        {
            string id = $"{_room.RoomNum}-{_checkIn.ToString("MM-dd")}-{_checkOut.ToString("MM-dd-yyy")}";
            string listOfAmenities = "";
            if(_selectedAmenities.Count > 0)
            {
                foreach (Amenity amenity in _selectedAmenities)
                {
                    listOfAmenities = listOfAmenities + amenity.Name + ",";
                }
            }




            _db.Open();
            SqlCommand cmd = _db.CreateCommand();
            cmd.CommandText = "INSERT INTO Bookings VALUES ('"
                + id
                + "','" + Convert.ToInt32(txtGuestNo.Text)
                + "','" + _room.RoomNum
                + "','" + Convert.ToInt32(lblNights.Text)
                + "','" + _checkIn.ToString(DATE_FORMAT)
                + "','" + _checkOut.ToString(DATE_FORMAT)
                + "','" + txtGuestName.Text
                + "','" + listOfAmenities + "')";
            cmd.ExecuteNonQuery();
            _db.Close();

            Document document = new Document(iTextSharp.text.PageSize.LETTER, 10,10,42,35);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream($"LIMITLESS-{id}.pdf", FileMode.Create));
            document.Open();
            Paragraph p = new Paragraph(
                $"BOOKING ID: {id}\n" +
                $"GUEST : {txtGuestName.Text}\n" +
                $"GUEST QUANTITY : {txtGuestNo.Text}\n" +
                $"PREFERRED ROOM : {_room.RoomNum}\n" +
                $"NUMBER OF NIGHTS : {lblNights.Text}\n" +
                $"CHECK-IN TIME : {_checkIn.ToString(DATE_FORMAT)}\n" +
                $"CHECK-OUT TIME : {_checkOut.ToString(DATE_FORMAT)}\n" +
                $"AMENITIES : {listOfAmenities}\n"
                );
            document.Add( p );
            document.Close();

        }

        public void setTotalAmenityPrice(double price)
        {
            _TotalAmenityPrice = price;
            lblTotalPrice.Text = $"Php {(Convert.ToDouble(lblNights.Text) * _room.Price) + _TotalAmenityPrice}";
        }

        public void loadGridView(List<Amenity> amenities)
        {
            _selectedAmenities = amenities;
            dgvAmenities.DataSource = _selectedAmenities.ToList();
        }
    }
}
