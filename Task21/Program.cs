Console.WriteLine("\n Задача 21");
Console.WriteLine("Введите координату X точки А");
var numberXAString = Console.ReadLine();
var numberXA = int.Parse(numberXAString!);

Console.WriteLine("Введите координату Y точки А");
var numberYAString = Console.ReadLine();
var numberYA = int.Parse(numberYAString!);

Console.WriteLine("Введите координату Z точки А");
var numberZAString = Console.ReadLine();
var numberZA = int.Parse(numberZAString!);

Console.WriteLine("Введите координату X точки B");
var numberXBString = Console.ReadLine();
var numberXB = int.Parse(numberXBString!);

Console.WriteLine("Введите координату Y точки B");
var numberYBString = Console.ReadLine();
var numberYB = int.Parse(numberYBString!);

Console.WriteLine("Введите координату Z точки B");
var numberZBString = Console.ReadLine();
var numberZB = int.Parse(numberZBString!);

double result = Math.Sqrt((Math.Pow(numberXB - numberXA, 2)) + (Math.Pow(numberYB - numberYA, 2)) + (Math.Pow(numberZB - numberZA, 2)));
Console.WriteLine($"Расстояние между точками А и В равно: {Math.Round(result, 2)} .");