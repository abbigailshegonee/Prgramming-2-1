﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWithFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Choose and option: add, sub, mul, or div: ");
            string op = Console.ReadLine();
            int result = 0;
            if (op == "add") result = add(n1, n2);
            else if (op == "sub") result = sub(n1, n2);
            else if (op == "mul") result = mul(n1, n2);
            else if (op == "div") result = div(n1, n2);
            Console.WriteLine("Result: " + result);
            wait();
        }

        // <access level> <static or not> <return type> najme(<args>) {}
        // In console apps, we'll make all functions "static"
        // Not static in Form apps; always "public" regardless

        public static void wait() {  // void means "returns nothing"
            Console.ReadLine();
            //return;
        }

        public static int add(int x, int y)
        {
            return x + y;
        }
        public static int sub(int x, int y)
        {
            return x - y;
        }
        public static int mul(int x, int y)
        {
            return x * y;
        }
        public static int div(int x, int y)
        {
            return x / y;
        }
    }
}
