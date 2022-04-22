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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "332001")
            {
                this.Hide();
                MainForm form1 = new MainForm();
                form1.ShowDialog();
            }
            else
                MessageBox.Show("Sai tai khoa hoac mat khau");

                 
        }
    }
}
