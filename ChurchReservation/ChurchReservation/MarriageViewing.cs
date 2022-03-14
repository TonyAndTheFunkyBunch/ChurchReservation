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
    public partial class MarriageViewing : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;

        public MarriageViewing()
        {
            InitializeComponent();
        }

        public void selection()
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Contact = '" + contactno.Text + "'", con);


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



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void MarriageViewing_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
            button2.Visible = false;
        }
    }
}
