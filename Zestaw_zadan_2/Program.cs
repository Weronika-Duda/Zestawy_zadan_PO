using System;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        p21();
        p22();
        p23();
        p24();
        p25();
        p26();
        p27();
        p28();
    }

    static void p21()
    {
        int suma = 0;
        int licznik = 0;
        int ocena;
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Podaj ocenę: ");
            ocena = Convert.ToInt32(Console.ReadLine());
            if (ocena > 2)
            {
                suma += ocena;
                licznik++;
            }
        }
        double srednia = suma / (double)licznik;
        Console.WriteLine("Śrenia z ocen wynosi: {0:N}", srednia);
    }

    static void p22()
    {
        Console.Write("Podaj początkową kwotę: ");
        double kwota_poczatkowa = Double.Parse(Console.ReadLine());

        double oprocentowanie = 0.06;

        Console.Write("Podaj liczbe lat, na jaka chcesz deponowac srodki: ");
        int ile_lat = Int32.Parse(Console.ReadLine());

        double wartosc_inwestycji = kwota_poczatkowa * Math.Pow((1 + oprocentowanie), ile_lat);

        Console.WriteLine("Wartosc inwestycji " + kwota_poczatkowa + " po " + ile_lat + " latach wynosi " + wartosc_inwestycji);
    }

    static void p23()
    {
        Console.Write("Podaj 5 liczb rozdzielajac je pauzami: ");
        string zbior_liczb = Console.ReadLine();

        // Rozdzielenie i usunięcie pustych elementów
        string[] stringi = zbior_liczb.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

        if (stringi.Length != 5)
        {
            Console.WriteLine("Nalezy podac 5 liczb!");
            return;
        }

        int[] liczby = new int[5];
        for( int i = 0; i < 5 ; i++ )
        {
            if (int.TryParse(stringi[i], out liczby[i]) == false)
            {
                Console.WriteLine("Niepoprawny format liczby: " + stringi[i]);
                return;
            }
        }

        int min = liczby[0];
        int max = liczby[0];

        for ( int i = 1; i < 5 ; i++)
        {
            if (liczby[i] < min) 
            {
                min = liczby[i];
            }
            if (liczby[i] > max) 
            {
                max = liczby[i];
            }
        }

        Console.WriteLine("Najmniejsza z podanych liczb to: " + min);
        Console.WriteLine("Najwieksza z podanych liczb to: " + max);
    }

    static void p24()
    {
        int K = 120;
        double S = 1.80;
        double ps = 0;

        Console.Write("Podaj dlugosc skoku: ");
        double d = Double.Parse(Console.ReadLine());

        Console.Write("Podaj oceny sedziow 0-20: ");
        double[] oceny = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Sedzia nr." + (i + 1) + ": ");
            double ocena = Double.Parse(Console.ReadLine());

            if (oceny[i] >= 0 && oceny[i] <= 20)
            {
                oceny[i] = ocena;

                Array.Sort(oceny);
                for (int o = 1; o < 4; o++)
                {
                    ps += oceny[i];
                }
            }
            else
            {
                Console.WriteLine("To niepoprawna ocena. Wprowadź ocenę od 0 do 20!!");
                i--;
            }
        }
        double pd = 60 + (d - K) * S;
        double p = pd + ps;

        Console.WriteLine("Liczba punktów: " + p);
    }

    static void p25()
    {
        double silnia = 1; // bo silnia z 0 to 1

        Console.Write("Podaj liczbe: ");
        double a = Double.Parse(Console.ReadLine());
        if (a >= 0)
        {                                
            for (int i = 1; i <= a; i++)
            {
                silnia *= i;
            }

            Console.WriteLine(a + "! = " + silnia);
        }

        else
        {
            Console.WriteLine("To niepoprawna wartosc. ");
        }
    }


    static int silnia(int a)
    {
        if (a == 0 || a == 1)
        {
            return 1;
        }

        else
        {
            int silnia = 1;

            for (int i = 1; i <= a; i++)
            {
                silnia *= i;
            }

            return silnia;
        }
    }


    static void p26()
    {
        Console.Write("Podaj liczbę do sprawdzenia: ");
        double p = Double.Parse(Console.ReadLine());

        bool czy_pierwsza = true;

        if (p <= 1)
        {
            czy_pierwsza = false; 
        }

        else if (p == 2)
        {
            czy_pierwsza = true; 
        }

        else if (p % 2 == 0)
        {
            czy_pierwsza = false; 
        }

        else
        {
            //  Jeśli liczba p nie jest pierwsza, to musi mieć przynajmniej 1 dzielnik <= od pierwiastka kwadratowego z p
            
            int pierwiastek_p = (int)Math.Floor(Math.Sqrt(p));

            for (int i = 3; i <= pierwiastek_p; i += 2)
            {
                if (p % i == 0)
                {
                    czy_pierwsza = false;
                    break;
                }
            }
        }


        if (czy_pierwsza)
        {
            Console.WriteLine(p + " jest liczbą pierwszą.");
        }
        else
        {
            Console.WriteLine(p + " nie jest liczbą pierwszą.");
        }
    }

    static bool czy_jest_pierwsza(int p)
    {
        if (p < 2)
        {
            return false;
        }

        for (int i = 2; i * i <= p; i ++)
        {
            if (p % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void p27()
    {
        Console.Write("Podaj liczbę a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj liczbę b, gdzie b > a: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a >= b)
        {
            Console.WriteLine("Wartosc b powinna byc wieksza od a.");
        }

        else
        {
            Console.Write("Liczby pierwsze w zadanym przedziale: ");
            for (int i = a; i <= b; i++)
            {
                if (czy_jest_pierwsza(i))
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine();
        }
    }

    static void p28()
    {
        Console.Write("Podaj liczbe k, gdzie k <= n: ");
        int k = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Podaj n: ");
        int n = Convert.ToInt32(Console.ReadLine());       

        if (k <= n)
        {
            long symbol_Newtona;

            if (k == 0 || k == n)
            {

                symbol_Newtona = 1;
            }

            else
            {

                long licznik = silnia(n);
                long mianownik = silnia(k) * silnia(n - k);

                symbol_Newtona = licznik / mianownik;

            }
            Console.WriteLine("Symbol Newtona = " + symbol_Newtona);
        }     

    }
}

