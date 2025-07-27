using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicCompilerWin
{
    public interface IVisitor
    {
        void Visit(object _obj);
    }
}
