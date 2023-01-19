namespace Limitless
{
    partial class BookingView
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
            this.pnlBookingPanel = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBookingUpdate = new System.Windows.Forms.Button();
            this.dgbBookingData = new System.Windows.Forms.DataGridView();
            this.lblBookingName = new System.Windows.Forms.Label();
            this.pnlBookingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbBookingData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBookingPanel
            // 
            this.pnlBookingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.pnlBookingPanel.Controls.Add(this.btnDelete);
            this.pnlBookingPanel.Controls.Add(this.btnBookingUpdate);
            this.pnlBookingPanel.Controls.Add(this.dgbBookingData);
            this.pnlBookingPanel.Location = new System.Drawing.Point(12, 56);
            this.pnlBookingPanel.Name = "pnlBookingPanel";
            this.pnlBookingPanel.Size = new System.Drawing.Size(776, 382);
            this.pnlBookingPanel.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(431, 322);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 41);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnBookingUpdate
            // 
            this.btnBookingUpdate.BackColor = System.Drawing.Color.Green;
            this.btnBookingUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingUpdate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingUpdate.ForeColor = System.Drawing.Color.White;
            this.btnBookingUpdate.Location = new System.Drawing.Point(219, 322);
            this.btnBookingUpdate.Name = "btnBookingUpdate";
            this.btnBookingUpdate.Size = new System.Drawing.Size(122, 41);
            this.btnBookingUpdate.TabIndex = 1;
            this.btnBookingUpdate.Text = "Update";
            this.btnBookingUpdate.UseVisualStyleBackColor = false;
            // 
            // dgbBookingData
            // 
            this.dgbBookingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbBookingData.Location = new System.Drawing.Point(7, 15);
            this.dgbBookingData.Name = "dgbBookingData";
            this.dgbBookingData.Size = new System.Drawing.Size(757, 288);
            this.dgbBookingData.TabIndex = 0;
            // 
            // lblBookingName
            // 
            this.lblBookingName.AutoSize = true;
            this.lblBookingName.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingName.Location = new System.Drawing.Point(12, 9);
            this.lblBookingName.Name = "lblBookingName";
            this.lblBookingName.Size = new System.Drawing.Size(181, 41);
            this.lblBookingName.TabIndex = 1;
            this.lblBookingName.Text = "BOOKING";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBookingName);
            this.Controls.Add(this.pnlBookingPanel);
            this.Name = "Booking";
            this.Text = "Booking";
            this.pnlBookingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbBookingData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBookingPanel;
        private System.Windows.Forms.Label lblBookingName;
        private System.Windows.Forms.DataGridView dgbBookingData;
        private System.Windows.Forms.Button btnBookingUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}