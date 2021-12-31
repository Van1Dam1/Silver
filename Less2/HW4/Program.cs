/* Дмитриев Иван 
 Реализовать метод проверки логина и пароля. 
 На вход метода подается логин и пароль. 
 На выходе истина, если прошел авторизацию, и ложь, если не прошел 
 (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: 
 пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
 С помощью цикла do while ограничить ввод пароля тремя попытками.
*/

static bool verify (string login, string password)
{
    if (login == "root" && password == "GeekBrains")
    {
        return true;
    }
    else 
    {
        return false;
    }

}

int t = 0;
do 
{
    Console.WriteLine("Введите логин: ");
    string login = Console.ReadLine();
    Console.WriteLine("Введите пароль: ");
    string password = Console.ReadLine();
    t++;
    if (verify(login, password))
    {
        return 1;
    }
}
while (t < 3);
return 0;