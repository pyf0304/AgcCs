using System;
using System.Collections;
using System.Text;
using com.taishsoft.commdb;

using System.Collections.Generic;
using AGC.Entity;

using AGC.BusinessLogic;
using com.taishsoft.common;
using System.Linq;

namespace AGC.BusinessLogicEx
{
	/// <summary>
	/// clsFuncModuleEx 的摘要说明。
	/// </summary>
	public partial class clsFuncModule_AgcBLEx: clsFuncModule_AgcBL
    {
        ///// <summary>
        ///// 功能模块对象列表
        ///// </summary>
        //public  static List<clsvFuncModule_AgcEN> arrvFuncModuleObjLst = null;// clsFuncModule_AgcBL.GetFuncModuleObjList(strCondition.ToString() + " order by FuncModuleName");
       
      
		/// <summary>
		/// 功能:把源工程的多个对象复制到新工程中,同时复制这些对象相关的字段。
		/// </summary>
		/// <param name = "strSouPrjId"></param>
		/// <param name = "strTarPrjId"></param>
		/// <param name = "arrSouObjId"></param>
		/// <returns></returns>
        public static bool CopyFuncModule(string strSouPrjId, string strTarPrjId, List<string> arrSouFuncModuleId, string strUserId)
		{
			//操作步骤:
			//1、对源工程中的源对象列表进行遍历,然后针对其中的每个对象ID进行操作
			//2、根据<对象ID>获取所有属性
			//3、根据当前对象ID的属性<对象名>检查是否在目标工程中存在相同的<对象名>。
			//       如果存在相同的<对象名>就放弃该对象名,不需要复制。
			//4、把当前对象复制 到新工程中。
			//    4.1 在目标工程中新建一个对象
			//    4.2 把当前对象的属性都复制到新建的对象中
			//5、获取当前对象的相关字段列表；
			//6、对该表进行循环,把字段ID(源字段ID)插入到一个ArrayList
			//7、把这组源字段ID列表从源工程中复制到目标工程中,同时获取一组插入到目标工程中的字段ID列表
			//8、把获取的一组新字段ID列表与新对象ID建立关系
			///

			clsFuncModule_AgcEN objSouFuncModule = null;
			clsFuncModule_AgcEN objNewFuncModule = null;
			string strNewclsFuncModuleId;
			//1、对源工程中的源对象列表进行遍历,然后针对其中的每个对象ID进行操作
			foreach (string  strSouFuncModuleId in arrSouFuncModuleId)
			{
				//2、根据<对象ID>获取所有属性
                objSouFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(strSouFuncModuleId, strSouPrjId);
				//3、根据当前对象ID的属性<对象名>检查是否在目标工程中存在相同的<对象名>。
				//       如果存在相同的<对象名>就放弃该对象名,不需要复制。
                if (clsFuncModule_AgcBL.IsExistRecord("PrjId = '" + strTarPrjId + "' and FuncModuleName = '" + objSouFuncModule.FuncModuleName + "'")  ==  true)
				{
					continue;
				}
				//4、把当前对象复制 到新工程中。
				//    4.1 在目标工程中新建一个对象
				strNewclsFuncModuleId = clsGeneralTab.GetMaxStrId("FuncModule_Agc", "FuncModuleAgcId", 8, strTarPrjId);
				objNewFuncModule = new clsFuncModule_AgcEN(strNewclsFuncModuleId);
				//    4.2 把当前对象的属性都复制到新建的对象中
				objNewFuncModule.PrjId = strTarPrjId;
				objNewFuncModule.FuncModuleName = objSouFuncModule.FuncModuleName;
				objNewFuncModule.Memo = objSouFuncModule.Memo;
                if (clsFuncModule_AgcBL.AddNewRecordBySql2(objNewFuncModule)  ==  false)
				{
					return false;
				}
				else
				{
					//					strResult = "添加记录成功!";
				}
			}
			return true;
		}
        /// <summary>
        /// 功能:把源工程的多个对象复制到新工程中,同时复制这些对象相关的字段。
        /// </summary>
        /// <param name = "strSouPrjId">源工程Id</param>
        /// <param name = "strTarPrjId">目标工程Id</param>
        /// <param name = "strUserId">操作用户Id</param>
        /// <returns>是否成功？</returns>
        public static bool CopyFuncModule(string strSouPrjId, string strTarPrjId, string strUserId)
        {
            //操作步骤:
            //1、对源工程中的源对象列表进行遍历,然后针对其中的每个对象ID进行操作
            //2、根据<对象ID>获取所有属性
            //3、根据当前对象ID的属性<对象名>检查是否在目标工程中存在相同的<对象名>。
            //       如果存在相同的<对象名>就放弃该对象名,不需要复制。
            //4、把当前对象复制 到新工程中。
            //    4.1 在目标工程中新建一个对象
            //    4.2 把当前对象的属性都复制到新建的对象中
            //5、获取当前对象的相关字段列表；
            //6、对该表进行循环,把字段ID(源字段ID)插入到一个ArrayList
            //7、把这组源字段ID列表从源工程中复制到目标工程中,同时获取一组插入到目标工程中的字段ID列表
            //8、把获取的一组新字段ID列表与新对象ID建立关系
                   
            string strCondition = string.Format("PrjId = '{0}'", strSouPrjId);
            List<clsFuncModule_AgcEN> arrFuncModuleObjLst = clsFuncModule_AgcBL.GetObjLst(strCondition);
            string strNewclsFuncModuleId;
            //1、对源工程中的源对象列表进行遍历,然后针对其中的每个对象ID进行操作
            foreach (clsFuncModule_AgcEN objFuncModule_S in arrFuncModuleObjLst)
            {
                //2、根据<对象ID>获取所有属性
                //objSouFuncModule = new clsFuncModule_AgcEN(strSouFuncModuleId, true);
                //3、根据当前对象ID的属性<对象名>检查是否在目标工程中存在相同的<对象名>。
                //       如果存在相同的<对象名>就放弃该对象名,不需要复制。
                if (clsFuncModule_AgcBL.IsExistRecord("PrjId = '" + strTarPrjId + "' and FuncModuleName = '" + objFuncModule_S.FuncModuleName + "'")  ==  true)
                {
                    continue;
                }
                //4、把当前对象复制 到新工程中。
                //    4.1 在目标工程中新建一个对象
                strNewclsFuncModuleId = clsGeneralTab.GetMaxStrId("FuncModule_Agc", "FuncModuleAgcId", 8, strTarPrjId);
                objFuncModule_S.FuncModuleAgcId = strNewclsFuncModuleId;
                objFuncModule_S.PrjId = strTarPrjId;
                objFuncModule_S.UpdUser = strUserId;
                objFuncModule_S.UpdDate = clsDateTime_Db.GetDataBaseDateTime14();

                if (clsFuncModule_AgcBL.AddNewRecordBySql2(objFuncModule_S)  ==  false)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        /// <param name = "strPrjId">工程ID</param>
        public static void BindDdl_FuncModuleAgcIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[功能模块_Agc]...", "0");
            //string strCondition = string.Format("1 =1 Order By {0}", conFuncModule_Agc.FuncModuleAgcId);
            IEnumerable<clsFuncModule_AgcEN> arrObjLst = clsFuncModule_AgcBL.GetObjLstCache(strPrjId);// strCondition);
            arrObjLst = arrObjLst.Where(x => x.PrjId == strPrjId);
            objDDL.DataValueField = conFuncModule_Agc.FuncModuleAgcId;
            objDDL.DataTextField = conFuncModule_Agc.FuncModuleName;
            objDDL.DataSource = arrObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
    }
}
