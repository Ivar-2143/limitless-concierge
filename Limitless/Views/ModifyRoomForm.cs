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

namespace Limitless.Views
{
    public partial class ModifyRoomForm : Form
    {
        private SqlConnection _db;
        private Room _room;
        private frmFrontPage _ownerForm;
        private RoomPreview _parent;
        private int _roomNumber;
        public ModifyRoomForm(frmFrontPage ownerForm, SqlConnection db, int generatedNumber)
        {
            _db = db;
            _ownerForm = ownerForm;
            _roomNumber = generatedNumber; 

            InitializeComponent();

            lblRoomNum.Text = generatedNumber.ToString();
        }
        public ModifyRoomForm(Room room,SqlConnection db,frmFrontPage ownerForm,RoomPreview parent)
        {
            _room = room;
            _db = db;
            _ownerForm = ownerForm;
            _parent= parent;

            InitializeComponent();
            lblRoomNum.Text = room.RoomNum.ToString();
            txtRoomName.Text = room.RoomName;
            txtPrice.Text = room.Price.ToString();
            txtBedCap.Text = room.BedCapacity.ToString();
            ptbRoomImage.Image = Image.FromFile(room.Image);


            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _db.Open();
            if (_room != null)
            {
                UpdateData();
                MessageBox.Show("Successfully Updated Data!", "Message");
            }
            else
            {
                InsertData();
                MessageBox.Show("Successfully Created Data!", "Message");
            }

            _db.Close();

            _ownerForm.ReloadLayout();
            Close();

        }

        private void UpdateData()
        {
            

            SqlCommand cmd = _db.CreateCommand();
            cmd.CommandText = "UPDATE Room " +
                "SET RoomName = '" + txtRoomName.Text +
                "', BedCapacity = '" + Convert.ToInt32(txtBedCap.Text) +
                "', Price = '" + Convert.ToDecimal(txtPrice.Text) +
                "' WHERE RoomNumber = " + Convert.ToInt32(_room.RoomNum);
            cmd.ExecuteNonQuery();

        }

        private void InsertData()
        {
            string roomName = txtRoomName.Text;
            int cap = Convert.ToInt32(txtBedCap.Text);
            string img = "studio.jpg";
            SqlCommand cmd = _db.CreateCommand();
            cmd.CommandText = "INSERT INTO Room VALUES ('"
                + _roomNumber
                + "','" + roomName
                + "','" + cap
                + "','" + img
                + "','" + Convert.ToDecimal(txtPrice.Text)
                + "','"+""+"')";
            cmd.ExecuteNonQuery();
        }
    }
}
