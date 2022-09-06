// Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Write("Задайте размер массива: ");
int sizeMass = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте числовой диапазон массива. От: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте числовой диапазон массива. До: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] massive = new double[sizeMass];

void FillArray(double[] massive, int min, int max)
{
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(min, max);
    }
}

void WriteArray(double[] massive)
{
    Console.Write("[ ");
    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write(massive[i] + " ");
    }
    Console.Write("]");
}

double DiffMinMax(double[] massive)
{
    double minNum = massive[0];
    double maxNum = massive[0];

    for (int i = 1; i < massive.Length; i++)
    {
        if (minNum > massive[i])
        {
            minNum = massive[i];
        }
        if (maxNum < massive[i])
        {
            maxNum = massive[i];
        }
    }
    double difference = maxNum - minNum;
    return difference;
}

FillArray(massive, min, max);
WriteArray(massive);
double difference = DiffMinMax(massive);
Console.WriteLine($" --> Разница между максимальным и минимальным \n числовым значением в массиве равна: {difference}.");
