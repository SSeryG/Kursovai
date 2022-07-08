using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Model
{
    class TWorker
    {
        string surname;//фамилия
        string name;//имя
        string prof;//должность        
        DateTime date;//дата рождения работника
        int pay;//оклад        
        public TWorker(string surname, string name, string prof, DateTime date, int pay)//конструктор для работника
        {                     
            this.surname = surname;
            this.name = name;
            this.prof = prof;
            this.date = date;
            this.pay = pay;        
        }      
        public string Prof //проверка написания должности
        {
            set             
            {
                prof = value;
                prof = VERifi(prof);
            }
        }
        public string  Surname//проверка написания фамилии
        {
            set
            {         
                surname = value;
                surname = VERifi(surname);                
            }
        }
        public string Name//проверка написания фамилии
        {
            set
            {
                name = value;
                name = VERifi(name);
            }
        }
        public string VERifi(string inf)//метод для проверки корректности данных текстового файла
        {             
             inf= inf.ToUpper();
             char[] A = {'1','2','3','4','5','6','7'
                  ,'8','9','0','+','=','>','<',','
                  ,'|','&','*','/','\\','(',')',
                  '?',':',';','^','#','№','@','!',
                  '~','$','%'};
             for (int i = 0; i < A.Length; i++)
             {                
                int Nomer = inf.IndexOf(A[i]);
                 while (Nomer > -1)
                 {
                    inf = "Некорректные данные ";
                      Nomer = -1;
                 }
             }
             return inf;
        }       
        public int Age//свойство возвращающее возраст
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - date.Year;
                if (today.Month < date.Month) age--;
                return age;
            }
        }
        public int Pay//возвращает оклад
        { get {return pay; } }
        public string ShowWorker //возвращает информацию о работнике
        {
            get
            {
                string txt = $"\nДолжность: {prof}\n";
                txt+=$"Фамилия имя: {SurName}\n";
                txt+=$"День рождения: {date.Day}.{date.Month}.{date.Year} г.\n";
                txt+=$"Оклад работника: {Pay:C0}\n";
                txt+=$"Возраст: {Age}";
                return txt;
            }
        }
        public string SurName//обЪединения имени и фамилии
        {
            get{ return surname + " " + name; }
        }        
    }
}
