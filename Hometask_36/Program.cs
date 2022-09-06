// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами.
// 2. Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Write("Задайте размер массива. Введите число: ");
int numMass = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте числовой диапазон массива. От: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте числовой диапазон массива. До: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[numMass];

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void WriteArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

int SumElemnt(int[] array)
{
    int sumElement = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sumElement += array[i];
    }
    return sumElement;
}

FillArray(numbers, min, max);
WriteArray(numbers);
int result = SumElemnt(numbers);
Console.WriteLine($" --> Cумма элементов, стоящих на нечётных индексах равна: {result}.");