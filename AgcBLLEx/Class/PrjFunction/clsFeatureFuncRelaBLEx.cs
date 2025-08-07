
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsFeatureFuncRelaBLEx
表名:FeatureFuncRela
生成代码版本:2018.03.19.1
生成日期:2018/03/20 00:11:46
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:函数管理
模块英文名:PrjFunction
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
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

    public static class clsFeatureFuncRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objFeatureFuncRelaENS">源对象</param>
        /// <returns>目标对象=>clsFeatureFuncRelaEN:objFeatureFuncRelaENT</returns>
        public static clsFeatureFuncRelaEN CopyTo(this clsFeatureFuncRelaENEx objFeatureFuncRelaENS)
        {
            try
            {
                clsFeatureFuncRelaEN objFeatureFuncRelaENT = new clsFeatureFuncRelaEN();
                clsFeatureFuncRelaBL.CopyTo(objFeatureFuncRelaENS, objFeatureFuncRelaENT);
                return objFeatureFuncRelaENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objFeatureFuncRelaENS">源对象</param>
        /// <returns>目标对象=>clsFeatureFuncRelaEN:objFeatureFuncRelaENT</returns>
        public static clsFeatureFuncRelaENEx CopyToEx(this clsFeatureFuncRelaEN objFeatureFuncRelaENS)
        {
            try
            {
                clsFeatureFuncRelaENEx objFeatureFuncRelaENT = new clsFeatureFuncRelaENEx();
                clsFeatureFuncRelaBL.FeatureFuncRelaDA.CopyTo(objFeatureFuncRelaENS, objFeatureFuncRelaENT);
                return objFeatureFuncRelaENT;
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
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_UpdateRecordEx)
        /// </summary>
        /// <param name = "objFeatureFuncRelaEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool UpdateRecordEx2(this clsFeatureFuncRelaEN objFeatureFuncRelaEN)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            try
            {
                //1、检查传进去的对象属性是否合法
                objFeatureFuncRelaEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objFeatureFuncRelaEN.Update();
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_EditRecordEx)
        /// </summary>
        /// <param name = "objFeatureFuncRela">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx2(this clsFeatureFuncRelaEN objFeatureFuncRela)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsFeatureFuncRelaEN objFeatureFuncRela_Cond = new clsFeatureFuncRelaEN();
            string strCondition = objFeatureFuncRela_Cond
            .SetApplicationTypeId(objFeatureFuncRela.ApplicationTypeId, "=")
            .SetFeatureId(objFeatureFuncRela.FeatureId, "=")
            .SetFuncId4GC(objFeatureFuncRela.FuncId4GC, "=")
            .GetCombineCondition();
            objFeatureFuncRela._IsCheckProperty = true;
            bool bolIsExist = clsFeatureFuncRelaBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objFeatureFuncRela.mId = clsFeatureFuncRelaBL.GetFirstID_S(strCondition);
                objFeatureFuncRela.UpdateWithCondition(strCondition);
            }
            else
            {
                objFeatureFuncRela.AddNewRecord();
            }
            return true;
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        public static bool AddRecordEx2(this clsFeatureFuncRelaEN objFeatureFuncRelaEN)
        {
            //操作步骤:
            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //2、检查唯一性
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
                            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            try
            {
                //2、检查传进去的对象属性是否合法
                objFeatureFuncRelaEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objFeatureFuncRelaEN.AddNewRecord();
            }
            catch (Exception objException)
            {
                strMsg = "(errid:BlEx000003)添加记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }
    }
    /// <summary>
    /// 功能函数关系(FeatureFuncRela)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsFeatureFuncRelaBLEx : clsFeatureFuncRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsFeatureFuncRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsFeatureFuncRelaDAEx FeatureFuncRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsFeatureFuncRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }


        public static bool AddFeatureFuncRelaRecordSave(int intApplicationTypeId, string strFeatureId, string strFuncId4GC, string strUpdUser)
        {
            //操作步骤:
            //1、检查控件中输入数据类型是否正确
            //2、定义对象并初始化对象
            //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //3.2、检查唯一性
            //4、把值从界面层传到逻辑层或数据实体层
            //5、检查传进去的对象属性是否合法
            //6、把数据实体层的数据存贮到数据库中
            //7、把新添的记录内容显示在GridView中
            string strMsg;  //专门用于传递信息的变量
            //string strResult = " "; //用于传递在检验对象属性时结果值的变量
            clsFeatureFuncRelaEN objFeatureFuncRelaEN;

            //2、定义对象并初始化对象
            //clsFeatureFuncRelaEN objFeatureFuncRelaEN;	//定义对象
            objFeatureFuncRelaEN = new clsFeatureFuncRelaEN();  //初始化新对象
            objFeatureFuncRelaEN.ApplicationTypeId = intApplicationTypeId;
            objFeatureFuncRelaEN.FeatureId = strFeatureId;// 功能Id
            objFeatureFuncRelaEN.FuncId4GC = strFuncId4GC;// 函数Id4Code
            objFeatureFuncRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);// 修改日期
            objFeatureFuncRelaEN.UpdUser = strUpdUser;// 修改者
                                                      //            objFeatureFuncRelaEN.Memo = wucFeatureFuncRelaB1.Memo;// 说明
                                                      //3.1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
                                                      //4、把值从界面层传到逻辑层或数据实体层

            //5.1、检查传进去的对象属性是否合法
            try
            {
                clsFeatureFuncRelaBL.CheckPropertyNew(objFeatureFuncRelaEN);
                //6、把数据实体层的数据存贮到数据库中
                clsFeatureFuncRelaBL.AddNewRecordBySql2(objFeatureFuncRelaEN);
            }
            catch (Exception objException)
            {
                strMsg = "(errid:WebI000005)添加记录不成功!" + objException.Message;
                throw new Exception(strMsg);
                //return false;
            }
            strMsg = "添加记录成功!";

            return true;
        }
        /// <summary>
        /// 根据功能Id获取函数对象列表
        /// </summary>
        /// <param name="strFeatureId">功能Id</param>
        /// <returns>函数对象列表</returns>
        public static List<clsFunction4CodeEN> GetFunction4CodeObjLstByFeatureId(string strFeatureId)
        {
            string strCondtion = string.Format("{0} in (Select {0} From {1} Where {2}='{3}')",
                conFunction4Code.FuncId4Code,
                clsFeatureFuncRelaEN._CurrTabName,
                conFeatureFuncRela.FeatureId,
                strFeatureId);
            List<clsFunction4CodeEN> arrFunction4CodeObjLst = clsFunction4CodeBL.GetObjLst(strCondtion);
            return arrFunction4CodeObjLst;
        }


        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKeyCache)
        /// </summary>
        /// <param name = "strFeatureId">功能Id</param>
        /// <returns>根据关键字获取的对象</returns>
        public static List<clsFeatureFuncRelaEN> GetObjLstByFeatureIdCacheEx(string strFeatureId)
        {
            //初始化列表缓存
            List<clsFeatureFuncRelaEN> arrObjLstCache = clsFeatureFuncRelaBL.GetObjLstCache();

            IEnumerable<clsFeatureFuncRelaEN> arrFeatureFuncRelaObjLst_Sel1 =
            from objFeatureFuncRelaEN in arrObjLstCache
            where objFeatureFuncRelaEN.FeatureId == strFeatureId
            select objFeatureFuncRelaEN;
            List<clsFeatureFuncRelaEN> arrFeatureFuncRelaObjLst_Sel = new List<clsFeatureFuncRelaEN>();
            foreach (clsFeatureFuncRelaEN obj in arrFeatureFuncRelaObjLst_Sel1)
            {
                arrFeatureFuncRelaObjLst_Sel.Add(obj);
            }
            return arrFeatureFuncRelaObjLst_Sel;
        }

    }
}