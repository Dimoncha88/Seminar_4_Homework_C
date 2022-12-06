// Задача 29: Напишите программу, которая задаёт массив из N элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Введите размерность массива:");
int n = int.Parse(Console.ReadLine());
int[] FillRandArray(int m)
{
    Random rnd = new Random();
    int[] arr = new int[m];
    for (int i = 0; i < m; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}

int[] arr = FillRandArray(n);
Console.Write($"[{String.Join(", ", arr)}]");