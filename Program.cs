using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winter_holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Компьютерный практикум 13";
            Console.ForegroundColor = ConsoleColor.Green;


            //Обработать тестовое задание по информатике. На экран вывести вопрос и три варианта ответа,
            //ввести с экрана вариант ответа. Программа должна оценить ответ и в случае неправильного ответа написать правильный.
            string s = "Какие основные принципы ООП(объектно - ориентированного программирования)?";
            string p1 = "1. Наследование, полиморфизм, инкапсуляция";
            string p2 = "2. Сложность, эффективность, скорость";
            string p3 = "3. Интерфейс, абстракция, модульность";

            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine($"{s}\n");
            Console.WriteLine($"{p1}\n{p2}\n{p3}");
            Console.Write("Введите номер ответа: ");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
                Console.WriteLine("Верно!");
            else
                Console.WriteLine($"Неверно. \nПравильный ответ: {p1}");



            //Написать программу вычисления стоимости переговоров, если по субботам и воскресеньям предоставляется 20% скидка.
            //Ввести продолжительность разговора и день недели (цифра от 1 до 7).

            int price;
            int discount = 0;
            int price_min = 30; //за минуту
            Console.Write("\nВведите продолжительность разговора(в минутах): ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Введите день недели, в который был совершён звонок(цифра от 1 до 7): ");
            int day = int.Parse(Console.ReadLine());

            if (day == 6 || day == 7)
                discount = price_min * length * 20 / 100;
            price = price_min * length - discount;

            Console.WriteLine("Стоимость переговоров = " + price);


            //Написать программу для определения времени суток по данному текущему времени и вывести сообщение
            //(утро – с 6 до 12, день – с 12 до 18, вечер – с 18 до 24, ночь – с 0 до 6).

            //Console.Write("Введите текущее время: ");
            //int hour = int.Parse(Console.ReadLine());

            //if (hour >= 6 && hour < 12)
            //    Console.WriteLine("Утро");
            //if (hour >= 12 && hour < 18)
            //    Console.WriteLine("День");
            //if (hour >= 18 && hour < 24)
            //    Console.WriteLine("Вечер");
            //if (hour >= 0 && hour < 6)
            //    Console.WriteLine("Ночь");


            //По текущему времени 
            DateTime dateTime = DateTime.Now;
            int hour_now = dateTime.Hour;
            Console.Write("\nСейчас: ");
            if (hour_now >= 6 && hour_now < 12)
                Console.WriteLine("Утро");
            if (hour_now >= 12 && hour_now < 18)
                Console.WriteLine("День");
            if (hour_now >= 18 && hour_now < 24)
                Console.WriteLine("Вечер");
            if (hour_now >= 0 && hour_now < 6)
                Console.WriteLine("Ночь");



            //Рейтинг бакалавра заочного отделения при поступлении в магистратуру определяется средним баллом по диплому,
            //умноженным на коэффициент стажа работы по специальности, который равен: нет стажа – 1, меньше 2 лет – 13,
            //от 2 до 5 лет – 16. Составить программу расчета рейтинга при заданном среднем балле диплома (от 3 до 5)
            //и вывести сообщение о приеме в магистратуру при проходном балле 45.

            Console.Write("\nВведите свой средний балл: ");
            double score = double.Parse(Console.ReadLine());
            Console.Write("Введите свой стаж работы: ");
            int work = int.Parse(Console.ReadLine());
            int factor = 1;

            if (work == 1 || work == 2)
                factor = 13;
            else if (work <= 5)
                factor = 16;

            double result = score * factor;

            if (result >= 45) Console.WriteLine("Вы приняты в магистратуру");
            else Console.WriteLine("Вы не приняты в магистратуру");


            //Написать программу , которая по дате рождения (день d месяц n) определяет знак Зодиака:
            //с 22 марта по 21 апреля - Овен (4); с 22 апреля по 21 мая - Телец (5); с 22 мая по 21 июня - Близнецы (6);
            //с 22 июня по 21 июля - Рак (7); с 22 июля по 21 августа - Лев (8); с 22 августа по 21 сентября - Дева (9);
            //с 22 сентября по 21 октября - Весы (10); с 22 октября по 21 ноября - Скорпион (11); с 22 ноября по 21 декабря - Стрелец (12);
            //с 22 декабря по 21 января - Козерог (1); 22 января по 21 февраля - Водолей (2); с 22 февраля по 21 марта - Рыбы (3).

            Console.Write("\nВведите дату рождения(в таком формате \"20.07.2015\"): ");
            string date = Console.ReadLine();
            string[] dates = date.Split('.', '/', ' ', ',');    
            int d = int.Parse(dates[0]);
            int n = int.Parse(dates[1]);

            Console.Write("Ваш знак зодиака: ");
            if (d >= 22 && n == 1 || d <= 21 && n == 2)
                Console.WriteLine("Водолей");
            if (d >= 22 && n == 2 || d <= 21 && n == 3)
                Console.WriteLine("Рыбы");
            if (d >= 22 && n == 3 || d <= 21 && n == 4)
                Console.WriteLine("Овен");
            if (d >= 22 && n == 4 || d <= 21 && n == 5)
                Console.WriteLine("Телец");
            if (d >= 22 && n == 5 || d <= 21 && n == 6)
                Console.WriteLine("Близнецы");
            if (d >= 22 && n == 6 || d <= 21 && n == 7)
                Console.WriteLine("Рак");
            if (d >= 22 && n == 7 || d <= 21 && n == 8)
                Console.WriteLine("Лев");
            if (d >= 22 && n == 8 || d <= 21 && n == 9)
                Console.WriteLine("Дева");
            if (d >= 22 && n == 9 || d <= 21 && n == 10)
                Console.WriteLine("Весы");
            if (d >= 22 && n == 10 || d <= 21 && n == 11)
                Console.WriteLine("Скорпион");
            if (d >= 22 && n == 11 || d <= 21 && n == 12)
                Console.WriteLine("Стрелец");
            if (d >= 22 && n == 12 || d <= 21 && n == 1)
                Console.WriteLine("Козерог");



            //Написать программу, которая при вводе числа в диапазоне от 1 до 99 добавляет к нему слово "копейка"
            //в правильной форме. Например, 1 копейка, 5 копеек, 42 копейки.

            Console.Write("\nВведите число: ");
            int penny = int.Parse(Console.ReadLine());

            if (penny % 10 >= 5 || penny % 10 <= 0 || penny >= 5 && penny <= 20)
                Console.WriteLine($"{penny} копеек");
            else if (penny % 10 == 1)
                Console.WriteLine($"{penny} копейка");
            else if (penny % 10 >= 2 || penny % 10 <= 4)
                Console.WriteLine($"{penny} копейки");


            //Написать программу, которая после введенного с клавиатуры числа
            //в диапазоне от 1 до 99 дописывает слово «рубль» в правильном падеже.

            Console.Write("\nВведите число: ");
            int money = int.Parse(Console.ReadLine());

            if (money % 10 >= 5 || money % 10 <= 0 || money >= 5 && money <= 20)
                Console.WriteLine($"{money} рублей");
            else if (money % 10 == 1)
                Console.WriteLine($"{money} рубль");
            else if (money % 10 >= 2 || money % 10 <= 4)
                Console.WriteLine($"{money} рубля");














            Console.ReadKey();
        }
    }
}
