using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{

    internal class Lab1
    {
        public void task1()
        {
            int d = 0;
            double x = 27.3198;

            d = (int)(Math.Round(x, 1) * 10) % 10;

            Console.WriteLine("Result=" + d);
        }

        public void task2()
        {

            DateTime time = DateTime.Now;

            int hour = time.Hour;
            int minute = time.Minute;
            int second = time.Second;

            Console.WriteLine("Прошло с начала суток:\t" + (hour * 3600 + minute * 60 + second));
            Console.WriteLine("Осталось до конца суток:\t" + (86400 - hour * 3600 + minute * 60 + second));

        }

        public void task3()
        {
            Console.WriteLine("Введите часы (0-11): ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите минуты (0-59): ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите секунды (0-59): ");
            int s = int.Parse(Console.ReadLine());
            
            if (h<0 || h>11 ||m<0 ||m>59 || s<0 || s>59)
            {
                Console.WriteLine("Некорректный ввод времени.");
                return;
            }


            double hourAngle = (h % 12) * 30 + (m / 60.0) * 30 + (s / 3600.0) * 30;

            hourAngle = hourAngle % 360;

            Console.WriteLine($"Угол между положением часовой стрелки и началом суток: {hourAngle}°");


        }

        public void task4()
        {
            int a = 5;
            int b = 10;
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"После обмена: a = {a}, b = {b}");

        }

        public void task5()
        {
            Console.Write("Введите длину первого катета (a): ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите длину первого катета (b): ");
            double b = double.Parse(Console.ReadLine());

            double area = (a * b) / 2;

            double c = Math.Sqrt(a * a + b * b);

            double perimetr = a + b + c;
            Console.WriteLine($"Площадь треугольника: {area}");
            Console.WriteLine($"Периметр треугольника: {perimetr}");

        }

        public void task6()
        {
            Console.Write("Введите четырехзначное число: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 1000 || number > 9999)
            {
                Console.WriteLine("Ошибка: число должно быть четырехзначным.");
                return;
            }
            int product = 1;

            while (number > 0)
            {
                product *= number % 10;
                number /= 10;
            }

            Console.WriteLine($"Произведение цифр: {product}");
        }

        public void task7()
        {
            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 100 || number > 999)
            {
                Console.WriteLine("Ошибка: число должно быть трехзначным.");
                return;
            }
            string reversed = number.ToString()[2].ToString() + number.ToString()[1] + number.ToString()[0];

            Console.WriteLine($"Обратное число: {reversed}");
        }

        public void task8()
        {
            Console.Write("Введите действительное число x: ");
            double x = double.Parse(Console.ReadLine());

            double x2 = x * x;
            double x3 = x * x2;
            double x4 = x * x3;

            double result = 3 * x4 - 5 * x3 + 2 * x2 - x + 7;

            Console.WriteLine($"Результат: {result}");
        }


        private void PrintRow(string[] row)
        {
            foreach (var cell in row)
            {
                Console.Write($"| {cell,-22}");
            }
            Console.WriteLine("|");
        }
        
        private void PrintSeparator(int columns)
        {
            for (int i = 0; i < columns; i++)
            {
                Console.WriteLine("+----------------------");
            }
            Console.WriteLine("+");
        }
        enum Type
        {
            К = 0,
            О = 1
        }
        struct Commodity
        {
            public string title { get; set; }
            public Type type { get; set; }
            public double price { get; set; }
            public int quantity { get; set; }
        }
        public void task10v10()
        {
                int rows = 3;
                int columns = 4;

                Commodity[] commodities = new Commodity[rows];

                string[] titles = new string[] { "Папка", "Бумага А4(пачка)", "Калькулятор" };
                Type[] types = new Type[] { Type.К, Type.О };
                double[] prices = new double[] { 4.75, 45.90, 411.00 };
                int[] quantity = new int[] { 400, 100, 10 };

                for (int i = 0; i < rows; i++)
                {
                    commodities[i] = new Commodity();
                    commodities[i].title = titles[i];
                    commodities[i].type = types[i];
                    commodities[i].price = prices[i];
                    commodities[i].quantity = quantity[i];
                }
                string[] headers = { "Наименование товара", "Тип товара", "Цена за 1шт(грн)", "Кол-во" };
                Console.WriteLine($"| {"Прайс-лист",-98}|");
                PrintSeparator(columns);
                string[,] table = new string[rows,columns];
                for (int i = 0;i < rows;i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        switch(j)
                        {
                            case 0:
                            table[i, j] = commodities[i].title; break;
                            case 1:
                            table[i, j] = commodities[i].type.ToString(); break;
                            case 2:
                            table[i, j] = commodities[i].price.ToString(); break;
                            case 3:
                            table[i, j] = commodities[i].quantity.ToString(); break;
                        }
                    }
                }


        }
    }
       
   
}


 