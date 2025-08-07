using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.commdb;
using com.taishsoft.common;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public static class clsFunctionTemplateRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objFunctionTemplateRelaENS">源对象</param>
        /// <returns>目标对象=>clsFunctionTemplateRelaEN:objFunctionTemplateRelaENT</returns>
        public static clsFunctionTemplateRelaEN CopyTo(this clsFunctionTemplateRelaENEx objFunctionTemplateRelaENS)
        {
            try
            {
                clsFunctionTemplateRelaEN objFunctionTemplateRelaENT = new clsFunctionTemplateRelaEN();
                clsFunctionTemplateRelaBL.CopyTo(objFunctionTemplateRelaENS, objFunctionTemplateRelaENT);
                return objFunctionTemplateRelaENT;
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
        /// <param name = "objFunctionTemplateRelaENS">源对象</param>
        /// <returns>目标对象=>clsFunctionTemplateRelaEN:objFunctionTemplateRelaENT</returns>
        public static clsFunctionTemplateRelaENEx CopyToEx(this clsFunctionTemplateRelaEN objFunctionTemplateRelaENS)
        {
            try
            {
                clsFunctionTemplateRelaENEx objFunctionTemplateRelaENT = new clsFunctionTemplateRelaENEx();
                clsFunctionTemplateRelaBL.FunctionTemplateRelaDA.CopyTo(objFunctionTemplateRelaENS, objFunctionTemplateRelaENT);
                return objFunctionTemplateRelaENT;
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
        /// <param name = "objFunctionTemplateRelaEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool UpdateRecordEx2(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            try
            {
                //1、检查传进去的对象属性是否合法
                objFunctionTemplateRelaEN.CheckPropertyNew();
                //4、把数据实体层的数据存贮到数据库中
                objFunctionTemplateRelaEN.Update();
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
        /// <param name = "objFunctionTemplateRela">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx2(this clsFunctionTemplateRelaEN objFunctionTemplateRela)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            clsFunctionTemplateRelaEN objFunctionTemplateRela_Cond = new clsFunctionTemplateRelaEN();
            string strCondition = objFunctionTemplateRela_Cond
            .SetCodeTypeId(objFunctionTemplateRela.CodeTypeId, "=")
            .SetFuncId4GC(objFunctionTemplateRela.FuncId4GC, "=")
            .SetFunctionTemplateId(objFunctionTemplateRela.FunctionTemplateId, "=")
            .GetCombineCondition();
            objFunctionTemplateRela._IsCheckProperty = true;
            bool bolIsExist = clsFunctionTemplateRelaBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objFunctionTemplateRela.mId = clsFunctionTemplateRelaBL.GetFirstID_S(strCondition);
                objFunctionTemplateRela.UpdateWithCondition(strCondition);
            }
            else
            {
                objFunctionTemplateRela.AddNewRecord();
            }
            return true;
        }

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        public static bool AddRecordEx2(this clsFunctionTemplateRelaEN objFunctionTemplateRelaEN)
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
                objFunctionTemplateRelaEN.CheckPropertyNew();
                //6、把数据实体层的数据存贮到数据库中
                objFunctionTemplateRelaEN.AddNewRecord();
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
    /// 
    /// </summary>
    public class clsFunctionTemplateRelaBLEx : clsFunctionTemplateRelaBL
    {
        /// <summary>
        /// 把一批记录移到最顶部
        /// </summary>
        /// <param name="arrKeyId">需要移动的记录关键字列表</param>
        /// <param name="strFunctionTemplateId">模板Id</param>
        /// <param name="strCodeTypeId">层类型Id</param>
        /// <param name="strProgLangTypeId">语言类型Id</param>
        /// <returns></returns>
        public static bool GoTop(List<long> arrKeyId, string strFunctionTemplateId, string strCodeTypeId)
        {
            try
            {
                bool bolResult = new clsFunctionTemplateRelaDAEx().GoTop(arrKeyId, strFunctionTemplateId, strCodeTypeId);
                bolResult = new clsFunctionTemplateRelaDAEx().ReOrder(strFunctionTemplateId, strCodeTypeId);

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错!\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 把一批记录移到最底部
        /// </summary>
        /// <param name="arrKeyId">需要移动的记录关键字列表</param>
        /// <param name="strFunctionTemplateId">模板Id</param>
        /// <param name="strCodeTypeId">层类型Id</param>
        /// <param name="strProgLangTypeId">语言类型Id</param>
        /// <returns></returns>
        public static bool GoBottom(List<long> arrKeyId, string strFunctionTemplateId, string strCodeTypeId)
        {
            try
            {
                bool bolResult = new clsFunctionTemplateRelaDAEx().GoBottom(arrKeyId, strFunctionTemplateId, strCodeTypeId);
                bolResult = new clsFunctionTemplateRelaDAEx().ReOrder(strFunctionTemplateId, strCodeTypeId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错!\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 调整次序。
        /// </summary>
        /// <param name="strDirect">方向：向上、向下</param>
        /// <param name="lngMid">需要调整记录的关键字</param>
        /// <returns></returns>
        public static bool AdjustSequenceNumber(string strDirect, long lngMid)
        {
            try
            {
                bool bolResult = new clsFunctionTemplateRelaDAEx().AdjustSequenceNumber(strDirect, lngMid);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错!\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 重序。针对模板Id的所有函数重序
        /// </summary>
        /// <param name="strFunctionTemplateId">模板Id</param>
        /// <param name="strCodeTypeId">层类型Id</param>
        /// <param name="strProgLangTypeId">语言类型Id</param>
        /// <returns></returns>
        public static bool ReOrder(string strFunctionTemplateId, string strCodeTypeId)
        {
            try
            {
                bool bolResult = new clsFunctionTemplateRelaDAEx().ReOrder(strFunctionTemplateId, strCodeTypeId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错!\r\n" + objException.Message);
            }

        }
             /// <summary>
        /// 功能:为函数模板关系设置编程语言、层类型
        /// </summary>
        /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
        public static bool p_Set_ProgLangType4FuncTempRela()
        {
            //通过存储过程来
            //直接使用
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsFunctionTemplateRelaDA.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();

            objSQL.ExecSP2("p_Set_ProgLangType4FuncTempRela", values);
            return true;
        }

        /// <summary>
        /// 从缓存中获取满足条件所有【系统缺省值名称】对象列表.
        /// </summary>
        /// <param name = "strFunctionTemplateId">工程</param>  
        /// <param name = "ltLangType">语言类型</param>
        /// <param name = "strCodeTypeId">层类型Id</param>
        /// <param name = "strSqlDsTypeId">数据源类型</param>
        /// <returns>从缓存中获取所有正在使用的用户缺省值列表</returns>
        public static List<clsFunctionTemplateRelaEN> GetAllFunctionTemplateRelaObjLstCacheEx(
            string strFunctionTemplateId,
            clsPubConst.LangType ltLangType,
            string strCodeTypeId)
        {
            string strProgLangTypeId = clsProgLangTypeBLEx.GetProgLangTypeIdByLangTypeCache(ltLangType);
            //List<string> arrSqlDsTypeIdLst = new List<string>();
            //arrSqlDsTypeIdLst.Add("00");
            //arrSqlDsTypeIdLst.Add(strSqlDsTypeId);
            clsFunctionTemplateRelaBL.InitListCache();

            List<clsFunctionTemplateRelaEN> arrObjLstCache = clsFunctionTemplateRelaBL.GetObjLstCache();

            IEnumerable<clsFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLst_Sel1 =
                from objFunctionTemplateRelaEN in arrObjLstCache
                where objFunctionTemplateRelaEN.FunctionTemplateId == strFunctionTemplateId
                && objFunctionTemplateRelaEN.CodeTypeId == strCodeTypeId                
                select objFunctionTemplateRelaEN;


            List<clsFunctionTemplateRelaEN> arrFunctionTemplateRelaObjLst_Sel = new List<clsFunctionTemplateRelaEN>();
            foreach (clsFunctionTemplateRelaEN obj in arrFunctionTemplateRelaObjLst_Sel1)
            {
                arrFunctionTemplateRelaObjLst_Sel.Add(obj);
            }

            return arrFunctionTemplateRelaObjLst_Sel;
        }


    }
}
