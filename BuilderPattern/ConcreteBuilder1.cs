﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();
        public override void BuilderPartA()
        {
            product.Add("部件A");
        }

        public override void BuilderPartB()
        {
            product.Add("部件B");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
