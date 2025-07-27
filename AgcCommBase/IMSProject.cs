using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgcCommBase
{
    public interface IMSProject
    {
        IEnumerable<string> GetCompileFileLst(string strPrjFileName);
    }
}
