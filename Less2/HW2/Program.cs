/*
Дмитриев Иван 
Написать метод подсчета количества цифр числа.
*/

int a;
int i = 0;
Console.WriteLine ("Введите чиcло: ");
a = int.Parse(Console.ReadLine());
while (a > 0)
{
   i++;
   a = a/10;
}
Console.WriteLine($"Количество цифр введенного числа: {i}");