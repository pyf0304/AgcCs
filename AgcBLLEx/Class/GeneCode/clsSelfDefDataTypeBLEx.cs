
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsSelfDefDataTypeBLEx
表名:SelfDefDataType
生成代码版本:2017.07.08.1
生成日期:2017/07/29 22:55:11
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:生成C#代码
模块英文名:GeneCode
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.07.14.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
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
    /// <summary>
    /// 自定义数据类型(SelfDefDataType)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsSelfDefDataTypeBLEx : clsSelfDefDataTypeBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsSelfDefDataTypeDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsSelfDefDataTypeDAEx SelfDefDataTypeDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsSelfDefDataTypeDAEx();
                }
                return uniqueInstanceEx;
            }
        }
        public static bool AddNewSelfDefDataType(string strDataTypeName, 
            string strPrjId, string strUpdUser)
        {
            clsSelfDefDataTypeEN objSelfDefDataTypeEN = new clsSelfDefDataTypeEN();
            objSelfDefDataTypeEN.SdDataTypeId =clsSelfDefDataTypeBL.GetMaxStrId_S();// 自定义数据类型Id
            objSelfDefDataTypeEN.DataTypeName = strDataTypeName;// 数据类型名称
            objSelfDefDataTypeEN.DataCnName = strDataTypeName;// 数据类型中文名称
            objSelfDefDataTypeEN.DataTypeAbbr = "";// 数据类型缩写
            objSelfDefDataTypeEN.VbNetType = strDataTypeName;// VBNET类型
            objSelfDefDataTypeEN.CsType = strDataTypeName;// CS类型
            objSelfDefDataTypeEN.JavaType = strDataTypeName;// JAVA类型
            objSelfDefDataTypeEN.JavaObjType = strDataTypeName;// JAVA对象类型
            objSelfDefDataTypeEN.SwiftType = strDataTypeName;// SwiftType
            objSelfDefDataTypeEN.OraDbType = strDataTypeName;// Ora数据类型
            objSelfDefDataTypeEN.SqlParaType = strDataTypeName;// SQL参数类型
            objSelfDefDataTypeEN.MySqlType = strDataTypeName;// MySqlType
            objSelfDefDataTypeEN.PrjId = strPrjId;// 工程ID
            objSelfDefDataTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);// 修改日期
            objSelfDefDataTypeEN.UpdUser = strUpdUser;// 修改者
            objSelfDefDataTypeEN.Memo = "";// 说明
            string strCondition_Exist = string.Format("{0}='{1}'",
                conSelfDefDataType.DataTypeName, strDataTypeName );
            if (clsSelfDefDataTypeBL.IsExistRecord(strCondition_Exist) == false)
            {
                clsSelfDefDataTypeBL.AddNewRecordBySql2(objSelfDefDataTypeEN);
            }
            return true;
        }

        /// <summary>
        /// 功能:为函数参数表中的参数类型设置是否为已知
        /// </summary>
        /// <returns>如果设置成功则返回TRUE,否则为FALSE</returns>
        public static bool p_set_KnownType4Para()
        {
            //通过存储过程来
            //直接使用
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsFunctionTemplateRelaDA.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();

            objSQL.ExecSP2("p_set_KnownType4Para", values);
            return true;
        }

        /// <summary>
        /// 功能:为函数表中的返回类型设置是否为已知
        /// </summary>
        /// <returns>如果设置成功则返回TRUE,否则为FALSE</returns>
        public static bool p_set_KnownType4Func()
        {
            //通过存储过程来
            //直接使用
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsFunctionTemplateRelaDA.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();

            objSQL.ExecSP2("p_set_KnownType4Func", values);
            return true;
        }
/// <summary>
/// 根据名称获取自定义数据类型
/// </summary>
/// <param name="strDataTypeName"></param>
/// <returns></returns>
        public static clsSelfDefDataTypeEN getSelfDefDataTypeByDataTypeName(string strDataTypeName)
        {
            string strCondition = string.Format("{0}='{1}'",
                 conSelfDefDataType.DataTypeName, strDataTypeName);
            clsSelfDefDataTypeEN objSelfDefDataTypeEN = clsSelfDefDataTypeBL.GetFirstObj_S(strCondition);
            return objSelfDefDataTypeEN;
        }
    }
}