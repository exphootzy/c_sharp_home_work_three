// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Begin(string messege)
{
    Console.WriteLine(messege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void unswer(int paramOne, int paramTwo)
{
    double result = 0;
    Console.Write($"Кубы чисел от 1 до {paramOne}: ");
    while (paramTwo <= paramOne)
    {
        result = Math.Pow(paramTwo, 3);
        Console.Write($" {result}");
        paramTwo++;
    }
}
int num_max = Begin("Введите число: ");
int num_min = 1;
unswer(num_max, num_min);
