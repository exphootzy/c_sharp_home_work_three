// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int Begin(string messege)
{
    Console.WriteLine(messege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void unswer(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2)) + (Math.Pow(z2 - z1, 2)));
    Console.WriteLine($"Расстояние между двумя точками равно: {Math.Round(result, 2)}");
}

int x1 = Begin("Введите первую координату для первой точки: ");
int y1 = Begin("Введите вторую координату для первой точки: ");
int z1 = Begin("Введите третью координату для первой точки: ");
int x2 = Begin("Введите первую координату для второй точки: ");
int y2 = Begin("Введите вторую координату для второй точки: ");
int z2 = Begin("Введите третью координату для второй точки: ");
unswer(x1, y1, z1, x2, y2, z2);
