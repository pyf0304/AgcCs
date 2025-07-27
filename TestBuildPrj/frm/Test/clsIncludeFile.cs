
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using com.taishsoft.common;

namespace Agc_CsWin.frm
{
    public class CompileTab
    {
        public string TabName { get; set; }
        public string Operate { get; set; }
        public bool IncludeExpand { get; set; }

    }
    public class clsIncludeFile
    {
        #region Fields



        private static XmlDocument _docXml;
        private static string _filePath;
        private static string _xmlPath;
        private static bool _isDirtyCsProj = false;
        private static bool _singleFile = false;

        public static string XmlPath { get => _xmlPath; set => _xmlPath = value; }

        #endregion Fields

        #region Methods



        public static List<CompileTab> getTabNameLst()
        {
            _docXml = _docXml ?? GetXmlDoc(_xmlPath);
            XmlNodeList xnl = _docXml.ChildNodes[0].ChildNodes;
            if (_docXml.ChildNodes[0].Name.ToLower() != "Compiles")
                xnl = _docXml.ChildNodes[1].ChildNodes;

            string assemblyname = string.Empty;//程序集名
            string outputpath = string.Empty;//输出路径
                                             
            //遍历工程集文件

            List<CompileTab> arrCompileTab = new List<CompileTab>();
            foreach (XmlNode xn in xnl)
            {
                CompileTab objCompileTab = null;//
                if (xn.Name == "TabName")
                {
                    objCompileTab = new CompileTab();
                    objCompileTab.TabName = xn.InnerText;
                }
                if (xn.Attributes.Count > 0)
                {
                    foreach (XmlAttribute strAttributes in xn.Attributes)
                    {
                        switch (strAttributes.Name)
                        {
                            case "IncludeExpand":
                                objCompileTab.IncludeExpand = bool.Parse(strAttributes.Value);
                                break;
                            case "Operate":
                                objCompileTab.Operate = strAttributes.Value;
                                break;

                        }
                    }
                }
                if (arrCompileTab.Exists(x=>x.TabName == objCompileTab.TabName))
                {
                    string strMsg = string.Format("在包含文件:[{0}]中，存在重复的表名:[{1}].(In {2})",
                        _xmlPath, objCompileTab.TabName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                arrCompileTab.Add(objCompileTab);
            }
            return arrCompileTab;
        }
        public static bool SortTabNameLst()
        {
            _docXml = _docXml ?? GetXmlDoc(_xmlPath);
            XmlNode xnCompile = _docXml.ChildNodes[0];
            foreach(XmlNode objInFor in _docXml.ChildNodes)
            {
                if (objInFor.Name.ToLower() != "compiles") continue;
                xnCompile = objInFor;
            }

            string assemblyname = string.Empty;//程序集名
            string outputpath = string.Empty;//输出路径

            //遍历工程集文件

            List<CompileTab> arrCompileTab = new List<CompileTab>();
            foreach (XmlNode xn in xnCompile.ChildNodes)
            {                
                CompileTab objCompileTab = null;//
                if (xn.Name == "TabName")
                {
                    objCompileTab = new CompileTab();
                    objCompileTab.TabName = xn.InnerText;
                }
                if (xn.Attributes.Count > 0)
                {
                    foreach (XmlAttribute strAttributes in xn.Attributes)
                    {
                        switch (strAttributes.Name)
                        {
                            case "IncludeExpand":
                                objCompileTab.IncludeExpand = bool.Parse(strAttributes.Value);
                                break;
                            case "Operate":
                                objCompileTab.Operate = strAttributes.Value;
                                break;
                        }
                    }
                }
                if (arrCompileTab.Exists(x => x.TabName == objCompileTab.TabName))
                {
                    //string strMsg = string.Format("在包含文件:[{0}]中，存在重复的表名:[{1}].(In {2})",
                    //    _xmlPath, objCompileTab.TabName, clsStackTrace.GetCurrClassFunction());
                    //throw new Exception(strMsg);
                }
                else
                {
                    arrCompileTab.Add(objCompileTab);
                }
     
            }
            int intLen = xnCompile.ChildNodes.Count;
            for (int i= intLen-1; i>=0; i--)
            {
                XmlNode xn = xnCompile.ChildNodes[i];            
                xnCompile.RemoveChild(xn);
            }
            //      xnCompile.RemoveAll();
            arrCompileTab = arrCompileTab.OrderBy(x => x.TabName).ToList();
            arrCompileTab.ForEach(x =>
            {
                XmlNode xn = _docXml.CreateNode(XmlNodeType.Element, "TabName", "");//.  xnCompile.AppendChild( new XmlNode();
                xn.InnerText = x.TabName;
                XmlAttribute att2 = _docXml.CreateAttribute("Operate");
                att2.Value = x.Operate.ToString();
                xn.Attributes.Append(att2);
                XmlAttribute att = _docXml.CreateAttribute("IncludeExpand");
                att.Value = x.IncludeExpand.ToString();
                xn.Attributes.Append(att);
              
                xnCompile.AppendChild(xn);
            });
            _docXml.Save(_xmlPath);
            return true;
        }
        public static string GetBuildPrj()
        {
            _docXml = _docXml ?? GetXmlDoc(_xmlPath);
            XmlNode xnCompile = _docXml.ChildNodes[0];
            foreach (XmlNode objInFor in _docXml.ChildNodes)
            {
                if (objInFor.Name.ToLower() != "compiles") continue;
                xnCompile = objInFor;
            }
            string strBuildPrj = "";
            foreach (XmlAttribute strAttributes in xnCompile.Attributes)
            {
                switch (strAttributes.Name)
                {
                    case "BuildPrj":
                        strBuildPrj  = strAttributes.Value;
                        break;
                }
            }
            return strBuildPrj;
        }


        private static XmlDocument GetXmlDoc(string xmlPath)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(xmlPath);
            
            return doc;
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