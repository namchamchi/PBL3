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
    public partial class btnPhong : UserControl
    {
        public string IteamID { get; set; }
        public string ItemMaPhong
        {
            get { return labMaPhong.Text; }
            set { labMaPhong.Text = value; }
        }
        public string ItemTinhTrang
        {
            get { return labTinhTrangPhong.Text; }
            set { labTinhTrangPhong.Text = value; }
        }
        public string ItemTrangThai
        {
            get { return labTrangThai.Text; }
            set { labTrangThai.Text = value; }
        }
        public string ItemSoNgay
        {
            get { return labSoNgay.Text; }
            set { labSoNgay.Text = value; }
        }
        public string ItemDondep
        {
            get { return labDonDep.Text; }
            set { labDonDep.Text = value; }
        }
        public btnPhong()
        {
            InitializeComponent();
        }
        private void labTinhTrangPhong_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
