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
using System.IO;

namespace QuizProject2
{
    public partial class Dashboard : Form
    {
       
        public Dashboard(string Username_Show)
        {
            InitializeComponent();
            label_welcome.Text = Username_Show;
            //label_balance_output.Text = Convert.ToString(Balance_Show);
            

            
            /*con.Open();
            OleDbDataReader reader = null;
            cmd = new OleDbCommand ("SELECT * FROM tbl_users", con);

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label_balance_output.Text = reader["balance"].ToString();
            }

            
            con.Close();*/


        }

         OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
         OleDbCommand cmd = new OleDbCommand();
         OleDbDataAdapter da = new OleDbDataAdapter();

       
        private void Dashboard_Load(object sender, EventArgs e)
        {
            pictureBox_profile.BorderStyle = BorderStyle.None;
            
        }
        
        
       
        Point lastPoint;

        private void Dashboard_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Dashboard_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        

       

        int ekonomi = 1000000;
        int business = 2000000;
        string nama, kota_asal, kota_tujuan, pergi, pulang, jumlah, kelas;
        private void button_beli_Click(object sender, EventArgs e)
        {
            

            if (textBox_nama.Text.Trim() == string.Empty || comboBox_kotaasal.Text.Trim() == string.Empty || comboBox_kotatujuan.Text.Trim() == string.Empty || numericUpDown2.Text.Trim() == string.Empty || comboBox_penerbangan.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill all your details", "Submit Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nama = textBox_nama.Text;
                label_namaa.Text = nama;

                 kota_asal = comboBox_kotaasal.Text;
                label_output_asal.Text = kota_asal;

                 kota_tujuan = comboBox_kotatujuan.Text; 
                label_outputtujuan.Text = kota_tujuan;

                 pergi = dateTimePicker_pergi.Text;
                label_pergi.Text = pergi;

                 pulang = dateTimePicker_pulang.Text;
                label_pulang.Text = pulang;

                 jumlah = numericUpDown2.Text;
                label_jum_pen.Text = jumlah;

                 kelas = comboBox_penerbangan.Text;
                label_pener.Text = kelas;
                label_bandara.Text = comboBox_bandara.Text;
            }


            DateTime startDate = dateTimePicker_pergi.Value.Date;
            DateTime endDate = dateTimePicker_pulang.Value.Date;
            //int totalDays = ((TimeSpan)(endDate - startDate)).Days;
            if (endDate < startDate)
            {
                MessageBox.Show("Please put the right date!");
            }
            else
            {

                if(kelas == "Ekonomi")
                {
                    if (label_pergi.Text == label_pulang.Text)
                    {
                        
                        int total = 1 * ekonomi * Convert.ToInt32(jumlah);
                        label_hargaTotal.Text = Convert.ToString(total);
                    }
                    else
                    {
                        int total = 2 * ekonomi * Convert.ToInt32(jumlah);
                        label_hargaTotal.Text = Convert.ToString(total);
                    }
                    
                }
                else if(kelas == "Business")
                {
                    if (label_pergi.Text == label_pulang.Text)
                    {
                        
                        int total = 1 * business * Convert.ToInt32(jumlah);
                        label_hargaTotal.Text = Convert.ToString(total);
                    }
                    else
                    {
                        int total = 2 * business * Convert.ToInt32(jumlah);
                        label_hargaTotal.Text = Convert.ToString(total);
                    }
                }

               
                


            }

        }

        private void comboBox_kotatujuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_bandara.Items.Clear();

            if(comboBox_kotatujuan.Text == "Jakarta")
            {
                comboBox_bandara.Items.Add("Jakarta - Soekarno-Hatta");
                comboBox_bandara.Items.Add("Jakarta - Halim Perdanakusuma");
                
            }
            
        }

        private void button_logoutt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                new Form_Login().Show();
            }
        }

        private void button_ktp_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBox_ktp.ImageLocation = imageLocation;
                    pictureBox_output_ktp.ImageLocation = imageLocation;
                }
                pictureBox_ktp.BorderStyle = BorderStyle.FixedSingle;

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox_ktp_Click(object sender, EventArgs e)
        {
            pictureBox_ktp.BorderStyle = BorderStyle.None;
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBox_ktp.ImageLocation = imageLocation;
                    pictureBox_output_ktp.ImageLocation = imageLocation;

                }


            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_nama.Clear(); 
            comboBox_kotaasal.ResetText();
            comboBox_kotatujuan.ResetText();
            comboBox_bandara.ResetText();
            dateTimePicker_pergi.ResetText();
            dateTimePicker_pulang.ResetText();
            numericUpDown2.ResetText();
            comboBox_penerbangan.ResetText();
            pictureBox_ktp.Image = null;
        }
















        private void button_beliTiket_Click(object sender, EventArgs e)
        {
         /*   String name = textBox_namalengkap.Text;
            label_nama.Text = name;
           
            if (comboBox_asal.Text == "Jakarta")
            {
                label_asal1.Text = "Soekarno-Hatta - Jakarta";
            }
            if (comboBox_tujuan.Text == "Manado")
            {
                label_tujuan1.Text = "Sam Ratulangi - Manado";
            }

            label_tglPergi1.Text = dateTimePicker_tglPergi.Text;

            label_tglPulang1.Text = dateTimePicker_tglPulang.Text;

            if(comboBox_kelas.Text == "Ekonomi")
            {
                label7.Text = "Ekonomi";
                
            }else if(comboBox_kelas.Text == "Business"){
                label7.Text = "Business";
                
            }







            if (checkBox_dewasa.Checked && numericUpDown_dewasa.Value == 1)
            {

                label_totalHarga.Text = Convert.ToString((dewasa * 1));
                label_jumlahoutput.Text = "Dewasa - 1 Orang";

            }
            else if (checkBox_dewasa.Checked && numericUpDown_dewasa.Value == 2)
            {

                label_totalHarga.Text = Convert.ToString((dewasa * 2));
                label_jumlahoutput.Text = "Dewasa - 2 Orang";
            }

            //anak
            else if (checkBox_anak.Checked && numericUpDown_anak.Value == 2)
            {

                label_totalHarga.Text = Convert.ToString((anak * 2));
                label_jumlahoutput.Text = "Anak - 2 Orang";
            }
            else if (checkBox_anak.Checked && numericUpDown_anak.Value == 1)
            {

                label_totalHarga.Text = Convert.ToString((anak * 1));
                label_jumlahoutput.Text = "Anak - 1 Orang";
            }


            //both
            int a = (dewasa * 1 + anak * 1);
            int b = (dewasa * 1 + anak * 2);
            int c = (dewasa * 2 + anak * 2);
            int d = (dewasa * 2 + anak * 1);
            DateTime startDate = dateTimePicker_tglPergi.Value.Date;
            DateTime endDate = dateTimePicker_tglPulang.Value.Date;
            int totalDays = ((TimeSpan)(endDate - startDate)).Days;
            if (endDate < startDate)
            {
                MessageBox.Show("Please put the right date!");
            }
            else
            {
                *//* if (comboBox_kelas.Text == "Ekonomi")
                 {
                     label_totalHarga.Text = Convert.ToString(totalDays * ekonomi);
                 }
                 else if (comboBox_kelas.Text == "Business")
                 {
                     label_totalHarga.Text = Convert.ToString(totalDays * business);
                 }*//*

                if (checkBox_dewasa.Checked && checkBox_anak.Checked && numericUpDown_dewasa.Value == 1 && numericUpDown_anak.Value == 1 && comboBox_kelas.Text == "Ekonomi")
                {


                    label_totalHarga.Text = Convert.ToString(a) + Convert.ToString(totalDays * ekonomi);
                    label_jumlahoutput.Text = "Dewasa - 1 Orang , Anak - 1 Orang";

                }
                else if (checkBox_dewasa.Checked && checkBox_anak.Checked && numericUpDown_dewasa.Value == 1 && numericUpDown_anak.Value == 1 && comboBox_kelas.Text == "Business")
                {


                    label_totalHarga.Text = Convert.ToString(a) + Convert.ToString(totalDays * business);
                    label_jumlahoutput.Text = "Dewasa - 1 Orang , Anak - 1 Orang";

                }





                else if (checkBox_dewasa.Checked && checkBox_anak.Checked && numericUpDown_dewasa.Value == 1 && numericUpDown_anak.Value == 2 && comboBox_kelas.Text == "Ekonomi")
                {

                    label_totalHarga.Text = Convert.ToString(b) + Convert.ToString(totalDays * ekonomi);

                    label_jumlahoutput.Text = "Dewasa - 1 Orang , Anak - 2 Orang";

                }
                else if (checkBox_dewasa.Checked && checkBox_anak.Checked && numericUpDown_dewasa.Value == 1 && numericUpDown_anak.Value == 2 && comboBox_kelas.Text == "Business")
                {

                    label_totalHarga.Text = Convert.ToString(b) + Convert.ToString(totalDays * business);

                    label_jumlahoutput.Text = "Dewasa - 1 Orang , Anak - 2 Orang";

                }


                else if (!checkBox_dewasa.Checked && !checkBox_anak.Checked || numericUpDown_dewasa.Value == 0 && numericUpDown_anak.Value == 0)
                {


                    label_totalHarga.Text = Convert.ToString(0);
                    MessageBox.Show("Masukan Jumlah Penumpang");

                }


                else if (checkBox_dewasa.Checked && checkBox_anak.Checked && numericUpDown_dewasa.Value == 2 && numericUpDown_anak.Value == 1 && comboBox_kelas.Text == "Ekonomi")
                {

                    label_totalHarga.Text = Convert.ToString(d) + Convert.ToString(totalDays * ekonomi);
                    label_jumlahoutput.Text = "Dewasa - 2 Orang , Anak - 1 Orang";
                }
                else if (checkBox_dewasa.Checked && checkBox_anak.Checked && numericUpDown_dewasa.Value == 2 && numericUpDown_anak.Value == 1 && comboBox_kelas.Text == "Business")
                {

                    label_totalHarga.Text = Convert.ToString(d) + Convert.ToString(totalDays * business);
                    label_jumlahoutput.Text = "Dewasa - 2 Orang , Anak - 1 Orang";
                }


                else if (checkBox_dewasa.Checked && checkBox_anak.Checked && numericUpDown_dewasa.Value == 2 && numericUpDown_anak.Value == 2 && comboBox_kelas.Text == "Ekonomi")
                {
                    label_totalHarga.Text = Convert.ToString(c) + Convert.ToString(totalDays * ekonomi);
                    label_jumlahoutput.Text = "Dewasa - 2 Orang , Anak - 2 Orang";

                }
                else if (checkBox_dewasa.Checked && checkBox_anak.Checked && numericUpDown_dewasa.Value == 2 && numericUpDown_anak.Value == 2 && comboBox_kelas.Text == "Business")
                {
                    label_totalHarga.Text = Convert.ToString(c) + Convert.ToString(totalDays * business);
                    label_jumlahoutput.Text = "Dewasa - 2 Orang , Anak - 2 Orang";

                }
            }
            */

            
            
           /* DateTime startDate = dateTimePicker_tglPergi.Value.Date;
            DateTime endDate = dateTimePicker_tglPulang.Value.Date;
            int totalDays = ((TimeSpan)(endDate - startDate)).Days;
            if (endDate < startDate)
            {
                MessageBox.Show("Please put the right date!");
            }
            else
            {
                if (comboBox_kelas.Text == "Ekonomi")
                {
                    label_totalHarga.Text = Convert.ToString(totalDays * ekonomi);
                }
                else if (comboBox_kelas.Text == "Business")
                {
                    label_totalHarga.Text = Convert.ToString(totalDays * business);
                }

            }*/





           /* int checkpricesatu = Convert.ToInt32(label_checkpricesatu.Text);
            int checkpricedua = Convert.ToInt32(label__checkpricejumlah.Text);

            int total = checkpricedua + checkpricedua;*/
            


        }





        private void button_checkpricejumlah_Click(object sender, EventArgs e)
        {
         /*   if (checkBox_dewasa.Checked && numericUpDown_dewasa.Value == 1)
            {

                label__checkpricejumlah.Text = Convert.ToString((dewasa * 1));
                



            }
            if (checkBox_dewasa.Checked && numericUpDown_dewasa.Value == 2)
            {

                label__checkpricejumlah.Text = Convert.ToString((dewasa * 2));
                
            }
            


            
            //anak
            if (checkBox_anak.Checked && numericUpDown_anak.Value == 2)
            {
               
                label__checkpricejumlah.Text = Convert.ToString((anak * 2));
                
            }
            if (checkBox_anak.Checked && numericUpDown_anak.Value == 1)
            {
                
                label__checkpricejumlah.Text = Convert.ToString((anak * 1));
                
            }


            //both
            int a = (dewasa * 1 + anak * 1);
            int b = (dewasa * 1 + anak * 2);
            int c = (dewasa * 2 + anak * 2);
            int d = (dewasa * 2 + anak * 1);
            if (checkBox_dewasa.Checked && checkBox_anak.Checked && numericUpDown_dewasa.Value == 1 && numericUpDown_anak.Value == 1)
            {
                

                label__checkpricejumlah.Text = Convert.ToString(a);
                

            }
            if (checkBox_dewasa.Checked && checkBox_anak.Checked && numericUpDown_dewasa.Value == 1 && numericUpDown_anak.Value == 2)
            {


                label__checkpricejumlah.Text = Convert.ToString(b);
               

            }
            if (!checkBox_dewasa.Checked && !checkBox_anak.Checked  || numericUpDown_dewasa.Value == 0 && numericUpDown_anak.Value == 0)
            {


                label__checkpricejumlah.Text = Convert.ToString(0);
                MessageBox.Show("Masukan Jumlah Penumpang");

            }


            if (checkBox_dewasa.Checked && checkBox_anak.Checked && numericUpDown_dewasa.Value == 2 && numericUpDown_anak.Value == 1)
            {
                
                label__checkpricejumlah.Text = Convert.ToString(d);
                
            }
            if (checkBox_dewasa.Checked && checkBox_anak.Checked && numericUpDown_dewasa.Value == 2 && numericUpDown_anak.Value == 2)
            {
                
                label__checkpricejumlah.Text = Convert.ToString(c);
            }
            */

        }


        private void button_checkpricejumlahsatu_Click(object sender, EventArgs e)
        {
            /*DateTime startDate = dateTimePicker_tglPergi.Value.Date;
            DateTime endDate = dateTimePicker_tglPulang.Value.Date;
            int totalDays = ((TimeSpan)(endDate - startDate)).Days;
            if (endDate < startDate)
            {
                MessageBox.Show("Please put the right date!");
            }
            else
            {
                if (comboBox_kelas.Text == "Ekonomi")
                {
                    label_checkpricesatu.Text = Convert.ToString(totalDays * ekonomi);
                }
                else if (comboBox_kelas.Text == "Business")
                {
                    label_checkpricesatu.Text = Convert.ToString(totalDays * business);
                }

            }*/
            

            
        }

        

        
        

















        /* private void button_addPic_Click(object sender, EventArgs e)
         {
             con.Open();
             string location ="D:";

             string path = Path.Combine(location, label_name_output.Text + ".jpg");
             cmd = new OleDbCommand("INSERT INTO tbl_users VALUES (@userPic)", con);
             cmd.Parameters.AddWithValue("@userPic", path);
             Image a = pictureBox_profile.Image;
             cmd.ExecuteNonQuery();
             a.Save(path);
             con.Close();
         }*/
    }
}
