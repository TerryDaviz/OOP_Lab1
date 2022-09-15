using System;
using System.Text;

namespace Lab1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter byte value");
            byte bvalue = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter int value");
            int ivalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter float value");
            float f = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter double value");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter decimal value");
            decimal dd = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter char value");
            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter string value");
            string str = Console.ReadLine();
            Console.WriteLine("Enter bool value");
            bool flse = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("Byte value: " + bvalue);
            Console.WriteLine("Int value: " + ivalue);
            Console.WriteLine("Float value: " + f);
            Console.WriteLine("Double value: " + d);
            Console.WriteLine("Decimal value: " + dd);
            Console.WriteLine("Char value: " + ch);
            Console.WriteLine("String value: " + str);
            Console.WriteLine("Bool value: " + flse);
            //=======================b============================
            bvalue = (byte)ivalue;
            ivalue = (int)f;
            d = (float)dd;
            dd = (int)dd;
            ch = (char)ivalue;
            ////=======================b============================
            bvalue = 1;
            ivalue = 8;
            short svalue = 4;
            long lvalue = 20;
            float fvalue = 5.5F;
            double dvalue = 10.2333333333333333333333333333;
            string strvalue = "value";
            dvalue = fvalue;
            ivalue = svalue;
            lvalue = ivalue;
            ivalue = Convert.ToInt32(bvalue);
            lvalue = bvalue;
            ////=======================c============================
            object obj;
            obj = ivalue;
            object obj2 = 3;
            ivalue = (int)obj2;
            ////=======================d============================
            int variable = 5;
            Console.WriteLine("Type of var variable " + variable.GetType());
            ////=======================e============================
            int? var2 = null;
            ////=======================f============================
            int var3 = 15;
            ////strings:a

            string str1 = "hto ya";
            string str2 = "dadaya";
            Console.WriteLine("Strings comparison:" + str1 == str2);
            //stings:b
            string str3 = "amogus";
            str1 += str2;
            Console.WriteLine("Strings concatenation: " + str1 + str3);
            string str4 = String.Copy(str1);
            Console.WriteLine("\nCopying: " + str4);
            Console.WriteLine("\nSubstring: " + str2.Substring(0, 5));
            Console.WriteLine("\nSplit: ");
            string[] words = str1.Split(" ");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\nInsert: " + str1.Insert(str2.Length, str3));
            Console.WriteLine("\nRemove:" + str1.Remove(11));
            Console.WriteLine("Interpolarion:");
            Console.WriteLine($"First string is :{str1}");
            //stings:c
            string emptyString = "";
            string nullString = null;
            Console.WriteLine("\nempty sting:" + String.IsNullOrEmpty(emptyString) + "\nnull string: " + String.IsNullOrEmpty(nullString));
            Console.WriteLine("Empty and null string concatenation: " + String.Concat(emptyString, str2));
            Console.WriteLine("Empry and null string comparison: " + nullString == str1);
            //stings:d
            StringBuilder sb = new StringBuilder("bruv");
            sb.Remove(2, 1);
            sb.Append("pog");
            sb.Insert(0, "kavo");
            Console.WriteLine("\nStringBuilder:" + sb);
            //arrays:a
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("===================matrix=================");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + matrix[i, j]);
                }
            }
            //arrays:b
            string[] strArray = { "\nsting1", "string2", "string3", "string4" };
            Console.WriteLine("\n\nstrArray length: " + strArray.Length);
            foreach (string s1 in strArray)
            {
                Console.Write(' ' + s1);
            }
            Console.WriteLine("\nEnter number and value of element you want to change: ");
            Console.WriteLine("number: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value: ");
            string value = Console.ReadLine();
            strArray[pos - 1] = value;
            Console.WriteLine("\nResult: ");
            foreach (string s1 in strArray)
            {
                Console.Write(' ' + s1);
            }
            //arrays:c
            Console.WriteLine("\n================Jaggged array============");
            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new int[2];
            jaggedArr[1] = new int[3];
            jaggedArr[2] = new int[4];
            Random random = new Random();
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    jaggedArr[i][j] = random.Next(9);
                }
            }
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write(' ');
                    Console.Write(jaggedArr[i][j] + "\t");
                }
                //arrays:d
                int[] arr = new int[3];
                string[] strng = new string[4];
            }
            //corteges a)
            ValueTuple<int, string, char, string, ulong> tuple = (228, "dabdaya", 'a', "hto ya", 70);
            ValueTuple<int, string, char, string, ulong> newTuple = (1337, "hto ya", 'b', "dabdaya", 90);

            //corteges b)
            Console.WriteLine("\n Tupble items\n" + tuple.Item1);
            Console.Write("\t" + tuple.Item2);
            Console.Write("\t" + tuple.Item3);
            Console.Write("\t" + tuple.Item4);
            Console.Write("\t" + tuple.Item5);
            //corteges c)
            (int, string) tple = (1, "abc");
            object box = tple;
            (int, string) t = (ValueTuple<int, string>)box;
            int[] x = { 1, 2, 3 };
            string str7 = "string";
            (_, _, _, str7) = GetMaxAndMin(x, str7);
            //corteges d)
            bool result = tuple == newTuple;
            Console.WriteLine("\nTuples comparison: " + result);

            //functions
            //Console.WriteLine("Check max int: " + checkMaxInt());
            Console.WriteLine("Uncheck max int: " + uncheckMaxInt());
            (int, int, int, string) GetMaxAndMin(int[] x, string s)
            {
                int max = 0;
                foreach (int elem in x)
                {
                    if (elem > max)
                    {
                        max = elem;
                    }
                }
                int min = 0;
                foreach (int elem in x)
                {
                    if (elem < min)
                    {
                        min = elem;
                    }
                }
                int sum = 0;
                foreach (int elem in x)
                {
                    sum += elem;
                }
                string firstLetter = s.Substring(0);
                return (max, min, sum, firstLetter);
            }

            int checkMaxInt()
            {
                checked
                {
                    int mx = Int32.MaxValue;
                    return mx + 1;
                }
            }
            int uncheckMaxInt()
            {
                unchecked
                {
                    int mx = Int32.MaxValue;
                    return mx + 1;
                }
            }
        }
    }
}