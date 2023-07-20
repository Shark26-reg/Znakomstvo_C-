// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int num = Prompt("Введите число: ");
int len = NumberLen(num);
SumNumbers(num, len);


int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int a)
{
    int index = 0;
    while(a > 0)
    {
        a /= 10;
        index++;
    }
    return index;

} 
void SumNumbers(int number, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    System.Console.WriteLine($"Сумма цифр в числе {num} = {sum}");
    
}



