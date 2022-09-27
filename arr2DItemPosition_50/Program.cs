// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int heigth = EnterInt("Введите высоту массива: ");
int width = EnterInt("Введите ширину массива: ");

double[,] numbers = new double[heigth, width];
Fill2DArray(numbers, heigth, width);
Print2DArray(numbers, heigth, width);

int row = EnterInt("Введите строку массива: ");
int col = EnterInt("Введите столбец массива:");

try
{
    Console.WriteLine($"Значение элемента на этой позиции {numbers[row, col]:F1}");
}
catch
{
    Console.WriteLine("В массиве нет такого элемента");
}


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
