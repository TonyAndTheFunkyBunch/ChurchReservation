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
    public partial class Fill_upBapt : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;


        public Fill_upBapt()
        {
            InitializeComponent();
        }

        public string fill;

        public string fillupbapt;


        public void DateCompareAndSelect()
        {
            con.Open();
            com = new MySqlCommand("Select * from tbl_baptisms WHERE Monthbap = '" + BuwanBinyag.Text + "'and Daybap = '" + ArawBinyag.Text + "' and Yearbap = '" + TaonBinyag.Text + "' and Timebap = '" + TimeBinyag.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())

                if (data.HasRows)
                {
                    MessageBox.Show("The Date/Time for Baptism is already occupied, Please Choose another");
                    BuwanBinyag.Text = "";
                    ArawBinyag.Text = "";
                    TaonBinyag.Text = "";
                    TimeBinyag.Text = "";
                    con.Close();
                    return;
                }
                else
                {

                }
            con.Close();

        }



        public void insert()
        {
            con.Open();
            com = new MySqlCommand("insert into db_reservation.tbl_baptisms(Firstbap,Middlebap,Lastbapt,Monthbap,Daybap,Yearbap,Timebap,Monthbirth,Daybirth,Yearbirth,Placebirth,Place,Fathername,fatherplace,Mothername,motherplace,Kindofmarriage,Godmother,Godfather,PangalanngPari,Contact)values ('" + FirstnameBapt.Text + "' , '" + MiddlenameBapt.Text + "','" + LastnameBapt.Text + "' ,'" + BuwanBinyag.Text + "' ,'" + ArawBinyag.Text + "' ,'" + TaonBinyag.Text + "', '" + TimeBinyag.Text + "','" + MonthBirth.Text + "' ,'" + DayBirth.Text + "' ,'" + YearBirth.Text + "' ,'" + PlaceofBirth.Text + "' ,'" + PlaceBapt.Text + "' ,'" + FathernameBapt.Text + "' ,'" + PlaceofBirthFatherBapt.Text + "', '" + MothernameBapt.Text + "' ,'" + PlaceofBirthMotherBapt.Text + "' ,'" + Uringkasal.Text + "' , '" + PangunahingNinang.Text + "' ,'" + PangunahingNinong.Text + "' ,'" + NameofPari.Text + "','" + contactno.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
        }
        public void update()
        {
            con.Open();
            com = new MySqlCommand("update tbl_baptisms set Firstbap = '" + FirstnameBapt.Text + "', Middlebap = '" + MiddlenameBapt.Text + "',LastBapt = '" + LastnameBapt.Text + "',Monthbap = '" + BuwanBinyag.Text + "',Daybap = '" + ArawBinyag.Text + "',Yearbap = '" + TaonBinyag.Text + "',Timebap = '" + TimeBinyag.Text + "',Monthbirth = '" + MonthBirth.Text + "',Daybirth = '" + DayBirth.Text + "',Yearbirth = '" + YearBirth.Text + "',Placebirth = '" + PlaceofBirth.Text + "',Place = '" + PlaceBapt.Text + "',Fathername = '" + FathernameBapt.Text + "',fatherplace = '" + PlaceofBirthFatherBapt.Text + "',Mothername = '" + MothernameBapt.Text + "',motherplace = '" + PlaceofBirthMotherBapt.Text + "',Kindofmarriage = '" + Uringkasal.Text + "',Godmother = '" + PangunahingNinang.Text + "',Godfather = '" + PangunahingNinong.Text + "',Pangalanngpari = '" + NameofPari.Text + "' where Contact = " + contactno.Text + "", con);
            com.ExecuteNonQuery();
            con.Close();
        }

        public void select()
        {
            con.Open();
            com = new MySqlCommand("Select * from tbl_baptisms WHERE Contact = '" + contactno.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())

                if (data.HasRows)
                {
                    MessageBox.Show("Contact already exist");
                    contactno.Text = "";
                    con.Close();
                    return;
                }
                else
                {
                }
            con.Close();
        }
                public void connection()
                  {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
                       }



                private void button1_Click(object sender, EventArgs e)
                {
                    DateCompareAndSelect();

                    if ((string.IsNullOrWhiteSpace(FirstnameBapt.Text)) | (string.IsNullOrWhiteSpace(MiddlenameBapt.Text)) | (string.IsNullOrWhiteSpace(LastnameBapt.Text)) | (string.IsNullOrWhiteSpace(BuwanBinyag.Text)) | (string.IsNullOrWhiteSpace(ArawBinyag.Text)) | (string.IsNullOrWhiteSpace(TaonBinyag.Text)) | (string.IsNullOrWhiteSpace(TimeBinyag.Text)) | (string.IsNullOrWhiteSpace(MonthBirth.Text)) | (string.IsNullOrWhiteSpace(DayBirth.Text)) | (string.IsNullOrWhiteSpace(YearBirth.Text)) | (string.IsNullOrWhiteSpace(PlaceofBirth.Text)) | (string.IsNullOrWhiteSpace(PlaceBapt.Text)) | (string.IsNullOrWhiteSpace(FathernameBapt.Text)) | (string.IsNullOrWhiteSpace(PlaceofBirthFatherBapt.Text)) | (string.IsNullOrWhiteSpace(MothernameBapt.Text)) | (string.IsNullOrWhiteSpace(PlaceofBirthMotherBapt.Text)) | (string.IsNullOrWhiteSpace(Uringkasal.Text)) | (string.IsNullOrWhiteSpace(NameofPari.Text)) | (string.IsNullOrWhiteSpace(PangunahingNinang.Text)) | (string.IsNullOrWhiteSpace(PangunahingNinong.Text) | (string.IsNullOrWhiteSpace(contactno.Text))))
                    {
                        MessageBox.Show("Please fill up all the information needed");
                    }


                    else
                    {

                        update();
                        Baptist bp = new Baptist();

                        bp.res = contactno.Text;
                        bp.baptist = textBox3.Text;
                        bp.fillupp = textBox2.Text;


                        this.Hide();
                        bp.Show();
                    }
                }
                

        private void Fill_upBapt_Load(object sender, EventArgs e)
        {
            textBox3.Text = fillupbapt;
            connection();
            contactno.Text = fill;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void PlaceofBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactno_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Baptist bpa = new Baptist();
            bpa.baptist = textBox3.Text;
            bpa.res = contactno.Text;
            bpa.Show();
            this.Hide();
        }
    }
}
