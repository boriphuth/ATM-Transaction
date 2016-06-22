using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Transactions;

namespace ATM
{
    public partial class FormMainMenu : Form
    {
        Customer customerObject;
        DataTable dataTableObject = new DataTable();
        GateWay gateWayObject = new GateWay();

        public FormMainMenu()
        {
            InitializeComponent();            
        }
        public FormMainMenu(Customer cObject)
        {
            InitializeComponent();
            customerObject = cObject;
        }

        private void VisibleFalse()
        {
            balanceGroupBox.Visible = false;
            transferGroupBox.Visible = false;
            depositCashGroupBox.Visible = false;
            withdrawCashGroupBox.Visible = false;
            transferHistoryGroupBox.Visible = false;
            lblDescription.Visible = false;
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            VisibleFalse();
            balanceGroupBox.Location = new Point(150, 169);
            transferGroupBox.Location = new Point(150, 169);
            depositCashGroupBox.Location = new Point(150, 169);
            withdrawCashGroupBox.Location = new Point(150, 169);
            transferHistoryGroupBox.Location = new Point(150, 169);

            lblName.Text = customerObject.name;
            string sqlSrring = "select customer.c_name, transfer_history.ammount from customer, transfer_history where acc_to='" + customerObject.acc_no + "' and notification = 1 and acc_from=account_no";
            dataTableObject = gateWayObject.SelectData(sqlSrring);
            if (dataTableObject.Rows.Count > 0)
            {
                lblNotification.Text = dataTableObject.Rows.Count.ToString() + " Notification(s).";
                lblNotification.Visible = true;
            }
        }

        private void buttonBalanceInquiry_Click(object sender, EventArgs e)
        {
            VisibleFalse();
            balanceGroupBox.Visible = true;
            txtBalance.Text = customerObject.balance.ToString();
        }

        private void buttonTransferCash_Click(object sender, EventArgs e)
        {
            VisibleFalse();
            transferGroupBox.Visible = true;
            txtGuestAcc.Select();
        }

        private void buttonDepositCash_Click(object sender, EventArgs e)
        {
            VisibleFalse();
            depositCashGroupBox.Visible = true;
            textBoxDepositCash.Select();
        }

        private void buttonWithdrawCash_Click(object sender, EventArgs e)
        {
            VisibleFalse();
            withdrawCashGroupBox.Visible = true;
            textBoxEnterAmountWithdrawCash.Select();
        }

        private void buttonExitMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDepositDepositCash_Click(object sender, EventArgs e)
        {
            try
            {
                customerObject.balance += Convert.ToDecimal(textBoxDepositCash.Text);
                GateWay gateWayObject = new GateWay();
                string updateString = "update customer set balance=" + customerObject.balance + " where account_no='" + customerObject.acc_no + "'";               

                string insertString = @"INSERT INTO [diposit_history] (account_no, date, ammount) VALUES (@account_no, @date, @ammount)";
                List<SqlParameter> parameter = new List<SqlParameter>();
                parameter.Add(new SqlParameter("@account_no", customerObject.acc_no));
                parameter.Add(new SqlParameter("@date", (DateTime.Now).ToString()));
                parameter.Add(new SqlParameter("@ammount", Convert.ToDecimal(textBoxDepositCash.Text)));

                if (gateWayObject.updateData(updateString) && gateWayObject.InsertData(insertString, parameter))
                {
                    MessageBox.Show("Deposit Successfull.\nNew balance" + customerObject.balance);
                }
                else
                {
                    MessageBox.Show("Error in Deposit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxDepositCash.Clear();

        }

        private void buttonExitDepositCash_Click(object sender, EventArgs e)
        {
            depositCashGroupBox.Visible = false;
        }

        private void buttonWithdrawWithdrawCash_Click(object sender, EventArgs e)
        {
            try
            {
                customerObject.balance -= Convert.ToDecimal(textBoxEnterAmountWithdrawCash.Text);
                GateWay gateWayObject = new GateWay();
                string updateString = "update customer set balance=" + customerObject.balance + " where account_no='" + customerObject.acc_no + "'";

                string insertString = @"INSERT INTO [withdraw_history] (account_no, date, ammount) VALUES (@account_no, @date, @ammount)";
                List<SqlParameter> parameter = new List<SqlParameter>();
                parameter.Add(new SqlParameter("@account_no", customerObject.acc_no));
                parameter.Add(new SqlParameter("@date", (DateTime.Now).ToString()));
                parameter.Add(new SqlParameter("@ammount", Convert.ToDecimal(textBoxEnterAmountWithdrawCash.Text)));
                
                if (gateWayObject.updateData(updateString) && gateWayObject.InsertData(insertString, parameter))
                {
                    MessageBox.Show("Withdraw Successfull.\nNew balance" + customerObject.balance);
                }
                else
                {
                    MessageBox.Show("Error in Withdraw.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxEnterAmountWithdrawCash.Clear();

        }

        private void buttonExitWithdrawCash_Click(object sender, EventArgs e)
        {
            withdrawCashGroupBox.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            balanceGroupBox.Visible = false;
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGuestAcc.Text != string.Empty && txtTransferAmount.Text != string.Empty)
                {
                    GateWay gateWayObject = new GateWay();
                    DataTable dataTableObject = new DataTable();
                    string sqlString = "select account_no from customer where account_no='" + txtGuestAcc.Text + "'"; // determine whether the account is exist.

                    dataTableObject = gateWayObject.SelectData(sqlString);
                    //DataRow dr = dataTableObject.Rows[0];
                    if (dataTableObject.Rows.Count == 1 && txtGuestAcc.Text != customerObject.acc_no)
                    {
                        customerObject.balance -= Convert.ToDecimal(txtTransferAmount.Text);                      

                        string updateCustomerString = "update customer set balance=" + customerObject.balance + " where account_no='" + customerObject.acc_no + "'";
                        string updateGusetString = "update customer set balance=balance+" + txtTransferAmount.Text + " where account_no='" + txtGuestAcc.Text + "'";

                        //insert into transfer_history table
                        string insertString = @"INSERT INTO [transfer_history] (date, acc_from, acc_to, ammount, notification) VALUES (@date, @acc_from, @acc_to, @ammount, @notification)";
                        List<SqlParameter> parameter = new List<SqlParameter>();

                        parameter.Add(new SqlParameter("@date", (DateTime.Now).ToString()));
                        parameter.Add(new SqlParameter("@acc_from", customerObject.acc_no));
                        parameter.Add(new SqlParameter("@acc_to", txtGuestAcc.Text));
                        parameter.Add(new SqlParameter("@ammount", Convert.ToDecimal(txtTransferAmount.Text)));
                        parameter.Add(new SqlParameter("@notification", 1));
                      
                        if (gateWayObject.updateData(updateCustomerString) && gateWayObject.updateData(updateGusetString) && gateWayObject.InsertData(insertString, parameter))
                        {
                            MessageBox.Show("Transfer Successfull.\nNew balance" + customerObject.balance);
                        }
                        else
                        {
                            MessageBox.Show("Error in Transfer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid account number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Account number or Amount should not be empty.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtGuestAcc.Clear();
            txtTransferAmount.Clear();
        }

        private void buttonExitTransferCash_Click(object sender, EventArgs e)
        {
            transferGroupBox.Visible = false;
        }

        private void textBoxDepositCash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonDepositDepositCash_Click(this, new EventArgs());
            }
        }

        private void textBoxEnterAmountWithdrawCash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonWithdrawWithdrawCash_Click(this, new EventArgs());
            }
        }

        private void txtGuestAcc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonTransfer_Click(this, new EventArgs());
            }
        }

        private void buttonTransactionHistory_Click(object sender, EventArgs e)
        {
            VisibleFalse();
            transferHistoryGroupBox.Visible = true;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings window = new FormSettings(customerObject);
            window.ShowDialog();
        }

        private void lblDiposit_Click(object sender, EventArgs e)
        {
            History window = new History("deposit", customerObject);
            window.ShowDialog();
        }

        private void lblWithdraw_Click(object sender, EventArgs e)
        {
            History window = new History("withdraw", customerObject);
            window.ShowDialog();
        }

        private void lblTransfer_Click(object sender, EventArgs e)
        {
            History window = new History("transfer", customerObject);
            window.ShowDialog();
        }

        private void lblNotification_Click(object sender, EventArgs e)
        {
            VisibleFalse();
            lblDescription.Location = new Point(200, 200);
            lblDescription.Text = "";
            for (int i = 0; i < dataTableObject.Rows.Count; i++)
            {
                lblDescription.Text += dataTableObject.Rows[i]["c_name"].ToString() + " sends you TK " + dataTableObject.Rows[i]["ammount"].ToString() + "\n";                
            }
            lblDescription.Visible = true;
            lblNotification.Visible = false;
            string sqlString = "update transfer_history set notification = 0 where acc_to='" + customerObject.acc_no + "' and notification = 1";
            if (!gateWayObject.updateData(sqlString))
            {
                MessageBox.Show("Notiication update error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
