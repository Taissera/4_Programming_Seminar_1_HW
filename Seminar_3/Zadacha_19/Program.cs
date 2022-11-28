﻿/*
Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
Палиндром - это строка, которая читается одинаково слева-направо и справа-налево, пробельные символы при этом игнорируются. 
*/

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int NumLength = number.Length;

if (NumLength == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"{number} - не является пятизначным");
}