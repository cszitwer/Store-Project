namespace StoreProject
{
    partial class storeGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(storeGUI));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.successfulLogin = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.userPassword = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Controls.Add(this.tabPage3);
            this.Tabs.Controls.Add(this.tabPage4);
            this.Tabs.Controls.Add(this.tabPage5);
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(756, 426);
            this.Tabs.TabIndex = 2;
            this.Tabs.SelectedIndexChanged += new System.EventHandler(this.Tabs_Click);
            this.Tabs.Click += new System.EventHandler(this.Tabs_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleName = "tabPage1";
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.successfulLogin);
            this.tabPage1.Controls.Add(this.loginButton);
            this.tabPage1.Controls.Add(this.userPassword);
            this.tabPage1.Controls.Add(this.userEmail);
            this.tabPage1.Controls.Add(this.passwordText);
            this.tabPage1.Controls.Add(this.emailText);
            this.tabPage1.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(748, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            // 
            // successfulLogin
            // 
            this.successfulLogin.AutoSize = true;
            this.successfulLogin.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successfulLogin.Location = new System.Drawing.Point(232, 304);
            this.successfulLogin.Name = "successfulLogin";
            this.successfulLogin.Size = new System.Drawing.Size(0, 23);
            this.successfulLogin.TabIndex = 5;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(286, 249);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(84, 42);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userPassword
            // 
            this.userPassword.AutoSize = true;
            this.userPassword.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassword.Location = new System.Drawing.Point(184, 155);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(102, 29);
            this.userPassword.TabIndex = 3;
            this.userPassword.Text = "Password";
            // 
            // userEmail
            // 
            this.userEmail.AutoSize = true;
            this.userEmail.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmail.Location = new System.Drawing.Point(184, 77);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(63, 29);
            this.userEmail.TabIndex = 2;
            this.userEmail.Text = "Email";
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.passwordText.Location = new System.Drawing.Point(184, 197);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(308, 35);
            this.passwordText.TabIndex = 1;
            // 
            // emailText
            // 
            this.emailText.AutoCompleteCustomSource.AddRange(new string[] {
            "cszitwer@gmail.com",
            "czitwer@student.touro.edu"});
            this.emailText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.emailText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.emailText.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.emailText.Location = new System.Drawing.Point(184, 109);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(308, 35);
            this.emailText.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(748, 393);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Items";
            // 
            // tabPage3
            // 
            this.tabPage3.AccessibleName = "tabPage3";
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(748, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Account";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(748, 393);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Past Orders";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage5.Controls.Add(this.splitContainer2);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(748, 393);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Orders Within Range";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Size = new System.Drawing.Size(748, 393);
            this.splitContainer2.SplitterDistance = 277;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 0;
            // 
            // storeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "storeGUI";
            this.Text = "Store";
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label successfulLogin;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label userPassword;
        private System.Windows.Forms.Label userEmail;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

