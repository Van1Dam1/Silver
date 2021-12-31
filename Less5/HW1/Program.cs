/* Дмитриев Иван Александрович
1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, 
содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) **с использованием регулярных выражений.
*/

class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            Console.WriteLine("Проверка на корректность без регулярных выражений: {0}", LogIn_NoReg(login));
            Console.WriteLine("Проверка на корректность c регулярными выражениями: {0}", LogIn_Reg(login));
            Console.ReadKey();
        }
        static bool LogIn_NoReg(string login)
        {
            if (login.Length>=2 && login.Length<=10 && char.GetNumericValue(login[0])==-1)
            {
                foreach (char item in login)
                {
                    if (char.IsLetterOrDigit(item)==false)
                    {
                        return false;                        
                    }
                }
                return true;
            }
            return false;
        }
        static bool LogIn_Reg(string login)
        {
            Regex myReg = new Regex(@"^[A-Za-zА-Яа-я][A-Za-zА-Яа-я0-9]{1,9}$");
            return myReg.IsMatch(login);
        }
    }
