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
    public partial class FormSettings : Form
    {
        Customer customerObject;
        public FormSettings(Customer cObject)
        {
            InitializeComponent();
            customerObject = cObject;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            txtName.Text = customerObject.name;
            txtUserName.Text = customerObject.userName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewUserName.Text != string.Empty && txtNewPinCode.Text != string.Empty && txtConfirmNewPinCode.Text != string.Empty)
            {
                try
                {
                    GateWay gateWayObject = new GateWay();
                    DataTable dataTableObject = new DataTable();

                    customerObject.userName = txtNewUserName.Text;
                    customerObject.pinCode = txtNewPinCode.Text;
                    if (txtNewPinCode.Text != txtConfirmNewPinCode.Text)
                    {
                        throw new Exception("Confirm PinCode does not match.");
                    }

                    dataTableObject = gateWayObject.SelectData("select * from customer");
                    bool found = false;
                    for (int i = 0; i < dataTableObject.Rows.Count; i++)  // check if the user name already exist
                    {
                        if (dataTableObject.Rows[i]["user_name"].ToString() == customerObject.userName)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (found)
                    {
                        MessageBox.Show("This user name already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string updateString = "update customer set user_name='" + customerObject.userName + "',pin_code='" + customerObject.pinCode + "' where account_no='" + customerObject.acc_no + "'";
                        if (gateWayObject.updateData(updateString))
                        {
                            MessageBox.Show("UserName and PinCode is updated.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Field should not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnClear_Click(this, new EventArgs());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNewUserName.Clear();
            txtNewPinCode.Clear();
            txtConfirmNewPinCode.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
