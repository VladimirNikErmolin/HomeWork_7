// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int heigth = EnterInt("Введите высоту массива: ");
int width = EnterInt("Введите ширину массива: ");

double[,] numbers = new double[heigth, width];
Fill2DArray(numbers, heigth, width);
Print2DArray(numbers, heigth, width);
double[] sums = FindSumColumns(numbers);
Console.WriteLine(string.Join("  ", FindAverage(sums, heigth)), 6);

int EnterInt(string hint)
{
    Console.WriteLine(hint);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(double[,] numbers, int heigth, int width)
{
    Random random = new Random();
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = random.Next(-10, 11);
        }
    }
}

void Print2DArray(double[,] numbers, int heigth, int width)
{
    Console.WriteLine("Ваш массив: ");
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j],4}");
        }
        Console.WriteLine();
    }
}

double[] FindSumColumns(double[,] numbers)
{
    double[] sumColumns = new double[numbers.GetLength(1)];
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        for (int j = 0; j < numbers.GetLength(0); j++)
        {
            sumColumns[i] += numbers[j, i];
        }
    }
    return sumColumns;
}

double[] FindAverage(double[] numbers, int rows)
{
    Console.WriteLine($"Среднее арифметическое каждого столбца :");
    double[] average = new double[numbers.Length];
    for (int k = 0; k < numbers.Length; k++)
    {
        average[k] = Math.Round(numbers[k] / rows, 2);
    }
    return average;
}
