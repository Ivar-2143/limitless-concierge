namespace Limitless
{
    partial class frmFrontPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFrontPage));
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlWhole = new System.Windows.Forms.Panel();
            this.pnlRoomType = new System.Windows.Forms.Panel();
            this.pnlSingleRoom = new System.Windows.Forms.Panel();
            this.ptbSingleRoom = new System.Windows.Forms.PictureBox();
            this.btnViewSingle = new System.Windows.Forms.Button();
            this.pnlDeluxeRoom = new System.Windows.Forms.Panel();
            this.btnViewDeluxe = new System.Windows.Forms.Button();
            this.ptbDeluxeRoom = new System.Windows.Forms.PictureBox();
            this.pnlResidentRoom = new System.Windows.Forms.Panel();
            this.btnViewResident = new System.Windows.Forms.Button();
            this.ptbResidentRoom = new System.Windows.Forms.PictureBox();
            this.pnlStudioRoom = new System.Windows.Forms.Panel();
            this.btnViewStudio = new System.Windows.Forms.Button();
            this.ptbStudioRoom = new System.Windows.Forms.PictureBox();
            this.btnBookingView = new System.Windows.Forms.Button();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblSingleRoom = new System.Windows.Forms.Label();
            this.lblDeluxeRoom = new System.Windows.Forms.Label();
            this.lblResidentRoom = new System.Windows.Forms.Label();
            this.lblStudioRoom = new System.Windows.Forms.Label();
            this.lblSinglePrice = new System.Windows.Forms.Label();
            this.lblDeluxePrice = new System.Windows.Forms.Label();
            this.lblResidentPrice = new System.Windows.Forms.Label();
            this.lblStudioPrice = new System.Windows.Forms.Label();
            this.lblSingleBed = new System.Windows.Forms.Label();
            this.lblDeluxeBed = new System.Windows.Forms.Label();
            this.lblResidentBed = new System.Windows.Forms.Label();
            this.lblStudioBed = new System.Windows.Forms.Label();
            this.pnlWhole.SuspendLayout();
            this.pnlRoomType.SuspendLayout();
            this.pnlSingleRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSingleRoom)).BeginInit();
            this.pnlDeluxeRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDeluxeRoom)).BeginInit();
            this.pnlResidentRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbResidentRoom)).BeginInit();
            this.pnlStudioRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStudioRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(66, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(172, 38);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "LIMITLESS";
            // 
            // pnlWhole
            // 
            this.pnlWhole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.pnlWhole.Controls.Add(this.lblRoomType);
            this.pnlWhole.Controls.Add(this.btnBookingView);
            this.pnlWhole.Controls.Add(this.pnlRoomType);
            this.pnlWhole.Location = new System.Drawing.Point(12, 50);
            this.pnlWhole.Name = "pnlWhole";
            this.pnlWhole.Size = new System.Drawing.Size(736, 563);
            this.pnlWhole.TabIndex = 1;
            // 
            // pnlRoomType
            // 
            this.pnlRoomType.BackColor = System.Drawing.Color.White;
            this.pnlRoomType.Controls.Add(this.pnlStudioRoom);
            this.pnlRoomType.Controls.Add(this.pnlResidentRoom);
            this.pnlRoomType.Controls.Add(this.pnlDeluxeRoom);
            this.pnlRoomType.Controls.Add(this.pnlSingleRoom);
            this.pnlRoomType.Location = new System.Drawing.Point(14, 54);
            this.pnlRoomType.Name = "pnlRoomType";
            this.pnlRoomType.Size = new System.Drawing.Size(707, 492);
            this.pnlRoomType.TabIndex = 0;
            // 
            // pnlSingleRoom
            // 
            this.pnlSingleRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.pnlSingleRoom.Controls.Add(this.lblSingleBed);
            this.pnlSingleRoom.Controls.Add(this.lblSinglePrice);
            this.pnlSingleRoom.Controls.Add(this.lblSingleRoom);
            this.pnlSingleRoom.Controls.Add(this.btnViewSingle);
            this.pnlSingleRoom.Controls.Add(this.ptbSingleRoom);
            this.pnlSingleRoom.Location = new System.Drawing.Point(13, 12);
            this.pnlSingleRoom.Name = "pnlSingleRoom";
            this.pnlSingleRoom.Size = new System.Drawing.Size(680, 112);
            this.pnlSingleRoom.TabIndex = 0;
            // 
            // ptbSingleRoom
            // 
            this.ptbSingleRoom.Image = ((System.Drawing.Image)(resources.GetObject("ptbSingleRoom.Image")));
            this.ptbSingleRoom.Location = new System.Drawing.Point(4, 3);
            this.ptbSingleRoom.Name = "ptbSingleRoom";
            this.ptbSingleRoom.Size = new System.Drawing.Size(195, 106);
            this.ptbSingleRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSingleRoom.TabIndex = 0;
            this.ptbSingleRoom.TabStop = false;
            // 
            // btnViewSingle
            // 
            this.btnViewSingle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.btnViewSingle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSingle.ForeColor = System.Drawing.Color.White;
            this.btnViewSingle.Location = new System.Drawing.Point(554, 64);
            this.btnViewSingle.Name = "btnViewSingle";
            this.btnViewSingle.Size = new System.Drawing.Size(113, 34);
            this.btnViewSingle.TabIndex = 1;
            this.btnViewSingle.Text = "View";
            this.btnViewSingle.UseVisualStyleBackColor = false;
            // 
            // pnlDeluxeRoom
            // 
            this.pnlDeluxeRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.pnlDeluxeRoom.Controls.Add(this.lblDeluxeBed);
            this.pnlDeluxeRoom.Controls.Add(this.lblDeluxePrice);
            this.pnlDeluxeRoom.Controls.Add(this.lblDeluxeRoom);
            this.pnlDeluxeRoom.Controls.Add(this.btnViewDeluxe);
            this.pnlDeluxeRoom.Controls.Add(this.ptbDeluxeRoom);
            this.pnlDeluxeRoom.Location = new System.Drawing.Point(13, 130);
            this.pnlDeluxeRoom.Name = "pnlDeluxeRoom";
            this.pnlDeluxeRoom.Size = new System.Drawing.Size(680, 112);
            this.pnlDeluxeRoom.TabIndex = 1;
            // 
            // btnViewDeluxe
            // 
            this.btnViewDeluxe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.btnViewDeluxe.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDeluxe.ForeColor = System.Drawing.Color.White;
            this.btnViewDeluxe.Location = new System.Drawing.Point(554, 64);
            this.btnViewDeluxe.Name = "btnViewDeluxe";
            this.btnViewDeluxe.Size = new System.Drawing.Size(113, 34);
            this.btnViewDeluxe.TabIndex = 1;
            this.btnViewDeluxe.Text = "View";
            this.btnViewDeluxe.UseVisualStyleBackColor = false;
            // 
            // ptbDeluxeRoom
            // 
            this.ptbDeluxeRoom.Image = ((System.Drawing.Image)(resources.GetObject("ptbDeluxeRoom.Image")));
            this.ptbDeluxeRoom.Location = new System.Drawing.Point(4, 3);
            this.ptbDeluxeRoom.Name = "ptbDeluxeRoom";
            this.ptbDeluxeRoom.Size = new System.Drawing.Size(195, 106);
            this.ptbDeluxeRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDeluxeRoom.TabIndex = 0;
            this.ptbDeluxeRoom.TabStop = false;
            // 
            // pnlResidentRoom
            // 
            this.pnlResidentRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.pnlResidentRoom.Controls.Add(this.lblResidentBed);
            this.pnlResidentRoom.Controls.Add(this.lblResidentPrice);
            this.pnlResidentRoom.Controls.Add(this.lblResidentRoom);
            this.pnlResidentRoom.Controls.Add(this.btnViewResident);
            this.pnlResidentRoom.Controls.Add(this.ptbResidentRoom);
            this.pnlResidentRoom.Location = new System.Drawing.Point(13, 248);
            this.pnlResidentRoom.Name = "pnlResidentRoom";
            this.pnlResidentRoom.Size = new System.Drawing.Size(680, 112);
            this.pnlResidentRoom.TabIndex = 2;
            // 
            // btnViewResident
            // 
            this.btnViewResident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.btnViewResident.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewResident.ForeColor = System.Drawing.Color.White;
            this.btnViewResident.Location = new System.Drawing.Point(554, 64);
            this.btnViewResident.Name = "btnViewResident";
            this.btnViewResident.Size = new System.Drawing.Size(113, 34);
            this.btnViewResident.TabIndex = 1;
            this.btnViewResident.Text = "View";
            this.btnViewResident.UseVisualStyleBackColor = false;
            // 
            // ptbResidentRoom
            // 
            this.ptbResidentRoom.Image = ((System.Drawing.Image)(resources.GetObject("ptbResidentRoom.Image")));
            this.ptbResidentRoom.Location = new System.Drawing.Point(4, 3);
            this.ptbResidentRoom.Name = "ptbResidentRoom";
            this.ptbResidentRoom.Size = new System.Drawing.Size(195, 106);
            this.ptbResidentRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbResidentRoom.TabIndex = 0;
            this.ptbResidentRoom.TabStop = false;
            // 
            // pnlStudioRoom
            // 
            this.pnlStudioRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.pnlStudioRoom.Controls.Add(this.lblStudioBed);
            this.pnlStudioRoom.Controls.Add(this.lblStudioPrice);
            this.pnlStudioRoom.Controls.Add(this.lblStudioRoom);
            this.pnlStudioRoom.Controls.Add(this.btnViewStudio);
            this.pnlStudioRoom.Controls.Add(this.ptbStudioRoom);
            this.pnlStudioRoom.Location = new System.Drawing.Point(13, 366);
            this.pnlStudioRoom.Name = "pnlStudioRoom";
            this.pnlStudioRoom.Size = new System.Drawing.Size(680, 112);
            this.pnlStudioRoom.TabIndex = 3;
            // 
            // btnViewStudio
            // 
            this.btnViewStudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.btnViewStudio.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStudio.ForeColor = System.Drawing.Color.White;
            this.btnViewStudio.Location = new System.Drawing.Point(554, 64);
            this.btnViewStudio.Name = "btnViewStudio";
            this.btnViewStudio.Size = new System.Drawing.Size(113, 34);
            this.btnViewStudio.TabIndex = 1;
            this.btnViewStudio.Text = "View";
            this.btnViewStudio.UseVisualStyleBackColor = false;
            // 
            // ptbStudioRoom
            // 
            this.ptbStudioRoom.Image = ((System.Drawing.Image)(resources.GetObject("ptbStudioRoom.Image")));
            this.ptbStudioRoom.Location = new System.Drawing.Point(4, 3);
            this.ptbStudioRoom.Name = "ptbStudioRoom";
            this.ptbStudioRoom.Size = new System.Drawing.Size(195, 106);
            this.ptbStudioRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbStudioRoom.TabIndex = 0;
            this.ptbStudioRoom.TabStop = false;
            // 
            // btnBookingView
            // 
            this.btnBookingView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.btnBookingView.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingView.ForeColor = System.Drawing.Color.White;
            this.btnBookingView.Location = new System.Drawing.Point(540, 3);
            this.btnBookingView.Name = "btnBookingView";
            this.btnBookingView.Size = new System.Drawing.Size(167, 45);
            this.btnBookingView.TabIndex = 2;
            this.btnBookingView.Text = "Booking View";
            this.btnBookingView.UseVisualStyleBackColor = false;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoomType.Location = new System.Drawing.Point(37, 11);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(179, 37);
            this.lblRoomType.TabIndex = 3;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblSingleRoom
            // 
            this.lblSingleRoom.AutoSize = true;
            this.lblSingleRoom.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingleRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSingleRoom.Location = new System.Drawing.Point(205, 3);
            this.lblSingleRoom.Name = "lblSingleRoom";
            this.lblSingleRoom.Size = new System.Drawing.Size(142, 24);
            this.lblSingleRoom.TabIndex = 4;
            this.lblSingleRoom.Text = "Single Room";
            // 
            // lblDeluxeRoom
            // 
            this.lblDeluxeRoom.AutoSize = true;
            this.lblDeluxeRoom.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeluxeRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeluxeRoom.Location = new System.Drawing.Point(205, 3);
            this.lblDeluxeRoom.Name = "lblDeluxeRoom";
            this.lblDeluxeRoom.Size = new System.Drawing.Size(142, 24);
            this.lblDeluxeRoom.TabIndex = 5;
            this.lblDeluxeRoom.Text = "Deluxe Room";
            // 
            // lblResidentRoom
            // 
            this.lblResidentRoom.AutoSize = true;
            this.lblResidentRoom.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResidentRoom.Location = new System.Drawing.Point(205, 3);
            this.lblResidentRoom.Name = "lblResidentRoom";
            this.lblResidentRoom.Size = new System.Drawing.Size(166, 24);
            this.lblResidentRoom.TabIndex = 6;
            this.lblResidentRoom.Text = "Resident Room";
            // 
            // lblStudioRoom
            // 
            this.lblStudioRoom.AutoSize = true;
            this.lblStudioRoom.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudioRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStudioRoom.Location = new System.Drawing.Point(205, 3);
            this.lblStudioRoom.Name = "lblStudioRoom";
            this.lblStudioRoom.Size = new System.Drawing.Size(142, 24);
            this.lblStudioRoom.TabIndex = 6;
            this.lblStudioRoom.Text = "Studio Room";
            // 
            // lblSinglePrice
            // 
            this.lblSinglePrice.AutoSize = true;
            this.lblSinglePrice.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinglePrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSinglePrice.Location = new System.Drawing.Point(205, 36);
            this.lblSinglePrice.Name = "lblSinglePrice";
            this.lblSinglePrice.Size = new System.Drawing.Size(153, 19);
            this.lblSinglePrice.TabIndex = 5;
            this.lblSinglePrice.Text = "1,500/ per night";
            // 
            // lblDeluxePrice
            // 
            this.lblDeluxePrice.AutoSize = true;
            this.lblDeluxePrice.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeluxePrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeluxePrice.Location = new System.Drawing.Point(205, 37);
            this.lblDeluxePrice.Name = "lblDeluxePrice";
            this.lblDeluxePrice.Size = new System.Drawing.Size(153, 19);
            this.lblDeluxePrice.TabIndex = 6;
            this.lblDeluxePrice.Text = "3,000/ per night";
            // 
            // lblResidentPrice
            // 
            this.lblResidentPrice.AutoSize = true;
            this.lblResidentPrice.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResidentPrice.Location = new System.Drawing.Point(205, 37);
            this.lblResidentPrice.Name = "lblResidentPrice";
            this.lblResidentPrice.Size = new System.Drawing.Size(153, 19);
            this.lblResidentPrice.TabIndex = 7;
            this.lblResidentPrice.Text = "5,000/ per night";
            // 
            // lblStudioPrice
            // 
            this.lblStudioPrice.AutoSize = true;
            this.lblStudioPrice.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudioPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStudioPrice.Location = new System.Drawing.Point(205, 36);
            this.lblStudioPrice.Name = "lblStudioPrice";
            this.lblStudioPrice.Size = new System.Drawing.Size(153, 19);
            this.lblStudioPrice.TabIndex = 7;
            this.lblStudioPrice.Text = "8,000/ per night";
            // 
            // lblSingleBed
            // 
            this.lblSingleBed.AutoSize = true;
            this.lblSingleBed.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingleBed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSingleBed.Location = new System.Drawing.Point(205, 64);
            this.lblSingleBed.Name = "lblSingleBed";
            this.lblSingleBed.Size = new System.Drawing.Size(54, 19);
            this.lblSingleBed.TabIndex = 6;
            this.lblSingleBed.Text = "1 Bed";
            // 
            // lblDeluxeBed
            // 
            this.lblDeluxeBed.AutoSize = true;
            this.lblDeluxeBed.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeluxeBed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDeluxeBed.Location = new System.Drawing.Point(205, 64);
            this.lblDeluxeBed.Name = "lblDeluxeBed";
            this.lblDeluxeBed.Size = new System.Drawing.Size(99, 19);
            this.lblDeluxeBed.TabIndex = 7;
            this.lblDeluxeBed.Text = "1 King Bed";
            // 
            // lblResidentBed
            // 
            this.lblResidentBed.AutoSize = true;
            this.lblResidentBed.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidentBed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResidentBed.Location = new System.Drawing.Point(205, 64);
            this.lblResidentBed.Name = "lblResidentBed";
            this.lblResidentBed.Size = new System.Drawing.Size(108, 19);
            this.lblResidentBed.TabIndex = 8;
            this.lblResidentBed.Text = "4 Queen Bed";
            // 
            // lblStudioBed
            // 
            this.lblStudioBed.AutoSize = true;
            this.lblStudioBed.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudioBed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStudioBed.Location = new System.Drawing.Point(205, 64);
            this.lblStudioBed.Name = "lblStudioBed";
            this.lblStudioBed.Size = new System.Drawing.Size(54, 19);
            this.lblStudioBed.TabIndex = 9;
            this.lblStudioBed.Text = "2 Bed";
            // 
            // frmFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(760, 619);
            this.Controls.Add(this.pnlWhole);
            this.Controls.Add(this.lblLogo);
            this.Name = "frmFrontPage";
            this.Text = "Front Page";
            this.pnlWhole.ResumeLayout(false);
            this.pnlWhole.PerformLayout();
            this.pnlRoomType.ResumeLayout(false);
            this.pnlSingleRoom.ResumeLayout(false);
            this.pnlSingleRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSingleRoom)).EndInit();
            this.pnlDeluxeRoom.ResumeLayout(false);
            this.pnlDeluxeRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDeluxeRoom)).EndInit();
            this.pnlResidentRoom.ResumeLayout(false);
            this.pnlResidentRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbResidentRoom)).EndInit();
            this.pnlStudioRoom.ResumeLayout(false);
            this.pnlStudioRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStudioRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlWhole;
        private System.Windows.Forms.Panel pnlRoomType;
        private System.Windows.Forms.Panel pnlSingleRoom;
        private System.Windows.Forms.Button btnBookingView;
        private System.Windows.Forms.Panel pnlStudioRoom;
        private System.Windows.Forms.Button btnViewStudio;
        private System.Windows.Forms.PictureBox ptbStudioRoom;
        private System.Windows.Forms.Panel pnlResidentRoom;
        private System.Windows.Forms.Button btnViewResident;
        private System.Windows.Forms.PictureBox ptbResidentRoom;
        private System.Windows.Forms.Panel pnlDeluxeRoom;
        private System.Windows.Forms.Button btnViewDeluxe;
        private System.Windows.Forms.PictureBox ptbDeluxeRoom;
        private System.Windows.Forms.Button btnViewSingle;
        private System.Windows.Forms.PictureBox ptbSingleRoom;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblStudioBed;
        private System.Windows.Forms.Label lblStudioPrice;
        private System.Windows.Forms.Label lblStudioRoom;
        private System.Windows.Forms.Label lblResidentBed;
        private System.Windows.Forms.Label lblResidentPrice;
        private System.Windows.Forms.Label lblResidentRoom;
        private System.Windows.Forms.Label lblDeluxeBed;
        private System.Windows.Forms.Label lblDeluxePrice;
        private System.Windows.Forms.Label lblDeluxeRoom;
        private System.Windows.Forms.Label lblSingleBed;
        private System.Windows.Forms.Label lblSinglePrice;
        private System.Windows.Forms.Label lblSingleRoom;
    }
}

