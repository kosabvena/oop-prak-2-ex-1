using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Введіть логін: ");
        string login = Console.ReadLine();

        string pattern = @"^[A-Za-z][A-Za-z0-9]{1,9}$";

        if (Regex.IsMatch(login, pattern))
        {
            Console.WriteLine("Логін коректний!");
        }
        else
        {
            Console.WriteLine("Логін некоректний!");
        }
    }
}
