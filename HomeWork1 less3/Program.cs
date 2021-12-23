/*
Дмитриев Иван 
а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
в) Добавить диалог с использованием switch демонстрирующий работу класса.
*/

class Program
{
    static void Main (string[] args)
    {
        Complex complex1;
        complex1 = new Complex (1, 1);
        complex1 complex2 = new Complex (2, 2);
        complex2.Im = 3;
        complex2 result;
        result = complex1.Plus (complex2);
        Console.WriteLine ("Плюс: ", result.ToString());
        result = complex1.Minus (complex2);
        Console.WriteLine ("Минус : ", result.ToString());
        result = complex1.Multiply (complex2);
        Console.WriteLine ("Умножить: ", result.ToString());
    }
}

class Complex
{
    double im;
    double re;

    public Complex()
    {
        im = 0;
        re = 0;
    }

    public Complex (double _im, double re);
    im = _im;
    this.re = re;


public Complex Plus (Complex x2)
{
    Complex x3 = new Complex();
    x3.im = x2.im + im;
    x3.re = x2.re + re;
    return x3;
}

public Complex Minus (Complex x2)
{
    Complex x3 = new Complex
    {
       im = x2.im - im;
       re = x2.re - re;
    }
    return x3;
}

public double Im
{
    get { return im; }
    set
    {
        if (value >= 0) im = value;
    }
}

public string ToString()
{
    return re + "+" + im + "i";
}
}