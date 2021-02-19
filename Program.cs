using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Var4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания");
            int numb;
            bool k = Int32.TryParse(Console.ReadLine(), out numb);
            while ((!k) | (numb < 1) | (numb > 3))
            {
                Console.WriteLine("Введите номер задания от 1 до 3");
                k = Int32.TryParse(Console.ReadLine(), out numb);
            }
            switch (numb)
          {
                case 1:
                    int tip;
                    Console.WriteLine("Как будем создавать объект класса?\n1 - ручками\n2 - с помощью ДСЧ");
                    bool p = Int32.TryParse(Console.ReadLine(), out tip);
                    while ((!p) | (tip < 1) | (tip > 2))
                    {
                        Console.WriteLine("Введите 1 или 2");
                        p = Int32.TryParse(Console.ReadLine(), out tip);
                    }
                    Organization m = new Organization();
                    Factory f = new Factory();
                    Insurance_Company i = new Insurance_Company();
                    Library l = new Library();
                    Shipbuilding_company s = new Shipbuilding_company("Кораблики", 317, 1859997.0, 900);
                    if (tip == 1)
                    {
                        m.Name = "Транснефть";
                        m.Number_of_employees = 15;
                        m.Show();
                        f.City_of_Object = "Москва";
                        f.AgeObJ = 20;
                        f.Name = "Горные руды";
                        f.Number_of_employees = 700;
                        f.Show();
                        i.Year_of_Foundation = 2000;
                        Console.WriteLine("Введите рейтинг компании (от 0 до 100)");
                        i.Rating = 75;
                        i.Name = "Транссибирь";
                        i.Number_of_employees = 200;
                        i.Show();
                        l.Name = "Берлога работяг";
                        l.Number_of_employees = 50;
                        l.Number_of_Books = 500;
                        l.Working_Hours = 8;
                        l.Show();
                        s.Show();
                        Console.ReadKey();
                    }
                    else
                    {
                        m = (Organization)m.Init();
                        f = (Factory)f.Init();
                        i = (Insurance_Company)i.Init();
                        l = (Library)l.Init();
                        s = (Shipbuilding_company)s.Init();
                        m.Show();
                        f.Show();
                        i.Show();
                        l.Show();
                        s.Show();
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    Console.WriteLine("Давайте выведем фамилии сотрудников, которые работают в фирме не менее 6 лет");
                    Factory v = new Factory();
                    Insurance_Company e = new Insurance_Company();
                    Library w = new Library();
                    Shipbuilding_company y = new Shipbuilding_company();
                    v.Name = "Горные руды";
                    e.Name = "Транссибирь";
                    w.Name = "Берлога работяг";
                    y.Name = "Кораблики";
                    v.ShowStage();
                    e.ShowStage();
                    w.ShowStage();
                    y.ShowStage();
                    Console.ReadKey();
                    break;
                case 3:

                    break;
            }
        }
    }
}
