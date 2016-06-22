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
    public partial class FormPinCode : Form
    {
        private DateTime dateTimeObject = new DateTime();
        
        public FormPinCode()
        {
            InitializeComponent();        
        }

        private void buttonAdminPinCode_Click(object sender, EventArgs e)
        {
            FormAdminLogin adminLoginWindow = new FormAdminLogin();
            adminLoginWindow.ShowDialog();
        }

        private void buttonExitPinCode_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }

        private void buttonAboutPinCode_Click(object sender, EventArgs e)
        {
            FormAbout window = new FormAbout();
            window.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimeObject = DateTime.Now;
            timeLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", dateTimeObject.Hour, dateTimeObject.Minute, dateTimeObject.Second);
            dayLabel.Text = dateTimeObject.ToLongDateString();
        }

        private void buttonOkPinCode_Click(object sender, EventArgs e)
        {     
            try
            {
                if (txtUserName.Text!=string.Empty && textBoxPinPinCode.Text != string.Empty)
                {
                    GateWay gateWayObject = new GateWay();
                    DataTable dataTableObject = new DataTable();
                    Customer customerObject = new Customer();
                    dataTableObject = gateWayObject.SelectData("Select * from customer where customer.pin_code='" + textBoxPinPinCode.Text + "' and customer.user_name='" + txtUserName.Text + "'");
                    if (dataTableObject.Rows.Count == 1)
                    {
                        DataRow dr = dataTableObject.Rows[0];
                        customerObject.name = dr["c_name"].ToString();
                        customerObject.userName = dr["user_name"].ToString();
                        customerObject.address = dr["address"].ToString();
                        customerObject.phone = dr["phone"].ToString();
                        customerObject.pinCode = dr["pin_code"].ToString();
                        customerObject.acc_no = dr["account_no"].ToString();
                        customerObject.balance = Convert.ToDecimal(dr["balance"]);

                        txtUserName.Clear();
                        textBoxPinPinCode.Clear();
                        FormMainMenu window = new FormMainMenu(customerObject);
                        window.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid UserName or PinCode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("UserName or PinCode should not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtUserName.Clear();
            textBoxPinPinCode.Clear();
        }

        private void buttonClearPinCode_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            textBoxPinPinCode.Clear();
        }

        private void textBoxPinPinCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonOkPinCode_Click(this, new EventArgs());
            }
        }

    }
}
