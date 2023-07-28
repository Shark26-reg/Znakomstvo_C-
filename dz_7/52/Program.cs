// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            System.Console.Write($"{array[i, j], 4}");
        }
        System.Console.WriteLine();
    }
}
Console.Write("Введите кол-во строк: ");
int indexrows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int indexcoloums = Convert.ToInt32(Console.ReadLine());
int[,] Array= new int[indexrows, indexcoloums];
FillArray(Array);
double[] AvgNumbers = new double[Array.GetLength(1)];
for (int i = 0; i < Array.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < Array.GetLength(0); j++)
    {
        result += Array[j, i];
        
    }
    AvgNumbers[i] = result / Array.GetLength(0);
    
}
Console.WriteLine();
PrintArray(AvgNumbers); 

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 1)}" + "    ");
    }
    Console.WriteLine();
}

