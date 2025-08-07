using AGC.BusinessLogic;

using AGC.DAL;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.util;


using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;
//using System.ValueTuple;

namespace AGC.BusinessLogicEx
{

    public static class clsCodeTypeBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objCodeTypeENS">源对象</param>
        /// <returns>目标对象=>clsCodeTypeEN:objCodeTypeENT</returns>
        public static clsCodeTypeENEx CopyToEx(this clsCodeTypeEN objCodeTypeENS)
        {
            try
            {
                clsCodeTypeENEx objCodeTypeENT = new clsCodeTypeENEx();
                clsCodeTypeBL.CopyTo(objCodeTypeENS, objCodeTypeENT);
                return objCodeTypeENT;
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
        /// <param name = "objCodeTypeENS">源对象</param>
        /// <returns>目标对象=>clsCodeTypeEN:objCodeTypeENT</returns>
        public static clsCodeTypeEN CopyTo(this clsCodeTypeENEx objCodeTypeENS)
        {
            try
            {
                clsCodeTypeEN objCodeTypeENT = new clsCodeTypeEN();
                clsCodeTypeBL.CopyTo(objCodeTypeENS, objCodeTypeENT);
                return objCodeTypeENT;
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
    /// 代码类型(CodeType)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsCodeTypeBLEx : clsCodeTypeBL
    {
        public static int intFindFailCount = 0;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsCodeTypeDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsCodeTypeDAEx CodeTypeDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsCodeTypeDAEx();
                }
                return uniqueInstanceEx;
            }
        }
        public static void BindDdl_GroupName(DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");

            IEnumerable<clsCodeTypeEN> arrCodeType = clsCodeTypeBL.GetObjLstCache()
                .Where(x => x.InUse == true);
            List<string> arrGroupName = arrCodeType.Select(x => x.GroupName).ToList();
            List<string> arrGroupName_Split = new List<string>();

            arrGroupName.ForEach(x =>
            {
                string[] sstrGroupName = x.Split(",".ToCharArray());
                foreach (string strInFor in sstrGroupName)
                {
                    if (string.IsNullOrEmpty(strInFor) == true) continue;
                    if (arrGroupName_Split.Contains(strInFor) == false) arrGroupName_Split.Add(strInFor);
                }
            });


            IEnumerable<clsCboObject> arrCboObject = arrGroupName_Split
                    .OrderBy(x => x)
                    .Select(x => new clsCboObject(x, x));
            objDDL.DataValueField = clsCboObject.con_Value;
            objDDL.DataTextField = clsCboObject.con_Text;
            objDDL.DataSource = arrCboObject;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;

        }

        public static void BindDdl_GroupNameByDependsOn(DropDownList objDDL, string strDependsOn, string strProgLangTypeId = "")
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");

            IEnumerable<clsCodeTypeEN> arrCodeType = clsCodeTypeBL.GetObjLstCache()
                .Where(x => x.InUse == true && x.DependsOn == strDependsOn);
            if (string.IsNullOrEmpty(strProgLangTypeId) == false)
            {
                arrCodeType = arrCodeType
                .Where(x => x.ProgLangTypeId == strProgLangTypeId);
            }
            List<string> arrGroupName = arrCodeType.Select(x => x.GroupName).ToList();
            List<string> arrGroupName_Split = new List<string>();

            arrGroupName.ForEach(x =>
            {
                string[] sstrGroupName = x.Split(",".ToCharArray());
                foreach (string strInFor in sstrGroupName)
                {
                    if (string.IsNullOrEmpty(strInFor) == true) continue;
                    if (arrGroupName_Split.Contains(strInFor) == false) arrGroupName_Split.Add(strInFor);
                }
            });


            IEnumerable<clsCboObject> arrCboObject = arrGroupName_Split
                    .OrderBy(x => x)
                    .Select(x => new clsCboObject(x, x));
            objDDL.DataValueField = clsCboObject.con_Value;
            objDDL.DataTextField = clsCboObject.con_Text;
            objDDL.DataSource = arrCboObject;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;

        }

        public static void BindDdl_DependsOn(DropDownList objDDL, string strProgLangTypeId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");

            IEnumerable<clsCodeTypeEN> arrCodeType = clsCodeTypeBL.GetObjLstCache()
                .Where(x => x.InUse == true && x.ProgLangTypeId == strProgLangTypeId);
            List<string> arrDependsOn = arrCodeType.Select(x => x.DependsOn).ToList();
            List<string> arrDependsOn_Split = new List<string>();

            arrDependsOn.ForEach(x =>
            {
                string[] sstrDependsOn = x.Split(",".ToCharArray());
                foreach (string strInFor in sstrDependsOn)
                {
                    if (string.IsNullOrEmpty(strInFor) == true) continue;
                    if (arrDependsOn_Split.Contains(strInFor) == false) arrDependsOn_Split.Add(strInFor);
                }
            });


            IEnumerable<clsCboObject> arrCboObject = arrDependsOn_Split
                    .OrderBy(x => x)
                    .Select(x => new clsCboObject(x, x));
            objDDL.DataValueField = clsCboObject.con_Value;
            objDDL.DataTextField = clsCboObject.con_Text;
            objDDL.DataSource = arrCboObject;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;

        }


        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strCodeTypeId">表关键字</param>
        /// <returns></returns>
        public new static bool DelRecordEx(string strCodeTypeId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsCodeTypeDA.GetSpecSQLObj();
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
                //删除与表:[CodeType]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conCodeType.CodeTypeId,
                //strCodeTypeId);
                //        clsCodeTypeBL.DelCodeTypesByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsCodeTypeBL.DelRecord(strCodeTypeId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsCodeTypeBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strCodeTypeId, clsStackTrace.GetCurrClassFunction());
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
        public static List<clsCodeTypeENEx> GetObjExLst(string strCondition)
        {
            List<clsCodeTypeEN> arrObjLst = clsCodeTypeBL.GetObjLst(strCondition);
            List<clsCodeTypeENEx> arrObjExLst = new List<clsCodeTypeENEx>();
            foreach (clsCodeTypeEN objInFor in arrObjLst)
            {
                clsCodeTypeENEx objCodeTypeENEx = new clsCodeTypeENEx();
                clsCodeTypeBL.CopyTo(objInFor, objCodeTypeENEx);
                arrObjExLst.Add(objCodeTypeENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strCodeTypeId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsCodeTypeENEx GetObjExByCodeTypeId(string strCodeTypeId)
        {
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeId(strCodeTypeId);
            clsCodeTypeENEx objCodeTypeENEx = new clsCodeTypeENEx();
            clsCodeTypeBL.CopyTo(objCodeTypeEN, objCodeTypeENEx);
            return objCodeTypeENEx;
        }

        public static void BindCbo_CodeTypeIdEx(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format(" 1=1 Order By {0}", conCodeType.OrderNum);
            System.Data.DataTable objDT = clsCodeTypeBL.GetDataTable_CodeType(strCondition);
            clsCodeTypeEN objCodeTypeEN;
            //初始化一个对象列表
            ArrayList CodeTypeList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objCodeTypeEN = new clsCodeTypeEN();
            objCodeTypeEN.CodeTypeId = "0";
            objCodeTypeEN.CodeTypeName = "请选择...";
            CodeTypeList.Add(objCodeTypeEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objCodeTypeEN = new clsCodeTypeEN();
                objCodeTypeEN.CodeTypeId = objRow["CodeTypeId"].ToString();
                objCodeTypeEN.CodeTypeName = objRow["CodeTypeName"].ToString() + "(" + objRow["CodeTypeId"].ToString() + ")";
                CodeTypeList.Add(objCodeTypeEN);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = CodeTypeList;
            objComboBox.ValueMember = "CodeTypeId";
            objComboBox.DisplayMember = "CodeTypeName";
            objComboBox.SelectedIndex = 0;
        }


        public static bool GoTop(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsCodeTypeDAEx().GoTop(arrKeyId);
                bolResult = new clsCodeTypeDAEx().ReOrder();

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错!\r\n" + objException.Message);
            }
        }

        public static bool GoBottom(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsCodeTypeDAEx().GoBottom(arrKeyId);
                bolResult = new clsCodeTypeDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错!\r\n" + objException.Message);
            }
        }

        public static bool AdjustSequenceNumber(string strDirect, string strCodeTypeId)
        {
            try
            {
                bool bolResult = new clsCodeTypeDAEx().AdjustSequenceNumber(strDirect, strCodeTypeId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错!\r\n" + objException.Message);
            }
        }
        public static bool ReOrder()
        {
            try
            {
                bool bolResult = new clsCodeTypeDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错!\r\n" + objException.Message);
            }

        }
        /// <summary>
        /// 获取所给语言类型的代码类型对象列表
        /// </summary>
        /// <param name="ltLangType"></param>
        /// <returns></returns>
        public static List<clsCodeTypeEN> GetCodeTypeObjLstByLangType(clsPubConst.LangType ltLangType)
        {
            string strCondition = "";
            switch (ltLangType)
            {
                case clsPubConst.LangType.CSharp:
                    strCondition = string.Format("{0}='1'", conCodeType.IsCSharp);
                    break;
                case clsPubConst.LangType.JAVA:
                    strCondition = string.Format("{0}='1'", conCodeType.IsJava);
                    break;
                case clsPubConst.LangType.Swift:
                    strCondition = string.Format("{0}='1'", conCodeType.IsSwift);
                    break;
                case clsPubConst.LangType.Swift3:
                    strCondition = string.Format("{0}='1'", conCodeType.IsSwift);
                    break;
                case clsPubConst.LangType.JavaScript:
                    strCondition = string.Format("{0}='1'", conCodeType.IsJavaScript);
                    break;
                case clsPubConst.LangType.SilverLight:
                    strCondition = string.Format("{0}='1'", conCodeType.IsSilverLight);
                    break;
                case clsPubConst.LangType.VB:
                    strCondition = string.Format("{0}='1'", conCodeType.IsVB);
                    break;
            }
            strCondition += string.Format(" Order By {0}", conCodeType.OrderNum);
            List<clsCodeTypeEN> arrCodeTypeObjList = clsCodeTypeBL.GetObjLst(strCondition);
            return arrCodeTypeObjList;
        }

        public static bool IsMatchLangType(clsCodeTypeEN objCodeTypeEN, string strProgLangTypeId)
        {
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(strProgLangTypeId);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);
            return IsMatchLangType(objCodeTypeEN, ltLangType);
        }
        /// <summary>
        /// 获取所给语言类型的代码类型对象列表
        /// </summary>
        /// <param name="ltLangType"></param>
        /// <returns></returns>
        public static bool IsMatchLangType(clsCodeTypeEN objCodeTypeEN, clsPubConst.LangType ltLangType)
        {
            //string strCondition = "";
            switch (ltLangType)
            {
                case clsPubConst.LangType.CSharp:
                    if (objCodeTypeEN.IsCSharp == true) return true;
                    else return false;
                case clsPubConst.LangType.JAVA:
                    if (objCodeTypeEN.IsJava == true) return true;
                    else return false;

                case clsPubConst.LangType.Swift:
                    if (objCodeTypeEN.IsSwift == true) return true;
                    else return false;
                case clsPubConst.LangType.Swift3:
                    if (objCodeTypeEN.IsSwift == true) return true;
                    else return false;
                case clsPubConst.LangType.Swift4:
                    if (objCodeTypeEN.IsSwift == true) return true;
                    else return false;
                case clsPubConst.LangType.JavaScript:
                    if (objCodeTypeEN.IsJavaScript == true) return true;
                    else return false;
                case clsPubConst.LangType.SilverLight:
                    if (objCodeTypeEN.IsSilverLight == true) return true;
                    else return false;
                case clsPubConst.LangType.VB:
                    if (objCodeTypeEN.IsVB == true) return true;
                    else return false;
                default:
                    string strMsg = string.Format("处理是否匹配中，该类型:[{0}]没有处理。({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 获取所给语言类型的代码类型对象列表
        /// </summary>
        /// <param name="objCodeTypeEN"></param>
        /// <param name="intApplicationTypeId"></param>
        /// <returns></returns>
        public static bool IsMatchLangType(clsCodeTypeEN objCodeTypeEN, int intApplicationTypeId)
        {
            clsApplicationTypeEN objApplicationTypeEN = clsApplicationTypeBL.GetObjByApplicationTypeIdCache(intApplicationTypeId);
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objApplicationTypeEN.ProgLangTypeId);
            clsPubConst.LangType ltLangType = clsPubConst.GetLangTypeByString(objProgLangTypeEN.ProgLangTypeName);

            switch (ltLangType)
            {
                case clsPubConst.LangType.CSharp:
                    if (objCodeTypeEN.IsCSharp == false) return false;

                    if (objCodeTypeEN.IsWin == true && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WinApp_1)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebApp_2)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsAspMvc == true
                      && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.AspMvcApp_13)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsPubApp4WinWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.PubApp4WinWeb_7)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsTableFldConst == true
                      && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.TableFldConst_11)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWebSrvAccess == true
                    && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebSrvAccess_10)
                    {
                        return true;
                    }
                    else return false;
                case clsPubConst.LangType.JAVA:
                    if (objCodeTypeEN.IsJava == false) return false;
                    if (objCodeTypeEN.IsMobileApp == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.AndroidApp_5)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWin == true && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WinApp_1)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebApp_2)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsPubApp4WinWeb == true
                      && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.PubApp4WinWeb_7)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsTableFldConst == true
                          && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.TableFldConst_11)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWebSrvAccess == true
                  && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebSrvAccess_10)
                    {
                        return true;
                    }
                    else return false;

                case clsPubConst.LangType.Swift:
                case clsPubConst.LangType.Swift3:
                case clsPubConst.LangType.Swift4:
                    if (objCodeTypeEN.IsSwift == false) return false;
                    if (objCodeTypeEN.IsMobileApp == true
                       && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.IOSApp_6)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWin == true && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WinApp_1)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebApp_2)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsPubApp4WinWeb == true
                      && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.PubApp4WinWeb_7)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsTableFldConst == true
                          && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.TableFldConst_11)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWebSrvAccess == true
                  && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebSrvAccess_10)
                    {
                        return true;
                    }
                    else return false;
                case clsPubConst.LangType.JavaScript:
                    if (objCodeTypeEN.IsJavaScript == false) return false;
                    if (objCodeTypeEN.IsWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebSite_4)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebApp_2)
                    {
                        return true;
                    }
                    else return false;
                case clsPubConst.LangType.TypeScript:
                    if (objCodeTypeEN.IsTypeScript == false) return false;
                    if (objCodeTypeEN.IsWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebSite_4)
                    {
                        return true;
                    }
                    else if (objCodeTypeEN.IsWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.WebApp_2)
                    {
                        return true;
                    }
                    else return false;
                case clsPubConst.LangType.SilverLight:
                    if (objCodeTypeEN.IsSilverLight == false) return false;
                    if (objCodeTypeEN.IsWeb == true
                        && objApplicationTypeEN.ApplicationTypeId == (int)enumApplicationType.SilverLightApp_8)
                    {
                        return true;
                    }
                    else return false;
                case clsPubConst.LangType.VB:
                    if (objCodeTypeEN.IsVB == true) return true;
                    else return false;
                default:
                    string strMsg = string.Format("处理是否匹配中，该类型:[{0}]没有处理。({1})", ltLangType, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
            }
        }


        /// <summary>
        /// 获取所给语言类型的【后台】代码类型对象列表
        /// </summary>
        /// <param name="intApplicationTypeId"></param>
        /// <returns></returns>
        public static List<clsCodeTypeEN> GetCodeTypeObjLstByApplicationType4Back(int intApplicationTypeId)
        {
            string strCondition = string.Format(" {0} in ('Table', 'PureClass') ", conCodeType.DependsOn);

            strCondition += string.Format(" and {0} in (Select {0} From {1} where {2}={3}) Order By {4}",
                conAppCodeTypeRela.CodeTypeId,
                clsAppCodeTypeRelaEN._CurrTabName,
                conAppCodeTypeRela.ApplicationTypeId, intApplicationTypeId,
                conCodeType.OrderNum);
            List<clsCodeTypeEN> arrCodeTypeObjList = clsCodeTypeBL.GetObjLst(strCondition);
            return arrCodeTypeObjList;
        }

        /// <summary>
        /// 获取所给语言类型的[前台][Web]代码类型对象列表
        /// </summary>     
        /// <param name="intApplicationTypeId"></param>
        /// <returns></returns>
        public static List<clsCodeTypeEN> GetCodeTypeObjLstByApplicationType4Front4Web(int intApplicationTypeId)
        {
            string strCondition = string.Format(" {0}='View' ", conCodeType.DependsOn);

            strCondition += string.Format(" and {0} in (Select {0} From {1} where {2}={3}) Order By {4}",
                conAppCodeTypeRela.CodeTypeId,
                clsAppCodeTypeRelaEN._CurrTabName,
                conAppCodeTypeRela.ApplicationTypeId, intApplicationTypeId,
                conCodeType.OrderNum);

            List<clsCodeTypeEN> arrCodeTypeObjList = clsCodeTypeBL.GetObjLst(strCondition);
            return arrCodeTypeObjList;


        }

        /// <summary>
        /// 获取所给语言类型的[前台][Web]代码类型对象列表
        /// </summary>
        /// <param name="ltLangType"></param>
        /// <returns></returns>
        public static List<clsCodeTypeEN> GetCodeTypeObjLstByLangType4Front4Win(clsPubConst.LangType ltLangType)
        {
            string strCondition = string.Format(" {0}='前台' and {1}='1'",
                conCodeType.FrontOrBack, conCodeType.IsWin);
            switch (ltLangType)
            {
                case clsPubConst.LangType.CSharp:
                    strCondition += string.Format(" And {0}='1'", conCodeType.IsCSharp);
                    break;
                case clsPubConst.LangType.JAVA:
                    strCondition += string.Format(" And {0}='1'", conCodeType.IsJava);
                    break;
                case clsPubConst.LangType.Swift:
                    strCondition += string.Format(" And {0}='1'", conCodeType.IsSwift);
                    break;
                case clsPubConst.LangType.Swift3:
                    strCondition += string.Format(" And {0}='1'", conCodeType.IsSwift);
                    break;
                case clsPubConst.LangType.JavaScript:
                    strCondition += string.Format(" And {0}='1'", conCodeType.IsJavaScript);
                    break;
                case clsPubConst.LangType.SilverLight:
                    strCondition += string.Format(" And {0}='1'", conCodeType.IsSilverLight);
                    break;
                case clsPubConst.LangType.VB:
                    strCondition += string.Format(" And {0}='1'", conCodeType.IsVB);
                    break;
            }
            strCondition += string.Format(" Order By {0}", conCodeType.OrderNum);
            List<clsCodeTypeEN> arrCodeTypeObjList = clsCodeTypeBL.GetObjLst(strCondition);
            return arrCodeTypeObjList;
        }


        public static bool IsCanVisible(List<clsCodeTypeEN> arrCodeTypeObjList, System.Windows.Forms.Button btnClassName)
        {
            foreach (clsCodeTypeEN objCodeTypeEN in arrCodeTypeObjList)
            {
                if (btnClassName.Name.Substring(3) == objCodeTypeEN.CodeTypeENName)
                {
                    btnClassName.Visible = true;
                    return true;
                }
            }
            btnClassName.Visible = false;
            return false;
        }





        public static string GetClassNameByTabId(string strCodeTypeId, string strProgLangTypeId,

            string strTabId, string strPrjId)
        {
            string strClassName = "";
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            if (objPrjTabEN == null)
            {
                string strMsg = string.Format("在项目表:(PrjTab)中，TabId=[{0}](PrjId={1})的记录不存在！",
                    strTabId, strPrjId);
                throw new Exception(strMsg);
            }
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            if (string.IsNullOrEmpty(objCodeTypeEN.ClassNameFormat) == true)
            {
                string strMsg = string.Format("CodeTypeId:{0}在没有相应的类名格式！({1})",
                      strCodeTypeId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            strClassName = string.Format(objCodeTypeEN.ClassNameFormat, objPrjTabEN.TabName);
            return strClassName;
        }

        public static string GetClassNameByViewId(string strCodeTypeId,
     string strViewId, string strPrjId)
        {
            string strClassName = "";
            clsViewInfoEN objViewInfoEN = clsViewInfoBLEx.GetObjByViewIdCache(strViewId, strPrjId);
            if (objViewInfoEN == null)
            {
                string strMsg = string.Format("在项目界面:(ViewInfo)中，ViewId=[{0}](PrjId={1})的记录不存在！",
                    strViewId, strPrjId);
                throw new Exception(strMsg);
            }
            clsPrjTabEN objMainTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfoEN.MainTabId, strPrjId);
            if (objMainTab == null)
            {
                string strMsg = string.Format("在项目表:(PrjTab)中，TabId=[{0}](PrjId={1})的记录不存在！",
                    objViewInfoEN.MainTabId, strPrjId);
                throw new Exception(strMsg);
            }
            clsPrjTabEN objOutTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfoEN.OutRelaTabId, strPrjId);
            if (objOutTab == null)
            {
                string strMsg = string.Format("在项目表:(PrjTab)中，TabId=[{0}](PrjId={1})的记录不存在！",
                    objViewInfoEN.OutRelaTabId, strPrjId);
                throw new Exception(strMsg);
            }
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeIdCache(strCodeTypeId);
            if (string.IsNullOrEmpty(objCodeTypeEN.ClassNameFormat) == true)
            {
                string strMsg = string.Format("CodeTypeId:{0}在没有相应的类名格式！({1})",
                      strCodeTypeId, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            strClassName = string.Format(objCodeTypeEN.ClassNameFormat, objMainTab.TabName);
            return strClassName;


        }
        static Func<clsCodeTypeEN, string, string, bool> IsMatch
            = (objCodeType, strClassName, strProgLangTypeId) =>
            {
                //if (objCodeType.DependsOn == "PureClass") return false;
                if (objCodeType.ProgLangTypeId != strProgLangTypeId) return false;
                string strPattern = objCodeType.ClassNamePattern;
                //string strClass3 = "aclsTestBLEx";

                //string strPattern = @"\bcls\S*BLEx\b";
                var r = new Regex(strPattern);
                Match m = r.Match(strClassName);
                return m.Success;
            };
        /// <summary>
        /// 根据类名和语言获取代码类型Id
        /// </summary>
        /// <param name="strClassName">类名</param>
        /// <param name="ltLangType">语言</param>
        /// <returns>代码类型Id</returns>
        public static Tuple<string, string> GetCodeTypeIdByClassName(string strClassName, clsPubConst.LangType ltLangType)
        {
            string strProgLangTypeId = clsProgLangTypeBLEx.GetProgLangTypeIdByLangTypeCache(ltLangType);
            IEnumerable<clsCodeTypeEN> arrCodeType = clsCodeTypeBL.GetObjLstCache();
            IEnumerable<clsCodeTypeEN> arrCodeType_Sel = arrCodeType.Where(x => IsMatch(x, strClassName, strProgLangTypeId));
            string strTabName = "";
            string strCodeTypeId = "";

            if (arrCodeType_Sel.Count() > 0)
            {
                clsCodeTypeEN objCodeType = arrCodeType_Sel.First();
                strCodeTypeId = objCodeType.CodeTypeId;
                if (objCodeType.DependsOn == "PureClass")
                {
                    return Tuple.Create(strTabName, strCodeTypeId);
                }
                string strPattern = objCodeType.ClassNamePattern.Replace("\\b", "");
                int intStart_S = strPattern.IndexOf("\\S*");

                string strEndWith = strPattern.Substring(intStart_S + 3);

                int intEnd_S = strClassName.LastIndexOf(strEndWith);

                strTabName = strClassName.Substring(intStart_S, intEnd_S - intStart_S);
                //strTabName = "";

            }
            else
            {
                strCodeTypeId = "0192";
                return Tuple.Create(strTabName, strCodeTypeId);
            }
            Tuple<string, string> TypeGroup = Tuple.Create(strTabName, strCodeTypeId);
            return TypeGroup;

        }

        /// <summary>
        /// 根据语言类型获取相关对象, 从缓存的对象列表中获取,使用顺序查询.
        /// </summary>
        /// <param name = "cnClassName">所给的类名</param>
        /// <param name = "ltLangType">所给的语言类型</param>
        /// <returns>根据关键字获取的对象</returns>
        public static string GetCodeTypeIdByClassNameCache(clsPubConst.ClassName cnClassName, clsPubConst.LangType ltLangType)
        {
            string strCodeTypeENName = clsPubConst.GetClassNameStringByClassName(cnClassName);
            //string str = clsPubConst.GetLangTypeStringByLangType(ltLangType);
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBLEx.GetObjByLangTypeCache(ltLangType);
            string strWhereCond = string.Format("1 = 1 order by {0}", conCodeType.OrderNum);
            List<clsCodeTypeEN> arrCodeTypeObjLstCache = clsCodeTypeBL.GetObjLstCache();
            List<clsCodeTypeEN> arrCodeTypeObjLst = arrCodeTypeObjLstCache
                .Where(x => x.CodeTypeENName == strCodeTypeENName && x.ProgLangTypeId == objProgLangTypeEN.ProgLangTypeId)
                .ToList();
            if (arrCodeTypeObjLst.Count > 0) return arrCodeTypeObjLst[0].CodeTypeId;

            intFindFailCount++;
            // 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
            CacheHelper.Remove(clsCodeTypeEN._CurrTabName);

            if (intFindFailCount == 1) return GetCodeTypeIdByClassNameCache(cnClassName, ltLangType);
            string strErrMsgForGetObjById = string.Format("在CodeType对象缓存列表中,找不到记录[cnClassName = {0},ltLangType={1}][intFindFailCount = {2}](函数:{3})",
                strCodeTypeENName, ltLangType,
                intFindFailCount, clsStackTrace.GetCurrClassFunction());
            clsLog.LogErrorS2("clsCodeTypeBLEx", clsStackTrace.GetCurrFunction(), strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }

        /// <summary>
        /// 根据语言类型获取相关对象, 从缓存的对象列表中获取,使用顺序查询.
        /// </summary>
        /// <param name = "cnClassName">所给的类名</param>
        /// <param name = "ltLangType">所给的语言类型</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsCodeTypeEN GetObjByClassNameAndLangTypeCache(clsPubConst.ClassName cnClassName, clsPubConst.LangType ltLangType)
        {
            string strCodeTypeENName = clsPubConst.GetClassNameStringByClassName(cnClassName);
            //string str = clsPubConst.GetLangTypeStringByLangType(ltLangType);
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBLEx.GetObjByLangTypeCache(ltLangType);
            string strWhereCond = string.Format("1 = 1 order by {0}", conCodeType.OrderNum);


            List<clsCodeTypeEN> arrCodeTypeObjLstCache = clsCodeTypeBL.GetObjLstCache();
            List<clsCodeTypeEN> arrCodeTypeObjLst = arrCodeTypeObjLstCache
                .Where(x => x.CodeTypeENName == strCodeTypeENName && x.ProgLangTypeId == objProgLangTypeEN.ProgLangTypeId).ToList();
            if (arrCodeTypeObjLst.Count > 0) return arrCodeTypeObjLst[0];

            intFindFailCount++;
            // 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
            CacheHelper.Remove(clsCodeTypeEN._CurrTabName);
            if (intFindFailCount == 1) return GetObjByClassNameAndLangTypeCache(cnClassName, ltLangType);
            string strErrMsgForGetObjById = string.Format("在CodeType对象缓存列表中,找不到记录[cnClassName = {0},ltLangType={1}][intFindFailCount = {2}](函数:{3})",
                strCodeTypeENName, ltLangType,
                intFindFailCount, clsStackTrace.GetCurrClassFunction());
            clsLog.LogErrorS2("clsCodeTypeBLEx", clsStackTrace.GetCurrFunction(), strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }

        public static clsCodeTypeEN GetObjByClassNameAndLangTypeCache(string strCodeTypeENName, clsPubConst.LangType ltLangType)
        {
            //string strCodeTypeENName = clsPubConst.GetClassNameStringByClassName(cnClassName);
            //string str = clsPubConst.GetLangTypeStringByLangType(ltLangType);
            clsProgLangTypeEN objProgLangTypeEN = clsProgLangTypeBLEx.GetObjByLangTypeCache(ltLangType);

            List<clsCodeTypeEN> arrCodeTypeObjLstCache = clsCodeTypeBL.GetObjLstCache();
            List<clsCodeTypeEN> arrCodeTypeObjLst = arrCodeTypeObjLstCache
                .Where(x => x.CodeTypeENName == strCodeTypeENName && x.ProgLangTypeId == objProgLangTypeEN.ProgLangTypeId)
                .ToList();
            if (arrCodeTypeObjLst.Count > 0) return arrCodeTypeObjLst[0];


            intFindFailCount++;
            // 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
            CacheHelper.Remove(clsCodeTypeEN._CurrTabName);

            if (intFindFailCount == 1) return GetObjByClassNameAndLangTypeCache(strCodeTypeENName, ltLangType);
            string strErrMsgForGetObjById = string.Format("在CodeType对象缓存列表中,找不到记录[strCodeTypeENName = {0},ltLangType={1}][intFindFailCount = {2}](函数:{3})",
                strCodeTypeENName, ltLangType,
                intFindFailCount, clsStackTrace.GetCurrClassFunction());
            clsLog.LogErrorS2("clsCodeTypeBLEx", clsStackTrace.GetCurrFunction(), strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }

        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_CodeTypeIdByProgLangTypeidEx(System.Web.UI.WebControls.DropDownList objDDL, string strProgLangTypeId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            //string strCondition = string.Format(" {0}='{1}' and {2}='1' Order By {3}", 
            //    conCodeType.ProgLangTypeId, strProgLangTypeId, 
            //    conCodeType.InUse,
            //    conCodeType.CodeTypeName);
            //   System.Data.DataTable objDT = clsCodeTypeBL.GetDataTable_CodeType(strCondition);
            List<clsCodeTypeEN> arrCodeTypeObjLstCache = clsCodeTypeBL.GetObjLstCache();// (strCondition);

            IEnumerable<clsCodeTypeEN> arrCodeTypeObjLst = arrCodeTypeObjLstCache
                .Where(x => x.ProgLangTypeId == strProgLangTypeId && x.InUse == true)
                   .OrderBy(x => x.CodeTypeName);
            objDDL.DataValueField = conCodeType.CodeTypeId;
            objDDL.DataTextField = conCodeType.CodeTypeName;
            objDDL.DataSource = arrCodeTypeObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static void BindDdl_CodeTypeIdByProgLangTypeidEx4Table(System.Web.UI.WebControls.DropDownList objDDL, string strProgLangTypeId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            //string strCondition = string.Format(" {0}='{1}' and {2}='1' Order By {3}",
            //    conCodeType.ProgLangTypeId, strProgLangTypeId,
            //    conCodeType.InUse,
            //    conCodeType.CodeTypeName);
            List<clsCodeTypeEN> arrCodeTypeObjLstCache = clsCodeTypeBL.GetObjLstCache();// (strCondition);

            IEnumerable<clsCodeTypeEN> arrCodeTypeObjLst = arrCodeTypeObjLstCache
                .Where(x => x.ProgLangTypeId == strProgLangTypeId && x.InUse == true && x.DependsOn == "Table")
                .OrderBy(x => x.CodeTypeName);

            //   System.Data.DataTable objDT = clsCodeTypeBL.GetDataTable_CodeType(strCondition);
            //IEnumerable<clsCodeTypeEN> arrCodeTypeObjLst = clsCodeTypeBL.GetObjLst(strCondition).Where(x=>x.DependsOn == "Table");

            objDDL.DataValueField = conCodeType.CodeTypeId;
            objDDL.DataTextField = conCodeType.CodeTypeName;
            objDDL.DataSource = arrCodeTypeObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        public static void BindDdl_CodeTypeIdByApplicationTypeidEx(System.Web.UI.WebControls.DropDownList objDDL, int intApplicationTypeId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            //string strCondition = string.Format(" {0} in (Select {0} From {1} where {2}={3}) Order By {0}",
            // conCodeType.CodeTypeId, clsAppCodeTypeRelaEN._CurrTabName,
            // conAppCodeTypeRela.ApplicationTypeId, intApplicationTypeId,
            // conCodeType.OrderNum);
            List<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLstCache = clsAppCodeTypeRelaBL.GetObjLstCache();// (strCondition);
            IEnumerable<clsAppCodeTypeRelaEN> arrAppCodeTypeRelaObjLst = arrAppCodeTypeRelaObjLstCache
                .Where(x => x.ApplicationTypeId == intApplicationTypeId)
                        .OrderBy(x => x.OrderNum);
            IEnumerable<string> arrCodeTypeId = arrAppCodeTypeRelaObjLst.Select(x => x.CodeTypeId);

            List<clsCodeTypeEN> arrCodeTypeObjLstCache = clsCodeTypeBL.GetObjLstCache();// (strCondition);

            IEnumerable<clsCodeTypeEN> arrCodeTypeObjLst = arrCodeTypeObjLstCache
                .Where(x => arrCodeTypeId.Contains(x.CodeTypeId))
                   .OrderBy(x => x.CodeTypeName);

            //List<clsCodeTypeEN> arrObjLst = clsCodeTypeBL.GetObjLst(strCondition);

            objDDL.DataValueField = conCodeType.CodeTypeId;
            objDDL.DataTextField = conCodeType.CodeTypeName;
            objDDL.DataSource = arrCodeTypeObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objDDL"></param>
        public static void BindDdl_CodeTypeIdWithLangTypeidEx(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format(" 1=1 Order By {0}, {1}", conCodeType.CodeTypeName, conCodeType.ProgLangTypeId);
            //   System.Data.DataTable objDT = clsCodeTypeBL.GetDataTable_CodeType(strCondition);
            List<clsCodeTypeEN> arrCodeTypeObjLst = clsCodeTypeBL.GetObjLstCache()
                .OrderBy(x => x.CodeTypeName)
                .ThenBy(x => x.ProgLangTypeId)
                .ToList();
            if (arrCodeTypeObjLst == null)
            {
                string strMsg = string.Format("条件:{0}的{1}记录不存在！({2})",
                    strCondition, clsCodeTypeEN._CurrTabName,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            foreach (clsCodeTypeEN objInFor in arrCodeTypeObjLst)
            {
                clsProgLangTypeEN obj = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objInFor.ProgLangTypeId);
                if (obj == null)
                {
                    objInFor.CodeTypeName = objInFor.CodeTypeName;
                }
                else
                {
                    if (objInFor.CodeTypeName.Contains(obj.ProgLangTypeSimName) == false)
                    {
                        objInFor.CodeTypeName = string.Format("{0}_{1}", objInFor.CodeTypeName, obj.ProgLangTypeSimName);
                    }
                }
            }

            objDDL.DataValueField = conCodeType.CodeTypeId;
            objDDL.DataTextField = conCodeType.CodeTypeName;
            objDDL.DataSource = arrCodeTypeObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static void BindDdl_CodeTypeId4WorkFlow(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format(" 1=1 and {0} in (select {1} from {2} where TabName='{3}' and InUse='1') Order By {4}",
                conCodeType.CodeTypeId, conwf_Point.TabKeyId, clswf_PointEN._CurrTabName, clsCodeTypeEN._CurrTabName,
                conCodeType.CodeTypeName);
            //   System.Data.DataTable objDT = clsCodeTypeBL.GetDataTable_CodeType(strCondition);
            List<clsCodeTypeEN> arrCodeTypeObjLst = clsCodeTypeBL.GetObjLst(strCondition);
            if (arrCodeTypeObjLst == null)
            {
                string strMsg = string.Format("条件:{0}的{1}记录不存在！({2})",
                    strCondition, clsCodeTypeEN._CurrTabName,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            foreach (clsCodeTypeEN objInFor in arrCodeTypeObjLst)
            {
                clsProgLangTypeEN obj = clsProgLangTypeBL.GetObjByProgLangTypeIdCache(objInFor.ProgLangTypeId);
                if (obj == null)
                {
                    objInFor.CodeTypeName = objInFor.CodeTypeName;
                }
                else
                {
                    objInFor.CodeTypeName = objInFor.CodeTypeName + "-" + obj.ProgLangTypeSimName;
                }
            }

            objDDL.DataValueField = conCodeType.CodeTypeId;
            objDDL.DataTextField = conCodeType.CodeTypeName;
            objDDL.DataSource = arrCodeTypeObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }


        public static bool SetDefaClassNameFormat(string strCodeTypeId)
        {
            string strClassNameFormat = "";
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBLEx.GetObjByCodeTypeIdCache(strCodeTypeId);
            if (objCodeTypeEN == null)
            {
                string strMsg = string.Format("在项目表:(CodeType)中，CodeTypeId=[{0}]的记录不存在！", strCodeTypeId);
                throw new Exception(strMsg);
            }
            switch (strCodeTypeId)
            {
                case enumCodeType.AppController_0013:
                    strClassNameFormat = "cls{0}ApiController";
                    break;
                case enumCodeType.AppViewDdlAdapter_0039:
                    strClassNameFormat = "ddlAdapter{0}";
                    break;
                case enumCodeType.AppViewDdlBind_0038:
                    strClassNameFormat = "ddlBind{0}";
                    break;
                case enumCodeType.AppViewEdtScript_0032:
                    strClassNameFormat = "uc_{0}_edit";
                    break;
                case enumCodeType.AppViewListViewAdapter_0037:
                    strClassNameFormat = "lv{0}Adapter";
                    break;
                case enumCodeType.AppViewLvHeadScript_0040:
                    strClassNameFormat = "uc_{0}_lvhead";
                    break;
                case enumCodeType.AppViewLvItemScript_0036:
                    strClassNameFormat = "uc_{0}_lvitem";
                    break;
                case enumCodeType.AppViewQryScript_0031:
                    strClassNameFormat = "uc_{0}_query";
                    break;
                case enumCodeType.AppViewScriptContent_0029:
                    strClassNameFormat = "content_{0}_qudi";
                    break;
                case enumCodeType.AppViewScriptCS_0030:
                    strClassNameFormat = "ac{0}_QUDI";
                    break;
                case enumCodeType.AppViewScriptMain_0035:
                    strClassNameFormat = "ac_{0}_qudi";
                    break;
                case enumCodeType.AppViewUnitTest_0025:
                    strClassNameFormat = "ac{0}_UnitTest";
                    break;
                case enumCodeType.WA_ViewUTScript_0052:
                    strClassNameFormat = "WApi_{0}_UT";
                    break;
                case enumCodeType.WA_ViewUTScriptCS_0053:
                    strClassNameFormat = "WApi_{0}_UT";
                    break;
                case enumCodeType.AppViewUTScript_0026:
                    strClassNameFormat = "ac_{0}_UT";
                    break;
                case enumCodeType.AppViewUTScriptCS_0027:
                    strClassNameFormat = "ac{0}_UT";
                    break;
                case enumCodeType.BusinessLogicEx_0021:
                    strClassNameFormat = "cls{0}BLEx";
                    break;
                case enumCodeType.BusinessLogic_0003:
                    strClassNameFormat = "cls{0}BL";
                    break;
                case enumCodeType.CommFun4BL_0020:
                    strClassNameFormat = "clsCommFun4BL4{0}";
                    break;
                case enumCodeType.CondEntityLayer_0028:
                    strClassNameFormat = "clsCond_{0}EN";
                    break;
                case enumCodeType.DALCode_0002:
                    strClassNameFormat = "cls{0}DA";
                    break;
                case enumCodeType.DALExCode_0022:
                    strClassNameFormat = "cls{0}DAEx";
                    break;
                case enumCodeType.EntityLayer_0001:
                    strClassNameFormat = "cls{0}EN";
                    break;
                case enumCodeType.EntityLayer_Sim_0011:
                    strClassNameFormat = "cls{0}EN_Sim";
                    break;
                case enumCodeType.Mvc_ControllerBase_0024:
                    strClassNameFormat = "cls{0}BaseController";
                    break;
                case enumCodeType.Mvc_View_0023:
                    strClassNameFormat = "{0}CRUD";
                    break;
                case enumCodeType.TableFldConst_0041:
                    strClassNameFormat = "const{0}";
                    break;
                case enumCodeType.Unknown_0000:
                    strClassNameFormat = "Unknown_{0}";
                    break;
                case enumCodeType.WebCtlControlCode4Gv_0033:
                    strClassNameFormat = "wuc{0}4Gv.ascx.cs";
                    break;
                case enumCodeType.WebCtlControlCode_0015:
                    strClassNameFormat = "wuc{0}B.ascx.cs";
                    break;
                case enumCodeType.WebCtlViewCode4Gv_0034:
                    strClassNameFormat = "wuc{0}4Gv.ascx";
                    break;
                case enumCodeType.WebCtlViewCode_0005:
                    strClassNameFormat = "wuc{0}B.ascx";
                    break;
                case enumCodeType.WS_Srv4Front_0017:
                    strClassNameFormat = "{0}Service.asmx";
                    break;
                case enumCodeType.WS_Access_0010:
                    strClassNameFormat = "cls{0}WS.cs";
                    break;
                case enumCodeType.WS_Srv_0009:
                    strClassNameFormat = "{0}Service.asmx.cs";
                    break;
                case enumCodeType.WebViewCode_0004:
                    strClassNameFormat = "wfm{0}_QUDI.aspx";
                    break;
                case enumCodeType.WebViewControlCode_0014:
                    strClassNameFormat = "wfm{0}_QUDI.aspx.cs";
                    break;
                case enumCodeType.WinViewCode_QD_0006:
                    strClassNameFormat = "frm{0}_QD_LV.cs";
                    break;
                case enumCodeType.WinViewCode_QD_Design_0018:
                    strClassNameFormat = "frm{0}_QD_LV.Designer.cs";
                    break;
                case enumCodeType.WinViewCode_UI_0016:
                    strClassNameFormat = "frm{0}_UI.cs";
                    break;
                case enumCodeType.WinViewCode_UI_Design_0019:
                    strClassNameFormat = "frm{0}_UI.Designer.cs";
                    break;
                case enumCodeType.WS_AccessHigh_0012:
                    strClassNameFormat = "cls{0}WS4Controller";
                    break;
                case enumCodeType.EntityLayerEx_0042:
                    strClassNameFormat = "cls{0}ENEx";
                    break;
                case enumCodeType.AppBusiness_0043:
                    strClassNameFormat = "cls{0}_ABL";
                    break;
                case enumCodeType.WA_Srv_0044:
                    strClassNameFormat = "{0}ApiController";
                    break;
                case enumCodeType.WA_Access_0045:
                    strClassNameFormat = "cls{0}WApi";
                    break;
                case enumCodeType.BusinessLogic4Mvc_0051:
                    strClassNameFormat = "cls{0}BL4Mvc";
                    break;
                case enumCodeType.WA_ViewUTScript_TS_0054:
                    strClassNameFormat = "WApi_{0}_UT_TS";
                    break;
                case enumCodeType.WA_ViewUTScriptCS_TS_0161:
                    strClassNameFormat = "WApi_{0}_UT_TS";
                    break;
                //case enumCodeType.Antroller_0013:
                //    strClassNameFormat = "cls{0}_Controller";
                //break;
                default:
                    string strCondition = string.Format("{0}='{1}' and CodeTypeName!=''", conCodeType.CodeTypeName, objCodeTypeEN.CodeTypeName);
                    clsCodeTypeEN objCodeType_Refa = clsCodeTypeBL.GetFirstObj_S(strCondition);
                    if (objCodeType_Refa == null) return false;
                    objCodeTypeEN.ClassNameFormat = objCodeType_Refa.ClassNameFormat;
                    return clsCodeTypeBL.UpdateBySql2(objCodeTypeEN);
            }
            objCodeTypeEN.ClassNameFormat = strClassNameFormat;
            return clsCodeTypeBL.UpdateBySql2(objCodeTypeEN);
        }


        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        /// <param name = "intApplicationTypeId">应用类型Id</param>
        public static void BindCbo_CodeTypeIdByApplicationTypeidEx(System.Windows.Forms.ComboBox objComboBox,
            int intApplicationTypeId)
        {
            //为数据源于表的下拉框设置内容

            string strCondition = string.Format(" {0} in (Select {0} From {1} where {2}={3}) Order By {0}",
                conCodeType.CodeTypeId, clsAppCodeTypeRelaEN._CurrTabName,
                conAppCodeTypeRela.ApplicationTypeId, intApplicationTypeId,
                conCodeType.OrderNum);
            List<clsCodeTypeEN> arrObjLst = clsCodeTypeBL.GetObjLst(strCondition);


            clsCodeTypeEN objCodeTypeEN;
            //初始化一个对象列表
            List<clsCodeTypeEN> CodeTypeList = new List<clsCodeTypeEN>();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objCodeTypeEN = new clsCodeTypeEN();
            objCodeTypeEN.CodeTypeId = "0";
            objCodeTypeEN.CodeTypeName = "请选择...";
            objCodeTypeEN.OrderNum = 0;
            CodeTypeList.Add(objCodeTypeEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (clsCodeTypeEN objInFor in arrObjLst)
            {
                clsAppCodeTypeRelaEN objAppCodeTypeRelaEN = clsAppCodeTypeRelaBLEx.GetObjByAppAndCodeType(intApplicationTypeId, objInFor.CodeTypeId);
                objCodeTypeEN = new clsCodeTypeEN();
                objCodeTypeEN.OrderNum = objAppCodeTypeRelaEN.OrderNum;
                objCodeTypeEN.CodeTypeId = objInFor.CodeTypeId;
                objCodeTypeEN.CodeTypeName = string.Format("{0}({1})-{2}",
                    objInFor.CodeTypeName,
                     objInFor.CodeTypeId,
                     objCodeTypeEN.OrderNum);
                CodeTypeList.Add(objCodeTypeEN);
            }
            CodeTypeList.Sort((clsCodeTypeEN h1, clsCodeTypeEN h2) =>
            {
                if (h1.OrderNum < h2.OrderNum)
                {
                    return -1;//左值小于右值，返回-1，为升序，如果返回1，就是降序  
                }
                else if (h1.OrderNum == h2.OrderNum)//左值等于右值，返回0  
                {
                    return 0;
                }
                else
                {
                    return 1;//左值大于右值，返回1，为升序，如果返回-1，就是降序  
                }
            });
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = CodeTypeList;
            objComboBox.ValueMember = "CodeTypeId";
            objComboBox.DisplayMember = "CodeTypeName";
            objComboBox.SelectedIndex = 0;
        }

    }
}
