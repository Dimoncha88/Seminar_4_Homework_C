// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

int SumNumbers(int num)
{
    int sum = num % 10;
    while (num >= 10)
    {
        num = num / 10;
        sum = sum + num % 10;
    }
    return sum;
}
Console.WriteLine($"Сумма цифр в числе = {SumNumbers(number)}");