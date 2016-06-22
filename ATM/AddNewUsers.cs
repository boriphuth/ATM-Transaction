using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM
{
    public partial class FormAddNewUsers : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public FormAddNewUsers()
        {
            InitializeComponent();
            //dataGridView1.AutoGenerateColumns = true;
        }

        private void buttonCancelAddNewUsers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddNewUsers_Load(object sender, EventArgs e)
        {
            try
            {
                GateWay gateWayObject = new GateWay();
                bindingSource.DataSource = gateWayObject.SelectData("Select * from customer;");
                dataGridView1.DataSource = bindingSource;

                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

            }
            catch (SqlException)
            {
                MessageBox.Show("Error in DataBase connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddAddNewUsers_Click(object sender, EventArgs e)
        {
            try
            {
                var emptyBoxes = from Control currentControl in Controls
                                where currentControl is TextBox  &&  string.IsNullOrEmpty(currentControl.Text)
                                orderby currentControl.TabIndex
                                select currentControl;
                if (emptyBoxes.Count() > 0)
                {
                    MessageBox.Show("Please fill in all fields.", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    List<SqlParameter> parameter = new List<SqlParameter>();
                    GateWay gateWayObject = new GateWay();
                    DataTable dataTableObject = new DataTable();
                    Customer customerObject = new Customer();

                    customerObject.name = textBoxAddName.Text;
                    customerObject.userName = txtUserName.Text;
                    customerObject.address = textBoxAddAddress.Text;
                    customerObject.phone = textBoxAddPhone.Text;
                    customerObject.pinCode = textBoxAddPin.Text;
                    customerObject.acc_no = textBoxAccountNo.Text;
                    customerObject.balance = Convert.ToDecimal(textBoxAddBalance.Text);
                                        
                    dataTableObject = gateWayObject.SelectData("Select * from customer");
                    bool found = false;
                    for (int i = 0; i < dataTableObject.Rows.Count; i++)    //check if the account no already exists
                    {
                        if (dataTableObject.Rows[i]["account_no"].ToString() == customerObject.acc_no)  //check if the account no already exists
                        {
                            found = true;
                            break;
                        }
                    }

                    if (found) 
                    {
                        MessageBox.Show("Account with this account number already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertString = @"INSERT INTO [customer] (c_name, user_name, address, phone, pin_code, account_no, balance) VALUES (@c_name, @user_name, @address, @phone, @pin_code, @account_no, @balance)";

                        parameter.Add(new SqlParameter("@c_name", customerObject.name));
                        parameter.Add(new SqlParameter("@user_name", customerObject.userName));
                        parameter.Add(new SqlParameter("@address", customerObject.address));
                        parameter.Add(new SqlParameter("@phone", customerObject.phone));
                        parameter.Add(new SqlParameter("@pin_code", customerObject.pinCode));
                        parameter.Add(new SqlParameter("@account_no", customerObject.acc_no));
                        parameter.Add(new SqlParameter("@balance", customerObject.balance));

                        gateWayObject.InsertData(insertString, parameter); // insert into customer table
                        FormAddNewUsers_Load(this, new EventArgs());  //update data grid view
                        //dataGridView1.Refresh();
                        btnClear_Click(this, new EventArgs());  // clear all text box
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveAddNewUsers_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonOkAddNewUsers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxAddName.Clear();
            txtUserName.Clear();
            textBoxAddAddress.Clear();
            textBoxAddPin.Clear();
            textBoxAccountNo.Clear();
            textBoxAddBalance.Clear();
            textBoxAddPhone.Clear();
        }

    }
}
