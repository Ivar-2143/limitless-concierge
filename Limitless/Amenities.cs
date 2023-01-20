using Limitless.Classes;
using Limitless.Components;
using Limitless.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Limitless
{

    public partial class frmAmenities : Form
    {

        SqlConnection db;
        List<Amenity> amenities;
        string workingDirectory, path, connection;
        public List<Amenity> chosenAmenities;
        private frmSingleViewForm _parent;
        private double _price;

        public frmAmenities(frmSingleViewForm parentView)
        {
            chosenAmenities = new List<Amenity>();
            _parent = parentView;

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
                    flPnlServices.Controls.Add(new AmenityComponent(this,amenity, false));
                }else if(amenity.Category == "essentials")
                {
                    flPnlEssential.Controls.Add(new AmenityComponent(this,amenity, false));
                }
                else
                {
                    flPnlOthers.Controls.Add(new AmenityComponent(this,amenity, false));
                }
            }
        }
        public frmAmenities(frmSingleViewForm parentView, List<Amenity> selected)
        {
            chosenAmenities = selected;
            Console.WriteLine(chosenAmenities.Count);
            _parent = parentView;

            workingDirectory = Environment.CurrentDirectory;
            path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            connection = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={path}\\Limitless\\dbLimitless.mdf;Integrated Security=True";
            db = new SqlConnection(connection);

            loadData();
            InitializeComponent();

            setPrice();
            foreach (Amenity amenity in amenities)
            {
                bool isChecked = false;
                if(chosenAmenities.Count > 0)
                {
                    foreach (Amenity cAmenity in chosenAmenities)
                    {
                        if (cAmenity.Name == amenity.Name)
                        {
                            isChecked = true;
                        }
                    }
                }
                if (amenity.Category == "services")
                {
                    flPnlServices.Controls.Add(new AmenityComponent(this, amenity,isChecked));
                }
                else if (amenity.Category == "essentials")
                {
                    flPnlEssential.Controls.Add(new AmenityComponent(this, amenity,isChecked));
                }
                else
                {
                    flPnlOthers.Controls.Add(new AmenityComponent(this, amenity,isChecked));
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ModifyAmenitiesForm maf = new ModifyAmenitiesForm(this,db);
            maf.ShowDialog();

        }

        private void loadData()
        {
            amenities = new List<Amenity>();
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
                    //Console.WriteLine($"Amenity Name: {amenityName}\n" +
                    //    $"Price: {price}\n" +
                    //    $"Category: {category}\n");
                    amenities.Add(new Amenity(amenityName,price,category));
                }
            }
            db.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (chosenAmenities.Count > 0)
            {
                _parent.loadGridView(chosenAmenities);
                _parent.setTotalAmenityPrice(_price);
            }
            Close();
            
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void setPrice()
        {
            _price = 0;
            foreach(Amenity amenity in chosenAmenities)
            {
                lblPrice.Text = $"Php {Convert.ToString(_price += amenity.Price)}";
            }
        }
        public void refreshData()
        {
            flPnlEssential.Controls.Clear();
            flPnlOthers.Controls.Clear();
            flPnlServices.Controls.Clear();
            amenities.Clear();
            loadData();
            foreach (Amenity amenity in amenities)
            {
                bool isChecked = false;
                if (chosenAmenities.Count > 0)
                {
                    foreach (Amenity cAmenity in chosenAmenities)
                    {
                        if (cAmenity.Name == amenity.Name)
                        {
                            isChecked = true;
                        }
                    }
                }
                if (amenity.Category == "services")
                {
                    flPnlServices.Controls.Add(new AmenityComponent(this, amenity,isChecked));
                }
                else if (amenity.Category == "essentials")
                {
                    flPnlEssential.Controls.Add(new AmenityComponent(this, amenity,isChecked));
                }
                else
                {
                    flPnlOthers.Controls.Add(new AmenityComponent(this, amenity, isChecked));
                }
            }
            flPnlEssential.Refresh();
            flPnlOthers.Refresh();
            flPnlServices.Refresh();
        }

    }
}
