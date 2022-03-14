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
    public partial class WeddingEdit : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;

       


        public string weddingedit;



        public WeddingEdit()
        {
            InitializeComponent();
        }
        public void clear()
        {

            motherciviltextwife.Text = "";
            motherlasttextwife.Text = "";
            mothermiddletextwife.Text = "";
            motherfirsttextwife.Text = "";
            fatherciviltextwife.Text = "";
            fatherlasttextwife.Text = "";
            fathermiddletextwife.Text = "";
            fatherfirsttextwife.Text = "";
            civiltextwife.Text = "";
            religiontextwife.Text = "";
            gendertextwife.Text = "";
            countrytextwife.Text = "";
            provincetextwife.Text = "";
            citytextwife.Text = "";
            yeartextwife.Text = "";
            provincetext.Text = "";
            monthtextwife.Text = "";
            daytextwife.Text = "";
            lasttextwife.Text = "";
            countrytext.Text = "";
            middletextwife.Text = "";
            gendertext.Text = "";
            firsttextwife.Text = "";
            motherciviltext.Text = "";
            religiontext.Text = "";
            motherlasttext.Text = "";
            civiltext.Text = "";
            mothermiddletext.Text = "";
            motherfirsttext.Text = "";
            fatherciviltext.Text = "";
            fatherlasttext.Text = "";
            fathermiddletext.Text = "";
            fatherfirsttext.Text = "";
            citytext.Text = "";
            yeartext.Text = "";
            monthtext.Text = "";
            daytext.Text = "";
            lasttext.Text = "";
            middletext.Text = "";
            firsttext.Text = "";
            contactno.Text = "";
            Godmother.Text = "";
            Godfather.Text = "";
            unenabled();
        }

        public void unenabled()
        {
            Godfather.Enabled = false;
            Godmother.Enabled = false;
            motherciviltextwife.Enabled = false;
            mothermiddletextwife.Enabled = false;
            motherfirsttextwife.Enabled = false;
            fatherciviltextwife.Enabled = false;
            fatherlasttextwife.Enabled = false;
            fathermiddletextwife.Enabled = false;
            fatherfirsttextwife.Enabled = false;
            civiltextwife.Enabled = false;
            religiontextwife.Enabled = false;
            gendertextwife.Enabled = false;
            countrytextwife.Enabled = false;
            provincetextwife.Enabled = false;
            citytextwife.Enabled = false;
            yeartextwife.Enabled = false;
            provincetext.Enabled = false;
            monthtextwife.Enabled = false;
            daytextwife.Enabled = false;
            lasttextwife.Enabled = false;
            countrytext.Enabled = false;
            middletextwife.Enabled = false;
            gendertext.Enabled = false;
            firsttextwife.Enabled = false;
            motherciviltext.Enabled = false;
            religiontext.Enabled = false;
            motherlasttext.Enabled = false;
            civiltext.Enabled = false;
            mothermiddletext.Enabled = false;
            motherfirsttext.Enabled = false;
            fatherciviltext.Enabled = false;
            fatherlasttext.Enabled = false;
            fathermiddletext.Enabled = false;
            fatherfirsttext.Enabled = false;
            citytext.Enabled = false;
            yeartext.Enabled = false;
            monthtext.Enabled = false;
            daytext.Enabled = false;
            lasttext.Enabled = false;
            middletext.Enabled = false;
            firsttext.Enabled = false;
        }

        public void enabled()
        {
            Godfather.Enabled = true;
            Godmother.Enabled = true;
            motherciviltextwife.Enabled = true;
            mothermiddletextwife.Enabled = true;
            motherfirsttextwife.Enabled = true;
            fatherciviltextwife.Enabled = true;
            fatherlasttextwife.Enabled = true;
            fathermiddletextwife.Enabled = true;
            fatherfirsttextwife.Enabled = true;
            civiltextwife.Enabled = true;
            religiontextwife.Enabled = true;
            gendertextwife.Enabled = true;
            countrytextwife.Enabled = true;
            provincetextwife.Enabled = true;
            citytextwife.Enabled = true;
            yeartextwife.Enabled = true;
            provincetext.Enabled = true;
            monthtextwife.Enabled = true;
            daytextwife.Enabled = true;
            lasttextwife.Enabled = true;
            countrytext.Enabled = true;
            middletextwife.Enabled = true;
            gendertext.Enabled = true;
            firsttextwife.Enabled = true;
            motherciviltext.Enabled = true;
            religiontext.Enabled = true;
            motherlasttext.Enabled = true;
            civiltext.Enabled = true;
            mothermiddletext.Enabled = true;
            motherfirsttext.Enabled = true;
            fatherciviltext.Enabled = true;
            fatherlasttext.Enabled = true;
            fathermiddletext.Enabled = true;
            fatherfirsttext.Enabled = true;
            citytext.Enabled = true;
            yeartext.Enabled = true;
            monthtext.Enabled = true;
            daytext.Enabled = true;
            lasttext.Enabled = true;
            middletext.Enabled = true;
            firsttext.Enabled = true;
        }

        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
        }


       public void ifnull()
        {
            string ex = "Please do fill up all the requirements";

            if ((string.IsNullOrWhiteSpace(firsttext.Text)) | (string.IsNullOrWhiteSpace(middletext.Text)) | (string.IsNullOrWhiteSpace(lasttext.Text)) | (string.IsNullOrWhiteSpace(daytext.Text)) | (string.IsNullOrWhiteSpace(monthtext.Text)) | (string.IsNullOrWhiteSpace(yeartext.Text)) | (string.IsNullOrWhiteSpace(citytext.Text)) | (string.IsNullOrWhiteSpace(provincetext.Text)) | (string.IsNullOrWhiteSpace(countrytext.Text)) | (string.IsNullOrWhiteSpace(religiontext.Text)) | (string.IsNullOrWhiteSpace(civiltext.Text)) | (string.IsNullOrWhiteSpace(fatherfirsttext.Text)) | (string.IsNullOrWhiteSpace(fathermiddletext.Text)) | (string.IsNullOrWhiteSpace(fatherlasttext.Text)) | (string.IsNullOrWhiteSpace(fatherciviltext.Text)) | (string.IsNullOrWhiteSpace(motherfirsttext.Text)) | (string.IsNullOrWhiteSpace(motherlasttext.Text)) | (string.IsNullOrWhiteSpace(mothermiddletext.Text)) | (string.IsNullOrWhiteSpace(motherciviltext.Text)) | (string.IsNullOrWhiteSpace(gendertext.Text)) | (string.IsNullOrWhiteSpace(firsttextwife.Text)) | (string.IsNullOrWhiteSpace(middletextwife.Text)) | (string.IsNullOrWhiteSpace(lasttextwife.Text)) | (string.IsNullOrWhiteSpace(daytextwife.Text)) | (string.IsNullOrWhiteSpace(monthtextwife.Text)) | (string.IsNullOrWhiteSpace(yeartextwife.Text)) | (string.IsNullOrWhiteSpace(citytextwife.Text)) | (string.IsNullOrWhiteSpace(provincetextwife.Text)) | (string.IsNullOrWhiteSpace(countrytextwife.Text)) | (string.IsNullOrWhiteSpace(religiontextwife.Text)) | (string.IsNullOrWhiteSpace(civiltextwife.Text)) | (string.IsNullOrWhiteSpace(fatherfirsttextwife.Text)) | (string.IsNullOrWhiteSpace(fathermiddletextwife.Text)) | (string.IsNullOrWhiteSpace(fatherlasttextwife.Text)) | (string.IsNullOrWhiteSpace(fatherciviltextwife.Text)) | (string.IsNullOrWhiteSpace(motherfirsttextwife.Text)) | (string.IsNullOrWhiteSpace(motherlasttextwife.Text)) | (string.IsNullOrWhiteSpace(mothermiddletextwife.Text)) | (string.IsNullOrWhiteSpace(motherciviltextwife.Text)) | (string.IsNullOrWhiteSpace(gendertextwife.Text) | (string.IsNullOrWhiteSpace(contactno.Text) | (string.IsNullOrWhiteSpace(Godfather.Text)) | (string.IsNullOrWhiteSpace(Godmother.Text)))))
            {
                MessageBox.Show(ex, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                con.Open();
                com = new MySqlCommand("update tbl_mar set Husbandfirst = '" + firsttext.Text + "', Husbandmiddle = '" + middletext.Text + "',Husbandlast = '" + lasttext.Text + "',HusbandDay = '" + daytext.Text + "',HusbandMonth = '" + monthtext.Text + "',HusbandYear = '" + yeartext.Text + "',HusbandCity = '" + citytext.Text + "',HusbandProvince = '" + provincetext.Text + "',HusbandCountry = '" + countrytext.Text + "',HusbandGender = '" + gendertext.Text + "',HusbandReligion = '" + religiontext.Text + "',HusbandCivilStatus = '" + civiltext.Text + "',Husbandfatherfirst = '" + fatherfirsttext.Text + "',Husbandfathermiddle = '" + fathermiddletext.Text + "',Husbandfatherlast = '" + fatherlasttext.Text + "',Husbandfathercitizen = '" + fatherciviltext.Text + "',Husbandmotherfirst = '" + motherfirsttext.Text + "',Husbandmothermiddle = '" + mothermiddletext.Text + "',Husbandmotherlast = '" + motherlasttext.Text + "',Husbandmothercitizen = '" + motherciviltext.Text + "',Wifefirst = '" + firsttextwife.Text + "',Wifemiddle = '" + middletextwife.Text + "',Wifelast = '" + lasttextwife.Text + "',WifeDay = '" + daytextwife.Text + "',WifeMonth = '" + monthtextwife.Text + "',WifeYear = '" + yeartextwife.Text + "',WifeCity = '" + citytextwife.Text + "',WifeProvince = '" + provincetextwife.Text + "',WifeCountry = '" + countrytextwife.Text + "',WifeGender = '" + gendertextwife.Text + "',WifeReligion = '" + religiontextwife.Text + "',WifeCivil = '" + civiltextwife.Text + "',Wifefatherfirst = '" + fatherfirsttextwife.Text + "',Wifefathermiddle = '" + fathermiddletextwife.Text + "',Wifefatherlast = '" + fatherlasttextwife.Text + "',Wifefathercitizen = '" + fatherciviltextwife.Text + "',Wifemotherfirst = '" + motherfirsttextwife.Text + "',Wifemothermiddle = '" + mothermiddletextwife.Text + "',Wifemotherlast = '" + motherlasttextwife.Text + "',Wifemothercitizen = '" + motherciviltextwife.Text + "',Contact = '" + contactno.Text + "',Godfather = '" + Godfather.Text + "',Godmother = '" + Godmother.Text + "' where Contact = " + contactno.Text + "", con);
                com.ExecuteNonQuery();
                con.Close();
                clear();
                select();
            }
        }


        public void select()
        {


            con.Open();
            com = new MySqlCommand("Select * from tbl_mar", con);
            data = com.ExecuteReader();
            listView1.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(data.GetValue(2).ToString());
                lv.SubItems.Add(data.GetValue(3).ToString());
                lv.SubItems.Add(data.GetValue(4).ToString());
                lv.SubItems.Add(data.GetValue(5).ToString());
                lv.SubItems.Add(data.GetValue(6).ToString());
                lv.SubItems.Add(data.GetValue(7).ToString());
                lv.SubItems.Add(data.GetValue(8).ToString());
                lv.SubItems.Add(data.GetValue(9).ToString());
                lv.SubItems.Add(data.GetValue(10).ToString());
                lv.SubItems.Add(data.GetValue(11).ToString());
                lv.SubItems.Add(data.GetValue(12).ToString());
                lv.SubItems.Add(data.GetValue(13).ToString());
                lv.SubItems.Add(data.GetValue(14).ToString());
                lv.SubItems.Add(data.GetValue(15).ToString());
                lv.SubItems.Add(data.GetValue(16).ToString());
                lv.SubItems.Add(data.GetValue(17).ToString());
                lv.SubItems.Add(data.GetValue(18).ToString());
                lv.SubItems.Add(data.GetValue(19).ToString());
                lv.SubItems.Add(data.GetValue(20).ToString());
                lv.SubItems.Add(data.GetValue(21).ToString());
                lv.SubItems.Add(data.GetValue(22).ToString());
                lv.SubItems.Add(data.GetValue(23).ToString());
                lv.SubItems.Add(data.GetValue(24).ToString());
                lv.SubItems.Add(data.GetValue(25).ToString());
                lv.SubItems.Add(data.GetValue(26).ToString());
                lv.SubItems.Add(data.GetValue(27).ToString());
                lv.SubItems.Add(data.GetValue(28).ToString());
                lv.SubItems.Add(data.GetValue(29).ToString());
                lv.SubItems.Add(data.GetValue(30).ToString());
                lv.SubItems.Add(data.GetValue(31).ToString());
                lv.SubItems.Add(data.GetValue(32).ToString());
                lv.SubItems.Add(data.GetValue(33).ToString());
                lv.SubItems.Add(data.GetValue(34).ToString());
                lv.SubItems.Add(data.GetValue(35).ToString());
                lv.SubItems.Add(data.GetValue(36).ToString());
                lv.SubItems.Add(data.GetValue(37).ToString());
                lv.SubItems.Add(data.GetValue(38).ToString());
                lv.SubItems.Add(data.GetValue(39).ToString());
                lv.SubItems.Add(data.GetValue(40).ToString());
                lv.SubItems.Add(data.GetValue(41).ToString());
                lv.SubItems.Add(data.GetValue(42).ToString());




                listView1.Items.Add(lv);
            }
            con.Close();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fatherlasttext_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void WeddingEdit_Load(object sender, EventArgs e)
        {
            textBox1.Text = weddingedit;
            connection();
            select();
            unenabled();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (searchbtn.Text != "")
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        if (item.Text.ToLower().Contains(searchbtn.Text.ToLower()))
                        {
                            item.Selected = true;
                        }
                        else
                        {
                            listView1.Items.Remove(item);
                        }

                    }
                    if (listView1.SelectedItems.Count == 1)
                    {
                        listView1.Focus();
                    }
                }
                else
                {
                    select();
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchbtn.Text = "";
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {

            enabled();
            contactno.Text = listView1.Items[listView1.SelectedItems[0].Index].Text;
             firsttext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text;
            middletext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text;
            lasttext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[3].Text;
            daytext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[4].Text;
            monthtext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[5].Text;
            yeartext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[6].Text;
            citytext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[7].Text;
            provincetext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[8].Text;
            countrytext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[9].Text;
            gendertext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[10].Text;
            religiontext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[11].Text;
            civiltext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[12].Text;
            fatherfirsttext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[13].Text;
            fathermiddletext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[14].Text;
            fatherlasttext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[15].Text;
            fatherciviltext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[16].Text;
            motherfirsttext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[17].Text;
            motherlasttext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[19].Text;
            mothermiddletext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[18].Text;
            motherciviltext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[20].Text;
            firsttextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[21].Text;
            middletextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[22].Text;
            lasttextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[23].Text;
            daytextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[24].Text;
            monthtextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[25].Text;
            yeartextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[26].Text;
            citytextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[27].Text;
            provincetextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[28].Text;
            countrytextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[29].Text;
            gendertextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[30].Text;
            religiontextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[31].Text;
            civiltextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[32].Text;
            fatherfirsttextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[33].Text;
            fathermiddletextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[34].Text;
            fatherlasttextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[35].Text;
            fatherciviltextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[36].Text;
            motherfirsttextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[37].Text;
            mothermiddletextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[38].Text;
            motherlasttextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[39].Text;
            motherciviltextwife.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[40].Text;
            Godmother.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[41].Text;
            Godfather.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[42].Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ifnull();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditForms mf = new EditForms();
            mf.editform = textBox1.Text;
            this.Hide();
            mf.Show();
        }
    }
}
