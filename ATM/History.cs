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
    public partial class History : Form
    {
        DataGridView myDataGridView = new DataGridView();
        BindingSource bindingSource = new BindingSource();
        GateWay gateWayObject = new GateWay();
        private string select;
        Customer customerObject;
          
        public History(string ss, Customer cObject)
        {
            InitializeComponent();
            myDataGridView.Location = new Point(10, 10);            
            myDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            myDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            select = ss;
            customerObject = cObject;
        }

        private void History_Load(object sender, EventArgs e)
        {
            myDataGridView.Columns.Clear();
            switch (select)
            {
                case "deposit":
                    {
                        myDataGridView.Size = new Size(345, 380);

                        DataGridViewTextBoxColumn dateColl = new DataGridViewTextBoxColumn();
                        dateColl.Width = 150;
                        dateColl.HeaderText = "Deposit Date";
                        dateColl.DataPropertyName = "date";   // coll name from the database table
                        DataGridViewCell dateCell = new DataGridViewTextBoxCell();
                        dateColl.CellTemplate = dateCell;
                        myDataGridView.Columns.Add(dateColl);

                        DataGridViewTextBoxColumn amountColl = new DataGridViewTextBoxColumn();
                        amountColl.Width = 150;
                        amountColl.HeaderText = "Amount";
                        amountColl.DataPropertyName = "ammount";
                        DataGridViewCell amountCell = new DataGridViewTextBoxCell();
                        amountColl.CellTemplate = amountCell;
                        myDataGridView.Columns.Add(amountColl);

                        this.Controls.Add(myDataGridView);
                        this.Width = myDataGridView.Width + 30;
                        this.Text = "Deposit History";

                        bindingSource.DataSource = gateWayObject.SelectData("select date, ammount from diposit_history where account_no='" + customerObject.acc_no + "' order by date asc");
                        myDataGridView.DataSource = bindingSource;
                    }
                    break;

                case "withdraw":
                    {
                        myDataGridView.Size = new Size(345, 380);

                        DataGridViewTextBoxColumn dateColl = new DataGridViewTextBoxColumn();
                        dateColl.Width = 150;
                        dateColl.HeaderText = "Withdraw Date";
                        dateColl.DataPropertyName = "date";   // coll name from the database table
                        DataGridViewCell dateCell = new DataGridViewTextBoxCell();
                        dateColl.CellTemplate = dateCell;
                        myDataGridView.Columns.Add(dateColl);

                        DataGridViewTextBoxColumn amountColl = new DataGridViewTextBoxColumn();
                        amountColl.Width = 150;
                        amountColl.HeaderText = "Amount";
                        amountColl.DataPropertyName = "ammount";
                        DataGridViewCell amountCell = new DataGridViewTextBoxCell();
                        amountColl.CellTemplate = amountCell;
                        myDataGridView.Columns.Add(amountColl);

                        this.Controls.Add(myDataGridView);
                        this.Width = myDataGridView.Width + 30;
                        this.Text = "Withdraw History";

                        bindingSource.DataSource = gateWayObject.SelectData("select date, ammount from withdraw_history where account_no='" + customerObject.acc_no + "' order by date asc");
                        myDataGridView.DataSource = bindingSource;
                    }
                    break;
                case "transfer":
                    {
                        myDataGridView.Size = new Size(750, 380);

                        DataGridViewTextBoxColumn accFromColl = new DataGridViewTextBoxColumn();
                        accFromColl.Width = 100;
                        accFromColl.HeaderText = "Acc From";
                        accFromColl.DataPropertyName = "acc_from";   // coll name from the database table
                        DataGridViewCell accFromCell = new DataGridViewTextBoxCell();
                        accFromColl.CellTemplate = accFromCell;
                        myDataGridView.Columns.Add(accFromColl);

                        DataGridViewTextBoxColumn name1Coll = new DataGridViewTextBoxColumn();
                        name1Coll.Width = 150;
                        name1Coll.HeaderText = "Name";
                        name1Coll.DataPropertyName = "name1";
                        DataGridViewCell name1Cell = new DataGridViewTextBoxCell();
                        name1Coll.CellTemplate = name1Cell;
                        myDataGridView.Columns.Add(name1Coll);

                        DataGridViewTextBoxColumn accToColl = new DataGridViewTextBoxColumn();
                        accToColl.Width = 100;
                        accToColl.HeaderText = "Acc To";
                        accToColl.DataPropertyName = "acc_to";
                        DataGridViewCell accToCell = new DataGridViewTextBoxCell();
                        accToColl.CellTemplate = accToCell;
                        myDataGridView.Columns.Add(accToColl);

                        DataGridViewTextBoxColumn name2Coll = new DataGridViewTextBoxColumn();
                        name2Coll.Width = 150;
                        name2Coll.HeaderText = "Name";
                        name2Coll.DataPropertyName = "name2";
                        DataGridViewCell name2Cell = new DataGridViewTextBoxCell();
                        name2Coll.CellTemplate = name2Cell;
                        myDataGridView.Columns.Add(name2Coll);

                        DataGridViewTextBoxColumn amountColl = new DataGridViewTextBoxColumn();
                        amountColl.Width = 100;
                        amountColl.HeaderText = "Amount";
                        amountColl.DataPropertyName = "ammount";
                        DataGridViewCell amountCell = new DataGridViewTextBoxCell();
                        amountColl.CellTemplate = amountCell;
                        myDataGridView.Columns.Add(amountColl);

                        DataGridViewTextBoxColumn dateColl = new DataGridViewTextBoxColumn();
                        dateColl.Width = 107;
                        dateColl.HeaderText = "Transfer Date";
                        dateColl.DataPropertyName = "date";   // coll name from the database table
                        DataGridViewCell dateCell = new DataGridViewTextBoxCell();
                        dateColl.CellTemplate = dateCell;
                        myDataGridView.Columns.Add(dateColl);

                        this.Controls.Add(myDataGridView);
                        this.Width = myDataGridView.Width + 30;
                        this.Text = "Transfer History";

                        string sqlString = "select distinct date, acc_from, name1, acc_to, c_name as name2, ammount from";
                        sqlString += "(select distinct date, acc_from, c_name as name1, acc_to, ammount from transfer_history, customer where (acc_from='" + customerObject.acc_no + "' or acc_to='" + customerObject.acc_no + "') and customer.account_no=transfer_history.acc_from)";
                        sqlString += "a, customer where a.acc_to=customer.account_no order by date";

                        bindingSource.DataSource = gateWayObject.SelectData(sqlString);
                        myDataGridView.DataSource = bindingSource;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
