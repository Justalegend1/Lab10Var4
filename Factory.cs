using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Var4
{
    public class Factory : Organization
    {
        string[] employee = new string[7] {"Кузнецов","Иванов", "Петров", "Ветров", "Подбельский", "Блок", "Понасенков"};
        int[] stage = new int[7] {3,4,5,6,5,9,2};
        int AgeObj;
        string city_of_object;
        public Factory() : base()
        { }
        public Factory(string name, int number, int AgeObj1, string city_of_obj) : base(name, number)
        {
            AgeObj = AgeObj1;
            City_of_Object = city_of_obj;
        }
        public int AgeObJ
        {
            get{ return AgeObj; }
            set
            {
                bool o = Int32.TryParse(Convert.ToString(value), out AgeObj);
                while (!o)
                {
                    Console.WriteLine("Введите целое число");
                    o = Int32.TryParse(Console.ReadLine(), out AgeObj);
                }
            }
        }
        public string City_of_Object
        {
            get { return city_of_object; }
            set 
            {
                city_of_object = Convert.ToString(value);
            }
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Возраст объекта: {AgeObj}, Город расположения объекта: {city_of_object}");
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
            string[] City_Object = new string[7] {"Пермь", "Москва", "Лондон", "Париж", "Венеция", "Прага", "Амстердам"};
            Factory f = new Factory(o.Name, o.Number_of_employees,rnd.Next(1,50),City_Object[rnd.Next(0,City_Object.Length-1)]);
            return f;
        }
    }
}
