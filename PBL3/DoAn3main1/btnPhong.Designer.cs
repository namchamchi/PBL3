namespace DoAn3main1
{
    partial class btnPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labDonDep = new System.Windows.Forms.Label();
            this.labSoNgay = new System.Windows.Forms.Label();
            this.labTrangThai = new System.Windows.Forms.Label();
            this.labMaPhong = new System.Windows.Forms.Label();
            this.labTinhTrangPhong = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.labDonDep);
            this.panel1.Controls.Add(this.labSoNgay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 23);
            this.panel1.TabIndex = 11;
            // 
            // labDonDep
            // 
            this.labDonDep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.labDonDep.Image = global::DoAn3main1.Properties.Resources.icons8_tick_13;
            this.labDonDep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labDonDep.Location = new System.Drawing.Point(131, 3);
            this.labDonDep.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.labDonDep.Name = "labDonDep";
            this.labDonDep.Size = new System.Drawing.Size(89, 13);
            this.labDonDep.TabIndex = 3;
            this.labDonDep.Text = "Đã dọn dẹp";
            this.labDonDep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labSoNgay
            // 
            this.labSoNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.labSoNgay.Image = global::DoAn3main1.Properties.Resources.icons8_calendar_13;
            this.labSoNgay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labSoNgay.Location = new System.Drawing.Point(12, 3);
            this.labSoNgay.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.labSoNgay.Name = "labSoNgay";
            this.labSoNgay.Size = new System.Drawing.Size(70, 13);
            this.labSoNgay.TabIndex = 2;
            this.labSoNgay.Text = "1 ngày";
            this.labSoNgay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labTrangThai
            // 
            this.labTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTrangThai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labTrangThai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labTrangThai.Location = new System.Drawing.Point(72, 21);
            this.labTrangThai.Name = "labTrangThai";
            this.labTrangThai.Size = new System.Drawing.Size(155, 79);
            this.labTrangThai.TabIndex = 9;
            this.labTrangThai.Text = "Phòng trống";
            this.labTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labTrangThai.Click += new System.EventHandler(this.labTinhTrangPhong_Click);
            // 
            // labMaPhong
            // 
            this.labMaPhong.AutoSize = true;
            this.labMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaPhong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labMaPhong.Location = new System.Drawing.Point(12, 4);
            this.labMaPhong.Name = "labMaPhong";
            this.labMaPhong.Size = new System.Drawing.Size(63, 13);
            this.labMaPhong.TabIndex = 8;
            this.labMaPhong.Text = "Ma phong";
            // 
            // labTinhTrangPhong
            // 
            this.labTinhTrangPhong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labTinhTrangPhong.Location = new System.Drawing.Point(116, 4);
            this.labTinhTrangPhong.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.labTinhTrangPhong.Name = "labTinhTrangPhong";
            this.labTinhTrangPhong.Size = new System.Drawing.Size(104, 13);
            this.labTinhTrangPhong.TabIndex = 7;
            this.labTinhTrangPhong.Text = "Tình trạng phòng";
            this.labTinhTrangPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labTinhTrangPhong.Click += new System.EventHandler(this.labTinhTrangPhong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAn3main1.Properties.Resources.icons8_ok_48;
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.labTinhTrangPhong_Click);
            // 
            // btnPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(214)))), ((int)(((byte)(147)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labTrangThai);
            this.Controls.Add(this.labMaPhong);
            this.Controls.Add(this.labTinhTrangPhong);
            this.Name = "btnPhong";
            this.Size = new System.Drawing.Size(230, 130);
            this.Click += new System.EventHandler(this.labTinhTrangPhong_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labDonDep;
        private System.Windows.Forms.Label labSoNgay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labTrangThai;
        private System.Windows.Forms.Label labMaPhong;
        private System.Windows.Forms.Label labTinhTrangPhong;
    }
}
