﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuilderPartA();
            builder.BuilderPartB();
        }
    }
}
