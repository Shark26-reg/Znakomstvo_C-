// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//  m = 3, n = 4.
//  0,5 7 -2 -0,2
//  1 -3,3 8 -9,9
//  8 7,8 -7,1 9


double[,] Arr(int m, int n)
{
    double[,] randomArray = new double[m,n];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i,j] = new Random().NextDouble() *10;
            Console.Write($"{Math.Round(randomArray[i,j], 2), 7}");
        }
        Console.WriteLine();
    }
    return randomArray;
}
Console.Write("Введите m размерность массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] Array=Arr(m,n);

