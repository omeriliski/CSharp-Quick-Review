﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public static class ExtensionMethods
    {
        public static void Print(this string str)
        {
            Console.WriteLine(str);
        }
    }
}
