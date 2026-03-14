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
    public partial class Form3 : Form
    {
        Thread thread;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (GlobalData.Tax_name.Length > 24)
            {
                label1.Text = GlobalData.Tax_name + ": \r\nинформация";
            }
            else
            {
                label1.Text = GlobalData.Tax_name + ": информация";
            }

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            domainUpDown1.Visible = true;
            numericUpDown1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
            domainUpDown1.ReadOnly = false;

            switch (GlobalData.Tax_name)
            {
                case GlobalData.ind_tax1:

                    domainUpDown1.Items.Clear();
                    domainUpDown1.Items.Add("13%");
                    domainUpDown1.Items.Add("15%");
                    domainUpDown1.Items.Add("30%");
                    domainUpDown1.Items.Add("35%");

                    label2.Text = "НДФЛ — это налог для физлиц, его уплачивают обычные \r\nграждане со своих доходов: с зарплат и гонораров, при \r\nпродаже квартиры или машины, при выигрыше в лотерею.";
                    label3.Text = "Выберите процентную ставку:";
                    label4.Text = "Введите размер дохода:";
                    label5.Text = "";

                    break;
                case GlobalData.ind_tax4:

                    domainUpDown1.Items.Clear();
                    domainUpDown1.Items.Add("0,1%");
                    domainUpDown1.Items.Add("0,2%");
                    domainUpDown1.Items.Add("5%");

                    label2.Text = "Налог на имущество физических лиц — это прямой налог, \r\nплательщиками которого являются физические лица, в \r\nсобственности которых имеется имущество. \r\n";
                    label3.Text = "Выберите процентную ставку:";
                    label4.Text = "Введите стоимость имущества:";
                    label5.Text = "";

                    break;
                case GlobalData.ind_tax7:

                    domainUpDown1.Items.Clear();
                    domainUpDown1.Items.Add("15%");
                    domainUpDown1.Items.Add("30%");
                    domainUpDown1.Items.Add("48%");
                    domainUpDown1.Items.Add("54%");

                    label2.Text = "Таможенная пошлина — обязательный платёж, взимаемый \r\nтаможенными органами в связи с перемещением товаров \r\nчерез таможенную границу.\r\n";
                    label3.Text = "Выберите процентную ставку:";
                    label4.Text = "Введите стоимость товара:";
                    label5.Text = "";

                    break;
                case GlobalData.ind_tax8:

                    domainUpDown1.Items.Clear();
                    domainUpDown1.Items.Add("0,1%");
                    domainUpDown1.Items.Add("0,2%");
                    domainUpDown1.Items.Add("2%");

                    label2.Text = "Налог на недвижимое имущество — один из трёх \r\nимущественных налогов, который уплачивают \r\nвладельцы недвижимости раз в год.";
                    label3.Text = "Выберите процентную ставку:";
                    label4.Text = "Введите стоимость недвижимости:";
                    label5.Text = "";

                    break;
                case GlobalData.ind_tax9:

                    domainUpDown1.Items.Clear();
                    domainUpDown1.Items.Add("5%");
                    domainUpDown1.Items.Add("10%");
                    domainUpDown1.Items.Add("15%");
                    domainUpDown1.Items.Add("20%");
                    domainUpDown1.Items.Add("30%");
                    domainUpDown1.Items.Add("40%");

                    label2.Text = "Налог с наследства и дарений - налог, уплачиваемый \r\nфизическими и юридическими лицами при переходе \r\nимущества от одного лица к другому по праву \r\nнаследования либо в виде дарения.\r\n";
                    label3.Text = "Выберите процентную ставку:";
                    label4.Text = "Введите стоимость имущества:";
                    label5.Text = "";

                    break;
                case GlobalData.com_tax1:

                    domainUpDown1.Items.Clear();
                    domainUpDown1.Items.Add("2%");
                    domainUpDown1.Items.Add("2,2%");

                    label2.Text = "Налогом на имущество у российских организаций облагается \r\nдвижимое и недвижимое имущество, учитываемое на \r\nбалансе в качестве объектов основных средств.\r\n";
                    label3.Text = "Выберите процентную ставку:";
                    label4.Text = "Введите стоимость имущества:";
                    label5.Text = "";

                    break;
                case GlobalData.com_tax2:

                    domainUpDown1.Items.Clear();
                    domainUpDown1.Items.Add("3%");
                    domainUpDown1.Items.Add("13%");
                    domainUpDown1.Items.Add("15%");
                    domainUpDown1.Items.Add("20%");

                    label2.Text = "Налог на прибыль организаций — это прямой налог, его величина \r\nпрямо зависит от конечных финансовых результатов деятельности \r\nорганизации. Налог начисляется на прибыль, которую получила \r\nорганизация, то есть на разницу между доходами и расходами.\r\n";
                    label3.Text = "Выберите процентную ставку:";
                    label4.Text = "Введите размер прибыли:";
                    label5.Text = "";

                    break;
                case GlobalData.com_tax3:

                    domainUpDown1.Items.Clear();
                    domainUpDown1.Items.Add("10%");
                    domainUpDown1.Items.Add("20%");

                    label2.Text = "Налог на добавленную стоимость — это косвенный налог, \r\nисчисление которого производится продавцом при \r\nреализации продукции покупателю. ";
                    label3.Text = "Выберите процентную ставку:";
                    label4.Text = "Введите стоимость товара (услуги):";
                    label5.Text = "";

                    break;
                case GlobalData.com_tax4:

                    //special для com_tax4
                    button3.Visible = true;

                    button2.Visible = false;
                    label3.Visible = false;
                    domainUpDown1.Visible = false;
                    numericUpDown1.Value = 100;

                    domainUpDown1.Items.Clear();

                    label2.Text = "Налог на транспорт платят организации, на которых\r\nзарегистрированы транспортные средства \r\n(автомобили, автобусы, лодки так далее).\r\n";
                    //label3.Text = "Выберите процентную ставку:"; не нужно здесь
                    label4.Text = "Введите количество лошадиных сил:";
                    label5.Text = "";

                    break;
                case GlobalData.com_tax5:

                    //special для com_tax5
                    button3.Visible = true;

                    button2.Visible = false;

                    label4.Visible = true;
                    numericUpDown1.Visible = true;
                    numericUpDown1.Value = 100;

                    domainUpDown1.Items.Clear();
                    domainUpDown1.Items.Add("480 рублей");
                    domainUpDown1.Items.Add("570 рублей");
                    domainUpDown1.Items.Add("14,88 рублей");
                    domainUpDown1.ReadOnly = true;

                    label2.Text = "Ставка водного налога напрямую зависит от вида\r\nдеятельности и особенностей забора воды.\r\nНиже представлена налоговая ставка в рублях за 1 тыс. куб.\r\nм. воды, забранной из: поверхностных вод Кубани (480 руб.),\r\nподземных вод Кубани (570 руб.), вод Черного/Азовского \r\nморей (14,88 руб.)\";\r\n\r\n";
                    label3.Text = "Выберите налоговую ставку:";
                    label4.Text = "Введите количество воды (в тыс. куб. м.):";
                    label5.Text = "";

                    break;
                default:
                    MessageBox.Show("Возникла ошибка. Пожалуйста, перзагрузите программу и попробуйте снова.");
                    break;
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                label5.Text = "Размер выплаты: ";

                decimal salary = numericUpDown1.Value;
                decimal result = 0;
                string input_value = "";

                if ((domainUpDown1.Text != null)  && domainUpDown1.Text.EndsWith("%"))
                {
                    input_value = domainUpDown1.Text.ToString();
                    input_value = input_value.Substring(0, input_value.Length-1);
                }
                else
                {
                    label5.Text = "";
                    MessageBox.Show("Ошибка ввода. Попробуйте еще раз.");
                }

                result = salary * Convert.ToDecimal(input_value) / 100m;
                //два знака после запятой ??? не работает
                //Math.Round(result, 2);
                //String.Format("{0:.00}", result);
                result.ToString("0.00");

                label5.Text += "\r\n"+result;
            }
            catch /*(Exception ex)*/
            {
                label5.Text = "";
                MessageBox.Show("Ошибка ввода. Попробуйте еще раз.");
                //MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                label5.Text = "Размер выплаты: ";

                if (label1.Text.StartsWith(GlobalData.com_tax4))
                {
                    decimal result = 0;
                    int horse_pow = Convert.ToInt32(numericUpDown1.Value);
                    if (horse_pow > 0 && horse_pow < 101)
                    {
                        result = horse_pow * 2.5m;
                    }
                    if (horse_pow > 100 && horse_pow < 151)
                    {
                        result = horse_pow * 3.5m;
                    }
                    if (horse_pow > 150 && horse_pow < 201)
                    {
                        result = horse_pow * 5m;
                    }
                    if (horse_pow > 200 && horse_pow < 251)
                    {
                        result = horse_pow * 7.5m;
                    }
                    if (horse_pow > 250)
                    {
                        result = horse_pow * 15m;
                    }
                    if (horse_pow > 1000 | horse_pow < 0)
                    {
                        MessageBox.Show("Ошибка ввода.");
                    }

                    Convert.ToString(result);
                    label5.Text += "\r\n" + result;
                }
                else if (label1.Text.StartsWith(GlobalData.com_tax5))
                {
                    decimal result = 0;
                    decimal v_water = numericUpDown1.Value;
                    if (domainUpDown1.Text == null)
                    {
                        MessageBox.Show("Кажется, Вы не выбрали налоговую ставку.");
                    }
                    else
                    {
                        if (domainUpDown1.Text == "480 рублей")
                        {
                            result = v_water * 480m;
                        }
                        if (domainUpDown1.Text == "570 рублей")
                        {
                            result = v_water * 570m;
                        }
                        if (domainUpDown1.Text == "14,88 рублей")
                        {
                            result = v_water * 14.88m;
                        }
                    }

                    Convert.ToString(result);
                    label5.Text += "\r\n" + result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
