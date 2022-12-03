// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число А:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = int.Parse(Console.ReadLine());

int NumberToPow(int num1, int num2)
{
    int count = 1;
    int result = num1;
    while (count < num2)
    {
        result = result * num1;
        count++;
    }
    return result;
}
Console.WriteLine($"Число А возведенное в степень числа В: {NumberToPow(a, b)}");