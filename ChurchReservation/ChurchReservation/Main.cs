using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Threading;

namespace ChurchReservation
{
    public partial class Main : Form
    {

        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;

        private string mne;

        public string Passvalue
        {
            get { return mne; }
            set { mne = value; }
        }

        public string aa;

        public Main()
        {
            InitializeComponent();
        }

        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
        }



        private void Main_Load(object sender, EventArgs e)
        {
            user.Text = aa;
            connection();


            con.Open();
            com = new MySqlCommand("select * from tbl_user where Username = '" + user.Text + "'", con);
            data = com.ExecuteReader();
            while (data.Read())
            {
                lvlofaccesslbl.Text = data.GetString("Levelofaccess");
                lvl.Text = data.GetString("Levelofaccess");
                fnamelbl.Text = data.GetString("Firstname");
                lnamelbl.Text = data.GetString("Lastname");
            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationList rl = new RegistrationList();
            rl.registrationlist = user.Text;
            rl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationListBaptist ff = new RegistrationListBaptist();
            ff.registrationlistbaptist = user.Text;
            ff.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            LoginFrm fm = new LoginFrm();
            this.Hide();
            fm.Show();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            RegistrationListFuneral gg = new RegistrationListFuneral();
            gg.registrationlistfuneral = user.Text;
            gg.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoreForm more = new MoreForm();

            more.setting = user.Text; 
            this.Hide();
            more.Show();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void fade_out()
        {
            for (double FadeOut = 90; FadeOut >= 10; FadeOut += -10)
            {
                this.Opacity = FadeOut / 100;
                this.Refresh();
                System.Threading.Thread.Sleep(50);
            }
        }




        private void button6_Click(object sender, EventArgs e)
        {
            int check = 0;
            /*if (check == 0)
            {
                for (int i = 643; i <= 643; i++)
                {
                    this.Size = new Size(1199, i); //893, 643 - 1199, 643
                    Thread.Sleep(5);
                }
                check = 1;
            }
            else if (check == 1)
            {
                for (int i = 643; i >= 643; i--)
                {
                    this.Size = new Size(893, i);
                    Thread.Sleep(5);
                }
                check = 0;
            }*/
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
      
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

}