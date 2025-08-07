
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvUserCodePrjMainPathExWApi
表名:vUserCodePrjMainPath(00050339)
生成代码版本:2019.07.15.2
生成日期:2019/07/16 19:01:48
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:系统设置
模块英文名:SystemSet
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

namespace AGC4WApi
{

    public static class clsvUserCodePrjMainPathExWApi_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvUserCodePrjMainPathENS">源对象</param>
        /// <returns>目标对象=>clsvUserCodePrjMainPathEN:objvUserCodePrjMainPathENT</returns>
        public static clsvUserCodePrjMainPathENEx CopyToEx(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathENS)
        {
            try
            {
                clsvUserCodePrjMainPathENEx objvUserCodePrjMainPathENT = new clsvUserCodePrjMainPathENEx();
                clsvUserCodePrjMainPathWApi.CopyTo(objvUserCodePrjMainPathENS, objvUserCodePrjMainPathENT);
                return objvUserCodePrjMainPathENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000068)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        public static string ApplicationTypeName(this clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN)
        {
            try
            {
                clsApplicationTypeEN objApplicationTypeEN = clsApplicationTypeWApi.GetObjByApplicationTypeIdCache(objvUserCodePrjMainPathEN.ApplicationTypeId);
                return objApplicationTypeEN.ApplicationTypeName;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Watl000069)获取ApplicationTypeName数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

    }

    /// <summary>
    /// vUserCodePrjMainPath(vUserCodePrjMainPath)
    /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
    /// </summary>
    public class clsvUserCodePrjMainPathExWApi
    {
        //private static readonly string mstrApiControllerName = "vUserCodePrjMainPathExApi";
        /// <summary>
        /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        public static List<clsvUserCodePrjMainPathEN> arrvUserCodePrjMainPathObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
        /// </summary>
        protected static int intFindFailCount = 0;

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_AccessEx4CSharp:Gen_4WAEx_ClassConstructor1)
        /// </summary>
        public clsvUserCodePrjMainPathExWApi()
        {
        }
        /// <summary>
        /// 绑定基于Win的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_ComboBoxBindFunction)
        /// </summary>
        /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
        /// <param name = "strUserId">strUserId</param>
        /// <param name = "strPrjId">strPrjId</param>
        public static void BindCbo_UserCodePrjMainPathIdByUserIdEx(System.Windows.Forms.ComboBox objComboBox,
            string strUserId, string strPrjId)
        {
            //为数据源为表的下拉框设置内容
            string strCondition = string.Format("{5} = '1' And {0}= '{1}' And  {2}='{3}' Order By {4}",
                  convUserCodePrjMainPath.UserId, strUserId,
                    convUserCodePrjMainPath.PrjId, strPrjId,
                    convUserCodePrjMainPath.AppOrderNum,
                    convUserCodePrjMainPath.AppIsVisible);

            List<clsvUserCodePrjMainPathEN> arrObj = clsvUserCodePrjMainPathWApi.GetObjLst(strCondition);
            clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN;
            //初始化一个对象列表
            List<clsvUserCodePrjMainPathEN> vUserCodePrjMainPathList = new List<clsvUserCodePrjMainPathEN>();
            //插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
            objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
            objvUserCodePrjMainPathEN.UserCodePrjMainPathId = "0";
            objvUserCodePrjMainPathEN.ApplicationTypeName = "请选择...";
            vUserCodePrjMainPathList.Add(objvUserCodePrjMainPathEN);
            //把DataTable中的所有项均加到对象列表中
            foreach (clsvUserCodePrjMainPathEN objRow in arrObj)
            {
                vUserCodePrjMainPathList.Add(objRow);
            }
            //vUserCodePrjMainPathList.Sort((x, y) => {
            //    return x.ApplicationTypeName.CompareTo(y.ApplicationTypeName);
            //});
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.ValueMember = convUserCodePrjMainPath.UserCodePrjMainPathId;
            objComboBox.DisplayMember = convUserCodePrjMainPath.ApplicationTypeName;
            objComboBox.DataSource = vUserCodePrjMainPathList;
            objComboBox.SelectedIndex = 0;
        }

        public static clsvUserCodePrjMainPathENEx CopyToExByMachineName(clsvUserCodePrjMainPathEN objUserCodePrjMainPathENS, string strMachineName)
        {
            try
            {
                clsUserCodePrjMainPath_MachineNameEN objUserCodePrjMainPath_MachineName = clsUserCodePrjMainPath_MachineNameWApi.GetObjByKeyLst(objUserCodePrjMainPathENS.UserCodePrjMainPathId, strMachineName);
                clsvUserCodePrjMainPathENEx objUserCodePrjMainPathENT = new clsvUserCodePrjMainPathENEx();
                clsvUserCodePrjMainPathWApi.CopyTo(objUserCodePrjMainPathENS, objUserCodePrjMainPathENT);

                if (objUserCodePrjMainPath_MachineName != null)
                {
                    objUserCodePrjMainPathENT.CodePath = objUserCodePrjMainPath_MachineName.CodePath;
                    objUserCodePrjMainPathENT.CodePathBackup = objUserCodePrjMainPath_MachineName.CodePathBackup;
                    objUserCodePrjMainPathENT.LogPath = objUserCodePrjMainPath_MachineName.LogPath;
                    objUserCodePrjMainPathENT.MachineName = objUserCodePrjMainPath_MachineName.MachineName;

                }
                return objUserCodePrjMainPathENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }


        public static clsvUserCodePrjMainPathENEx CopyToEx(clsvUserCodePrjMainPathEN objUserCodePrjMainPathENS )
        {
            try
            {
                clsvUserCodePrjMainPathENEx objUserCodePrjMainPathENT = new clsvUserCodePrjMainPathENEx();
                clsvUserCodePrjMainPathWApi.CopyTo(objUserCodePrjMainPathENS, objUserCodePrjMainPathENT);
                return objUserCodePrjMainPathENT;

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

    }
}

