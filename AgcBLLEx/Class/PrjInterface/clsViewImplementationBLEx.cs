
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsViewImplementationBLEx
表名:ViewImplementation
生成代码版本:2018.03.11.1
生成日期:2018/03/17 16:38:56
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
模块中文名:界面管理
模块英文名:PrjInterface
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

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 界面实现方式(ViewImplementation)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsViewImplementationBLEx : clsViewImplementationBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsViewImplementationDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsViewImplementationDAEx ViewImplementationDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsViewImplementationDAEx();
                }
                return uniqueInstanceEx;
            }
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strFeatureId">功能Id</param>
        public static void BindDdl_ViewImplIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strFeatureId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format("1 =1 and {0} in (Select {0} from {1} where {2}='{3}') Order By {0}", 
                conViewImplementation.ViewImplId,
                clsFeatureImplementationEN._CurrTabName,
                conFeatureImplementation.FeatureId,
                strFeatureId);
            System.Data.DataTable objDT = clsViewImplementationBL.GetDataTable(strCondition);
            objDDL.DataValueField = conViewImplementation.ViewImplId;
            objDDL.DataTextField = conViewImplementation.ViewImplName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
    }
}