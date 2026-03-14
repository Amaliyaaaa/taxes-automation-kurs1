using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya
{
    public partial class Form4 : Form
    {
        Thread thread;
        public Form4()
        {
            InitializeComponent();
        }

        Account Account_gen = new Account();
        private void Form4_Load(object sender, EventArgs e)
        {
            if (GlobalData.Account_selected == "Аккаунт 1")
            {
                label2.Text += Account_gen.Name_1;
                label3.Text += Account_gen.Birth_date_1;
                label4.Text += Account_gen.Sex_1;
                label5.Text += Account_gen.Snils_1;
                label6.Text += Account_gen.Inn_1;
                label7.Text += Account_gen.Passport_info_1;
                label8.Text += Account_gen.Phone_number_1;
                label9.Text += Account_gen.Email_1;
            }
            if (GlobalData.Account_selected == "Аккаунт 2")
            {
                label2.Text += Account_gen.Name_2;
                label3.Text += Account_gen.Birth_date_2;
                label4.Text += Account_gen.Sex_2;
                label5.Text += Account_gen.Snils_2;
                label6.Text += Account_gen.Inn_2;
                label7.Text += Account_gen.Passport_info_2;
                label8.Text += Account_gen.Phone_number_2;
                label9.Text += Account_gen.Email_2;
            }
            if (GlobalData.Account_selected == "Аккаунт 3")
            {
                label2.Text += Account_gen.Name_3;
                label3.Text += Account_gen.Birth_date_3;
                label4.Text += Account_gen.Sex_3;
                label5.Text += Account_gen.Snils_3;
                label6.Text += Account_gen.Inn_3;
                label7.Text += Account_gen.Passport_info_3;
                label8.Text += Account_gen.Phone_number_3;
                label9.Text += Account_gen.Email_3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenForm2);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void OpenForm2(object obj)
        {
            Application.Run(new Form2());
        }

        
    }
}
