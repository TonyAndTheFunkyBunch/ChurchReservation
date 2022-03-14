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
    public partial class FuneralForm : Form
    {
        MySqlConnection con  = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
        MySqlCommand com;
        MySqlDataReader data;


        public string funeralform;



        public FuneralForm()
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
            com = new MySqlCommand("Select * from tbl_registrationfuneral WHERE RegistrationID = '" + reciever.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                requirements.Text = data.GetValue(3).ToString();
                fillupe.Text = data.GetValue(4).ToString();
                paymentx.Text = data.GetValue(5).ToString();
                Completee.Text = data.GetValue(8).ToString();
                Completee2.Text = data.GetValue(9).ToString();
            }
        }

        public void connection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            
        }





      
        private void button1_Click(object sender, EventArgs e)
        {
            REQUIREMENTS rq = new REQUIREMENTS();
            this.Hide();
            rq.Show();
        }

        private void paybtt_Click(object sender, EventArgs e)
        {
            PaymentFuneral payfun = new PaymentFuneral();
            this.Hide();
            payfun.Show();
        }

        private void FuneralForm_Load(object sender, EventArgs e)
        {
            connection();
            textBox6.Text = funeralform;

            reciever.Text = res;
            textBox2.Text = Passvalue;

            Payment.Text = recie;

            textBox4.Text = fillupp;


            select();




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
                label8.Text = "Incomplete";
            }


        


        }
        

        private void reqbtt_Click(object sender, EventArgs e)
        {
            FuneralReq funrq = new FuneralReq();
            this.Hide();
            funrq.Show();
        }

        private void fllbtt_Click(object sender, EventArgs e)
        {
            FillupFormFuneral fll = new FillupFormFuneral();
            this.Hide();
            fll.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Main mn = new Main();
            this.Hide();
            mn.Show();
        }

        private void paylbl_Click(object sender, EventArgs e)
        {

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
                label9.Text = "Complete";

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
                com = new MySqlCommand("update tbl_registrationfuneral set Requirements = '" + cc + "'where RegistrationID = '" + reciever.Text + "'", con);
                com.ExecuteNonQuery();
                select();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Equals("Complete"))
            {
                fllbtt.Enabled = false;
                //label1.Text = "Complete";
                string cc = "Complete";
                connection();
                com = new MySqlCommand("update tbl_registrationfuneral set Fillup = '" + cc + "'where RegistrationID = '" + reciever.Text + "'", con);
                com.ExecuteNonQuery();
                select();
            }
        }

        private void Payment_TextChanged(object sender, EventArgs e)
        {

            if (Payment.Text.Equals("Complete"))
            {
                paybtt.Enabled = false;
                label8.Text = "Complete";
                string cc = "Complete";
                connection();
                com = new MySqlCommand("update tbl_registrationfuneral set Payment = '" + cc + "'where RegistrationID = '" + reciever.Text + "'", con);
                com.ExecuteNonQuery();
                select();
            }
             if (Payment.Text.Equals("Incomplete"))
            {
                paybtt.Enabled = false;
                label8.Text = "Incomplete";
                string cc = "Incomplete";
                connection();
                com = new MySqlCommand("update tbl_registrationfuneral set Payment = '" + cc + "'where RegistrationID = '" + reciever.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                select();
            }

        }

        private void reqbtt_Click_1(object sender, EventArgs e)
        {
            FuneralReq fq = new FuneralReq();
   
            fq.resi = reciever.Text;
            fq.funeralreq = textBox6.Text;
            fq.Show();
            this.Hide();
        }

        private void fllbtt_Click_1(object sender, EventArgs e)
        {
            FillupFormFuneral fff = new FillupFormFuneral();
            fff.fill = reciever.Text;
            fff.fillupformfuneral = textBox6.Text;
            fff.Show();
            this.Hide();
        }

        private void paybtt_Click_1(object sender, EventArgs e)
        {
            PaymentFuneral pf = new PaymentFuneral();
            pf.resic = reciever.Text;
            pf.paymentfuneral = textBox6.Text;
            pf.Show();
            this.Hide();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            RegistrationListFuneral ff = new RegistrationListFuneral();
            ff.registrationlistfuneral = textBox6.Text;
            ff.Show();
            this.Hide();
        }
    }
}
