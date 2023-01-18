using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limitless
{
    internal class RoomPreview: Panel
    {
        private Room _room;
        private frmFrontPage _ownerForm;
        private Label _roomName, _roomPrice, _bedCapacity;
        private Button _btnView, _btnEdit, _btnDelete;
        private PictureBox _roomImg;
        public RoomPreview(Room room, frmFrontPage ownerForm)
        {
            _room = room;
            _ownerForm = ownerForm;
            Width = 680;
            Height = 138;
            Margin = new Padding(4, 4, 4, 4);
            Name = $"{room.RoomName}-{room.RoomNum}";
            BackColor = Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));


            _roomName = new Label();
            _roomPrice = new Label();
            _bedCapacity = new Label();
            _btnView = new Button();
            _btnEdit = new Button();
            _btnDelete = new Button();
            _roomImg = new PictureBox();

            _roomName.AutoSize= true;
            _roomName.Text = $"{room.RoomName}";
            _roomName.Location = new Point(273, 4);
            _roomName.Font = new Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _roomName.ForeColor = SystemColors.ControlLightLight;
            //_roomName.Size = new Size(142, 24);

            _roomPrice.AutoSize= true;
            _roomPrice.Text = $"{Convert.ToString(room.Price)}/per night";
            _roomPrice.Location = new Point(273, 44);
            _roomPrice.ForeColor = SystemColors.ControlLightLight;
            _roomPrice.Margin = new Padding(4, 0, 4, 0);
            _roomPrice.Font = new Font("Consolas", 12F, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            //_roomPrice.Size = new Size(153, 19);

            _bedCapacity.AutoSize = true;
            _bedCapacity.Text = $"{Convert.ToString(room.BedCapacity)} pax";
            _bedCapacity.Font = new Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _bedCapacity.ForeColor = SystemColors.ControlLightLight;
            _bedCapacity.Margin = new Padding(4,0,4, 0);
            _bedCapacity.Location = new Point(273, 79);
            //_bedCapacity.Size = new Size(54, 19);

            //_roomImg.Image = new Bitmap(room.Image);
            Console.WriteLine(room.Image);
            _roomImg.Image = Image.FromFile(room.Image);
            _roomImg.Location = new Point(5, 4);
            _roomImg.Size = new Size(260, 130);
            _roomImg.SizeMode = PictureBoxSizeMode.StretchImage;
            _roomImg.Margin = new Padding(4, 4, 4, 4);


            _btnView.Text = "View";
            _btnView.Font =  new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            _btnView.BackColor = Color.White;
            _btnView.ForeColor = Color.Black;
            _btnView.Location = new Point(505, 3);
            _btnView.Size = new Size(151, 40);
            _btnView.UseVisualStyleBackColor = true;
            _btnView.Click += new EventHandler(openBooking_Click);

            _btnEdit.Text = "Edit";
            _btnEdit.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            _btnEdit.BackColor = Color.White;
            _btnEdit.ForeColor = Color.Black;
            _btnEdit.Location = new Point(505, 48);
            _btnEdit.Size = new Size(151, 40);
            _btnEdit.UseVisualStyleBackColor = true;
            _btnEdit.Click += new EventHandler(EditRoom_Click);

            _btnDelete.Text = "Delete";
            _btnDelete.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            _btnDelete.BackColor = Color.White;
            _btnDelete.ForeColor = Color.Black;
            _btnDelete.Location = new Point(505, 93);
            _btnDelete.Size = new Size(151, 40);
            _btnDelete.UseVisualStyleBackColor = true;
            _btnDelete.Click += new EventHandler(DeleteRoom_Click);



            Controls.Add(_roomImg);
            Controls.Add(_roomName);
            Controls.Add(_bedCapacity);
            Controls.Add(_roomPrice);
            Controls.Add(_btnView);
            Controls.Add(_btnEdit);
            Controls.Add(_btnDelete);
        }
        private void openBooking_Click(object sender, EventArgs e)
        {
            frmSingleViewForm roomView = new frmSingleViewForm(_room,_ownerForm);
            roomView.Show();
            _ownerForm.Visible = false;
        }

        private void DeleteRoom_Click(object sender, EventArgs e)
        {

        }

        private void EditRoom_Click(object sender, EventArgs e)
        {

        }
            
    }
}
