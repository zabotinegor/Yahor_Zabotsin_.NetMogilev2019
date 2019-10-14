using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Figure:\n" +
                              "1. Square.\n" +
                              "2. Circle.\n" +
                              "3. Triangle.\n");

            if (int.TryParse(Console.ReadLine(), out var choice) && ((0 < choice) && (choice < 4)))
            {
                Console.WriteLine("\nEnter parameter: ");

                if (double.TryParse(Console.ReadLine(), out var parameter))
                {
                    Console.WriteLine("\nСalculate:\n" +
                                      "1. Perimeter.\n" +
                                      "2. Area.\n");

                    if (int.TryParse(Console.ReadLine(), out var calculation) && ((calculation == 1) || (calculation == 2)))
                    {
                        var square = new Square(parameter);
                        var circle = new Circle(parameter);
                        var triangle = new Triangle(parameter);

                        Console.WriteLine("Calculations:\n");
                        Console.WriteLine($"Parameter = {parameter}\n");

                        if (calculation == 1)
                        {
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine($"Perimeter of squere = {square.Perimeter}");
                                    Console.WriteLine($"Parameters of other figures:\n" +
                                                      $"Circle - {circle.GetParameterByPerimeter(square.Perimeter)}\n" +
                                                      $"Triangle - {triangle.GetParameterByPerimeter(square.Perimeter)}\n");
                                    break;
                                case 2:
                                    Console.WriteLine($"Perimeter of circle = {circle.Perimeter}");
                                    Console.WriteLine($"Parameters of other figures:\n" +
                                                      $"Square - {square.GetParameterByPerimeter(circle.Perimeter)}\n" +
                                                      $"Triangle - {triangle.GetParameterByPerimeter(circle.Perimeter)}\n");
                                    break;
                                case 3:
                                    Console.WriteLine($"Perimeter of triangle = {triangle.Perimeter}");
                                    Console.WriteLine($"Parameters of other figures:\n" +
                                                      $"Square - {square.GetParameterByPerimeter(triangle.Perimeter)}\n" +
                                                      $"Circle - {circle.GetParameterByPerimeter(triangle.Perimeter)}\n");
                                    break;
                            }
                        }
                        else
                        {
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine($"Area of squere = {square.Area}");
                                    Console.WriteLine($"Parameters of other figures:\n" +
                                                      $"Circle - {circle.GetParameterByArea(square.Area)}\n" +
                                                      $"Triangle - {triangle.GetParameterByArea(square.Area)}\n");
                                    break;
                                case 2:
                                    Console.WriteLine($"Area of circle = {circle.Area}");
                                    Console.WriteLine($"Parameters of other figures:\n" +
                                                      $"Square - {square.GetParameterByArea(circle.Area)}\n" +
                                                      $"Triangle - {triangle.GetParameterByArea(circle.Area)}\n");
                                    break;
                                case 3:
                                    Console.WriteLine($"Area of triangle = {triangle.Area}");
                                    Console.WriteLine($"Parameters of other figures:\n" +
                                                      $"Square - {square.GetParameterByArea(triangle.Area)}\n" +
                                                      $"Circle - {circle.GetParameterByArea(triangle.Area)}\n");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid parameter!");
                }
            }
            else
            {
                Console.WriteLine("Invalid item!");
            }

            Console.ReadKey();
        }
    }
}
