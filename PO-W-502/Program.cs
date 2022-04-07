//Autor: mgr.inż. Piotr Bilski
// Programowanie Obiektowe

using System;

namespace PO_W_502
{
    // Klasa zliczająca równocześnie trzy parametry
    class Counting
    {
        double _side1;
        double _side2;
        double _side3;

        // Konstruktor przypisujący wartości polom prywatnym
        // Nie da się pracować na tej klasie inaczej, niż z trzema
        // parametrami naraz
        public Counting(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        // Przeciążenie operatora (+) 
        public static Counting operator +(Counting fig1, Counting fig2)
        {
            return new Counting(fig1._side1 + fig2._side1, fig1._side2
                              + fig2._side2, fig1._side3 + fig2._side3);
        }

        // Przeciążenie operatora (-)
        public static Counting operator -(Counting fig1, int value)
        {
            return new Counting(fig1._side1 - value, fig1._side2 - value,
                                fig1._side3 - value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Utworzenie obiektów klasy Counting
            Counting fig1 = new Counting(2.34, 5.61, 3.17);
            Counting fig2 = new Counting(4.22, 3.91, 4.17);

            // Wywołanie po przeciążenia obu operatorów (+) i (-)
            // poprzez próbę wykonania operacji matematycznej
            // na złożonych obiektach!!!!! co jest tu akurat błędem!!!
            Counting wynik = fig1 + fig2 - 2;

            // Co tak naprawdę zwróci nam to polecenie?
            Console.WriteLine("\n\n  Wynik obliczeń to: " + wynik);
            Console.ReadKey();
        }
    }
}
