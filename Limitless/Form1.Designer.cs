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
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlWhole = new System.Windows.Forms.Panel();
            this.flPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.btnBookingView = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.pnlWhole.SuspendLayout();
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
            this.pnlWhole.Controls.Add(this.btnAddItem);
            this.pnlWhole.Controls.Add(this.flPanel);
            this.pnlWhole.Controls.Add(this.lblRoomType);
            this.pnlWhole.Controls.Add(this.btnBookingView);
            this.pnlWhole.Location = new System.Drawing.Point(12, 50);
            this.pnlWhole.Name = "pnlWhole";
            this.pnlWhole.Size = new System.Drawing.Size(736, 563);
            this.pnlWhole.TabIndex = 1;
            // 
            // flPanel
            // 
            this.flPanel.AutoScroll = true;
            this.flPanel.BackColor = System.Drawing.Color.White;
            this.flPanel.Location = new System.Drawing.Point(17, 54);
            this.flPanel.Name = "flPanel";
            this.flPanel.Size = new System.Drawing.Size(707, 492);
            this.flPanel.TabIndex = 4;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoomType.Location = new System.Drawing.Point(54, 11);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(107, 37);
            this.lblRoomType.TabIndex = 3;
            this.lblRoomType.Text = "Rooms";
            // 
            // btnBookingView
            // 
            this.btnBookingView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.btnBookingView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingView.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingView.ForeColor = System.Drawing.Color.White;
            this.btnBookingView.Location = new System.Drawing.Point(557, 3);
            this.btnBookingView.Name = "btnBookingView";
            this.btnBookingView.Size = new System.Drawing.Size(167, 45);
            this.btnBookingView.TabIndex = 2;
            this.btnBookingView.Text = "Booking View";
            this.btnBookingView.UseVisualStyleBackColor = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddItem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(384, 3);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(167, 45);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add item";
            this.btnAddItem.UseVisualStyleBackColor = false;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlWhole;
        private System.Windows.Forms.Button btnBookingView;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.FlowLayoutPanel flPanel;
        private System.Windows.Forms.Button btnAddItem;
    }
}

