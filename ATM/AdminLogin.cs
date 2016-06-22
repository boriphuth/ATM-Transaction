using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATM
{
    public partial class FormAdminLogin : Form
    {
        public FormAdminLogin()
        {
            InitializeComponent();
        }

        private void buttonCancelAdminLogin_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void buttonOkAdminLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserNameAdminLogin.Text == "mm" && textBoxPasswordAdminLogin.Text == "123")
            {
                this.Close();
                FormAddNewUsers window = new FormAddNewUsers();
                window.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid name or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUserNameAdminLogin.Clear();
                textBoxPasswordAdminLogin.Clear();
            }
        }

        private void textBoxUserNameAdminLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonOkAdminLogin_Click(this, new EventArgs());
            }
        }

    }
}
