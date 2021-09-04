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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        private void Form_Login_Load(object sender, EventArgs e)
        {

            //Remove Top
            this.FormBorderStyle = FormBorderStyle.None;
            string username = "WahyuAgung";
            string password = "1234";
           
            textBox_user_signin.Text = username;
            textBox_pass_signin.Text = password;

            
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button_login_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username = '" + textBox_user_signin.Text + "' and password= '" + textBox_pass_signin.Text + "' ";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();
            

            if (dr.Read() == true)
            {
                new Dashboard(textBox_user_signin.Text).Show();
                this.Hide();
            }
            else if(textBox_user_signin.Text == "" || textBox_pass_signin.Text == "")
                {
                MessageBox.Show("Username or Password fields are empty", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                
                MessageBox.Show("Username or Password are invalid, try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_user_signin.Text = "";
                textBox_pass_signin.Text = "";
                textBox_user_signin.Focus();
            }
            Dashboard form_dashboard = new Dashboard(textBox_user_signin.Text);
            con.Close();
        }

        private void checkBox_showpass_signin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showpass_signin.Checked)
            {
                textBox_pass_signin.PasswordChar = '\0';
            }
            else
            {
                textBox_pass_signin.PasswordChar = '*';
            }
        }

        private void label_signup_Click(object sender, EventArgs e)
        {
            new Form_Register().Show();
            this.Hide();
        }

        private void Form_Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void Form_Login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
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

        private void btn_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_user_signin_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
