# Модификатор static

Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:

— метод, определяющий длину окружности по заданному радиусу;

— метод, определяющий площадь круга по заданному радиусу;

— метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.

> CircleCalculator.cs

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    static class CircleCalculator
    {
        private const double piValue = Math.PI;

        static public double GetCircumference(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным.");
            }

            else
            {
                return 2 * piValue * radius;
            }
        }

        static public double GetAreaCircle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным");
            }

            else
            {
                return piValue * Math.Pow(radius, 2);
            }
        }

        public static string IsPointInCircle(double x, double y, double x0, double y0, double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным");
            }

            else
            {
                double distanceSquared = Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2);
                double radiusSquared = Math.Pow(radius, 2);

                if (distanceSquared < radiusSquared)
                {
                    return "Точка находится внутри окружности";
                }

                else if (distanceSquared == radiusSquared)
                {
                    return "Точка находится на окружности";
                }

                else
                {
                    return "Точка находится вне окружности";
                }
            }
        }

    }
}

```
___

> Program.cs

```
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите значение x: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите значение y: ");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите значение x0: ");
                double x0 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите значение y: ");
                double y0 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите значение радиуса: ");
                double radius = Convert.ToDouble(Console.ReadLine());


                double circumference = CircleCalculator.GetCircumference(radius);
                double areaCircle = CircleCalculator.GetAreaCircle(radius);
                string pointInCircle = CircleCalculator.IsPointInCircle(x, y, x0, y0, radius);

                Console.WriteLine($"Длина окружности равняется: {circumference:F2} \n Площадь круга равняется: {areaCircle:F2} \n {pointInCircle:F2}");
            }

            catch (ArgumentException)
            {
                Console.WriteLine("Радиус не может быть отрицательным.");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}

```
___
