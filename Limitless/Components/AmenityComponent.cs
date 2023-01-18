using Limitless.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Limitless.Components;
using System.Drawing;

namespace Limitless.Components
{
    public class AmenityComponent : Panel
    {
        private Label _lblPrice;
        private CheckBox _chkAmenity;

        public AmenityComponent(Amenity amenity) {
            Width = 378;
            Height = 40;
            BackColor = Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));


            _lblPrice = new Label();
            _chkAmenity = new CheckBox();

            _lblPrice.Text = Convert.ToString(amenity.Price);
            _lblPrice.AutoSize = true;
            _lblPrice.BackColor = Color.White;
            _lblPrice.ForeColor = Color.Black;
            _lblPrice.Location = new Point(310, 7);
            _lblPrice.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);

            _chkAmenity.Text= amenity.Name;
            _chkAmenity.AutoSize = true;
            _chkAmenity.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _chkAmenity.ForeColor = SystemColors.ControlLightLight;
            _chkAmenity.Location = new Point(3, 7);


            Controls.Add(_lblPrice);
            Controls.Add(_chkAmenity);


        }
    }
}
