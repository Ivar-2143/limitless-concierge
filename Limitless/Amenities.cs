using Limitless.Classes;
using Limitless.Components;
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

    public partial class frmAmenities : Form
    {

        SqlConnection db;
        List<Amenity> amenities;
        string workingDirectory, path, connection;

        public frmAmenities()
        {
            amenities = new List<Amenity>();
            workingDirectory = Environment.CurrentDirectory;
            path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            connection = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={path}\\Limitless\\dbLimitless.mdf;Integrated Security=True";
            db = new SqlConnection(connection);

            loadData();
            InitializeComponent();

            foreach(Amenity amenity in amenities)
            {
                if(amenity.Category == "services")
                {
                    flPnlServices.Controls.Add(new AmenityComponent(amenity));
                }else if(amenity.Category == "essentials")
                {
                    flPnlEssential.Controls.Add(new AmenityComponent(amenity));
                }
                else
                {
                    flPnlOthers.Controls.Add(new AmenityComponent(amenity));
                }
            }



        }

        private void loadData()
        {
            db.Open();
            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = "SELECT * FROM Amenities";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string amenityName = reader.GetString(0);
                    double price = Convert.ToDouble(reader.GetDecimal(1));
                    string category = reader.GetString(2);
                    Console.WriteLine($"Amenity Name: {amenityName}\n" +
                        $"Price: {price}\n" +
                        $"Category: {category}\n");
                    amenities.Add(new Amenity(amenityName,price,category));
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
