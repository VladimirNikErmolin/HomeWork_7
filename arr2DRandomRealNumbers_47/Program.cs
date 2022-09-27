// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int heigth = EnterInt("Введите высоту массива: ");
int width = EnterInt("Введите ширину массива: ");

double[,] numbers = new double[heigth, width];
Fill2DArray(numbers, heigth, width);
Print2DArray(numbers, heigth, width);



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
            numbers[i, j] = random.Next(-10, 11) + random.NextDouble();
        }
    }
}

void Print2DArray(double[,] numbers, int heigth, int width)
{
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write("{0,6:F1}", numbers[i, j]);
        }
        Console.WriteLine();
    }
}
