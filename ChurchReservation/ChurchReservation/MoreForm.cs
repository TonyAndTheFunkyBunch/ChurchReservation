using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChurchReservation
{
    public partial class MoreForm : Form
    {
                MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;


        public MoreForm()
        {
            InitializeComponent();
        }


                public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
        }


        public string setting;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.aa = textBox1.Text;
            this.Hide();
            mn.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Main mn = new Main();
            this.Hide();
            mn.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Main mn = new Main();
            this.Hide();
            mn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Viewing mv = new Viewing();
            mv.viewing = textBox1.Text;
            this.Close();
            mv.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BaptistViewing bap = new BaptistViewing();
            this.Hide();
            bap.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AccountForm acc = new AccountForm();
            acc.accountform = textBox1.Text;
            this.Hide();
            acc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditForms nm = new EditForms();
            nm.editform = textBox1.Text;
            this.Hide();
            nm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CreditsForm cd = new CreditsForm();
            cd.credits = textBox1.Text;
            this.Close();
            cd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InstallmentForm inf = new InstallmentForm();
            inf.installmentform = textBox1.Text;
            inf.Show();
            this.Hide();
        }

        private void MoreForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = setting;

                        connection();


            con.Open();
            com = new MySqlCommand("select * from tbl_user where Username = '" + textBox1.Text + "'", con);
            data = com.ExecuteReader();
            while (data.Read())
            {
                textBox2.Text = data.GetString("Levelofaccess");

            }
            con.Close();


            if(textBox2.Text == ("Client"))
            {
                label11.Enabled = false;
                label4.Enabled = false;
                button2.Enabled = false;
                button5.Enabled = false;
            }

        }


        }

    }
