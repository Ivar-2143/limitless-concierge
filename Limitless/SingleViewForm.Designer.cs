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
            this.txtDaysOfStay = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblRoomDetails = new System.Windows.Forms.Label();
            this.lblRoomPrice = new System.Windows.Forms.Label();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.txtBedCapacity = new System.Windows.Forms.TextBox();
            this.lblBedCapacity = new System.Windows.Forms.Label();
            this.lblAmenities = new System.Windows.Forms.Label();
            this.btnSubmitSingle = new System.Windows.Forms.Button();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEditAmenities = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.dgvAmenities = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPictureSingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmenities)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbPictureSingle
            // 
            this.ptbPictureSingle.Image = ((System.Drawing.Image)(resources.GetObject("ptbPictureSingle.Image")));
            this.ptbPictureSingle.Location = new System.Drawing.Point(13, 74);
            this.ptbPictureSingle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbPictureSingle.Name = "ptbPictureSingle";
            this.ptbPictureSingle.Size = new System.Drawing.Size(435, 418);
            this.ptbPictureSingle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPictureSingle.TabIndex = 0;
            this.ptbPictureSingle.TabStop = false;
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoomNo.Location = new System.Drawing.Point(477, 121);
            this.lblRoomNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(134, 32);
            this.lblRoomNo.TabIndex = 3;
            this.lblRoomNo.Text = "Room No.";
            // 
            // lblGuestNo
            // 
            this.lblGuestNo.AutoSize = true;
            this.lblGuestNo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGuestNo.Location = new System.Drawing.Point(475, 168);
            this.lblGuestNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestNo.Name = "lblGuestNo";
            this.lblGuestNo.Size = new System.Drawing.Size(149, 32);
            this.lblGuestNo.TabIndex = 4;
            this.lblGuestNo.Text = "Guest No.";
            // 
            // lblDaysOfStay
            // 
            this.lblDaysOfStay.AutoSize = true;
            this.lblDaysOfStay.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysOfStay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDaysOfStay.Location = new System.Drawing.Point(713, 122);
            this.lblDaysOfStay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDaysOfStay.Name = "lblDaysOfStay";
            this.lblDaysOfStay.Size = new System.Drawing.Size(209, 32);
            this.lblDaysOfStay.TabIndex = 5;
            this.lblDaysOfStay.Text = "Days of Stay:";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGuestName.Location = new System.Drawing.Point(508, 220);
            this.lblGuestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(179, 32);
            this.lblGuestName.TabIndex = 6;
            this.lblGuestName.Text = "Guest Name:";
            // 
            // txtGuestNo
            // 
            this.txtGuestNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestNo.Location = new System.Drawing.Point(625, 168);
            this.txtGuestNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGuestNo.Name = "txtGuestNo";
            this.txtGuestNo.Size = new System.Drawing.Size(95, 30);
            this.txtGuestNo.TabIndex = 8;
            // 
            // txtDaysOfStay
            // 
            this.txtDaysOfStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaysOfStay.Location = new System.Drawing.Point(930, 121);
            this.txtDaysOfStay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDaysOfStay.Name = "txtDaysOfStay";
            this.txtDaysOfStay.Size = new System.Drawing.Size(224, 30);
            this.txtDaysOfStay.TabIndex = 9;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestName.Location = new System.Drawing.Point(698, 220);
            this.txtGuestName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(405, 30);
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
            this.lblRoomName.Location = new System.Drawing.Point(16, 524);
            this.lblRoomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(258, 55);
            this.lblRoomName.TabIndex = 12;
            this.lblRoomName.Text = "Pipe Room";
            // 
            // lblRoomDetails
            // 
            this.lblRoomDetails.AutoSize = true;
            this.lblRoomDetails.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoomDetails.Location = new System.Drawing.Point(473, 9);
            this.lblRoomDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomDetails.Name = "lblRoomDetails";
            this.lblRoomDetails.Size = new System.Drawing.Size(336, 55);
            this.lblRoomDetails.TabIndex = 13;
            this.lblRoomDetails.Text = "Room Details";
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.AutoSize = true;
            this.lblRoomPrice.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoomPrice.Location = new System.Drawing.Point(813, 74);
            this.lblRoomPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(359, 32);
            this.lblRoomPrice.TabIndex = 14;
            this.lblRoomPrice.Text = "Price: 1,500/ per night";
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoomID.Location = new System.Drawing.Point(477, 74);
            this.lblRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(344, 32);
            this.lblRoomID.TabIndex = 16;
            this.lblRoomID.Text = "Room Type: Single Room";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Location = new System.Drawing.Point(698, 280);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(405, 31);
            this.dtpCheckIn.TabIndex = 19;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Location = new System.Drawing.Point(698, 348);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(405, 31);
            this.dtpCheckOut.TabIndex = 20;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCheckIn.Location = new System.Drawing.Point(508, 280);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(149, 32);
            this.lblCheckIn.TabIndex = 21;
            this.lblCheckIn.Text = "Check In.";
            // 
            // txtBedCapacity
            // 
            this.txtBedCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBedCapacity.Location = new System.Drawing.Point(930, 166);
            this.txtBedCapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBedCapacity.Name = "txtBedCapacity";
            this.txtBedCapacity.Size = new System.Drawing.Size(224, 30);
            this.txtBedCapacity.TabIndex = 24;
            // 
            // lblBedCapacity
            // 
            this.lblBedCapacity.AutoSize = true;
            this.lblBedCapacity.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBedCapacity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBedCapacity.Location = new System.Drawing.Point(713, 166);
            this.lblBedCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBedCapacity.Name = "lblBedCapacity";
            this.lblBedCapacity.Size = new System.Drawing.Size(224, 32);
            this.lblBedCapacity.TabIndex = 23;
            this.lblBedCapacity.Text = "Bed Capacity: ";
            // 
            // lblAmenities
            // 
            this.lblAmenities.AutoSize = true;
            this.lblAmenities.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmenities.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAmenities.Location = new System.Drawing.Point(458, 407);
            this.lblAmenities.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmenities.Name = "lblAmenities";
            this.lblAmenities.Size = new System.Drawing.Size(199, 43);
            this.lblAmenities.TabIndex = 26;
            this.lblAmenities.Text = "Amenities";
            // 
            // btnSubmitSingle
            // 
            this.btnSubmitSingle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSubmitSingle.FlatAppearance.BorderSize = 0;
            this.btnSubmitSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitSingle.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitSingle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmitSingle.Location = new System.Drawing.Point(1028, 544);
            this.btnSubmitSingle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmitSingle.Name = "btnSubmitSingle";
            this.btnSubmitSingle.Size = new System.Drawing.Size(144, 51);
            this.btnSubmitSingle.TabIndex = 27;
            this.btnSubmitSingle.Text = "Submit";
            this.btnSubmitSingle.UseVisualStyleBackColor = false;
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoomNum.Location = new System.Drawing.Point(619, 121);
            this.lblRoomNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(86, 31);
            this.lblRoomNum.TabIndex = 28;
            this.lblRoomNum.Text = "label1";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(20, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 46);
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
            this.btnEditAmenities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAmenities.ForeColor = System.Drawing.Color.White;
            this.btnEditAmenities.Location = new System.Drawing.Point(891, 401);
            this.btnEditAmenities.Name = "btnEditAmenities";
            this.btnEditAmenities.Size = new System.Drawing.Size(130, 46);
            this.btnEditAmenities.TabIndex = 30;
            this.btnEditAmenities.Text = "Edit";
            this.btnEditAmenities.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(508, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "Check Out.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1028, 453);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 32;
            this.label2.Text = "Total:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalPrice.Location = new System.Drawing.Point(1028, 494);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(74, 32);
            this.lblTotalPrice.TabIndex = 33;
            this.lblTotalPrice.Text = "....";
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // dgvAmenities
            // 
            this.dgvAmenities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmenities.Location = new System.Drawing.Point(466, 453);
            this.dgvAmenities.Name = "dgvAmenities";
            this.dgvAmenities.RowHeadersWidth = 51;
            this.dgvAmenities.RowTemplate.Height = 24;
            this.dgvAmenities.Size = new System.Drawing.Size(555, 160);
            this.dgvAmenities.TabIndex = 34;
            // 
            // frmSingleViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1204, 625);
            this.Controls.Add(this.dgvAmenities);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditAmenities);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblRoomNum);
            this.Controls.Add(this.btnSubmitSingle);
            this.Controls.Add(this.lblAmenities);
            this.Controls.Add(this.txtBedCapacity);
            this.Controls.Add(this.lblBedCapacity);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.lblRoomID);
            this.Controls.Add(this.lblRoomPrice);
            this.Controls.Add(this.lblRoomDetails);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.txtDaysOfStay);
            this.Controls.Add(this.txtGuestNo);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.lblDaysOfStay);
            this.Controls.Add(this.lblGuestNo);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.ptbPictureSingle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSingleViewForm";
            this.Text = "SingleViewForm";
            this.Load += new System.EventHandler(this.frmSingleViewForm_Load);
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
        private System.Windows.Forms.TextBox txtDaysOfStay;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblRoomDetails;
        private System.Windows.Forms.Label lblRoomPrice;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.TextBox txtBedCapacity;
        private System.Windows.Forms.Label lblBedCapacity;
        private System.Windows.Forms.Label lblAmenities;
        private System.Windows.Forms.Button btnSubmitSingle;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEditAmenities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.DataGridView dgvAmenities;
    }
}