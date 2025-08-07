using System;
using System.Collections.Generic;
using AGC4WApi;

namespace AGC.frm
{

    public class myCheckPrjFileState : ICheckPrjFileState
    {
        public bool CheckPrjFileState(string strPrjFileName)
        {
            clsMSProject.ProjectPath = strPrjFileName;// @"E:\ASPNETJX\SamplePrj\SamplePrj_Entity\SamplePrj_Entity.csproj";
            try
            {
                IEnumerable<string> arr = clsMSProject.getCompileFileLst();
                return true;
            }
            catch (Exception objException)
            {
                Console.WriteLine(objException);
                return false;
            }
        }
    }
}
