using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn3main1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Button currenButton;
        public void loadform(object form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }
        private Form activeForm = null;

        //mo form moi
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void SetDateMenuButtonUI(object button)
        {
            var btn = (Button)button;
            //Hightlight button
            btn.BackColor = btnHome.FlatAppearance.BorderColor;
            btn.ForeColor = Color.Black;
            //unHighlight button
            if (currenButton != null && currenButton != btn)
            {
                currenButton.BackColor = this.BackColor;
                currenButton.ForeColor = Color.FromArgb(0, 0, 0);
            }
            currenButton = btn;
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            //loadform(new KhachHangForm());
            openChildForm(new DatPhong());
            SetDateMenuButtonUI(sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonUI(sender);
            if (activeForm != null)
                activeForm.Close();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonUI(sender);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonUI(sender);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonUI(sender);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonUI(sender);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonUI(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new DatPhong1());
            SetDateMenuButtonUI(sender);
        }
        private void btnPhong3_Click(object sender, EventArgs e)
        {
            ShowDialog(new ChiTietPhongForm());
        }
    }
}
