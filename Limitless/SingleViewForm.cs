using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Limitless.Classes;
using Limitless.Components;

namespace Limitless
{
    public partial class frmSingleViewForm : Form
    {
        private frmFrontPage _prevForm;
        private frmAmenities _amenitiesForm;
        private List<Amenity> _selectedAmenities;


        public frmSingleViewForm(Room room, frmFrontPage form)
        {
            _prevForm = form;
            InitializeComponent();

            lblBedCap.Text = Convert.ToString(room.BedCapacity);
            lblRoomName.Text = room.RoomName;
            lblRoomPrice.Text = $"Price: {Convert.ToString(room.Price)}/per night";
            lblRoomID.Text = $"{room.RoomName}-{room.RoomNum}";
            ptbPictureSingle.Image = Image.FromFile(room.Image);
            lblRoomNum.Text = Convert.ToString(room.RoomNum);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            _prevForm.Visible = true;
        }


        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEditAmenities_Click(object sender, EventArgs e)
        {
            _amenitiesForm  = new frmAmenities();
            _amenitiesForm.ShowDialog();

        }
    }
}
