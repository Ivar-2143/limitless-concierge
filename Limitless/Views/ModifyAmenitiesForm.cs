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
    public partial class ModifyAmenitiesForm : Form
    {
        private SqlConnection _db;
        private List<Amenity> _amenities;
        private frmAmenities _parentForm;
        private int _selectedRow;
        public ModifyAmenitiesForm(frmAmenities parentForm,SqlConnection db)
        {
            _db = db;
            _parentForm = parentForm;
            

            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            _amenities = new List<Amenity>();
            _db.Open();
            SqlCommand cmd = _db.CreateCommand();
            cmd.CommandText = "SELECT * FROM Amenities";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dtgAmenities.DataSource = dt;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    _amenities.Add(new Amenity(reader.GetString(0), Convert.ToDouble(reader.GetDecimal(1)), reader.GetString(2)));
                }
            }
            _db.Close();
        }
        private void insertData()
        {
            _db.Open();
            SqlCommand cmd = _db.CreateCommand();
            cmd.CommandText = "INSERT INTO Amenities VALUES ('"
                + txtName.Text
                + "','" + Convert.ToDecimal(txtPrice.Text)
                + "','" + txtCategory.Text + "')";
            cmd.ExecuteNonQuery();
            _db.Close();
        }
        private void updateData()
        {
            _db.Open();
            SqlCommand cmd = _db.CreateCommand();
            cmd.CommandText = "UPDATE Amenities " +
                "SET Category = '" + txtCategory.Text +
                "', Price = " + Convert.ToDecimal(txtPrice.Text) +
                " WHERE Name = '" + txtName.Text + "'";
            cmd.ExecuteNonQuery();
            _db.Close();
        }
        private void removeData()
        {
            string message = "Are you sure you want to Delete this Data?";
            string title = "Delete Message";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _db.Open();
                SqlCommand cmd = _db.CreateCommand();
                cmd.CommandText = "DELETE FROM Amenities WHERE Name = '" + dtgAmenities[0,_selectedRow].Value + "'";
                cmd.ExecuteNonQuery();
                _db.Close();
            }
        }

        private void dtgAmenities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRow = e.RowIndex;

            txtName.Text = dtgAmenities[0,_selectedRow].Value.ToString();
            txtPrice.Text = dtgAmenities[1,_selectedRow].Value.ToString();
            txtCategory.Text = dtgAmenities[2,_selectedRow].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach(Amenity amenity in _amenities)
            {
                if(amenity.Name == txtName.Text)
                {
                    updateData();
                    loadData();
                    MessageBox.Show("Successfully Updated Data!", "MESSAGE");
                    _parentForm.refreshData();
                }
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insertData();
            loadData();
            MessageBox.Show("Successfully Added Data!", "MESSAGE");
            _parentForm.refreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            removeData();
            loadData();
            MessageBox.Show("Successfully Deleted Data!", "MESSAGE");
            _parentForm.refreshData();
        }

    }

}
