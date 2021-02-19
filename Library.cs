using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Var4
{
    class Library : Organization
    {
        static int working_hours;
        static int number_of_books;
        string[] employee = new string[7] { "Улыбкина", "Кардашьян", "Барбариков", "Бобров", "Крылов", "Чесноков", "Паров" };
        int[] stage = new int[7] {3,15,11,4,4,2,22};
        public Library() : base()
        { }
        public Library(string name, int number, int work, int number1) : base(name, number)
        {
            Working_Hours = work;
            Number_of_Books = number1;
        }
        public int Working_Hours
        {
            get{return working_hours;}
            set
            {
                bool o = Int32.TryParse(Convert.ToString(value), out working_hours);
            while ((!o) | (working_hours < 0) | (working_hours > 9))
                {
                    Console.WriteLine("Не может столько библиотека работать, введите время работы заново");
                    o = Int32.TryParse(Console.ReadLine(), out working_hours);
                }
            }
        }
        public int Number_of_Books
        {
            get { return number_of_books; }
            set
            {
                bool o = Int32.TryParse(Convert.ToString(value), out number_of_books);
                while ((!o) | (number_of_books < 0))
                {
                    Console.WriteLine("Такого количества книг не может быть, осуществите ввод заново");
                    o = Int32.TryParse(Console.ReadLine(), out number_of_books);
                }
            }
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Библиотека работает {working_hours} часов и имеет {number_of_books} книг"); ;
        }
        public void ShowStage()
        {
            for (int y = 0; y < stage.Length; y++)
            {
                Console.WriteLine($"{employee[y]} - работает {stage[y]} лет ");
            }
            Console.WriteLine($"Эти люди работают в {name} не менее шести лет");
            for (int t = 0; t < stage.Length; t++)
            {
                if (stage[t] >= 6)
                {
                    Console.WriteLine(employee[t]);
                }
            }
        }
        Random rnd = new Random();
        public override object Init()
        {
            Organization o = (Organization)base.Init();
            Library l = new Library(o.Name, o.Number_of_employees, rnd.Next(1, 10), rnd.Next(50, 1001));
            return l;
        }
    }
}
