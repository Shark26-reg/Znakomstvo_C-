// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void PrintNumbers(int numberStart, int numberFinish)
{
    if (numberStart - 1 == numberFinish)
    {
        return;
    }

    System.Console.Write($"{numberFinish};");    
    PrintNumbers(numberStart, numberFinish - 1);    
}
  
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int numberStart = 1;
int numberFinish = Prompt("Введите число (конец промежутка) ");
PrintNumbers(numberStart, numberFinish);