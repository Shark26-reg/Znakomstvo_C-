// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int numberA = Prompt("Введите первое число: ");
int numberB = Prompt("Введите второе число: ");
Stepen(numberA, numberB);


void Stepen(int a, int b)
{
    int result = 1;

    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    
    }
    Console.WriteLine($"Число {numberA} в степени {numberB} = {result}");
}

int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
