using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class ClassTrain
    

namespace ConsoleAppOOPClasses //пространство имен проекта
    {
        internal class ClsStudent
        {
            //поля
            private string punktNasnachenia;
            private DateTime Dstart;
            private string nTrain;
            private byte kurs;
            private string group;
            private string phone;
            private double scholarship;
            // свойства для доступа к полям
            public string PunktNasnachenia
            {
                get { return punktNasnachenia; }//возвращает значение поля
                set { punktNasnachenia = value; } //устанавливает значение поля
            }
            public byte Kurs
            {
                get { return kurs; }
                set { kurs = value; }
            }
            public string Group
            {
                get { return group; }
                set { group = value; }
            }
            public string Phone
            {
                get { return phone; }
                set { phone = value; }
            }
            public double Scholarship
            {
                get { return scholarship; }
                set { scholarship = value; }
            }
            public DateTime DStart
            {
                get { return Dstart; }
                set { Dstart = value; }
            }
            public string ntrain
        {
            get { return nTrain; } //возвращает значение поля
        set { nTrain = value; } //устанавливает значение поля
}
//методы 
//конструктор без параметров задает значения полей по умолчанию
public ClsStudent()
{
    kurs = 2;
    group = "ИСП.21.2А";
    phone = "+79991234567";
    punktNasnachenia = "Куровское";
    nTrain = "22";
    Dstart = new DateTime(2023, 02, 01);
    scholarship = 0.00;
}
//конструктор с параметрами
public ClsStudent(string f, DateTime d, string ad,
    string ph, byte k,
    string g, double s)
{
    punktNasnachenia = f;
    Dstart = d;
    nTrain = ad;
    phone = ph;

}
//метод вывода на экран
public string PrintToScreen()
{
   string line = $"Пункт назначения {punktNasnachenia} дата отпрвления {Dstart}"+"\n";
                    line +=$"Получает стипендию в размкере{StreamWriter}

    Console.WriteLine($"Номер поезда {nTrain}");

}
public void SaveToFile(string filename)
{
    StreamWriter streamWriter = new StreamWriter(filename, true, Encoding.Default);
    streamWriter.WriteLine("Данные о работе поезда");
    streamWriter.WriteLine($"Пункт назначения: {punktNasnachenia}");
    streamWriter.WriteLine($"Номер поезда: {nTrain}");

    streamWriter.Close();

}
//метод ввода с клавиатуры
public void GetFromKeyboard()
{
    Console.WriteLine("Укажите пункт назначения");
    punktNasnachenia = Console.ReadLine();
    Console.WriteLine("Укажите номер поезда");
    nTrain = Console.ReadLine();

    Console.WriteLine("Укажите дату отправления");
    Console.WriteLine("Год?"); int year = int.Parse(Console.ReadLine());
    Console.WriteLine("Месяц?"); int month = int.Parse(Console.ReadLine());
    Console.WriteLine("День?"); int day = int.Parse(Console.ReadLine());
    Console.WriteLine("час"); double hour = double.Parse(Console.ReadLine());
    Dstart = new DateTime(year, month, day);


}
    }
}

    }
}
