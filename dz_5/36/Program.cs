// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. 
// [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0


int[] GenerateArray(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 20);
          
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.WriteLine(array[j] + "\t");
    }
    System.Console.WriteLine();

}

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Search(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum +array[i];
    }
    return sum;
}

int Length = Prompt("Введите длину массива");
int[] array = GenerateArray(Length);
PrintArray(array);

System.Console.WriteLine($"четных -> {Search(array)}");