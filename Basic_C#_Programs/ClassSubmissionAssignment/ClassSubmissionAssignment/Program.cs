﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidMethod diVide = new VoidMethod();
            VoidMethod outPut = new VoidMethod();
           

            int y = 200;

            diVide.MyDivide(80);
            diVide.MyDivide(80, 2);
            outPut.MyOutput(out y);
            VoidMethod.MyStatic();
            Console.ReadLine();
        }
    }
}
