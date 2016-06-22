namespace ATM
{
    partial class FormPinCode
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
            this.components = new System.ComponentModel.Container();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonAboutPinCode = new System.Windows.Forms.Button();
            this.buttonAdminPinCode = new System.Windows.Forms.Button();
            this.buttonExitPinCode = new System.Windows.Forms.Button();
            this.buttonOkPinCode = new System.Windows.Forms.Button();
            this.buttonClearPinCode = new System.Windows.Forms.Button();
            this.labelPin = new System.Windows.Forms.Label();
            this.textBoxPinPinCode = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelWelcome.Location = new System.Drawing.Point(241, 13);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(3);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(215, 57);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome To ATM";
            // 
            // buttonAboutPinCode
            // 
            this.buttonAboutPinCode.BackColor = System.Drawing.Color.Transparent;
            this.buttonAboutPinCode.BackgroundImage = global::ATM.Properties.Resources.messenger;
            this.buttonAboutPinCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAboutPinCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAboutPinCode.FlatAppearance.BorderSize = 0;
            this.buttonAboutPinCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.buttonAboutPinCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutPinCode.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAboutPinCode.ForeColor = System.Drawing.Color.White;
            this.buttonAboutPinCode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAboutPinCode.Location = new System.Drawing.Point(12, 12);
            this.buttonAboutPinCode.Name = "buttonAboutPinCode";
            this.buttonAboutPinCode.Size = new System.Drawing.Size(113, 100);
            this.buttonAboutPinCode.TabIndex = 8;
            this.buttonAboutPinCode.Text = "About";
            this.buttonAboutPinCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAboutPinCode.UseVisualStyleBackColor = false;
            this.buttonAboutPinCode.Click += new System.EventHandler(this.buttonAboutPinCode_Click);
            // 
            // buttonAdminPinCode
            // 
            this.buttonAdminPinCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdminPinCode.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdminPinCode.BackgroundImage = global::ATM.Properties.Resources.linuxconf;
            this.buttonAdminPinCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAdminPinCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdminPinCode.FlatAppearance.BorderSize = 0;
            this.buttonAdminPinCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.buttonAdminPinCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminPinCode.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminPinCode.ForeColor = System.Drawing.Color.White;
            this.buttonAdminPinCode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdminPinCode.Location = new System.Drawing.Point(12, 350);
            this.buttonAdminPinCode.Name = "buttonAdminPinCode";
            this.buttonAdminPinCode.Size = new System.Drawing.Size(113, 100);
            this.buttonAdminPinCode.TabIndex = 9;
            this.buttonAdminPinCode.Text = "Admin";
            this.buttonAdminPinCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdminPinCode.UseVisualStyleBackColor = false;
            this.buttonAdminPinCode.Click += new System.EventHandler(this.buttonAdminPinCode_Click);
            // 
            // buttonExitPinCode
            // 
            this.buttonExitPinCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExitPinCode.BackColor = System.Drawing.Color.Transparent;
            this.buttonExitPinCode.BackgroundImage = global::ATM.Properties.Resources.DeleteRed;
            this.buttonExitPinCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonExitPinCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExitPinCode.FlatAppearance.BorderSize = 0;
            this.buttonExitPinCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.buttonExitPinCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitPinCode.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitPinCode.ForeColor = System.Drawing.Color.White;
            this.buttonExitPinCode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExitPinCode.Location = new System.Drawing.Point(604, 350);
            this.buttonExitPinCode.Name = "buttonExitPinCode";
            this.buttonExitPinCode.Size = new System.Drawing.Size(113, 100);
            this.buttonExitPinCode.TabIndex = 10;
            this.buttonExitPinCode.Text = "Exit";
            this.buttonExitPinCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExitPinCode.UseVisualStyleBackColor = false;
            this.buttonExitPinCode.Click += new System.EventHandler(this.buttonExitPinCode_Click);
            // 
            // buttonOkPinCode
            // 
            this.buttonOkPinCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOkPinCode.BackColor = System.Drawing.Color.Transparent;
            this.buttonOkPinCode.BackgroundImage = global::ATM.Properties.Resources._492;
            this.buttonOkPinCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOkPinCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOkPinCode.FlatAppearance.BorderSize = 0;
            this.buttonOkPinCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOkPinCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.buttonOkPinCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOkPinCode.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOkPinCode.ForeColor = System.Drawing.Color.White;
            this.buttonOkPinCode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOkPinCode.Location = new System.Drawing.Point(230, 251);
            this.buttonOkPinCode.Name = "buttonOkPinCode";
            this.buttonOkPinCode.Size = new System.Drawing.Size(113, 100);
            this.buttonOkPinCode.TabIndex = 11;
            this.buttonOkPinCode.Text = "Ok";
            this.buttonOkPinCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOkPinCode.UseVisualStyleBackColor = true;
            this.buttonOkPinCode.Click += new System.EventHandler(this.buttonOkPinCode_Click);
            // 
            // buttonClearPinCode
            // 
            this.buttonClearPinCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClearPinCode.BackColor = System.Drawing.Color.Transparent;
            this.buttonClearPinCode.BackgroundImage = global::ATM.Properties.Resources.looknfeel;
            this.buttonClearPinCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClearPinCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearPinCode.FlatAppearance.BorderSize = 0;
            this.buttonClearPinCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.buttonClearPinCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearPinCode.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearPinCode.ForeColor = System.Drawing.Color.White;
            this.buttonClearPinCode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClearPinCode.Location = new System.Drawing.Point(378, 251);
            this.buttonClearPinCode.Name = "buttonClearPinCode";
            this.buttonClearPinCode.Size = new System.Drawing.Size(113, 100);
            this.buttonClearPinCode.TabIndex = 12;
            this.buttonClearPinCode.Text = "Clear";
            this.buttonClearPinCode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClearPinCode.UseVisualStyleBackColor = false;
            this.buttonClearPinCode.Click += new System.EventHandler(this.buttonClearPinCode_Click);
            // 
            // labelPin
            // 
            this.labelPin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPin.BackColor = System.Drawing.Color.Transparent;
            this.labelPin.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.labelPin.ForeColor = System.Drawing.Color.White;
            this.labelPin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelPin.Location = new System.Drawing.Point(151, 188);
            this.labelPin.Margin = new System.Windows.Forms.Padding(3);
            this.labelPin.Name = "labelPin";
            this.labelPin.Size = new System.Drawing.Size(215, 57);
            this.labelPin.TabIndex = 13;
            this.labelPin.Text = "Enter Your Pin";
            // 
            // textBoxPinPinCode
            // 
            this.textBoxPinPinCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPinPinCode.Location = new System.Drawing.Point(347, 188);
            this.textBoxPinPinCode.Multiline = true;
            this.textBoxPinPinCode.Name = "textBoxPinPinCode";
            this.textBoxPinPinCode.PasswordChar = '*';
            this.textBoxPinPinCode.Size = new System.Drawing.Size(200, 30);
            this.textBoxPinPinCode.TabIndex = 1;
            this.textBoxPinPinCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPinPinCode_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(521, 35);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(182, 46);
            this.timeLabel.TabIndex = 15;
            this.timeLabel.Text = "00:00:00";
            // 
            // dayLabel
            // 
            this.dayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dayLabel.AutoSize = true;
            this.dayLabel.BackColor = System.Drawing.Color.Transparent;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(514, 88);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(73, 20);
            this.dayLabel.TabIndex = 16;
            this.dayLabel.Text = "dayLabel";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.Location = new System.Drawing.Point(347, 130);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 30);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPinPinCode_KeyDown);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUserName.Location = new System.Drawing.Point(151, 129);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(3);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(215, 57);
            this.lblUserName.TabIndex = 18;
            this.lblUserName.Text = "Enter User Name";
            // 
            // FormPinCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATM.Properties.Resources.darkaurora1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 462);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.textBoxPinPinCode);
            this.Controls.Add(this.labelPin);
            this.Controls.Add(this.buttonClearPinCode);
            this.Controls.Add(this.buttonOkPinCode);
            this.Controls.Add(this.buttonExitPinCode);
            this.Controls.Add(this.buttonAdminPinCode);
            this.Controls.Add(this.buttonAboutPinCode);
            this.Controls.Add(this.labelWelcome);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Name = "FormPinCode";
            this.Text = "Pin Code";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        internal System.Windows.Forms.Button buttonAboutPinCode;
        internal System.Windows.Forms.Button buttonAdminPinCode;
        internal System.Windows.Forms.Button buttonExitPinCode;
        internal System.Windows.Forms.Button buttonOkPinCode;
        internal System.Windows.Forms.Button buttonClearPinCode;
        private System.Windows.Forms.Label labelPin;
        private System.Windows.Forms.TextBox textBoxPinPinCode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
    }
}

