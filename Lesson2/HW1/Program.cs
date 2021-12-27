/* Дмитриев Иван 
Написать метод, возвращающий минимальное из трёх чисел.
*/

int a, b, c, min;
Console.WriteLine ("Введите первое чиcло: ");
a = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите второе чиcло: ");
b = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите третье чиcло: ");
c = int.Parse (Console.ReadLine());
if (a < b && a < c)
{
    min = a;
}
else 
{
    if (b < c)
    {
        min = b;
    }
    else 
    {
        min = c;
    }
}
Console.WriteLine ("Минимальное число: " + min);