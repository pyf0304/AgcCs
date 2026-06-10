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
                arrFileResource = arrFileResource.Where(x => lstFileResourceID.Contains(x.FileResourceID) == true).ToList();
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
    }
}