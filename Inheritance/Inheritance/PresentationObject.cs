﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Hieght { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object is copied.");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object is duplicated.");
        }

    }
}
