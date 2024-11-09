using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                this.Hide();
                new Edit_Menu().Show();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
