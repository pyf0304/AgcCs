
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsViewReferFilesBLEx
表名:ViewReferFiles(00050465)
生成代码版本:2019.05.17.1
生成日期:2019/05/17 11:04:51
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:生成代码
模块英文名:GeneCode
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

using com.taishsoft.datetime;

namespace AGC.BusinessLogicEx
{
    public static class clsViewReferFilesBLEx_Static
    {
        public static void GeneCode(this clsViewReferFilesEN objViewReferFilesEN, enumApplicationType intApplicationTypeId, StringBuilder strCodeForCs)
        {
            clsReferFilesEN objReferFiles = clsReferFilesBL.GetObjByReferFileIdCache(objViewReferFilesEN.ReferFileId);

            switch (objReferFiles.ReferFileTypeId)
            {
                case enumReferFileType.JsvaScript_01:
                    strCodeForCs.AppendFormat("\r\n" + "<script type=\"text/javascript\" src=\"{0}/{1}\"></script>",
                        objReferFiles.FilePath,
                        objReferFiles.FileName);
                    break;
                case enumReferFileType.Style_02:
                    strCodeForCs.AppendFormat("\r\n" + "    <link href=\"{0}/{1}\" rel=\"stylesheet\" />",
                        objReferFiles.FilePath,
                        objReferFiles.FileName);

                    break;
            }


        }


        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objViewReferFilesENS">源对象</param>
        /// <returns>目标对象=>clsViewReferFilesEN:objViewReferFilesENT</returns>
        public static clsViewReferFilesENEx CopyToEx(this clsViewReferFilesEN objViewReferFilesENS)
        {
            try
            {
                clsViewReferFilesENEx objViewReferFilesENT = new clsViewReferFilesENEx();
                clsViewReferFilesBL.CopyTo(objViewReferFilesENS, objViewReferFilesENT);
                return objViewReferFilesENT;
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
        /// <param name = "objViewReferFilesENS">源对象</param>
        /// <returns>目标对象=>clsViewReferFilesEN:objViewReferFilesENT</returns>
        public static clsViewReferFilesEN CopyTo(this clsViewReferFilesENEx objViewReferFilesENS)
        {
            try
            {
                clsViewReferFilesEN objViewReferFilesENT = new clsViewReferFilesEN();
                clsViewReferFilesBL.CopyTo(objViewReferFilesENS, objViewReferFilesENT);
                return objViewReferFilesENT;
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
    /// 界面引用文件(ViewReferFiles)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsViewReferFilesBLEx : clsViewReferFilesBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsViewReferFilesDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsViewReferFilesDAEx ViewReferFilesDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsViewReferFilesDAEx();
                }
                return uniqueInstanceEx;
            }
        }

    
        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsViewReferFilesENEx> GetObjExLst(string strCondition)
        {
            List<clsViewReferFilesEN> arrObjLst = clsViewReferFilesBL.GetObjLst(strCondition);
            List<clsViewReferFilesENEx> arrObjExLst = new List<clsViewReferFilesENEx>();
            foreach (clsViewReferFilesEN objInFor in arrObjLst)
            {
                clsViewReferFilesENEx objViewReferFilesENEx = new clsViewReferFilesENEx();
                clsViewReferFilesBL.CopyTo(objInFor, objViewReferFilesENEx);
                arrObjExLst.Add(objViewReferFilesENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsViewReferFilesENEx GetObjExBymId(long lngmId)
        {
            clsViewReferFilesEN objViewReferFilesEN = clsViewReferFilesBL.GetObjBymId(lngmId);
            clsViewReferFilesENEx objViewReferFilesENEx = new clsViewReferFilesENEx();
            clsViewReferFilesBL.CopyTo(objViewReferFilesEN, objViewReferFilesENEx);
            return objViewReferFilesENEx;
        }
        /// <summary>
        /// 从模板复制记录
        /// </summary>
        /// <param name="strViewId"></param>
        /// <param name="strPrjId"></param>  
        /// <param name="strUserId"></param>
        public static bool CopyFromTempplate(string strViewId, string strPrjId, string strOpUserId)
        {

            string strCondition = string.Format("{0}='1'", conViewReferFiles.IsTemplate);
            List<string> arrCodeTypeId = new List<string>() { "0004", "0005", "0034" };
            List<clsViewReferFilesEN> arrObjLst = clsViewReferFilesBL.GetObjLst(strCondition);
            foreach (clsViewReferFilesEN objInFor in arrObjLst)
            {
                //foreach (string strCodeTypeId in arrCodeTypeId)
                //{
                if (objInFor.SetViewId(strViewId)
                    //.SetCodeTypeId(strCodeTypeId)
                    .SetIsTemplate(false)
                    .SetPrjId(strPrjId)
                    .SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUserId(strOpUserId)
                    .CheckUniqueness() == true)
                {
                    objInFor.AddNewRecord();
                }
                //}
            }
            return true;
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsViewReferFilesEN> GetObjLstByViewId(string strViewId)
        {
            string strCondition = string.Format("{0}='{1}'", conViewReferFiles.ViewId, strViewId);

            List<clsViewReferFilesEN> arrObjLst = clsViewReferFilesBL.GetObjLst(strCondition);
            return arrObjLst;
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <param name = "strPrjId">界面Id</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsViewReferFilesEN> GetObjLstByViewIdCache(string strViewId, string strPrjId)
        {
            //string strCondition = string.Format("{0}='{1}'", clsvViewReferFilesEN.con_ViewId, strViewId);

            IEnumerable<clsViewReferFilesEN> arrObjLst = clsViewReferFilesBL.GetObjLstCache(strPrjId).Where(x => x.ViewId == strViewId);
            return arrObjLst.ToList();
        }
    }

}