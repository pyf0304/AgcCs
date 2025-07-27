
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsWebApiIPAndPortTabBLEx
表名:WebApiIPAndPortTab(00050529)
生成代码版本:2019.12.06.1
生成日期:2019/12/21 16:02:36
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:系统设置
模块英文名:SystemSet
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
    public static class clsWebApiIPAndPortTabBLEx_Static
    {

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        public static bool AddRecordEx2(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
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
                objWebApiIPAndPortTabEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objWebApiIPAndPortTabEN.AddNewRecord();
            }
            catch (Exception objException)
            {
                strMsg = "(errid:BlEx000003)添加记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_UpdateRecordEx)
        /// </summary>
        /// <param name = "objWebApiIPAndPortTabEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool UpdateRecordEx2(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            try
            {
                //1、检查传进去的对象属性是否合法
                objWebApiIPAndPortTabEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objWebApiIPAndPortTabEN.Update();
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
        /// <param name = "objWebApiIPAndPortTab">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx2(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTab)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsWebApiIPAndPortTabEN objWebApiIPAndPortTab_Cond = new clsWebApiIPAndPortTabEN();
            string strCondition = objWebApiIPAndPortTab_Cond
            .SetWebApiIPAndPort(objWebApiIPAndPortTab.WebApiIPAndPort, "=")
            .SetWebApiVirtualPath(objWebApiIPAndPortTab.WebApiVirtualPath, "=")
            .GetCombineCondition();
            objWebApiIPAndPortTab._IsCheckProperty = true;
            bool bolIsExist = clsWebApiIPAndPortTabBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objWebApiIPAndPortTab.mId = clsWebApiIPAndPortTabBL.GetFirstID_S(strCondition);
                objWebApiIPAndPortTab.UpdateWithCondition(strCondition);
            }
            else
            {
                objWebApiIPAndPortTab.AddNewRecord();
            }
            return true;
        }


        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objWebApiIPAndPortTabENS">源对象</param>
        /// <returns>目标对象=>clsWebApiIPAndPortTabEN:objWebApiIPAndPortTabENT</returns>
        public static clsWebApiIPAndPortTabENEx CopyToEx(this clsWebApiIPAndPortTabEN objWebApiIPAndPortTabENS)
        {
            try
            {
                clsWebApiIPAndPortTabENEx objWebApiIPAndPortTabENT = new clsWebApiIPAndPortTabENEx();
                clsWebApiIPAndPortTabBL.WebApiIPAndPortTabDA.CopyTo(objWebApiIPAndPortTabENS, objWebApiIPAndPortTabENT);
                return objWebApiIPAndPortTabENT;
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
        /// <param name = "objWebApiIPAndPortTabENS">源对象</param>
        /// <returns>目标对象=>clsWebApiIPAndPortTabEN:objWebApiIPAndPortTabENT</returns>
        public static clsWebApiIPAndPortTabEN CopyTo(this clsWebApiIPAndPortTabENEx objWebApiIPAndPortTabENS)
        {
            try
            {
                clsWebApiIPAndPortTabEN objWebApiIPAndPortTabENT = new clsWebApiIPAndPortTabEN();
                clsWebApiIPAndPortTabBL.CopyTo(objWebApiIPAndPortTabENS, objWebApiIPAndPortTabENT);
                return objWebApiIPAndPortTabENT;
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
    /// WebApiIP表(WebApiIPAndPortTab)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsWebApiIPAndPortTabBLEx : clsWebApiIPAndPortTabBL
    {
        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "strFeatureTypeId">需要绑定当前表的下拉框</param>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        public static void BindCbo_WebApiIPAndPortVirtualPath(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format(" 1=1  Order by {0}",
            conWebApiIPAndPortTab.OrderNum);

            List<clsWebApiIPAndPortTabEN> arrObjLst = clsWebApiIPAndPortTabBL.GetObjLst(strCondition);
            arrObjLst.ForEach(x=>  x.WebApiIPAndPort = string.Format("{0}/{1}/Api/", x.WebApiIPAndPort, x.WebApiVirtualPath) );
            //初始化一个对象列表
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN()
            {
                mId = 0,
                WebApiIPAndPort = "选[WApiIP]..."
            };
            arrObjLst.Insert(0, objWebApiIPAndPortTabEN);
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conWebApiIPAndPortTab.mId;
            objComboBox.DisplayMember = conWebApiIPAndPortTab.WebApiIPAndPort;
            objComboBox.DataSource = arrObjLst;
            objComboBox.SelectedIndex = 0;
        }


        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsWebApiIPAndPortTabDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsWebApiIPAndPortTabDAEx WebApiIPAndPortTabDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsWebApiIPAndPortTabDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="lngmId">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(long lngmId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
            //删除TeacherInfo本表中与当前对象有关的记录
            SqlConnection objConnection = null;
            SqlTransaction objSqlTransaction = null;
            try
            {
                //获取连接对象
                objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
                //获取该连接对象中的事务
                objSqlTransaction = objConnection.BeginTransaction();
                //
                //删除与表:[WebApiIPAndPortTab]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conWebApiIPAndPortTab.mId,
                //lngmId);
                //        clsWebApiIPAndPortTabBL.DelWebApiIPAndPortTabsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsWebApiIPAndPortTabBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsWebApiIPAndPortTabBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                lngmId, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
                if (objSqlTransaction != null)
                {
                    objSqlTransaction.Rollback();
                }
                throw new Exception(strMsg);
            }
            finally
            {
                objConnection.Close();
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsWebApiIPAndPortTabENEx> GetObjExLst(string strCondition)
        {
            List<clsWebApiIPAndPortTabEN> arrObjLst = clsWebApiIPAndPortTabBL.GetObjLst(strCondition);
            List<clsWebApiIPAndPortTabENEx> arrObjExLst = new List<clsWebApiIPAndPortTabENEx>();
            foreach (clsWebApiIPAndPortTabEN objInFor in arrObjLst)
            {
                clsWebApiIPAndPortTabENEx objWebApiIPAndPortTabENEx = new clsWebApiIPAndPortTabENEx();
                clsWebApiIPAndPortTabBL.CopyTo(objInFor, objWebApiIPAndPortTabENEx);
                arrObjExLst.Add(objWebApiIPAndPortTabENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsWebApiIPAndPortTabENEx GetObjExBymId(long lngmId)
        {
            clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = clsWebApiIPAndPortTabBL.GetObjBymId(lngmId);
            clsWebApiIPAndPortTabENEx objWebApiIPAndPortTabENEx = new clsWebApiIPAndPortTabENEx();
            clsWebApiIPAndPortTabBL.CopyTo(objWebApiIPAndPortTabEN, objWebApiIPAndPortTabENEx);
            return objWebApiIPAndPortTabENEx;
        }
    }
}