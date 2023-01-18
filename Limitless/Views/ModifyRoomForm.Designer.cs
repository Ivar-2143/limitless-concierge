namespace Limitless.Views
{
    partial class ModifyRoomForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblBedCapacity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtBedCap = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ptbRoomImage = new System.Windows.Forms.PictureBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRoomImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room No:";
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNum.Location = new System.Drawing.Point(115, 37);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(54, 23);
            this.lblRoomNum.TabIndex = 1;
            this.lblRoomNum.Text = "0000";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.Location = new System.Drawing.Point(8, 78);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(109, 23);
            this.lblRoomName.TabIndex = 2;
            this.lblRoomName.Text = "Room Name";
            // 
            // lblBedCapacity
            // 
            this.lblBedCapacity.AutoSize = true;
            this.lblBedCapacity.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBedCapacity.Location = new System.Drawing.Point(8, 121);
            this.lblBedCapacity.Name = "lblBedCapacity";
            this.lblBedCapacity.Size = new System.Drawing.Size(142, 23);
            this.lblBedCapacity.TabIndex = 3;
            this.lblBedCapacity.Text = "Bed Capacity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(266, 121);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 23);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomName.Location = new System.Drawing.Point(160, 77);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(311, 26);
            this.txtRoomName.TabIndex = 6;
            // 
            // txtBedCap
            // 
            this.txtBedCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBedCap.Location = new System.Drawing.Point(160, 120);
            this.txtBedCap.Name = "txtBedCap";
            this.txtBedCap.Size = new System.Drawing.Size(70, 26);
            this.txtBedCap.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(337, 120);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(134, 26);
            this.txtPrice.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ptbRoomImage
            // 
            this.ptbRoomImage.Location = new System.Drawing.Point(12, 218);
            this.ptbRoomImage.Name = "ptbRoomImage";
            this.ptbRoomImage.Size = new System.Drawing.Size(300, 175);
            this.ptbRoomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRoomImage.TabIndex = 9;
            this.ptbRoomImage.TabStop = false;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(12, 180);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(65, 23);
            this.lblImage.TabIndex = 5;
            this.lblImage.Text = "Image";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(232, 176);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(80, 32);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(354, 352);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(117, 41);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ModifyRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 405);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.ptbRoomImage);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtBedCap);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblBedCapacity);
            this.Controls.Add(this.lblRoomName);
            this.Controls.Add(this.lblRoomNum);
            this.Controls.Add(this.label1);
            this.Name = "ModifyRoomForm";
            this.Text = "ModifyRoomForm";
            ((System.ComponentModel.ISupportInitialize)(this.ptbRoomImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblBedCapacity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtBedCap;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox ptbRoomImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnConfirm;
    }
}