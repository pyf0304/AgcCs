using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;

using AGC.DAL;
using System.Collections;
using System.Data;
using AGC.BusinessLogic;
using com.taishsoft.commdb;

namespace AGC.BusinessLogicEx
{
    public partial class clsPrjDataBaseBLEx : clsPrjDataBaseBL
    {    
        ///绑定下拉框的函数代码
        public static void BindDdl_PrjDataBaseIdEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            System.Data.DataTable objDT = clsPrjDataBaseBL.GetDataTable_PrjDataBase("UseStateId = '0001' Order By PrjDataBaseName");
            objDDL.DataValueField = "PrjDataBaseId";
            objDDL.DataTextField = "PrjDataBaseName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        ///绑定下拉框的函数代码
        public static void BindDdl_PrjDataBaseIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format("UseStateId = '0001' and PrjDataBaseId in (Select PrjDataBaseId from ProjectDatabaseRel where PrjId = '{0}')  Order By PrjDataBaseName", strPrjId);
            System.Data.DataTable objDT = clsPrjDataBaseBL.GetDataTable_PrjDataBase(strCondition);
            objDDL.DataValueField = "PrjDataBaseId";
            objDDL.DataTextField = "PrjDataBaseName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        public static void BindCbo_PrjDataBaseIdEx(System.Windows.Forms.ComboBox objComboBox, string strPrjId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("UseStateId = '0001' and PrjDataBaseId in (Select PrjDataBaseId from ProjectDatabaseRel where PrjId = '{0}')  Order By PrjDataBaseName", strPrjId);
       List<clsPrjDataBaseEN>     arrObj = clsPrjDataBaseBL.GetObjLst(strCondition);
           clsPrjDataBaseEN objPrjDataBaseEN;
            //初始化一个对象列表
            ArrayList PrjDataBaseList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objPrjDataBaseEN = new clsPrjDataBaseEN();
            objPrjDataBaseEN.PrjDataBaseId = "0";
            objPrjDataBaseEN.PrjDataBaseName = "请选择...";
            PrjDataBaseList.Add(objPrjDataBaseEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (clsPrjDataBaseEN objRow in arrObj)
            {              
                PrjDataBaseList.Add(objRow);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = PrjDataBaseList;
            objComboBox.ValueMember = "PrjDataBaseId";
            objComboBox.DisplayMember = "PrjDataBaseName";
            objComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 根据关键字strPrjDataBaseId获取连接串
        /// </summary>
        /// <param name = "strPrjDataBaseId">关键字</param>
        /// <returns>连接串</returns>
        public static string GetConnectString(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            //获得连接字符串
            StringBuilder sbConnectString = new StringBuilder();
            if (objPrjDataBaseEN.DataBaseTypeId  ==  "01" || objPrjDataBaseEN.DataBaseTypeId  ==  "02")
            {
                sbConnectString.AppendFormat("server = {0};", objPrjDataBaseEN.IpAddress);
                sbConnectString.AppendFormat("database = {0};", objPrjDataBaseEN.DataBaseName);
                sbConnectString.AppendFormat("uid = {0};", objPrjDataBaseEN.DataBaseUserId);
                sbConnectString.AppendFormat("pwd = {0};", objPrjDataBaseEN.DataBasePwd);
            }
            else if (objPrjDataBaseEN.DataBaseTypeId  ==  "03")
            {

                sbConnectString.Append("Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)");
                sbConnectString.AppendFormat("(HOST = {0})",
                    objPrjDataBaseEN.IpAddress);
                sbConnectString.Append("(PORT = 1521)))");
                sbConnectString.AppendFormat("(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = {0})));",
                    objPrjDataBaseEN.Sid);
                sbConnectString.AppendFormat("User Id = {0};Password = {1};",
                    objPrjDataBaseEN.DataBaseUserId,
                    objPrjDataBaseEN.DataBasePwd);

            }
            else
            {
                return "";
            }
            return sbConnectString.ToString();
        }


        /// <summary>
        /// 根据关键字strPrjDataBaseId获取连接串
        /// </summary>
        /// <param name = "objPrjDataBaseEN">数据库对象</param>
        /// <returns>连接串</returns>
        public static string GetConnectString(clsPrjDataBaseEN objPrjDataBaseEN)
        {
           
            //获得连接字符串
            StringBuilder sbConnectString = new StringBuilder();
            if (objPrjDataBaseEN.DataBaseTypeId  ==  "01" || objPrjDataBaseEN.DataBaseTypeId  ==  "02")
            {
                sbConnectString.AppendFormat("server = {0};", objPrjDataBaseEN.IpAddress);
                sbConnectString.AppendFormat("database = {0};", objPrjDataBaseEN.DataBaseName);
                sbConnectString.AppendFormat("uid = {0};", objPrjDataBaseEN.DataBaseUserId);
                sbConnectString.AppendFormat("pwd = {0};", objPrjDataBaseEN.DataBasePwd);
            }
            else if (objPrjDataBaseEN.DataBaseTypeId  ==  "03")
            {

                sbConnectString.Append("Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)");
                sbConnectString.AppendFormat("(HOST = {0})",
                    objPrjDataBaseEN.IpAddress);
                sbConnectString.Append("(PORT = 1521)))");
                sbConnectString.AppendFormat("(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = {0})));",
                    objPrjDataBaseEN.Sid);
                sbConnectString.AppendFormat("User Id = {0};Password = {1};",
                    objPrjDataBaseEN.DataBaseUserId,
                    objPrjDataBaseEN.DataBasePwd);

            }
            else
            {
                return "";
            }
            return sbConnectString.ToString();
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name = "strPrjDataBaseId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsPrjDataBaseENEx GetPrjDataBaseENExObjByPrjDataBaseId(string strPrjDataBaseId)
        {
            List<clsPrjDataBaseEN> arrObjLstCache = clsPrjDataBaseBL.GetObjLstCache();

            foreach (clsPrjDataBaseEN objPrjDataBaseEN in arrObjLstCache)
            {
                if (objPrjDataBaseEN.PrjDataBaseId  ==  strPrjDataBaseId)
                {
                    clsPrjDataBaseENEx objPrjDataBaseENEx = new clsPrjDataBaseENEx(objPrjDataBaseEN);
                    return objPrjDataBaseENEx;
                }
            }
            return null;
        }

        /// <summary>
        /// 从缓存中获取所有正在使用的工程对象列表.
        /// </summary>
        /// <returns>从缓存中获取所有正在使用的工程对象列表</returns>
        public static List<clsPrjDataBaseEN> GetAllPrjDataBaseObjLstCacheEx(string strUseStateId)
        {
            clsPrjDataBaseBL.InitListCache();
            //string strWhereCond = string.Format("1 = 1 order by {0}", conPrjDataBase.PrjDataBaseName);
            //if (arrPrjDataBaseObjLstSortByNameCache == null)
            //{
            //    arrPrjDataBaseObjLstSortByNameCache = new clsPrjDataBaseDA().GetObjLst(strWhereCond);
            //}

            //List<clsPrjDataBaseEN> arrPrjDataBaseObjLst = new List<clsPrjDataBaseEN>();
            List<clsPrjDataBaseEN> arrObjLstCache = clsPrjDataBaseBL.GetObjLstCache();

            IEnumerable<clsPrjDataBaseEN> arrPrjDataBaseObjLst_Sel1 =
                from objPrjDataBaseEN in arrObjLstCache
                where objPrjDataBaseEN.UseStateId == strUseStateId
                select objPrjDataBaseEN;


            List<clsPrjDataBaseEN> arrPrjDataBaseObjLst_Sel = arrPrjDataBaseObjLst_Sel1.OrderBy(x=>x.PrjDataBaseName).ToList();
            return arrPrjDataBaseObjLst_Sel;
        }

        /// <summary>
        /// 绑定基于Web的下拉框-使用Cache
        /// (AGC.BusinessLogicEx.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_PrjDataBaseIdCacheEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            List<clsPrjDataBaseEN> arrPrjDataBaseObjLst = GetAllPrjDataBaseObjLstCacheEx("0001");//正在使用中的工程对象
            objDDL.DataValueField = conPrjDataBase.PrjDataBaseId;
            objDDL.DataTextField = conPrjDataBase.PrjDataBaseName;
            objDDL.DataSource = arrPrjDataBaseObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }



        /// <summary>
        /// 设置工程使用
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static bool SetInUse(string strPrjId)
        {
            clsPrjDataBaseBL.SetFldValue(clsPrjDataBaseEN._CurrTabName, conPrjDataBase.UseStateId, "0001", string.Format("{0} = '{1}'", conPrjDataBase.PrjDataBaseId, strPrjId));

            return true;
        }

        /// <summary>
        /// 设置工程不使用
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <returns></returns>
        public static bool SetNotInUse(string strPrjId)
        {
            clsPrjDataBaseBL.SetFldValue(clsPrjDataBaseEN._CurrTabName, conPrjDataBase.UseStateId, "0002", string.Format("{0} = '{1}'", conPrjDataBase.PrjDataBaseId, strPrjId));

            return true;
        }
    }
}
