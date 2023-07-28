// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  17 -> такого числа в массиве нет


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
            System.Console.Write($"{array[i, j], 4}");
        }
        System.Console.WriteLine();
    }
}
Console.Write("Введите индекс столбца: ");
int indexrows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите введите индекс строки: ");
int indexcoloums = Convert.ToInt32(Console.ReadLine());
int[,] Array= new int[5, 5];
FillArray(Array);

if(indexrows < Array.GetLength(0) && indexcoloums < Array.GetLength(1))
{
    System.Console.WriteLine("под введеным индексом это число :" + Array[indexrows, indexcoloums]);
}
else
{
    System.Console.WriteLine($"{indexrows}, {indexcoloums} -> введеный индекс не соответствует размеру массива ");
}