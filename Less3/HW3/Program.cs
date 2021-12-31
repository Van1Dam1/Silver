/* 
Дмитриев Иван Александрович
3. Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
Написать программу, демонстрирующую все разработанные элементы класса.
*/ 

 class Fraction
    {
        private int numerator;
        private int denominator;
        public double GetValue
        {
            get
            {
                if (denominator == 0) return double.NaN;
                return (double)numerator / denominator;
            }
        }
        public Fraction()
        {
            this.numerator = 0;
            this.denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0) throw new DivideByZeroException("Делитель не может быть нулем");
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public Fraction(string stringFraction)
        {
            string[] sf = stringFraction.Split('/');
            if (sf.Length < 2) throw new Exception("Не удается преобразовать строку в дробь");
            if (sf[1] == "0") throw new DivideByZeroException("Делитель не может быть нулем");
            int nr, dr;
            if (!int.TryParse(sf[0], out nr) || !int.TryParse(sf[1], out dr))
                throw new Exception("Не удается преобразовать строку в дробь");
            this.numerator = nr;
            this.denominator = dr;
        }

        override public string ToString()
        {
            if (denominator == 0) return "NaN";
            return string.Format("{0}/{1}", numerator, denominator);
        }

        static public Fraction operator +(Fraction f1, Fraction f2)
        {
            int df = f1.denominator;
            int nf = f1.numerator + f2.numerator;
            if (f1.denominator != f2.denominator)
            {
                df *= f2.denominator;
                nf = f1.numerator * f2.denominator + f2.numerator * f1.denominator;
            }
            return new Fraction(nf, df);
        }

        static public Fraction operator -(Fraction f1, Fraction f2)
        {
            int df = f1.denominator;
            int nf = f1.numerator - f2.numerator;
            if (f1.denominator != f2.denominator)
            {
                df *= f2.denominator;
                nf = f1.numerator * f2.denominator - f2.numerator * f1.denominator;
            }
            return new Fraction(nf, df);
        }

        static public Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.numerator * f2.numerator, f1.denominator * f2.denominator);
        }

        static public Fraction operator /(Fraction f1, Fraction f2)
        {
            if (f2.numerator == 0) throw new DivideByZeroException("Деление на 0");
            return f1 * f2.FlipFraction;
        }

        public Fraction FlipFraction { get { return new Fraction(denominator, numerator); } }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Fraction fr1 = new Fraction(1, 2);
            Fraction fr2 = new Fraction("1/3");
            Fraction fr3 = fr1 + fr2;
            Console.WriteLine($"{fr1} + ${fr2} = ${fr3} = ${fr3.GetValue}.");
            fr3 = fr1 - fr2;
            Console.WriteLine($"{fr1} - {fr2} = {fr3} = {fr3.GetValue}.");
            fr3 = fr1 * fr2;
            Console.WriteLine($"{fr1} * {fr2} = {fr3} = {fr3.GetValue}.");
            fr3 = fr1 / fr2;
            Console.WriteLine($"{fr1} / {fr2} = {fr3} = {fr3.GetValue}.");
            Console.ReadLine();
        }
    }