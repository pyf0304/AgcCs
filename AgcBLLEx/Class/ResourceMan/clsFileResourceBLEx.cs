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
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.DAL;
using AGC.Entity;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.file;
using com.taishsoft.util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

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
            clsFileResourceEN objFileResourceEN = clsFileResourceBL.GetObjByFileResourceId(lngFileResourceID);
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
                arrFileResource = arrFileResource.Where(x => lstFileResourceID.Contains(x.FileResourceId) == true).ToList();
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
                    var obj = clsFileResourceBL.GetObjByFileResourceIdCache(lngFileResourceID);
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



            List<string> arrExclude = new List<string>() { ".cs", ".cshtml", ".txt", ".ttf", ".ts", ".rar", ".png", ".map", ".log", ".js", ".html", ".gif", ".css" };
            List<clsFileResourceEN> arrFileResource = clsFileResourceBL.GetObjLst(strCondition).Where(x => arrExclude.Contains(x.Extension) == true).ToList();

            IEnumerable<clsCboObject> arrCboObject = arrFileResource.Select(x => new clsCboObject(x.Extension, x.Extension)).Distinct(new CboObjectComparer()).OrderBy(x => x.Text);
            objDDL.DataValueField = clsCboObject.con_Value;
            objDDL.DataTextField = clsCboObject.con_Text;
            objDDL.DataSource = arrCboObject;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 根据用户、电脑获取当前项目中的所有相关文件并导入到数据库
        /// </summary>
        /// <param name="lngCMProjectAppRelaId">Cm工程应用关系Id</param>
        /// <param name="strUserId">用户Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strServerIp">服务器IP地址</param>
        /// <param name="strMsg">返回消息</param>
        /// <returns>成功导入的文件数量</returns>
        public static int ImportProjectFilesByUserAndComputerBak(
            long lngCMProjectAppRelaId,
            string strUserId,
            string strPrjId,
            string strServerIp,
            out string strMsg)
        {
            strMsg = string.Empty;
            int intCount = 0;

            try
            {
                // 1. 验证参数
                if (lngCMProjectAppRelaId <= 0)
                {
                    strMsg = "请提供有效的CMProjectAppRelaId";
                    return -1;
                }

                if (string.IsNullOrEmpty(strUserId))
                {
                    strMsg = "请提供有效的用户Id";
                    return -1;
                }

                if (string.IsNullOrEmpty(strPrjId))
                {
                    strMsg = "请提供有效的工程Id";
                    return -1;
                }

                // 2. 获取用户项目主路径
                string strCondtion = new clsUserCodePrjMainPathEN()
                    .SetUserId(strUserId, "=")
                    .SetCMProjectAppRelaId(lngCMProjectAppRelaId, "=")
                    .SetPrjId(strPrjId, "=")
                    .GetCombineCondition();

                clsUserCodePrjMainPathEN objUserCodePrjMainPath = clsUserCodePrjMainPathBL.GetFirstObj_S(strCondtion);

                if (objUserCodePrjMainPath == null)
                {
                    strMsg = string.Format("未找到用户[{0}]对应的项目主路径配置，请先配置用户项目路径！", strUserId);
                    return -1;
                }

                // 3. 获取项目物理路径
                string strCondition_Path = new clsUserCodePrjMainPath_MachineNameEN()
                    .SetUserCodePrjMainPathId(objUserCodePrjMainPath.UserCodePrjMainPathId, "=")
                    .SetMachineName(Environment.MachineName, "=")
                    .GetCombineCondition();

                clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName =
                    clsUserCodePrjMainPath_MachineNameBL.GetFirstObj_S(strCondition_Path);

                if (objUserCodePrjMainPath_MachineName == null)
                {
                    strMsg = string.Format("未找到当前电脑[{0}]的项目路径配置，请先配置！", Environment.MachineName);
                    return -1;
                }

                string strPhysicalDir = objUserCodePrjMainPath_MachineName.CodePath;

                if (string.IsNullOrEmpty(strPhysicalDir) || !Directory.Exists(strPhysicalDir))
                {
                    strMsg = string.Format("项目物理路径[{0}]不存在或无法访问！", strPhysicalDir);
                    return -1;
                }

                // 4. 获取排除路径列表
                var arrFileResExcludePathObjLst = clsFileResExcludePathBL.GetObjLstCache();
                var arrExcludeDirName = arrFileResExcludePathObjLst.Select(x => x.ExcludeDirName);

                // 5. 获取文件列表
                FileCollection objFileColl = new FileCollection();
                clsFile.GetFileListEx(strPhysicalDir, objFileColl);

                // 6. 获取CmPrjId
                var objCmCMProjectAppRela = clsCMProjectAppRelaBL.GetObjByCMProjectAppRelaIdCache(lngCMProjectAppRelaId, strPrjId);
                if (objCmCMProjectAppRela == null)
                {
                    strMsg = "未找到对应的项目应用关系记录";
                    return -1;
                }

                if (string.IsNullOrEmpty(strServerIp))
                {
                    strServerIp = System.Net.Dns.GetHostName();
                }

                // 7. 遍历文件并导入
                foreach (UserFile objUserFile in objFileColl.FileLst)
                {
                    // 检查是否在排除列表中
                    bool bolIsInclude = false;
                    foreach (string strExcludeDirName in arrExcludeDirName)
                    {
                        if (objUserFile.FullDirName.Contains(strExcludeDirName) == true)
                        {
                            bolIsInclude = true;
                            break;
                        }
                    }
                    if (bolIsInclude == true) continue;

                    // 创建文件资源对象
                    clsFileResourceEN objFileResource = new clsFileResourceEN();
                    objFileResource.FileDirName = objUserFile.FullDirName;
                    objFileResource.IpAddress = strServerIp;
                    objFileResource.FileName = objUserFile.FileName;
                    objFileResource.FileLength = objUserFile.FileSize;
                    objFileResource.UpdUser = strUserId;
                    objFileResource.Extension = objUserFile.Extension;
                    objFileResource.CreationTime = clsDateTime.getDateStr(objUserFile.CreationTime, 1);
                    objFileResource.LastWriteTime = clsDateTime.getDateStr(objUserFile.LastWriteTime, 1);
                    objFileResource.IsExistFile = true;
                    objFileResource.PrjId = strPrjId;
                    objFileResource.CmPrjId = objCmCMProjectAppRela.CmPrjId;

                    // 检查记录是否已存在
                    string strConditionCheck = new clsFileResourceEN()
                        .SetPrjId(objFileResource.PrjId, "=")
                        .SetCmPrjId(objFileResource.CmPrjId, "=")
                        .SetFileDirName(objFileResource.FileDirName, "=")
                        .SetFileName(objFileResource.FileName, "=")
                        .GetCombineCondition();

                    try
                    {
                        if (clsFileResourceBL.IsExistRecord(strConditionCheck) == false)
                        {
                            clsFileResourceBL.AddNewRecordBySql2(objFileResource);
                            intCount++;
                        }
                    }
                    catch (Exception objEx)
                    {
                        var objCmProject = clsCMProjectBL.GetObjByCmPrjIdCache(objCmCMProjectAppRela.CmPrjId);
                        strMsg = string.Format("导入文件[{0}]出错！错误：[{1}]. 项目：{2} (in {3})",
                            objUserFile.FileName,
                            objEx.Message,
                            objCmProject.CmPrjName,
                            clsStackTrace.GetCurrClassFunction());
                        return -1;
                    }
                }

                strMsg = string.Format("成功导入 {0} 个文件。", intCount);
                return intCount;
            }
            catch (Exception objException)
            {
                strMsg = string.Format("导入项目文件资源时出错：{0} (in {1})",
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                return -1;
            }
        }
        /// <summary>
        /// 根据用户、电脑获取当前项目中的所有相关文件并导入到数据库
        /// </summary>
        /// <param name="strUserId">用户Id</param>
        /// <param name="strMachineName">机器名（电脑名），如果为空则使用当前机器名</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strCmPrjId">Cm工程Id</param>
        /// <param name="intApplicationTypeId">应用类型Id</param>
        /// <param name="strServerIp">服务器IP地址，如果为空则使用当前主机名</param>
        /// <param name="bolUseGitIgnore">是否使用 .gitignore 文件过滤，默认为 true</param>
        /// <param name="strMsg">返回消息</param>
        /// <returns>成功导入的文件数量，失败返回-1</returns>
        public static int ImportProjectFilesByUserAndComputerBak20260612(
            string strUserId,
            string strMachineName,
            string strPrjId,
            string strCmPrjId,
            int intApplicationTypeId,
            string strServerIp,
            bool bolUseGitIgnore,
            out string strMsg)
        {
            strMsg = string.Empty;
            int intCount = 0;
            int intIgnoredByGitIgnore = 0;
            int intIgnoredByExcludePath = 0;

            try
            {
                // 1. 验证参数
                if (string.IsNullOrEmpty(strUserId))
                {
                    strMsg = "请提供有效的用户Id";
                    return -1;
                }

                if (string.IsNullOrEmpty(strPrjId))
                {
                    strMsg = "请提供有效的工程Id";
                    return -1;
                }

                if (string.IsNullOrEmpty(strCmPrjId))
                {
                    strMsg = "请提供有效的Cm工程Id";
                    return -1;
                }

                if (intApplicationTypeId <= 0)
                {
                    strMsg = "请提供有效的应用类型Id";
                    return -1;
                }

                // 如果机器名为空，使用当前机器名
                if (string.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = Environment.MachineName;
                }

                // 2. 获取 CMProjectAppRela 关联ID
                long lngCMProjectAppRelaId = clsCMProjectAppRelaBLEx.getCMProjectAppRelaId(
                    strCmPrjId,
                    intApplicationTypeId,
                    strPrjId);

                if (lngCMProjectAppRelaId <= 0)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    strMsg = string.Format(
                        "未找到CM工程:{0}(ID:{1})与应用:{2}(ID:{3})的关联配置，请检查CMProjectAppRela表！(from {4})",
                        strCmPrjName, strCmPrjId, strAppName, intApplicationTypeId,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 3. 获取用户代码项目主路径对象
                clsUserCodePrjMainPathEN objUserCodePrjMainPath =
                    clsUserCodePrjMainPathBLEx.GetObjByCMProjectAppRelaIdCache(
                        lngCMProjectAppRelaId,
                        strPrjId,
                        strUserId);

                if (objUserCodePrjMainPath == null)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    strMsg = string.Format(
                        "未找到CM工程:{0}与应用:{1}的用户:{2}在项目:{3}的代码主路径配置，请先配置UserCodePrjMainPath表！(from {4})",
                        strCmPrjName, strAppName, strUserId, strPrjId,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 4. 获取特定机器的代码路径记录
                clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName =
                    clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(
                        objUserCodePrjMainPath.UserCodePrjMainPathId,
                        strMachineName);

                if (objUserCodePrjMainPath_MachineName == null)
                {
                    strMsg = string.Format(
                        "未找到当前电脑[{0}]的项目路径配置，请先在UserCodePrjMainPath_MachineName表中配置！(from {1})",
                        strMachineName,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 5. 获取项目物理路径
                string strPhysicalDir = objUserCodePrjMainPath_MachineName.CodePath;

                if (string.IsNullOrEmpty(strPhysicalDir))
                {
                    strMsg = string.Format("机器[{0}]的CodePath配置为空！", strMachineName);
                    return -1;
                }

                if (!Directory.Exists(strPhysicalDir))
                {
                    strMsg = string.Format("项目物理路径[{0}]不存在或无法访问！", strPhysicalDir);
                    return -1;
                }

                // 6. 加载 .gitignore 解析器（如果启用）
                clsGitIgnoreParser gitIgnoreParser = null;
                if (bolUseGitIgnore)
                {
                    try
                    {
                        gitIgnoreParser = clsGitIgnoreParser.LoadFromDirectory(strPhysicalDir);
                    }
                    catch (Exception ex)
                    {
                        string strWarnMsg = string.Format("加载 .gitignore 文件时出现警告：{0}，将继续处理但不过滤 .gitignore 规则", ex.Message);
                        clsSysParaEN.objLog.WriteDebugLog(strWarnMsg);
                    }
                }

                // 7. 获取排除路径列表
                var arrFileResExcludePathObjLst = clsFileResExcludePathBL.GetObjLstCache();
                var arrExcludeDirName = arrFileResExcludePathObjLst.Select(x => x.ExcludeDirName);

                // 8. 获取文件列表
                FileCollection objFileColl = new FileCollection();
                clsFile.GetFileListEx(strPhysicalDir, objFileColl);

                // 9. 设置服务器IP
                if (string.IsNullOrEmpty(strServerIp))
                {
                    strServerIp = System.Net.Dns.GetHostName();
                }

                // 10. 遍历文件并导入
                foreach (UserFile objUserFile in objFileColl.FileLst)
                {
                    // 10.1 检查是否在排除路径列表中
                    bool bolIsExcludedByPath = false;
                    foreach (string strExcludeDirName in arrExcludeDirName)
                    {
                        if (objUserFile.FullDirName.Contains(strExcludeDirName) == true)
                        {
                            bolIsExcludedByPath = true;
                            intIgnoredByExcludePath++;
                            break;
                        }
                    }
                    if (bolIsExcludedByPath) continue;

                    // 10.2 检查是否被 .gitignore 忽略
                    if (gitIgnoreParser != null)
                    {
                        string strFullPath = Path.Combine(objUserFile.FullDirName, objUserFile.FileName);
                        bool isDirectory = Directory.Exists(strFullPath);

                        if (gitIgnoreParser.ShouldIgnore(strFullPath, isDirectory))
                        {
                            intIgnoredByGitIgnore++;
                            continue;
                        }
                    }

                    // 10.3 创建文件资源对象
                    clsFileResourceEN objFileResource = new clsFileResourceEN();
                    objFileResource.FileDirName = objUserFile.FullDirName;
                    objFileResource.IpAddress = strServerIp;
                    objFileResource.FileName = objUserFile.FileName;
                    objFileResource.FileLength = objUserFile.FileSize;
                    objFileResource.UpdUser = strUserId;
                    objFileResource.Extension = objUserFile.Extension;
                    objFileResource.CreationTime = clsDateTime.getDateStr(objUserFile.CreationTime, 1);
                    objFileResource.LastWriteTime = clsDateTime.getDateStr(objUserFile.LastWriteTime, 1);
                    objFileResource.IsExistFile = true;
                    objFileResource.PrjId = strPrjId;
                    objFileResource.CmPrjId = strCmPrjId;

                    // 10.4 检查记录是否已存在
                    string strConditionCheck = new clsFileResourceEN()
                        .SetPrjId(objFileResource.PrjId, "=")
                        .SetCmPrjId(objFileResource.CmPrjId, "=")
                        .SetFileDirName(objFileResource.FileDirName, "=")
                        .SetFileName(objFileResource.FileName, "=")
                        .GetCombineCondition();

                    try
                    {
                        if (clsFileResourceBL.IsExistRecord(strConditionCheck) == false)
                        {
                            clsFileResourceBL.AddNewRecordBySql2(objFileResource);
                            intCount++;
                        }
                    }
                    catch (Exception objEx)
                    {
                        string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                        strMsg = string.Format(
                            "导入文件[{0}]出错！错误：[{1}]. 项目：{2} (in {3})",
                            objUserFile.FileName,
                            objEx.Message,
                            strCmPrjName,
                            clsStackTrace.GetCurrClassFunction());
                        return -1;
                    }
                }

                // 11. 生成详细的成功消息
                strMsg = string.Format(
                    "成功导入 {0} 个文件到项目[{1}]。" +
                    "{2}" +
                    "{3}",
                    intCount,
                    strCmPrjId,
                    intIgnoredByGitIgnore > 0 ? string.Format("通过 .gitignore 过滤了 {0} 个文件。", intIgnoredByGitIgnore) : "",
                    intIgnoredByExcludePath > 0 ? string.Format("通过排除路径过滤了 {0} 个文件。", intIgnoredByExcludePath) : "");

                return intCount;
            }
            catch (Exception objException)
            {
                strMsg = string.Format(
                    "导入项目文件资源时出错：{0} (in {1})",
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                return -1;
            }
        }



        /// <summary>
        /// 根据用户、电脑获取当前项目UserCodeRoot子目录中的所有相关文件并导入到数据库
        /// </summary>
        /// <param name="strUserId">用户Id</param>
        /// <param name="strMachineName">机器名（电脑名），如果为空则使用当前机器名</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strCmPrjId">Cm工程Id</param>
        /// <param name="intApplicationTypeId">应用类型Id</param>
        /// <param name="strServerIp">服务器IP地址，如果为空则使用当前主机名</param>
        /// <param name="bolUseGitIgnore">是否使用 .gitignore 文件过滤，默认为 true</param>
        /// <param name="strMsg">返回消息</param>
        /// <returns>成功导入的文件数量，失败返回-1</returns>
        public static int ImportProjectFilesFromUserCodeRootBak20260612(
            string strUserId,
            string strMachineName,
            string strPrjId,
            string strCmPrjId,
            int intApplicationTypeId,
            string strServerIp,
            bool bolUseGitIgnore,
            out string strMsg)
        {
            strMsg = string.Empty;
            int intCount = 0;
            int intIgnoredByGitIgnore = 0;
            int intIgnoredByExcludePath = 0;

            try
            {
                // 1. 验证参数
                if (string.IsNullOrEmpty(strUserId))
                {
                    strMsg = "请提供有效的用户Id";
                    return -1;
                }

                if (string.IsNullOrEmpty(strPrjId))
                {
                    strMsg = "请提供有效的工程Id";
                    return -1;
                }

                if (string.IsNullOrEmpty(strCmPrjId))
                {
                    strMsg = "请提供有效的Cm工程Id";
                    return -1;
                }

                if (intApplicationTypeId <= 0)
                {
                    strMsg = "请提供有效的应用类型Id";
                    return -1;
                }

                // 如果机器名为空，使用当前机器名
                if (string.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = Environment.MachineName;
                }

                // 2. 获取 CMProject 对象，读取 UserCodeRoot
                clsCMProjectEN objCmProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
                if (objCmProject == null)
                {
                    strMsg = string.Format("未找到CmPrjId为[{0}]的CM工程记录！", strCmPrjId);
                    return -1;
                }

                // 3. 获取 CMProjectAppRela 关联ID
                long lngCMProjectAppRelaId = clsCMProjectAppRelaBLEx.getCMProjectAppRelaId(
                    strCmPrjId,
                    intApplicationTypeId,
                    strPrjId);

                if (lngCMProjectAppRelaId <= 0)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    strMsg = string.Format(
                        "未找到CM工程:{0}(ID:{1})与应用:{2}(ID:{3})的关联配置，请检查CMProjectAppRela表！(from {4})",
                        strCmPrjName, strCmPrjId, strAppName, intApplicationTypeId,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 4. 获取用户代码项目主路径对象
                clsUserCodePrjMainPathEN objUserCodePrjMainPath =
                    clsUserCodePrjMainPathBLEx.GetObjByCMProjectAppRelaIdCache(
                        lngCMProjectAppRelaId,
                        strPrjId,
                        strUserId);

                if (objUserCodePrjMainPath == null)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    strMsg = string.Format(
                        "未找到CM工程:{0}与应用:{1}的用户:{2}在项目:{3}的代码主路径配置，请先配置UserCodePrjMainPath表！(from {4})",
                        strCmPrjName, strAppName, strUserId, strPrjId,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 5. 获取特定机器的代码路径记录
                clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName =
                    clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(
                        objUserCodePrjMainPath.UserCodePrjMainPathId,
                        strMachineName);

                if (objUserCodePrjMainPath_MachineName == null)
                {
                    strMsg = string.Format(
                        "未找到当前电脑[{0}]的项目路径配置，请先在UserCodePrjMainPath_MachineName表中配置！(from {1})",
                        strMachineName,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 6. 获取项目物理路径（根路径）
                string strPhysicalDir = objUserCodePrjMainPath_MachineName.CodePath;

                if (string.IsNullOrEmpty(strPhysicalDir))
                {
                    strMsg = string.Format("机器[{0}]的CodePath配置为空！", strMachineName);
                    return -1;
                }

                // 7. 拼接 UserCodeRoot 子目录，并标准化路径
                string strUserCodeRootDir = strPhysicalDir;
                if (objCmProject != null && string.IsNullOrEmpty(objCmProject.UserCodeRoot) == false)
                {
                    // 标准化路径：确保主路径以路径分隔符结尾
                    strPhysicalDir = strPhysicalDir.TrimEnd('\\', '/');

                    // 标准化 UserCodeRoot：去除开头和结尾的路径分隔符
                    string strUserCodeRoot = objCmProject.UserCodeRoot.Trim().TrimStart('\\', '/').TrimEnd('\\', '/');

                    // 使用 Path.Combine 组合路径（自动处理路径分隔符）
                    strUserCodeRootDir = Path.Combine(strPhysicalDir, strUserCodeRoot);

                    // 标准化最终路径（处理 ../ 和 ./ 等）
                    strUserCodeRootDir = Path.GetFullPath(strUserCodeRootDir);
                }

                if (!Directory.Exists(strUserCodeRootDir))
                {
                    strMsg = string.Format(
                        "用户代码根目录[{0}]不存在或无法访问！UserCodeRoot配置为：[{1}]",
                        strUserCodeRootDir,
                        objCmProject.UserCodeRoot ?? "(空)");
                    return -1;
                }

                // 8. 加载 .gitignore 解析器（从项目根目录加载，而不是 UserCodeRoot）
                clsGitIgnoreParser gitIgnoreParser = null;
                if (bolUseGitIgnore)
                {
                    try
                    {
                        // .gitignore 通常在项目根目录，所以从根目录加载
                        gitIgnoreParser = clsGitIgnoreParser.LoadFromDirectory(strPhysicalDir);
                    }
                    catch (Exception ex)
                    {
                        string strWarnMsg = string.Format("加载 .gitignore 文件时出现警告：{0}，将继续处理但不过滤 .gitignore 规则", ex.Message);
                        clsSysParaEN.objLog.WriteDebugLog(strWarnMsg);
                    }
                }

                // 9. 获取排除路径列表
                var arrFileResExcludePathObjLst = clsFileResExcludePathBL.GetObjLstCache();
                var arrExcludeDirName = arrFileResExcludePathObjLst.Select(x => x.ExcludeDirName);

                // 10. 获取文件列表（从 UserCodeRoot 子目录开始扫描）
                FileCollection objFileColl = new FileCollection();
                clsFile.GetFileListEx(strUserCodeRootDir, objFileColl);

                // 11. 设置服务器IP
                if (string.IsNullOrEmpty(strServerIp))
                {
                    strServerIp = System.Net.Dns.GetHostName();
                }

                // 12. 遍历文件并导入
                foreach (UserFile objUserFile in objFileColl.FileLst)
                {
                    // 12.1 检查是否在排除路径列表中
                    bool bolIsExcludedByPath = false;
                    foreach (string strExcludeDirName in arrExcludeDirName)
                    {
                        if (objUserFile.FullDirName.Contains(strExcludeDirName) == true)
                        {
                            bolIsExcludedByPath = true;
                            intIgnoredByExcludePath++;
                            break;
                        }
                    }
                    if (bolIsExcludedByPath) continue;

                    // 12.2 检查是否被 .gitignore 忽略
                    if (gitIgnoreParser != null)
                    {
                        string strFullPath = Path.Combine(objUserFile.FullDirName, objUserFile.FileName);
                        bool isDirectory = Directory.Exists(strFullPath);

                        if (gitIgnoreParser.ShouldIgnore(strFullPath, isDirectory))
                        {
                            intIgnoredByGitIgnore++;
                            continue;
                        }
                    }

                    // 12.3 创建文件资源对象
                    clsFileResourceEN objFileResource = new clsFileResourceEN();
                    objFileResource.FileDirName = objUserFile.FullDirName;
                    objFileResource.IpAddress = strServerIp;
                    objFileResource.FileName = objUserFile.FileName;
                    objFileResource.FileLength = objUserFile.FileSize;
                    objFileResource.UpdUser = strUserId;
                    objFileResource.Extension = objUserFile.Extension;
                    objFileResource.CreationTime = clsDateTime.getDateStr(objUserFile.CreationTime, 1);
                    objFileResource.LastWriteTime = clsDateTime.getDateStr(objUserFile.LastWriteTime, 1);
                    objFileResource.IsExistFile = true;
                    objFileResource.PrjId = strPrjId;
                    objFileResource.CmPrjId = strCmPrjId;

                    // 12.4 检查记录是否已存在
                    string strConditionCheck = new clsFileResourceEN()
                        .SetPrjId(objFileResource.PrjId, "=")
                        .SetCmPrjId(objFileResource.CmPrjId, "=")
                        .SetFileDirName(objFileResource.FileDirName, "=")
                        .SetFileName(objFileResource.FileName, "=")
                        .GetCombineCondition();

                    try
                    {
                        if (clsFileResourceBL.IsExistRecord(strConditionCheck) == false)
                        {
                            clsFileResourceBL.AddNewRecordBySql2(objFileResource);
                            intCount++;
                        }
                    }
                    catch (Exception objEx)
                    {
                        string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                        strMsg = string.Format(
                            "导入文件[{0}]出错！错误：[{1}]. 项目：{2} (in {3})",
                            objUserFile.FileName,
                            objEx.Message,
                            strCmPrjName,
                            clsStackTrace.GetCurrClassFunction());
                        return -1;
                    }
                }

                // 13. 生成详细的成功消息
                strMsg = string.Format(
                    "成功从UserCodeRoot目录[{0}]导入 {1} 个文件到项目[{2}]。" +
                    "{3}" +
                    "{4}",
                    objCmProject.UserCodeRoot ?? "(根目录)",
                    intCount,
                    strCmPrjId,
                    intIgnoredByGitIgnore > 0 ? string.Format("通过 .gitignore 过滤了 {0} 个文件。", intIgnoredByGitIgnore) : "",
                    intIgnoredByExcludePath > 0 ? string.Format("通过排除路径过滤了 {0} 个文件。", intIgnoredByExcludePath) : "");

                return intCount;
            }
            catch (Exception objException)
            {
                strMsg = string.Format(
                    "从UserCodeRoot导入项目文件资源时出错：{0} (in {1})",
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                return -1;
            }
        }

        /// <summary>
        /// 统计UserCodeRoot子目录中符合导入条件的文件数量（不实际导入）
        /// </summary>
        /// <param name="strUserId">用户Id</param>
        /// <param name="strMachineName">机器名（电脑名），如果为空则使用当前机器名</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strCmPrjId">Cm工程Id</param>
        /// <param name="intApplicationTypeId">应用类型Id</param>
        /// <param name="bolUseGitIgnore">是否使用 .gitignore 文件过滤，默认为 true</param>
        /// <param name="strMsg">返回消息</param>
        /// <param name="intTotalFiles">输出：扫描到的文件总数</param>
        /// <param name="intIgnoredByGitIgnore">输出：被 .gitignore 过滤的文件数</param>
        /// <param name="intIgnoredByExcludePath">输出：被排除路径过滤的文件数</param>
        /// <param name="intAlreadyExists">输出：数据库中已存在的文件数</param>
        /// <returns>将要导入的文件数量，失败返回-1</returns>
        public static int CountProjectFilesFromUserCodeRoot(
            string strUserId,
            string strMachineName,
            string strPrjId,
            string strCmPrjId,
            int intApplicationTypeId,
            bool bolUseGitIgnore,
            out string strMsg,
            out int intTotalFiles,
            out int intIgnoredByGitIgnore,
            out int intIgnoredByExcludePath,
            out int intAlreadyExists)
        {
            strMsg = string.Empty;
            intTotalFiles = 0;
            intIgnoredByGitIgnore = 0;
            intIgnoredByExcludePath = 0;
            intAlreadyExists = 0;
            int intWillImport = 0;

            try
            {
                // 1. 验证参数
                if (string.IsNullOrEmpty(strUserId))
                {
                    strMsg = "请提供有效的用户Id";
                    return -1;
                }

                if (string.IsNullOrEmpty(strPrjId))
                {
                    strMsg = "请提供有效的工程Id";
                    return -1;
                }

                if (string.IsNullOrEmpty(strCmPrjId))
                {
                    strMsg = "请提供有效的Cm工程Id";
                    return -1;
                }

                if (intApplicationTypeId <= 0)
                {
                    strMsg = "请提供有效的应用类型Id";
                    return -1;
                }

                // 如果机器名为空，使用当前机器名
                if (string.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = Environment.MachineName;
                }

                // 2. 获取 CMProject 对象，读取 UserCodeRoot
                clsCMProjectEN objCmProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
                if (objCmProject == null)
                {
                    strMsg = string.Format("未找到CmPrjId为[{0}]的CM工程记录！", strCmPrjId);
                    return -1;
                }

                // 3. 获取 CMProjectAppRela 关联ID
                long lngCMProjectAppRelaId = clsCMProjectAppRelaBLEx.getCMProjectAppRelaId(
                    strCmPrjId,
                    intApplicationTypeId,
                    strPrjId);

                if (lngCMProjectAppRelaId <= 0)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    strMsg = string.Format(
                        "未找到CM工程:{0}(ID:{1})与应用:{2}(ID:{3})的关联配置，请检查CMProjectAppRela表！(from {4})",
                        strCmPrjName, strCmPrjId, strAppName, intApplicationTypeId,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 4. 获取用户代码项目主路径对象
                clsUserCodePrjMainPathEN objUserCodePrjMainPath =
                    clsUserCodePrjMainPathBLEx.GetObjByCMProjectAppRelaIdCache(
                        lngCMProjectAppRelaId,
                        strPrjId,
                        strUserId);

                if (objUserCodePrjMainPath == null)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    strMsg = string.Format(
                        "未找到CM工程:{0}与应用:{1}的用户:{2}在项目:{3}的代码主路径配置，请先配置UserCodePrjMainPath表！(from {4})",
                        strCmPrjName, strAppName, strUserId, strPrjId,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 5. 获取特定机器的代码路径记录
                clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName =
                    clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(
                        objUserCodePrjMainPath.UserCodePrjMainPathId,
                        strMachineName);

                if (objUserCodePrjMainPath_MachineName == null)
                {
                    strMsg = string.Format(
                        "未找到当前电脑[{0}]的项目路径配置，请先在UserCodePrjMainPath_MachineName表中配置！(from {1})",
                        strMachineName,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 6. 获取项目物理路径（根路径）
                string strPhysicalDir = objUserCodePrjMainPath_MachineName.CodePath;

                if (string.IsNullOrEmpty(strPhysicalDir))
                {
                    strMsg = string.Format("机器[{0}]的CodePath配置为空！", strMachineName);
                    return -1;
                }

                // 7. 拼接 UserCodeRoot 子目录，并标准化路径
                string strUserCodeRootDir = strPhysicalDir;
                if (objCmProject != null && string.IsNullOrEmpty(objCmProject.UserCodeRoot) == false)
                {
                    // 标准化路径：确保主路径以路径分隔符结尾
                    strPhysicalDir = strPhysicalDir.TrimEnd('\\', '/');

                    // 标准化 UserCodeRoot：去除开头和结尾的路径分隔符
                    string strUserCodeRoot = objCmProject.UserCodeRoot.Trim().TrimStart('\\', '/').TrimEnd('\\', '/');

                    // 使用 Path.Combine 组合路径（自动处理路径分隔符）
                    strUserCodeRootDir = Path.Combine(strPhysicalDir, strUserCodeRoot);

                    // 标准化最终路径（处理 ../ 和 ./ 等）
                    strUserCodeRootDir = Path.GetFullPath(strUserCodeRootDir);
                }

                if (!Directory.Exists(strUserCodeRootDir))
                {
                    strMsg = string.Format(
                        "用户代码根目录[{0}]不存在或无法访问！UserCodeRoot配置为：[{1}]",
                        strUserCodeRootDir,
                        objCmProject.UserCodeRoot ?? "(空)");
                    return -1;
                }

                // 8. 加载 .gitignore 解析器（从项目根目录加载）
                clsGitIgnoreParser gitIgnoreParser = null;
                if (bolUseGitIgnore)
                {
                    try
                    {
                        gitIgnoreParser = clsGitIgnoreParser.LoadFromDirectory(strPhysicalDir);
                    }
                    catch (Exception ex)
                    {
                        string strWarnMsg = string.Format("加载 .gitignore 文件时出现警告：{0}，将继续处理但不过滤 .gitignore 规则", ex.Message);
                        clsSysParaEN.objLog.WriteDebugLog(strWarnMsg);
                    }
                }

                // 9. 获取排除路径列表
                var arrFileResExcludePathObjLst = clsFileResExcludePathBL.GetObjLstCache();
                var arrExcludeDirName = arrFileResExcludePathObjLst.Select(x => x.ExcludeDirName);

                // 10. 获取文件列表（从 UserCodeRoot 子目录开始扫描）
                FileCollection objFileColl = new FileCollection();
                clsFile.GetFileListEx(strUserCodeRootDir, objFileColl);

                intTotalFiles = objFileColl.FileLst.Count;

                // 11. 遍历文件并统计
                foreach (UserFile objUserFile in objFileColl.FileLst)
                {
                    // 11.1 检查是否在排除路径列表中
                    bool bolIsExcludedByPath = false;
                    foreach (string strExcludeDirName in arrExcludeDirName)
                    {
                        if (objUserFile.FullDirName.Contains(strExcludeDirName) == true)
                        {
                            bolIsExcludedByPath = true;
                            intIgnoredByExcludePath++;
                            break;
                        }
                    }
                    if (bolIsExcludedByPath) continue;

                    // 11.2 检查是否被 .gitignore 忽略
                    if (gitIgnoreParser != null)
                    {
                        string strFullPath = Path.Combine(objUserFile.FullDirName, objUserFile.FileName);
                        bool isDirectory = Directory.Exists(strFullPath);

                        if (gitIgnoreParser.ShouldIgnore(strFullPath, isDirectory))
                        {
                            intIgnoredByGitIgnore++;
                            continue;
                        }
                    }

                    // 11.3 检查记录是否已存在
                    string strConditionCheck = new clsFileResourceEN()
                        .SetPrjId(strPrjId, "=")
                        .SetCmPrjId(strCmPrjId, "=")
                        .SetFileDirName(objUserFile.FullDirName, "=")
                        .SetFileName(objUserFile.FileName, "=")
                        .GetCombineCondition();

                    try
                    {
                        if (clsFileResourceBL.IsExistRecord(strConditionCheck) == true)
                        {
                            intAlreadyExists++;
                        }
                        else
                        {
                            intWillImport++;
                        }
                    }
                    catch (Exception objEx)
                    {
                        string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                        strMsg = string.Format(
                            "检查文件[{0}]时出错！错误：[{1}]. 项目：{2} (in {3})",
                            objUserFile.FileName,
                            objEx.Message,
                            strCmPrjName,
                            clsStackTrace.GetCurrClassFunction());
                        return -1;
                    }
                }

                // 12. 生成详细的统计消息
                strMsg = string.Format(
                    "UserCodeRoot目录[{0}]文件统计结果：\r\n" +
                    "扫描路径：{1}\r\n" +
                    "扫描文件总数：{2}\r\n" +
                    "将要导入：{3}\r\n" +
                    "已存在数据库：{4}\r\n" +
                    ".gitignore过滤：{5}\r\n" +
                    "排除路径过滤：{6}",
                    objCmProject.UserCodeRoot ?? "(根目录)",
                    strUserCodeRootDir,
                    intTotalFiles,
                    intWillImport,
                    intAlreadyExists,
                    intIgnoredByGitIgnore,
                    intIgnoredByExcludePath);

                return intWillImport;
            }
            catch (Exception objException)
            {
                strMsg = string.Format(
                    "统计UserCodeRoot目录文件时出错：{0} (in {1})",
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                return -1;
            }
        }
        /// <summary>
        /// 统计符合导入条件的文件数量（不实际导入）
        /// </summary>
        /// <param name="strUserId">用户Id</param>
        /// <param name="strMachineName">机器名（电脑名），如果为空则使用当前机器名</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strCmPrjId">Cm工程Id</param>
        /// <param name="intApplicationTypeId">应用类型Id</param>
        /// <param name="bolUseGitIgnore">是否使用 .gitignore 文件过滤，默认为 true</param>
        /// <param name="strMsg">返回消息</param>
        /// <param name="intTotalFiles">输出：扫描到的文件总数</param>
        /// <param name="intIgnoredByGitIgnore">输出：被 .gitignore 过滤的文件数</param>
        /// <param name="intIgnoredByExcludePath">输出：被排除路径过滤的文件数</param>
        /// <param name="intAlreadyExists">输出：数据库中已存在的文件数</param>
        /// <returns>将要导入的文件数量，失败返回-1</returns>
        public static int CountProjectFilesToImport(
            string strUserId,
            string strMachineName,
            string strPrjId,
            string strCmPrjId,
            int intApplicationTypeId,
            bool bolUseGitIgnore,
            out string strMsg,
            out int intTotalFiles,
            out int intIgnoredByGitIgnore,
            out int intIgnoredByExcludePath,
            out int intAlreadyExists)
        {
            strMsg = string.Empty;
            intTotalFiles = 0;
            intIgnoredByGitIgnore = 0;
            intIgnoredByExcludePath = 0;
            intAlreadyExists = 0;
            int intWillImport = 0;

            try
            {
                // 1. 验证参数
                if (string.IsNullOrEmpty(strUserId))
                {
                    strMsg = "请提供有效的用户Id";
                    return -1;
                }

                if (string.IsNullOrEmpty(strPrjId))
                {
                    strMsg = "请提供有效的工程Id";
                    return -1;
                }

                if (string.IsNullOrEmpty(strCmPrjId))
                {
                    strMsg = "请提供有效的Cm工程Id";
                    return -1;
                }

                if (intApplicationTypeId <= 0)
                {
                    strMsg = "请提供有效的应用类型Id";
                    return -1;
                }

                // 如果机器名为空，使用当前机器名
                if (string.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = Environment.MachineName;
                }

                // 2. 获取 CMProjectAppRela 关联ID
                long lngCMProjectAppRelaId = clsCMProjectAppRelaBLEx.getCMProjectAppRelaId(
                    strCmPrjId,
                    intApplicationTypeId,
                    strPrjId);

                if (lngCMProjectAppRelaId <= 0)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    strMsg = string.Format(
                        "未找到CM工程:{0}(ID:{1})与应用:{2}(ID:{3})的关联配置，请检查CMProjectAppRela表！(from {4})",
                        strCmPrjName, strCmPrjId, strAppName, intApplicationTypeId,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 3. 获取用户代码项目主路径对象
                clsUserCodePrjMainPathEN objUserCodePrjMainPath =
                    clsUserCodePrjMainPathBLEx.GetObjByCMProjectAppRelaIdCache(
                        lngCMProjectAppRelaId,
                        strPrjId,
                        strUserId);

                if (objUserCodePrjMainPath == null)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    strMsg = string.Format(
                        "未找到CM工程:{0}与应用:{1}的用户:{2}在项目:{3}的代码主路径配置，请先配置UserCodePrjMainPath表！(from {4})",
                        strCmPrjName, strAppName, strUserId, strPrjId,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 4. 获取特定机器的代码路径记录
                clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName =
                    clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(
                        objUserCodePrjMainPath.UserCodePrjMainPathId,
                        strMachineName);

                if (objUserCodePrjMainPath_MachineName == null)
                {
                    strMsg = string.Format(
                        "未找到当前电脑[{0}]的项目路径配置，请先在UserCodePrjMainPath_MachineName表中配置！(from {1})",
                        strMachineName,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 5. 获取项目物理路径
                string strPhysicalDir = objUserCodePrjMainPath_MachineName.CodePath;

                if (string.IsNullOrEmpty(strPhysicalDir))
                {
                    strMsg = string.Format("机器[{0}]的CodePath配置为空！", strMachineName);
                    return -1;
                }

                if (!Directory.Exists(strPhysicalDir))
                {
                    strMsg = string.Format("项目物理路径[{0}]不存在或无法访问！", strPhysicalDir);
                    return -1;
                }

                // 6. 加载 .gitignore 解析器（如果启用）
                clsGitIgnoreParser gitIgnoreParser = null;
                if (bolUseGitIgnore)
                {
                    try
                    {
                        gitIgnoreParser = clsGitIgnoreParser.LoadFromDirectory(strPhysicalDir);
                    }
                    catch (Exception ex)
                    {
                        string strWarnMsg = string.Format("加载 .gitignore 文件时出现警告：{0}，将继续处理但不过滤 .gitignore 规则", ex.Message);
                        clsSysParaEN.objLog.WriteDebugLog(strWarnMsg);
                    }
                }

                // 7. 获取排除路径列表
                var arrFileResExcludePathObjLst = clsFileResExcludePathBL.GetObjLstCache();
                var arrExcludeDirName = arrFileResExcludePathObjLst.Select(x => x.ExcludeDirName);

                // 8. 获取文件列表
                FileCollection objFileColl = new FileCollection();
                clsFile.GetFileListEx(strPhysicalDir, objFileColl);

                intTotalFiles = objFileColl.FileLst.Count;

                // 9. 遍历文件并统计
                foreach (UserFile objUserFile in objFileColl.FileLst)
                {
                    // 9.1 检查是否在排除路径列表中
                    bool bolIsExcludedByPath = false;
                    foreach (string strExcludeDirName in arrExcludeDirName)
                    {
                        if (objUserFile.FullDirName.Contains(strExcludeDirName) == true)
                        {
                            bolIsExcludedByPath = true;
                            intIgnoredByExcludePath++;
                            break;
                        }
                    }
                    if (bolIsExcludedByPath) continue;

                    // 9.2 检查是否被 .gitignore 忽略
                    if (gitIgnoreParser != null)
                    {
                        string strFullPath = Path.Combine(objUserFile.FullDirName, objUserFile.FileName);
                        bool isDirectory = Directory.Exists(strFullPath);

                        if (gitIgnoreParser.ShouldIgnore(strFullPath, isDirectory))
                        {
                            intIgnoredByGitIgnore++;
                            continue;
                        }
                    }

                    // 9.3 检查记录是否已存在
                    string strConditionCheck = new clsFileResourceEN()
                        .SetPrjId(strPrjId, "=")
                        .SetCmPrjId(strCmPrjId, "=")
                        .SetFileDirName(objUserFile.FullDirName, "=")
                        .SetFileName(objUserFile.FileName, "=")
                        .GetCombineCondition();

                    try
                    {
                        if (clsFileResourceBL.IsExistRecord(strConditionCheck) == true)
                        {
                            intAlreadyExists++;
                        }
                        else
                        {
                            intWillImport++;
                        }
                    }
                    catch (Exception objEx)
                    {
                        string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                        strMsg = string.Format(
                            "检查文件[{0}]时出错！错误：[{1}]. 项目：{2} (in {3})",
                            objUserFile.FileName,
                            objEx.Message,
                            strCmPrjName,
                            clsStackTrace.GetCurrClassFunction());
                        return -1;
                    }
                }

                // 10. 生成详细的统计消息
                strMsg = string.Format(
                    "文件统计结果：\r\n" +
                    "扫描文件总数：{0}\r\n" +
                    "将要导入：{1}\r\n" +
                    "已存在数据库：{2}\r\n" +
                    ".gitignore过滤：{3}\r\n" +
                    "排除路径过滤：{4}",
                    intTotalFiles,
                    intWillImport,
                    intAlreadyExists,
                    intIgnoredByGitIgnore,
                    intIgnoredByExcludePath);

                return intWillImport;
            }
            catch (Exception objException)
            {
                strMsg = string.Format(
                    "统计项目文件时出错：{0} (in {1})",
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                return -1;
            }
        }

        /// <summary>
        /// 统计符合导入条件的文件数量（简化版本，只返回将要导入的数量）
        /// </summary>
        /// <param name="strUserId">用户Id</param>
        /// <param name="strMachineName">机器名（电脑名），如果为空则使用当前机器名</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strCmPrjId">Cm工程Id</param>
        /// <param name="intApplicationTypeId">应用类型Id</param>
        /// <param name="bolUseGitIgnore">是否使用 .gitignore 文件过滤，默认为 true</param>
        /// <param name="strMsg">返回消息</param>
        /// <returns>将要导入的文件数量，失败返回-1</returns>
        public static int CountProjectFilesToImportSimple(
            string strUserId,
            string strMachineName,
            string strPrjId,
            string strCmPrjId,
            int intApplicationTypeId,
            bool bolUseGitIgnore,
            out string strMsg)
        {
            int intTotalFiles, intIgnoredByGitIgnore, intIgnoredByExcludePath, intAlreadyExists;

            return CountProjectFilesToImport(
                strUserId,
                strMachineName,
                strPrjId,
                strCmPrjId,
                intApplicationTypeId,
                bolUseGitIgnore,
                out strMsg,
                out intTotalFiles,
                out intIgnoredByGitIgnore,
                out intIgnoredByExcludePath,
                out intAlreadyExists);
        }

     
        /// <summary>
        /// 批量获取文件的CodeTypeId字典（优化性能）
        /// </summary>
        /// <param name="arrFileName">文件名列表</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>文件名到CodeTypeId的字典</returns>
        private static Dictionary<string, string> GetCodeTypeIdDictionaryBak20260612(List<string> arrFileName, string strPrjId)
        {
            Dictionary<string, string> dictCodeTypeId = new Dictionary<string, string>();

            try
            {
                // 获取所有CodeType缓存（一次性获取，避免重复查询）
                var arrCodeType = clsCodeTypeBL.GetObjLstCache();

                // 编译所有正则表达式
                var arrCompiledRegex = new List<Tuple<string, System.Text.RegularExpressions.Regex>>();
                foreach (var objCodeType in arrCodeType)
                {
                    if (string.IsNullOrEmpty(objCodeType.ClassNamePattern))
                        continue;

                    try
                    {
                        var regex = new System.Text.RegularExpressions.Regex(
                            objCodeType.ClassNamePattern,
                            System.Text.RegularExpressions.RegexOptions.IgnoreCase |
                            System.Text.RegularExpressions.RegexOptions.Compiled);

                        arrCompiledRegex.Add(new Tuple<string, System.Text.RegularExpressions.Regex>(
                            objCodeType.CodeTypeId, regex));
                    }
                    catch
                    {
                        continue;
                    }
                }

                // 为每个文件名匹配CodeTypeId
                foreach (string strFileName in arrFileName)
                {
                    string strFileNameWithoutExt = Path.GetFileNameWithoutExtension(strFileName);
                    string strCodeTypeId = "0000"; // 默认值

                    // 尝试匹配每个正则表达式
                    foreach (var tuple in arrCompiledRegex)
                    {
                        try
                        {
                            if (tuple.Item2.IsMatch(strFileNameWithoutExt))
                            {
                                strCodeTypeId = tuple.Item1;
                                break; // 找到第一个匹配就停止
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    dictCodeTypeId[strFileName] = strCodeTypeId;
                }
            }
            catch (Exception ex)
            {
                clsSysParaEN.objLog.WriteDebugLog($"批量匹配CodeTypeId时出错：{ex.Message}");
            }

            return dictCodeTypeId;
        }

        /// <summary>
        /// 根据用户、电脑获取当前项目中的所有相关文件并导入到数据库（增强版：包含CodeTypeId识别）
        /// </summary>
        /// <param name="strUserId">用户Id</param>
        /// <param name="strMachineName">机器名（电脑名），如果为空则使用当前机器名</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strCmPrjId">Cm工程Id</param>
        /// <param name="intApplicationTypeId">应用类型Id</param>
        /// <param name="strServerIp">服务器IP地址，如果为空则使用当前主机名</param>
        /// <param name="bolUseGitIgnore">是否使用 .gitignore 文件过滤，默认为 true</param>
        /// <param name="strMsg">返回消息</param>
        /// <returns>成功导入的文件数量，失败返回-1</returns>
        public static int ImportProjectFilesByUserAndComputer(
            string strUserId,
            string strMachineName,
            string strPrjId,
            string strCmPrjId,
            int intApplicationTypeId,
            string strServerIp,
            bool bolUseGitIgnore,
            out string strMsg)
        {
            strMsg = string.Empty;
            int intCount = 0;
            int intIgnoredByGitIgnore = 0;
            int intIgnoredByExcludePath = 0;

            try
            {
                // 1. 验证参数
                if (string.IsNullOrEmpty(strUserId))
                {
                    strMsg = "请提供有效的用户Id";
                    return -1;
                }

                if (string.IsNullOrEmpty(strPrjId))
                {
                    strMsg = "请提供有效的工程Id";
                    return -1;
                }

                if (string.IsNullOrEmpty(strCmPrjId))
                {
                    strMsg = "请提供有效的Cm工程Id";
                    return -1;
                }

                if (intApplicationTypeId <= 0)
                {
                    strMsg = "请提供有效的应用类型Id";
                    return -1;
                }

                // 如果机器名为空，使用当前机器名
                if (string.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = Environment.MachineName;
                }

                // 2. 获取 CMProjectAppRela 关联ID
                long lngCMProjectAppRelaId = clsCMProjectAppRelaBLEx.getCMProjectAppRelaId(
                    strCmPrjId,
                    intApplicationTypeId,
                    strPrjId);

                if (lngCMProjectAppRelaId <= 0)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    strMsg = string.Format(
                        "未找到CM工程:{0}(ID:{1})与应用:{2}(ID:{3})的关联配置，请检查CMProjectAppRela表！(from {4})",
                        strCmPrjName, strCmPrjId, strAppName, intApplicationTypeId,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 3. 获取用户代码项目主路径对象
                clsUserCodePrjMainPathEN objUserCodePrjMainPath =
                    clsUserCodePrjMainPathBLEx.GetObjByCMProjectAppRelaIdCache(
                        lngCMProjectAppRelaId,
                        strPrjId,
                        strUserId);

                if (objUserCodePrjMainPath == null)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    strMsg = string.Format(
                        "未找到CM工程:{0}与应用:{1}的用户:{2}在项目:{3}的代码主路径配置，请先配置UserCodePrjMainPath表！(from {4})",
                        strCmPrjName, strAppName, strUserId, strPrjId,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 4. 获取特定机器的代码路径记录
                clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName =
                    clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(
                        objUserCodePrjMainPath.UserCodePrjMainPathId,
                        strMachineName);

                if (objUserCodePrjMainPath_MachineName == null)
                {
                    strMsg = string.Format(
                        "未找到当前电脑[{0}]的项目路径配置，请先在UserCodePrjMainPath_MachineName表中配置！(from {1})",
                        strMachineName,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 5. 获取项目物理路径
                string strPhysicalDir = objUserCodePrjMainPath_MachineName.CodePath;

                if (string.IsNullOrEmpty(strPhysicalDir))
                {
                    strMsg = string.Format("机器[{0}]的CodePath配置为空！", strMachineName);
                    return -1;
                }

                if (!Directory.Exists(strPhysicalDir))
                {
                    strMsg = string.Format("项目物理路径[{0}]不存在或无法访问！", strPhysicalDir);
                    return -1;
                }

                // 6. 加载 .gitignore 解析器（如果启用）
                clsGitIgnoreParser gitIgnoreParser = null;
                if (bolUseGitIgnore)
                {
                    try
                    {
                        gitIgnoreParser = clsGitIgnoreParser.LoadFromDirectory(strPhysicalDir);
                    }
                    catch (Exception ex)
                    {
                        string strWarnMsg = string.Format("加载 .gitignore 文件时出现警告：{0}，将继续处理但不过滤 .gitignore 规则", ex.Message);
                        clsSysParaEN.objLog.WriteDebugLog(strWarnMsg);
                    }
                }

                // 7. 获取排除路径列表
                var arrFileResExcludePathObjLst = clsFileResExcludePathBL.GetObjLstCache();
                var arrExcludeDirName = arrFileResExcludePathObjLst.Select(x => x.ExcludeDirName);

                // 8. 获取文件列表
                FileCollection objFileColl = new FileCollection();
                clsFile.GetFileListEx(strPhysicalDir, objFileColl);

                // 9. 预先批量获取所有文件的CodeTypeId（性能优化）
                var arrAllFileNames = objFileColl.FileLst.Select(x => x.FileName).ToList();
                var dictCodeTypeId = GetCodeTypeIdDictionary(arrAllFileNames, strPrjId);

                // 10. 设置服务器IP
                if (string.IsNullOrEmpty(strServerIp))
                {
                    strServerIp = System.Net.Dns.GetHostName();
                }

                // 11. 遍历文件并导入
                foreach (UserFile objUserFile in objFileColl.FileLst)
                {
                    // 11.1 检查是否在排除路径列表中
                    bool bolIsExcludedByPath = false;
                    foreach (string strExcludeDirName in arrExcludeDirName)
                    {
                        if (objUserFile.FullDirName.Contains(strExcludeDirName) == true)
                        {
                            bolIsExcludedByPath = true;
                            intIgnoredByExcludePath++;
                            break;
                        }
                    }
                    if (bolIsExcludedByPath) continue;

                    // 11.2 检查是否被 .gitignore 忽略
                    if (gitIgnoreParser != null)
                    {
                        string strFullPath = Path.Combine(objUserFile.FullDirName, objUserFile.FileName);
                        bool isDirectory = Directory.Exists(strFullPath);

                        if (gitIgnoreParser.ShouldIgnore(strFullPath, isDirectory))
                        {
                            intIgnoredByGitIgnore++;
                            continue;
                        }
                    }

                    // 11.3 获取CodeTypeId
                    string strCodeTypeId = "0000"; // 默认值
                    if (dictCodeTypeId.ContainsKey(objUserFile.FileName))
                    {
                        strCodeTypeId = dictCodeTypeId[objUserFile.FileName];
                    }

                    // 11.4 创建文件资源对象
                    clsFileResourceEN objFileResource = new clsFileResourceEN();
                    objFileResource.FileDirName = objUserFile.FullDirName;
                    objFileResource.IpAddress = strServerIp;
                    objFileResource.FileName = objUserFile.FileName;
                    objFileResource.FileLength = objUserFile.FileSize;
                    objFileResource.UpdUser = strUserId;
                    objFileResource.Extension = objUserFile.Extension;
                    objFileResource.CreationTime = clsDateTime.getDateStr(objUserFile.CreationTime, 1);
                    objFileResource.LastWriteTime = clsDateTime.getDateStr(objUserFile.LastWriteTime, 1);
                    objFileResource.IsExistFile = true;
                    objFileResource.PrjId = strPrjId;
                    objFileResource.CmPrjId = strCmPrjId;
                    objFileResource.CodeTypeId = strCodeTypeId; // 设置CodeTypeId

                    // 11.5 检查记录是否已存在
                    string strConditionCheck = new clsFileResourceEN()
                        .SetPrjId(objFileResource.PrjId, "=")
                        .SetCmPrjId(objFileResource.CmPrjId, "=")
                        .SetFileDirName(objFileResource.FileDirName, "=")
                        .SetFileName(objFileResource.FileName, "=")
                        .GetCombineCondition();

                    try
                    {
                        if (clsFileResourceBL.IsExistRecord(strConditionCheck) == false)
                        {
                            clsFileResourceBL.AddNewRecordBySql2(objFileResource);
                            intCount++;
                        }
                        else
                        {
                            // 如果记录已存在，更新CodeTypeId
                            var objExisting = clsFileResourceBL.GetFirstObj_S(strConditionCheck);
                            if (objExisting != null && objExisting.CodeTypeId != strCodeTypeId)
                            {
                                objExisting.CodeTypeId = strCodeTypeId;
                                objExisting.UpdUser = strUserId;
                                objExisting.Update();
                            }
                        }
                    }
                    catch (Exception objEx)
                    {
                        string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                        strMsg = string.Format(
                            "导入文件[{0}]出错！错误：[{1}]. 项目：{2} (in {3})",
                            objUserFile.FileName,
                            objEx.Message,
                            strCmPrjName,
                            clsStackTrace.GetCurrClassFunction());
                        return -1;
                    }
                }

                // 12. 生成详细的成功消息
                strMsg = string.Format(
                    "成功导入 {0} 个文件到项目[{1}]。" +
                    "{2}" +
                    "{3}",
                    intCount,
                    strCmPrjId,
                    intIgnoredByGitIgnore > 0 ? string.Format("通过 .gitignore 过滤了 {0} 个文件。", intIgnoredByGitIgnore) : "",
                    intIgnoredByExcludePath > 0 ? string.Format("通过排除路径过滤了 {0} 个文件。", intIgnoredByExcludePath) : "");

                return intCount;
            }
            catch (Exception objException)
            {
                strMsg = string.Format(
                    "导入项目文件资源时出错：{0} (in {1})",
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                return -1;
            }
        }

     
        /// <summary>
        /// 批量从文件名中提取表名并获取TabId
        /// </summary>
        /// <param name="dictCodeTypeId">文件名到CodeTypeId的字典</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>文件名到TabId的字典</returns>
        private static Dictionary<string, string> GetTabIdDictionary(
            Dictionary<string, string> dictCodeTypeId,
            string strPrjId)
        {
            Dictionary<string, string> dictTabId = new Dictionary<string, string>();

            try
            {
                foreach (var kvp in dictCodeTypeId)
                {
                    string strFileName = kvp.Key;
                    string strCodeTypeId = kvp.Value;

                    // 从文件名中提取表名
                    string strTabName = ExtractTabNameFromFileName(strFileName, strCodeTypeId, strPrjId);

                    if (!string.IsNullOrEmpty(strTabName))
                    {
                        // 根据表名获取TabId
                        string strTabId = clsPrjTabBLEx.GetTabIdByTabNameCache(strPrjId, strTabName);

                        if (!string.IsNullOrEmpty(strTabId))
                        {
                            dictTabId[strFileName] = strTabId;
                        }
                        else
                        {
                            dictTabId[strFileName] = "";
                        }
                    }
                    else
                    {
                        dictTabId[strFileName] = "";
                    }
                }
            }
            catch (Exception ex)
            {
                clsSysParaEN.objLog.WriteDebugLog($"批量获取TabId时出错：{ex.Message}");
            }

            return dictTabId;
        }

        /// <summary>
        /// 根据用户、电脑获取UserCodeRoot子目录中的所有相关文件并导入到数据库（增强版：包含CodeTypeId和TabId识别）
        /// </summary>
        /// <param name="strUserId">用户Id</param>
        /// <param name="strMachineName">机器名（电脑名），如果为空则使用当前机器名</param>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strCmPrjId">Cm工程Id</param>
        /// <param name="intApplicationTypeId">应用类型Id</param>
        /// <param name="strServerIp">服务器IP地址，如果为空则使用当前主机名</param>
        /// <param name="bolUseGitIgnore">是否使用 .gitignore 文件过滤，默认为 true</param>
        /// <param name="strMsg">返回消息</param>
        /// <returns>成功导入的文件数量，失败返回-1</returns>
        public static int ImportProjectFilesFromUserCodeRoot(
            string strUserId,
            string strMachineName,
            string strPrjId,
            string strCmPrjId,
            int intApplicationTypeId,
            string strServerIp,
            bool bolUseGitIgnore,
            out string strMsg)
        {
            strMsg = string.Empty;
            int intCount = 0;
            int intIgnoredByGitIgnore = 0;
            int intIgnoredByExcludePath = 0;
            int intCodeTypeIdMatched = 0;
            int intTabIdMatched = 0;

            try
            {
                // 1. 验证参数
                if (string.IsNullOrEmpty(strUserId))
                {
                    strMsg = "请提供有效的用户Id";
                    return -1;
                }

                if (string.IsNullOrEmpty(strPrjId))
                {
                    strMsg = "请提供有效的工程Id";
                    return -1;
                }

                if (string.IsNullOrEmpty(strCmPrjId))
                {
                    strMsg = "请提供有效的Cm工程Id";
                    return -1;
                }

                if (intApplicationTypeId <= 0)
                {
                    strMsg = "请提供有效的应用类型Id";
                    return -1;
                }

                // 如果机器名为空，使用当前机器名
                if (string.IsNullOrEmpty(strMachineName))
                {
                    strMachineName = Environment.MachineName;
                }

                // 2. 获取 CMProject 对象，读取 UserCodeRoot
                clsCMProjectEN objCmProject = clsCMProjectBL.GetObjByCmPrjIdCache(strCmPrjId);
                if (objCmProject == null)
                {
                    strMsg = string.Format("未找到CmPrjId为[{0}]的CM工程记录！", strCmPrjId);
                    return -1;
                }

                // 3. 获取 CMProjectAppRela 关联ID
                long lngCMProjectAppRelaId = clsCMProjectAppRelaBLEx.getCMProjectAppRelaId(
                    strCmPrjId,
                    intApplicationTypeId,
                    strPrjId);

                if (lngCMProjectAppRelaId <= 0)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    strMsg = string.Format(
                        "未找到CM工程:{0}(ID:{1})与应用:{2}(ID:{3})的关联配置，请检查CMProjectAppRela表！(from {4})",
                        strCmPrjName, strCmPrjId, strAppName, intApplicationTypeId,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 4. 获取用户代码项目主路径对象
                clsUserCodePrjMainPathEN objUserCodePrjMainPath =
                    clsUserCodePrjMainPathBLEx.GetObjByCMProjectAppRelaIdCache(
                        lngCMProjectAppRelaId,
                        strPrjId,
                        strUserId);

                if (objUserCodePrjMainPath == null)
                {
                    string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                    string strAppName = clsApplicationTypeBL.GetNameByApplicationTypeIdCache(intApplicationTypeId);

                    strMsg = string.Format(
                        "未找到CM工程:{0}与应用:{1}的用户:{2}在项目:{3}的代码主路径配置，请先配置UserCodePrjMainPath表！(from {4})",
                        strCmPrjName, strAppName, strUserId, strPrjId,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 5. 获取特定机器的代码路径记录
                clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName =
                    clsUserCodePrjMainPath_MachineNameBL.GetObjByKeyLst(
                        objUserCodePrjMainPath.UserCodePrjMainPathId,
                        strMachineName);

                if (objUserCodePrjMainPath_MachineName == null)
                {
                    strMsg = string.Format(
                        "未找到当前电脑[{0}]的项目路径配置，请先在UserCodePrjMainPath_MachineName表中配置！(from {1})",
                        strMachineName,
                        clsStackTrace.GetCurrClassFunction());
                    return -1;
                }

                // 6. 获取项目物理路径（根路径）
                string strPhysicalDir = objUserCodePrjMainPath_MachineName.CodePath;

                if (string.IsNullOrEmpty(strPhysicalDir))
                {
                    strMsg = string.Format("机器[{0}]的CodePath配置为空！", strMachineName);
                    return -1;
                }

                // 7. 拼接 UserCodeRoot 子目录，并标准化路径
                string strUserCodeRootDir = strPhysicalDir;
                if (objCmProject != null && string.IsNullOrEmpty(objCmProject.UserCodeRoot) == false)
                {
                    // 标准化路径：确保主路径以路径分隔符结尾
                    strPhysicalDir = strPhysicalDir.TrimEnd('\\', '/');

                    // 标准化 UserCodeRoot：去除开头和结尾的路径分隔符
                    string strUserCodeRoot = objCmProject.UserCodeRoot.Trim().TrimStart('\\', '/').TrimEnd('\\', '/');

                    // 使用 Path.Combine 组合路径（自动处理路径分隔符）
                    strUserCodeRootDir = Path.Combine(strPhysicalDir, strUserCodeRoot);

                    // 标准化最终路径（处理 ../ 和 ./ 等）
                    strUserCodeRootDir = Path.GetFullPath(strUserCodeRootDir);
                }

                if (!Directory.Exists(strUserCodeRootDir))
                {
                    strMsg = string.Format(
                        "用户代码根目录[{0}]不存在或无法访问！UserCodeRoot配置为：[{1}]",
                        strUserCodeRootDir,
                        objCmProject.UserCodeRoot ?? "(空)");
                    return -1;
                }

                // 8. 加载 .gitignore 解析器（从项目根目录加载，而不是 UserCodeRoot）
                clsGitIgnoreParser gitIgnoreParser = null;
                if (bolUseGitIgnore)
                {
                    try
                    {
                        // .gitignore 通常在项目根目录，所以从根目录加载
                        gitIgnoreParser = clsGitIgnoreParser.LoadFromDirectory(strPhysicalDir);
                    }
                    catch (Exception ex)
                    {
                        string strWarnMsg = string.Format("加载 .gitignore 文件时出现警告：{0}，将继续处理但不过滤 .gitignore 规则", ex.Message);
                        clsSysParaEN.objLog.WriteDebugLog(strWarnMsg);
                    }
                }

                // 9. 获取排除路径列表
                var arrFileResExcludePathObjLst = clsFileResExcludePathBL.GetObjLstCache();
                var arrExcludeDirName = arrFileResExcludePathObjLst.Select(x => x.ExcludeDirName);

                // 10. 获取文件列表（从 UserCodeRoot 子目录开始扫描）
                FileCollection objFileColl = new FileCollection();
                clsFile.GetFileListEx(strUserCodeRootDir, objFileColl);

                // 11. 预先批量获取所有文件的CodeTypeId（性能优化）
                var arrAllFileNames = objFileColl.FileLst.Select(x => x.FileName).ToList();
                var dictCodeTypeId = GetCodeTypeIdDictionary(arrAllFileNames, strPrjId);

                // 12. 预先批量获取所有文件的TabId（性能优化）
                var dictTabId = GetTabIdDictionary(dictCodeTypeId, strPrjId);

                // 13. 设置服务器IP
                if (string.IsNullOrEmpty(strServerIp))
                {
                    strServerIp = System.Net.Dns.GetHostName();
                }

                // 14. 遍历文件并导入
                foreach (UserFile objUserFile in objFileColl.FileLst)
                {
                    // 14.1 检查是否在排除路径列表中
                    bool bolIsExcludedByPath = false;
                    foreach (string strExcludeDirName in arrExcludeDirName)
                    {
                        if (objUserFile.FullDirName.Contains(strExcludeDirName) == true)
                        {
                            bolIsExcludedByPath = true;
                            intIgnoredByExcludePath++;
                            break;
                        }
                    }
                    if (bolIsExcludedByPath) continue;

                    // 14.2 检查是否被 .gitignore 忽略
                    if (gitIgnoreParser != null)
                    {
                        string strFullPath = Path.Combine(objUserFile.FullDirName, objUserFile.FileName);
                        bool isDirectory = Directory.Exists(strFullPath);

                        if (gitIgnoreParser.ShouldIgnore(strFullPath, isDirectory))
                        {
                            intIgnoredByGitIgnore++;
                            continue;
                        }
                    }

                    // 14.3 获取CodeTypeId
                    string strCodeTypeId = "0000"; // 默认值
                    if (dictCodeTypeId.ContainsKey(objUserFile.FileName))
                    {
                        strCodeTypeId = dictCodeTypeId[objUserFile.FileName];
                        if (strCodeTypeId != "0000")
                        {
                            intCodeTypeIdMatched++;
                        }
                    }

                    // 14.4 获取TabId
                    string strTabId = "";
                    if (dictTabId.ContainsKey(objUserFile.FileName))
                    {
                        strTabId = dictTabId[objUserFile.FileName];
                        if (!string.IsNullOrEmpty(strTabId))
                        {
                            intTabIdMatched++;
                        }
                    }

                    // 14.5 创建文件资源对象
                    clsFileResourceEN objFileResource = new clsFileResourceEN();
                    objFileResource.FileDirName = objUserFile.FullDirName;
                    objFileResource.IpAddress = strServerIp;
                    objFileResource.FileName = objUserFile.FileName;
                    objFileResource.FileLength = objUserFile.FileSize;
                    objFileResource.UpdUser = strUserId;
                    objFileResource.Extension = objUserFile.Extension;
                    objFileResource.CreationTime = clsDateTime.getDateStr(objUserFile.CreationTime, 1);
                    objFileResource.LastWriteTime = clsDateTime.getDateStr(objUserFile.LastWriteTime, 1);
                    objFileResource.IsExistFile = true;
                    objFileResource.PrjId = strPrjId;
                    objFileResource.CmPrjId = strCmPrjId;
                    objFileResource.CodeTypeId = strCodeTypeId; // 设置CodeTypeId
                    objFileResource.TabId = strTabId; // 设置TabId
                    objFileResource.UpdDate = clsDateTime.getTodayDateTimeStr(1);

                    // 14.6 检查记录是否已存在
                    string strConditionCheck = new clsFileResourceEN()
                        .SetPrjId(objFileResource.PrjId, "=")
                        .SetCmPrjId(objFileResource.CmPrjId, "=")
                        .SetFileDirName(objFileResource.FileDirName, "=")
                        .SetFileName(objFileResource.FileName, "=")
                        .GetCombineCondition();

                    try
                    {
                        if (clsFileResourceBL.IsExistRecord(strConditionCheck) == false)
                        {
                            clsFileResourceBL.AddNewRecordBySql2(objFileResource);
                            intCount++;
                        }
                        else
                        {
                            // 如果记录已存在，更新CodeTypeId和TabId
                            var objExisting = clsFileResourceBL.GetFirstObj_S(strConditionCheck);
                            if (objExisting != null)
                            {
                                bool bolNeedUpdate = false;

                                if (objExisting.CodeTypeId != strCodeTypeId)
                                {
                                    objExisting.CodeTypeId = strCodeTypeId;
                                    bolNeedUpdate = true;
                                }

                                if (objExisting.TabId != strTabId)
                                {
                                    objExisting.TabId = strTabId;
                                    bolNeedUpdate = true;
                                }

                                if (bolNeedUpdate)
                                {
                                    objExisting.UpdUser = strUserId;
                                    objExisting.Update();
                                }
                            }
                        }
                    }
                    catch (Exception objEx)
                    {
                        string strCmPrjName = clsCMProjectBL.GetNameByCmPrjIdCache(strCmPrjId);
                        strMsg = string.Format(
                            "导入文件[{0}]出错！错误：[{1}]. 项目：{2} (in {3})",
                            objUserFile.FileName,
                            objEx.Message,
                            strCmPrjName,
                            clsStackTrace.GetCurrClassFunction());
                        return -1;
                    }
                }

                // 15. 生成详细的成功消息
                strMsg = string.Format(
                    "成功从UserCodeRoot目录[{0}]导入 {1} 个文件到项目[{2}]。\r\n" +
                    "匹配到CodeTypeId：{3} 个文件\r\n" +
                    "匹配到TabId：{4} 个文件\r\n" +
                    "{5}" +
                    "{6}",
                    objCmProject.UserCodeRoot ?? "(根目录)",
                    intCount,
                    strCmPrjId,
                    intCodeTypeIdMatched,
                    intTabIdMatched,
                    intIgnoredByGitIgnore > 0 ? string.Format("通过 .gitignore 过滤了 {0} 个文件。\r\n", intIgnoredByGitIgnore) : "",
                    intIgnoredByExcludePath > 0 ? string.Format("通过排除路径过滤了 {0} 个文件。", intIgnoredByExcludePath) : "");

                return intCount;
            }
            catch (Exception objException)
            {
                strMsg = string.Format(
                    "从UserCodeRoot导入项目文件资源时出错：{0} (in {1})",
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                return -1;
            }
        }
        /// <summary>
        /// 根据文件名获取CodeTypeId和TabId（公共服务方法）
        /// </summary>
        /// <param name="strFileName">文件名（包括扩展名）</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>文件类型信息对象</returns>
        public static FileTypeInfo GetFileTypeInfoByFileName(string strFileName, string strPrjId)
        {
            FileTypeInfo result = new FileTypeInfo
            {
                CodeTypeId = "0000",
                CodeTypeName = "未知",
                TabId = "",
                TabName = "",
                IsMatched = false,
                ErrorMessage = ""
            };

            try
            {
                // 1. 参数验证
                if (string.IsNullOrEmpty(strFileName))
                {
                    result.ErrorMessage = "文件名不能为空";
                    return result;
                }

                if (string.IsNullOrEmpty(strPrjId))
                {
                    result.ErrorMessage = "工程Id不能为空";
                    return result;
                }

                // 2. 获取CodeTypeId
                string strCodeTypeId = GetCodeTypeIdByFileName(strFileName, strPrjId);
                result.CodeTypeId = strCodeTypeId;

                // 3. 获取CodeType对象以获取名称
                var objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
                if (objCodeType != null)
                {
                    result.CodeTypeName = objCodeType.CodeTypeName;
                }

                // 4. 如果CodeTypeId不是"0000"，尝试提取TabId
                if (strCodeTypeId != "0000")
                {
                    string strTabName = ExtractTabNameFromFileName(strFileName, strCodeTypeId, strPrjId);

                    if (!string.IsNullOrEmpty(strTabName))
                    {
                        result.TabName = strTabName;

                        // 获取TabId
                        string strTabId = clsPrjTabBLEx.GetTabIdByTabNameCache(strPrjId, strTabName);

                        if (!string.IsNullOrEmpty(strTabId))
                        {
                            result.TabId = strTabId;
                            result.IsMatched = true;
                        }
                        else
                        {
                            result.ErrorMessage = string.Format("表名[{0}]在工程中未找到对应的TabId", strTabName);
                        }
                    }
                    else
                    {
                        // 某些文件类型可能不包含表名（如公共函数类）
                        result.IsMatched = true;
                        result.ErrorMessage = "该文件类型不包含表名信息";
                    }
                }
                else
                {
                    result.ErrorMessage = "未能识别文件类型";
                }

                return result;
            }
            catch (Exception ex)
            {
                result.ErrorMessage = string.Format("获取文件类型信息时出错：{0}", ex.Message);
                clsSysParaEN.objLog.WriteDebugLog(result.ErrorMessage);
                return result;
            }
        }

        /// <summary>
        /// 批量获取文件类型信息
        /// </summary>
        /// <param name="arrFileName">文件名列表</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>文件类型信息列表</returns>
        public static List<FileTypeInfo> GetFileTypeInfoBatch(List<string> arrFileName, string strPrjId)
        {
            List<FileTypeInfo> result = new List<FileTypeInfo>();

            try
            {
                // 1. 参数验证
                if (arrFileName == null || arrFileName.Count == 0)
                {
                    return result;
                }

                if (string.IsNullOrEmpty(strPrjId))
                {
                    return result;
                }

                // 2. 批量获取CodeTypeId
                var dictCodeTypeId = GetCodeTypeIdDictionary(arrFileName, strPrjId);

                // 3. 批量获取TabId
                var dictTabId = GetTabIdDictionary(dictCodeTypeId, strPrjId);

                // 4. 组装结果
                foreach (string strFileName in arrFileName)
                {
                    FileTypeInfo info = new FileTypeInfo
                    {
                        CodeTypeId = "0000",
                        CodeTypeName = "未知",
                        TabId = "",
                        TabName = "",
                        IsMatched = false,
                        ErrorMessage = ""
                    };

                    // 获取CodeTypeId
                    if (dictCodeTypeId.ContainsKey(strFileName))
                    {
                        info.CodeTypeId = dictCodeTypeId[strFileName];

                        // 获取CodeType名称
                        var objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(info.CodeTypeId);
                        if (objCodeType != null)
                        {
                            info.CodeTypeName = objCodeType.CodeTypeName;
                        }
                    }

                    // 获取TabId
                    if (dictTabId.ContainsKey(strFileName))
                    {
                        info.TabId = dictTabId[strFileName];

                        if (!string.IsNullOrEmpty(info.TabId))
                        {
                            // 获取表名
                            var objPrjTab = clsPrjTabBL.GetObjByTabIdCache(info.TabId, strPrjId);
                            if (objPrjTab != null)
                            {
                                info.TabName = objPrjTab.TabName;
                            }
                            info.IsMatched = true;
                        }
                    }

                    // 如果CodeTypeId不是"0000"但TabId为空，也算部分匹配成功
                    if (info.CodeTypeId != "0000" && string.IsNullOrEmpty(info.TabId))
                    {
                        info.IsMatched = true;
                        info.ErrorMessage = "该文件类型不包含表名信息";
                    }

                    result.Add(info);
                }

                return result;
            }
            catch (Exception ex)
            {
                clsSysParaEN.objLog.WriteDebugLog($"批量获取文件类型信息时出错：{ex.Message}");
                return result;
            }
        }
        /// <summary>
        /// 获取指定工程的所有CodeTypeId列表（不重复）
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>CodeTypeId列表</returns>
        public static List<string> GetCodeTypeIdListByPrjId(string strPrjId)
        {
            try
            {
                if (string.IsNullOrEmpty(strPrjId))
                {
                    return new List<string>();
                }

                // 获取该工程的所有文件资源
                string strCondition = string.Format("{0}='{1}'", conFileResource.PrjId, strPrjId);
                var arrFileResource = clsFileResourceBL.GetObjLst(strCondition);

                // 提取不重复的CodeTypeId
                var arrCodeTypeId = arrFileResource
                    .Where(x => !string.IsNullOrEmpty(x.CodeTypeId))
                    .Select(x => x.CodeTypeId)
                    .Distinct()
                    .OrderBy(x => x)
                    .ToList();

                return arrCodeTypeId;
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("获取CodeTypeId列表时出错：{0} (in {1})",
                    ex.Message, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objLog.WriteDebugLog(strMsg);
                return new List<string>();
            }
        }

        /// <summary>
        /// 获取指定工程和CmPrjId的所有CodeTypeId列表（不重复）
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strCmPrjId">Cm工程Id</param>
        /// <returns>CodeTypeId列表</returns>
        public static List<string> GetCodeTypeIdListByPrjIdAndCmPrjId(string strPrjId, string strCmPrjId)
        {
            try
            {
                if (string.IsNullOrEmpty(strPrjId))
                {
                    return new List<string>();
                }

                // 构建查询条件
                string strCondition = string.Format("{0}='{1}'", conFileResource.PrjId, strPrjId);

                if (!string.IsNullOrEmpty(strCmPrjId))
                {
                    strCondition += string.Format(" AND {0}='{1}'", conFileResource.CmPrjId, strCmPrjId);
                }

                var arrFileResource = clsFileResourceBL.GetObjLst(strCondition);

                // 提取不重复的CodeTypeId
                var arrCodeTypeId = arrFileResource
                    .Where(x => !string.IsNullOrEmpty(x.CodeTypeId))
                    .Select(x => x.CodeTypeId)
                    .Distinct()
                    .OrderBy(x => x)
                    .ToList();

                return arrCodeTypeId;
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("获取CodeTypeId列表时出错：{0} (in {1})",
                    ex.Message, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objLog.WriteDebugLog(strMsg);
                return new List<string>();
            }
        }

        /// <summary>
        /// 获取指定工程的CodeTypeId统计信息
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="bolIncludeFileNames">是否包含文件名列表（默认false）</param>
        /// <returns>CodeTypeId统计信息列表</returns>
        public static List<CodeTypeStatInfo> GetCodeTypeStatisticsByPrjId(string strPrjId, bool bolIncludeFileNames = false)
        {
            List<CodeTypeStatInfo> result = new List<CodeTypeStatInfo>();

            try
            {
                if (string.IsNullOrEmpty(strPrjId))
                {
                    return result;
                }

                // 获取该工程的所有文件资源
                string strCondition = string.Format("{0}='{1}'", conFileResource.PrjId, strPrjId);
                var arrFileResource = clsFileResourceBL.GetObjLst(strCondition);

                // 按CodeTypeId分组统计
                var groupedData = arrFileResource
                    .Where(x => !string.IsNullOrEmpty(x.CodeTypeId))
                    .GroupBy(x => x.CodeTypeId)
                    .Select(g => new
                    {
                        CodeTypeId = g.Key,
                        FileCount = g.Count(),
                        FileNames = bolIncludeFileNames ? g.Select(f => f.FileName).ToList() : new List<string>()
                    })
                    .OrderBy(x => x.CodeTypeId)
                    .ToList();

                // 转换为结果对象
                foreach (var item in groupedData)
                {
                    CodeTypeStatInfo info = new CodeTypeStatInfo
                    {
                        CodeTypeId = item.CodeTypeId,
                        CodeTypeName = "",
                        FileCount = item.FileCount,
                        FileNames = item.FileNames
                    };

                    // 获取CodeType名称
                    var objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(item.CodeTypeId);
                    if (objCodeType != null )
                    {
                        info.CodeTypeName = objCodeType.CodeTypeName;
                    }

                    result.Add(info);
                }

                return result;
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("获取CodeTypeId统计信息时出错：{0} (in {1})",
                    ex.Message, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objLog.WriteDebugLog(strMsg);
                return result;
            }
        }

        /// <summary>
        /// 获取指定工程和CmPrjId的CodeTypeId统计信息
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strCmPrjId">Cm工程Id</param>
        /// <param name="bolIncludeFileNames">是否包含文件名列表（默认false）</param>
        /// <returns>CodeTypeId统计信息列表</returns>
        public static List<CodeTypeStatInfo> GetCodeTypeStatisticsByPrjIdAndCmPrjId(
            string strPrjId,
            string strCmPrjId,
            bool bolIncludeFileNames = false)
        {
            List<CodeTypeStatInfo> result = new List<CodeTypeStatInfo>();

            try
            {
                if (string.IsNullOrEmpty(strPrjId))
                {
                    return result;
                }

                // 构建查询条件
                string strCondition = string.Format("{0}='{1}'", conFileResource.PrjId, strPrjId);

                if (!string.IsNullOrEmpty(strCmPrjId))
                {
                    strCondition += string.Format(" AND {0}='{1}'", conFileResource.CmPrjId, strCmPrjId);
                }

                var arrFileResource = clsFileResourceBL.GetObjLst(strCondition);

                // 按CodeTypeId分组统计
                var groupedData = arrFileResource
                    .Where(x => !string.IsNullOrEmpty(x.CodeTypeId))
                    .GroupBy(x => x.CodeTypeId)
                    .Select(g => new
                    {
                        CodeTypeId = g.Key,
                        FileCount = g.Count(),
                        FileNames = bolIncludeFileNames ? g.Select(f => f.FileName).ToList() : new List<string>()
                    })
                    .OrderBy(x => x.CodeTypeId)
                    .ToList();

                // 转换为结果对象
                foreach (var item in groupedData)
                {
                    CodeTypeStatInfo info = new CodeTypeStatInfo
                    {
                        CodeTypeId = item.CodeTypeId,
                        CodeTypeName = "",
                        FileCount = item.FileCount,
                        FileNames = item.FileNames
                    };

                    // 获取CodeType名称
                    var objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(item.CodeTypeId);
                    if (objCodeType != null)
                    {
                        info.CodeTypeName = objCodeType.CodeTypeName;
                    }

                    result.Add(info);
                }

                return result;
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("获取CodeTypeId统计信息时出错：{0} (in {1})",
                    ex.Message, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objLog.WriteDebugLog(strMsg);
                return result;
            }
        }

        /// <summary>
        /// 根据CodeTypeId获取文件列表
        /// </summary>
        /// <param name="strPrjId">工程Id</param>
        /// <param name="strCodeTypeId">代码类型Id</param>
        /// <param name="strCmPrjId">Cm工程Id（可选）</param>
        /// <returns>文件资源对象列表</returns>
        public static List<clsFileResourceEN> GetFilesByCodeTypeId(
            string strPrjId,
            string strCodeTypeId,
            string strCmPrjId = "")
        {
            try
            {
                if (string.IsNullOrEmpty(strPrjId) || string.IsNullOrEmpty(strCodeTypeId))
                {
                    return new List<clsFileResourceEN>();
                }

                // 构建查询条件
                string strCondition = string.Format("{0}='{1}' AND {2}='{3}'",
                    conFileResource.PrjId, strPrjId,
                    conFileResource.CodeTypeId, strCodeTypeId);

                if (!string.IsNullOrEmpty(strCmPrjId))
                {
                    strCondition += string.Format(" AND {0}='{1}'", conFileResource.CmPrjId, strCmPrjId);
                }

                var arrFileResource = clsFileResourceBL.GetObjLst(strCondition);

                return arrFileResource.OrderBy(x => x.FileName).ToList();
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("根据CodeTypeId获取文件列表时出错：{0} (in {1})",
                    ex.Message, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objLog.WriteDebugLog(strMsg);
                return new List<clsFileResourceEN>();
            }
        }

        private static bool TryExtractTabNameByFileNameFormat(string strFileName, string strFileNameFormat, out string strTabName)
        {
            strTabName = "";
            if (string.IsNullOrEmpty(strFileName) || string.IsNullOrEmpty(strFileNameFormat)) return false;

            string strPureFileName = Path.GetFileName(strFileName);

            // 把 FileNameFormat 转成正则：如 cls{0}EN.ts => ^cls(?<tab>.+?)EN\.ts$
            string strPattern = System.Text.RegularExpressions.Regex.Escape(strFileNameFormat);
            strPattern = "^" + strPattern.Replace("\\{0\\}", "(?<tab>.+?)") + "$";

            var regex = new System.Text.RegularExpressions.Regex(strPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            var match = regex.Match(strPureFileName);
            if (!match.Success) return false;

            strTabName = match.Groups["tab"].Value;
            return string.IsNullOrEmpty(strTabName) == false;
        }

        /// <summary>
        /// 根据文件名匹配CodeTypeId（优先按FileNameFormat + 扩展名）
        /// </summary>
        private static string GetCodeTypeIdByFileNameBak20260612(string strFileName, string strPrjId)
        {
            try
            {
                if (string.IsNullOrEmpty(strFileName)) return "0000";
                string strExt = Path.GetExtension(strFileName);

                // 仅取当前工程的 CodeType
                var arrCodeType = clsCodeTypeBL.GetObjLstCache()                   ;

                // 第一优先级：FileNameFormat 扩展名一致 + 格式匹配
                foreach (var objCodeType in arrCodeType)
                {
                    if (string.IsNullOrEmpty(objCodeType.FileNameFormat)) continue;

                    string strFmtExt = Path.GetExtension(objCodeType.FileNameFormat);
                    if (string.Equals(strFmtExt, strExt, StringComparison.OrdinalIgnoreCase) == false) continue;

                    if (TryExtractTabNameByFileNameFormat(strFileName, objCodeType.FileNameFormat, out _))
                    {
                        return objCodeType.CodeTypeId;
                    }
                }

                // 第二优先级：不看扩展名，只按 FileNameFormat 匹配
                foreach (var objCodeType in arrCodeType)
                {
                    if (string.IsNullOrEmpty(objCodeType.FileNameFormat)) continue;

                    if (TryExtractTabNameByFileNameFormat(strFileName, objCodeType.FileNameFormat, out _))
                    {
                        return objCodeType.CodeTypeId;
                    }
                }

                // 第三优先级：旧逻辑（ClassNamePattern）
                string strFileNameWithoutExt = Path.GetFileNameWithoutExtension(strFileName);
                foreach (var objCodeType in arrCodeType)
                {
                    if (string.IsNullOrEmpty(objCodeType.ClassNamePattern)) continue;
                    try
                    {
                        var regex = new System.Text.RegularExpressions.Regex(objCodeType.ClassNamePattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                        if (regex.IsMatch(strFileNameWithoutExt)) return objCodeType.CodeTypeId;
                    }
                    catch
                    {
                        // 忽略非法正则
                    }
                }

                return "0000";
            }
            catch (Exception ex)
            {
                clsSysParaEN.objLog.WriteDebugLog($"匹配CodeTypeId时出错：{ex.Message}");
                return "0000";
            }
        }

        /// <summary>
        /// 从文件名中提取表名（优先按FileNameFormat）
        /// </summary>
        private static string ExtractTabNameFromFileNameBak20260612(string strFileName, string strCodeTypeId, string strPrjId)
        {
            try
            {
                var objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
                if (objCodeType == null ) return "";

                // 优先按 FileNameFormat 提取（可区分 .cs/.ts）
                if (string.IsNullOrEmpty(objCodeType.FileNameFormat) == false)
                {
                    if (TryExtractTabNameByFileNameFormat(strFileName, objCodeType.FileNameFormat, out string strTabName))
                    {
                        return strTabName;
                    }
                }

                // 兼容旧逻辑回退
                string strFileNameWithoutExt = Path.GetFileNameWithoutExtension(strFileName);
                if (string.IsNullOrEmpty(objCodeType.FileNameFormat)) return "";

                string strPattern = objCodeType.FileNameFormat;
                int intDotPos = strPattern.IndexOf('.');
                if (intDotPos > 0) strPattern = strPattern.Substring(0, intDotPos);

                strPattern = strPattern.Replace("{0}", "(.+?)");
                strPattern = System.Text.RegularExpressions.Regex.Escape(strPattern);
                strPattern = strPattern.Replace("\\(\\.\\+\\?\\)", "(.+?)");

                var regex = new System.Text.RegularExpressions.Regex("^" + strPattern + "$", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                var match = regex.Match(strFileNameWithoutExt);
                if (match.Success && match.Groups.Count > 1) return match.Groups[1].Value;

                return "";
            }
            catch (Exception ex)
            {
                clsSysParaEN.objLog.WriteDebugLog($"从文件名提取表名时出错：{ex.Message}");
                return "";
            }
        }

        private static bool TryMatchByFileNameFormat(string strFileName, string strFileNameFormat, out string strTabName)
        {
            strTabName = "";
            if (string.IsNullOrEmpty(strFileName) || string.IsNullOrEmpty(strFileNameFormat)) return false;

            string strPureFileName = Path.GetFileName(strFileName);

            // 例如: cls{0}EN.ts => ^cls(?<tab>.+?)EN\.ts$
            string strPattern = System.Text.RegularExpressions.Regex.Escape(strFileNameFormat);
            strPattern = "^" + strPattern.Replace("\\{0\\}", "(?<tab>.+?)") + "$";

            var regex = new System.Text.RegularExpressions.Regex(
                strPattern,
                System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            var match = regex.Match(strPureFileName);
            if (!match.Success) return false;

            strTabName = match.Groups["tab"].Value;
            return string.IsNullOrEmpty(strTabName) == false;
        }

        private static string GetCodeTypeIdByFileName(string strFileName, string strPrjId)
        {
            try
            {
                if (string.IsNullOrEmpty(strFileName)) return "0000";

                string strExt = Path.GetExtension(strFileName); // .cs / .ts

                // 仅取当前工程的 CodeType
                var arrCodeType = clsCodeTypeBL.GetObjLstCache();

                // 1) 第一优先级：FileNameFormat 且扩展名一致
                foreach (var objCodeType in arrCodeType)
                {
                    if (string.IsNullOrEmpty(objCodeType.FileNameFormat)) continue;

                    string strFmtExt = Path.GetExtension(objCodeType.FileNameFormat);
                    if (string.Equals(strFmtExt, strExt, StringComparison.OrdinalIgnoreCase) == false) continue;

                    if (TryMatchByFileNameFormat(strFileName, objCodeType.FileNameFormat, out _))
                    {
                        return objCodeType.CodeTypeId;
                    }
                }

                // 2) 第二优先级：FileNameFormat（不强制扩展名）
                foreach (var objCodeType in arrCodeType)
                {
                    if (string.IsNullOrEmpty(objCodeType.FileNameFormat)) continue;

                    if (TryMatchByFileNameFormat(strFileName, objCodeType.FileNameFormat, out _))
                    {
                        return objCodeType.CodeTypeId;
                    }
                }

                // 3) 最后回退：ClassNamePattern（尽量按扩展名约束）
                string strFileNameWithoutExt = Path.GetFileNameWithoutExtension(strFileName);
                foreach (var objCodeType in arrCodeType)
                {
                    if (string.IsNullOrEmpty(objCodeType.ClassNamePattern)) continue;

                    // 如果 FileNameFormat 有扩展名，优先要求一致，避免 ts 命中 cs
                    if (string.IsNullOrEmpty(objCodeType.FileNameFormat) == false)
                    {
                        string strFmtExt = Path.GetExtension(objCodeType.FileNameFormat);
                        if (string.IsNullOrEmpty(strFmtExt) == false
                            && string.Equals(strFmtExt, strExt, StringComparison.OrdinalIgnoreCase) == false)
                        {
                            continue;
                        }
                    }

                    try
                    {
                        var regex = new System.Text.RegularExpressions.Regex(
                            objCodeType.ClassNamePattern,
                            System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                        if (regex.IsMatch(strFileNameWithoutExt))
                        {
                            return objCodeType.CodeTypeId;
                        }
                    }
                    catch
                    {
                        // 忽略无效正则
                    }
                }

                return "0000";
            }
            catch (Exception ex)
            {
                clsSysParaEN.objLog.WriteDebugLog($"匹配CodeTypeId时出错：{ex.Message}");
                return "0000";
            }
        }

        private static Dictionary<string, string> GetCodeTypeIdDictionary(List<string> arrFileName, string strPrjId)
        {
            Dictionary<string, string> dictCodeTypeId = new Dictionary<string, string>();

            if (arrFileName == null || arrFileName.Count == 0) return dictCodeTypeId;

            foreach (string strFileName in arrFileName)
            {
                dictCodeTypeId[strFileName] = GetCodeTypeIdByFileName(strFileName, strPrjId);
            }

            return dictCodeTypeId;
        }

        private static string ExtractTabNameFromFileNameBak202606122(string strFileName, string strCodeTypeId, string strPrjId)
        {
            try
            {
                var objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
                if (objCodeType == null) return "";
                //if (objCodeType.PrjId != strPrjId) return "";
                if (string.IsNullOrEmpty(objCodeType.FileNameFormat)) return "";

                if (TryMatchByFileNameFormat(strFileName, objCodeType.FileNameFormat, out string strTabName))
                {
                    return strTabName;
                }

                return "";
            }
            catch (Exception ex)
            {
                clsSysParaEN.objLog.WriteDebugLog($"从文件名提取表名时出错：{ex.Message}");
                return "";
            }
        }
        /// <summary>
        /// 从文件名中提取表名（基于CodeType的FileNameFormat，兼容扩展名差异）
        /// </summary>
        /// <param name="strFileName">文件名（含扩展名）</param>
        /// <param name="strCodeTypeId">代码类型Id</param>
        /// <param name="strPrjId">工程Id</param>
        /// <returns>表名，如果无法提取返回空字符串</returns>
        private static string ExtractTabNameFromFileNameBaked0260615(string strFileName, string strCodeTypeId, string strPrjId)
        {
            try
            {
                var objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
                if (objCodeType == null || string.IsNullOrEmpty(objCodeType.FileNameFormat))
                    return "";

                string strPureFileName = Path.GetFileName(strFileName);
                string strFormat = objCodeType.FileNameFormat;

                // 1) 完整格式匹配（含扩展名）
                string strPatternFull = System.Text.RegularExpressions.Regex.Escape(strFormat);
                strPatternFull = "^" + strPatternFull.Replace("\\{0}", "(?<tab>.+?)") + "$";
                var regexFull = new System.Text.RegularExpressions.Regex(
                    strPatternFull,
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                var matchFull = regexFull.Match(strPureFileName);
                if (matchFull.Success && matchFull.Groups["tab"] != null)
                {
                    string strTabName = matchFull.Groups["tab"].Value;
                    if (string.IsNullOrEmpty(strTabName) == false) return strTabName;
                }

                // 2) 忽略扩展名匹配（兜底）
                string strFileNameWithoutExt = Path.GetFileNameWithoutExtension(strPureFileName);

                string strFormatWithoutExt = strFormat;
                int intDotPos = strFormatWithoutExt.LastIndexOf('.');
                if (intDotPos > 0)
                {
                    strFormatWithoutExt = strFormatWithoutExt.Substring(0, intDotPos);
                }

                string strPatternNoExt = System.Text.RegularExpressions.Regex.Escape(strFormatWithoutExt);
                strPatternNoExt = "^" + strPatternNoExt.Replace("\\{0}", "(?<tab>.+?)") + "$";
                var regexNoExt = new System.Text.RegularExpressions.Regex(
                    strPatternNoExt,
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                var matchNoExt = regexNoExt.Match(strFileNameWithoutExt);
                if (matchNoExt.Success && matchNoExt.Groups["tab"] != null)
                {
                    string strTabName = matchNoExt.Groups["tab"].Value;
                    if (string.IsNullOrEmpty(strTabName) == false) return strTabName;
                }

                return "";
            }
            catch (Exception ex)
            {
                clsSysParaEN.objLog.WriteDebugLog($"从文件名提取表名时出错：{ex.Message}");
                return "";
            }
        }
        private static string ExtractTabNameFromFileName(string strFileName, string strCodeTypeId, string strPrjId)
        {
            try
            {
                var objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
                if (objCodeType == null || string.IsNullOrEmpty(objCodeType.FileNameFormat))
                    return "";

                string strPureFileName = Path.GetFileName(strFileName);
                string strFormat = objCodeType.FileNameFormat;

                // 1) 完整格式匹配（含扩展名）
                string strPatternFull = System.Text.RegularExpressions.Regex.Escape(strFormat);
                strPatternFull = "^" + strPatternFull.Replace("\\{0}", "(?<tab>.+?)") + "$";
                var regexFull = new System.Text.RegularExpressions.Regex(
                    strPatternFull,
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                var matchFull = regexFull.Match(strPureFileName);
                if (matchFull.Success && matchFull.Groups["tab"] != null)
                {
                    string strTabName = matchFull.Groups["tab"].Value;
                    if (string.IsNullOrEmpty(strTabName) == false) return strTabName;
                }

                // 2) 忽略扩展名匹配（兜底）
                string strFileNameWithoutExt = Path.GetFileNameWithoutExtension(strPureFileName);

                string strFormatWithoutExt = strFormat;
                int intDotPos = strFormatWithoutExt.LastIndexOf('.');
                if (intDotPos > 0)
                {
                    strFormatWithoutExt = strFormatWithoutExt.Substring(0, intDotPos);
                }

                string strPatternNoExt = System.Text.RegularExpressions.Regex.Escape(strFormatWithoutExt);
                strPatternNoExt = "^" + strPatternNoExt.Replace("\\{0}", "(?<tab>.+?)") + "$";
                var regexNoExt = new System.Text.RegularExpressions.Regex(
                    strPatternNoExt,
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                var matchNoExt = regexNoExt.Match(strFileNameWithoutExt);
                if (matchNoExt.Success && matchNoExt.Groups["tab"] != null)
                {
                    string strTabName = matchNoExt.Groups["tab"].Value;
                    if (string.IsNullOrEmpty(strTabName) == false) return strTabName;
                }

                return "";
            }
            catch (Exception ex)
            {
                clsSysParaEN.objLog.WriteDebugLog($"从文件名提取表名时出错：{ex.Message}");
                return "";
            }
        }

        public static ImportFileListFromClientResult ImportFileListFromClient(
            string strUserId,
            string strPrjId,
            string strCmPrjId,
            int intApplicationTypeId,
            string strServerIp,
            List<ClientImportFileItem> arrFileList)
        {
            ImportFileListFromClientResult result = new ImportFileListFromClientResult
            {
                ErrorId = 0,
                ErrorMsg = ""
            };

            try
            {
                // 参数验证
                if (string.IsNullOrEmpty(strUserId) || string.IsNullOrEmpty(strPrjId)
                    || string.IsNullOrEmpty(strCmPrjId) || intApplicationTypeId <= 0)
                {
                    result.ErrorId = 400;
                    result.ErrorMsg = "参数无效：UserId/PrjId/CmPrjId/ApplicationTypeId 必填";
                    return result;
                }

                if (arrFileList == null || arrFileList.Count == 0)
                {
                    result.ErrorId = 400;
                    result.ErrorMsg = "FileList 不能为空";
                    return result;
                }

                // 校验关联配置
                long lngCMProjectAppRelaId = clsCMProjectAppRelaBLEx.getCMProjectAppRelaId(
                    strCmPrjId, intApplicationTypeId, strPrjId);
                if (lngCMProjectAppRelaId <= 0)
                {
                    result.ErrorId = 400;
                    result.ErrorMsg = $"未找到关联配置：PrjId={strPrjId}, CmPrjId={strCmPrjId}, ApplicationTypeId={intApplicationTypeId}";
                    return result;
                }

                string strNow = clsDateTime.getTodayDateTimeStr(1);
                if (string.IsNullOrEmpty(strServerIp))
                {
                    strServerIp = System.Net.Dns.GetHostName();
                }

                result.TotalCount = arrFileList.Count;

                foreach (var item in arrFileList)
                {
                    if (item == null || string.IsNullOrEmpty(item.FileName) || string.IsNullOrEmpty(item.FileDirName))
                    {
                        result.IgnoredCount++;
                        continue;
                    }

                    try
                    {
                        string strCondition = new clsFileResourceEN()
                            .SetPrjId(strPrjId, "=")
                            .SetCmPrjId(strCmPrjId, "=")
                            .SetFileDirName(item.FileDirName, "=")
                            .SetFileName(item.FileName, "=")
                            .GetCombineCondition();

                        clsFileResourceEN objExist = clsFileResourceBL.GetFirstObj_S(strCondition);

                        // 自动识别 CodeTypeId / TabId
                        var objTypeInfo = GetFileTypeInfoByFileName(item.FileName, strPrjId);
                        string strCodeTypeId = objTypeInfo?.CodeTypeId ?? "0000";
                        string strTabId = objTypeInfo?.TabId ?? "";

                        if (objExist == null)
                        {
                            clsFileResourceEN objNew = new clsFileResourceEN();
                            objNew.PrjId = strPrjId;
                            objNew.CmPrjId = strCmPrjId;
                            objNew.FileDirName = item.FileDirName;
                            objNew.FileName = item.FileName;
                            objNew.Extension = item.Extension ?? "";
                            objNew.FileLength = item.FileLength;
                            objNew.CreationTime = string.IsNullOrEmpty(item.CreationTime) ? strNow : item.CreationTime;
                            objNew.LastWriteTime = string.IsNullOrEmpty(item.LastWriteTime) ? strNow : item.LastWriteTime;
                            objNew.UpdUser = strUserId;
                            objNew.UpdDate = strNow;
                            objNew.IsExistFile = true;
                            objNew.IpAddress = strServerIp;
                            objNew.CodeTypeId = strCodeTypeId;
                            objNew.TabId = strTabId;

                            clsFileResourceBL.AddNewRecordBySql2(objNew);
                            result.AddedCount++;
                        }
                        else
                        {
                            bool bolChanged = false;

                            string strExtension = item.Extension ?? "";
                            if (objExist.Extension != strExtension) { objExist.Extension = strExtension; bolChanged = true; }
                            if (objExist.FileLength != item.FileLength) { objExist.FileLength = item.FileLength; bolChanged = true; }

                            string strCreationTime = string.IsNullOrEmpty(item.CreationTime) ? objExist.CreationTime : item.CreationTime;
                            string strLastWriteTime = string.IsNullOrEmpty(item.LastWriteTime) ? objExist.LastWriteTime : item.LastWriteTime;

                            if (objExist.CreationTime != strCreationTime) { objExist.CreationTime = strCreationTime; bolChanged = true; }
                            if (objExist.LastWriteTime != strLastWriteTime) { objExist.LastWriteTime = strLastWriteTime; bolChanged = true; }

                            if (objExist.IpAddress != strServerIp) { objExist.IpAddress = strServerIp; bolChanged = true; }
                            if (objExist.CodeTypeId != strCodeTypeId) { objExist.CodeTypeId = strCodeTypeId; bolChanged = true; }
                            if (objExist.TabId != strTabId) { objExist.TabId = strTabId; bolChanged = true; }

                            if (objExist.IsExistFile != true) { objExist.IsExistFile = true; bolChanged = true; }

                            if (bolChanged)
                            {
                                objExist.UpdUser = strUserId;
                                objExist.UpdDate = strNow;
                                objExist.Update();
                                result.UpdatedCount++;
                            }
                            else
                            {
                                result.IgnoredCount++;
                            }
                        }
                    }
                    catch (Exception objExItem)
                    {
                        result.FailedCount++;
                        result.FailedFiles.Add(item.FileName ?? "(null)");
                        clsSysParaEN.objLog.WriteDebugLog(
                            $"[ImportFileListFromClient][ItemError] prjId={strPrjId}, cmPrjId={strCmPrjId}, file={item?.FileName}, err={objExItem}");
                    }
                }

                if (result.FailedCount > 0)
                {
                    result.ErrorId = 2; // 部分成功
                    result.ErrorMsg = $"部分成功：失败 {result.FailedCount} 个，新增 {result.AddedCount}，更新 {result.UpdatedCount}，忽略 {result.IgnoredCount}";
                }

                return result;
            }
            catch (Exception objException)
            {
                result.ErrorId = 500;
                result.ErrorMsg = $"服务端异常：{objException.Message}";
                clsSysParaEN.objLog.WriteDebugLog(
                    $"[ImportFileListFromClient][Fatal] prjId={strPrjId}, cmPrjId={strCmPrjId}, count={arrFileList?.Count ?? 0}, err={objException}");
                return result;
            }
        }

        public static int SyncTabOwnershipByCmPrjId(string prjId, string cmPrjId)
        {
            int UpdatedCount = 0;
            if (string.IsNullOrWhiteSpace(prjId))
                throw new ArgumentException("prjId 不能为空", nameof(prjId));
            if (string.IsNullOrWhiteSpace(cmPrjId))
                throw new ArgumentException("cmPrjId 不能为空", nameof(cmPrjId));

            var setTabIdInCmPrj = clsCmProjectPrjTabBLEx.GetTabIdLstCache(cmPrjId);
            string strCondition = new clsFileResourceEN()
                .SetPrjId(prjId, "=")
                .SetCmPrjId(cmPrjId, "=")
                .GetCombineCondition();
            var arrFileResource = clsFileResourceBLEx.GetObjLst(strCondition);


            foreach (var item in arrFileResource)
            {

                var bolShouldBelong = setTabIdInCmPrj.Contains(item.TabId);
                var bolCurrentBelong = item.IsBelongsCurrCMPrj;

                if (bolShouldBelong == bolCurrentBelong)
                {
                    //result.UnchangedCount++;
                    continue;
                }

                var bolUpdated = clsFileResourceBL.SetFldValue(conFileResource._CurrTabName, conFileResource.IsBelongsCurrCMPrj, bolShouldBelong ? "1" : "0", $"FileResourceId = {item.FileResourceId}");

                if (bolUpdated > 0)
                {
                    UpdatedCount++;
                }

            }

            return UpdatedCount;
        }
    }

    /// <summary>
    /// 根据文件名获取CodeTypeId和TabId的结果类
    /// </summary>
    public class FileTypeInfo
    {
        /// <summary>
        /// 代码类型Id
        /// </summary>
        public string CodeTypeId { get; set; }

        /// <summary>
        /// 代码类型名称
        /// </summary>
        public string CodeTypeName { get; set; }

        /// <summary>
        /// 表Id
        /// </summary>
        public string TabId { get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        public string TabName { get; set; }

        /// <summary>
        /// 是否匹配成功
        /// </summary>
        public bool IsMatched { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        public string ErrorMessage { get; set; }
    }


    /// <summary>
    /// CodeTypeId统计信息类
    /// </summary>
    public class CodeTypeStatInfo
    {
        /// <summary>
        /// 代码类型Id
        /// </summary>
        public string CodeTypeId { get; set; }

        /// <summary>
        /// 代码类型名称
        /// </summary>
        public string CodeTypeName { get; set; }

        /// <summary>
        /// 文件数量
        /// </summary>
        public int FileCount { get; set; }

        /// <summary>
        /// 文件名列表（可选）
        /// </summary>
        public List<string> FileNames { get; set; }
    }
}

// 建议放在 clsFileResourceBLEx 类内部（public partial class clsFileResourceBLEx : clsFileResourceBL）
public class ClientImportFileItem
{
    public string FileName { get; set; }
    public string FileDirName { get; set; }
    public string Extension { get; set; }
    public long? FileLength { get; set; }
    public string CreationTime { get; set; }
    public string LastWriteTime { get; set; }
}

public class ImportFileListFromClientResult
{
    public int ErrorId { get; set; }
    public string ErrorMsg { get; set; }
    public int TotalCount { get; set; }
    public int AddedCount { get; set; }
    public int UpdatedCount { get; set; }
    public int IgnoredCount { get; set; }
    public int FailedCount { get; set; }
    public List<string> FailedFiles { get; set; } = new List<string>();
}
