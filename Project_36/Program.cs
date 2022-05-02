// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.Clear();

// int size = 20;
System.Console.Write("Введите длину массива ");
int size = Int32.Parse(Console.ReadLine());

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    int sum = 0;
    System.Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        System.Console.Write(arr[i] + " ");
        if (i % 2 > 0) sum += arr[i];
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции, соcтаваляет {sum} ");
    System.Console.WriteLine();
}

PrintArray(FillArray(size));
