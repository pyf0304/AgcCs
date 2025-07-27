using System.Text;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

using Microsoft.Build.Evaluation;
using com.taishsoft.common;

namespace Agc_CsWin.frm
{
    public class clsMSProject
    {
        #region Fields

        private const string CPP_PROJ = @"..\Cpp.UnitTest\Cpp.UnitTest.vcxproj";
        private const string CS_PROJ = @"..\specflowC.IntelliSense.StepDefinitions\specflowC.IntelliSense.StepDefinitions.csproj";
        private const string FEATURE_DIR = @"..\" + PROJECT_NAME + "\\";
        private const string PROJECT_NAME = @"Cpp.UnitTest";

        private static Microsoft.Build.Evaluation.Project _cppProj;
        private static Microsoft.Build.Evaluation.Project _csProj;
        private static string _filePath;
        private static string _projectPath;
        private static string _projectPath_Loaded;//已经引导的文件名

        private static bool _isDirtyCppProj = false;
        private static bool _isDirtyCsProj = false;
        private static bool _singleFile = false;

        public static string ProjectPath { get => _projectPath;
            set  {
                _projectPath = value;
                if (_projectPath != _projectPath_Loaded)
                {
                    _csProj = null;
                }
            }
        }

        #endregion Fields

        #region Methods

        public static bool AddCompileFile(string filePath)
        {
            _csProj = _csProj ?? GetUnloadedProject(_projectPath);
            ICollection<ProjectItem> arr = _csProj.GetItems("Compile");
            ProjectItem objProjectItem_Sel = arr.FirstOrDefault(x => x.EvaluatedInclude.Equals(filePath,  StringComparison.InvariantCultureIgnoreCase));
            //if (objProjectItem_Sel != null)
            //{
            //    _csProj.RemoveItem(objProjectItem_Sel);
            //}

            if (objProjectItem_Sel == null)
            {
                string strFileName_Sim = clsString.GetSimpleFName_S(filePath);
                //arr = _csProj.GetItems("Compile");
                ProjectItem objProjectItem_Del = arr.FirstOrDefault(x => x.EvaluatedInclude.Contains(strFileName_Sim));
                
                if (objProjectItem_Del != null)
                {
                    _csProj.RemoveItem(objProjectItem_Del);
                }
                _csProj.AddItem("Compile", filePath);
            }
            _csProj.Save();
            return true;
        }
        public static bool Build()
        {
            _csProj = _csProj ?? GetUnloadedProject(_projectPath);
            //Microsoft.Build.Framework.ILogger logger
            return _csProj.Build();
//            return true;
        }
        public static bool RemoveCompileFile(string filePath)
        {
            _csProj = _csProj ?? GetUnloadedProject(_projectPath);
            ICollection<ProjectItem> arr = _csProj.GetItems("Compile");
            ProjectItem objProjectItem_Sel = arr.FirstOrDefault(x => (x.EvaluatedInclude.Equals(filePath, StringComparison.InvariantCultureIgnoreCase)));
            if (objProjectItem_Sel != null)
            {
                _csProj.RemoveItem(objProjectItem_Sel);
            }
            else
            {
                return false;
            }
            _csProj.Save();
           
            return true;
        }
        public static string RemoveCompileFileByFileName(string fileName)
        {
            string strEvaluatedInclude = "";
            
            _csProj = _csProj ?? GetUnloadedProject(_projectPath);
            ICollection<ProjectItem> arr = _csProj.GetItems("Compile");
            ProjectItem objProjectItem_Sel = arr.FirstOrDefault(x => x.EvaluatedInclude.Contains(fileName));
            if (objProjectItem_Sel != null)
            {
                strEvaluatedInclude = objProjectItem_Sel.EvaluatedInclude;
                _csProj.RemoveItem(objProjectItem_Sel);
            }
            _csProj.Save();
           
            return strEvaluatedInclude;
        }

        public static IEnumerable<string> getCompileFileLst()
        {
            _csProj = _csProj ?? GetUnloadedProject(_projectPath);
            ICollection<ProjectItem> arr = _csProj.GetItems("Compile");
//            ProjectItem objProjectItem_Sel = arr.FirstOrDefault(x => x.EvaluatedInclude == filePath);
            IEnumerable<string> arrFileLst = arr.Select(x=>x.EvaluatedInclude);

            return arrFileLst;
        }

        private static void AddFeatureFileLinkToIntelliSenseProject(string featureFilePath, string featureDir, string pathToIntelliSenseProject)
        {
            _csProj = _csProj ?? GetUnloadedProject(pathToIntelliSenseProject);
            featureFilePath = MakeLinkRelativeToIntelliSenseProject(featureFilePath, featureDir);
            var featureFileLink = featureFilePath.Replace(@"..\", string.Empty);
            if (!_csProj.Items.Any(item => item.GetMetadataValue("Link") == featureFileLink))
            {
                _csProj.AddItem("None", featureFilePath, new Dictionary<string, string> { { "Link", featureFileLink } });
                _isDirtyCsProj = true;
            }
        }

        private static void AddFilesToCppProject(string pathToFile, string featureDir, string pathToCppProject)
        {
            _cppProj = _cppProj ?? GetUnloadedProject(pathToCppProject);

            pathToFile = MakeFeatureDirRelativeToCppProject(pathToFile, featureDir);

            string type = CppFileType(pathToFile);

            if (!_cppProj.GetItems(type).Any(item => item.UnevaluatedInclude == pathToFile))
            {
                _cppProj.AddItem(type, pathToFile);
                _isDirtyCppProj = true;
            }
        }

     
        private static string CppFileType(string pathToFile)
        {
            string type;
            if (pathToFile.Contains(".h"))
            {
                type = "ClInclude";
            }
            else
            {
                type = "ClCompile";
            }
            return type;
        }

       
        private static Microsoft.Build.Evaluation.Project GetUnloadedProject(string projectPath)
        {
            if (File.Exists(projectPath) == false)
            {
                string strMsg = string.Format("工程文件:{0}不存在！(In {1})", projectPath, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            var project = new Microsoft.Build.Evaluation.Project(projectPath);
            project.ProjectCollection.UnloadAllProjects();
            _projectPath_Loaded = projectPath;
            return project;
        }

        //private static void Main(string[] args)
        //{
        //    if (ValidCommandLine(args))
        //    {
        //        Console.WriteLine(string.Format("FEATURE FILE: {0}", _filePath));
        //        string basePath = string.Format("{0}\\", Path.GetDirectoryName(_filePath));
        //        GenerateTest(_filePath, basePath);
        //    }
        //}

        private static string MakeFeatureDirRelativeToCppProject(string pathToFile, string featureDir)
        {
            // could be called from CPP build (already relative) or CS build (make relative to CPP in this case)
            if (pathToFile.StartsWith(featureDir))
            {
                pathToFile = pathToFile.Substring(pathToFile.IndexOf(featureDir) + featureDir.Length);
            }
            return pathToFile;
        }

        private static string MakeLinkRelativeToIntelliSenseProject(string featureFilePath, string featureDir)
        {
            // could be called from CPP build (make relative to CS in this case) or CS build (already relative)
            if (!featureFilePath.StartsWith(featureDir))
            {
                featureFilePath = featureDir + featureFilePath;
            }
            return featureFilePath;
        }

        private static void PrintHelp(string msg)
        {
            Console.WriteLine(string.Format("Invalid command-line argument. Please specify a feature file: {0}", msg));
        }

    
        private static bool ValidCommandLine(string[] args)
        {
            if (args.Length < 1)
            {
                PrintHelp("no args");
                return false;
            }

            if (args[0].ToLower() == "-single" && args.Length == 2)
            {
                _filePath = args[1];
                _singleFile = true;
            }
            else
            {
                _filePath = args[0];
                _singleFile = false;
            }

            if (!File.Exists(_filePath))
            {
                PrintHelp("missing file");
                return false;
            }

            return true;
        }
        
        #endregion Methods
    }
}