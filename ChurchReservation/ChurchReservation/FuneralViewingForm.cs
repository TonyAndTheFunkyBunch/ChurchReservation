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


    public partial class FuneralViewingForm : Form
    {

        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;


        public string funeralviewing;

        public FuneralViewingForm()
        {
            InitializeComponent();
        }


        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
        }

        public void selectionsjanuary()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + january.Text + "'", con);
            data = com.ExecuteReader();
            listView3.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(12)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(13)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(14)));


                listView3.Items.Add(lv);
            }
            con.Close();
        }


        public void selectionsfebruary()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + february.Text + "'", con);
            data = com.ExecuteReader();
            listView2.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(12)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(13)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(14)));


                listView2.Items.Add(lv);
            }
            con.Close();
        }

        public void selectionsmarch()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + march.Text + "'", con);
            data = com.ExecuteReader();
            listView4.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(12)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(13)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(14)));


                listView4.Items.Add(lv);
            }
            con.Close();
        }

        public void selectionsapril()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + april.Text + "'", con);
            data = com.ExecuteReader();
            listView5.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(12)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(13)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(14)));


                listView5.Items.Add(lv);
            }
            con.Close();
        }

        public void selectionsmay()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + may.Text + "'", con);
            data = com.ExecuteReader();
            listView6.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(12)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(13)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(14)));


                listView6.Items.Add(lv);
            }
            con.Close();
        }

        public void selectionsjune()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + june.Text + "'", con);
            data = com.ExecuteReader();
            listView7.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(12)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(13)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(14)));


                listView7.Items.Add(lv);
            }
            con.Close();
        }

        public void selectionsjuly()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + july.Text + "'", con);
            data = com.ExecuteReader();
            listView8.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(12)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(13)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(14)));


                listView8.Items.Add(lv);
            }
            con.Close();
        }

        public void selectionsaugust()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + august.Text + "'", con);
            data = com.ExecuteReader();
            listView9.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(12)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(13)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(14)));


                listView9.Items.Add(lv);
            }
            con.Close();
        }

        public void selectionsseptember()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + september.Text + "'", con);
            data = com.ExecuteReader();
            listView10.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(12)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(13)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(14)));


                listView10.Items.Add(lv);
            }
            con.Close();
        }

        public void selectionsoctober()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + october.Text + "'", con);
            data = com.ExecuteReader();
            listView11.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(12)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(13)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(14)));


                listView11.Items.Add(lv);
            }
            con.Close();
        }

        public void selectionsnovember()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + november.Text + "'", con);
            data = com.ExecuteReader();
            listView12.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(12)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(13)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(14)));


                listView12.Items.Add(lv);
            }
            con.Close();
        }

        public void selectionsdecember()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + december.Text + "'", con);
            data = com.ExecuteReader();
            listView1.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(12)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(13)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(14)));


                listView1.Items.Add(lv);
            }
            con.Close();
        }



        private void FuneralViewingForm_Load(object sender, EventArgs e)
        {
            textBox13.Text = funeralviewing;
            connection();
            selectionsjanuary();
            selectionsfebruary();
            selectionsmarch();
            selectionsapril();
            selectionsmay();
            selectionsjune();
            selectionsjuly();
            selectionsaugust();
            selectionsseptember();
            selectionsoctober();
            selectionsnovember();
            selectionsdecember();
        }

        private void listView3_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + january.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label21.Text = listView3.Items[listView3.SelectedItems[0].Index].Text;
                label20.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[1].Text;
                label19.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[2].Text;
                label18.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[3].Text;
                label17.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[4].Text;
                label16.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[5].Text;
                label15.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[6].Text;


            }
            con.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void listView2_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + february.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label14.Text = listView2.Items[listView2.SelectedItems[0].Index].Text;
                label13.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[1].Text;
                label12.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[2].Text;
                label11.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[3].Text;
                label10.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[4].Text;
                label9.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[5].Text;
                label8.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[6].Text;


            }
            con.Close();
        }

        private void listView4_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + march.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label28.Text = listView4.Items[listView4.SelectedItems[0].Index].Text;
                label27.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[1].Text;
                label26.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[2].Text;
                label25.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[3].Text;
                label24.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[4].Text;
                label23.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[5].Text;
                label22.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[6].Text;


            }
            con.Close();
        }

        private void listView5_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + april.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label35.Text = listView5.Items[listView5.SelectedItems[0].Index].Text;
                label34.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[1].Text;
                label33.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[2].Text;
                label32.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[3].Text;
                label31.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[4].Text;
                label30.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[5].Text;
                label29.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[6].Text;


            }
            con.Close();
        }

        private void listView6_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + may.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label42.Text = listView6.Items[listView6.SelectedItems[0].Index].Text;
                label41.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[1].Text;
                label40.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[2].Text;
                label39.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[3].Text;
                label38.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[4].Text;
                label37.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[5].Text;
                label36.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[6].Text;


            }
            con.Close();
        }

        private void listView7_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + june.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label49.Text = listView7.Items[listView7.SelectedItems[0].Index].Text;
                label48.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[1].Text;
                label47.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[2].Text;
                label46.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[3].Text;
                label45.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[4].Text;
                label44.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[5].Text;
                label43.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[6].Text;


            }
            con.Close();
        }

        private void listView8_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + july.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label56.Text = listView8.Items[listView8.SelectedItems[0].Index].Text;
                label55.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[1].Text;
                label54.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[2].Text;
                label53.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[3].Text;
                label52.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[4].Text;
                label51.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[5].Text;
                label50.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[6].Text;


            }
            con.Close();
        }

        private void listView9_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + august.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label63.Text = listView9.Items[listView9.SelectedItems[0].Index].Text;
                label62.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[1].Text;
                label61.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[2].Text;
                label60.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[3].Text;
                label59.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[4].Text;
                label58.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[5].Text;
                label57.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[6].Text;


            }
            con.Close();
        }

        private void listView10_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + september.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label70.Text = listView10.Items[listView10.SelectedItems[0].Index].Text;
                label69.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[1].Text;
                label68.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[2].Text;
                label67.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[3].Text;
                label66.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[4].Text;
                label65.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[5].Text;
                label64.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[6].Text;


            }
            con.Close();
        }

        private void listView11_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + october.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label77.Text = listView11.Items[listView11.SelectedItems[0].Index].Text;
                label76.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[1].Text;
                label75.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[2].Text;
                label74.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[3].Text;
                label73.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[4].Text;
                label72.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[5].Text;
                label71.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[6].Text;


            }
            con.Close();
        }

        private void listView12_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + november.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label84.Text = listView12.Items[listView12.SelectedItems[0].Index].Text;
                label83.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[1].Text;
                label82.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[2].Text;
                label81.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[3].Text;
                label80.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[4].Text;
                label79.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[5].Text;
                label78.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[6].Text;


            }
            con.Close();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_fun where MonthofFuneral = '" + december.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label1.Text = listView1.Items[listView1.SelectedItems[0].Index].Text;
                label2.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text;
                label3.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text;
                label4.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[3].Text;
                label5.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[4].Text;
                label6.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[5].Text;
                label7.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[6].Text;


            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Viewing vii = new Viewing();
            vii.viewing = textBox13.Text;
            vii.Show();
            this.Hide();
        }
    }
}
