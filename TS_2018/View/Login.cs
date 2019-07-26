using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TS_2018.Controller;
using TS_2018.Model.Database;
using TS_2018.View;

namespace TS_2018
{
    public partial class Form1 : Form
    {
        private FuncSV controller;

        public Form1()
        {
            InitializeComponent();
            controller = new FuncSV();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username != "" && password != "")
            {
                USER user = controller.Login(username, password);
                if (user != null)
                {
                    ListOfSV mainForm = new ListOfSV();
                    this.Hide();
                    mainForm.CanBoUser = user;
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu hoặc tài khoản không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mật khẩu và tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}