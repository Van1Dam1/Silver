// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* 

Дмитриев Иван Александрович
Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ)
 по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
 */

double m;
double h;
double I;
Console.Write ("Введите ваш вес в кг: ");
string c = Console.ReadLine ();
m = Convert.ToDouble(c);
Console.Write ("Введите ваш рост в метрах: ");
string b = Console.ReadLine ();
h = Convert.ToDouble(b);
I = m / (h*h);
Console.WriteLine ("Ваш индекс массы тела: " + I);
