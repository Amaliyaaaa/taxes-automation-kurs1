using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace kursovaya
{
    public partial class Form2 : Form
    {
        Thread thread;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Вы вошли в "+GlobalData.Account_selected;

            //просмотр и расчет налогов, сборов и платежей:
            label2.Visible = false;
            checkedListBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            checkedListBox1.Items.Clear();
            listBox1.Visible = false;
            label4.Visible = false;
            button3.Visible = false;

            //оплата налогов, сборов и платежей:
            linkLabel1.Visible = false;
        }

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void выходИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenForm1);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void OpenForm1(object obj)
        {
            Application.Run(new Form1());
        }

        public void просмотрИРасчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linkLabel1.Visible = false;

            checkedListBox1.Visible = false;
            listBox1.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            button3.Visible = false;

            label2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            //checkedListBox1.Items.Add("физического лица");
            //checkedListBox1.Items.Add("юридического лица");
        }

        /*private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 1)
            {
                if (checkedListBox1.CheckedItems.Contains("физического лица"))
                {
                    label3.Text = "физического лица";
                }
                else
                {
                    label3.Text = "юридического лица";
                }
            }
            else if (checkedListBox1.CheckedItems.Count == 2)
            {
                MessageBox.Show("Пожалуйста, выберите одно из списка.");
            }
        127 строка в дизайнере
        }*/

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label3.Text = "";
            if (checkedListBox1.CheckedItems.Count == 1)
            {
                if (checkedListBox1.CheckedItems.Contains("физического лица"))
                {
                    label3.Text = "";
                    label3.Text = "Список прямых налогов, сборов и платежей \r\nдля физического лица:";

                    listBox1.Items.Clear();
                    listBox1.Items.Add(GlobalData.ind_tax1);
                    //listBox1.Items.Add(GlobalData.ind_tax2);
                    //listBox1.Items.Add(GlobalData.ind_tax3);
                    listBox1.Items.Add(GlobalData.ind_tax4);
                    //listBox1.Items.Add(GlobalData.ind_tax5);
                    //listBox1.Items.Add(GlobalData.ind_tax6);
                    listBox1.Items.Add(GlobalData.ind_tax7);
                    listBox1.Items.Add(GlobalData.ind_tax8);
                    listBox1.Items.Add(GlobalData.ind_tax9);
                    listBox1.Visible = true;

                    label4.Text = "Нажмите дважды на налог (сбор, платеж) чтобы посмотреть схему расчета\r\n и воспользоваться ей. \r\n*Список может быть изменен и дополнен.";
                    label4.Visible = true;
                }
                else
                {
                    label3.Text = "";
                    label3.Text = "Список прямых налогов, сборов и платежей \r\nдля юридического лица:";

                    listBox1.Items.Clear();
                    listBox1.Items.Add(GlobalData.com_tax1);
                    listBox1.Items.Add(GlobalData.com_tax2);
                    listBox1.Items.Add(GlobalData.com_tax3);
                    listBox1.Items.Add(GlobalData.com_tax4);
                    listBox1.Items.Add(GlobalData.com_tax5);
                    listBox1.Visible = true;

                    label4.Text = "Нажмите дважды на налог (сбор, платеж) чтобы посмотреть схему расчета\r\n и воспользоваться ей. \r\n*Список может быть изменен и дополнен.";
                    label4.Visible = true;
                }
            }
            else
            {
                if (checkedListBox1.CheckedItems.Count == 2)
                {
                    listBox1.Visible = false;
                    label4.Visible = false;
                    label3.Text = "";
                    MessageBox.Show("Пожалуйста, выберите одно из списка.");
                }
                if (checkedListBox1.CheckedItems.Count == 0)
                {
                    listBox1.Visible = false;
                    label4.Visible = false;
                    label3.Text = "";
                }
            }
        }

        private void оплатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            checkedListBox1.Visible = false;
            checkedListBox1.Items.Clear();

            linkLabel1.Text = "Перейдите на сайт Федеральной налоговой \r\nслужбы для оплаты и просмотра \r\nдополнительной информации.\r\n(нажмите здесь, чтобы перейти)";
            linkLabel1.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //MessageBox.Show("Все норм");
            //System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://www.nalog.gov.ru/rn23/", UseShellExecute = true });
            Process.Start("https://www.nalog.gov.ru/rn23/");
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            GlobalData.Tax_name = listBox1.SelectedItem.ToString();
            
            this.Close();
            thread = new Thread(OpenForm3);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void OpenForm3(object obj)
        {
            Application.Run(new Form3());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label2.Visible = false;

            label3.Visible = true;
            label3.Text = "";
            label3.Text = "Список прямых налогов, сборов и платежей \r\nдля физического лица:";

            listBox1.Items.Clear();
            listBox1.Items.Add(GlobalData.ind_tax1);
            //listBox1.Items.Add(GlobalData.ind_tax2); не прописано, не работает
            //listBox1.Items.Add(GlobalData.ind_tax3); не прописано, не работает
            listBox1.Items.Add(GlobalData.ind_tax4);
            //listBox1.Items.Add(GlobalData.ind_tax5); не прописано, не работает
            //listBox1.Items.Add(GlobalData.ind_tax6); не прописано, не работает
            listBox1.Items.Add(GlobalData.ind_tax7);
            listBox1.Items.Add(GlobalData.ind_tax8);
            listBox1.Items.Add(GlobalData.ind_tax9);
            listBox1.Visible = true;

            label4.Text = "Нажмите дважды на налог (сбор, платеж) чтобы посмотреть схему расчета\r\n и воспользоваться ей. \r\n*Список может быть изменен и дополнен.";
            label4.Visible = true;

            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label2.Visible = false;

            label3.Visible = true;
            label3.Text = "";
            label3.Text = "Список прямых налогов, сборов и платежей \r\nдля юридического лица:";

            listBox1.Items.Clear();
            listBox1.Items.Add(GlobalData.com_tax1);
            listBox1.Items.Add(GlobalData.com_tax2);
            listBox1.Items.Add(GlobalData.com_tax3);
            listBox1.Items.Add(GlobalData.com_tax4);
            listBox1.Items.Add(GlobalData.com_tax5);
            listBox1.Visible = true;

            label4.Text = "Нажмите дважды на налог (сбор, платеж) чтобы посмотреть схему расчета\r\n и воспользоваться ей. \r\n*Список может быть изменен и дополнен.";
            label4.Visible = true;

            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button1.Visible = true;
            button2.Visible = true;

            checkedListBox1.Visible = false;
            checkedListBox1.Items.Clear();
            listBox1.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            button3.Visible = false;
        }

        private void информацияОбАккаунтеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenForm4);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void OpenForm4(object obj)
        {
            Application.Run(new Form4());
        }
    }
}
