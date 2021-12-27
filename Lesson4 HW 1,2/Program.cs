/* Дмитриев Иван Александрович
1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
В данной задаче под парой подразумевается два подряд идущих элемента массива.
Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

2. Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
в)*Добавьте обработку ситуации отсутствия файла на диске.
*/

class Program
    {
        static void Main(string[] args)
        {
            MyArray array1 = new MyArray(20);
            array1.Print();
            Console.WriteLine("Количество пар, делящихся на 3 = " + array1.Pair_to_N(3));

            MyArray array2 = new MyArray(15, 0, 2);
            array2.Print();

            Console.WriteLine("Сумма: " + array2.Sum);

            array2.Inverse();
            Console.Write("Инверсия: ");
            array2.Print();

            array2.Multi(5);
            Console.Write("Умножаем на 5: ");
            array2.Print();

            Console.WriteLine("Количество максимальных элементов в массиве array1: " + array1.MaxCount);
            Console.WriteLine("Количество максимальных элементов в массиве array2: " + array2.MaxCount);
            MyArray array3 = new MyArray(100000);
            Console.WriteLine("Количество максимальных элементов в массиве array3: " + array3.MaxCount);

            MyArray array4 = new MyArray(@"D:\test.txt");
            Console.WriteLine("Тестим чтение из файла");
            array4.Print();
            Console.WriteLine("Тестим запись в файл массива array1 и чтение файла с обновленными данными");
            array1.Rec(@"D:\test.txt");
            Read(@"D:\test.txt");

            Console.ReadKey();
        }

        
        static void Read(string filename)
        {
            if (File.Exists(filename))
            {
                string[] ss = File.ReadAllLines(filename);
                for (int i = 0; i < ss.Length; i++)
                {
                    Console.Write(ss[i] + " ");
                }
                Console.WriteLine();
            }
            else Console.WriteLine("Error load file");
        }
    }

    class MyArray
    {
        int[] a;
        Random rnd = new Random();
        
        public MyArray(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(-10000, 10000);
        }

        public MyArray(int n, int start, int step)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = start + step * i;
            }
        }

        public MyArray(string filename)
        {
            if (File.Exists(filename))
            {
                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                    a[i] = int.Parse(ss[i]);
            }
            else Console.WriteLine("Error load file");
        }        
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
        }

        public void Inverse()
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= -1;
            }            
        }

        public void Multi(int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= x;
            }
        }

        public int MaxCount
        {
            get
            {
                int max = a[0];
                int count = 1;
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i]>max)
                    {
                        max = a[i];
                        count = 1; 
                    }
                    else if (a[i] == max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public void Print()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
        }

        public int Pair_to_N(int n)
        {
            int count = 0;
            for (int i = 0; i < (a.Length - 1); i++)
            {
                if ((a[i]%n == 0) || (a[i+1]%n == 0))
                {
                    count++;
                }
            }
            return count;
        }


        public void Rec(string filename)
        {
            string[] a_string = new string[a.Length]; 
            for (int i = 0; i < a_string.Length; i++)
                a_string[i] = Convert.ToString(a[i]);
            System.IO.File.WriteAllLines(filename, a_string);
        }   
    }