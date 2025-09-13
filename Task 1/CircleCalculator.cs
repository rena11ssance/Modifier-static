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
