using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya
{
    static class GlobalData
    {
        public static string Account_selected;
        public static string Tax_name;

        //налоги физических лиц (программа без этого перечисления не работает)
        public const string ind_tax1 = " - налог на доходы физических лиц";
        public const string ind_tax2 = " - транспортный налог";
        public const string ind_tax3 = " - земельный налог";
        public const string ind_tax4 = " - налог на имущество физических лиц";
        public const string ind_tax5 = " - пенсионные социальные вычеты";
        public const string ind_tax6 = " - имущественные вычеты";
        public const string ind_tax7 = " - таможенные пошлины и сборы";
        public const string ind_tax8 = " - налог на недвижимость";
        public const string ind_tax9 = " - налог на наследование или дарение";

        //налоги юридических лиц
        public const string com_tax1 = " - налог на имущество организаций";
        public const string com_tax2 = " - налог на прибыль организаций";
        public const string com_tax3 = " - налог на добавленную стоимость";
        public const string com_tax4 = " - транспортный налог";
        public const string com_tax5 = " - водный налог";
    }

    public class Account
    { 
        public string Account_name;
        public string Password;
        
        public string Name_1 = "Иванова Лидия Петровна";
        public string Birth_date_1 = "19.02.1960";
        public string Inn_1 = "111111111111";
        public string Sex_1 = "Женский";
        public string Email_1 = "lidiya@mail.ru";
        public string Phone_number_1 = "8 (961) 111 11 11";
        public string Snils_1 = "111-111-111-11";
        public string Passport_info_1 = "1111 111111";

        public string Name_2 = "Смирнов Иван Алексеевич";
        public string Birth_date_2 = "09.10.1992";
        public string Inn_2 = "222222222222";
        public string Sex_2 = "Мужской";
        public string Email_2 = "ivan999@gmail.com";
        public string Phone_number_2 = "8 (961) 222 22 22";
        public string Snils_2 = "222-222-222-22";
        public string Passport_info_2 = "2222 222222";

        public string Name_3 = "Сидоров Прокофий Анатольевич";
        public string Birth_date_3 = "12.06.1981";
        public string Inn_3 = "333333333333";
        public string Sex_3 = "Мужской";
        public string Email_3 = "s.prokof.a@outlook.com";
        public string Phone_number_3 = "8 (961) 333 33 33";
        public string Snils_3 = "333-333-333-33";
        public string Passport_info_3 = "3333 333333";
    }
}
