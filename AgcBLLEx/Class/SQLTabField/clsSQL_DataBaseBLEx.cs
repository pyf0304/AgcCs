using System;
using System.Data;
using System.Text;
using System.Collections;
using com.taishsoft.commdb;
using AGC.Entity;
using System.Collections.Generic;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    public partial class clsSQL_DataBaseBLEx : clsSQL_DataBaseBL
    {

      

        ///绑定下拉框的函数代码

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能:根据界面上查询控件中所设置内容查询表记录,
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_SQL_DataBase(System.Windows.Forms.ListView lvSQL_DataBase, string strWhereCond)
        {
            //操作步骤:(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviSQL_DataBase;
            List<clsSQL_DataBaseEN> arrSQL_DataBaseObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrSQL_DataBaseObjList = clsSQL_DataBaseBL.GetObjLst(strWhereCond);
            //	3、设置ListView的列头信息
            lvSQL_DataBase.Items.Clear();//清除原来所有Item
            lvSQL_DataBase.Columns.Clear();//清除原来所有列头信息
            lvSQL_DataBase.Columns.Add("数据库名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSQL_DataBase.Columns.Add("服务器", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSQL_DataBase.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSQL_DataBase.Columns.Add("口令", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSQL_DataBase.Columns.Add("用户ID4Master", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSQL_DataBase.Columns.Add("口令4Master", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSQL_DataBase.Columns.Add("工程ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvSQL_DataBase.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsSQL_DataBaseEN objSQL_DataBase in arrSQL_DataBaseObjList)
            {
                lviSQL_DataBase = new System.Windows.Forms.ListViewItem();
                lviSQL_DataBase.Tag = objSQL_DataBase.DataBaseName;
                lviSQL_DataBase.Text = objSQL_DataBase.DataBaseName;
                lviSQL_DataBase.SubItems.Add(objSQL_DataBase.Server);
                lviSQL_DataBase.SubItems.Add(objSQL_DataBase.UserId);
                lviSQL_DataBase.SubItems.Add(objSQL_DataBase.Password);
                lviSQL_DataBase.SubItems.Add(objSQL_DataBase.UserIdForMaster);
                lviSQL_DataBase.SubItems.Add(objSQL_DataBase.PasswordForMaster);
                lviSQL_DataBase.SubItems.Add(objSQL_DataBase.PrjId);
                lvSQL_DataBase.Items.Add(lviSQL_DataBase);
            }
            //	4、设置记录数的状态,
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrSQL_DataBaseObjList.Count;
        }
        /// <summary>
        /// 获取指定服务器的所有数据库
        /// </summary>
        /// <returns>返回所有数据库的DataTable</returns>
        public System.Data.DataTable getDataBases(clsSQL_DataBaseEN objSQL_DataBaseEN)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objSQL_DataBaseEN.Server, "master",
               objSQL_DataBaseEN.UserIdForMaster, objSQL_DataBaseEN.PasswordForMaster);
            objDT = objSQL.getDataBases();
            return objDT;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public System.Data.DataTable getTables(clsSQL_DataBaseEN objSQL_DataBaseEN)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objSQL_DataBaseEN.Server,
                objSQL_DataBaseEN.DataBaseName,
                objSQL_DataBaseEN.UserId,
                objSQL_DataBaseEN.Password);
            objDT = objSQL.getTables();
            return objDT;
        }

        /// <summary>
        /// 获取当前数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的ArrayList</returns>
        public ArrayList getTablesList(clsSQL_DataBaseEN objSQL_DataBaseEN)
        {
            ArrayList arrTablesList = new ArrayList();
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objSQL_DataBaseEN.Server,
                objSQL_DataBaseEN.DataBaseName,
                objSQL_DataBaseEN.UserId,
                objSQL_DataBaseEN.Password);
            objDT = objSQL.getTables();

            foreach (DataRow objRow in objDT.Rows)
            {
                string strTabName = objRow["name"].ToString().Trim();
                arrTablesList.Add(strTabName);
            }

            return arrTablesList;
        }


        /// <summary>
        /// 获取当前数据库中所有表对象的列表。
        /// </summary>
        /// <returns>所有表名的对象ArrayList</returns>
        public ArrayList getTablesObjList(clsSQL_DataBaseEN objSQL_DataBaseEN)
        {
            ArrayList arrTablesObjList = new ArrayList();
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objSQL_DataBaseEN.Server,
                objSQL_DataBaseEN.DataBaseName,
                objSQL_DataBaseEN.UserId,
                objSQL_DataBaseEN.Password);
            objDT = objSQL.getTables();

            foreach (DataRow objRow in objDT.Rows)
            {
                clsTablesEN objTables = new clsTablesEN();
                objTables.TabName = objRow["name"].ToString().Trim();
                objTables.DataBaseName = objSQL_DataBaseEN.DataBaseName;
                arrTablesObjList.Add(objTables);
            }
            return arrTablesObjList;
        }

      
        public static clsSpecSQLforSql getSpecSQLByPrjDataBaseId(string strPrjDataBaseId)
        {
            if (strPrjDataBaseId  ==  null || strPrjDataBaseId  ==  "")
            {
                throw new Exception("PrjDataBaseId 为空,请设置一个合法的PrjDataBaseId(工程数据库号)!");
            }
//            bool bolResult = clsPrjDataBaseBL.IsExistRecord("PrjDataBaseId = '" + strPrjDataBaseId + "'");
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);

            if (objPrjDataBaseEN ==  null)
            {
                throw new Exception("非法PrjDataBaseId或PrjDataBaseId:" + strPrjDataBaseId + "' 不存在 ,请设置一个合法的PrjDataBaseId(工程数据库号)!");
            }
           
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objPrjDataBaseEN.IpAddress,
                objPrjDataBaseEN.DataBaseName,
                objPrjDataBaseEN.DataBaseUserId,
                objPrjDataBaseEN.DataBasePwd);
            return objSQL;
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有表名。
        /// </summary>
        /// <returns>所有表名的DataTable</returns>
        public bool IsExistTable(clsSQL_DataBaseEN objSQL_DataBaseEN, string strTabName)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objSQL_DataBaseEN.Server,
                objSQL_DataBaseEN.DataBaseName,
                objSQL_DataBaseEN.UserId,
                objSQL_DataBaseEN.Password);
            objDT = objSQL.getTables();
            if (objDT.Rows.Count  ==  0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 获取所定的服务器和数据库中所有VIEW名。
        /// </summary>
        /// <returns>所有View名的DataTable</returns>
        public System.Data.DataTable getViews(clsSQL_DataBaseEN objSQL_DataBaseEN)
        {
            System.Data.DataTable objDT;

            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(objSQL_DataBaseEN.Server,
                   objSQL_DataBaseEN.DataBaseName,
                  objSQL_DataBaseEN.UserId,
                   objSQL_DataBaseEN.Password);
            objDT = objSQL.getViews();
            return objDT;
        }
    }
}