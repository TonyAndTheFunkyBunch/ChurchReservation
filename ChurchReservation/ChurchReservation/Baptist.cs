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
    public partial class Baptist : Form
    {
        MySqlConnection con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
        MySqlCommand com;
        MySqlDataReader data;


        public string baptist;



        
        public Baptist()
        {
            InitializeComponent();
        }


        private string mnee;

        public string Passvalue
        {
            get { return mnee; }
            set { mnee = value; }
        }


        public string res;

        public string recie;

        public string fillupp;

        public void select()
        {
            connection();
            com = new MySqlCommand("Select * from tbl_registrationbaptist WHERE RegistrationID = '" + reciever.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {

                requirements.Text = data.GetValue(3).ToString();
                fillupe.Text = data.GetValue(4).ToString();
                paymentx.Text = data.GetValue(5).ToString();
                Completee.Text = data.GetValue(7).ToString();
                Completee2.Text = data.GetValue(8).ToString();

            }
        }     

        public void connection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
        }


        private void nextbtn_Click(object sender, EventArgs e)
        {
            Main bap = new Main();
            this.Hide();
            bap.Show();
        }

      

      
        


        

        private void fllbtt_Click_1(object sender, EventArgs e)
        {
            Fill_upBapt fl = new Fill_upBapt();
            fl.fill = reciever.Text;
            fl.fillupbapt = textBox6.Text;
            this.Hide();
            fl.Show();
        }

        private void paybtt_Click_1(object sender, EventArgs e)
        {
            PaymentBapt paymm = new PaymentBapt();
            paymm.resic = reciever.Text;
            paymm.paymentbapt = textBox6.Text;
            this.Hide();
            paymm.Show();
        }

        private void reqbtt_Click_1(object sender, EventArgs e)
        {
            ReqBaptist rq = new ReqBaptist();

            rq.resi = reciever.Text;
            rq.reqbaptistt = textBox6.Text;
            rq.Show();
            this.Hide();
        }

        private void Baptist_Load(object sender, EventArgs e)
        {
            textBox6.Text = baptist;
            connection();
            textBox4.Text = fillupp;
            textBox5.Text = textBox4.Text;
            reciever.Text = res;
            Payment.Text = recie;
            textBox2.Text = Passvalue;
            select();

            if (textBox4.Text.Equals("Complete"))
            {
                fllbtt.Enabled = false;
                label1.Text = "Complete";
                string cc = "Complete";
                connection();
                com = new MySqlCommand("update tbl_registrationbaptist set Fillup = '" + cc + "'where RegistrationID = '" + reciever.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                select();
            }




 











            if (paymentx.Text.Equals("x"))
            {
                label8.Text = "Incomplete";
            }

            if (requirements.Text.Equals("x"))
            {
                label7.Text = "Incomplete";
            }
            if (fillupe.Text.Equals("x"))
            {
                label1.Text = "Incomplete";
            }





        }

        private void paymentx_TextChanged(object sender, EventArgs e)
        {
            if (paymentx.Text.Equals("Complete"))
            {
                label8.Text = "Complete";
                paybtt.Enabled = false;
            }
            if (paymentx.Text.Equals("Incomplete"))
            {
                label8.Text = "Incomplete";
                paybtt.Enabled = false;
            }
        }

        private void requirements_TextChanged(object sender, EventArgs e)
        {
            if (requirements.Text.Equals("Complete"))
            {
                label7.Text = "Complete";
                reqbtt.Enabled = false;
            }
        }

        private void fillupe_TextChanged(object sender, EventArgs e)
        {
            if (fillupe.Text.Equals("Complete"))
            {
                fllbtt.Enabled = false;
                label1.Text = "Complete";

            }
        }

        private void Completee_TextChanged(object sender, EventArgs e)
        {
            if (Completee.Text.Equals("Complete"))
            {
                reqbtt.Enabled = false;
                label7.Text = "Complete";
                string cc = "Complete";
                connection();
                com = new MySqlCommand("update tbl_registrationbaptist set Requirements = '" + cc + "'where RegistrationID = '" + reciever.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                select();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void Payment_TextChanged(object sender, EventArgs e)
        {
            if (Payment.Text.Equals("Complete"))
            {
                paybtt.Enabled = false;
                label1.Text = "Complete";
                string cc = "Complete";
                connection();
                com = new MySqlCommand("update tbl_registrationbaptist set Payment = '" + cc + "'where RegistrationID = '" + reciever.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                select();
            }
            if (Payment.Text.Equals("Incomplete"))
            {
                paybtt.Enabled = false;
                label1.Text = "Incomplete";
                string cc = "Incomplete";
                connection();
                com = new MySqlCommand("update tbl_registrationbaptist set Payment = '" + cc + "'where RegistrationID = '" + reciever.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                select();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationListBaptist fs = new RegistrationListBaptist();
            fs.registrationlistbaptist = textBox6.Text;
            this.Hide();
            fs.Show();
        }



 



    }
}
