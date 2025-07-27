
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsDetailRegionBLEx
表名:DetailRegion(00050543)
生成代码版本:2020.05.24.1
生成日期:2020/05/26 02:27:29
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:区域管理
模块英文名:RegionManage
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
using AGC.Const;
using com.taishsoft.datetime;
using com.taishsoft.commexception;

namespace AGC.BusinessLogicEx
{
    public static class clsDetailRegionBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objDetailRegionENS">源对象</param>
        /// <returns>目标对象=>clsDetailRegionEN:objDetailRegionENT</returns>
        //public static clsDetailRegionENEx CopyToEx(this clsDetailRegionEN objDetailRegionENS)
        //{
        //    try
        //    {
        //        clsDetailRegionENEx objDetailRegionENT = new clsDetailRegionENEx();
        //        clsDetailRegionBL.DetailRegionDA.CopyTo(objDetailRegionENS, objDetailRegionENT);
        //        return objDetailRegionENT;
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);
        //    }
        //}

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objDetailRegionENS">源对象</param>
        /// <returns>目标对象=>clsDetailRegionEN:objDetailRegionENT</returns>
        //public static clsDetailRegionEN CopyTo(this clsDetailRegionENEx objDetailRegionENS)
        //{
        //    try
        //    {
        //        clsDetailRegionEN objDetailRegionENT = new clsDetailRegionEN();
        //        clsDetailRegionBL.CopyTo(objDetailRegionENS, objDetailRegionENT);
        //        return objDetailRegionENT;
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);
        //    }
        //}
    }
    /// <summary>
    /// 详细信息区域(DetailRegion)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsDetailRegionBLEx 
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsDetailRegionDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsDetailRegionDAEx DetailRegionDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsDetailRegionDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objDetailRegionENS">源对象</param>
        /// <returns>目标对象=>clsDetailRegionEN:objDetailRegionENT</returns>
        //public static clsDetailRegionENEx CopyToEx(clsDetailRegionEN objDetailRegionENS)
        //{
        //    try
        //    {
        //        clsDetailRegionENEx objDetailRegionENT = new clsDetailRegionENEx();
        //        clsDetailRegionBL.DetailRegionDA.CopyTo(objDetailRegionENS, objDetailRegionENT);
        //        return objDetailRegionENT;
        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("(errid:BlEx000005)Copy表对象数据出错,{1}.({0})",
        //        clsStackTrace.GetCurrClassFunction(),
        //        objException.Message);
        //        throw new Exception(strMsg);
        //    }
        //}

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        //public static List<clsDetailRegionENEx> GetObjExLst(string strCondition)
        //{
        //    List<clsDetailRegionEN> arrObjLst = clsDetailRegionBL.GetObjLst(strCondition);
        //    List<clsDetailRegionENEx> arrObjExLst = new List<clsDetailRegionENEx>();
        //    foreach (clsDetailRegionEN objInFor in arrObjLst)
        //    {
        //        clsDetailRegionENEx objDetailRegionENEx = new clsDetailRegionENEx();
        //        clsDetailRegionBL.CopyTo(objInFor, objDetailRegionENEx);
        //        arrObjExLst.Add(objDetailRegionENEx);
        //    }
        //    return arrObjExLst;
        //}

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngRegionId">表关键字</param>
        /// <returns>表扩展对象</returns>
        //public static clsDetailRegionENEx GetObjExByRegionId(string lngRegionId)
        //{
        //    clsDetailRegionEN objDetailRegionEN = clsDetailRegionBL.GetObjByRegionId(lngRegionId);
        //    clsDetailRegionENEx objDetailRegionENEx = new clsDetailRegionENEx();
        //    clsDetailRegionBL.CopyTo(objDetailRegionEN, objDetailRegionENEx);
        //    return objDetailRegionENEx;
        //}

        //public static void GetDetailRegionEx(ref clsDetailRegionENEx objDetailRegionENEx, string strPrjId)
        //{
        //    //clsDetailRegionDAEx objDetailRegionDA = new clsDetailRegionDAEx();
        //    //bool bolResult = objDetailRegionDA.GetDetailRegionEx(ref objDetailRegionEN);
        //    //return bolResult;

        //    clsDetailRegionEN objDetailRegionEN = GetObjByRegionId_CacheEx(objDetailRegionENEx.RegionId, strPrjId);
        //    clsDetailRegionBL.CopyTo(objDetailRegionEN, objDetailRegionENEx);
        //}

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_GetObjByKey_Cache)
        /// </summary>
        /// <param name = "lngRegionId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        //public static clsDetailRegionEN GetObjByRegionId_CacheEx(string lngRegionId, string strPrjId)
        //{
        //    //初始化列表缓存
        //    List<clsDetailRegionEN> arrObjLst_Cache = clsDetailRegionBL.GetObjLst_Cache(strPrjId);


        //    IEnumerable<clsDetailRegionEN> arrDetailRegionObjLst_Sel1 =
        //    from objDetailRegionEN in arrObjLst_Cache
        //    where objDetailRegionEN.RegionId == lngRegionId
        //    select objDetailRegionEN;
        //    List<clsDetailRegionEN> arrDetailRegionObjLst_Sel = new List<clsDetailRegionEN>();
        //    foreach (clsDetailRegionEN obj in arrDetailRegionObjLst_Sel1)
        //    {
        //        arrDetailRegionObjLst_Sel.Add(obj);
        //    }
        //    if (arrDetailRegionObjLst_Sel.Count == 0)
        //    {
        //        return null;
        //    }
        //    return arrDetailRegionObjLst_Sel[0];
        //}



        public static bool ImportRelaFlds(string lngRegionId, string strPrjId, string strUserId)
        {
            int intRecNum = 0;
            //clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();

           
            //1、获取当前区域ID的相关主表ID；
            string strRelaTabId = clsViewRegionBL.GetObjByRegionId_Cache(lngRegionId, strPrjId).TabId;
            //2、获取相关主表ID的字段的对象列表;
            IEnumerable<clsvPrjTabFldEN> arrRelaTabFldObjList =
                clsvPrjTabFldBL.GetObjLst("TabId = '" + strRelaTabId + "' order by SequenceNumber");

            List<string> arrNoNeedFieldTypeId = new List<string>() {
                enumFieldType.ManageField_04,
                enumFieldType.BeingNot_18,
                enumFieldType.SynField_08,
                enumFieldType.CalcField_11
            };


            arrRelaTabFldObjList = arrRelaTabFldObjList.Where(x => arrNoNeedFieldTypeId.Contains(x.FieldTypeId) == false);


            List<clsDetailRegionFldsEN> arrDetailRegionFlds = arrRelaTabFldObjList
                .Where(x => x.PrimaryTypeId != enumPrimaryType.Identity_02)
                .Select(clsDetailRegionFldsBLEx.GetObjByvPrjTabFld).ToList();
            intRecNum = clsGeneralTab2.funGetRecCountByCond(clsDetailRegionFldsEN._CurrTabName_S, "RegionId = " + lngRegionId);

            List<clsPrjTabFldEN> arrPrjTabFld = clsPrjTabFldBL.GetObjLst_Cache(strPrjId);

            foreach (clsDetailRegionFldsEN objDetailRegionFldsEN in arrDetailRegionFlds)
            {
                var objPrjTabFld = arrPrjTabFld.Find(x=>x.FldId == objDetailRegionFldsEN.FldId && x.FieldTypeId == enumFieldType.KeyField_02);
                if (objPrjTabFld != null)
                {
                    var objPrjTabFld_Name = arrPrjTabFld.Find(x => x.TabId == objPrjTabFld.TabId && x.FieldTypeId == enumFieldType.NameField_03);
                    if (objPrjTabFld_Name != null)
                    {
                        if (arrDetailRegionFlds.Find(x=>x.FldId == objPrjTabFld_Name.FldId) != null)
                        {
                            objDetailRegionFldsEN.InUse = false;
                        }
                    }
                }
                objDetailRegionFldsEN.SetUpdDate(clsDateTime.getTodayStr(0))
                    .SetUpdUser(strUserId)
                    .SetPrjId(strPrjId)
                    .SetRegionId(lngRegionId);

                //5、检查传进去的对象属性是否合法

                clsDetailRegionFldsBL.CheckPropertyNew(objDetailRegionFldsEN);

                //6、把数据实体层的数据存贮到数据库中
                //long lngTabFldId = objDetailRegionFldsEN.TabFldId;
                //string strFldName = clsvPrjTabFldBL.GetObjBymId(lngTabFldId).FldName;
                string strCondition = string.Format("{0}={1} and {2}='{3}'",
                    clsDetailRegionFldsEN.con_RegionId, lngRegionId,
                    clsDetailRegionFldsEN.con_FldId, objDetailRegionFldsEN.FldId);
                if (clsDetailRegionFldsBL.IsExistRecord(strCondition) == false)
                {
                    objDetailRegionFldsEN.SeqNum = intRecNum + 1;
                    intRecNum++;
                    if (clsDetailRegionFldsBL.AddNewRecordBySql2(objDetailRegionFldsEN) == false)
                    {
                        throw new clsDbObjException("添加编辑区域字段不成功!" + clsPrjTabFldBLEx.getFldName(objDetailRegionFldsEN.TabFldId));
                    }

                }

            }
            //设置当前界面的修改日期
            clsViewInfoBLEx.SetViewUpdDate(lngRegionId);

            return true;

        }
        public static bool ImportRelaFlds_Detail(string lngRegionId, string strPrjId, string strUserId)
        {
            int intRecNum = 0;
            clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
            
            //1、获取当前区域ID的相关主表ID；
            string strRelaTabId = clsViewRegionBL.GetObjByRegionId(lngRegionId).TabId;
            //2、获取相关主表ID的字段的对象列表;
            IEnumerable<clsvPrjTabFldEN> arrRelaTabFldObjList =
                clsvPrjTabFldBL.GetObjLst("TabId = '" + strRelaTabId + "' order by SequenceNumber");

            List<string> arrNoNeedFieldTypeId = new List<string>() {
                enumFieldType.ManageField_04,
                enumFieldType.BeingNot_18,
                enumFieldType.SynField_08
            };

            arrRelaTabFldObjList = arrRelaTabFldObjList.Where(x => arrNoNeedFieldTypeId.Contains(x.FieldTypeId) == false);

            foreach (clsvPrjTabFldEN objPrjTabFldEN in arrRelaTabFldObjList)
            {
                if (objPrjTabFldEN.PrimaryTypeId == "02" && objPrjTabFldEN.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                objDetailRegionFldsEN.TabFldId = objPrjTabFldEN.mId;
                objDetailRegionFldsEN.RegionId = lngRegionId;
                switch (objPrjTabFldEN.DataTypeName)
                {
                    case "bit":
                        objDetailRegionFldsEN.CtlTypeId = enumCtlTypeAbbr.Label_10;// "02";
                        break;
                    default:
                        objDetailRegionFldsEN.CtlTypeId = enumCtlTypeAbbr.Label_10;//"16";
                        break;
                }
                //判断该字段是否为相关表中的关键字
                if (objPrjTabFldEN.FieldTypeId != enumFieldType.KeyField_02
                    && objPrjTabFldEN.IsNeedTransCode == true)
                {
                    objDetailRegionFldsEN.CtlTypeId = enumCtlTypeAbbr.Label_10;
                }
                else
                {
                    objDetailRegionFldsEN.CtlTypeId = enumCtlTypeAbbr.Label_10;
                }
                objDetailRegionFldsEN.INOUTTypeId = clsINOUTTypeBLEx.OUT_Type;		//输出类型
                objDetailRegionFldsEN.UpdDate = clsDateTime.getTodayStr(0);
                objDetailRegionFldsEN.UpdUser = strUserId;
                objDetailRegionFldsEN.PrjId = strPrjId;

                //5、检查传进去的对象属性是否合法

                clsDetailRegionFldsBL.CheckPropertyNew(objDetailRegionFldsEN);

                //6、把数据实体层的数据存贮到数据库中
                long lngTabFldId = objDetailRegionFldsEN.TabFldId;
                string strFldName = clsvPrjTabFldBL.GetObjBymId(lngTabFldId).FldName;
                intRecNum = clsGeneralTab2.funGetRecCountByCond(clsDetailRegionFldsEN._CurrTabName_S, "RegionId = " + lngRegionId);
                if (clsvDetailRegionFldsBL.IsExistRecord("RegionId = " + lngRegionId + " and FldName = '" + strFldName + "'") == false)
                {
                    objDetailRegionFldsEN.SeqNum = intRecNum + 1;
                    intRecNum++;
                    if (clsDetailRegionFldsBL.AddNewRecordBySql2(objDetailRegionFldsEN) == false)
                    {
                        throw new clsDbObjException("添加编辑区域字段不成功!" + clsPrjTabFldBLEx.getFldName(objDetailRegionFldsEN.TabFldId));
                    }
                    else
                    {
                    }
                }

            }
            return true;

        }


        public static bool ImportRelaFlds(string lngRegionId, List<clsvPrjTabFldEN> arrRelaTabFldObjList, string strPrjId, string strUserId)
        {
            int intRecNum = 0;
            //clsDetailRegionFldsEN objDetailRegionFldsEN = new clsDetailRegionFldsEN();
           
            //1、获取当前区域ID的相关主表ID；
            string strRelaTabId = clsViewRegionBL.GetObjByRegionId(lngRegionId).TabId;
            clsPrjTabEN objRelaPrjTab = clsPrjTabBL.GetObjByTabId_Cache(strRelaTabId, strPrjId);

            IEnumerable<clsDetailRegionFldsEN> arrDetailRegionFldsObjLst = arrRelaTabFldObjList.Where(x => x.PrimaryTypeId != enumPrimaryType.Identity_02).Select(clsDetailRegionFldsBLEx.GetObjByvPrjTabFld);

            //2、获取相关主表ID的字段的对象列表;
            foreach (clsDetailRegionFldsEN objDetailRegionFldsEN in arrDetailRegionFldsObjLst)
            {
                objDetailRegionFldsEN.RegionId = lngRegionId;

                objDetailRegionFldsEN.UpdUser = strUserId;
                objDetailRegionFldsEN.PrjId = strPrjId;

                //5、检查传进去的对象属性是否合法

                clsDetailRegionFldsBL.CheckPropertyNew(objDetailRegionFldsEN);

                //6、把数据实体层的数据存贮到数据库中
                long lngTabFldId = objDetailRegionFldsEN.TabFldId;
                string strFldName = clsvPrjTabFldBL.GetObjBymId(lngTabFldId).FldName;
                if (clsvDetailRegionFldsBL.IsExistRecord("RegionId = " + lngRegionId + " and FldName = '" + strFldName + "'") == false)
                {
                    objDetailRegionFldsEN.SeqNum = intRecNum + 1;
                    intRecNum++;
                    if (clsDetailRegionFldsBL.AddNewRecordBySql2(objDetailRegionFldsEN) == false)
                    {
                        throw new clsDbObjException("添加编辑区域字段不成功!" + clsPrjTabFldBLEx.getFldName(objDetailRegionFldsEN.TabFldId));
                    }
                    else
                    {
                    }
                }

            }
            //设置当前界面的修改日期
            clsViewInfoBLEx.SetViewUpdDate(lngRegionId);

            return true;

        }

        public static bool CopyTo(string lngRegionId_S, string lngRegionId_T, string strPrjId, string strUpdUser)
        {
        

            List<clsDetailRegionFldsEN> arrDetailRegionFldsObjLst = clsDetailRegionFldsBLEx.GetObjLstByRegionId_CacheEx(lngRegionId_S, strPrjId);
            foreach (clsDetailRegionFldsEN objInfor2 in arrDetailRegionFldsObjLst)
            {
                clsDetailRegionFldsEN objInfor2_T = new clsDetailRegionFldsEN();
                clsDetailRegionFldsBL.CopyTo(objInfor2, objInfor2_T);
                objInfor2_T.RegionId = lngRegionId_T;
                objInfor2_T.SetUpdDate(clsDateTime.getTodayDateTimeStr(1))
                    .SetUpdUser(strUpdUser);
                objInfor2_T.EditRecordEx();
            }
            return true;
        }
    }
}