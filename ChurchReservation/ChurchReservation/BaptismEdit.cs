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
    public partial class BaptismEdit : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;


        public string baptismEdit;


        public BaptismEdit()
        {
            InitializeComponent();
        }

        public void unenabled()
        {
            FirstnameBapt.Enabled = false;
            MiddlenameBapt.Enabled = false;
            LastnameBapt.Enabled = false;
            BuwanBinyag.Enabled = false;
            ArawBinyag.Enabled = false;
            TaonBinyag.Enabled = false;
            TimeBinyag.Enabled = false;
            MonthBirth.Enabled = false;
            DayBirth.Enabled = false;
            YearBirth.Enabled = false;
            PlaceofBirth.Enabled = false;
            PlaceBapt.Enabled = false;
            FathernameBapt.Enabled = false;
            PlaceofBirthFatherBapt.Enabled = false;
            MothernameBapt.Enabled = false;
            PlaceofBirthMotherBapt.Enabled = false;
            Uringkasal.Enabled = false;
            PangunahingNinong.Enabled = false;
            PangunahingNinang.Enabled = false;
            NameofPari.Enabled = false;

        }

        public void enabled()
        {
            FirstnameBapt.Enabled = true;
            MiddlenameBapt.Enabled = true;
            LastnameBapt.Enabled = true;
            BuwanBinyag.Enabled = true;
            ArawBinyag.Enabled = true;
            TaonBinyag.Enabled = true;
            TimeBinyag.Enabled = true;
            MonthBirth.Enabled = true;
            DayBirth.Enabled = true;
            YearBirth.Enabled = true;
            PlaceofBirth.Enabled = true;
            PlaceBapt.Enabled = true;
            FathernameBapt.Enabled = true;
            PlaceofBirthFatherBapt.Enabled = true;
            MothernameBapt.Enabled = true;
            PlaceofBirthMotherBapt.Enabled = true;
            Uringkasal.Enabled = true;
            PangunahingNinong.Enabled = true;
            PangunahingNinang.Enabled = true;
            NameofPari.Enabled = true;
        }

        public void cleartb()
        {
            FirstnameBapt.Text = "";
            MiddlenameBapt.Text = "";
            LastnameBapt.Text = "";
            BuwanBinyag.Text = "";
            ArawBinyag.Text = "";
            TaonBinyag.Text = "";
            TimeBinyag.Text = "";
            MonthBirth.Text = "";
            DayBirth.Text = "";
            YearBirth.Text = "";
            PlaceofBirth.Text = "";
            PlaceBapt.Text = "";
            FathernameBapt.Text = "";
            PlaceofBirthFatherBapt.Text = "";
            MothernameBapt.Text = "";
            PlaceofBirthMotherBapt.Text = "";
            Uringkasal.Text = "";
            PangunahingNinong.Text = "";
            PangunahingNinang.Text = "";
            NameofPari.Text = "";
            contactno.Text = "";
            MessageBox.Show("Done");
            unenabled();
        }

        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
        }

        public void Ifnull()
        {
            string ex = "Please do fill up all the requirements";


            if ((string.IsNullOrWhiteSpace(FirstnameBapt.Text)) | (string.IsNullOrWhiteSpace(MiddlenameBapt.Text)) | (string.IsNullOrWhiteSpace(LastnameBapt.Text)) | (string.IsNullOrWhiteSpace(BuwanBinyag.Text)) | (string.IsNullOrWhiteSpace(ArawBinyag.Text)) | (string.IsNullOrWhiteSpace(TaonBinyag.Text)) | (string.IsNullOrWhiteSpace(TimeBinyag.Text)) | (string.IsNullOrWhiteSpace(MonthBirth.Text)) | (string.IsNullOrWhiteSpace(DayBirth.Text)) | (string.IsNullOrWhiteSpace(YearBirth.Text)) | (string.IsNullOrWhiteSpace(PlaceofBirth.Text)) | (string.IsNullOrWhiteSpace(PlaceBapt.Text)) | (string.IsNullOrWhiteSpace(FathernameBapt.Text)) | (string.IsNullOrWhiteSpace(PlaceofBirthFatherBapt.Text)) | (string.IsNullOrWhiteSpace(MothernameBapt.Text)) | (string.IsNullOrWhiteSpace(PlaceofBirthMotherBapt.Text)) | (string.IsNullOrWhiteSpace(Uringkasal.Text)) | (string.IsNullOrWhiteSpace(NameofPari.Text)) | (string.IsNullOrWhiteSpace(PangunahingNinang.Text)) | (string.IsNullOrWhiteSpace(PangunahingNinong.Text) | (string.IsNullOrWhiteSpace(contactno.Text))))
            {
                MessageBox.Show(ex, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            else
            {
                con.Open();
                com = new MySqlCommand("update tbl_baptisms set Firstbap = '" + FirstnameBapt.Text + "', Middlebap = '" + MiddlenameBapt.Text + "',LastBapt = '" + LastnameBapt.Text + "',Monthbap = '" + BuwanBinyag.Text + "',Daybap = '" + ArawBinyag.Text + "',Yearbap = '" + TaonBinyag.Text + "',Timebap = '" + TimeBinyag.Text + "',Monthbirth = '" + MonthBirth.Text + "',Daybirth = '" + DayBirth.Text + "',Yearbirth = '" + YearBirth.Text + "',Placebirth = '" + PlaceofBirth.Text + "',Place = '" + PlaceBapt.Text + "',Fathername = '" + FathernameBapt.Text + "',fatherplace = '" + PlaceofBirthFatherBapt.Text + "',Mothername = '" + MothernameBapt.Text + "',motherplace = '" + PlaceofBirthMotherBapt.Text + "',Kindofmarriage = '" + Uringkasal.Text + "',Godmother = '" + PangunahingNinang.Text + "',Godfather = '" + PangunahingNinong.Text + "',Pangalanngpari = '" + NameofPari.Text + "' where Contact = " + contactno.Text + "", con);
                com.ExecuteNonQuery();
                con.Close();
                cleartb();
                select();
            }
        }

        public void select()
        {


            con.Open();
            com = new MySqlCommand("Select * from tbl_baptisms", con);
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




                listView1.Items.Add(lv);
            }
            con.Close();
        }



        private void BaptismEdit_Load(object sender, EventArgs e)
        {
            textBox1.Text = baptismEdit;
            connection();
            select();
            unenabled();
            

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            enabled();
            contactno.Text = listView1.Items[listView1.SelectedItems[0].Index].Text;
            FirstnameBapt.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text;
            MiddlenameBapt.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text;
            LastnameBapt.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[3].Text;
            BuwanBinyag.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[4].Text;
            ArawBinyag.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[5].Text;
            TaonBinyag.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[6].Text;
            TimeBinyag.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[7].Text;
            MonthBirth.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[8].Text;
            DayBirth.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[9].Text;
            YearBirth.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[10].Text;
            PlaceofBirth.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[11].Text;
            PlaceBapt.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[12].Text;
            FathernameBapt.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[13].Text;
            PlaceofBirthFatherBapt.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[14].Text;
            MothernameBapt.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[15].Text;
            PlaceofBirthMotherBapt.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[16].Text;
            Uringkasal.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[17].Text;
            PangunahingNinong.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[18].Text;
            PangunahingNinang.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[19].Text;
            NameofPari.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[20].Text;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            Ifnull();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditForms cc = new EditForms();
            cc.editform = textBox1.Text;
            this.Hide();
            cc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn_TextChanged(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            searchbtn.Text = "";
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            FirstnameBapt.Text = "";
            MiddlenameBapt.Text = "";
            LastnameBapt.Text = "";
            BuwanBinyag.Text = "";
            ArawBinyag.Text = "";
            TaonBinyag.Text = "";
            TimeBinyag.Text = "";
            MonthBirth.Text = "";
            DayBirth.Text = "";
            YearBirth.Text = "";
            PlaceofBirth.Text = "";
            PlaceBapt.Text = "";
            FathernameBapt.Text = "";
            PlaceofBirthFatherBapt.Text = "";
            MothernameBapt.Text = "";
            PlaceofBirthMotherBapt.Text = "";
            Uringkasal.Text = "";
            PangunahingNinong.Text = "";
            PangunahingNinang.Text = "";
            NameofPari.Text = "";
            contactno.Text = "";
            unenabled();
        }
    }
}
