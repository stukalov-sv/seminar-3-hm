/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            string str = number.ToString();
            int length = str.Length;
            if (length == 5)
                return number;
            else
            {
                Console.WriteLine("Ошибка ввода. Число должно быть пятизначным");
            }
        }
    }
}

void GetPolyCheck(int number)
{
    string str = number.ToString();

    if ((str[0] == str[4]) && (str[1] == str[3])) Console.WriteLine($"{number} -> да");
    else Console.WriteLine($"{number} -> нет");
}

string msg = "Введите пятизначное число: ";
int number = GetNumber(msg);

GetPolyCheck(number);