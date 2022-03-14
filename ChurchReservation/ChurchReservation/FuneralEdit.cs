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
    public partial class FuneralEdit : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;


        public string funeraledit;

        public FuneralEdit()
        {
            InitializeComponent();
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
            com = new MySqlCommand("Select * from tbl_fun", con);
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



                listView1.Items.Add(lv);
            }
            con.Close();
        }


        public void clear()
        {
            FirstnameFun.Text = "";
            MiddlenameFun.Text= "";
            LastnameFun.Text= "";
            daytext.Text= "";
            monthtext.Text= "";
            FatherFun.Text= "";
            StatusFun.Text= "";
            MotherFun.Text= "";
            WifeFun.Text= "";
            CauseFun.Text= "";
            PlaceFun.Text = "";
            DayFun.Text = "";
            MonthFun.Text = "";
            TimeFun.Text = "";
            contactno.Text = "";
            NamePriestFun.Text = "";
            unenabled();

        }

        public void enabled()
        {
            FirstnameFun.Enabled = true;
            MiddlenameFun.Enabled = true;
            LastnameFun.Enabled = true;
            daytext.Enabled = true;
            monthtext.Enabled = true;
            FatherFun.Enabled = true;
            StatusFun.Enabled = true;
            MotherFun.Enabled = true;
            WifeFun.Enabled = true;
            CauseFun.Enabled = true;
            PlaceFun.Enabled = true;
            DayFun.Enabled = true;
            MonthFun.Enabled = true;
            TimeFun.Enabled = true;
            NamePriestFun.Enabled = true;

        }

        public void unenabled()
        {
            FirstnameFun.Enabled = false;
            MiddlenameFun.Enabled = false;
            LastnameFun.Enabled = false;
            daytext.Enabled = false;
            monthtext.Enabled = false;
            FatherFun.Enabled = false;
            StatusFun.Enabled = false;
            MotherFun.Enabled = false;
            WifeFun.Enabled = false;
            CauseFun.Enabled = false;
            PlaceFun.Enabled = false;
            DayFun.Enabled = false;
            MonthFun.Enabled = false;
            TimeFun.Enabled = false;
            NamePriestFun.Enabled = false;

        }






        public void Ifnull()
        {
            string ex = "Please do fill up all the requirements";


            if ((string.IsNullOrWhiteSpace(FirstnameFun.Text)) | (string.IsNullOrWhiteSpace(MiddlenameFun.Text)) | (string.IsNullOrWhiteSpace(LastnameFun.Text)) | (string.IsNullOrWhiteSpace(daytext.Text)) | (string.IsNullOrWhiteSpace(monthtext.Text)) | (string.IsNullOrWhiteSpace(FatherFun.Text)) | (string.IsNullOrWhiteSpace(StatusFun.Text)) | (string.IsNullOrWhiteSpace(MotherFun.Text)) | (string.IsNullOrWhiteSpace(WifeFun.Text)) | (string.IsNullOrWhiteSpace(CauseFun.Text)) | (string.IsNullOrWhiteSpace(PlaceFun.Text)) | (string.IsNullOrWhiteSpace(DayFun.Text)) | (string.IsNullOrWhiteSpace(MonthFun.Text)) | (string.IsNullOrWhiteSpace(TimeFun.Text)) | (string.IsNullOrWhiteSpace(contactno.Text)| (string.IsNullOrWhiteSpace(NamePriestFun.Text))))
            {
                MessageBox.Show(ex, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            else
            {
                con.Open();
                com = new MySqlCommand("update tbl_fun set Firstfun = '" + FirstnameFun.Text + "', MiddleFun = '" + MiddlenameFun.Text + "',LastFun = '" + LastnameFun.Text + "',Day = '" + daytext.Text + "',Month = '" + monthtext.Text + "',Status = '" + StatusFun.Text + "',Father = '" + FatherFun.Text + "',Mother = '" + MotherFun.Text + "',Wife = '" + WifeFun.Text + "',Cause = '" + CauseFun.Text + "',PlaceofFuneral = '" + PlaceFun.Text + "',DayofFuneral = '" + DayFun.Text + "',MonthofFuneral = '" + MonthFun.Text + "',Time = '" + TimeFun.Text + "',NameofPriest = '" + NamePriestFun.Text + "' where Contact = " + contactno.Text + "", con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Done");
                button2.Enabled = false;
                clear();
                select();
            }
        }




        private void FuneralEdit_Load(object sender, EventArgs e)
        {
            textBox1.Text = funeraledit;
            connection();
            select();
            unenabled();
            button2.Enabled = false;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            button2.Enabled = true;
            enabled();
            contactno.Text = listView1.Items[listView1.SelectedItems[0].Index].Text;
            FirstnameFun.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text;
            MiddlenameFun.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text;
            LastnameFun.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[3].Text;
            daytext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[4].Text;
            monthtext.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[5].Text;
            StatusFun.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[6].Text;
            FatherFun.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[7].Text;
            MotherFun.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[8].Text;
            WifeFun.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[9].Text;
            CauseFun.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[10].Text;
            PlaceFun.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[11].Text;
            DayFun.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[12].Text;
            MonthFun.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[13].Text;
            TimeFun.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[14].Text;
            NamePriestFun.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[15].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ifnull();
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

        private void button1_Click(object sender, EventArgs e)
        {
            EditForms ef = new EditForms();
            ef.editform = textBox1.Text;
            ef.Show();
            this.Hide();
        }
    }
}
