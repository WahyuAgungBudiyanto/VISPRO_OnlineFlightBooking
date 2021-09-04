
namespace QuizProject2
{
    partial class Form_Login
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
            this.label_signup = new System.Windows.Forms.Label();
            this.label_dont_acc = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.checkBox_showpass_signin = new System.Windows.Forms.CheckBox();
            this.textBox_pass_signin = new System.Windows.Forms.TextBox();
            this.label_pass_signin = new System.Windows.Forms.Label();
            this.textBox_user_signin = new System.Windows.Forms.TextBox();
            this.label_user_signin = new System.Windows.Forms.Label();
            this.label_desc_signin = new System.Windows.Forms.Label();
            this.label_header_signin = new System.Windows.Forms.Label();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_Minimized = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_signup
            // 
            this.label_signup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_signup.AutoSize = true;
            this.label_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_signup.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_signup.Location = new System.Drawing.Point(197, 382);
            this.label_signup.Name = "label_signup";
            this.label_signup.Size = new System.Drawing.Size(56, 17);
            this.label_signup.TabIndex = 25;
            this.label_signup.Text = "Sign Up";
            this.label_signup.Click += new System.EventHandler(this.label_signup_Click);
            // 
            // label_dont_acc
            // 
            this.label_dont_acc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_dont_acc.AutoSize = true;
            this.label_dont_acc.Location = new System.Drawing.Point(48, 382);
            this.label_dont_acc.Name = "label_dont_acc";
            this.label_dont_acc.Size = new System.Drawing.Size(152, 17);
            this.label_dont_acc.TabIndex = 24;
            this.label_dont_acc.Text = "Don\'t have an account?";
            // 
            // button_login
            // 
            this.button_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_login.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(22, 327);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(283, 41);
            this.button_login.TabIndex = 23;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // checkBox_showpass_signin
            // 
            this.checkBox_showpass_signin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_showpass_signin.AutoSize = true;
            this.checkBox_showpass_signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_showpass_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_showpass_signin.Location = new System.Drawing.Point(186, 291);
            this.checkBox_showpass_signin.Name = "checkBox_showpass_signin";
            this.checkBox_showpass_signin.Size = new System.Drawing.Size(119, 21);
            this.checkBox_showpass_signin.TabIndex = 21;
            this.checkBox_showpass_signin.Text = "Show Password";
            this.checkBox_showpass_signin.UseVisualStyleBackColor = true;
            this.checkBox_showpass_signin.CheckedChanged += new System.EventHandler(this.checkBox_showpass_signin_CheckedChanged);
            // 
            // textBox_pass_signin
            // 
            this.textBox_pass_signin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_pass_signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBox_pass_signin.Location = new System.Drawing.Point(22, 256);
            this.textBox_pass_signin.Multiline = true;
            this.textBox_pass_signin.Name = "textBox_pass_signin";
            this.textBox_pass_signin.PasswordChar = '*';
            this.textBox_pass_signin.Size = new System.Drawing.Size(282, 29);
            this.textBox_pass_signin.TabIndex = 18;
            // 
            // label_pass_signin
            // 
            this.label_pass_signin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_pass_signin.AutoSize = true;
            this.label_pass_signin.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass_signin.Location = new System.Drawing.Point(17, 233);
            this.label_pass_signin.Name = "label_pass_signin";
            this.label_pass_signin.Size = new System.Drawing.Size(76, 20);
            this.label_pass_signin.TabIndex = 17;
            this.label_pass_signin.Text = "Password";
            // 
            // textBox_user_signin
            // 
            this.textBox_user_signin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_user_signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBox_user_signin.Location = new System.Drawing.Point(22, 186);
            this.textBox_user_signin.Multiline = true;
            this.textBox_user_signin.Name = "textBox_user_signin";
            this.textBox_user_signin.Size = new System.Drawing.Size(282, 29);
            this.textBox_user_signin.TabIndex = 16;
            this.textBox_user_signin.TextChanged += new System.EventHandler(this.textBox_user_signin_TextChanged);
            // 
            // label_user_signin
            // 
            this.label_user_signin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_user_signin.AutoSize = true;
            this.label_user_signin.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user_signin.Location = new System.Drawing.Point(17, 163);
            this.label_user_signin.Name = "label_user_signin";
            this.label_user_signin.Size = new System.Drawing.Size(80, 20);
            this.label_user_signin.TabIndex = 15;
            this.label_user_signin.Text = "Username";
            // 
            // label_desc_signin
            // 
            this.label_desc_signin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_desc_signin.AutoSize = true;
            this.label_desc_signin.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_desc_signin.ForeColor = System.Drawing.Color.LightGray;
            this.label_desc_signin.Location = new System.Drawing.Point(18, 125);
            this.label_desc_signin.Name = "label_desc_signin";
            this.label_desc_signin.Size = new System.Drawing.Size(277, 19);
            this.label_desc_signin.TabIndex = 14;
            this.label_desc_signin.Text = "Enter your username and password to login";
            // 
            // label_header_signin
            // 
            this.label_header_signin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_header_signin.AutoSize = true;
            this.label_header_signin.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header_signin.ForeColor = System.Drawing.Color.Black;
            this.label_header_signin.Location = new System.Drawing.Point(15, 84);
            this.label_header_signin.Name = "label_header_signin";
            this.label_header_signin.Size = new System.Drawing.Size(268, 32);
            this.label_header_signin.TabIndex = 13;
            this.label_header_signin.Text = "Login to your account";
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maximize.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Maximize.Location = new System.Drawing.Point(267, 1);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(30, 30);
            this.btn_Maximize.TabIndex = 28;
            this.btn_Maximize.Text = "O";
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Minimized
            // 
            this.btn_Minimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimized.FlatAppearance.BorderSize = 0;
            this.btn_Minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimized.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimized.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Minimized.Location = new System.Drawing.Point(243, 1);
            this.btn_Minimized.Name = "btn_Minimized";
            this.btn_Minimized.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimized.TabIndex = 27;
            this.btn_Minimized.Text = "O";
            this.btn_Minimized.UseVisualStyleBackColor = true;
            this.btn_Minimized.Click += new System.EventHandler(this.btn_Minimized_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_close.Location = new System.Drawing.Point(291, 1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 26;
            this.btn_close.Text = "O";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(321, 500);
            this.Controls.Add(this.btn_Maximize);
            this.Controls.Add(this.btn_Minimized);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label_signup);
            this.Controls.Add(this.label_dont_acc);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.checkBox_showpass_signin);
            this.Controls.Add(this.textBox_pass_signin);
            this.Controls.Add(this.label_pass_signin);
            this.Controls.Add(this.textBox_user_signin);
            this.Controls.Add(this.label_user_signin);
            this.Controls.Add(this.label_desc_signin);
            this.Controls.Add(this.label_header_signin);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_signup;
        private System.Windows.Forms.Label label_dont_acc;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.CheckBox checkBox_showpass_signin;
        private System.Windows.Forms.TextBox textBox_pass_signin;
        private System.Windows.Forms.Label label_pass_signin;
        private System.Windows.Forms.TextBox textBox_user_signin;
        private System.Windows.Forms.Label label_user_signin;
        private System.Windows.Forms.Label label_desc_signin;
        private System.Windows.Forms.Label label_header_signin;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Button btn_Minimized;
        private System.Windows.Forms.Button btn_close;
    }
}