﻿// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 - 5
// 782 - 8
// 918 - 1 


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
     if (number < 1000)
     {
          int secondDigit = (number / 10) % 10;
          Console.WriteLine(secondDigit);
     }
}