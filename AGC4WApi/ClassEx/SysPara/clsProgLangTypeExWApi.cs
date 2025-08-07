
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsProgLangTypeExWApi
表名:ProgLangType(00050303)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:01:31
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:系统参数
模块英文名:SysPara
框架-层名:WebApi访问扩展层(WA_AccessEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Collections;
using com.taishsoft.common;
using System.ServiceModel;
using AGC.Entity;
using System.Collections.Generic;
using com.taishsoft.json;
using AgcCommBase;
using System.Reflection;
using System.Linq;

namespace AGC4WApi
{
    /// <summary>
    /// 编程语言类型(ProgLangType)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsProgLangTypeExWApi
    {
        private static readonly string mstrApiControllerName = "ProgLangTypeExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsProgLangTypeEN> arrProgLangTypeObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsProgLangTypeExWApi()
        {
        }
        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        public static void BindCbo_ProgLangTypeIdEx(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("{0}='1' Order by {1}",
                conProgLangType.IsVisible, conProgLangType.OrderNum);
            List<clsProgLangTypeEN> arrObj = clsProgLangTypeWApi.GetObjLst(strCondition);
            clsProgLangTypeEN objProgLangTypeEN;
            //初始化一个对象列表
            ArrayList ProgLangTypeList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objProgLangTypeEN = new clsProgLangTypeEN();
            objProgLangTypeEN.ProgLangTypeId = "0";
            objProgLangTypeEN.ProgLangTypeName = "请选择...";
            ProgLangTypeList.Add(objProgLangTypeEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (clsProgLangTypeEN objRow in arrObj)
            {
                ProgLangTypeList.Add(objRow);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = conProgLangType.ProgLangTypeId;
            objComboBox.DisplayMember = conProgLangType.ProgLangTypeName;
            objComboBox.DataSource = ProgLangTypeList;
            objComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 根据语言类型获取相关对象, 从缓存的对象列表中获取,使用顺序查询.
        /// </summary>
        /// <param name = "cnLangType">所给的语言类型</param>
        /// <returns>根据关键字获取的对象</returns>
        public static string GetProgLangTypeIdByLangType_Cache(clsPubConst.LangType cnLangType)
        {
            string strLangTypeName = clsPubConst.GetLangTypeStringByLangType(cnLangType);


            string strWhereCond = string.Format("1 = 1 order by ProgLangTypeId");

            List<clsProgLangTypeEN> arrProgLangTypeObjLst_Cache = clsProgLangTypeWApi.GetObjLstCache();
            foreach (clsProgLangTypeEN objProgLangTypeEN in arrProgLangTypeObjLst_Cache)
            {
                if (objProgLangTypeEN.ProgLangTypeName == strLangTypeName)
                {
                    intFindFailCount = 0;
                    return objProgLangTypeEN.ProgLangTypeId;
                }
            }

            return "";
        }

        /// <summary>
        /// 根据语言类型获取相关对象, 从缓存的对象列表中获取,使用顺序查询.
        /// </summary>
        /// <param name = "cnLangType">所给的语言类型</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsProgLangTypeEN GetObjByLangType_Cache(clsPubConst.LangType cnLangType)
        {
            string strLangTypeName = clsPubConst.GetLangTypeStringByLangType(cnLangType);


            string strWhereCond = string.Format("1 = 1 order by ProgLangTypeId");
            List<clsProgLangTypeEN> arrProgLangTypeObjLst_Cache = clsProgLangTypeWApi.GetObjLstCache();

            foreach (clsProgLangTypeEN objProgLangTypeEN in arrProgLangTypeObjLst_Cache)
            {
                if (objProgLangTypeEN.ProgLangTypeName == strLangTypeName)
                {
                    intFindFailCount = 0;
                    return objProgLangTypeEN;
                }
            }
            intFindFailCount++;
            // 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用

            if (intFindFailCount == 1) return GetObjByLangType_Cache(cnLangType);
            string strErrMsgForGetObjById = string.Format("在ProgLangType对象缓存列表中,找不到记录[cnLangType = {0}][intFindFailCount = {1}](函数:GetProgLangTypeObjByLangType_Cache)", strLangTypeName, intFindFailCount);
            clsLog.LogErrorS2("clsProgLangTypeBLEx", "GetProgLangTypeObjByLangType_Cache", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }
        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objRadioButtonList">需要绑定当前表的下拉框</param>
        public static void BindRbl_ProgLangTypeIdEx(TzWinCtrlLib.TzRadioButtonList objRadioButtonList)
        {
            string strCondition = string.Format("{0}='1' order by {1}",
             conProgLangType.IsVisible,
             conProgLangType.OrderNum);
            List<clsProgLangTypeEN> arrObj = clsProgLangTypeWApi.GetObjLst(strCondition);
            DataTable objDT = ToDataTable(arrObj);
            objRadioButtonList.DisplayMember = conProgLangType.ProgLangTypeName;
            objRadioButtonList.ValueMember = conProgLangType.ProgLangTypeId;
            objRadioButtonList.DataSource = objDT;
            //tzRadioButtonList1.DataSource = arrKcCrsTypeObjLst;
            objRadioButtonList.DataBind();

        }
        /// <summary>
        /// 对象列表 转换为 DataTable数据集合
        /// </summary>
        /// <param name="arrObj">原对象列表</param>
        /// <returns>返回的DataTable</returns>
        public static DataTable ToDataTable(List<clsProgLangTypeEN> arrObj)
        {
            DataTable dataTable = new DataTable(); //实例化
            DataTable result;

            if (arrObj.Count == 0) return null;
            if (clsProgLangTypeEN._AttributeName.Length == 0)
            {
                result = dataTable;
                return result;
            }
            Type type = typeof(clsProgLangTypeEN);
            PropertyInfo[] arrPropertyInfo = type.GetProperties();
            try
            {
                //Columns
                foreach (string strInFor in clsProgLangTypeEN._AttributeName)
                {
                    PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strInFor).First();
                    dataTable.Columns.Add(strInFor, proprety_Curr.PropertyType);
                }
                foreach (clsProgLangTypeEN objInFor in arrObj)
                {
                    //Rows
                    DataRow dataRow = dataTable.NewRow();
                    foreach (string current in clsProgLangTypeEN._AttributeName)
                    {
                        dataRow[current] = objInFor[current];
                    }
                    dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
                }

            }
            catch (Exception objExceptoin)
            {
                throw objExceptoin;
            }
            result = dataTable;
            return result;
        }



        //public static string ToJson(this DataTable dt)
        //{
        //    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
        //    javaScriptSerializer.MaxJsonLength = Int32.MaxValue; //取得最大数值
        //    ArrayList arrayList = javaScriptSerializer.Deserialize<ArrayList>(json);
        //    foreach (DataRow dataRow in dt.Rows)
        //    {
        //        Dictionary<string, object> dictionary = new Dictionary<string, object>(); //实例化一个参数集合
        //        foreach (DataColumn dataColumn in dt.Columns)
        //        {
        //            dictionary.Add(dataColumn.ColumnName, dataRow[dataColumn.ColumnName].ToStr());
        //        }
        //        arrayList.Add(dictionary); //ArrayList集合中添加键值
        //    }

        //    return javaScriptSerializer.Serialize(arrayList); //返回一个json字符串
        //}
    }
}