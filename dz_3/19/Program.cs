// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да 


System.Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >=10000 && number <= 99999)
{
    int firstNum = number / 10000;            // Находим первую цифру введеном числе
    int lastNum = number % 10;                // Находим последнюю цифру в числе

    if(firstNum == lastNum)                   // Проверяем совпадает ли первая и последняя цифры, если да то переходим к следующей паре
    {
        number = number / 10;                  // переход к следующей цифре
        int secondNum = (number / 100) % 10;   // находим вторую с начала цифру
        int lastSecondNum = number % 10;       // находим вторую с конца цифру
        if(secondNum == lastSecondNum)         // сравниваем полученые две цифры
        {
            System.Console.WriteLine("Да");
        }
        
    }
    else
        System.Console.WriteLine("Нет");
    
}
else
    System.Console.WriteLine("Введено не пятизначное число!");
