using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Var4
{
    public class Insurance_Company : Organization
    {
        string[] employee = new string[7] {"Петров", "Николаев", "Борисов", "Никитин", "Вяткин", "Уткин", "Отвальный" };
        int[] stage = new int[7] {5,3,9,4,17,9,13};
        static int rating;
        static int year_of_foundation;
        public Insurance_Company() : base()
        { }
        public Insurance_Company(string l, int k, int year_of_found, int rating1) : base(l, k)
        {
            Year_of_Foundation = year_of_found;
            rating = rating1;
        }
        public int Rating
        {
            get { return rating; }
            set
            {
                bool o = Int32.TryParse(Convert.ToString(value), out rating);
                while ((!o) | (rating < 0) | (rating > 100))
                {
                    Console.WriteLine("Введите рейтинг от 0 до 100");
                    o = Int32.TryParse(Console.ReadLine(), out rating);
                }
            }
        }
        public int Year_of_Foundation
        {
            get { return year_of_foundation; }
            set
            {
                bool o = Int32.TryParse(Convert.ToString(value), out year_of_foundation);
                while ((!o) | (year_of_foundation < 0) | (year_of_foundation>2021))
                {
                    Console.WriteLine("Введите целое число");
                    o = Int32.TryParse(Console.ReadLine(), out year_of_foundation);
                }
            }
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Фирма имеет рейтинг {rating}");
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
            Insurance_Company i = new Insurance_Company(o.Name, o.Number_of_employees, rnd.Next(1800,2022), rnd.Next(0,101));
            return i;
        }
    }
}
