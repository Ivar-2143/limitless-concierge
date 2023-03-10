namespace Limitless
{
    partial class frmSingleViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSingleViewForm));
            this.ptbPictureSingle = new System.Windows.Forms.PictureBox();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblGuestNo = new System.Windows.Forms.Label();
            this.lblDaysOfStay = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.txtGuestNo = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblRoomDetails = new System.Windows.Forms.Label();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.dtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblBedCapacity = new System.Windows.Forms.Label();
            this.lblAmenities = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEditAmenities = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.dgvAmenities = new System.Windows.Forms.DataGridView();
            this.lblBedCap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPictureSingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmenities)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbPictureSingle
            // 
            this.ptbPictureSingle.Image = ((System.Drawing.Image)(resources.GetObject("ptbPictureSingle.Image")));
            this.ptbPictureSingle.Location = new System.Drawing.Point(10, 60);
            this.ptbPictureSingle.Name = "ptbPictureSingle";
            this.ptbPictureSingle.Size = new System.Drawing.Size(326, 340);
            this.ptbPictureSingle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPictureSingle.TabIndex = 0;
            this.ptbPictureSingle.TabStop = false;
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoomNo.Location = new System.Drawing.Point(358, 108);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(106, 24);
            this.lblRoomNo.TabIndex = 3;
            this.lblRoomNo.Text = "Room No.";
            // 
            // lblGuestNo
            // 
            this.lblGuestNo.AutoSize = true;
            this.lblGuestNo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGuestNo.Location = new System.Drawing.Point(359, 141);
            this.lblGuestNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestNo.Name = "lblGuestNo";
            this.lblGuestNo.Size = new System.Drawing.Size(118, 24);
            this.lblGuestNo.TabIndex = 4;
            this.lblGuestNo.Text = "Guest No.";
            // 
            // lblDaysOfStay
            // 
            this.lblDaysOfStay.AutoSize = true;
            this.lblDaysOfStay.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysOfStay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDaysOfStay.Location = new System.Drawing.Point(584, 108);
            this.lblDaysOfStay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDaysOfStay.Name = "lblDaysOfStay";
            this.lblDaysOfStay.Size = new System.Drawing.Size(214, 24);
            this.lblDaysOfStay.TabIndex = 5;
            this.lblDaysOfStay.Text = "Number of Nights:";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGuestName.Location = new System.Drawing.Point(381, 179);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(142, 24);
            this.lblGuestName.TabIndex = 6;
            this.lblGuestName.Text = "Guest Name:";
            // 
            // txtGuestNo
            // 
            this.txtGuestNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestNo.Location = new System.Drawing.Point(485, 141);
            this.txtGuestNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuestNo.Name = "txtGuestNo";
            this.txtGuestNo.Size = new System.Drawing.Size(95, 26);
            this.txtGuestNo.TabIndex = 8;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestName.Location = new System.Drawing.Point(524, 179);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(305, 26);
            this.txtGuestName.TabIndex = 10;
            // 
            // lblRoomName
            // 
            this.lblRoomName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Consolas", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblRoomName.Location = new System.Drawing.Point(12, 426);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(209, 45);
            this.lblRoomName.TabIndex = 12;
            this.lblRoomName.Text = "Pipe Room";
            // 
            // lblRoomDetails
            // 
            this.lblRoomDetails.AutoSize = true;
            this.lblRoomDetails.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoomDetails.Location = new System.Drawing.Point(355, 7);
            this.lblRoomDetails.Name = "lblRoomDetails";
            this.lblRoomDetails.Size = new System.Drawing.Size(259, 43);
            this.lblRoomDetails.TabIndex = 13;
            this.lblRoomDetails.Text = "Room Details";
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoomPrice.Location = new System.Drawing.Point(589, 76);
            this.lblRoomPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(240, 22);
            this.lblRoomPrice.TabIndex = 14;
            this.lblRoomPrice.Text = "Price: 1,500/ per night";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoomID.Location = new System.Drawing.Point(416, 76);
            this.lblRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(80, 22);
            this.lblRoomID.TabIndex = 16;
            this.lblRoomID.Text = "Room ID";
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckIn.Location = new System.Drawing.Point(524, 228);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtCheckIn.Size = new System.Drawing.Size(305, 26);
            this.dtCheckIn.TabIndex = 19;
            this.dtCheckIn.ValueChanged += new System.EventHandler(this.dtCheckIn_ValueChanged);
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckOut.Location = new System.Drawing.Point(524, 283);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(305, 26);
            this.dtCheckOut.TabIndex = 20;
            this.dtCheckOut.ValueChanged += new System.EventHandler(this.dtCheckOut_ValueChanged);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCheckIn.Location = new System.Drawing.Point(381, 228);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(118, 24);
            this.lblCheckIn.TabIndex = 21;
            this.lblCheckIn.Text = "Check In.";
            // 
            // lblBedCapacity
            // 
            this.lblBedCapacity.AutoSize = true;
            this.lblBedCapacity.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBedCapacity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBedCapacity.Location = new System.Drawing.Point(635, 141);
            this.lblBedCapacity.Name = "lblBedCapacity";
            this.lblBedCapacity.Size = new System.Drawing.Size(178, 24);
            this.lblBedCapacity.TabIndex = 23;
            this.lblBedCapacity.Text = "Bed Capacity: ";
            // 
            // lblAmenities
            // 
            this.lblAmenities.AutoSize = true;
            this.lblAmenities.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmenities.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAmenities.Location = new System.Drawing.Point(344, 331);
            this.lblAmenities.Name = "lblAmenities";
            this.lblAmenities.Size = new System.Drawing.Size(159, 34);
            this.lblAmenities.TabIndex = 26;
            this.lblAmenities.Text = "Amenities";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Location = new System.Drawing.Point(721, 457);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 41);
            this.btnSubmit.TabIndex = 27;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoomNum.Location = new System.Drawing.Point(464, 108);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(82, 24);
            this.lblRoomNum.TabIndex = 28;
            this.lblRoomNum.Text = "label1";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(15, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 37);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEditAmenities
            // 
            this.btnEditAmenities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditAmenities.FlatAppearance.BorderSize = 0;
            this.btnEditAmenities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAmenities.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAmenities.ForeColor = System.Drawing.Color.White;
            this.btnEditAmenities.Location = new System.Drawing.Point(527, 327);
            this.btnEditAmenities.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditAmenities.Name = "btnEditAmenities";
            this.btnEditAmenities.Size = new System.Drawing.Size(98, 37);
            this.btnEditAmenities.TabIndex = 30;
            this.btnEditAmenities.Text = "Edit";
            this.btnEditAmenities.UseVisualStyleBackColor = false;
            this.btnEditAmenities.Click += new System.EventHandler(this.btnEditAmenities_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(381, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Check Out.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(721, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Total:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalPrice.Location = new System.Drawing.Point(722, 412);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(40, 17);
            this.lblTotalPrice.TabIndex = 33;
            this.lblTotalPrice.Text = "....";
            // 
            // dgvAmenities
            // 
            this.dgvAmenities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmenities.Location = new System.Drawing.Point(350, 368);
            this.dgvAmenities.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAmenities.Name = "dgvAmenities";
            this.dgvAmenities.RowHeadersWidth = 51;
            this.dgvAmenities.RowTemplate.Height = 24;
            this.dgvAmenities.Size = new System.Drawing.Size(366, 130);
            this.dgvAmenities.TabIndex = 34;
            // 
            // lblBedCap
            // 
            this.lblBedCap.AutoSize = true;
            this.lblBedCap.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBedCap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBedCap.Location = new System.Drawing.Point(795, 141);
            this.lblBedCap.Name = "lblBedCap";
            this.lblBedCap.Size = new System.Drawing.Size(34, 24);
            this.lblBedCap.TabIndex = 35;
            this.lblBedCap.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(358, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 36;
            this.label3.Text = "ID: ";
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNights.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNights.Location = new System.Drawing.Point(795, 110);
            this.lblNights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(30, 22);
            this.lblNights.TabIndex = 37;
            this.lblNights.Text = "00";
            // 
            // frmSingleViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(845, 521);
            this.Controls.Add(this.lblNights);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBedCap);
            this.Controls.Add(this.dgvAmenities);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditAmenities);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblRoomNum);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAmenities);
            this.Controls.Add(this.lblBedCapacity);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.dtCheckIn);
            this.Controls.Add(this.lblRoomID);
            this.Controls.Add(this.lblRoomPrice);
            this.Controls.Add(this.lblRoomDetails);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.txtGuestNo);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.lblDaysOfStay);
            this.Controls.Add(this.lblGuestNo);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.ptbPictureSingle);
            this.Name = "frmSingleViewForm";
            this.Text = "SingleViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.ptbPictureSingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmenities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbPictureSingle;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblGuestNo;
        private System.Windows.Forms.Label lblDaysOfStay;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TextBox txtGuestNo;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblRoomDetails;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.DateTimePicker dtCheckIn;
        private System.Windows.Forms.DateTimePicker dtCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblBedCapacity;
        private System.Windows.Forms.Label lblAmenities;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEditAmenities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.DataGridView dgvAmenities;
        private System.Windows.Forms.Label lblBedCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNights;
    }
}