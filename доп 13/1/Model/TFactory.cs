using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Model
{
    class TFactory
    {
        string nameFactory;
        int daypay;//день зарплаты
        int worker;//кол-во рабочих
        int bonuspay;//премия
        TWorker[] workman;//рабочии                            
        public TFactory()
        {
            try 
            {
                //сохраняем путь доступа к файлу
                string path =Directory.GetCurrentDirectory()+ "\\List.txt";
                //создаем объект класса  StreamReader для считывания данных
                StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
                //объявляем переменные для временного хранения данных
                string surname, name, prof;
                int dayBirthday, monthBirthday, yearBirthday,pay;
                DateTime date;//объявляем объекта класса DateTime
                Random rnd = new Random();//создание объекта класса Random
                nameFactory = sr.ReadLine();//считывание с файла название предприятия
                daypay = rnd.Next(1,28);//задаем день зарплаты через объект rnd           
                worker =CHar();//задаем количество рабочих через метод
                bonuspay = rnd.Next(1000,3000);//задаем премию через объект rnd                       
                sr.ReadLine();//перемещаем указатель на строку вниз
                workman = new TWorker[worker];//создание массива объектов
                for (int i = 0; i < workman.Length; i++)//создаем рабочих
                {
                    //считываем данные с файла
                    surname = sr.ReadLine();               
                    name = sr.ReadLine();
                    prof = sr.ReadLine();
                    dayBirthday = int.Parse(sr.ReadLine());
                    monthBirthday = int.Parse(sr.ReadLine());
                    yearBirthday = int.Parse(sr.ReadLine());
                    date = new DateTime(yearBirthday, monthBirthday, dayBirthday);
                    pay = int.Parse(sr.ReadLine());                                  
                    workman[i] = new TWorker(surname, name, prof, date, pay);
                    sr.ReadLine();                    
                }
                sr.Close();//закрываем файл
            }
            catch (Exception e)//в случае исключения, выводим информацию об ошибке
            {
                Console.WriteLine(e.Message);
            }
        }                  
        public int MaxPayPred//свойство вычисляющие работника с макс зарплатой 
        {
            get
            {
                int number = 0, Max = workman[number].Pay;
                for (int i = 1; i < workman.Length; i++)
                {
                    if (Max < workman[i].Pay)
                    {
                        Max = workman[i].Pay;
                        number = i;
                    }
                }
                return number; 
            }
        }
        public string MaxPay() //метод возращающий работника с максимальной зарплатой 
        {            
            return $"Работник с максимальным окладом: \n{workman[MaxPayPred].ShowWorker}";           
        }

        public int MeanPayPred//свойство вычисляющие среднию зарплату на предприятии 
        {
            get
            {
                int sum = 0, num = 0;
                for (int i = 0; i < workman.Length; i++)
                {
                    sum += workman[i].Pay;
                    num++;
                }
                return sum / num;
            }
        }
        public string MeanPay()//метод вывода средней зарплаты на предприятии 
        {           
            return $"Средннее значение оклада на предприятии: {MeanPayPred:C0}\n";
        }
        public string FinalyPay() //метод для вывода и вычисления заработной платы работника
        {            
            double[] finaly = new double[worker];
            for (int i = 0; i < workman.Length; i++)
            {
                finaly[i] = workman[i].Pay + bonuspay;
                finaly[i] -=( 0.13 * finaly[i]);
            }
            for (int i = 1; i < finaly.Length; i++)
            {
                for (int j = 0; j < finaly.Length - i; j++)
                {
                    if (finaly[j] < finaly[j + 1])
                    {
                        (workman[j], workman[j + 1]) = (workman[j + 1], workman[j]);
                        (finaly[j], finaly[j + 1]) = (finaly[j + 1], finaly[j]);
                    }
                }
            }
            string s= "Заработная плата с учетом подоходного налога:\n";
            for (int i = 0; i < finaly.Length; i++)
            {
                s+=$"{workman[i].SurName} получит {finaly[i]:C2}\n";
            }           
            return s;
        }
               
         public string ShowSpiFactory() //Метод для отображения списка всех рабочих
         {
            string s ;
            s = $"{nameFactory}\n";
            s += $"День зарплаты: {daypay}\n";
            s += $"Кол-во работников: {worker}\n";
            s += $"Премия: {bonuspay:C0}\n";
            for (int i=0;i<+workman.Length;i++)
            s += $"{workman[i].ShowWorker}\n" ;
            return s;
         }
        public int CHar()//Определение количества работников
        {
            string path = Directory.GetCurrentDirectory() + "\\List.txt";
            string sr = File.ReadAllText(path, System.Text.Encoding.Default);
            int N;
            N = 0;
            foreach (char c in sr)
            {
                if (c == '-') { N++; };
            }
            N-=2;
            N /= 2;
            return N;
        }
    }    
}
