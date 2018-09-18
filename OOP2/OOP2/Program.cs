using System;
using System.Text;
namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n = 0;
            byte f = 5;
            int v = 100;
            long g = 1000;
            short t = 100;
            ushort c = 15;
            uint k = 10;
            ulong s = 5;
            char q = 'h';
            bool p = true;
            float fl = 3.14F;
            double b = 6.222232;
            decimal w = 112_232_444;

            //явное и неявное приведение

            int ff = f;
            short nn = t;
            double ee = c;
            long gg = k;
            int cc = t;

            byte bb = (byte)c;
            int hh = (int)k;
            uint qq = (uint)s;
            ulong vv = (ulong)v;
            byte zz = (byte)w;

            //упаковка и распаковка
            int uu = 5;
            Object obj = uu;

            int db = (int)obj;

            Console.WriteLine($"{db}");

            //-------------------
            var q2 = db; //неявно типизированная переменная
            Console.WriteLine("Сумма = {0}", (q2 + 5));

            //nullable-переменная
            int? vd = null;
            int qd = vd ?? 6;
            Console.WriteLine("Выведет 6, т.к. левый операнд null");

            int? sd = 7;
            int fd = sd ?? 6;
            Console.WriteLine("Выведет {0}, т.к. левый операнд не null", fd);

            //Строковые литералы
            String path;
            path = "C:\\Windows\\regedit.exe"; //верно
            path = @"C:\Windows\regedit.exe";   //верно, наиболее предпочтительно
            path = "C:/Windows/regedit.exe";   //верно
            //path = "C:\Windows\regedit.exe"; //неверно

            //Три строки и операции с ними
            string str1 = "qqq";
            string str2 = "www";
            string str3 = "eee";

            Console.WriteLine("Конкатенация {0}", String.Concat(str1, str2, str3));

            string sq;
            sq = String.Copy(str1);
            Console.WriteLine("Копирование строки str1 - {0}", sq);

            sq = str1.Substring(1, 2);
            Console.WriteLine("Выделение подстроки из str1 (2 первых символа) - {0}", sq);

            String str4 = str1.Insert(1, str2);
            Console.WriteLine("Вставка подстроки в строку - {0}", str4);

            string sv = "lolik";
            Console.WriteLine("Удаление 1 символа начиная со 2 позиции {0}", sv.Remove(2, 1));

            //создание пустой и null строки
            string mys = "";
            string nys = null;
            string vys = "kek";

            Console.WriteLine("Вставка в пустую строку {0}", mys.Insert(0, "f"));
            Console.WriteLine("Объединение null строки со строкой vys {0}", (String.Concat(vys, nys)));
            //выдаст ошибку, т.к. нельзя применять методы к null строкам
            //Console.WriteLine("Вставка в null строку {0}", nys.Insert(0, "f"));

            //Создание строки с использованием StringBuilder
            StringBuilder sb = new StringBuilder("ABC", 10);
            Console.WriteLine("Вставка в начало {0}", sb.Insert(0, "Hi"));
            Console.WriteLine("Вставка в конец {0}", sb.Append("Hi"));
            Console.WriteLine("Удаление 1 символа начиная с позиции 1 {0}", sb.Remove(1, 1));

            //Двумерный массив и вывод на экран
            Console.WriteLine();
            int[,] myArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int ik = 0; ik < myArray.GetLength(0); ik++)
            {
                for (int jk = 0; jk < myArray.GetLength(1); jk++)
                {
                    Console.Write(myArray[ik, jk] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Массив строк
            string[] arrOfString = { "my", "name", "is", "Vadim" };
            Console.Write("Содержимое массива: ");
            foreach (var x in arrOfString)
                Console.Write(x + " ");
            Console.WriteLine();
            Console.WriteLine("Длина массива: {0}", arrOfString.Length);
            Console.WriteLine("Введите строку, на которую нужно заменить элемент: ");
            string myString = Console.ReadLine();
            Console.WriteLine("Введите номер заменяемого элемента: ");
            int posToChange = int.Parse(Console.ReadLine());
            arrOfString[posToChange] = myString;
            foreach (var x in arrOfString)
                Console.Write(x + " ");
            Console.WriteLine();

            //Ступенчатый массив вещественных данных
            float[][] jaggedArray = { new float[2], new float[3], new float[4] };
            Console.WriteLine("Введите элементы массива jaggedArray[0][2]: ");
            for (int i = 0; i < 2; i++)
            {
                jaggedArray[0][i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите элементы массива jaggedArray[1][3]: ");
            for (int i = 0; i < 3; i++)
            {
                jaggedArray[1][i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите элементы массива jaggedArray[2][4]: ");
            for (int i = 0; i < 4; i++)
            {
                jaggedArray[2][i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Ступенчатый массив выглядит так:");
            for (int i = 0; i < 2; i++)
            {
                Console.Write("\t" + jaggedArray[0][i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\t" + jaggedArray[1][i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\t" + jaggedArray[2][i] + " ");
            }

            Console.WriteLine();
            Console.ReadKey();

            //неявно типизированная переменная для хранения массива и строки
            var varArray = new int[16];
            var varString = "";

            //Кортежи
            (int age, string firstName, char groupNumber, string secondName, ulong studentId) human = (18, "Вадим", '6', "Докурно", 71171077);
            Console.WriteLine($"{human}"); //вывод целиком
            Console.WriteLine("{0} {1} {2}", human.firstName.ToString(), human.secondName.ToString(), human.age); //вывод выборочно
            (var one, var two, var three, var fourth, var fifth) = human; //распаковка кортежа в переменные
            Console.WriteLine(one);

            (int age, string firstName, char groupNumber, string secondName, ulong studentId) human2 = (18, "Вадим", '6', "Докурно", 71171077);
            if (human.CompareTo(human2)==0)
            {
                Console.WriteLine("Кортеж {0} идентичен кортежу {1}", human, human2);
            } else
            {
                Console.WriteLine("Кортеж {0} не идентичен кортежу {1}", human, human2);
            }

            //Локальная функция
            (int max, int min, int sum, char firstLetter) LocFun(int[] array, String strLoc)
            {
                int sum = 0;
                foreach (int i in array)
                {
                    sum += i;
                }
                Array.Sort(array);
                return (array[array.Length - 1], array[0], sum, strLoc.ToCharArray()[0]);
            }
            int[] intArr = { 6, 3, 2, 1, 5, 4 };
            Console.WriteLine(LocFun(intArr, str1));
        }
    }
}
