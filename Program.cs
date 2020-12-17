using System;

namespace Lesson4
{
    struct Complex
    {
        private double _im;
        public double Re { get; set; }

        public double Im
        {
            get { return _im; }
            set
            {
                if (value > 0)
                    _im = value;
                else
                    throw new Exception("Мнимая часть комплексного числа должна быть > 0");
            }
        }

        public Complex(double re, double im)
        {
            Re = re;

            if (im > 0)
                this._im = im;
            else
                throw new Exception("Мнимая часть комплексного числа должна быть > 0");
        }


        public Complex Minus(Complex x)
        {
            Complex y = new Complex
            {
                Re = Re - x.Re,
                _im = _im - x._im
            };
            return y;
        }

        public override string ToString()
        {
            return $"{Re}+{_im}i";
        }

    }
    class ComplexClass
    {
        private double _im;
        public double Re { get; set; }
        public double Im
        {
            get { return _im; }
            set
            {
                if (value > 0)
                    _im = value;
                else
                    throw new Exception("Мнимая часть комплексного числа должна быть > 0");
            }
        }

        public ComplexClass() { }
        public ComplexClass(double re, double im)
        {
            Re = re;

            if (im > 0)
                this._im = im;
            else
                throw new Exception("Мнимая часть комплексного числа должна быть > 0");
        }

        public ComplexClass Multiply(ComplexClass x)
        {
            ComplexClass multyplyed = new ComplexClass();

            multyplyed.Re = (x.Re * Re) - (x.Im * Im);
            multyplyed.Im = (Re * x.Im) + (Im * x.Re);
            return multyplyed;
        }
        public ComplexClass Minus(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.Re = Re - x.Re;
            y.Im = Im - x.Im;
            return y;
        }

        public override string ToString()
        {
            return $"{Re}+{_im}i";
        }
    }
    class Login
    {
        static public int SignIn()
        {
            int sum = 0;
            int a;
            string nums = "Нечетные положительные числа: ";
            do
            {
                while (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Введите целое число!");
                }
                if (a > 0 && a % 2 != 0)
                {
                    nums += a + "  ";
                    sum += a;
                }
            }
            while (a != 0);
            Console.WriteLine(nums + $"\nСумма чисел = {sum}");
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex();
            Complex complex2 = new Complex();

            ComplexClass complexClass1 = new ComplexClass(3, 3);
            ComplexClass complexClass2 = new ComplexClass(4, 4);

            Console.WriteLine(complex1 + " - " + complex2 + " = " + complex1.Minus(complex2));
            Console.WriteLine(complexClass1 + " * " + complexClass2 + " = " + complexClass1.Multiply(complexClass2));

            Login.SignIn();
        }
    }
}
