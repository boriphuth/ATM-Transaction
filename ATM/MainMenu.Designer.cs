namespace ATM
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExitMainMenu = new System.Windows.Forms.Button();
            this.buttonWithdrawCash = new System.Windows.Forms.Button();
            this.buttonDepositCash = new System.Windows.Forms.Button();
            this.buttonTransferCash = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonTransactionHistory = new System.Windows.Forms.Button();
            this.buttonBalanceInquiry = new System.Windows.Forms.Button();
            this.balanceGroupBox = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.buttonExitTransferCash = new System.Windows.Forms.Button();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.txtGuestAcc = new System.Windows.Forms.TextBox();
            this.transferGroupBox = new System.Windows.Forms.GroupBox();
            this.withdrawCashGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonExitWithdrawCash = new System.Windows.Forms.Button();
            this.buttonWithdrawWithdrawCash = new System.Windows.Forms.Button();
            this.textBoxEnterAmountWithdrawCash = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.depositCashGroupBox = new System.Windows.Forms.GroupBox();
            this.textBoxDepositCash = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonExitDepositCash = new System.Windows.Forms.Button();
            this.buttonDepositDepositCash = new System.Windows.Forms.Button();
            this.transferHistoryGroupBox = new System.Windows.Forms.GroupBox();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.lblDiposit = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.balanceGroupBox.SuspendLayout();
            this.transferGroupBox.SuspendLayout();
            this.withdrawCashGroupBox.SuspendLayout();
            this.depositCashGroupBox.SuspendLayout();
            this.transferHistoryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Main Menu\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(292, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Welcome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Footlight MT Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(286, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Select A Transaction";
            // 
            // buttonExitMainMenu
            // 
            this.buttonExitMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonExitMainMenu.BackgroundImage = global::ATM.Properties.Resources.DeleteRed1;
            this.buttonExitMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonExitMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExitMainMenu.FlatAppearance.BorderSize = 0;
            this.buttonExitMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.buttonExitMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitMainMenu.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitMainMenu.ForeColor = System.Drawing.Color.White;
            this.buttonExitMainMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExitMainMenu.Location = new System.Drawing.Point(654, 449);
            this.buttonExitMainMenu.Name = "buttonExitMainMenu";
            this.buttonExitMainMenu.Size = new System.Drawing.Size(130, 89);
            this.buttonExitMainMenu.TabIndex = 7;
            this.buttonExitMainMenu.Text = "Exit";
            this.buttonExitMainMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExitMainMenu.UseVisualStyleBackColor = false;
            this.buttonExitMainMenu.Click += new System.EventHandler(this.buttonExitMainMenu_Click);
            // 
            // buttonWithdrawCash
            // 
            this.buttonWithdrawCash.BackColor = System.Drawing.Color.Transparent;
            this.buttonWithdrawCash.BackgroundImage = global::ATM.Properties.Resources.kwallet1;
            this.buttonWithdrawCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonWithdrawCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWithdrawCash.FlatAppearance.BorderSize = 0;
            this.buttonWithdrawCash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.buttonWithdrawCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWithdrawCash.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdrawCash.ForeColor = System.Drawing.Color.White;
            this.buttonWithdrawCash.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonWithdrawCash.Location = new System.Drawing.Point(654, 331);
            this.buttonWithdrawCash.Name = "buttonWithdrawCash";
            this.buttonWithdrawCash.Size = new System.Drawing.Size(130, 98);
            this.buttonWithdrawCash.TabIndex = 6;
            this.buttonWithdrawCash.Text = "Withdraw Cash";
            this.buttonWithdrawCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonWithdrawCash.UseVisualStyleBackColor = false;
            this.buttonWithdrawCash.Click += new System.EventHandler(this.buttonWithdrawCash_Click);
            // 
            // buttonDepositCash
            // 
            this.buttonDepositCash.BackColor = System.Drawing.Color.Transparent;
            this.buttonDepositCash.BackgroundImage = global::ATM.Properties.Resources.my_documents;
            this.buttonDepositCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDepositCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDepositCash.FlatAppearance.BorderSize = 0;
            this.buttonDepositCash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.buttonDepositCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepositCash.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositCash.ForeColor = System.Drawing.Color.White;
            this.buttonDepositCash.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDepositCash.Location = new System.Drawing.Point(654, 207);
            this.buttonDepositCash.Name = "buttonDepositCash";
            this.buttonDepositCash.Size = new System.Drawing.Size(130, 98);
            this.buttonDepositCash.TabIndex = 4;
            this.buttonDepositCash.Text = "Deposit Cash";
            this.buttonDepositCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDepositCash.UseVisualStyleBackColor = false;
            this.buttonDepositCash.Click += new System.EventHandler(this.buttonDepositCash_Click);
            // 
            // buttonTransferCash
            // 
            this.buttonTransferCash.BackColor = System.Drawing.Color.Transparent;
            this.buttonTransferCash.BackgroundImage = global::ATM.Properties.Resources.kwrite;
            this.buttonTransferCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonTransferCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransferCash.FlatAppearance.BorderSize = 0;
            this.buttonTransferCash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.buttonTransferCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransferCash.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransferCash.ForeColor = System.Drawing.Color.White;
            this.buttonTransferCash.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTransferCash.Location = new System.Drawing.Point(654, 88);
            this.buttonTransferCash.Name = "buttonTransferCash";
            this.buttonTransferCash.Size = new System.Drawing.Size(130, 98);
            this.buttonTransferCash.TabIndex = 1;
            this.buttonTransferCash.Text = "Transfer Cash";
            this.buttonTransferCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTransferCash.UseVisualStyleBackColor = false;
            this.buttonTransferCash.Click += new System.EventHandler(this.buttonTransferCash_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.BackgroundImage = global::ATM.Properties.Resources.kuser;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSettings.Location = new System.Drawing.Point(12, 331);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(130, 98);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonTransactionHistory
            // 
            this.buttonTransactionHistory.BackColor = System.Drawing.Color.Transparent;
            this.buttonTransactionHistory.BackgroundImage = global::ATM.Properties.Resources.mydocuments;
            this.buttonTransactionHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonTransactionHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransactionHistory.FlatAppearance.BorderSize = 0;
            this.buttonTransactionHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.buttonTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionHistory.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactionHistory.ForeColor = System.Drawing.Color.White;
            this.buttonTransactionHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTransactionHistory.Location = new System.Drawing.Point(12, 207);
            this.buttonTransactionHistory.Name = "buttonTransactionHistory";
            this.buttonTransactionHistory.Size = new System.Drawing.Size(130, 98);
            this.buttonTransactionHistory.TabIndex = 3;
            this.buttonTransactionHistory.Text = "Transaction History";
            this.buttonTransactionHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTransactionHistory.UseVisualStyleBackColor = false;
            this.buttonTransactionHistory.Click += new System.EventHandler(this.buttonTransactionHistory_Click);
            // 
            // buttonBalanceInquiry
            // 
            this.buttonBalanceInquiry.BackColor = System.Drawing.Color.Transparent;
            this.buttonBalanceInquiry.BackgroundImage = global::ATM.Properties.Resources.Binoculars;
            this.buttonBalanceInquiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBalanceInquiry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBalanceInquiry.FlatAppearance.BorderSize = 0;
            this.buttonBalanceInquiry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.buttonBalanceInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBalanceInquiry.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBalanceInquiry.ForeColor = System.Drawing.Color.White;
            this.buttonBalanceInquiry.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBalanceInquiry.Location = new System.Drawing.Point(12, 88);
            this.buttonBalanceInquiry.Name = "buttonBalanceInquiry";
            this.buttonBalanceInquiry.Size = new System.Drawing.Size(130, 98);
            this.buttonBalanceInquiry.TabIndex = 0;
            this.buttonBalanceInquiry.Text = "Balance Inquiry";
            this.buttonBalanceInquiry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBalanceInquiry.UseVisualStyleBackColor = false;
            this.buttonBalanceInquiry.Click += new System.EventHandler(this.buttonBalanceInquiry_Click);
            // 
            // balanceGroupBox
            // 
            this.balanceGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.balanceGroupBox.Controls.Add(this.btnOk);
            this.balanceGroupBox.Controls.Add(this.txtBalance);
            this.balanceGroupBox.Controls.Add(this.label4);
            this.balanceGroupBox.Location = new System.Drawing.Point(708, 357);
            this.balanceGroupBox.Name = "balanceGroupBox";
            this.balanceGroupBox.Size = new System.Drawing.Size(500, 181);
            this.balanceGroupBox.TabIndex = 30;
            this.balanceGroupBox.TabStop = false;
            this.balanceGroupBox.Text = "Balance";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOk.Location = new System.Drawing.Point(212, 130);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 35);
            this.btnOk.TabIndex = 30;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(259, 77);
            this.txtBalance.Multiline = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(144, 29);
            this.txtBalance.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Footlight MT Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Your Balance (TK)";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Footlight MT Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(394, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 24);
            this.lblName.TabIndex = 38;
            this.lblName.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Footlight MT Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(44, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 22);
            this.label7.TabIndex = 40;
            this.label7.Text = "Enter Amount In (Tk)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Footlight MT Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 41;
            this.label5.Text = "Enter Account No";
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTransfer.Location = new System.Drawing.Point(94, 227);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(110, 35);
            this.buttonTransfer.TabIndex = 42;
            this.buttonTransfer.Text = "Transfer";
            this.buttonTransfer.UseVisualStyleBackColor = false;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // buttonExitTransferCash
            // 
            this.buttonExitTransferCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExitTransferCash.Location = new System.Drawing.Point(293, 227);
            this.buttonExitTransferCash.Name = "buttonExitTransferCash";
            this.buttonExitTransferCash.Size = new System.Drawing.Size(110, 35);
            this.buttonExitTransferCash.TabIndex = 43;
            this.buttonExitTransferCash.Text = "Exit";
            this.buttonExitTransferCash.UseVisualStyleBackColor = false;
            this.buttonExitTransferCash.Click += new System.EventHandler(this.buttonExitTransferCash_Click);
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.Location = new System.Drawing.Point(272, 133);
            this.txtTransferAmount.Multiline = true;
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(185, 22);
            this.txtTransferAmount.TabIndex = 1;
            this.txtTransferAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGuestAcc_KeyDown);
            // 
            // txtGuestAcc
            // 
            this.txtGuestAcc.Location = new System.Drawing.Point(272, 88);
            this.txtGuestAcc.Multiline = true;
            this.txtGuestAcc.Name = "txtGuestAcc";
            this.txtGuestAcc.Size = new System.Drawing.Size(185, 22);
            this.txtGuestAcc.TabIndex = 0;
            this.txtGuestAcc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGuestAcc_KeyDown);
            // 
            // transferGroupBox
            // 
            this.transferGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.transferGroupBox.Controls.Add(this.txtGuestAcc);
            this.transferGroupBox.Controls.Add(this.txtTransferAmount);
            this.transferGroupBox.Controls.Add(this.buttonExitTransferCash);
            this.transferGroupBox.Controls.Add(this.buttonTransfer);
            this.transferGroupBox.Controls.Add(this.label5);
            this.transferGroupBox.Controls.Add(this.label7);
            this.transferGroupBox.Location = new System.Drawing.Point(120, 391);
            this.transferGroupBox.Name = "transferGroupBox";
            this.transferGroupBox.Size = new System.Drawing.Size(500, 306);
            this.transferGroupBox.TabIndex = 39;
            this.transferGroupBox.TabStop = false;
            this.transferGroupBox.Text = "Transfer Cash";
            // 
            // withdrawCashGroupBox
            // 
            this.withdrawCashGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.withdrawCashGroupBox.Controls.Add(this.buttonExitWithdrawCash);
            this.withdrawCashGroupBox.Controls.Add(this.buttonWithdrawWithdrawCash);
            this.withdrawCashGroupBox.Controls.Add(this.textBoxEnterAmountWithdrawCash);
            this.withdrawCashGroupBox.Controls.Add(this.label8);
            this.withdrawCashGroupBox.Location = new System.Drawing.Point(654, 70);
            this.withdrawCashGroupBox.Name = "withdrawCashGroupBox";
            this.withdrawCashGroupBox.Size = new System.Drawing.Size(500, 255);
            this.withdrawCashGroupBox.TabIndex = 40;
            this.withdrawCashGroupBox.TabStop = false;
            this.withdrawCashGroupBox.Text = "Withdraw Cash";
            // 
            // buttonExitWithdrawCash
            // 
            this.buttonExitWithdrawCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExitWithdrawCash.Location = new System.Drawing.Point(298, 146);
            this.buttonExitWithdrawCash.Name = "buttonExitWithdrawCash";
            this.buttonExitWithdrawCash.Size = new System.Drawing.Size(110, 35);
            this.buttonExitWithdrawCash.TabIndex = 45;
            this.buttonExitWithdrawCash.Text = "Exit";
            this.buttonExitWithdrawCash.UseVisualStyleBackColor = false;
            this.buttonExitWithdrawCash.Click += new System.EventHandler(this.buttonExitWithdrawCash_Click);
            // 
            // buttonWithdrawWithdrawCash
            // 
            this.buttonWithdrawWithdrawCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonWithdrawWithdrawCash.Location = new System.Drawing.Point(112, 146);
            this.buttonWithdrawWithdrawCash.Name = "buttonWithdrawWithdrawCash";
            this.buttonWithdrawWithdrawCash.Size = new System.Drawing.Size(110, 35);
            this.buttonWithdrawWithdrawCash.TabIndex = 44;
            this.buttonWithdrawWithdrawCash.Text = "Withdraw";
            this.buttonWithdrawWithdrawCash.UseVisualStyleBackColor = false;
            this.buttonWithdrawWithdrawCash.Click += new System.EventHandler(this.buttonWithdrawWithdrawCash_Click);
            // 
            // textBoxEnterAmountWithdrawCash
            // 
            this.textBoxEnterAmountWithdrawCash.Location = new System.Drawing.Point(265, 64);
            this.textBoxEnterAmountWithdrawCash.Multiline = true;
            this.textBoxEnterAmountWithdrawCash.Name = "textBoxEnterAmountWithdrawCash";
            this.textBoxEnterAmountWithdrawCash.Size = new System.Drawing.Size(185, 22);
            this.textBoxEnterAmountWithdrawCash.TabIndex = 0;
            this.textBoxEnterAmountWithdrawCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEnterAmountWithdrawCash_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Footlight MT Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(50, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 22);
            this.label8.TabIndex = 42;
            this.label8.Text = "Enter Amount In (Tk)";
            // 
            // depositCashGroupBox
            // 
            this.depositCashGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.depositCashGroupBox.Controls.Add(this.textBoxDepositCash);
            this.depositCashGroupBox.Controls.Add(this.label6);
            this.depositCashGroupBox.Controls.Add(this.buttonExitDepositCash);
            this.depositCashGroupBox.Controls.Add(this.buttonDepositDepositCash);
            this.depositCashGroupBox.Location = new System.Drawing.Point(39, 88);
            this.depositCashGroupBox.Name = "depositCashGroupBox";
            this.depositCashGroupBox.Size = new System.Drawing.Size(500, 257);
            this.depositCashGroupBox.TabIndex = 47;
            this.depositCashGroupBox.TabStop = false;
            this.depositCashGroupBox.Text = "Deposit Cash";
            // 
            // textBoxDepositCash
            // 
            this.textBoxDepositCash.Location = new System.Drawing.Point(266, 87);
            this.textBoxDepositCash.Multiline = true;
            this.textBoxDepositCash.Name = "textBoxDepositCash";
            this.textBoxDepositCash.Size = new System.Drawing.Size(200, 22);
            this.textBoxDepositCash.TabIndex = 0;
            this.textBoxDepositCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDepositCash_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Footlight MT Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Enter Deposit Cash (Tk)";
            // 
            // buttonExitDepositCash
            // 
            this.buttonExitDepositCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExitDepositCash.Location = new System.Drawing.Point(291, 168);
            this.buttonExitDepositCash.Name = "buttonExitDepositCash";
            this.buttonExitDepositCash.Size = new System.Drawing.Size(82, 35);
            this.buttonExitDepositCash.TabIndex = 29;
            this.buttonExitDepositCash.Text = "Exit";
            this.buttonExitDepositCash.UseVisualStyleBackColor = false;
            this.buttonExitDepositCash.Click += new System.EventHandler(this.buttonExitDepositCash_Click);
            // 
            // buttonDepositDepositCash
            // 
            this.buttonDepositDepositCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonDepositDepositCash.Location = new System.Drawing.Point(122, 168);
            this.buttonDepositDepositCash.Name = "buttonDepositDepositCash";
            this.buttonDepositDepositCash.Size = new System.Drawing.Size(82, 35);
            this.buttonDepositDepositCash.TabIndex = 28;
            this.buttonDepositDepositCash.Text = "Deposit";
            this.buttonDepositDepositCash.UseVisualStyleBackColor = false;
            this.buttonDepositDepositCash.Click += new System.EventHandler(this.buttonDepositDepositCash_Click);
            // 
            // transferHistoryGroupBox
            // 
            this.transferHistoryGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.transferHistoryGroupBox.Controls.Add(this.lblTransfer);
            this.transferHistoryGroupBox.Controls.Add(this.lblWithdraw);
            this.transferHistoryGroupBox.Controls.Add(this.lblDiposit);
            this.transferHistoryGroupBox.Location = new System.Drawing.Point(148, 325);
            this.transferHistoryGroupBox.Name = "transferHistoryGroupBox";
            this.transferHistoryGroupBox.Size = new System.Drawing.Size(504, 209);
            this.transferHistoryGroupBox.TabIndex = 48;
            this.transferHistoryGroupBox.TabStop = false;
            this.transferHistoryGroupBox.Text = "Transaction History";
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.BackColor = System.Drawing.Color.Transparent;
            this.lblTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTransfer.Font = new System.Drawing.Font("Footlight MT Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransfer.ForeColor = System.Drawing.Color.White;
            this.lblTransfer.Location = new System.Drawing.Point(173, 138);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(150, 22);
            this.lblTransfer.TabIndex = 33;
            this.lblTransfer.Text = "Transfer History";
            this.lblTransfer.Click += new System.EventHandler(this.lblTransfer_Click);
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.lblWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWithdraw.Font = new System.Drawing.Font("Footlight MT Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdraw.ForeColor = System.Drawing.Color.White;
            this.lblWithdraw.Location = new System.Drawing.Point(165, 97);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(166, 22);
            this.lblWithdraw.TabIndex = 32;
            this.lblWithdraw.Text = "Withdraw History";
            this.lblWithdraw.Click += new System.EventHandler(this.lblWithdraw_Click);
            // 
            // lblDiposit
            // 
            this.lblDiposit.AutoSize = true;
            this.lblDiposit.BackColor = System.Drawing.Color.Transparent;
            this.lblDiposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDiposit.Font = new System.Drawing.Font("Footlight MT Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiposit.ForeColor = System.Drawing.Color.White;
            this.lblDiposit.Location = new System.Drawing.Point(179, 53);
            this.lblDiposit.Name = "lblDiposit";
            this.lblDiposit.Size = new System.Drawing.Size(142, 22);
            this.lblDiposit.TabIndex = 31;
            this.lblDiposit.Text = "Deposit History";
            this.lblDiposit.Click += new System.EventHandler(this.lblDiposit_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNotification.Font = new System.Drawing.Font("Footlight MT Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.Color.Red;
            this.lblNotification.Location = new System.Drawing.Point(605, 37);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(124, 24);
            this.lblNotification.TabIndex = 49;
            this.lblNotification.Text = "Notifications";
            this.lblNotification.Visible = false;
            this.lblNotification.Click += new System.EventHandler(this.lblNotification_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDescription.Font = new System.Drawing.Font("Footlight MT Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Red;
            this.lblDescription.Location = new System.Drawing.Point(483, 39);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(116, 24);
            this.lblDescription.TabIndex = 50;
            this.lblDescription.Text = "Description";
            this.lblDescription.Visible = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATM.Properties.Resources.darkaurora;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 552);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.transferHistoryGroupBox);
            this.Controls.Add(this.depositCashGroupBox);
            this.Controls.Add(this.withdrawCashGroupBox);
            this.Controls.Add(this.transferGroupBox);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.balanceGroupBox);
            this.Controls.Add(this.buttonBalanceInquiry);
            this.Controls.Add(this.buttonTransactionHistory);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonTransferCash);
            this.Controls.Add(this.buttonDepositCash);
            this.Controls.Add(this.buttonWithdrawCash);
            this.Controls.Add(this.buttonExitMainMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.balanceGroupBox.ResumeLayout(false);
            this.balanceGroupBox.PerformLayout();
            this.transferGroupBox.ResumeLayout(false);
            this.transferGroupBox.PerformLayout();
            this.withdrawCashGroupBox.ResumeLayout(false);
            this.withdrawCashGroupBox.PerformLayout();
            this.depositCashGroupBox.ResumeLayout(false);
            this.depositCashGroupBox.PerformLayout();
            this.transferHistoryGroupBox.ResumeLayout(false);
            this.transferHistoryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button buttonExitMainMenu;
        internal System.Windows.Forms.Button buttonWithdrawCash;
        internal System.Windows.Forms.Button buttonDepositCash;
        internal System.Windows.Forms.Button buttonTransferCash;
        internal System.Windows.Forms.Button buttonSettings;
        internal System.Windows.Forms.Button buttonTransactionHistory;
        internal System.Windows.Forms.Button buttonBalanceInquiry;
        private System.Windows.Forms.GroupBox balanceGroupBox;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.Button buttonExitTransferCash;
        private System.Windows.Forms.TextBox txtTransferAmount;
        private System.Windows.Forms.TextBox txtGuestAcc;
        private System.Windows.Forms.GroupBox transferGroupBox;
        private System.Windows.Forms.GroupBox withdrawCashGroupBox;
        private System.Windows.Forms.Button buttonExitWithdrawCash;
        private System.Windows.Forms.Button buttonWithdrawWithdrawCash;
        private System.Windows.Forms.TextBox textBoxEnterAmountWithdrawCash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox depositCashGroupBox;
        private System.Windows.Forms.TextBox textBoxDepositCash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExitDepositCash;
        private System.Windows.Forms.Button buttonDepositDepositCash;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox transferHistoryGroupBox;
        private System.Windows.Forms.Label lblTransfer;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Label lblDiposit;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label lblDescription;
    }
}