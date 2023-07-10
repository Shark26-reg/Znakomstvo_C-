/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = 0;

if (number >= 100){
    while (number > 999)
    {
        number = number / 10;
    }
    result = number % 10;
    Console.WriteLine("Третья цыфра числа " + result);
}

else{
    Console.WriteLine("Третьей цифры нет");
}
