using System;

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
        }
    }
}