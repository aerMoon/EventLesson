﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EventLesson
{
    internal class Alpha
    {
        public string name;
        public Alpha(string txt)
        {
            name=txt;
        }
        public void show(string msg)
        {
            Console.WriteLine($"объект {name}:"); 
            Console.WriteLine(msg);
        }
    }
}
