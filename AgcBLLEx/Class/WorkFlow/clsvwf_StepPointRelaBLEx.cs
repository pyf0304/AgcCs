
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvwf_StepPointRelaBLEx
表名:vwf_StepPointRela(00050487)
生成代码版本:2019.08.22.1
生成日期:2019/08/25 10:24:38
生成者:
生成服务器IP:101.251.68.133
工程名称:AGC
工程ID:0005
相关数据库:101.251.68.133,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:工作流管理
模块英文名:WorkFlow
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
    public static class clsvwf_StepPointRelaBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objvwf_StepPointRelaENS">源对象</param>
        /// <returns>目标对象=>clsvwf_StepPointRelaEN:objvwf_StepPointRelaENT</returns>
        public static clsvwf_StepPointRelaENEx CopyToEx(this clsvwf_StepPointRelaEN objvwf_StepPointRelaENS)
        {
            try
            {
                clsvwf_StepPointRelaENEx objvwf_StepPointRelaENT = new clsvwf_StepPointRelaENEx();
                clsvwf_StepPointRelaBL.CopyTo(objvwf_StepPointRelaENS, objvwf_StepPointRelaENT);
                return objvwf_StepPointRelaENT;
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
        /// <param name = "objvwf_StepPointRelaENS">源对象</param>
        /// <returns>目标对象=>clsvwf_StepPointRelaEN:objvwf_StepPointRelaENT</returns>
        public static clsvwf_StepPointRelaEN CopyTo(this clsvwf_StepPointRelaENEx objvwf_StepPointRelaENS)
        {
            try
            {
                clsvwf_StepPointRelaEN objvwf_StepPointRelaENT = new clsvwf_StepPointRelaEN();
                clsvwf_StepPointRelaBL.CopyTo(objvwf_StepPointRelaENS, objvwf_StepPointRelaENT);
                return objvwf_StepPointRelaENT;
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
    /// v工作流与结点关系(vwf_StepPointRela)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvwf_StepPointRelaBLEx : clsvwf_StepPointRelaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvwf_StepPointRelaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvwf_StepPointRelaDAEx vwf_StepPointRelaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvwf_StepPointRelaDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvwf_StepPointRelaENEx> GetObjExLst(string strCondition)
        {
            List<clsvwf_StepPointRelaEN> arrObjLst = clsvwf_StepPointRelaBL.GetObjLst(strCondition);
            List<clsvwf_StepPointRelaENEx> arrObjExLst = new List<clsvwf_StepPointRelaENEx>();
            foreach (clsvwf_StepPointRelaEN objInFor in arrObjLst)
            {
                clsvwf_StepPointRelaENEx objvwf_StepPointRelaENEx = new clsvwf_StepPointRelaENEx();
                clsvwf_StepPointRelaBL.CopyTo(objInFor, objvwf_StepPointRelaENEx);
                arrObjExLst.Add(objvwf_StepPointRelaENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngWorkFlowStepPointRelaId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvwf_StepPointRelaENEx GetObjExByWorkFlowStepPointRelaId(long lngWorkFlowStepPointRelaId)
        {
            clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = clsvwf_StepPointRelaBL.GetObjByWorkFlowStepPointRelaId(lngWorkFlowStepPointRelaId);
            clsvwf_StepPointRelaENEx objvwf_StepPointRelaENEx = new clsvwf_StepPointRelaENEx();
            clsvwf_StepPointRelaBL.CopyTo(objvwf_StepPointRelaEN, objvwf_StepPointRelaENEx);
            return objvwf_StepPointRelaENEx;
        }

        public static clsvwf_StepPointRelaEN GetObjByPointName(string strWorkFlowId, string strPointName)
        {
            clsvwf_StepPointRelaEN objwf_StepPointRelaEN_Cond = new clsvwf_StepPointRelaEN();
            objwf_StepPointRelaEN_Cond.SetWorkFlowId(strWorkFlowId, "=")
                    .SetPointName(strPointName, "=");

            string strCondition = objwf_StepPointRelaEN_Cond.GetCombineCondition();

            clsvwf_StepPointRelaEN objwf_StepPointRelaEN = clsvwf_StepPointRelaBL.GetFirstObj_S(strCondition);
            return objwf_StepPointRelaEN;
        }
        /// <summary>
        /// 绑定基于Web的下拉框-使用Cache
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strWorkFlowId">工作流Id</param>
        public static void BindDdl_PointIdByWorkFlowIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strWorkFlowId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[工作流结点表]...", "0");
            List<clsvwf_StepPointRelaEN> arrvwf_StepPointRelaObjLst = GetAllvwf_StepPointRelaObjLstCache();
            arrvwf_StepPointRelaObjLst.ForEach(x=>x._StrTag = string.Format("{0}({1})", x.PointName, x.LevelNo));
            IEnumerable<clsvwf_StepPointRelaEN> arrvwf_StepPointRelaObjLst_Sub = arrvwf_StepPointRelaObjLst
                .Where(x => x.WorkFlowId == strWorkFlowId)
                .OrderBy(x => x.LevelNo);                
            objDDL.DataValueField = convwf_StepPointRela.PointId;
            objDDL.DataTextField = clsvwf_StepPointRelaEN.con_StrTag;
            objDDL.DataSource = arrvwf_StepPointRelaObjLst_Sub;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWorkFlowId"></param>
        /// <param name="strPointId"></param>
        /// <returns></returns>
        public static clsvwf_StepPointRelaEN GetObjByWorkFlowIdAndPointIdCache(string strWorkFlowId, string strPointId)
        {
            //初始化列表缓存
            List<clsvwf_StepPointRelaEN> arrObjLstCache = clsvwf_StepPointRelaBL.GetObjLstCache();

            IEnumerable<clsvwf_StepPointRelaEN> arrwf_StepPointRelaObjLst_Sel
                = arrObjLstCache
                .Where(x => x.WorkFlowId == strWorkFlowId && x.PointId == strPointId);
            if (arrwf_StepPointRelaObjLst_Sel.Count() == 0)
            {
                clsvwf_StepPointRelaEN obj = clsvwf_StepPointRelaBLEx.GetObjByWorkFlowIdAndPointId(strWorkFlowId, strPointId);
                if (obj != null)
                {
                    CacheHelper.Remove(clsvwf_StepPointRelaEN._CurrTabName);

                    //clsvwf_StepPointRelaBL.arrvwf_StepPointRelaObjLstCache = null;
                    return obj;
                }
                return null;
            }
            return arrwf_StepPointRelaObjLst_Sel.First();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWorkFlowId"></param>
        /// <param name="strTabKeyId"></param>
        /// <returns></returns>

        public static clsvwf_StepPointRelaEN GetObjByWorkFlowIdAndTabKeyIdCache(string strWorkFlowId, string strTabKeyId)
        {
            //初始化列表缓存
            List<clsvwf_StepPointRelaEN> arrObjLstCache = clsvwf_StepPointRelaBL.GetObjLstCache();

            IEnumerable<clsvwf_StepPointRelaEN> arrwf_StepPointRelaObjLst_Sel
                = arrObjLstCache
                .Where(x => x.WorkFlowId == strWorkFlowId && x.TabKeyId == strTabKeyId);
            if (arrwf_StepPointRelaObjLst_Sel.Count() == 0)
            {
                clsvwf_StepPointRelaEN obj = clsvwf_StepPointRelaBLEx.GetObjByWorkFlowIdAndTabKeyId(strWorkFlowId, strTabKeyId);
                if (obj != null)
                {
                    //clsvwf_StepPointRelaBL.arrvwf_StepPointRelaObjLstCache = null;
                    CacheHelper.Remove(clsvwf_StepPointRelaEN._CurrTabName);

                    return obj;
                }
                return null;
            }
            return arrwf_StepPointRelaObjLst_Sel.First();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrwf_StepProcessRelaObjLst"></param>
        /// <param name="strPointId"></param>
        /// <returns></returns>
        public static string GetHeadPoint(IEnumerable<clsvwf_StepProcessRelaEN> arrwf_StepProcessRelaObjLst, string strPointId)
        {
            Queue<string> arrQueue = new Queue<string>();
            arrQueue.Enqueue(strPointId);
            while (arrQueue.Count > 0)
            {
                string strPointId_Curr = arrQueue.Dequeue();
                IEnumerable<clsvwf_StepProcessRelaEN> arrwf_StepProcessRelaObjLst_Sel 
                    = arrwf_StepProcessRelaObjLst.Where(x => x.EndPoint == strPointId_Curr);
                foreach (clsvwf_StepProcessRelaEN objInFor in arrwf_StepProcessRelaObjLst_Sel)
                {
                    arrQueue.Enqueue(objInFor.StartPoint);
                }
                clswf_PointEN objwf_Point = clswf_PointBL.GetObjByPointIdCache(strPointId_Curr);
                if (objwf_Point.PointName == "起点")
                {
                    IEnumerable<clsvwf_StepProcessRelaEN> arrwf_StepProcessRelaObjLst_Sel2
                        = arrwf_StepProcessRelaObjLst.Where(x => x.StartPoint == objwf_Point.PointId);
                    return arrwf_StepProcessRelaObjLst_Sel2.First().EndPoint;
                }
            }
            return "";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWorkFlowId"></param>
        /// <param name="strTabKeyId"></param>
        /// <returns></returns>
        public static clsvwf_StepPointRelaEN GetHeadObjByWorkFlowIdAndTabKeyIdCache(string strWorkFlowId, string strTabKeyId)
        {
            //初始化列表缓存
            IEnumerable<clsvwf_StepProcessRelaEN> arrwf_StepProcessRelaObjLst_Sel
                = clsvwf_StepProcessRelaBLEx.GetObjLstByWorkFlowIdCache(strWorkFlowId);

            clsvwf_StepPointRelaEN objvwf_StepPointRela = GetObjByWorkFlowIdAndTabKeyIdCache(strWorkFlowId, strTabKeyId);
            string strHeadPointId = GetHeadPoint(arrwf_StepProcessRelaObjLst_Sel, objvwf_StepPointRela.PointId);
            clsvwf_StepPointRelaEN objvwf_StepPointRela_Sel = GetObjByWorkFlowIdAndPointIdCache(strWorkFlowId, strHeadPointId);
           
            return objvwf_StepPointRela_Sel;
        }
        private static clsvwf_StepPointRelaEN GetObjByWorkFlowIdAndTabKeyId(string strWorkFlowId, string strTabKeyId)
        {
            string strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                convwf_StepPointRela.WorkFlowId, strWorkFlowId,
                convwf_StepPointRela.TabKeyId, strTabKeyId);
            clsvwf_StepPointRelaEN Obj = clsvwf_StepPointRelaBL.GetFirstObj_S(strCondition);
            return Obj;
        }

        private static clsvwf_StepPointRelaEN GetObjByWorkFlowIdAndPointId(string strWorkFlowId, string strPointId)
        {
            string strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                convwf_StepPointRela.WorkFlowId, strWorkFlowId,
                convwf_StepPointRela.PointId, strPointId);
            clsvwf_StepPointRelaEN Obj = clsvwf_StepPointRelaBL.GetFirstObj_S(strCondition);
            return Obj;
        }

    }
}