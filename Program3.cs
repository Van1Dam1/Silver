

/* 

Дмитриев Иван Александрович
Написать программу, которая подсчитывает расстояние между точками с координатами 
x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой); 
*/

double x1;
double y1;
double x2;
double y2;
double r;
Console.Write ("Введите координату х1: ");
string a = Console.ReadLine ();
x1 = Convert.ToDouble(a);
Console.Write ("Введите координату y1: ");
string b = Console.ReadLine ();
y1 = Convert.ToDouble(b);
Console.Write ("Введите координату х2: ");
string c = Console.ReadLine ();
x2 = Convert.ToDouble(c);
Console.Write ("Введите координату y2: ");
string d = Console.ReadLine ();
y2 = Convert.ToDouble(d);
r = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
Console.WriteLine ("Расстояние между точками: " + $"{r:F}");
