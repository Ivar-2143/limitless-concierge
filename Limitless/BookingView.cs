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

namespace Limitless
{
    public partial class BookingView : Form
    {
        private frmFrontPage _ownerForm;
        private SqlConnection _db;

        public BookingView(frmFrontPage ownerForm, SqlConnection db)
        {
            _ownerForm= ownerForm;
            _db= db;
            InitializeComponent();
        }

       
    }
}

