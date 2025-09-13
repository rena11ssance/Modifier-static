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
