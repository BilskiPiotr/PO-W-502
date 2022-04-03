using System;

namespace PO_W_502
{
    // przykład klasy zliczającej równocześnie wiele parametrów naraz
    class Counting
    {
        public double _side1;
        public double _side2;
        public double _side3;
        public Counting(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }
        public static Counting operator +(Counting fig1, Counting fig2)
        {
            return new Counting(fig1._side1 + fig2._side1, fig1._side2
                              + fig2._side2, fig1._side3 + fig2._side3);
        }
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
            Counting fig1 = new Counting(2.34, 5.61, 3.17);
            Counting fig2 = new Counting(4.22, 3.91, 4.17);

            Counting wynik = fig1 + fig2 - 2;

            // Co tak naprawdę zwróci nam to polecenie?
            Console.WriteLine("Wynik obliczeń to: " + wynik);
            Console.ReadKey();
        }
    }
}
