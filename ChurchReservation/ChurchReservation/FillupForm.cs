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
    public partial class FillupForm : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;

        public string fillupform;





        public FillupForm()
        {
            InitializeComponent();
        }


        public string fill;



        public void select()
        {

            con.Open();
            com = new MySqlCommand("Select * from tbl_mar WHERE Contact = '" + contactno.Text + "'", con);
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

        public void DateCompareAndSelect()
        {
            con.Open();
            com = new MySqlCommand("Select * from tbl_mar WHERE day = '" + DAY.Text + "'and Month = '" + MONTH.Text + "' and Year = '" + YEAR.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())

                if (data.HasRows)
                {
                    MessageBox.Show("The DAY for your Wedding is already occupied, Please Choose another");
                    DAY.Text = "";
                    MONTH.Text = "";
                    YEAR.Text = "";
                    con.Close();
                    return;
                }
                else
                {

                }
            con.Close();

        }

        public void update()
        {
            con.Open();
            com = new MySqlCommand("update tbl_mar set Husbandfirst = '" + firsttext.Text + "', Husbandmiddle = '" + middletext.Text + "',Husbandlast = '" + lasttext.Text + "',HusbandDay = '" + daytext.Text + "',HusbandMonth = '" + monthtext.Text + "',HusbandYear = '" + yeartext.Text + "',HusbandCity = '" + citytext.Text + "',HusbandProvince = '" + provincetext.Text + "',HusbandCountry = '" + countrytext.Text + "',HusbandGender = '" + gendertext.Text + "',HusbandReligion = '" + religiontext.Text + "',HusbandCivilStatus = '" + civiltext.Text + "',Husbandfatherfirst = '" + fatherfirsttext.Text + "',Husbandfathermiddle = '" + fathermiddletext.Text + "',Husbandfatherlast = '" + fatherlasttext.Text + "',Husbandfathercitizen = '" + fatherciviltext.Text + "',Husbandmotherfirst = '" + motherfirsttext.Text + "',Husbandmothermiddle = '" + mothermiddletext.Text + "',Husbandmotherlast = '" + motherlasttext.Text + "',Husbandmothercitizen = '" + motherciviltext.Text + "',Wifefirst = '" + firsttextwife.Text + "',Wifemiddle = '" + middletextwife.Text + "',Wifelast = '" + lasttextwife.Text + "',WifeDay = '" + daytextwife.Text + "',WifeMonth = '" + monthtextwife.Text + "',WifeYear = '" + yeartextwife.Text + "',WifeCity = '" + citytextwife.Text + "',WifeProvince = '" + provincetextwife.Text + "',WifeCountry = '" + countrytextwife.Text + "',WifeGender = '" + gendertextwife.Text + "',WifeReligion = '" + religiontextwife.Text + "',WifeCivil = '" + civiltextwife.Text + "',Wifefatherfirst = '" + fatherfirsttextwife.Text + "',Wifefathermiddle = '" + fathermiddletextwife.Text + "',Wifefatherlast = '" + fatherlasttextwife.Text + "',Wifefathercitizen = '" + fff.Text + "',Wifemotherfirst = '" + motherfirsttextwife.Text + "',Wifemothermiddle = '" + mothermiddletextwife.Text + "',Wifemotherlast = '" + motherlasttextwife.Text + "',Wifemothercitizen = '" + mothercitizentextwife.Text + "',Contact = '" + contactno.Text + "',Godfather = '" + Godfather.Text + "',Godmother = '" + Godmother.Text + "' where Contact = " + contactno.Text + "", con);
            com.ExecuteNonQuery();
            con.Close();
        }



        public void insert()
        {
            con.Open();
            com = new MySqlCommand("insert into db_reservation.tbl_mar(Husbandfirst,Husbandmiddle,Husbandlast,HusbandDay,HusbandMonth,HusbandYear,HusbandCity,HusbandProvince,HusbandCountry,HusbandGender,HusbandReligion,HusbandCivilStatus,Husbandfatherfirst,Husbandfathermiddle,Husbandfatherlast,Husbandfathercitizen,Husbandmotherfirst,Husbandmothermiddle,Husbandmotherlast,Husbandmothercitizen,Wifefirst,Wifemiddle,Wifelast,WifeDay,WifeMonth,WifeYear,WifeCity,WifeProvince,WifeCountry,WifeGender,WifeReligion,WifeCivil,Wifefatherfirst,Wifefathermiddle,Wifefatherlast,Wifefathercitizen,Wifemotherfirst,Wifemothermiddle,Wifemotherlast,Wifemothercitizen,Contact,Godfather,Godmother,Day,Month,Year)values ('" + firsttext.Text + "' , '" + middletext.Text + "','" + lasttext.Text + "' ,'" + daytext.Text + "' ,'" + monthtext.Text + "' ,'" + yeartext.Text + "', '" + citytext.Text + "','" + provincetext.Text + "' ,'" + countrytext.Text + "' ,'" + gendertext.Text + "' ,'" + religiontext.Text + "' ,'" + civiltext.Text + "' ,'" + fatherfirsttext.Text + "' ,'" + fathermiddletext.Text + "', '" + fatherlasttext.Text + "' ,'" + fatherciviltext.Text + "' ,'" + motherfirsttext.Text + "' , '" + mothermiddletext.Text + "' ,'" + motherlasttext.Text + "' ,'" + motherciviltext.Text + "' ,'" + firsttextwife.Text + "' , '" + middletextwife.Text + "','" + lasttextwife.Text + "' ,'" + daytextwife.Text + "' ,'" + monthtextwife.Text + "' ,'" + yeartextwife.Text + "', '" + citytextwife.Text + "','" + provincetextwife.Text + "' ,'" + countrytextwife.Text + "' ,'" + gendertextwife.Text + "' ,'" + religiontextwife.Text + "' ,'" + civiltextwife.Text + "' ,'" + fatherfirsttextwife.Text + "' ,'" + fathermiddletextwife.Text + "', '" + fatherlasttextwife.Text + "' ,'" + fff.Text + "' ,'" + motherfirsttextwife.Text + "' , '" + mothermiddletextwife.Text + "' ,'" + motherlasttextwife.Text + "' ,'" + mothercitizentextwife.Text + "','" + contactno.Text + "','" + Godfather.Text + "','" + Godmother.Text + "','" + DAY.Text + "','" + MONTH.Text + "','" + YEAR.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();

        }


        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FillupForm_Load(object sender, EventArgs e)
        {
            connection();
            contactno.Text = fill;
            textBox3.Text = fillupform;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(daytext.Text + monthtext.Text + yeartext.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            
            DateCompareAndSelect();

            if ((string.IsNullOrWhiteSpace(firsttext.Text)) | (string.IsNullOrWhiteSpace(middletext.Text)) | (string.IsNullOrWhiteSpace(lasttext.Text)) | (string.IsNullOrWhiteSpace(daytext.Text)) | (string.IsNullOrWhiteSpace(monthtext.Text)) | (string.IsNullOrWhiteSpace(yeartext.Text)) | (string.IsNullOrWhiteSpace(citytext.Text)) | (string.IsNullOrWhiteSpace(provincetext.Text)) | (string.IsNullOrWhiteSpace(countrytext.Text)) | (string.IsNullOrWhiteSpace(religiontext.Text)) | (string.IsNullOrWhiteSpace(civiltext.Text)) | (string.IsNullOrWhiteSpace(fatherfirsttext.Text)) | (string.IsNullOrWhiteSpace(fathermiddletext.Text)) | (string.IsNullOrWhiteSpace(fatherlasttext.Text)) | (string.IsNullOrWhiteSpace(fatherciviltext.Text)) | (string.IsNullOrWhiteSpace(motherfirsttext.Text)) | (string.IsNullOrWhiteSpace(motherlasttext.Text)) | (string.IsNullOrWhiteSpace(mothermiddletext.Text)) | (string.IsNullOrWhiteSpace(motherciviltext.Text)) | (string.IsNullOrWhiteSpace(gendertext.Text)) | (string.IsNullOrWhiteSpace(firsttextwife.Text)) | (string.IsNullOrWhiteSpace(middletextwife.Text)) | (string.IsNullOrWhiteSpace(lasttextwife.Text)) | (string.IsNullOrWhiteSpace(daytextwife.Text)) | (string.IsNullOrWhiteSpace(monthtextwife.Text)) | (string.IsNullOrWhiteSpace(yeartextwife.Text)) | (string.IsNullOrWhiteSpace(citytextwife.Text)) | (string.IsNullOrWhiteSpace(provincetextwife.Text)) | (string.IsNullOrWhiteSpace(countrytextwife.Text)) | (string.IsNullOrWhiteSpace(religiontextwife.Text)) | (string.IsNullOrWhiteSpace(civiltextwife.Text)) | (string.IsNullOrWhiteSpace(fatherfirsttextwife.Text)) | (string.IsNullOrWhiteSpace(fathermiddletextwife.Text)) | (string.IsNullOrWhiteSpace(fatherlasttextwife.Text)) | (string.IsNullOrWhiteSpace(fff.Text)) | (string.IsNullOrWhiteSpace(motherfirsttextwife.Text)) | (string.IsNullOrWhiteSpace(motherlasttextwife.Text)) | (string.IsNullOrWhiteSpace(mothermiddletextwife.Text)) | (string.IsNullOrWhiteSpace(mothercitizentextwife.Text)) | (string.IsNullOrWhiteSpace(gendertextwife.Text) | (string.IsNullOrWhiteSpace(contactno.Text) | (string.IsNullOrWhiteSpace(Godfather.Text)) | (string.IsNullOrWhiteSpace(Godmother.Text)) | (string.IsNullOrWhiteSpace(DAY.Text)) | (string.IsNullOrWhiteSpace(MONTH.Text)) | (string.IsNullOrWhiteSpace(YEAR.Text)))))
            {
              MessageBox.Show("Please fill up all the information needed");
               return;
            }

            else
            {
                update();
                marriage fl = new marriage();
                fl.res = contactno.Text;
                fl.fillupp = textBox2.Text;
                fl.marriagee = textBox3.Text;
                this.Hide();
                fl.Show();
            }

 

    }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox22_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void provincetext_TextChanged(object sender, EventArgs e)
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

        private void yeartext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

        private void daytextwife_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

        private void YEAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            marriage mn = new marriage();
            mn.marriagee = textBox3.Text;
            mn.res = contactno.Text;
            mn.Show();
            this.Hide();
        }
    }
}