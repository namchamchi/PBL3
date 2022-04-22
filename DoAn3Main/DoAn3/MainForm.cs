using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn3
{
    public partial class MainForm : Form
    {
        private Button currenButton;
        public MainForm()
        {
            InitializeComponent();
        }
        public void loadform(object form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel2.Tag = f;
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
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
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
            if(currenButton !=null&&currenButton!=btn)
            {
                currenButton.BackColor = this.BackColor;
                currenButton.ForeColor = Color.FromArgb(0,0,0);
            }
            currenButton = btn;
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            //loadform(new KhachHangForm());
            openChildForm(new KhachHangForm());
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
            openChildForm(new DatPhong());
            SetDateMenuButtonUI(sender);
        }
    }
}
