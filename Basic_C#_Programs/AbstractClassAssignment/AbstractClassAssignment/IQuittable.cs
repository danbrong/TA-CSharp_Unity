﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    interface IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }
    }
}
