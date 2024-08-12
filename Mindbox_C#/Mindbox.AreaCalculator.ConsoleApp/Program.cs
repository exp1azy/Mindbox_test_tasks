using Mindbox.AreaCalculator;
using Mindbox.AreaCalculator.Exceptions;

namespace AreaCalculator.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Посчитаем площадь? Выбери фигуру:\n\n1. Треугольник\n2. Круг\n3. Выход\n");

                string? choice;
                int shapeNumber = -1;

                do
                {
                    choice = Console.ReadLine();
                    Console.WriteLine();

                    if (!int.TryParse(choice, out shapeNumber) || shapeNumber < 1 || shapeNumber > 3)
                        Console.WriteLine("Неверный ввод! Попробуй еще раз.");
                }
                while (shapeNumber < 1 || shapeNumber > 3);

                if (shapeNumber == 1)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("Введите сторону №1: ");
                            var side1 = double.Parse(Console.ReadLine());

                            Console.Write("Введите сторону №2: ");
                            var side2 = double.Parse(Console.ReadLine());

                            Console.Write("Введите сторону №3: ");
                            var side3 = double.Parse(Console.ReadLine());

                            var triangle = new Triangle(side1, side2, side3);
                            var result = triangle.CalculateArea();
                            Console.WriteLine($"\nПлощадь треугольника равна {result} ({(int)result})\n");
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nВведены некорректные данные! Попробуйте снова.\n");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"\nОшибка: {ex.Message}\n");
                        }
                    }
                }
                else if (shapeNumber == 2)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write("Введите радиус: ");
                            var radius = double.Parse(Console.ReadLine());

                            var circle = new Circle(radius);
                            var result = circle.CalculateArea();
                            Console.WriteLine($"\nПлощадь круга равна {result} ({(int)result})\n");
                            break;
                        }
                        catch (LessOrEqualZeroException ex)
                        {
                            Console.WriteLine($"\nОшибка: {ex.Message}\n");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nВведены некорректные данные! Попробуйте снова.\n");
                        }
                    }
                }
                else if (shapeNumber == 3)
                {
                    Console.WriteLine("\nВыход из программы.");
                    break;
                }
            }
        }
    }
}
