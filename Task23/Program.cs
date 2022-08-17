Console.WriteLine("\n Задача 23");
Decision:
Console.WriteLine("Введите положительное число");
var numberString = Console.ReadLine();
var number = int.Parse(numberString!);
int count = 1;
if (number < 0)
{
    Console.WriteLine("Вы ввели отрицательное число. Программа ничего не вычислит");
    goto Decision;
}
if (number == 0)
{
    Console.WriteLine("Вы ввели ноль. Программа ничего не вычислит");
    goto Decision;
}
else
{
    Console.Write($"Кубы всх чисел от 1 до {+number}: ");
    while (count <= number)
    {
        Console.Write(Math.Pow(count, 3) + " ");
        count += 1;
    }
}