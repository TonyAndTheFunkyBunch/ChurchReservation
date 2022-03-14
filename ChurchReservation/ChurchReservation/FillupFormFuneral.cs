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
    public partial class FillupFormFuneral : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;

        public FillupFormFuneral()
        {
            InitializeComponent();
        }

        public string fillupformfuneral;
        public string fill;


        public void DateCompareAndSelect()
        {
            con.Open();
            com = new MySqlCommand("Select * from tbl_fun WHERE DayofFuneral = '" + DayFun.Text + "'and MonthofFuneral = '" + MonthFun.Text + "' and Time = '" + TimeFun.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())

                if (data.HasRows)
                {
                    MessageBox.Show("The DAY for the funeral is already occupied, Please Choose another");
                    DayFun.Text = "";
                    MonthFun.Text = "";
                    TimeFun.Text = "";
                    FirstnameFun.Text = "";
                    MiddlenameFun.Text = "";
                    LastnameFun.Text = "";
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

        public void select()
        {

            con.Open();
            com = new MySqlCommand("Select * from tbl_fun WHERE Contact = '" + contactno.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())

                if (data.HasRows)
                {
                    MessageBox.Show("Contact is already exist");
                    contactno.Text = "";
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
            com = new MySqlCommand("insert into db_reservation.tbl_fun(Firstfun,Middlefun,Lastfun,Day,Month,Status,Father,Mother,Wife,Cause,PlaceofFuneral,DayofFuneral,MonthofFuneral,Time,NameofPriest,Contact)values ('" + FirstnameFun.Text + "' , '" + MiddlenameFun.Text + "','" + LastnameFun.Text + "' ,'" + daytext.Text + "' ,'" + monthtext.Text + "' ,'" + StatusFun.Text + "', '" + FatherFun.Text + "','" + MotherFun.Text + "' ,'" + WifeFun.Text + "' ,'" + CauseFun.Text + "' ,'" + PlaceFun.Text + "' ,'" + DayFun.Text + "' ,'" + MonthFun.Text + "' ,'" + TimeFun.Text + "', '" + NamePriestFun.Text + "' ,'" + contactno.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();

        }

        public void update()
        {
                con.Open();
                com = new MySqlCommand("update tbl_fun set Firstfun = '" + FirstnameFun.Text + "', MiddleFun = '" + MiddlenameFun.Text + "',LastFun = '" + LastnameFun.Text + "',Day = '" + daytext.Text + "',Month = '" + monthtext.Text + "',Status = '" + StatusFun.Text + "',Father = '" + FatherFun.Text + "',Mother = '" + MotherFun.Text + "',Wife = '" + WifeFun.Text + "',Cause = '" + CauseFun.Text + "',PlaceofFuneral = '" + PlaceFun.Text + "',DayofFuneral = '" + DayFun.Text + "',MonthofFuneral = '" + MonthFun.Text + "',Time = '" + TimeFun.Text + "',NameofPriest = '" + NamePriestFun.Text + "' where Contact = " + contactno.Text + "", con);
                com.ExecuteNonQuery();
                con.Close();
        }





        private void button1_Click(object sender, EventArgs e)
        {

            DateCompareAndSelect();

            if ((string.IsNullOrWhiteSpace(FirstnameFun.Text)) | (string.IsNullOrWhiteSpace(MiddlenameFun.Text)) | (string.IsNullOrWhiteSpace(LastnameFun.Text)) | (string.IsNullOrWhiteSpace(daytext.Text)) | (string.IsNullOrWhiteSpace(monthtext.Text)) | (string.IsNullOrWhiteSpace(StatusFun.Text)) | (string.IsNullOrWhiteSpace(FatherFun.Text)) | (string.IsNullOrWhiteSpace(MotherFun.Text)) | (string.IsNullOrWhiteSpace(WifeFun.Text)) | (string.IsNullOrWhiteSpace(CauseFun.Text)) | (string.IsNullOrWhiteSpace(PlaceFun.Text)) | (string.IsNullOrWhiteSpace(DayFun.Text)) | (string.IsNullOrWhiteSpace(MonthFun.Text)) | (string.IsNullOrWhiteSpace(TimeFun.Text)) | (string.IsNullOrWhiteSpace(NamePriestFun.Text) | (string.IsNullOrWhiteSpace(contactno.Text))))
            {
                MessageBox.Show("Please fill up all the information needed");
                return;
            }

            else
            {
                update();
                FuneralForm fn = new FuneralForm();
                fn.res = contactno.Text;
                fn.fillupp = textBox2.Text;
                fn.funeralform = textBox3.Text;
                this.Hide();
                fn.Show();



            }
        }

        private void FillupFormFuneral_Load(object sender, EventArgs e)
        {
            connection();
            textBox3.Text = fillupformfuneral;
            contactno.Text = fill;
        }

        private void TimeFun_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FuneralForm fn = new FuneralForm();
            fn.res = contactno.Text;
            fn.funeralform = textBox3.Text;
            this.Hide();
            fn.Show();
        }
    }
}
