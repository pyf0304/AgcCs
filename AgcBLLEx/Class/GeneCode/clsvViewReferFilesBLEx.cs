
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvViewReferFilesBLEx
表名:vViewReferFiles(00050466)
生成代码版本:2019.05.17.1
生成日期:2019/05/17 11:04:53
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


namespace AGC.BusinessLogicEx
{
    public static class clsvViewReferFilesBLEx_Static
    {
        public static void GeneCode(this clsvViewReferFilesENEx objvViewReferFilesENEx, StringBuilder strCodeForCs)
        {
            switch(objvViewReferFilesENEx.ReferFileTypeId)
            {
                case enumReferFileType.JsvaScript_01:
                    strCodeForCs.AppendFormat("\r\n" + "<script type=\"text/javascript\" src=\"{0}/{1}\"></script>", 
                        objvViewReferFilesENEx.FilePath,
                        objvViewReferFilesENEx.FileName);
                    break;
                case enumReferFileType.Style_02:
                    strCodeForCs.AppendFormat("\r\n" + "    <link href=\"{0}/{1}\" rel=\"stylesheet\" />",
                        objvViewReferFilesENEx.FilePath,
                        objvViewReferFilesENEx.FileName);

                    break;
            }
            

        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvViewReferFilesENS">源对象</param>
        /// <returns>目标对象=>clsvViewReferFilesEN:objvViewReferFilesENT</returns>
        public static clsvViewReferFilesENEx CopyToEx(this clsvViewReferFilesEN objvViewReferFilesENS)
        {
            try
            {
                clsvViewReferFilesENEx objvViewReferFilesENT = new clsvViewReferFilesENEx();
                clsvViewReferFilesBL.CopyTo(objvViewReferFilesENS, objvViewReferFilesENT);
                return objvViewReferFilesENT;
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
        /// <param name = "objvViewReferFilesENS">源对象</param>
        /// <returns>目标对象=>clsvViewReferFilesEN:objvViewReferFilesENT</returns>
        public static clsvViewReferFilesEN CopyTo(this clsvViewReferFilesENEx objvViewReferFilesENS)
        {
            try
            {
                clsvViewReferFilesEN objvViewReferFilesENT = new clsvViewReferFilesEN();
                clsvViewReferFilesBL.CopyTo(objvViewReferFilesENS, objvViewReferFilesENT);
                return objvViewReferFilesENT;
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
    /// vViewReferFiles(vViewReferFiles)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvViewReferFilesBLEx : clsvViewReferFilesBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvViewReferFilesDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvViewReferFilesDAEx vViewReferFilesDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvViewReferFilesDAEx();
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
        public static List<clsvViewReferFilesENEx> GetObjExLst(string strCondition)
        {
            List<clsvViewReferFilesEN> arrObjLst = clsvViewReferFilesBL.GetObjLst(strCondition);
            List<clsvViewReferFilesENEx> arrObjExLst = new List<clsvViewReferFilesENEx>();
            foreach (clsvViewReferFilesEN objInFor in arrObjLst)
            {
                clsvViewReferFilesENEx objvViewReferFilesENEx = new clsvViewReferFilesENEx();
                clsvViewReferFilesBL.CopyTo(objInFor, objvViewReferFilesENEx);
                arrObjExLst.Add(objvViewReferFilesENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvViewReferFilesENEx GetObjExBymId(long lngmId)
        {
            clsvViewReferFilesEN objvViewReferFilesEN = clsvViewReferFilesBL.GetObjBymId(lngmId);
            clsvViewReferFilesENEx objvViewReferFilesENEx = new clsvViewReferFilesENEx();
            clsvViewReferFilesBL.CopyTo(objvViewReferFilesEN, objvViewReferFilesENEx);
            return objvViewReferFilesENEx;
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strViewId">界面Id</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvViewReferFilesENEx> GetObjExLstByViewIdCache(string strViewId, string strPrjId)
        {
            //string strCondition = string.Format("{0}='{1}'", clsvViewReferFilesEN.con_ViewId, strViewId);
        
            IEnumerable<clsvViewReferFilesEN> arrObjLst = clsvViewReferFilesBL.GetObjLstCache(strPrjId).Where(x=>x.ViewId == strViewId);
            List<clsvViewReferFilesENEx> arrObjExLst = new List<clsvViewReferFilesENEx>();
            foreach (clsvViewReferFilesEN objInFor in arrObjLst)
            {
                clsvViewReferFilesENEx objvViewReferFilesENEx = new clsvViewReferFilesENEx();
                clsvViewReferFilesBL.CopyTo(objInFor, objvViewReferFilesENEx);
                arrObjExLst.Add(objvViewReferFilesENEx);
            }
            return arrObjExLst;
        }
    }
}