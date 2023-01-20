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

namespace Limitless.Views
{
    public partial class ModifyRoomForm : Form
    {
        private SqlConnection _db;
        private Room _room;
        private frmFrontPage _ownerForm;
        private RoomPreview _parent;
        private int _roomNumber;
        private string _image;
        private string path, workingDirectory;

        public ModifyRoomForm(frmFrontPage ownerForm, SqlConnection db, int generatedNumber)
        {
            _db = db;
            _ownerForm = ownerForm;
            _roomNumber = generatedNumber;
            workingDirectory = Environment.CurrentDirectory;
            path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            InitializeComponent();
            Console.WriteLine("Image" + ptbRoomImage.Image);
            lblRoomNum.Text = generatedNumber.ToString();
        }
        public ModifyRoomForm(Room room,SqlConnection db,frmFrontPage ownerForm,RoomPreview parent)
        {
            _room = room;
            _db = db;
            _ownerForm = ownerForm;
            _parent= parent;
            workingDirectory = Environment.CurrentDirectory;
            path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            InitializeComponent();
            lblRoomNum.Text = room.RoomNum.ToString();
            txtRoomName.Text = room.RoomName;
            txtPrice.Text = room.Price.ToString();
            txtBedCap.Text = room.BedCapacity.ToString();
            ptbRoomImage.Image = System.Drawing.Image.FromFile($"{path}\\Limitless\\Graphics\\{room.Image}");

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
           

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if(file.ShowDialog() == DialogResult.OK)
            {
                _image = file.FileName;
                ptbRoomImage.Image = new Bitmap(file.FileName);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            _db.Open();
            if (_room != null)
            {
                if (_image != null)
                {
                    File.Copy(_image, Path.Combine($"{path}\\Limitless\\Graphics\\", Path.GetFileName(_image)), true);
                } 
                
                UpdateData();
                MessageBox.Show("Successfully Updated Data!", "Message");
            }
            else
            {
                File.Copy(_image, Path.Combine($"{path}\\Limitless\\Graphics\\",Path.GetFileName(_image)),true);
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
                "', Image = '" + ((_image != null)? Path.GetFileName(_image) : _room.Image) +
                "', BedCapacity = '" + Convert.ToInt32(txtBedCap.Text) +
                "', Price = '" + Convert.ToDecimal(txtPrice.Text) +
                "' WHERE RoomNumber = " + Convert.ToInt32(_room.RoomNum);
            cmd.ExecuteNonQuery();

        }

        private void InsertData()
        {
            string roomName = txtRoomName.Text;
            int cap = Convert.ToInt32(txtBedCap.Text);
            string img = Path.GetFileName(_image);
            SqlCommand cmd = _db.CreateCommand();
            cmd.CommandText = "INSERT INTO Room VALUES ('"
                + _roomNumber
                + "','" + roomName
                + "','" + cap
                + "','" + img
                + "','" + Convert.ToDecimal(txtPrice.Text)
                + "','"+"" + "')";
            cmd.ExecuteNonQuery();
            
        }
    }
}
