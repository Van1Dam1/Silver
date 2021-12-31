/*
Дмитриев Иван 
С клавиатуры вводятся числа, пока не будет введен 0.
Подсчитать сумму всех нечетных положительных чисел.
*/

int sum = 0;
while (true)
{
    Console.WriteLine ("Введите чиcло (для выхода введите 0): ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a == 0)
    {
        break;
    }
    if (a > 0 && a % 2 != 0)
    {
        sum += a;
    }
    Console.WriteLine("Суммы нечетных положительных чисел: " + sum);
}
return sum;