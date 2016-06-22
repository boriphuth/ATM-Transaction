namespace ATM
{
    partial class FormAdminLogin
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
            this.textBoxUserNameAdminLogin = new System.Windows.Forms.TextBox();
            this.textBoxPasswordAdminLogin = new System.Windows.Forms.TextBox();
            this.buttonOkAdminLogin = new System.Windows.Forms.Button();
            this.buttonCancelAdminLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Footlight MT Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textBoxUserNameAdminLogin
            // 
            this.textBoxUserNameAdminLogin.Location = new System.Drawing.Point(171, 45);
            this.textBoxUserNameAdminLogin.Multiline = true;
            this.textBoxUserNameAdminLogin.Name = "textBoxUserNameAdminLogin";
            this.textBoxUserNameAdminLogin.Size = new System.Drawing.Size(200, 27);
            this.textBoxUserNameAdminLogin.TabIndex = 0;
            this.textBoxUserNameAdminLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUserNameAdminLogin_KeyDown);
            // 
            // textBoxPasswordAdminLogin
            // 
            this.textBoxPasswordAdminLogin.Location = new System.Drawing.Point(171, 102);
            this.textBoxPasswordAdminLogin.Multiline = true;
            this.textBoxPasswordAdminLogin.Name = "textBoxPasswordAdminLogin";
            this.textBoxPasswordAdminLogin.PasswordChar = '*';
            this.textBoxPasswordAdminLogin.Size = new System.Drawing.Size(200, 27);
            this.textBoxPasswordAdminLogin.TabIndex = 1;
            this.textBoxPasswordAdminLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUserNameAdminLogin_KeyDown);
            // 
            // buttonOkAdminLogin
            // 
            this.buttonOkAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonOkAdminLogin.BackgroundImage = global::ATM.Properties.Resources._492;
            this.buttonOkAdminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOkAdminLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonOkAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOkAdminLogin.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOkAdminLogin.ForeColor = System.Drawing.Color.White;
            this.buttonOkAdminLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOkAdminLogin.Location = new System.Drawing.Point(171, 144);
            this.buttonOkAdminLogin.Name = "buttonOkAdminLogin";
            this.buttonOkAdminLogin.Size = new System.Drawing.Size(92, 89);
            this.buttonOkAdminLogin.TabIndex = 2;
            this.buttonOkAdminLogin.Text = "Ok";
            this.buttonOkAdminLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOkAdminLogin.UseVisualStyleBackColor = false;
            this.buttonOkAdminLogin.Click += new System.EventHandler(this.buttonOkAdminLogin_Click);
            this.buttonOkAdminLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUserNameAdminLogin_KeyDown);
            // 
            // buttonCancelAdminLogin
            // 
            this.buttonCancelAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelAdminLogin.BackgroundImage = global::ATM.Properties.Resources.DeleteRed1;
            this.buttonCancelAdminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCancelAdminLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCancelAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelAdminLogin.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelAdminLogin.ForeColor = System.Drawing.Color.White;
            this.buttonCancelAdminLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancelAdminLogin.Location = new System.Drawing.Point(279, 144);
            this.buttonCancelAdminLogin.Name = "buttonCancelAdminLogin";
            this.buttonCancelAdminLogin.Size = new System.Drawing.Size(92, 89);
            this.buttonCancelAdminLogin.TabIndex = 19;
            this.buttonCancelAdminLogin.Text = "Cancel";
            this.buttonCancelAdminLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancelAdminLogin.UseVisualStyleBackColor = false;
            this.buttonCancelAdminLogin.Click += new System.EventHandler(this.buttonCancelAdminLogin_Click);
            this.buttonCancelAdminLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUserNameAdminLogin_KeyDown);
            // 
            // FormAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ATM.Properties.Resources.darkaurora;
            this.ClientSize = new System.Drawing.Size(432, 261);
            this.Controls.Add(this.buttonCancelAdminLogin);
            this.Controls.Add(this.buttonOkAdminLogin);
            this.Controls.Add(this.textBoxPasswordAdminLogin);
            this.Controls.Add(this.textBoxUserNameAdminLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAdminLogin";
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserNameAdminLogin;
        private System.Windows.Forms.TextBox textBoxPasswordAdminLogin;
        internal System.Windows.Forms.Button buttonOkAdminLogin;
        internal System.Windows.Forms.Button buttonCancelAdminLogin;
    }
}