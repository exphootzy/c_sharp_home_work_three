// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = 0;
// int count = 0;
int init = num;

while (init > 0)
{
    temp = temp * 10 + init % 10;
    init = init / 10;
}

if (num - temp == 0)
    Console.WriteLine("Да, это полиндром");
    else
    {
    Console.WriteLine("Нет, это не полиндром");
    }

