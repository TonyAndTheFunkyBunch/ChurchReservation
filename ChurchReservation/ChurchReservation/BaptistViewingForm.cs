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
    public partial class BaptistViewingForm : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;


        public string baptistviewing;


        public BaptistViewingForm()
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
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + january.Text + "'", con);
            data = com.ExecuteReader();
            listView1.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(4)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(5)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(6)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
     



                listView1.Items.Add(lv);
            }
            con.Close();
        }

        public void selectionsfebruary()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + february.Text + "'", con);
            data = com.ExecuteReader();
            listView2.Items.Clear();

            while (data.Read())
            {
                ListViewItem lve = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lve.SubItems.Add(Convert.ToString(data.GetValue(4)));
                lve.SubItems.Add(Convert.ToString(data.GetValue(5)));
                lve.SubItems.Add(Convert.ToString(data.GetValue(6)));
                lve.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lve.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lve.SubItems.Add(Convert.ToString(data.GetValue(3)));




                listView2.Items.Add(lve);
            }
            con.Close();
        }

        public void selectionsmarch()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + march.Text + "'", con);
            data = com.ExecuteReader();
            listView3.Items.Clear();

            while (data.Read())
            {
                ListViewItem lvee = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lvee.SubItems.Add(Convert.ToString(data.GetValue(4)));
                lvee.SubItems.Add(Convert.ToString(data.GetValue(5)));
                lvee.SubItems.Add(Convert.ToString(data.GetValue(6)));
                lvee.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lvee.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lvee.SubItems.Add(Convert.ToString(data.GetValue(3)));




                listView3.Items.Add(lvee);
            }
            con.Close();
        }

        public void selectionsapril()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + april.Text + "'", con);
            data = com.ExecuteReader();
            listView4.Items.Clear();

            while (data.Read())
            {
                ListViewItem lveee = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lveee.SubItems.Add(Convert.ToString(data.GetValue(4)));
                lveee.SubItems.Add(Convert.ToString(data.GetValue(5)));
                lveee.SubItems.Add(Convert.ToString(data.GetValue(6)));
                lveee.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lveee.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lveee.SubItems.Add(Convert.ToString(data.GetValue(3)));




                listView4.Items.Add(lveee);
            }
            con.Close();
        }

        public void selectionsmay()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + may.Text + "'", con);
            data = com.ExecuteReader();
            listView5.Items.Clear();

            while (data.Read())
            {
                ListViewItem lveeee = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lveeee.SubItems.Add(Convert.ToString(data.GetValue(4)));
                lveeee.SubItems.Add(Convert.ToString(data.GetValue(5)));
                lveeee.SubItems.Add(Convert.ToString(data.GetValue(6)));
                lveeee.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lveeee.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lveeee.SubItems.Add(Convert.ToString(data.GetValue(3)));




                listView5.Items.Add(lveeee);
            }
            con.Close();
        }

        public void selectionsjune()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + june.Text + "'", con);
            data = com.ExecuteReader();
            listView6.Items.Clear();

            while (data.Read())
            {
                ListViewItem lveeeee = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lveeeee.SubItems.Add(Convert.ToString(data.GetValue(4)));
                lveeeee.SubItems.Add(Convert.ToString(data.GetValue(5)));
                lveeeee.SubItems.Add(Convert.ToString(data.GetValue(6)));
                lveeeee.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lveeeee.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lveeeee.SubItems.Add(Convert.ToString(data.GetValue(3)));




                listView6.Items.Add(lveeeee);
            }
            con.Close();
        }

        public void selectionsjuly()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + july.Text + "'", con);
            data = com.ExecuteReader();
            listView7.Items.Clear();

            while (data.Read())
            {
                ListViewItem lveeeeee = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lveeeeee.SubItems.Add(Convert.ToString(data.GetValue(4)));
                lveeeeee.SubItems.Add(Convert.ToString(data.GetValue(5)));
                lveeeeee.SubItems.Add(Convert.ToString(data.GetValue(6)));
                lveeeeee.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lveeeeee.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lveeeeee.SubItems.Add(Convert.ToString(data.GetValue(3)));




                listView7.Items.Add(lveeeeee);
            }
            con.Close();
        }

        public void selectionsaugust()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + august.Text + "'", con);
            data = com.ExecuteReader();
            listView8.Items.Clear();

            while (data.Read())
            {
                ListViewItem lveeeeeee = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lveeeeeee.SubItems.Add(Convert.ToString(data.GetValue(4)));
                lveeeeeee.SubItems.Add(Convert.ToString(data.GetValue(5)));
                lveeeeeee.SubItems.Add(Convert.ToString(data.GetValue(6)));
                lveeeeeee.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lveeeeeee.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lveeeeeee.SubItems.Add(Convert.ToString(data.GetValue(3)));




                listView8.Items.Add(lveeeeeee);
            }
            con.Close();
        }

        public void selectionsseptember()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + september.Text + "'", con);
            data = com.ExecuteReader();
            listView9.Items.Clear();

            while (data.Read())
            {
                ListViewItem lveeeeeeee = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lveeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(4)));
                lveeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(5)));
                lveeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(6)));
                lveeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lveeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lveeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(3)));




                listView9.Items.Add(lveeeeeeee);
            }
            con.Close();
        }


        public void selectionsoctober()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + october.Text + "'", con);
            data = com.ExecuteReader();
            listView10.Items.Clear();

            while (data.Read())
            {
                ListViewItem lveeeeeeeee = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lveeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(4)));
                lveeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(5)));
                lveeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(6)));
                lveeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lveeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lveeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(3)));




                listView10.Items.Add(lveeeeeeeee);
            }
            con.Close();
        }

        public void selectionsnovember()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + november.Text + "'", con);
            data = com.ExecuteReader();
            listView11.Items.Clear();

            while (data.Read())
            {
                ListViewItem lveeeeeeeeee = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lveeeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(4)));
                lveeeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(5)));
                lveeeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(6)));
                lveeeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lveeeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lveeeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(3)));




                listView11.Items.Add(lveeeeeeeeee);
            }
            con.Close();
        }

        public void selectionsdecember()
        {

            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + december.Text + "'", con);
            data = com.ExecuteReader();
            listView12.Items.Clear();

            while (data.Read())
            {
                ListViewItem lveeeeeeeeeee = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lveeeeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(4)));
                lveeeeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(5)));
                lveeeeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(6)));
                lveeeeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lveeeeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lveeeeeeeeeee.SubItems.Add(Convert.ToString(data.GetValue(3)));




                listView12.Items.Add(lveeeeeeeeeee);
            }
            con.Close();
        }




        private void BaptistViewingForm_Load(object sender, EventArgs e)
        {
            textBox12.Text = baptistviewing;
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

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + january.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label1.Text = listView1.Items[listView1.SelectedItems[0].Index].Text;
                label3.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[1].Text;
                label2.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[2].Text;
                label4.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[3].Text;
                label6.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[4].Text;
                label5.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[5].Text;
                label7.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[6].Text;


            }
            con.Close();
        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }

        private void listView2_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + february.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label14.Text = listView2.Items[listView2.SelectedItems[0].Index].Text;
                label12.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[1].Text;
                label13.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[2].Text;
                label11.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[3].Text;
                label10.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[4].Text;
                label9.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[5].Text;
                label8.Text = listView2.Items[listView2.SelectedItems[0].Index].SubItems[6].Text;



            }
            con.Close();
        }

        private void listView3_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + march.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label21.Text = listView3.Items[listView3.SelectedItems[0].Index].Text;
                label19.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[1].Text;
                label20.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[2].Text;
                label18.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[3].Text;
                label17.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[4].Text;
                label16.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[5].Text;
                label15.Text = listView3.Items[listView3.SelectedItems[0].Index].SubItems[6].Text;

            }
            con.Close();
        }

        private void listView4_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + april.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label28.Text = listView4.Items[listView4.SelectedItems[0].Index].Text;
                label26.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[1].Text;
                label27.Text = listView4.Items[listView4.SelectedItems[0].Index].SubItems[2].Text;
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
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + may.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label35.Text = listView5.Items[listView5.SelectedItems[0].Index].Text;
                label33.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[1].Text;
                label34.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[2].Text;
                label32.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[3].Text;
                label31.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[4].Text;
                label30.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[5].Text;
                label39.Text = listView5.Items[listView5.SelectedItems[0].Index].SubItems[6].Text;

            }
            con.Close();
        }

        private void listView6_ItemActivate(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + june.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label42.Text = listView6.Items[listView6.SelectedItems[0].Index].Text;
                label40.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[1].Text;
                label41.Text = listView6.Items[listView6.SelectedItems[0].Index].SubItems[2].Text;
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
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + july.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label49.Text = listView7.Items[listView7.SelectedItems[0].Index].Text;
                label47.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[1].Text;
                label48.Text = listView7.Items[listView7.SelectedItems[0].Index].SubItems[2].Text;
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
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + august.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label56.Text = listView8.Items[listView8.SelectedItems[0].Index].Text;
                label54.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[1].Text;
                label55.Text = listView8.Items[listView8.SelectedItems[0].Index].SubItems[2].Text;
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
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + september.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label63.Text = listView9.Items[listView9.SelectedItems[0].Index].Text;
                label61.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[1].Text;
                label62.Text = listView9.Items[listView9.SelectedItems[0].Index].SubItems[2].Text;
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
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + october.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label70.Text = listView10.Items[listView10.SelectedItems[0].Index].Text;
                label68.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[1].Text;
                label69.Text = listView10.Items[listView10.SelectedItems[0].Index].SubItems[2].Text;
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
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + november.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label77.Text = listView11.Items[listView11.SelectedItems[0].Index].Text;
                label75.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[1].Text;
                label76.Text = listView11.Items[listView11.SelectedItems[0].Index].SubItems[2].Text;
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
            com = new MySqlCommand("select * from tbl_baptisms where Monthbap = '" + december.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                label84.Text = listView12.Items[listView12.SelectedItems[0].Index].Text;
                label82.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[1].Text;
                label83.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[2].Text;
                label81.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[3].Text;
                label80.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[4].Text;
                label79.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[5].Text;
                label78.Text = listView12.Items[listView12.SelectedItems[0].Index].SubItems[6].Text;
            }
            con.Close();
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
                    selectionsjanuary();
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
                    selectionsfebruary();
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
                    selectionsmarch();
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
                    selectionsapril();
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
                    selectionsseptember();
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

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label3.Text = "";
            label2.Text = "";
            label4.Text = "";
            label6.Text = "";
            label5.Text = "";
            label7.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            label10.Text = "";
            label9.Text = "";
            label11.Text = "";
            label13.Text = "";
            label12.Text = "";
            label14.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label15.Text = "";
            label17.Text = "";
            label16.Text = "";
            label18.Text = "";
            label20.Text = "";
            label19.Text = "";
            label21.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label22.Text = "";
            label24.Text = "";
            label23.Text = "";
            label25.Text = "";
            label27.Text = "";
            label26.Text = "";
            label28.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label29.Text = "";
            label31.Text = "";
            label30.Text = "";
            label32.Text = "";
            label34.Text = "";
            label33.Text = "";
            label35.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label36.Text = "";
            label38.Text = "";
            label37.Text = "";
            label39.Text = "";
            label41.Text = "";
            label40.Text = "";
            label42.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label43.Text = "";
            label45.Text = "";
            label44.Text = "";
            label46.Text = "";
            label48.Text = "";
            label47.Text = "";
            label49.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label50.Text = "";
            label52.Text = "";
            label51.Text = "";
            label53.Text = "";
            label55.Text = "";
            label54.Text = "";
            label56.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label57.Text = "";
            label59.Text = "";
            label58.Text = "";
            label60.Text = "";
            label62.Text = "";
            label61.Text = "";
            label63.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label64.Text = "";
            label66.Text = "";
            label65.Text = "";
            label67.Text = "";
            label69.Text = "";
            label68.Text = "";
            label70.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label71.Text = "";
            label73.Text = "";
            label72.Text = "";
            label74.Text = "";
            label76.Text = "";
            label75.Text = "";
            label77.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label78.Text = "";
            label80.Text = "";
            label79.Text = "";
            label81.Text = "";
            label83.Text = "";
            label82.Text = "";
            label84.Text = "";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Viewing vi = new Viewing();
            vi.viewing = textBox12.Text;
            vi.Show();
            this.Hide();
        }
    }
}
