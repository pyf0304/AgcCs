using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;

using AGC.Entity;


using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.file;
using com.taishsoft.commexception;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace AutoGCLib
{
    /// <summary>
    /// 该类专门用生成数据表的表代理层,该代理层是逻辑层的一部分,体系结构从下到下,
    /// 共分以下几层:
    ///		1、界面层
    ///			通用界面层,专门提供一些界面控件的公共操作函数
    ///		2、逻辑层
    ///			2.1 业务逻辑层
    ///			2.2 表代理层。包括:
    ///					1)表记录的添加、
    ///					2)表记录的删除
    ///					3)表记录的修改
    ///					4)表记录的查询
    ///					5)获取某些表记录的有关字段属性
    ///					6)设置表记录的有关字段属性等。
    ///		3、数据层,即通用数据层,专门用于操作数据库的一些操作,以及操作表的一些通用操作
    /// </summary>
    class EntityLayer_Sim4TypeScript : clsGeneCodeBase4Tab
    {
        

        #region 构造函数

        public EntityLayer_Sim4TypeScript(string strTabId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strPrjDataBaseId, strPrjId)
        {

            // 
            // TODO: 在此处添加构造函数逻辑
            //
        }
        #endregion
     

        /// <summary>
        /// 生成Entity层代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            //if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层!({1})",
                                  objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层!({1})",
                  objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; ///临时变量;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);


            objPrjTabENEx.ClsName = "cls" + objPrjTabENEx.TabName + "EN_Sim";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.EntityLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".ts";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".ts";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //类名开始

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));
                
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                
                strBuilder.AppendFormat("\r\n" + "export class  {0}",
                    objPrjTabENEx.ClsName,
                    this.objKeyField.PrivFuncName);
                strBuilder.Append("\r\n" + "{");
                
                strBuilder.Append("\r\n" + "//以下是属性变量");

                //生成所有的函数

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                     strFuncName = objvFunction4GeneCodeEN.FuncName;
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }
                strBuilder.Append("\r\n" + "public sfUpdFldSetStr = \"\";     //专门用于记录某字段属性是否修改");
                strBuilder.Append("\r\n" + "public sfFldComparisonOp = \"\";     //专门用于记录条件对象某字段的比较运算符");                
                strBuilder.Append("\r\n" + "};");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
  
            }
            return strBuilder.ToString();
        }

        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strBuilder = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strBuilder.Append("\r\n" + "");
                    strBuilder.Append("\r\n" + "");
                    strBuilder.Append("\r\n " + strFuncName.Substring(6));
                    return strBuilder.ToString();
                }

                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
                {
                    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                }
                else
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                }

                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strBuilder.Append("\r\n" + strTemp);
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strBuilder.ToString();
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
              string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(EntityLayer_Sim4TypeScript);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                    if (mt.GetParameters().Length == 0)
                    {
                        strCode = (string)mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strErrMsg = ""; 
                if (objException.InnerException != null)
                {
                    strErrMsg = objException.InnerException.Message;
                }
                else
                { 
                    strErrMsg = objException.Message;
                }
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", strFuncName, strErrMsg);
                throw new Exception(sbMessage.ToString());
            }
        }
        public override void GetClsName()
        {
            this.ClsName = string.Format("cls{0}EN_Sim", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
        public string Gen_EN_ClassConstructor1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///类构造器----------------------------------------------;            
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// 构造函数");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.AppendFormat("\r\n constructor()",
                objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n super();");
            //strBuilder.Append("\r\n this.hmProperty =  new collections.Dictionary <string, boolean>();");
            //strBuilder.Append("\r\n this.SetInit();");
            strBuilder.AppendFormat("\r\n this.CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n this.KeyFldName = \"{0}\";", objKeyField.FldName);

            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 类公开的类属性
        /// </summary>
        /// <returns></returns>
        public string Gen_SimEN_ClsProperty()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///定义类属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n/// <summary>");
                strBuilder.AppendFormat("\r\n/// {4}(说明:{3};字段类型:{0};字段长度:{1};是否可空:{2})",
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength,
                    objField.ObjFieldTabENEx.IsNull,
                    objField.ObjFieldTabENEx.MemoInTab,
                     objField.ColCaption);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n/// </summary>");
                strBuilder.AppendFormat("\r\n public {1}: {0} = {2};",
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.InitValue_TypeScript);

                strBuilder.Append("\r\n");
            }
            return strBuilder.ToString();
        }
    
    }
}
