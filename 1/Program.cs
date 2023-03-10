// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// // 23432 -> да


Console.WriteLine("Введите пятизначное число");

int number = Convert.ToInt32(Console.ReadLine());

int one = number / 10000;

int two = (number / 1000) % 10;

int four = (number / 10) % 10 ;

int five = number % 10;


if ((number > 9999) && (number < 100000))
{
    if( (one == five) && (two == four))
    {
        Console.WriteLine("Это палиндром");
    }
    else 
    {
        Console.WriteLine("Это не палиндром");
    }
}
else
{
    Console.WriteLine("Введите пятизначное число");
}