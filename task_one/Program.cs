﻿// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int Begin(string messege)
{
    Console.WriteLine(messege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int numberFlip(int number)
{
    int temp = 0;
    while (number > 0)
    {
        temp = temp * 10 + number % 10;
        number = number / 10;
    }
    return temp;
}

int num = Begin("Введите число: ");
int init = numberFlip(num);
int result = num - init;

if (result == 0)
    {
        Console.WriteLine($"Да, число: {num} - это полиндром");
        return;
    }
Console.WriteLine($"Нет, число: {num} - это не полиндром ");
