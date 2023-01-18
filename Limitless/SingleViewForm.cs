using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limitless
{
    public partial class frmSingleViewForm : Form
    {
       private frmFrontPage _prevForm;
        public frmSingleViewForm(Room room, frmFrontPage form)
        {
            _prevForm = form;
            InitializeComponent();

            lblRoomName.Text = room.RoomName;
            lblRoomPrice.Text = $"{Convert.ToString(room.Price)}/per night";
            lblRoomID.Text = $"{room.RoomName}-{room.RoomNum}";
            ptbPictureSingle.Image = Image.FromFile(room.Image);
            lblRoomNum.Text = Convert.ToString(room.RoomNum);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            _prevForm.Visible = true;
        }

    }
}
