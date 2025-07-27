
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFileResourceBLEx
表名:FileResource(00050539)
生成代码版本:2020.05.09.1
生成日期:2020/05/09 16:07:44
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:资源管理
模块英文名:ResourceMan
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;


using AGC.Entity;
using System.Data;
using System.Data.SqlClient;
using AGC.DAL;
using AGC.BusinessLogic;

using com.taishsoft.util;

namespace AGC.BusinessLogicEx
{
    public static class clsFileResourceBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objFileResourceENS">源对象</param>
        /// <returns>目标对象=>clsFileResourceEN:objFileResourceENT</returns>
        public static clsFileResourceENEx CopyToEx(this clsFileResourceEN objFileResourceENS)
        {
            try
            {
                clsFileResourceENEx objFileResourceENT = new clsFileResourceENEx();
                clsFileResourceBL.FileResourceDA.CopyTo(objFileResourceENS, objFileResourceENT);
                return objFileResourceENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objFileResourceENS">源对象</param>
        /// <returns>目标对象=>clsFileResourceEN:objFileResourceENT</returns>
        public static clsFileResourceEN CopyTo(this clsFileResourceENEx objFileResourceENS)
        {
            try
            {
                clsFileResourceEN objFileResourceENT = new clsFileResourceEN();
                clsFileResourceBL.CopyTo(objFileResourceENS, objFileResourceENT);
                return objFileResourceENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 文件资源(FileResource)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsFileResourceBLEx : clsFileResourceBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsFileResourceDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsFileResourceDAEx FileResourceDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsFileResourceDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objFileResourceENS">源对象</param>
        /// <returns>目标对象=>clsFileResourceEN:objFileResourceENT</returns>
        public static clsFileResourceENEx CopyToEx(clsFileResourceEN objFileResourceENS)
        {
            try
            {
                clsFileResourceENEx objFileResourceENT = new clsFileResourceENEx();
                clsFileResourceBL.FileResourceDA.CopyTo(objFileResourceENS, objFileResourceENT);
                return objFileResourceENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsFileResourceENEx> GetObjExLst(string strCondition)
        {
            List<clsFileResourceEN> arrObjLst = clsFileResourceBL.GetObjLst(strCondition);
            List<clsFileResourceENEx> arrObjExLst = new List<clsFileResourceENEx>();
            foreach (clsFileResourceEN objInFor in arrObjLst)
            {
                clsFileResourceENEx objFileResourceENEx = new clsFileResourceENEx();
                clsFileResourceBL.CopyTo(objInFor, objFileResourceENEx);
                arrObjExLst.Add(objFileResourceENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngFileResourceID">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsFileResourceENEx GetObjExByFileResourceID(long lngFileResourceID)
        {
            clsFileResourceEN objFileResourceEN = clsFileResourceBL.GetObjByFileResourceID(lngFileResourceID);
            clsFileResourceENEx objFileResourceENEx = new clsFileResourceENEx();
            clsFileResourceBL.CopyTo(objFileResourceEN, objFileResourceENEx);
            return objFileResourceENEx;
        }

        public static bool AnalysisFileByGenerateCode(string strCmPrjId, List<long> lstFileResourceID = null)
        {
            clsCMProjectEN objCMProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
            string strCondition = new clsFileResourceEN()
                .SetCmPrjId(strCmPrjId, "=")
                .GetCombineCondition();
            List<clsFileResourceEN> arrFileResource = clsFileResourceBL.GetObjLst(strCondition);
            if (lstFileResourceID != null)
            {
                arrFileResource = arrFileResource.Where(x=> lstFileResourceID.Contains( x.FileResourceID) == true).ToList();
            }
            string strCondition_PrjId = new clsPrjTabEN()
                .SetPrjId(objCMProject.PrjId, "=")
                .GetCombineCondition();

            List<clsPrjTabEN> arrPrjTab = clsPrjTabBL.GetObjLst(strCondition_PrjId);
            string strCondition_ApplicationTypeId = new clsAppCodeTypeRelaEN()
                .SetApplicationTypeId(objCMProject.ApplicationTypeId, "=")
                .GetCombineCondition();

            List<clsAppCodeTypeRelaEN> arrAppCodeTypeRela = clsAppCodeTypeRelaBL.GetObjLst(strCondition_ApplicationTypeId);

            string strCondition_CmPrjId = new clsCmProjectPrjTabEN()
                            .SetCmPrjId(strCmPrjId, "=")
                            .GetCombineCondition();

            List<clsCmProjectPrjTabEN> arrCMProjectPrjTab = clsCmProjectPrjTabBL.GetObjLst(strCondition_CmPrjId);

            List<string> arrTabId = arrCMProjectPrjTab.Select(x => x.TabId).ToList();
            if (lstFileResourceID != null)
            {
                var arrTabIdSet = new List<string>();
                foreach (long lngFileResourceID in lstFileResourceID)
                {
                    var obj = clsFileResourceBL.GetObjByFileResourceIDCache(lngFileResourceID);
                    if (string.IsNullOrEmpty(obj.TabId) == true) continue;
                    if (arrTabIdSet.Contains(obj.TabId) == false) arrTabIdSet.Add(obj.TabId);
                }
      //          arrPrjTab = arrPrjTab.Where(x=> arrTabIdSet.Contains( x.TabId) == true).ToList();
            }
            foreach (clsPrjTabEN objPrjTab in arrPrjTab)
            {
                foreach (clsAppCodeTypeRelaEN objAppCodeTypeRela in arrAppCodeTypeRela)
                {
                    clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objAppCodeTypeRela.CodeTypeId);
                    string strFileName = string.Format(objCodeType.FileNameFormat, objPrjTab.TabName);
                    List<clsFileResourceEN> arrFileResource_Sel = arrFileResource.Where(x => x.FileName == strFileName).ToList();

                    if (arrFileResource_Sel.Count == 0) continue;

                    bool bolIsBelongCurrCmPrjId = arrTabId.Contains(objPrjTab.TabId);
                    bool bolIsCanDel = false;

                    foreach (clsFileResourceEN objFileResource in arrFileResource_Sel)
                    {
                        if (bolIsBelongCurrCmPrjId == false)
                        {
                            if (objCodeType.IsDefaultOverride == true)
                            {
                                bolIsCanDel = true;
                            }
                            else if (objFileResource.CreationTime == objFileResource.LastWriteTime)
                            {
                                bolIsCanDel = true;
                            }
                        }
                        objFileResource.SetTabId(objPrjTab.TabId)
                            .SetIsBelongsCurrCMPrj(bolIsBelongCurrCmPrjId)
                            .SetIsCanDel(bolIsCanDel);
                        objFileResource.Update();
                    }
                    string strFileExtName = clsFile.GetFileExtName(strFileName);
                    if (strFileExtName == "ts")
                    {
                        strFileName = strFileName.Replace(".ts", ".js");
                        arrFileResource_Sel = arrFileResource.Where(x => x.FileName == strFileName).ToList();

                        if (arrFileResource_Sel.Count == 0) continue;

                        bolIsBelongCurrCmPrjId = arrTabId.Contains(objPrjTab.TabId);
                        bolIsCanDel = false;

                        foreach (clsFileResourceEN objFileResource in arrFileResource_Sel)
                        {
                            if (bolIsBelongCurrCmPrjId == false)
                            {
                                if (objCodeType.IsDefaultOverride == true)
                                {
                                    bolIsCanDel = true;
                                }
                                else if (objFileResource.CreationTime == objFileResource.LastWriteTime)
                                {
                                    bolIsCanDel = true;
                                }
                            }
                            objFileResource.SetTabId(objPrjTab.TabId)
                                .SetIsBelongsCurrCMPrj(bolIsBelongCurrCmPrjId)
                                .SetIsCanDel(bolIsCanDel);
                            objFileResource.Update();
                        }
                    }
                }
            }

            return true;
        }
        public class CboObjectComparer : IEqualityComparer<clsCboObject>
        {
            public bool Equals(clsCboObject t1, clsCboObject t2)
            {
                return (t1.Value == t2.Value);
            }
            public int GetHashCode(clsCboObject t)
            {
                return t.ToString().GetHashCode();
            }
        }
        public static void BindDdlIn_ExtensionEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format("1 = 1 and {0}='{1}' ",
                conFileResource.PrjId,
                strPrjId);
     //       < option value = ".cache" >.cache </ option >
 
     //< option value = ".config" >.config </ option >
  
     // < option value = ".cs" >.cs </ option >
   
     //  < option value = ".cshtml" >.cshtml </ option >
    
     //   < option value = ".csproj" >.csproj </ option >
     
     //    < option value = ".css" >.css </ option >
      
     //     < option value = ".dll" >.dll </ option >
       
     //      < option value = ".eot" >.eot </ option >
        
     //       < option value = ".gif" >.gif </ option >
         
     //        < option value = ".html" >.html </ option >
          
     //         < option value = ".ico" >.ico </ option >
           
     //          < option value = ".jpg" >.jpg </ option >
            
     //           < option value = ".js" >.js </ option >
             
     //            < option value = ".json" >.json </ option >
              
     //             < option value = ".log" >.log </ option >
               
     //              < option value = ".map" >.map </ option >
                
     //               < option value = ".md" >.md </ option >
                 
     //                < option value = ".out" >.out</ option >
                     
     //                    < option value = ".pdb" >.pdb </ option >
                      
     //                     < option value = ".png" >.png </ option >
                       
     //                      < option value = ".props" >.props </ option >
                        
     //                       < option value = ".pubxml" >.pubxml </ option >
                         
     //                        < option value = ".rar" >.rar </ option >
                          
     //                         < option value = ".svg" >.svg </ option >
                           
     //                          < option value = ".targets" >.targets </ option >
                            
     //                           < option value = ".ts" >.ts </ option >
                             
     //                            < option value = ".ttf" >.ttf </ option >
                              
     //                             < option value = ".txt" >.txt </ option >
                               
     //                              < option value = ".user" >.user </ option >
                                
     //                               < option value = ".woff" >.woff </ option >



                                             List<string> arrExclude = new List<string>() { ".cs", ".cshtml", ".txt", ".ttf", ".ts", ".rar",".png", ".map", ".log" , ".js", ".html", ".gif", ".css" };
            List<clsFileResourceEN> arrFileResource = clsFileResourceBL.GetObjLst(strCondition).Where(x => arrExclude.Contains(x.Extension) == true).ToList();
           
            IEnumerable<clsCboObject> arrCboObject = arrFileResource.Select(x => new clsCboObject(x.Extension, x.Extension)).Distinct(new CboObjectComparer()).OrderBy(x => x.Text);
            objDDL.DataValueField = clsCboObject.con_Value;
            objDDL.DataTextField = clsCboObject.con_Text;
            objDDL.DataSource = arrCboObject;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

    }
}