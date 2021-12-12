// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Дмитриев Иван Александрович
 1. Написать программу «Анкета». Последовательно задаются вопросы 
(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $.
*/

string name;
string surname;
double age;
double height;
double weight;
Console.Write ("Введите ваше имя: ");
name = Console.ReadLine ();
Console.Write ("Введите вашу фамилию: ");
surname = Console.ReadLine ();
Console.Write ("Введите ваш возраст: ");
string a = Console.ReadLine ();
age = Convert.ToDouble (a);
Console.Write ("Введите ваш рост: ");
string b = Console.ReadLine ();
height = Convert.ToDouble(b);
Console.Write ("Введите ваш вес: ");
string c = Console.ReadLine ();
weight = Convert.ToDouble(c);
Console.WriteLine (name + " " + surname + " " + age + " " + height + " " + weight);
Console.WriteLine ("{0}" + " " + "{1}" + " " + "{2}" + " " + "{3}" + " " + "{4}", name, surname, age, height, weight);
Console.WriteLine ($"{name}" + " " + $"{surname}" + " " + $"{age}" + " " + $"{height}" + " " + $"{weight}");
