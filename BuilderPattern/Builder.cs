using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal abstract class Builder
    {
        // 一个产品需要A B两部分一起构建，必须被重写，所以用抽象方法
        public abstract void BuilderPartA();
        public abstract void BuilderPartB();
        public abstract Product GetResult();
    }
}
