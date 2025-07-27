using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGC4WApi
{
    public interface IParseCsFile
    {
        bool ParseCsFile(string strFileName, string strProjectPath, string strPrjId, string strUserId);

    }
}
