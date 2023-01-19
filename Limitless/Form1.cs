using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using Limitless.Classes;
using Limitless.Components;
using System.Windows.Forms;
using Limitless.Views;

namespace Limitless
{
    public partial class frmFrontPage : Form
    {
        string dbPath, imgsPath, connection;
        SqlConnection db;
        List<Room> hotelRooms;
        string workingDirectory, path;

        
        public frmFrontPage()
        {
            imgsPath = Path.GetFullPath("Images");
            dbPath = Path.GetFullPath("dbLimitless.mdf"); 
            workingDirectory = Environment.CurrentDirectory;
            path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            //Console.WriteLine($"{projectDirectory}\\Limitless\\dbLimitless.mdf");
            //C:\Users\Adi\Documents\Visual Studio 2022\Projects\limitless-concierge\Limitless\dbLimitless.mdf
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\Adi\Documents\Visual Studio 2022\Projects\limitless-concierge\Limitless\dbLimitless.mdf";Integrated Security=True
            //connection = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True";

            connection = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={path}\\Limitless\\dbLimitless.mdf;Integrated Security=False";
            db = new SqlConnection(connection);
            hotelRooms= new List<Room>();
            
            InitializeComponent();
            loadData();

            foreach(Room room in hotelRooms)
            {
                flPanel.Controls.Add(new RoomPreview(room, this,db));
            }

        }
        public void ReloadLayout() {

            loadData();

            flPanel.Controls.Clear();
            flPanel.Refresh();
            foreach (Room room in hotelRooms)
            {
                flPanel.Controls.Add(new RoomPreview(room, this, db));
            }
            flPanel.Refresh();
        } 

        private void loadData()
        {
            hotelRooms.Clear();
            
            db.Open();
            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = "SELECT * FROM Room";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int roomNum = reader.GetInt32(0);
                    string roomName = reader.GetString(1);
                    int bedCapacity = reader.GetInt32(2);
                    Console.WriteLine(path);
                    string image = $"{path}\\Limitless\\Graphics\\{reader.GetString(3)}";
                    double price = Convert.ToDouble(reader.GetDecimal(4));
                    string bookedDates = reader.GetString(5);
                    Console.WriteLine($"Room No.: {roomNum}\n" +
                        $"Room Name: {roomName}\n" +
                        $"Capacity: {bedCapacity}\n"+
                        $"Image: {image}\n" +
                        $"Price: {price}\n" +
                        $"Booked Dates: {bookedDates}\n");
                    //telRooms.Append(new Room(roomNum,roomName,roomType,price,bedCapacity));
                    hotelRooms.Add(new Room(roomNum, roomName, bedCapacity, image, price, bookedDates));
                    //telRooms.Append<Room>(new Room(roomNum, roomName, roomType, price, bedCapacity));
                }

            }

            reader.Close();
            Console.WriteLine($"List Count: {hotelRooms.Count}");


            db.Close();
        }

        private int Generate_RoomNumber()
        {
            int roomNum = 0;
            foreach (Room room in hotelRooms)
            {
                roomNum = room.RoomNum;
            }
            return roomNum+=1;
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ModifyRoomForm roomForm = new ModifyRoomForm(this, db, Generate_RoomNumber());
            roomForm.ShowDialog();
        }

    }
}
