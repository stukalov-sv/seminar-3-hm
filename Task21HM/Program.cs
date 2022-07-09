/*
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Вы ввели не целое число");
        }
    }
}

double GetVector(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double diffX = Math.Pow((x1 - x2), 2);
    double diffY = Math.Pow((y1 - y2), 2);
    double diffZ = Math.Pow((z1 - z2), 2);
    double length = Math.Sqrt(diffX + diffY + diffZ);
    return length;
}

int x1 = GetNumber("Введите координату первой точки по x: ");
int y1 = GetNumber("Введите координату первой точки по y: ");
int z1 = GetNumber("Введите координату первой точки по z: ");
int x2 = GetNumber("Введите координату второй точки по x: ");
int y2 = GetNumber("Введите координату второй точки по y: ");
int z2 = GetNumber("Введите координату второй точки по z: ");

double result = GetVector(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {Math.Round(result, 2)}");