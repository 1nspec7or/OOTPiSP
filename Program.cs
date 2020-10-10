using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ootpisp_lb2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boolvar = false; //true or false
            byte bytevar = 0; //0...255
            sbyte sbytevar = 0; //-128...127
            char charvar = ' '; // 1 symbol
            decimal decimalvar = 0; //+- 1.0*10^28 ... +- 7.9*10^28
            double doublevar = 0; // 5*10^-324 ... 1.7*10^308
            float floatvar = 0.0f; // 1.5*10^-45...3.4*10^38
            int intvar = 0; // -2,147,483,648...2,147,483,647
            uint uintvar = 0; // 0...4,294,967,295
            long longvar = 0; //-9,223,372,036,854,775,808...9,223,372,036,854,775,807
            ulong ulongvar = 0; //0...18,446,744,073,709,551,615
            ushort ushortvar = 0; //0...65,535

            Console.WriteLine("Введите boolvar: ");
            boolvar = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите bytevar: ");
            bytevar = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите sbytevar: ");
            sbytevar = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("Введите charvar: ");
            charvar = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите decimalvar: ");
            decimalvar = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine("Введите doublevar: ");
            doublevar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine("Введите floatvar: ");
            floatvar = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine("Введите intvar: ");
            intvar = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите uintvar: ");
            uintvar = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите longvar: ");
            longvar = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите ulongvar: ");
            ulongvar = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Введите ushortvar: ");
            ushortvar = ushort.Parse(Console.ReadLine());

            Console.WriteLine("\n{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}\n{10}\n{11}",
            boolvar, bytevar, sbytevar, charvar, decimalvar, doublevar, floatvar, intvar, uintvar, longvar, ulongvar, ushortvar);

            //неявное преобразовние
            longvar = intvar;
            longvar = bytevar;
            intvar = bytevar;
            doublevar = floatvar;
            ulongvar = ushortvar;

            //явное преобразование
            floatvar = (float)doublevar;
            ushortvar = (ushort)intvar;
            ulongvar = (ulong)longvar;
            sbytevar = (sbyte)bytevar;
            bytevar = (byte)sbytevar;

            int variable = 5;
            object tmpobj = variable; //упаковка
            int unboxedvar = (int)tmpobj; //распаковка

            var i = 10; //компилируется как int
            var s = "a"; //компилируется как string

            int? nullableint = null; //эквивалентно записи Nullable<int>
            //Console.WriteLine(nullableint.Value); возникнет ошибка. необходимо выполнять проверку на наличие значения
            if (nullableint.HasValue)
                Console.WriteLine(nullableint.Value);
            else
                Console.WriteLine("null");

            var c = 123;
            c = "abc"; //ошибка, т.к. тип определяется при инициализации

            var d;
            d = 123; //также возникнет ошибка

            var str1 = "abc";
            var str2 = "abd";

            if (str1 == str2)
                Console.WriteLine("str1 = str2");
            else
                Console.WriteLine("str1 != str2");

            string str3 = "Hell";
            string str4 = "o W";
            string str5 = "orld";

            str3 += str4; // сцепление строк (конкатенация)
            str4 = String.Copy(str3);
            str3 = str3.Substring(4);
            str3 = str3 + str5;
            string[] splittedstr = str3.Split(new char[] { ' ' });
            str3 = str3.Insert(7, str5);
            str3 = str3.Remove(7);
            Console.WriteLine($"str3 = {str3}\tstr4 = {str4}\tstr5 = {str5}\n Hello World => {str4 + str5}");

            string emptystr = "";
            string nullstr = null;
            if (String.IsNullOrEmpty(emptystr))
                Console.WriteLine("Null or empty");
            if (String.IsNullOrEmpty(nullstr))
                Console.WriteLine("Null or empty");

            Console.WriteLine(emptystr.Length);
            Console.WriteLine(nullstr.Length);

            StringBuilder sb = new StringBuilder("Hello World!");
            Console.WriteLine(sb);
            sb.Remove(0, 6);
            sb.Insert(0, "Wonderful ");
            sb.Insert(0, "(");
            sb.Insert(sb.Length, ")");
            Console.Write(sb);

            int[,] intarr = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < intarr.GetLength(0); i++)
            {
                for (int j = 0; j < intarr.GetLength(1); j++)
                    Console.Write(intarr[i, j]);
                Console.WriteLine();
            }

            string[] stringarr = { "A", "BC", "DEF", "", "GH" };
            Console.WriteLine($"Длина массива: {stringarr.Length}");
            for (int i = 0; i < stringarr.Length; i++)
                Console.WriteLine($"{i + 1}-я строка массива: {stringarr[i]}");


            Console.WriteLine("Введите номер строки, которую нужно изменить: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Введите новое значение строки: ");
            stringarr[index] = Console.ReadLine();
            Console.WriteLine("Новый массив:");
            for (int i = 0; i < stringarr.Length; i++)
                Console.WriteLine($"{i + 1}-я строка массива: {stringarr[i]}");


            double[][] jaggedarr = new double[3][];
            jaggedarr[0] = new double[2];
            jaggedarr[1] = new double[3];
            jaggedarr[2] = new double[4];

            Console.WriteLine("Инициализируем первый массив: ");
            for (int i = 0; i < jaggedarr[0].Length; i++)
            {
                jaggedarr[0][i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                //Console.Write($"{jaggedarr[0][i]}\t");
            }
            Console.WriteLine();

            Console.WriteLine("Инициализируем второй массив: ");
            for (int i = 0; i < jaggedarr[1].Length; i++)
            {
                jaggedarr[1][i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                //Console.Write($"{jaggedarr[1][i]}/t");
            }
            Console.WriteLine();

            Console.WriteLine("Инициализируем третий массив: ");
            for (int i = 0; i < jaggedarr[2].Length; i++)
            {
                jaggedarr[2][i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
                //Console.Write($"{jaggedarr[2][i]}/t");
            }
            Console.WriteLine();

            for (int i = 0; i < jaggedarr.Length; i++)
            {
                for (int j = 0; j < jaggedarr[i].Length; j++)
                {
                    System.Console.Write(jaggedarr[i][j] + " ");
                }
                Console.WriteLine();
            }

            var arrstorage = new object[0];
            var strstorage = "";

            (int, string, char, string, ulong) tuple = (10, "Easy", 'b', "Lime", 123456789);
            Console.WriteLine($"\tTouple\nint: {tuple.Item1}\nstring: {tuple.Item2}\nchar: {tuple.Item3}\nstring: {tuple.Item4}\nulong: {tuple.Item5}\n");
            Console.WriteLine($"\nint: {tuple.Item1}\nchar: {tuple.Item3}\nstring: {tuple.Item4}\n");

            (int Item1, string Item2, char Item3, string Item4, ulong Item5) = tuple;
            (var Item6, var Item7, var Item8, var Item9, var Item10) = tuple;
            var (Item11, Item12, Item13, Item14, Item15) = tuple;
            (_, _, _, _, _) = tuple;

            var a = (1, 2, 3);
            var b = (3, 2, 3);
            var c = (1, 2, 3);
            var d = (2, 1, 3);

            if (a.CompareTo(b) == 0)
                Console.WriteLine("a = b");
            if (a.CompareTo(c) == 0)
                Console.WriteLine("a = c");
            if (a.CompareTo(d) == 0)
                Console.WriteLine("a = d");

            (int, int, int, char) MultipurposeFunction(int[] nums, string str)
            {
                int temp;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                }
                int min = nums[0];
                int max = nums[nums.Length - 1];
                int sum = 0;
                foreach (int i in nums)
                    sum += i;
                char symb = str[0];
                return (min, max, sum, symb);
            }
            
            var tuple1 = MultipurposeFunction(new int[] { 10, 2, 300, 48, 21, 19, 163, 237}, "ghsndwen");
            Console.WriteLine($"min: {tuple1.Item1}\nmax: {tuple1.Item2}\nsum: {tuple1.Item3}\nfirst symbol in string: {tuple1.Item4}");
            
            int chFunc(int maxvalue1)
            {
                checked
                {
                    //maxvalue1++;
                }
                return maxvalue1;
            }

            int unchFunc(int maxvalue2)
            {
                unchecked
                {
                    maxvalue2++;
                }
                return maxvalue2;
            }

            Console.WriteLine(chFunc(int.MaxValue));
            Console.WriteLine(unchFunc(int.MaxValue));

            Console.ReadLine();
        }
    }
}
