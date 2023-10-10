// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

/* Zadanie 1.1: Napisać program do obliczania pola koła o zadanym (wczytanym przez użytkownika)
promieniu. Jeśli użytkownik wprowadzi liczbę ujemną, program powinien wypisać komunikat „Niepoprawne dane”.
Zadanie 1.2: Napisać program, który wczytuje dwie liczby (długości boków pewnego prostokąta).
Program powinien obliczyć pole prostokąta i sprawdzić, czy prostokąt może być kwadratem.
Zadanie 1.3: Napisać program, który sprawdza, czy wczytana liczba całkowita jest parzysta.
Zadanie 1.4: Napisać program wczytujący 3 liczby i znajdujący największą z nich.
Zadanie 1.5: Napisać program do znajdowania miejsc zerowych równania kwadratowego. Należy
rozważyć trzy przypadki: delta większa/mniejsza/równa zero. Dla przypadku delta < 0 obliczyć
oddzielnie część rzeczywistą i część urojoną i wypisać na ekranie w sposób jaki zapisujemy liczby
zespolone, np. 2 + 3i.*/

static void zad1()
{
    Console.Write("Podaj promien kola: ");
    double r = Double.Parse(Console.ReadLine());
    if (r < 0) {
        Console.WriteLine("Niepoprawne dane");
    }
    else { 
        double pole = Math.PI * r * r;
        Console.WriteLine("Pole wynosi: {0:0.##}", pole);
    }
}

//zad1();

static void zad2()
{
    Console.Write("Podaj dlugosc boku prostokata: ");
    double a = Double.Parse(Console.ReadLine());
    Console.Write("Podaj dlugosc drugiego boku prostokata: ");
    double b = Double.Parse(Console.ReadLine());
    if ( a < 0 || b < 0)
    {
        Console.WriteLine("Niepoprawne dane");
    }
    else
    {
        double pole = a * b;
        Console.WriteLine("Pole prostokota wynosi: {0:0.##}", pole);
    }
    if ( a == b)
    {
        Console.WriteLine("To jest kwadrat");
    }
}

//zad2();

static void zad3()
{
    Console.Write("Podaj liczbe calkowita: ");
    double a = Double.Parse(Console.ReadLine());
    if ((a % 2) == 0)
    {
        Console.WriteLine("Parzysta");
    }
    else
    {
        Console.WriteLine("Nieparzysta");
    }
}

//zad3();

static void zad4()
{
    Console.Write("Podaj pierwsza liczbe: ");
    int a = Int32.Parse(Console.ReadLine());
    Console.Write("Podaj druga liczbe: ");
    int b = Int32.Parse(Console.ReadLine());
    Console.Write("Podaj trzecia liczbe: ");
    int c = Int32.Parse(Console.ReadLine());

    int max = a;

    if (b > max)    {
        max = b;
    }
    if (c > max)    {
        max = c;
    }

    Console.WriteLine("Max({0}, {1}, {2}) = {3}", a, b, c, max);
}
zad4();

static void zad5()
{
    Console.Write("Podaj wspolczynnik a: ");
    double a = Double.Parse(Console.ReadLine());
    Console.Write("Podaj wspolczynnik b: ");
    double b = Double.Parse(Console.ReadLine());
    Console.Write("Podaj wspolczynnik c: ");
    double c = Double.Parse(Console.ReadLine());
    if (a == 0)
    {
        Console.WriteLine("Nie jest to rownanie kwadratowe");
    }
    else
    {
        double delta = b * b - (4 * a * c);
        if (delta < 0)
        {
            Console.WriteLine("Rownanie nie ma pierwiastkow rzeczywistych");
            double re = (-b) / (2 * a);
            double im = Math.Sqrt(-delta) / (2 * a);
            Console.WriteLine("x1 = {0} + {1:0.00}i, x2 = {2} - {3:0.00}i", re, im, re, im);
        }
        else
        {
            if(delta == 0)
            {
                double x0 = (-b) / (2 * a);
                Console.WriteLine("x wynosi: {0:0.##}", x0);
            }
            else
            {
                double pomocnicza = c / a;
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x1 = (pomocnicza / x1);
                Console.WriteLine("x1 wynosi: {0:0.##}", x1);
                double x2 = (-b + Math.Sqrt(delta))/(2 * a);
                x2 = (pomocnicza / x2);            
                Console.WriteLine("x2 wynosi: {0:0.##}", x2);
            }
        }
    }
}

zad5();

static void zad6()
{
    Console.Write("Podaj kwote w zlotowkach: ");
    int kwota_PLN = Int32.Parse(Console.ReadLine());

    Console.Write("Okresl walute (USD/EUR/GBP/CHF/CZK): ");
    string waluta = Console.ReadLine().ToUpper();

    switch (waluta)
    {
        case "USD":
            double kurs_USD = 4.33;
            Console.WriteLine("{0:0.00} zl to {1:0.00} USD", kwota_PLN, kwota_PLN / kurs_USD);
            break;

        case "EUR":
            double kurs_EUR = 4.56;
            Console.WriteLine("{0:0.00} zl to {1:0.00} EUR", kwota_PLN, kwota_PLN / kurs_EUR);
            break;

        case "GBP":
            double kurs_GBP = 5.28;
            Console.WriteLine("{0:0.00} zl to {1:0.00} GBP", kwota_PLN, kwota_PLN / kurs_GBP);
            break;

        case "CHF":
            double kurs_CHF = 4.77;
            Console.WriteLine("{0:0.00} zl to {1:0.00} CHF", kwota_PLN, kwota_PLN / kurs_CHF);
            break;

        case "CZK":
            double kurs_CZK = 0.18;
            Console.WriteLine("{0:0.00} zl to {1:0.00} CZK", kwota_PLN, kwota_PLN / kurs_CZK);
            break;

    }
}

zad6();