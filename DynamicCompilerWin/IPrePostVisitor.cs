using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicCompilerWin
{
    public interface IPrePostVisitor
    {
        void PreVisit(object _obj);
        void Visit(object _obj);
        void PostVisit(object _obj);
    }
}
