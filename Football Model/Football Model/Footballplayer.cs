﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Model
{
    class Footballplayer : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }

        public Footballplayer(string name, int age, int number, double height)
              : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}