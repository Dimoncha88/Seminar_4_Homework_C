// Напишите программу, которая на вход принимает радиус круга 
// и находит его площадь округленную до целого числа, 
// необходимо вывести максимальную цифру в полученном округлённом значении площади круга.

// 10 -> 4
// 20 -> 7
// 30 -> 8

Console.Clear();
Console.WriteLine("Введите радиус круга ");
int r = Convert.ToInt32(Console.ReadLine());

int FindSqrRound(int rad)
{
    double s = 3.14 * Math.Pow(rad, 2);
    return Convert.ToInt32(Math.Round(s));
}

int FindMaxNum(int s)
{
    int max = s % 10;
    while (s >= 10)
    {
        s = s / 10;
        int n = s % 10;
        if (n > max) max = n;
    }
    return max;
}
Console.WriteLine($"Площадь круга, округленная до целого числа = {FindSqrRound(r)}");
Console.WriteLine($"Максимальная цифра в полученном числе = {FindMaxNum(FindSqrRound(r))}");