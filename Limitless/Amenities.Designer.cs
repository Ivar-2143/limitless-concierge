namespace Limitless
{
    partial class frmAmenities
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
            this.lblAmenities = new System.Windows.Forms.Label();
            this.pnlServices = new System.Windows.Forms.Panel();
            this.lblConsumablePrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHygiene = new System.Windows.Forms.Panel();
            this.lblHygienePrice = new System.Windows.Forms.Label();
            this.lblEssential = new System.Windows.Forms.Label();
            this.pnlOthers = new System.Windows.Forms.Panel();
            this.lblOthersPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlTotalPrice = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.flPnlEssential = new System.Windows.Forms.FlowLayoutPanel();
            this.flPnlServices = new System.Windows.Forms.FlowLayoutPanel();
            this.flPnlOthers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlServices.SuspendLayout();
            this.pnlHygiene.SuspendLayout();
            this.pnlOthers.SuspendLayout();
            this.pnlTotalPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAmenities
            // 
            this.lblAmenities.AutoSize = true;
            this.lblAmenities.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmenities.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAmenities.Location = new System.Drawing.Point(346, 10);
            this.lblAmenities.Name = "lblAmenities";
            this.lblAmenities.Size = new System.Drawing.Size(159, 34);
            this.lblAmenities.TabIndex = 27;
            this.lblAmenities.Text = "Amenities";
            // 
            // pnlServices
            // 
            this.pnlServices.BackColor = System.Drawing.Color.White;
            this.pnlServices.Controls.Add(this.flPnlServices);
            this.pnlServices.Controls.Add(this.lblConsumablePrice);
            this.pnlServices.Controls.Add(this.label1);
            this.pnlServices.Location = new System.Drawing.Point(13, 47);
            this.pnlServices.Name = "pnlServices";
            this.pnlServices.Size = new System.Drawing.Size(402, 288);
            this.pnlServices.TabIndex = 28;
            // 
            // lblConsumablePrice
            // 
            this.lblConsumablePrice.AutoSize = true;
            this.lblConsumablePrice.BackColor = System.Drawing.Color.White;
            this.lblConsumablePrice.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumablePrice.ForeColor = System.Drawing.Color.Black;
            this.lblConsumablePrice.Location = new System.Drawing.Point(303, 9);
            this.lblConsumablePrice.Name = "lblConsumablePrice";
            this.lblConsumablePrice.Size = new System.Drawing.Size(95, 34);
            this.lblConsumablePrice.TabIndex = 31;
            this.lblConsumablePrice.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 34);
            this.label1.TabIndex = 28;
            this.label1.Text = "Services";
            // 
            // pnlHygiene
            // 
            this.pnlHygiene.BackColor = System.Drawing.Color.White;
            this.pnlHygiene.Controls.Add(this.flPnlEssential);
            this.pnlHygiene.Controls.Add(this.lblHygienePrice);
            this.pnlHygiene.Controls.Add(this.lblEssential);
            this.pnlHygiene.Location = new System.Drawing.Point(421, 47);
            this.pnlHygiene.Name = "pnlHygiene";
            this.pnlHygiene.Size = new System.Drawing.Size(402, 288);
            this.pnlHygiene.TabIndex = 29;
            // 
            // lblHygienePrice
            // 
            this.lblHygienePrice.AutoSize = true;
            this.lblHygienePrice.BackColor = System.Drawing.Color.White;
            this.lblHygienePrice.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHygienePrice.ForeColor = System.Drawing.Color.Black;
            this.lblHygienePrice.Location = new System.Drawing.Point(303, 9);
            this.lblHygienePrice.Name = "lblHygienePrice";
            this.lblHygienePrice.Size = new System.Drawing.Size(95, 34);
            this.lblHygienePrice.TabIndex = 32;
            this.lblHygienePrice.Text = "Price";
            // 
            // lblEssential
            // 
            this.lblEssential.AutoSize = true;
            this.lblEssential.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEssential.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEssential.Location = new System.Drawing.Point(3, 9);
            this.lblEssential.Name = "lblEssential";
            this.lblEssential.Size = new System.Drawing.Size(175, 34);
            this.lblEssential.TabIndex = 28;
            this.lblEssential.Text = "Essentials";
            // 
            // pnlOthers
            // 
            this.pnlOthers.BackColor = System.Drawing.Color.White;
            this.pnlOthers.Controls.Add(this.flPnlOthers);
            this.pnlOthers.Controls.Add(this.lblOthersPrice);
            this.pnlOthers.Controls.Add(this.label3);
            this.pnlOthers.Location = new System.Drawing.Point(13, 341);
            this.pnlOthers.Name = "pnlOthers";
            this.pnlOthers.Size = new System.Drawing.Size(402, 288);
            this.pnlOthers.TabIndex = 30;
            // 
            // lblOthersPrice
            // 
            this.lblOthersPrice.AutoSize = true;
            this.lblOthersPrice.BackColor = System.Drawing.Color.White;
            this.lblOthersPrice.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOthersPrice.ForeColor = System.Drawing.Color.Black;
            this.lblOthersPrice.Location = new System.Drawing.Point(303, 9);
            this.lblOthersPrice.Name = "lblOthersPrice";
            this.lblOthersPrice.Size = new System.Drawing.Size(95, 34);
            this.lblOthersPrice.TabIndex = 32;
            this.lblOthersPrice.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 34);
            this.label3.TabIndex = 28;
            this.label3.Text = "Others";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConfirm.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm.Location = new System.Drawing.Point(507, 528);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(243, 88);
            this.btnConfirm.TabIndex = 31;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // pnlTotalPrice
            // 
            this.pnlTotalPrice.BackColor = System.Drawing.Color.White;
            this.pnlTotalPrice.Controls.Add(this.lblTotalPrice);
            this.pnlTotalPrice.Location = new System.Drawing.Point(459, 399);
            this.pnlTotalPrice.Name = "pnlTotalPrice";
            this.pnlTotalPrice.Size = new System.Drawing.Size(327, 97);
            this.pnlTotalPrice.TabIndex = 32;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(3, 1);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(207, 34);
            this.lblTotalPrice.TabIndex = 29;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // flPnlEssential
            // 
            this.flPnlEssential.AutoScroll = true;
            this.flPnlEssential.Location = new System.Drawing.Point(0, 51);
            this.flPnlEssential.Name = "flPnlEssential";
            this.flPnlEssential.Size = new System.Drawing.Size(402, 237);
            this.flPnlEssential.TabIndex = 32;
            // 
            // flPnlServices
            // 
            this.flPnlServices.AutoScroll = true;
            this.flPnlServices.Location = new System.Drawing.Point(0, 51);
            this.flPnlServices.Name = "flPnlServices";
            this.flPnlServices.Size = new System.Drawing.Size(402, 237);
            this.flPnlServices.TabIndex = 33;
            // 
            // flPnlOthers
            // 
            this.flPnlOthers.AutoScroll = true;
            this.flPnlOthers.Location = new System.Drawing.Point(0, 58);
            this.flPnlOthers.Name = "flPnlOthers";
            this.flPnlOthers.Size = new System.Drawing.Size(402, 237);
            this.flPnlOthers.TabIndex = 34;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(13, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 34);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAmenities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(833, 640);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlTotalPrice);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pnlOthers);
            this.Controls.Add(this.pnlHygiene);
            this.Controls.Add(this.pnlServices);
            this.Controls.Add(this.lblAmenities);
            this.Name = "frmAmenities";
            this.Text = "Amenities";
            this.pnlServices.ResumeLayout(false);
            this.pnlServices.PerformLayout();
            this.pnlHygiene.ResumeLayout(false);
            this.pnlHygiene.PerformLayout();
            this.pnlOthers.ResumeLayout(false);
            this.pnlOthers.PerformLayout();
            this.pnlTotalPrice.ResumeLayout(false);
            this.pnlTotalPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmenities;
        private System.Windows.Forms.Panel pnlServices;
        private System.Windows.Forms.Label lblConsumablePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlHygiene;
        private System.Windows.Forms.Label lblHygienePrice;
        private System.Windows.Forms.Label lblEssential;
        private System.Windows.Forms.Panel pnlOthers;
        private System.Windows.Forms.Label lblOthersPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel pnlTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.FlowLayoutPanel flPnlServices;
        private System.Windows.Forms.FlowLayoutPanel flPnlEssential;
        private System.Windows.Forms.FlowLayoutPanel flPnlOthers;
        private System.Windows.Forms.Button btnCancel;
    }
}