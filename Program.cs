using System;

namespace LiczbaPierwsza01
{
    class Program
    {
        static bool liczbaPierwsza(int liczba, int x)
        {


            if (liczba <= 2)
            {
                return (liczba == 2) ? true : false;
            }
            if (liczba % x == 0)
            {
                return false;
            }
            if (liczba < x * x)
            {
                return true;
            }
            else
            {
                return liczbaPierwsza(liczba, x + 1);
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Podaj jedną liczbę dodatnią by sprawdzić czy jest liczbą pierwszą");
            int liczba = int.Parse(Console.ReadLine());

            if (liczbaPierwsza(liczba, 2))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Liczba {liczba} jest liczba pierwsza");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Liczba {liczba} nie jest liczba pierwsza");
                Console.ResetColor();
            }
        }
    }
}
