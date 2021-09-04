using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QuizProject2
{
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button_register_Click(object sender, EventArgs e)
        {
            if (textBox_user_signup.Text == "" && textBox_pass_signup.Text == "" && textBox_confirm_pass_signup.Text == "")
            {
                MessageBox.Show("Username or Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBox_pass_signup.Text == textBox_confirm_pass_signup.Text)
            {
                    con.Open();
                    if (checkBox_agree.Checked)
                    {
                        
                        string checkDuplicate = "SELECT username FROM tbl_users WHERE username =@username";
                        cmd = new OleDbCommand(checkDuplicate, con);
                        cmd.Parameters.AddWithValue("@username", textBox_user_signup.Text);
                        OleDbDataReader dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            MessageBox.Show("Name Existing Already!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                        
                        
                        cmd = new OleDbCommand("INSERT INTO tbl_users VALUES ('" + textBox_user_signup.Text + "','" + textBox_pass_signup.Text + "')", con);
                         
                            cmd.ExecuteNonQuery();
                            
                            MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox_user_signup.Text = "";
                            textBox_pass_signup.Text = "";
                            textBox_confirm_pass_signup.Text = "";
                            new Form_Login().Show();
                            this.Hide();
                        textBox_balanceplaced.Hide();
                        } 
                    }
                    else
                    {
                        MessageBox.Show("Please check the Privacy Policy!");
                    }
                con.Close();
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_pass_signup.Text = "";
                textBox_confirm_pass_signup.Text = "";
                textBox_pass_signup.Focus();
            }

            

        }


        private void checkBox_showpass_signup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showpass_signup.Checked)
            {
                textBox_pass_signup.PasswordChar = '\0';
                textBox_confirm_pass_signup.PasswordChar = '\0';
            }
            else
            {
                textBox_pass_signup.PasswordChar = '*';
                textBox_confirm_pass_signup.PasswordChar = '*';
            }
        }

        private void label_signin_Click(object sender, EventArgs e)
        {
            new Form_Login().Show();
            this.Hide();
        }

        private void Form_Register_Load(object sender, EventArgs e)
        {
            //Remove Top
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form_Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Form_Register_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
