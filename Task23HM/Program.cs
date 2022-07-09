/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9. 
5 -> 1, 8, 27, 64, 125
*/

void GetCubic(int N)
{
    foreach (int ind in Enumerable.Range(1, N)) Console.Write($"{ind * ind * ind}, ");
}

int GetNumber(string msg)
{  
    while(true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if(int.TryParse(valueFromConsole, out int number))
        {
            if(number > 0) 
                return number;
            else 
            {
                Console.WriteLine("Ошибка ввода. Число должно отличаться от 0");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Вы ввели не число");
        }
    }
}

string msg = "Введите целое число";
int number = GetNumber(msg);

GetCubic(number);