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
    public partial class Form1 : Form
    {
        Thread thread;
        public Form1()
        {
            InitializeComponent();
        }

        Account Account1 = new Account();
        Account Account2 = new Account();
        Account Account3 = new Account();

        public void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            domainUpDown1.Items.Add("Аккаунт 1");
            domainUpDown1.Items.Add("Аккаунт 2");
            domainUpDown1.Items.Add("Аккаунт 3");

            Account1.Account_name = "Аккаунт 1";
            Account2.Account_name = "Аккаунт 2";
            Account3.Account_name = "Аккаунт 3";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Account1.Password = "123";
            Account2.Password = "234";
            Account3.Password = "345";

            if ((domainUpDown1.Text == Account1.Account_name && textBox1.Text == Account1.Password) | (domainUpDown1.Text == Account2.Account_name && textBox1.Text == Account2.Password) | (domainUpDown1.Text == Account3.Account_name && textBox1.Text == Account3.Password))
            {
                if (domainUpDown1.Text == "Аккаунт 1")
                    GlobalData.Account_selected = "Аккаунт 1";
                if (domainUpDown1.Text == "Аккаунт 2")
                    GlobalData.Account_selected = "Аккаунт 2";
                if (domainUpDown1.Text == "Аккаунт 3")
                    GlobalData.Account_selected = "Аккаунт 3";

                this.Close();
                thread = new Thread(OpenForm2);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Выбран неверный аккаунт или введен неверный пароль.");
            }
        }

        public void OpenForm2(object obj)
        {
            Application.Run(new Form2());
        }
    }
}
