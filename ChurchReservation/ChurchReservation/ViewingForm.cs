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
    public partial class ViewingForm : Form
    {
        public ViewingForm()
        {
            InitializeComponent();
        }

        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;

        public string viewingform;

        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
        }

        public void selections()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + january.Text + "'", con);
            data = com.ExecuteReader();
            listView1.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(43)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(44)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(45)));
                lv.SubItems.Add(data.GetValue(1).ToString());
                lv.SubItems.Add(data.GetValue(2).ToString());
                lv.SubItems.Add(data.GetValue(3).ToString());
                lv.SubItems.Add(data.GetValue(23).ToString());
                lv.SubItems.Add(data.GetValue(22).ToString());
                lv.SubItems.Add(data.GetValue(21).ToString());
 


                listView1.Items.Add(lv);
            }
            con.Close();
        }

        public void selectionsfeb()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + february.Text + "'", con);
            data = com.ExecuteReader();
            listView2.Items.Clear();

            while (data.Read())
            {
                ListViewItem lve = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lve.SubItems.Add(Convert.ToString(data.GetValue(43)));
                lve.SubItems.Add(Convert.ToString(data.GetValue(44)));
                lve.SubItems.Add(Convert.ToString(data.GetValue(45)));
                lve.SubItems.Add(data.GetValue(1).ToString());
                lve.SubItems.Add(data.GetValue(2).ToString());
                lve.SubItems.Add(data.GetValue(3).ToString());
                lve.SubItems.Add(data.GetValue(23).ToString());
                lve.SubItems.Add(data.GetValue(22).ToString());
                lve.SubItems.Add(data.GetValue(21).ToString());



                listView2.Items.Add(lve);
            }
            con.Close();
        }

        public void selectionsmar()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + march.Text + "'", con);
            data = com.ExecuteReader();
            listView3.Items.Clear();

            while (data.Read())
            {
                ListViewItem lvem = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lvem.SubItems.Add(Convert.ToString(data.GetValue(43)));
                lvem.SubItems.Add(Convert.ToString(data.GetValue(44)));
                lvem.SubItems.Add(Convert.ToString(data.GetValue(45)));
                lvem.SubItems.Add(data.GetValue(1).ToString());
                lvem.SubItems.Add(data.GetValue(2).ToString());
                lvem.SubItems.Add(data.GetValue(3).ToString());
                lvem.SubItems.Add(data.GetValue(23).ToString());
                lvem.SubItems.Add(data.GetValue(22).ToString());
                lvem.SubItems.Add(data.GetValue(21).ToString());



                listView3.Items.Add(lvem);
            }
            con.Close();
        }

        public void selectionsapr()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + april.Text + "'", con);
            data = com.ExecuteReader();
            listView4.Items.Clear();

            while (data.Read())
            {
                ListViewItem lveap = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lveap.SubItems.Add(Convert.ToString(data.GetValue(43)));
                lveap.SubItems.Add(Convert.ToString(data.GetValue(44)));
                lveap.SubItems.Add(Convert.ToString(data.GetValue(45)));
                lveap.SubItems.Add(data.GetValue(1).ToString());
                lveap.SubItems.Add(data.GetValue(2).ToString());
                lveap.SubItems.Add(data.GetValue(3).ToString());
                lveap.SubItems.Add(data.GetValue(23).ToString());
                lveap.SubItems.Add(data.GetValue(22).ToString());
                lveap.SubItems.Add(data.GetValue(21).ToString());



                listView4.Items.Add(lveap);
            }
            con.Close();
        }

        public void selectionsmay()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + may.Text + "'", con);
            data = com.ExecuteReader();
            listView5.Items.Clear();

            while (data.Read())
            {
                ListViewItem lvemay = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lvemay.SubItems.Add(Convert.ToString(data.GetValue(43)));
                lvemay.SubItems.Add(Convert.ToString(data.GetValue(44)));
                lvemay.SubItems.Add(Convert.ToString(data.GetValue(45)));
                lvemay.SubItems.Add(data.GetValue(1).ToString());
                lvemay.SubItems.Add(data.GetValue(2).ToString());
                lvemay.SubItems.Add(data.GetValue(3).ToString());
                lvemay.SubItems.Add(data.GetValue(23).ToString());
                lvemay.SubItems.Add(data.GetValue(22).ToString());
                lvemay.SubItems.Add(data.GetValue(21).ToString());



                listView5.Items.Add(lvemay);
            }
            con.Close();
        }

        public void selectionsjune()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + junee.Text + "'", con);
            data = com.ExecuteReader();
            listView6.Items.Clear();

            while (data.Read())
            {
                ListViewItem lvejune = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lvejune.SubItems.Add(Convert.ToString(data.GetValue(43)));
                lvejune.SubItems.Add(Convert.ToString(data.GetValue(44)));
                lvejune.SubItems.Add(Convert.ToString(data.GetValue(45)));
                lvejune.SubItems.Add(data.GetValue(1).ToString());
                lvejune.SubItems.Add(data.GetValue(2).ToString());
                lvejune.SubItems.Add(data.GetValue(3).ToString());
                lvejune.SubItems.Add(data.GetValue(23).ToString());
                lvejune.SubItems.Add(data.GetValue(22).ToString());
                lvejune.SubItems.Add(data.GetValue(21).ToString());



                listView6.Items.Add(lvejune);
            }
            con.Close();
        }

        public void selectionsjuly()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + julyy.Text + "'", con);
            data = com.ExecuteReader();
            listView7.Items.Clear();

            while (data.Read())
            {
                ListViewItem lvejuly = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lvejuly.SubItems.Add(Convert.ToString(data.GetValue(43)));
                lvejuly.SubItems.Add(Convert.ToString(data.GetValue(44)));
                lvejuly.SubItems.Add(Convert.ToString(data.GetValue(45)));
                lvejuly.SubItems.Add(data.GetValue(1).ToString());
                lvejuly.SubItems.Add(data.GetValue(2).ToString());
                lvejuly.SubItems.Add(data.GetValue(3).ToString());
                lvejuly.SubItems.Add(data.GetValue(23).ToString());
                lvejuly.SubItems.Add(data.GetValue(22).ToString());
                lvejuly.SubItems.Add(data.GetValue(21).ToString());



                listView7.Items.Add(lvejuly);
            }
            con.Close();
        }

        public void selectionsaugust()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + augustt.Text + "'", con);
            data = com.ExecuteReader();
            listView8.Items.Clear();

            while (data.Read())
            {
                ListViewItem lveaugust = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lveaugust.SubItems.Add(Convert.ToString(data.GetValue(43)));
                lveaugust.SubItems.Add(Convert.ToString(data.GetValue(44)));
                lveaugust.SubItems.Add(Convert.ToString(data.GetValue(45)));
                lveaugust.SubItems.Add(data.GetValue(1).ToString());
                lveaugust.SubItems.Add(data.GetValue(2).ToString());
                lveaugust.SubItems.Add(data.GetValue(3).ToString());
                lveaugust.SubItems.Add(data.GetValue(23).ToString());
                lveaugust.SubItems.Add(data.GetValue(22).ToString());
                lveaugust.SubItems.Add(data.GetValue(21).ToString());



                listView8.Items.Add(lveaugust);
            }
            con.Close();
        }

        public void selectionssemptember()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + september.Text + "'", con);
            data = com.ExecuteReader();
            listView9.Items.Clear();

            while (data.Read())
            {
                ListViewItem lvesep = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lvesep.SubItems.Add(Convert.ToString(data.GetValue(43)));
                lvesep.SubItems.Add(Convert.ToString(data.GetValue(44)));
                lvesep.SubItems.Add(Convert.ToString(data.GetValue(45)));
                lvesep.SubItems.Add(data.GetValue(1).ToString());
                lvesep.SubItems.Add(data.GetValue(2).ToString());
                lvesep.SubItems.Add(data.GetValue(3).ToString());
                lvesep.SubItems.Add(data.GetValue(23).ToString());
                lvesep.SubItems.Add(data.GetValue(22).ToString());
                lvesep.SubItems.Add(data.GetValue(21).ToString());



                listView9.Items.Add(lvesep);
            }
            con.Close();
        }


        public void selectionsoctober()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + october.Text + "'", con);
            data = com.ExecuteReader();
            listView10.Items.Clear();

            while (data.Read())
            {
                ListViewItem lveoct = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lveoct.SubItems.Add(Convert.ToString(data.GetValue(43)));
                lveoct.SubItems.Add(Convert.ToString(data.GetValue(44)));
                lveoct.SubItems.Add(Convert.ToString(data.GetValue(45)));
                lveoct.SubItems.Add(data.GetValue(1).ToString());
                lveoct.SubItems.Add(data.GetValue(2).ToString());
                lveoct.SubItems.Add(data.GetValue(3).ToString());
                lveoct.SubItems.Add(data.GetValue(23).ToString());
                lveoct.SubItems.Add(data.GetValue(22).ToString());
                lveoct.SubItems.Add(data.GetValue(21).ToString());



                listView10.Items.Add(lveoct);
            }
            con.Close();
        }

        public void selectionsnovember()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + november.Text + "'", con);
            data = com.ExecuteReader();
            listView11.Items.Clear();

            while (data.Read())
            {
                ListViewItem lvenov = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lvenov.SubItems.Add(Convert.ToString(data.GetValue(43)));
                lvenov.SubItems.Add(Convert.ToString(data.GetValue(44)));
                lvenov.SubItems.Add(Convert.ToString(data.GetValue(45)));
                lvenov.SubItems.Add(data.GetValue(1).ToString());
                lvenov.SubItems.Add(data.GetValue(2).ToString());
                lvenov.SubItems.Add(data.GetValue(3).ToString());
                lvenov.SubItems.Add(data.GetValue(23).ToString());
                lvenov.SubItems.Add(data.GetValue(22).ToString());
                lvenov.SubItems.Add(data.GetValue(21).ToString());



                listView11.Items.Add(lvenov);
            }
            con.Close();
        }


        public void selectionsdecember()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + december.Text + "'", con);
            data = com.ExecuteReader();
            listView12.Items.Clear();

            while (data.Read())
            {
                ListViewItem lvedec = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lvedec.SubItems.Add(Convert.ToString(data.GetValue(43)));
                lvedec.SubItems.Add(Convert.ToString(data.GetValue(44)));
                lvedec.SubItems.Add(Convert.ToString(data.GetValue(45)));
                lvedec.SubItems.Add(data.GetValue(1).ToString());
                lvedec.SubItems.Add(data.GetValue(2).ToString());
                lvedec.SubItems.Add(data.GetValue(3).ToString());
                lvedec.SubItems.Add(data.GetValue(23).ToString());
                lvedec.SubItems.Add(data.GetValue(22).ToString());
                lvedec.SubItems.Add(data.GetValue(21).ToString());



                listView12.Items.Add(lvedec);
            }
            con.Close();
        }












        private void ViewingForm_Load(object sender, EventArgs e)
        {
            textBox13.Text = viewingform;
            connection();
            selections();
            selectionsfeb();
            selectionsmar();
            selectionsapr();
            selectionsmay();
            selectionsjune();
            selectionsjuly();
            selectionsaugust();
            selectionssemptember();
            selectionsoctober();
            selectionsnovember();
            selectionsdecember();

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + january.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label1.Text = listView1.Items[listView1.SelectedItems[0].Index].Text;
                label2.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text;
                label3.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text;
                label4.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[3].Text;
                label5.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[4].Text;
                label61.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[5].Text;
                label62.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[6].Text;
                label63.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[7].Text;
                label64.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[8].Text;
                label65.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[9].Text;

               
            }
                con.Close();
        }


        private void listView2_ItemActivate_1(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + february.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label15.Text = listView2.Items[listView2.SelectedItems[0].Index].Text;
                label13.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[1].Text;
                label14.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[2].Text;
                label12.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[3].Text;
                label11.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[4].Text;
                label10.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[5].Text;
                label9.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[6].Text;
                label8.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[7].Text;
                label7.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[8].Text;
                label6.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[9].Text;


            }
            con.Close();
        }

        private void listView3_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + march.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label25.Text = listView3.Items[listView3.SelectedItems[0].Index].Text;
                label23.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[1].Text;
                label24.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[2].Text;
                label22.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[3].Text;
                label21.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[4].Text;
                label20.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[5].Text;
                label19.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[6].Text;
                label18.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[7].Text;
                label17.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[8].Text;
                label16.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[9].Text;


            }
            con.Close();
        }

        private void listView4_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + april.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label35.Text = listView4.Items[listView4.SelectedItems[0].Index].Text;
                label33.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[1].Text;
                label34.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[2].Text;
                label32.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[3].Text;
                label31.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[4].Text;
                label30.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[5].Text;
                label29.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[6].Text;
                label28.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[7].Text;
                label27.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[8].Text;
                label26.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[9].Text;


            }
            con.Close();
        }

        private void listView5_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + may.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label45.Text = listView5.Items[listView5.SelectedItems[0].Index].Text;
                label43.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[1].Text;
                label44.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[2].Text;
                label42.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[3].Text;
                label41.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[4].Text;
                label40.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[5].Text;
                label39.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[6].Text;
                label38.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[7].Text;
                label37.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[8].Text;
                label36.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[9].Text;


            }
            con.Close();
        }

        private void listView6_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + junee.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label55.Text = listView6.Items[listView6.SelectedItems[0].Index].Text;
                label53.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[1].Text;
                label54.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[2].Text;
                label52.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[3].Text;
                label51.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[4].Text;
                label50.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[5].Text;
                label49.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[6].Text;
                label48.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[7].Text;
                label47.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[8].Text;
                label46.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[9].Text;


            }
            con.Close();
        }

        private void listView7_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + julyy.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label70.Text = listView7.Items[listView7.SelectedItems[0].Index].Text;
                label68.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[1].Text;
                label69.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[2].Text;
                label67.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[3].Text;
                label66.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[4].Text;
                label60.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[5].Text;
                label59.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[6].Text;
                label58.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[7].Text;
                label57.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[8].Text;
                label56.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[9].Text;


            }
            con.Close();
        }

        private void listView8_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + augustt.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label80.Text = listView8.Items[listView8.SelectedItems[0].Index].Text;
                label78.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[1].Text;
                label79.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[2].Text;
                label77.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[3].Text;
                label76.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[4].Text;
                label75.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[5].Text;
                label74.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[6].Text;
                label73.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[7].Text;
                label72.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[8].Text;
                label71.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[9].Text;

            }
            con.Close();
        }

        private void listView9_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + september.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label90.Text = listView9.Items[listView9.SelectedItems[0].Index].Text;
                label88.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[1].Text;
                label89.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[2].Text;
                label87.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[3].Text;
                label86.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[4].Text;
                label85.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[5].Text;
                label84.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[6].Text;
                label83.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[7].Text;
                label82.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[8].Text;
                label81.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[9].Text;

            }
            con.Close();
        }

        private void listView10_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + october.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label100.Text = listView10.Items[listView10.SelectedItems[0].Index].Text;
                label98.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[1].Text;
                label99.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[2].Text;
                label97.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[3].Text;
                label96.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[4].Text;
                label95.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[5].Text;
                label94.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[6].Text;
                label93.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[7].Text;
                label92.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[8].Text;
                label91.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[9].Text;

            }
            con.Close();
        }

        private void listView11_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + november.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label110.Text = listView11.Items[listView11.SelectedItems[0].Index].Text;
                label108.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[1].Text;
                label109.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[2].Text;
                label107.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[3].Text;
                label106.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[4].Text;
                label105.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[5].Text;
                label104.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[6].Text;
                label103.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[7].Text;
                label102.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[8].Text;
                label101.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[9].Text;

            }
            con.Close();
        }

        private void listView12_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Month = '" + december.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label120.Text = listView12.Items[listView12.SelectedItems[0].Index].Text;
                label118.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[1].Text;
                label119.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[2].Text;
                label117.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[3].Text;
                label116.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[4].Text;
                label115.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[5].Text;
                label114.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[6].Text;
                label113.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[7].Text;
                label112.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[8].Text;
                label111.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[9].Text;

            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label61.Text = "";
            label62.Text = "";
            label63.Text = "";
            label64.Text = "";
            label65.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label15.Text = "";
            label13.Text = "";
            label14.Text = "";
            label12.Text = "";
            label11.Text = "";
            label10.Text = "";
            label9.Text = "";
            label8.Text = "";
            label7.Text = "";
            label6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label25.Text = "";
            label23.Text = "";
            label24.Text = "";
            label22.Text = "";
            label21.Text = "";
            label20.Text = "";
            label19.Text = "";
            label18.Text = "";
            label17.Text = "";
            label16.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label35.Text = "";
            label33.Text = "";
            label34.Text = "";
            label32.Text = "";
            label31.Text = "";
            label30.Text = "";
            label29.Text = "";
            label28.Text = "";
            label27.Text = "";
            label26.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label45.Text = "";
            label43.Text = "";
            label44.Text = "";
            label42.Text = "";
            label41.Text = "";
            label40.Text = "";
            label39.Text = "";
            label38.Text = "";
            label37.Text = "";
            label36.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label55.Text = "";
            label53.Text = "";
            label54.Text = "";
            label52.Text = "";
            label51.Text = "";
            label50.Text = "";
            label49.Text = "";
            label48.Text = "";
            label47.Text = "";
            label46.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label70.Text = "";
            label68.Text = "";
            label69.Text = "";
            label67.Text = "";
            label66.Text = "";
            label60.Text = "";
            label59.Text = "";
            label58.Text = "";
            label57.Text = "";
            label56.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label80.Text = "";
            label78.Text = "";
            label79.Text = "";
            label77.Text = "";
            label76.Text = "";
            label75.Text = "";
            label74.Text = "";
            label73.Text = "";
            label72.Text = "";
            label71.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label90.Text = "";
            label88.Text = "";
            label89.Text = "";
            label87.Text = "";
            label86.Text = "";
            label85.Text = "";
            label84.Text = "";
            label83.Text = "";
            label82.Text = "";
            label81.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label100.Text = "";
            label98.Text = "";
            label99.Text = "";
            label97.Text = "";
            label96.Text = "";
            label95.Text = "";
            label94.Text = "";
            label93.Text = "";
            label92.Text = "";
            label91.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label110.Text = "";
            label108.Text = "";
            label109.Text = "";
            label107.Text = "";
            label106.Text = "";
            label105.Text = "";
            label104.Text = "";
            label103.Text = "";
            label102.Text = "";
            label101.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label120.Text = "";
            label118.Text = "";
            label119.Text = "";
            label117.Text = "";
            label116.Text = "";
            label115.Text = "";
            label114.Text = "";
            label113.Text = "";
            label112.Text = "";
            label111.Text = "";
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox11.Text != "")
                {
                    foreach (ListViewItem item in listView12.Items)
                    {
                        if (item.Text.ToLower().Contains(textBox11.Text.ToLower()))
                        {
                            item.Selected = true;
                        }
                        else
                        {
                            listView12.Items.Remove(item);
                        }

                    }
                    if (listView12.SelectedItems.Count == 1)
                    {
                        listView12.Focus();
                    }
                }
                else
                {
                    selectionsdecember();
                }
            } 
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox10.Text != "")
                {
                    foreach (ListViewItem item in listView11.Items)
                    {
                        if (item.Text.ToLower().Contains(textBox10.Text.ToLower()))
                        {
                            item.Selected = true;
                        }
                        else
                        {
                            listView11.Items.Remove(item);
                        }

                    }
                    if (listView11.SelectedItems.Count == 1)
                    {
                        listView11.Focus();
                    }
                }
                else
                {
                    selectionsnovember();
                }
            } 
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox9.Text != "")
                {
                    foreach (ListViewItem item in listView10.Items)
                    {
                        if (item.Text.ToLower().Contains(textBox9.Text.ToLower()))
                        {
                            item.Selected = true;
                        }
                        else
                        {
                            listView10.Items.Remove(item);
                        }

                    }
                    if (listView10.SelectedItems.Count == 1)
                    {
                        listView10.Focus();
                    }
                }
                else
                {
                    selectionsoctober();
                }
            } 
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox8.Text != "")
                {
                    foreach (ListViewItem item in listView9.Items)
                    {
                        if (item.Text.ToLower().Contains(textBox8.Text.ToLower()))
                        {
                            item.Selected = true;
                        }
                        else
                        {
                            listView9.Items.Remove(item);
                        }

                    }
                    if (listView9.SelectedItems.Count == 1)
                    {
                        listView9.Focus();
                    }
                }
                else
                {
                    selectionssemptember();
                }
            } 
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox7.Text != "")
                {
                    foreach (ListViewItem item in listView8.Items)
                    {
                        if (item.Text.ToLower().Contains(textBox7.Text.ToLower()))
                        {
                            item.Selected = true;
                        }
                        else
                        {
                            listView8.Items.Remove(item);
                        }

                    }
                    if (listView8.SelectedItems.Count == 1)
                    {
                        listView8.Focus();
                    }
                }
                else
                {
                    selectionsaugust();
                }
            } 
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox6.Text != "")
                {
                    foreach (ListViewItem item in listView7.Items)
                    {
                        if (item.Text.ToLower().Contains(textBox6.Text.ToLower()))
                        {
                            item.Selected = true;
                        }
                        else
                        {
                            listView7.Items.Remove(item);
                        }

                    }
                    if (listView7.SelectedItems.Count == 1)
                    {
                        listView7.Focus();
                    }
                }
                else
                {
                    selectionsjuly();
                }
            } 
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox5.Text != "")
                {
                    foreach (ListViewItem item in listView6.Items)
                    {
                        if (item.Text.ToLower().Contains(textBox5.Text.ToLower()))
                        {
                            item.Selected = true;
                        }
                        else
                        {
                            listView6.Items.Remove(item);
                        }

                    }
                    if (listView6.SelectedItems.Count == 1)
                    {
                        listView6.Focus();
                    }
                }
                else
                {
                    selectionsjune();
                }
            } 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox4.Text != "")
                {
                    foreach (ListViewItem item in listView5.Items)
                    {
                        if (item.Text.ToLower().Contains(textBox4.Text.ToLower()))
                        {
                            item.Selected = true;
                        }
                        else
                        {
                            listView5.Items.Remove(item);
                        }

                    }
                    if (listView5.SelectedItems.Count == 1)
                    {
                        listView5.Focus();
                    }
                }
                else
                {
                    selectionsmay();
                }
            } 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox3.Text != "")
                {
                    foreach (ListViewItem item in listView4.Items)
                    {
                        if (item.Text.ToLower().Contains(textBox3.Text.ToLower()))
                        {
                            item.Selected = true;
                        }
                        else
                        {
                            listView4.Items.Remove(item);
                        }

                    }
                    if (listView4.SelectedItems.Count == 1)
                    {
                        listView4.Focus();
                    }
                }
                else
                {
                    selectionsapr();
                }
            } 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox2.Text != "")
                {
                    foreach (ListViewItem item in listView3.Items)
                    {
                        if (item.Text.ToLower().Contains(textBox2.Text.ToLower()))
                        {
                            item.Selected = true;
                        }
                        else
                        {
                            listView3.Items.Remove(item);
                        }

                    }
                    if (listView3.SelectedItems.Count == 1)
                    {
                        listView3.Focus();
                    }
                }
                else
                {
                    selectionsmar();
                }
            } 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (textBox1.Text != "")
                {
                    foreach (ListViewItem item in listView2.Items)
                    {
                        if (item.Text.ToLower().Contains(textBox1.Text.ToLower()))
                        {
                            item.Selected = true;
                        }
                        else
                        {
                            listView2.Items.Remove(item);
                        }

                    }
                    if (listView2.SelectedItems.Count == 1)
                    {
                        listView2.Focus();
                    }
                }
                else
                {
                    selectionsfeb();
                }
            } 
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
                    selections();
                }
            } 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Viewing mr = new Viewing();
            mr.viewing = textBox13.Text;
            this.Hide();
            mr.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        }
}
