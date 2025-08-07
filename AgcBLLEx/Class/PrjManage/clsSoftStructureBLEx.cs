
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsSoftStructureBLEx
表名:SoftStructure
生成代码版本:2017.05.06.1
生成日期:2017/05/07
生成者:
工程名称:AGC_CSV7
工程ID:0005
模块中文名:工程管理
模块英文名:PrjManage
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
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

namespace AGC.BusinessLogicEx
{
    /// <summary>
    /// 软件架构(SoftStructure)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsSoftStructureBLEx : clsSoftStructureBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsSoftStructureDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsSoftStructureDAEx SoftStructureDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsSoftStructureDAEx();
                }
                return uniqueInstanceEx;
            }
        }




        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_SoftStructure(System.Windows.Forms.ListView lvSoftStructure, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviSoftStructure;
            List<clsSoftStructureEN> arrSoftStructureObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrSoftStructureObjList = clsSoftStructureBL.GetObjLst(strWhereCond);
            //	3、设置ListView的列头信息
            lvSoftStructure.Items.Clear();//清除原来所有Item
            lvSoftStructure.Columns.Clear();//清除原来所有列头信息
            lvSoftStructure.Columns.Add("架构ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSoftStructure.Columns.Add("架构名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSoftStructure.Columns.Add("架构描述", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSoftStructure.Columns.Add("说明", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSoftStructure.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsSoftStructureEN objSoftStructure in arrSoftStructureObjList)
            {
                lviSoftStructure = new System.Windows.Forms.ListViewItem();
                lviSoftStructure.Tag = objSoftStructure.SoftStructureId;
                lviSoftStructure.Text = objSoftStructure.SoftStructureId.ToString();
                lviSoftStructure.SubItems.Add(objSoftStructure.SoftStructureName);
                lviSoftStructure.SubItems.Add(objSoftStructure.SoftStructureDesc);
                lviSoftStructure.SubItems.Add(objSoftStructure.Memo);
                lvSoftStructure.Items.Add(lviSoftStructure);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrSoftStructureObjList.Count;
        }
    }
}