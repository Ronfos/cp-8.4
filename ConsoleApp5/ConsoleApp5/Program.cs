using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        //Задача 1. Составить программу, в результате которой величина а меняется значением с величиной b, а величина b — с величиной c.
        //Определить метод, осуществляющий обмен значениями двух переменных величин.

        //static void Change()
        //{
        //    double a = 1, b = 2, c = 3;
        //    Console.Write($"Переменна a = {a} приняла значение");
        //    a = b;
        //    Console.Write($" a = {a}");
        //    Console.Write($"\nПеременна b = {b} приняла значение");
        //    b = c;
        //    Console.WriteLine($" b = {b}");
        //}
        //static void Main(string[] args)
        //{
        //    Change();
        //    Console.ReadKey();
        //}

        //Задача 2. Ввести три целых числа и вывести их в порядке возрастания значений.

        //static void Sort()
        //{
        //    int[] numbers = new int[3];
        //    Console.Write("Введите первое число: ");
        //    numbers[0] = int.Parse(Console.ReadLine());
        //    Console.Write("Введите второе число: ");
        //    numbers[1] = int.Parse(Console.ReadLine());
        //    Console.Write("Введите третье число: ");
        //    numbers[2] = int.Parse(Console.ReadLine());
        //    Array.Sort(numbers);
        //    foreach (int num in numbers)
        //    { Console.Write(num); }

        //}
        //static void Main(string[] args)
        //{
        //    Sort();
        //    Console.ReadKey();
        //}

        //Задача 3. Создать метод, который будет вычислять площадь круга и длину окружности.
        //Вызывающий программный код должен передавать в качестве аргумента методу значение радиуса и печатать значение радиуса, площади круга и длины окружности.

        //static void Circle(double r=2)
        //{
        //    double s = Math.PI * Math.Pow(r,2);
        //    double p = 2 * r * Math.PI;
        //    Console.Write($"Площадь круга с радиусом {r} = {s:f2}\nДлина окружности круга с радиусом {r} = {p:f2}");
        //}
        //static void Main(string[] args)
        //{
        //    Console.Write($"Введите радиус круга = ");
        //    double rad = double.Parse(Console.ReadLine());
        //    Circle(rad);
        //    Console.ReadKey();
        //}

        //Задача 4. Даны два предложения.Найти общее количество букв "н" в них. (Определить функцию для расчета количества букв н в предложении.)

        static void Count()
        {
            Console.Write("Введите предложение: ");
            string sentence1 = Console.ReadLine();
            Console.Write("Введите второе предложение: ");
            string sentence2 = Console.ReadLine();
            string sentences = sentence1 + sentence2;
            int count = 0;
            foreach (char a in sentences)
            {
                if (a == 'н')
                { count++; }
                if (a == 'Н')
                { count++; }
            }
            Console.WriteLine($"Количество символов н в слове = {count}");
        }
        static void Main(string[] args)
        {
            Count();
            Console.ReadKey();
        }
    }
}
