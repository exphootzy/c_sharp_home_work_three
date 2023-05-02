// Задача 3 НЕОБЯЗАТЕЛЬНАЯ. Напишите программу для. проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z (Теорема Де Моргана) .
//  Но теперь количество предикатов не три, а генерируется случайным образом от 5 до 25, сами значения предикатов случайные, проверяем это 
//  утверждение 100 раз, с помощью модуля time выводим на экран , сколько времени отработала программа. 
//  В конце вывести результат проверки истинности этого утверждения.

var watch = new System.Diagnostics.Stopwatch();         
watch.Start();

int i = 0;
while (i <= 100)
{
    bool Convretion(int boolian)
    {
        bool num = Convert.ToBoolean(boolian);
        return num;
    }

    Random random = new Random();
    int a = random.Next(5, 26);
    int[] mass = new int[a];
    Console.WriteLine($"Рандомное число для длинны массива: {a}");
    Console.Write($"Масив: ");
    for (int x = 0; x < mass.Length; x++)
    {
        {
            mass[x] = random.Next(0, 2);
            Console.Write(" ");
            Console.Write(mass[x]);
            Console.Write(" ");
        }
    }

    bool answerOne = Convretion(mass[0]);
    for (int x = 1; x < mass.Length; x++)
    {
        {
            answerOne = !(answerOne & Convretion(mass[x]));
        }
    }

    bool answerTwo = Convretion(mass[0]);
    for (int x = 1; x < mass.Length; x++)
    {
        {
            answerTwo = !answerTwo | !Convretion(mass[x]);
        }
    }

    {
        Console.WriteLine($"Первый итог: {answerOne} Второй итог: {answerTwo}");
        if (answerOne == answerTwo)
        {
            Console.WriteLine("Теорема работает");

        }

        else
        Console.WriteLine("Теорема Не работает");
    }
    i++;
}
watch.Stop();

Console.WriteLine($"Время работы: {watch.ElapsedMilliseconds} ms");



