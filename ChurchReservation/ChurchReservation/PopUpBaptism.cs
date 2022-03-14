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
    public partial class PopUpBaptism : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;



        public PopUpBaptism()
        {
            InitializeComponent();
        }

        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
        }

        public void selection()
        {

            con.Open();
            com = new MySqlCommand("Select * from tblpaymentbaptist", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label7.Text = data.GetString("Money");
            }
            con.Close();
        }



        private void PopUpBaptism_Load(object sender, EventArgs e)
        {
            connection();
            selection();
        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            Baptist bap = new Baptist();
            this.Close();
            bap.Show();
            MessageBox.Show("Hello! First you must fill up all the requirements!(Click the requiments Button)");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mm = new Main();
            this.Close();
            mm.Show();
        }
    }
}
