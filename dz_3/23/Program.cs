// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int start = 1;                                     // счетчик начинаем с 1 по условию
if(number < 0)                                     // если число ввели отрицательное переводим в положительное
{
    number = -number;
}
while(start <= number)                             // выводим кубы начиная с 1 и заканчивая введеной цифрой
{
    int cube = start * start * start;
    start ++;
    System.Console.WriteLine(cube);
}