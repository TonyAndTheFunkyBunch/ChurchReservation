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
    public partial class BaptistViewing : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;


        public BaptistViewing()
        {
            InitializeComponent();
        }

        public void clear()
        {
            label1.Text = "";
            label2.Text = "";
            label4.Text = "";
            label6.Text = "";
            label18.Text = "";
            label19.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label22.Text = "";
            label24.Text = "";
            label3.Text = "";
            label25.Text ="";
            label26.Text = "";
            label29.Text = "";
            label30.Text = "";
            label10.Text = "";
            label13.Text = "";
            label16.Text = "";

        }



        public void selection()
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Contact = '" + contactno.Text + "'", con);


            data = com.ExecuteReader();

            int count = 0;

            while (data.Read())
            {
                count += 1;
            }

            if (count == 1)
            {

                label1.Text = data.GetString("Firstbap");
                label2.Text = data.GetString("Middlebap");
                label4.Text = data.GetString("Lastbapt");
                label6.Text = data.GetString("MonthBap");
                label13.Text = data.GetString("DayBap");
                label16.Text = data.GetString("YearBap");
                label3.Text = data.GetString("TimeBap");
                label10.Text = data.GetString("Monthbirth");
                label18.Text = data.GetString("Daybirth");
                label19.Text = data.GetString("Yearbirth");
                label7.Text = data.GetString("Placebirth");
                label8.Text = data.GetString("Place");
                label8.Text = data.GetString("Fathername");
                label25.Text = data.GetString("fatherplace");
                label9.Text = data.GetString("Mothername");
                label26.Text = data.GetString("motherplace");
                label22.Text = data.GetString("Kindofmarriage");
                label29.Text = data.GetString("Godmother");
                label30.Text = data.GetString("Godfather");
                label24.Text = data.GetString("PangalanngPari");
                

                con.Close();


            }

            else
            {
                MessageBox.Show("Search Not Found");
                
                con.Close();
                contactno.Text = "";
                button1.Visible = true;
                button2.Visible = false;
                return;


            }

        }



        private void BaptistViewing_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
            button2.Visible = false;


        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(contactno.Text.Equals(""))
            {
                MessageBox.Show("Invalid");
                contactno.Text = "";
                button1.Visible = true;
                button2.Visible = false;
                return;
            }

            button1.Visible = false;
            button2.Visible = true;


            selection();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            contactno.Text = "";
            clear();
        }
        }
    }

