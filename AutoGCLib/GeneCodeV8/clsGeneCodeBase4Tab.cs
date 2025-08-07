using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using CodeStruct;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.sql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

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
    public abstract partial class clsGeneCodeBase4Tab : clsGCBase
    {
        protected CodeElement objCodeElement_Imports = null;
        private clsPrjTabENEx mobjPrjTabENEx = null;
        public clsGeneCodeBase4Tab() : base()
        {
        }
        public string GetVueShareClsName()
        {
            string strClsName = string.Format("{0}VueShare", this.TabName);
            //if (objViewInfoENEx.ViewName != $"{objViewInfoENEx.TabName}CRUD")
            //{
            //    strClsName = string.Format("{0}VueShare", objViewInfoENEx.ViewName);
            //}
            return strClsName;
        }

        public clsPrjTabENEx objPrjTabENEx { get => mobjPrjTabENEx; set => mobjPrjTabENEx = value; }

        public string ThisClsName
        {
            get
            {
                return objPrjTabENEx.ClsName;
            }
        }
        public string CurrUserName
        {
            set
            {

                if (mobjPrjTabENEx != null)
                {
                    mobjPrjTabENEx.UserId = value;
                }
            }

        }
        public string PrjId
        {
            get
            {

                return objPrjTabENEx.PrjId;

            }
        }

        public string TabId
        {
            get
            {

                return objPrjTabENEx.TabId;

            }
        }

        public string TabName
        {
            get
            {

                return objPrjTabENEx.TabName;

            }
        }

        public string TabCnName
        {
            get
            {

                return objPrjTabENEx.TabCnName;

            }
        }
        public string PrjDataBaseId
        {
            get
            {

                return objPrjTabENEx.PrjDataBaseId;

            }
        }

        public bool IsAppliedInViewList
        {
            get
            {
                return objPrjTabENEx.IsAppliedInViewList;
            }
        }


        public bool IsAppliedInViewList4CmPrjId
        {
            get
            {
                return objPrjTabENEx.IsAppliedInViewList4CmPrjId;
            }
        }
        public CacheClassify thisCacheClassify
        {
            get
            {
                if (objCacheClassify == null)
                {
                    CacheClassify obj = new CacheClassify
                    {
                        FldId = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.FldId : "",
                        FldId2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.FldId : "",

                        FldName = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.FldName : "",
                        FldName2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.FldName : "",

                        VarDef4Fld = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? string.Format("{0}.{1}", ThisObjName4EN, objPrjTabENEx.ObjCacheClassifyFld_TS.PropertyName(this.isFstLcase)) : "",
                        VarDef4Fld2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? string.Format("{0}.{1}", ThisObjName4EN, objPrjTabENEx.ObjCacheClassifyFld2_TS.PropertyName(this.isFstLcase)) : "",

                        PriVarName = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.PrivFuncName : "",
                        PriVarName2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.ObjFieldTabENEx.PrivFuncName : "",
                        TypeScriptType = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "",
                        TypeScriptType2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "",
                        CsType = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.CsType : "",
                        CsType2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.ObjFieldTabENEx.objDataTypeAbbrEN.CsType : "",

                        DataTypeId = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.DataTypeId : "",
                        DataTypeId2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.ObjFieldTabENEx.DataTypeId : "",
                        FldLength = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength : 0,
                        FldLength2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.ObjFieldTabENEx.FldLength : 0,
                        IsHasCacheClassfyFld = objPrjTabENEx.objCacheClassifyFld == null ? false : true,

                        IsHasCacheClassfyFld2 = objPrjTabENEx.objCacheClassifyFld2 == null ? false : true,
                        IsHasCacheClassfyFld_TS = objPrjTabENEx.ObjCacheClassifyFld_TS == null ? false : true,

                        IsHasCacheClassfyFld2_TS = objPrjTabENEx.ObjCacheClassifyFld2_TS == null ? false : true,

                        IsNumberType = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.IsNumberType() : false,
                        IsNumberType2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.IsNumberType() : false,
                        IsForExtendClass = objPrjTabENEx.objCacheClassifyFld != null ? objPrjTabENEx.objCacheClassifyFld.IsForExtendClass() : false,
                        IsForExtendClass2 = objPrjTabENEx.objCacheClassifyFld2 != null ? objPrjTabENEx.objCacheClassifyFld2.IsForExtendClass() : false,

                    };
                    objCacheClassify = obj;
                }
                return objCacheClassify;
            }
        }
        public TabProp thisTabProp_TS
        {
            get
            {
                if (objTabProp_TS == null)
                {
                    List<string> arrTemp = new List<string>();
                    foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                    {
                        arrTemp.Add(objInFor.ObjFieldTab().PropertyName_TS(this.IsFstLcase));
                    }
                    string strTemp = clsArray.GetSqlInStrByArray(arrTemp, false);
                    TabProp obj = new TabProp
                    {
                        KeyFldCount = objPrjTabENEx.arrKeyFldSet.Count,
                        FldId = objPrjTabENEx.KeyFldId(),
                        FldName = objPrjTabENEx.KeyFldName(),
                        KeyFldNameLstStr = objPrjTabENEx.KeyFldNameLstStr,
                        KeyVarDefineLstStr = objPrjTabENEx.KeyVarDefineLstStr_TS,
                        KeyPrivVarNameLstStr = objPrjTabENEx.KeyPrivFuncFldNameLstStr_TS,
                        PropertyNameLstrStr = strTemp,
                        ByInFuncName = objPrjTabENEx.arrKeyFldSet.Count == 1 ? objPrjTabENEx.KeyFldName() : "KeyLst",
                    };
                    objTabProp_TS = obj;
                }
                return objTabProp_TS;
            }
        }

        public override string thisPrjId
        {
            get
            {
                return objPrjTabENEx.PrjId;

            }
        }

        public CacheClassify thisCacheClassify_TS
        {
            get
            {
                if (objCacheClassify_TS == null)
                {
                    string ThisClsName = "";
                    CacheClassify obj = new CacheClassify
                    {
                        FldId = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? objPrjTabENEx.ObjCacheClassifyFld_TS.FldId : "",
                        FldId2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? objPrjTabENEx.ObjCacheClassifyFld2_TS.FldId : "",

                        VarDef4Fld = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? string.Format("{0}.{1}Cache", ThisClsName, objPrjTabENEx.ObjCacheClassifyFld_TS.FldName) : "",
                        VarDef4Fld2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? string.Format("{0}.{1}Cache", ThisClsName, objPrjTabENEx.ObjCacheClassifyFld2_TS.FldName) : "",

                        FldName = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? objPrjTabENEx.ObjCacheClassifyFld_TS.FldName : "",
                        FldName2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? objPrjTabENEx.ObjCacheClassifyFld2_TS.FldName : "",
                        PriVarName = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? objPrjTabENEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.PrivFuncName : "",
                        PriVarName2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? objPrjTabENEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.PrivFuncName : "",
                        TypeScriptType = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? objPrjTabENEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "",
                        TypeScriptType2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? objPrjTabENEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType : "",
                        CsType = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? objPrjTabENEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.CsType : "",
                        CsType2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? objPrjTabENEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.objDataTypeAbbrEN.CsType : "",

                        DataTypeId = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? objPrjTabENEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.DataTypeId : "",
                        DataTypeId2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? objPrjTabENEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.DataTypeId : "",
                        FldLength = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? objPrjTabENEx.ObjCacheClassifyFld_TS.ObjFieldTabENEx.FldLength : 0,
                        FldLength2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? objPrjTabENEx.ObjCacheClassifyFld2_TS.ObjFieldTabENEx.FldLength : 0,
                        IsHasCacheClassfyFld = objPrjTabENEx.ObjCacheClassifyFld_TS == null ? false : true,
                        IsHasCacheClassfyFld2 = objPrjTabENEx.ObjCacheClassifyFld2_TS == null ? false : true,
                        IsNumberType = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? objPrjTabENEx.ObjCacheClassifyFld_TS.IsNumberType() : false,
                        IsNumberType2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? objPrjTabENEx.ObjCacheClassifyFld2_TS.IsNumberType() : false,
                        IsForExtendClass = objPrjTabENEx.ObjCacheClassifyFld_TS != null ? objPrjTabENEx.ObjCacheClassifyFld_TS.IsForExtendClass() : false,
                        IsForExtendClass2 = objPrjTabENEx.ObjCacheClassifyFld2_TS != null ? objPrjTabENEx.ObjCacheClassifyFld2_TS.IsForExtendClass() : false,

                    };
                    objCacheClassify_TS = obj;
                }
                return objCacheClassify_TS;
            }
        }

        public string ThisClsName4EN
        {
            get
            {
                return string.Format("cls{0}EN", objPrjTabENEx.TabName);
            }
        }
        public string ThisClsName4StoreEN
        {
            get
            {
                return string.Format("cls{0}", objPrjTabENEx.TabName);
            }
        }
        public string ThisObjName4Cond
        {
            get
            {
                return string.Format("obj{0}Cond", objPrjTabENEx.TabName);
            }
        }
        public string ThisObjName4EN
        {
            get
            {
                return string.Format("obj{0}EN", objPrjTabENEx.TabName);
            }
        }
        public string ThisTabName4GC
        {
            get
            {
                return string.Format("{0}", objPrjTabENEx.TabName);
            }
        }
        public string ThisTabId4GC
        {
            get
            {
                return string.Format("{0}", objPrjTabENEx.TabId);
            }
        }

        public string ThisClsName4ENEx
        {
            get
            {
                return string.Format("cls{0}ENEx", objPrjTabENEx.TabName);
            }
        }
        public string ThisClsName4Bl
        {
            get
            {
                return string.Format("cls{0}BL", objPrjTabENEx.TabName);
            }
        }
        public string ThisClsName4BlEx
        {
            get
            {
                return string.Format("cls{0}BLEx", objPrjTabENEx.TabName);
            }
        }
        public string ThisClsName4DA
        {
            get
            {
                return string.Format("cls{0}DA", objPrjTabENEx.TabName);
            }
        }
        public string ThisClsName4DAEx
        {
            get
            {
                return string.Format("cls{0}DAEx", objPrjTabENEx.TabName);
            }
        }
        public string ThisClsName4WApi
        {
            get
            {
                return string.Format("cls{0}WApi", objPrjTabENEx.TabName);
            }
        }

        public string tabNameHead
        {
            get
            {
                if (strTabNameHead == null)
                {
                    strTabNameHead = string.Format("{0}_", this.objPrjTabENEx.TabName);
                }
                return strTabNameHead;

            }
        }

        public string tabNameHeadEx
        {
            get
            {
                if (strTabNameHeadEx == null)
                {
                    strTabNameHeadEx = string.Format("{0}Ex_", this.objPrjTabENEx.TabName);
                }
                return strTabNameHeadEx;

            }
        }


        public string controllerName
        {
            get
            {
                if (strControllerName == null)
                {
                    strControllerName = string.Format("{0}_Controller", clsString.FstLcaseS(objPrjTabENEx.TabName));
                }
                return strControllerName;

            }
        }

        public string controllerNameEx
        {
            get
            {
                if (strControllerNameEx == null)
                {
                    strControllerNameEx = string.Format("{0}Ex_Controller", clsString.FstLcaseS(objPrjTabENEx.TabName));
                }
                return strControllerNameEx;

            }
        }

        public string constructorName
        {
            get
            {
                if (strConstructorName == null)
                {
                    strConstructorName = string.Format("{0}_ConstructorName", clsString.FstLcaseS(objPrjTabENEx.TabName));
                }
                return strConstructorName;

            }
        }

        public string constructorNameEx
        {
            get
            {
                if (strConstructorNameEx == null)
                {
                    strConstructorNameEx = string.Format("{0}Ex_ConstructorName", clsString.FstLcaseS(objPrjTabENEx.TabName));
                }
                return strConstructorNameEx;

            }
        }

        public clsProjectsENEx objProjectsENEx
        {
            get
            {
                if (mobjProjectsENEx == null)
                {
                    if (objPrjTabENEx != null)
                    {
                        mobjProjectsENEx = objPrjTabENEx.objProjectsEN.CopyToEx();
                        return mobjProjectsENEx;
                    }

                    return null;
                }
                else
                {
                    return mobjProjectsENEx;
                }
            }
            set => mobjProjectsENEx = value;
        }
        public bool GetPrjTabInfo(string strTabId, string strPrjDataBaseId, string strPrjId)
        {
            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(strTabId, strPrjId);
            this.objPrjTabENEx = new clsPrjTabENEx(strTabId);
            clsPrjTabBL.CopyTo(objPrjTabEN, this.objPrjTabENEx);
            this.objPrjTabENEx.IsAppliedInViewList = clsPrjTabBLEx.IsAppiedInViewList(strTabId, strPrjId);
            //this.objPrjTabENEx = new clsPrjTabENEx(strTabId);
            mobjPrjTabENEx.GetObjAllInfoEx();

            this.objPrjTabENEx.PrjDataBaseId = strPrjDataBaseId;

            //clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId(strTabId);
            this.objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            if (this.objFuncModuleEN == null)
            {
                string strMsg = string.Format("表:[{0}({1})]的模块为空,请维护该表的模块。({2})",
                    this.objPrjTabENEx.TabName, this.objPrjTabENEx.TabCnName,
                    clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            clsProjectsEN objProjectsEN = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId);
            this.objProjectsENEx = new clsProjectsENEx();
            clsProjectsBL.CopyTo(objProjectsEN, objProjectsENEx);
            this.objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strFunctionTemplateId = clsPrjFuncTemplateRelaBLEx.getFunctionTemplateIdByPrjId(objPrjTabENEx.PrjId);
            //objPrjTabENEx.FunctionTemplateId = strFunctionTemplateId;
            this.mobjKeyField = objPrjTabENEx.objKeyField0;
            this.mobjNameField = objPrjTabENEx.objNameField;
            this.mobjOrderNumField = objPrjTabENEx.objOrderNumField;
            this.mobjDelSignField = objPrjTabENEx.objDelSignField;
            this.mobjSortField = objPrjTabENEx.objSortField;

            this.GetClsName();
            return true;
        }



        public virtual string GenSQLCode(string strPrjDataBaseId)
        {
            string strResult = "";
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
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

            StringBuilder strCreateTabCode = new StringBuilder();
            string strDatabaseOwner;	//数据库拥有者
            string strFieldCode;
            string strRemark, strRemark0;
            string strFieldName;
            string strFieldType;
            //			string strFieldType0;
            string strIsNullable;		//, strIsNullable0;		// = " null ";
            string strPrimaryKey;		//, strPrimaryKey0;
            string strFieldLength, strFieldLength0;		//字段长度

            ArrayList arrFieldCodes = new ArrayList();

            ///定义类中私有属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetAll)
            {

                ///计算字段名
                strFieldName = objField.ObjFieldTabENEx.FldName;
                ///计算字段类型
                strFieldType = objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///计算字段长度
                strFieldLength0 = objField.ObjFieldTabENEx.FldLength.ToString();
                if (strFieldLength0 == string.Empty)
                    strFieldLength = string.Empty;
                else
                    strFieldLength = "(" + strFieldLength0 + ")";
                //判断该数据类型是否需要长度
                if (clsSqlObject.IsNeedLength(strFieldType) == false)
                {
                    strFieldLength = string.Empty;
                }
                ///计算字段注释(即字段中文名称)
                strRemark0 = objField.ColCaption;
                if (strRemark0 == string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/**" + strRemark0 + " **/";

                ///计算是否可空

                if (objField.IsTabNullable == true)
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                ///计算主键

                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strPrimaryKey = " primary key identity";
                }
                else if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strPrimaryKey = " primary key";
                }
                else
                {
                    strPrimaryKey = "";
                }
                if (strPrimaryKey == "")
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strIsNullable;
                }
                else
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strPrimaryKey;
                }
                arrFieldCodes.Add(strFieldCode);
            }
            string[] sstrFieldCode = (string[])(arrFieldCodes.ToArray(System.Type.GetType("System.String")));
            string strTabBodyCode = string.Join(",\r\r\n", sstrFieldCode);
            //clsProjectsENEx objProjects = new clsProjectsENEx(PrjId, true);

            strDatabaseOwner = objPrjDataBase.DatabaseOwner;
            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }
            strCreateTabCode.AppendFormat("CREATE table [{2}].[{0}] ({1}) \r\r\n", objPrjTabENEx.TabName, strTabBodyCode, strDatabaseOwner);
            strCreateTabCode.Append("ON [PRIMARY] ");
            strCreateTabCode.Append("\r\r\nGO");
            //						Response.Write(strCreateTabCode.ToString());
            return strCreateTabCode.ToString();

        }

        public virtual string GenStoreProcedure_Add(string strPrjDataBaseId)
        {

            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Add ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                //判断该数据类型是否需要长度
                if (clsSqlObject.IsNeedLength(objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1},",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,

                    objField.ObjFieldTabENEx.FldLength);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2}),",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength);

                }
            }
            strCodeForCs.Remove(strCodeForCs.Length - 1, 1);
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            //需要插入表的字段列表
            ArrayList arrFieldListForInsert = new ArrayList();
            //需要插入表的值列表
            ArrayList arrValueListForInsert = new ArrayList();


            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if ((objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY) && (objField.FieldTypeId == enumFieldType.KeyField_02))
                {
                    continue;
                }
                arrFieldListForInsert.Add(objField.ObjFieldTabENEx.FldName);
                arrValueListForInsert.Add("@" + objField.ObjFieldTabENEx.FldName);
            }

            //组织插入记录SQL串
            string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
            string strFieldListCode = string.Join(",", sstrFieldCode);
            string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
            string strValuesListCode = string.Join(",", sstrValuesCode);

            strCodeForCs.AppendFormat("\r\n" + "insert into {0} ",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "({0}) values ({1}) ;", strFieldListCode, strValuesListCode);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Add()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Add";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
                objField.ObjFieldTabENEx.FldName,
                objField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                objField.ObjFieldTabENEx.FldLength);
            }
            //<Parameter name = "@Name" size = "10" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@Sex" size = "2" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@ClgId" size = "2" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@MajorId" size = "4" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            //<Parameter name = "@UserType" size = "10" datatype = "NVarChar" direction = "spParamInput" isNullable = "False" />
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Update()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Update";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
                objField.ObjFieldTabENEx.FldName,
                objField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
                objField.ObjFieldTabENEx.FldLength);
            }

            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Delete()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Delete";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
            objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_Select()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_Select";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public string GenStoreProcedureXmlParameter_SelectOne()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_SelectOne";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
            objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedureXmlParameter_IsExist()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_IsExist";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@{0}\" size = \"{2}\" datatype = \"{1}\" direction = \"spParamInput\" isNullable = \"False\" />",
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
            objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.Append("\r\n" + "<Parameter name = \"@IsExist\" size = \"1\" datatype = \"Char\" direction = \"spParamOutput\" isNullable = \"False\" />");

            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");

            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedureXmlParameter_SelectByCond()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_SelectByCond";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@strCond\" size = \"1000\" datatype = \"VarChar\" direction = \"spParamInput\" isNullable = \"False\" />",
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
            objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public string GenStoreProcedureXmlParameter_SelectTop1ByCond()
        {
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            string strStoreProcedure = objPrjTabENEx.TabName + "_SelectTop1ByCond";
            //strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");

            strCodeForCs.AppendFormat("\r\n" + "<StoredProcedure name = \"{0}\">",
            strStoreProcedure);
            strCodeForCs.AppendFormat("\r\n" + "<Parameters>");

            strCodeForCs.AppendFormat("\r\n" + "<Parameter name = \"@strCond\" size = \"1000\" datatype = \"VarChar\" direction = \"spParamInput\" isNullable = \"False\" />",
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.SqlParaType,
            objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.AppendFormat("\r\n" + "</Parameters>");
            strCodeForCs.AppendFormat("\r\n" + "</StoredProcedure>");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenStoreProcedure_Update(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Update ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //判断该数据类型是否需要长度
                if (clsSqlObject.IsNeedLength(objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
                {

                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1},",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2}),",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                    objField.ObjFieldTabENEx.FldLength);
                }
            }
            strCodeForCs.Remove(strCodeForCs.Length - 1, 1);
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "update {0} set ",
            objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\n" + "{0} = @{0},", objField.ObjFieldTabENEx.FldName);
            }

            strCodeForCs.Remove(strCodeForCs.Length - 1, 1);
            strCodeForCs.AppendFormat("\r\n" + "Where {0} = @{0};", objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public virtual string GenStoreProcedure_Delete(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Delete ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            if (clsSqlObject.IsNeedLength(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2})",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "delete from {0} ",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Where {0} = @{0};", objKeyField.FldName);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public virtual string GenStoreProcedure_Select(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_Select ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            //if (clsSqlObject.IsNeedLength(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName)  ==  false)
            //{
            // strCodeForCs.AppendFormat("\r\n" + "@{0} {1}",
            // objKeyField.FldName,
            // objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            // objKeyField.ObjFieldTabENEx.FldLength);
            //}
            //else
            //{
            // strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2})",
            // objKeyField.FldName,
            // objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
            // objKeyField.ObjFieldTabENEx.FldLength);
            //}

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "Select * from {0} ",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "-- Where {0} = @{0};", objKeyField.FldName);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenStoreProcedure_SelectOne(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectOne ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            if (clsSqlObject.IsNeedLength(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2})",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");

            strCodeForCs.AppendFormat("\r\n" + "Select * from {0} ",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Where {0} = @{0};", objKeyField.FldName);


            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }


        public virtual string GenStoreProcedure_IsExist(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "-- Run Example:");
            strCodeForCs.Append("\r\n" + "-- declare @Exist char(1)");
            strCodeForCs.Append("\r\n" + "-- exec Student_IsExist '1005', @Exist out");
            strCodeForCs.Append("\r\n" + "-- select @Exist;");

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_IsExist ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            if (clsSqlObject.IsNeedLength(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName) == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1},",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "@{0} {1}({2}),",
                objKeyField.FldName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                objKeyField.ObjFieldTabENEx.FldLength);
            }
            strCodeForCs.Append("\r\n" + "@IsExist char(1) out");
            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");
            strCodeForCs.AppendFormat("\r\n" + "if (Exists(select * from {1} Where {0} = @{0}))",
            objKeyField.FldName,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "begin");
            strCodeForCs.Append("\r\n" + "set @IsExist = '1';");
            strCodeForCs.Append("\r\n" + "return 1;");
            strCodeForCs.Append("\r\n" + "end");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "begin");
            strCodeForCs.Append("\r\n" + "set @IsExist = '0'");
            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "end");
            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenStoreProcedure_SelectByCond(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectByCond ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            strCodeForCs.Append("\r\n" + "@strCond varchar(1000)");

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");

            strCodeForCs.Append("\r\n" + "declare @ret int, -- return value of sp call");
            strCodeForCs.Append("\r\n" + "@strSQL		nvarchar(4000)");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");

            strCodeForCs.AppendFormat("\r\n" + "set @strSQL = 'Select * from {0} ';",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + ' Where ';");
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + @strCond;");

            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");
            strCodeForCs.Append("\r\n" + "exec (@strSQL)");

            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenStoreProcedure_SelectTop1ByCond(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
            string strMsg = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的字段数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strMsg = "当前表:" + objPrjTabENEx.TabName + "的关键字的个数为0,无法生成通用逻辑层!";
                return strMsg;
            }
            //clsProjectsENEx objProjects = new clsProjectsENEx(objPrjTabENEx.PrjId, true);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            clsUsersEN objUsers = clsUsersBL.GetObjByUserId(objPrjTabENEx.UserId);
            strCodeForCs.AppendFormat("\r\n" + "-- Author:		<{0},{1}>",
            objUsers.UserId, objUsers.UserName);
            strCodeForCs.AppendFormat("\r\n" + "-- Create date: <{0}>",
            clsDateTime.getTodayStr(1));
            strCodeForCs.Append("\r\n" + "-- Description:	<Description,,>");
            strCodeForCs.Append("\r\n" + "--  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == = ");
            strCodeForCs.AppendFormat("\r\n" + "CREATE PROCEDURE [{0}].{1}_SelectTop1ByCond ",
            objPrjDataBase.DatabaseOwner,
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "-- Add the parameters for the stored procedure here");
            //判断该数据类型是否需要长度
            strCodeForCs.Append("\r\n" + "@strCond varchar(1000)");

            //@AcademyName varchar(30),
            //@Memo varchar(1000)

            strCodeForCs.Append("\r\n" + "AS");
            strCodeForCs.Append("\r\n" + "BEGIN");

            strCodeForCs.Append("\r\n" + "declare @ret int, -- return value of sp call");
            strCodeForCs.Append("\r\n" + "@strSQL		nvarchar(4000)");
            strCodeForCs.Append("\r\n" + "SET NOCOUNT ON;");

            strCodeForCs.AppendFormat("\r\n" + "set @strSQL = 'Select Top 1 * from {0} ';",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + ' Where ';");
            strCodeForCs.Append("\r\n" + "set @strSQL = @strSQL + @strCond;");

            strCodeForCs.Append("\r\n" + "--开始事务处理");
            strCodeForCs.Append("\r\n" + "BEGIN TRANSACTION;");
            strCodeForCs.Append("\r\n" + "exec (@strSQL)");

            strCodeForCs.Append("\r\n" + "IF @@ERROR<>0");
            strCodeForCs.Append("\r\n" + "BEGIN");
            strCodeForCs.Append("\r\n" + "--事务回滚");
            strCodeForCs.Append("\r\n" + "ROLLBACK TRANSACTION ;");
            strCodeForCs.Append("\r\n" + "RETURN -1;");
            strCodeForCs.Append("\r\n" + "END");
            strCodeForCs.Append("\r\n" + "--事务确认");
            strCodeForCs.Append("\r\n" + "COMMIT TRANSACTION;");

            strCodeForCs.Append("\r\n" + "return 0;");
            strCodeForCs.Append("\r\n" + "END");
            //strCodeForCs.Append("\r\n" + "GO");
            return strCodeForCs.ToString();
            //clsSpecSQLforSql objSQL;
            //objSQL = new clsSpecSQLforSql(objProjects.ConnectString); 
            //return objSQL.ExecSql(strSQL.ToString());

        }

        public virtual string GenSQLCode4CreateTab(string strPrjDataBaseId)
        {
            clsPrjDataBaseEN objPrjDataBase = clsPrjDataBaseBL.GetObjByPrjDataBaseIdCache(strPrjDataBaseId);
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

            StringBuilder strCreateTabCode = new StringBuilder();
            string strDatabaseOwner;
            string strFieldCode;
            string strRemark, strRemark0;
            string strFieldName;
            string strFieldType;
            //			string strFieldType0;
            string strIsNullable;		//, strIsNullable0;		// = " null ";
            string strPrimaryKey;		//, strPrimaryKey0;
            string strFieldLength, strFieldLength0;		//字段长度

            ArrayList arrFieldCodes = new ArrayList();

            ///定义类中私有属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSetAll)
            {

                ///计算字段名
                strFieldName = objField.ObjFieldTabENEx.FldName;
                ///计算字段类型
                strFieldType = objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName;
                ///计算字段长度
                strFieldLength0 = objField.ObjFieldTabENEx.FldLength.ToString();
                if (strFieldLength0 == string.Empty)
                    strFieldLength = string.Empty;
                else
                    strFieldLength = "(" + strFieldLength0 + ")";
                //判断该数据类型是否需要长度
                if (clsSqlObject.IsNeedLength(strFieldType) == false)
                {
                    strFieldLength = string.Empty;
                }
                ///计算字段注释(即字段中文名称)
                strRemark0 = objField.ColCaption;
                if (strRemark0 == string.Empty)
                    strRemark = "/**/";
                else
                    strRemark = "/**" + strRemark0 + " **/";

                ///计算是否可空

                if (objField.IsTabNullable == true)
                {
                    strIsNullable = " Null";
                }
                else
                {
                    strIsNullable = " not Null";
                }
                ///计算主键
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strPrimaryKey = " primary key identity";
                }
                else if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    strPrimaryKey = " primary key";
                }
                else
                {
                    strPrimaryKey = "";
                }
                if (strPrimaryKey == "")
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strIsNullable;
                }
                else
                {
                    strFieldCode = "\t" + strRemark + "\r\r\n\t" + strFieldName + " " + strFieldType + strFieldLength + strPrimaryKey;
                }
                arrFieldCodes.Add(strFieldCode);
            }
            string[] sstrFieldCode = (string[])(arrFieldCodes.ToArray(System.Type.GetType("System.String")));
            string strTabBodyCode = string.Join(",\r\r\n", sstrFieldCode);
            //clsProjectsENEx objProjects = new clsProjectsENEx(PrjId, true);

            strDatabaseOwner = objPrjDataBase.DatabaseOwner;
            if (strDatabaseOwner == "")
            {
                strDatabaseOwner = "dbo";
            }

            strCreateTabCode.AppendFormat("CREATE table [{2}].[{0}] ({1}) \r\r\n", objPrjTabENEx.TabName, strTabBodyCode, strDatabaseOwner);
            strCreateTabCode.Append("ON [PRIMARY] ");
            //			strCreateTabCode.Append("\r\r\nGO");
            //						Response.Write(strCreateTabCode.ToString());
            return strCreateTabCode.ToString();

        }

        public string AccessNull(clsPrjTabFldENEx objField)
        {
            string strContent = "";
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte":
                case "byte[]":
                    strContent = string.Format("objDT.Rows[0][con{0}.{1}]", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                default:
                    strContent = string.Format("objDT.Rows[0][con{0}.{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
            }
        }
        public string AccessNull_Static(clsPrjTabFldENEx objField)
        {
            string strContent = "";
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte":
                case "byte[]":
                    strContent = string.Format("objRow[con{0}.{1}]", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull_Static(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                default:
                    if (objField.IsTabNullable == true && objField.IsNumberType() == true)
                    {
                        strContent = string.Format("objRow[con{0}.{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        string strTemp = AccessNull_Static(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                        return string.Format("objRow[con{0}.{1}] == DBNull.Value ? ({3}?)null : {2}", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, strTemp, objField.ObjFieldTab().ObjDataTypeAbbr().CsType);
                    }
                    else if (objField.IsTabNullable == true && objField.CsType == "string")
                    {
                        strContent = string.Format("objRow[con{0}.{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        string strTemp = AccessNull_Static(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                        return string.Format("objRow[con{0}.{1}] == DBNull.Value ? null : {2}", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, strTemp, objField.ObjFieldTab().ObjDataTypeAbbr().CsType);
                    }
                    else
                    {
                        strContent = string.Format("objRow[con{0}.{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        return AccessNull_Static(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);

                    }
            }
        }
        public string AccessNull2(clsPrjTabFldENEx objField)
        {
            string strContent = "";
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte":
                case "byte[]":
                    strContent = string.Format("objRow[con{0}.{1}]", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                default:
                    if (objField.IsTabNullable && objField.IsNumberType() == true)
                    {
                        strContent = string.Format("objRow[con{0}.{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        string strTemp = AccessNull(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                        return string.Format("objRow[con{0}.{1}] == DBNull.Value ? ({3}?)null : {2}", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, strTemp, objField.ObjFieldTab().ObjDataTypeAbbr().CsType);
                    }
                    else if (objField.IsTabNullable && objField.CsType == "string")
                    {
                        strContent = string.Format("objRow[con{0}.{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        string strTemp = AccessNull(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                        return string.Format("objRow[con{0}.{1}] == DBNull.Value ? null : {2}", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, strTemp, objField.ObjFieldTab().ObjDataTypeAbbr().CsType);
                    }
                    else
                    {
                        strContent = string.Format("objRow[con{0}.{1}].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                        return AccessNull(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                    }
            }
        }
        public string AccessNull4WS(clsPrjTabFldENEx objField)
        {
            string strContent = "";
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte":
                case "byte[]":
                    strContent = string.Format("objRow[\"{1}\"]", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull_Sub4WS(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
                default:
                    strContent = string.Format("objRow[\"{1}\"].ToString().Trim()", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    return AccessNull_Sub4WS(strContent, objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.IsTabNullable);
            }
        }




        //拼装关键字的WHERE串
        public string KeyWhereStr()
        {
            bool isNeed_m = true;
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.ObjFieldTabENEx.FldName + " = \" + " + Mark(objField) + "+ " + (isNeed_m == true ? "m" : "") + objField.ObjFieldTabENEx.PrivFuncName + "+" + Mark(objField);
                if (i == 0)	//是否是第一次
                {
                    WhereStr += strTemp;
                }
                else
                {
                    WhereStr += " + \" and " + strTemp;
                }
                i++;
            }

            return WhereStr;
        }

        //拼装关键字的WHERE串
        public string KeyWhereStr(bool isNeed_m)
        {
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.ObjFieldTabENEx.FldName + " = \" + " + Mark(objField) + "+ " + (isNeed_m == true ? "m" : "") + objField.ObjFieldTabENEx.PrivFuncName + "+" + Mark(objField);
                ///'strTemp = objPrjTabENEx.arrKeyFldSet[i].ColumnName + " = \"" + Mark(objPrjTabENEx.arrKeyFldSet[i]) + "+ " + "m" + objField.ObjFieldTabENEx.PrivFuncName + Mark(objPrjTabENEx.arrKeyFldSet[i])
                if (i == 0)	//是否是第一次
                {
                    WhereStr += strTemp;
                }
                else
                {
                    WhereStr += " + \" and " + strTemp;
                }
                i++;
            }

            return WhereStr;
        }


        /// <summary>
        /// 关键字赋值,用于构造函数中关键字赋初值
        /// </summary>
        /// <returns>赋值表达式串</returns>

        //拼装关键字的传值参数串
        public string GetKeyPara()
        {
            string strPara, strTemp;
            int i = 0;
            strPara = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                if (objPrjTabENEx.LangType == clsPubConst.LangType.CSharp)
                {
                    strTemp = objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.SilverLight)
                {
                    strTemp = objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.JAVA)
                {
                    strTemp = objField.JavaType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.Swift)
                {
                    strTemp = string.Format("{0} : {1}",
                         objField.ObjFieldTabENEx.PrivFuncName,
                         objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.Swift3)
                {
                    strTemp = string.Format("{0} : {1}",
                         objField.ObjFieldTabENEx.PrivFuncName,
                         objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.Swift4)
                {
                    strTemp = string.Format("{0} : {1}",
                         objField.ObjFieldTabENEx.PrivFuncName,
                         objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                }
                else if (objPrjTabENEx.LangType == clsPubConst.LangType.JavaScript)
                {
                    strTemp = objField.JavaType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else
                {
                    string strMsg = string.Format("在函数中,没有处理语言类型:[{0}].({1})",
                       objPrjTabENEx.LangType,
                       clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                if (i == 0)		//是否是第一次
                {
                    strPara += strTemp;
                }
                else
                {
                    strPara += " , " + strTemp;
                }
                i++;
            }
            return strPara;
        }

        /// <summary>
        /// 类的私有变量,用于类属性的私有变量
        /// </summary>
        /// <returns></returns>
        public string GenClsPrivateVar()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///定义类中私有属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.DefPrivateProperty(objPrjTabENEx.LangType, objField));
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 类的私有变量,用于类属性的私有变量
        /// </summary>
        /// <returns></returns>
        public string GenClsPrivateVar_Sim()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///定义类中私有属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.DefPrivateProperty_Sim(objPrjTabENEx.LangType, objField));
            }
            //系统字段_修改字段集合串
            clsPrjTabFldENEx objField1 = new clsPrjTabFldENEx();
            objField1.ObjFieldTabENEx.FldName = "sf_UpdFldSetStr";
            objField1.ObjFieldTabENEx.Caption = "系统字段_修改字段集合串";
            objField1.ObjFieldTabENEx.FldLength = 4;
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN = new clsDataTypeAbbrEN().CopyToEx();
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.CsType = "string";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType = "String";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType = "String";

            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr = "str";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName = "str";
            strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.DefPrivateProperty_Sim(objPrjTabENEx.LangType, objField1));

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 类的字段名称常量,用于类属性名称的引用
        /// </summary>
        /// <returns></returns>
        public string GenPropertyNameConst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //定义类中属性名称常量
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.DefPropertyNameConst(objPrjTabENEx.LangType, objField, this.IsFstLcase, clsStackTrace.GetCurrClassFunction()));
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 类的字段名称常量,用于类属性名称的引用
        /// </summary>
        /// <returns></returns>
        public string GenPropertyNameConst4ConstLevel()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //定义类中属性名称常量
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.DefPropertyNameConst4ConstLevel(objPrjTabENEx.LangType, objField));
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 类公开的类属性
        /// </summary>
        /// <returns></returns>
        public string GenClsPropertyV2()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTemp = "";
            ///定义类属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strTemp = clsPrjTabFldBLEx.ToStringV2(objField, this.IsFstLcase, objPrjTabENEx.LangType, objPrjTabENEx.TabName);
                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }
            }

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 类公开的类属性
        /// </summary>
        /// <returns></returns>
        public string GenClsProperty_Sim()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTemp = "";
            ///定义类属性
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strTemp = clsPrjTabFldBLEx.ToString2(objField, objPrjTabENEx.LangType, true);
                strCodeForCs.Append("\r\n" + strTemp);
            }
            clsPrjTabFldENEx objField1 = new clsPrjTabFldENEx();
            objField1.ObjFieldTabENEx.FldName = "sf_UpdFldSetStr";
            objField1.ObjFieldTabENEx.Caption = "系统字段_修改字段集合串";
            objField1.ObjFieldTabENEx.FldLength = 4;
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN = new clsDataTypeAbbrEN().CopyToEx();
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.CsType = "string";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.JavaType = "String";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType = "String";

            objField1.FldOpTypeId = "0001";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeAbbr = "str";
            objField1.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName = "str";
            strCodeForCs.Append("\r\n" + clsPrjTabFldBLEx.ToString2(objField1, objPrjTabENEx.LangType, true));

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 类索引器
        /// </summary>
        /// <returns></returns>
        public string GenClsIndexer()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\npublic static int AttributeCount");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nget");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn _AttributeCount;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            //类索引器,字符串参数
            strCodeForCs.Append("\r\npublic override object this[string strAttributeName]");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nget");
            strCodeForCs.Append("\r\n{");
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strCodeForCs.AppendFormat("\r\nif (strAttributeName  ==  con{0}.{1})",
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PrivPropName);
                    strCodeForCs.Append("\r\n}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\nelse if (strAttributeName  ==  con{0}.{1})",
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PrivPropName);
                    strCodeForCs.Append("\r\n}");
                }
            }
            strCodeForCs.Append("\r\nreturn null;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nset");
            strCodeForCs.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strCodeForCs.AppendFormat("\r\nif (strAttributeName  ==  con{0}.{1})",
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\n{0} = {1};", objField.ObjFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true));
                    strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con{0}.{1});", objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);

                    strCodeForCs.Append("\r\n}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\nelse if (strAttributeName  ==  con{0}.{1})",
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]")
                    {
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n{0} = {1};",
                        objField.ObjFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true));
                        strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con{0}.{1});", objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.FldName);

                    }
                    strCodeForCs.Append("\r\n}");
                }
            }
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");

            //类索引器,整型(INT)序号参数

            strCodeForCs.Append("\r\npublic object this[int intIndex]");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nget");
            strCodeForCs.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strCodeForCs.AppendFormat("\r\nif (con{0}.{1}  ==  _AttributeName[intIndex])",
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PrivPropName);
                    strCodeForCs.Append("\r\n}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\nelse if (con{0}.{1}  ==  _AttributeName[intIndex])",
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\nreturn {0};",
                    objField.ObjFieldTabENEx.PrivPropName);
                    strCodeForCs.Append("\r\n}");
                }
            }
            strCodeForCs.Append("\r\nreturn null;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nset");
            strCodeForCs.Append("\r\n{");
            bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.DataTypeId == "08")
                {
                    continue;
                }
                if (bolIsFirst == true)
                {
                    bolIsFirst = false;
                    strCodeForCs.AppendFormat("\r\nif (con{0}.{1}  ==  _AttributeName[intIndex])",
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\n{0} = {1};",
                               objField.ObjFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true));
                    strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con{0}.{1});", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    strCodeForCs.Append("\r\n}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\nelse if (con{0}.{1}  ==  _AttributeName[intIndex])",
                        objPrjTabENEx.TabName,
                    objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n{");
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]")
                    {
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n{0} = {1};",
                              objField.ObjFieldTabENEx.PrivPropName, AccessNull("value.ToString()", objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true));
                        strCodeForCs.AppendFormat("\r\n AddUpdatedFld(con{0}.{1});", objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);

                    }
                    strCodeForCs.Append("\r\n}");
                }
            }
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// 获取关键字Id(keyId)
        /// </summary>
        /// <returns></returns>
        public string GenGetKeyId()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 获取关键字Id(keyId)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.Append("\r\n public override string _KeyId");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n get");
            strCodeForCs.Append("\r\n {");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\n  return {0};", objKeyField.ObjFieldTabENEx.PrivPropName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n  return {0}.ToString();", objKeyField.ObjFieldTabENEx.PrivPropName);
            }
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 获取名称字段值(NameValue)
        /// </summary>
        /// <returns></returns>
        public string GenGetNameValue()
        {
            if (objPrjTabENEx.objPrjTabFld4NameFld == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 获取名称字段值(NameValue)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.Append("\r\n public override string _NameValue");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n get");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n  return {0};", objPrjTabENEx.objPrjTabFld4NameFld.ObjFieldTabENEx.PrivPropName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成条件实体层构造函数
        /// </summary>
        /// <returns></returns>
        public string GenCondEntityClassConstructor()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 条件实体层构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n  dicFldComparisonOp = new Dictionary<string, string>();");
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成构造函数1
        /// </summary>
        /// <returns></returns>
        public string GenClassConstructor1()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.Append("\r\n mbolIsCheckProperty = false;");
            //strCodeForCs.AppendFormat("\r\n _CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strCodeForCs.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objField.ObjFieldTabENEx.FldName);
            }
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成构造函数2
        /// </summary>
        /// <returns></returns>
        public string GenClassConstructor2()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n/// <param name = \"{0}\">关键字:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivFuncName,
                objKeyField.ColCaption);
            strCodeForCs.Append("\r\npublic " + objPrjTabENEx.ClsName + "(" + GetKeyPara() + ")");
            strCodeForCs.Append("\r\n {");
            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte[]":
                case "byte":
                    break;
                case "string":
                    strCodeForCs.AppendFormat("\r\n" + "{0} = {0}.Replace(\"'\", \"''\");",
                              objKeyField.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.Length > {1})", objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldLength);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"在表:{0}中,关键字长度不正确!\");", objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0})  ==  true)", objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"在表:{0}中,关键字不能为空 或 null!\");", objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckStrSQL_Weak({0});", objKeyField.PrivFuncName);

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "throw new Exception(string.Format(\"在关键字中含有{" + "0" + "},请检查!\", objException.Message));");
                    strCodeForCs.Append("\r\n" + "}");
                    //strCodeForCs.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);

                    break;
                case "bool":
                    break;
                case "int":
                case "short":
                case "Int16":
                case "Int32":
                case "long":
                    strCodeForCs.AppendFormat("\r\n if ({0}  ==  0)", objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n {");
                    strCodeForCs.Append("\r\n throw new Exception(\"关键字不能为0!\");");
                    strCodeForCs.Append("\r\n }");
                    break;
                case "float":
                case "double":
                    break;
                default:
                    break;
            }

            strCodeForCs.Append("\r\n" + GetKeyAssign());
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.Append("\r\n mbolIsCheckProperty = false;");
            //strCodeForCs.AppendFormat("\r\n _CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strCodeForCs.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objField.ObjFieldTabENEx.FldName);
            }
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GenClassConstructor3()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\npublic {0}({1}, bool bolIsGet{2})",
            objPrjTabENEx.ClsName, GetKeyPara(), objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "byte[]":
                case "byte":
                    break;
                case "string":

                    strCodeForCs.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);

                    break;
                case "bool":
                    break;
                case "int":
                case "short":
                case "Int16":
                case "Int32":
                case "long":
                    strCodeForCs.AppendFormat("\r\n if ({0}  ==  0)", objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n {");
                    strCodeForCs.Append("\r\n throw new Exception(\"关键字不能为0!\");");
                    strCodeForCs.Append("\r\n }");
                    break;
                case "float":
                case "double":
                    break;
                default:
                    break;
            }
            strCodeForCs.AppendFormat("\r\n{0}", GetKeyAssign() + ";");
            strCodeForCs.Append("\r\nSetInit();");
            strCodeForCs.Append("\r\n mbolIsCheckProperty = false;");
            strCodeForCs.AppendFormat("\r\nif (bolIsGet{0} == true)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nGet{0}();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n}");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strCodeForCs.AppendFormat("\r\n lstKeyFldNames.Add(\"{0}\");", objField.ObjFieldTabENEx.FldName);
            }
            // strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            return strCodeForCs.ToString();
        }

        public string GenClassConstructorEx2()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\npublic " + ClsNameEx + "(" + GetKeyPara() + ")" + ": base(" + objKeyField.PrivFuncName + ")");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GenClassConstructorEx3()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\npublic {0}({1}, bool bolIsGet{2}) : base({3},bolIsGet{2})",
            ClsNameEx, GetKeyPara(), objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            return strCodeForCs.ToString();
        }

        public string GenSetInit()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 设置类的有些属性初始值");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\nprivate void SetInit()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nmstrModuleName = this.GetType().ToString();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "DateTime")
                {
                    strCodeForCs.AppendFormat("\r\n {0} = System.DateTime.Parse(\"01/01/1900\");	",
                        strPrivPropNameWithObjectName4Get);
                }
            }
            strCodeForCs.Append("\r\n}");
            ///类构造器 ==  ==  == = ;
            return strCodeForCs.ToString();
        }



        public virtual string Gen_GetSpecSQLObj_Obj()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取SQL服务器连接对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>SQL服务器连接对象</returns>");

            strCodeForCs.Append("\r\n public override clsSpecSQLforSql GetSpecSQLObj_Obj() ");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            //strCodeForCs.Append("\r\n //1. 如果当前对象有指定的连接串,就用对象连接串");
            //strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(this.ConnectString_Obj)  ==  false)");
            //strCodeForCs.Append("\r\n {");
            //strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql(this.ConnectString_Obj);");
            //strCodeForCs.Append("\r\n return objSQL;");
            //strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串");
            strCodeForCs.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n //2. 如果类所指定的连接串非空,就用该类所指定的连接串");
            strCodeForCs.Append("\r\n //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串");
            strCodeForCs.AppendFormat("\r\n if (string.IsNullOrEmpty(cls{0}EN._ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql();");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n objSQL = new clsSpecSQLforSql(cls{0}EN._ConnectString);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n");
            ///删除记录 == = ;
            return strCodeForCs.ToString();
        }


        public virtual string Gen_GetSpecSQLObjV5()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取SQL服务器连接对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>SQL服务器连接对象</returns>");

            strCodeForCs.Append("\r\n public static clsSpecSQLforSql GetSpecSQLObj() ");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");

            strCodeForCs.Append("\r\n //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串");
            strCodeForCs.Append("\r\n if (clsSysParaEN.bolIsUseConnectStrName  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n //2. 如果类所指定的连接串非空,就用该类所指定的连接串");
            strCodeForCs.Append("\r\n //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串");
            strCodeForCs.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}EN._ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjSQL = new clsSpecSQLforSql();");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nobjSQL = new clsSpecSQLforSql(cls{0}EN._ConnectString);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nreturn objSQL;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            ///删除记录 == = ;
            return strCodeForCs.ToString();
        }
        public virtual string Gen_GetSpecSQLObj_ObjV5()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取SQL服务器连接对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>SQL服务器连接对象</returns>");

            strCodeForCs.Append("\r\n public clsSpecSQLforSql GetSpecSQLObj_Obj() ");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //1. 如果当前对象有指定的连接串,就用对象连接串");
            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(this.ConnectString_Obj)  ==  false)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql(this.ConnectString_Obj);");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n //2. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串");
            strCodeForCs.Append("\r\n if (clsSysPara.bolIsUseConnectStrName  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysPara.strConnectStrName, true);");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n //3. 如果类所指定的连接串非空,就用该类所指定的连接串");
            strCodeForCs.Append("\r\n //4. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串");
            strCodeForCs.AppendFormat("\r\n if (string.IsNullOrEmpty(cls{0}.ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql();");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n objSQL = new clsSpecSQLforSql(cls{0}.ConnectString);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n");
            ///删除记录 == = ;
            return strCodeForCs.ToString();
        }


        public virtual string Gen_GetSpecSQLObj5()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取SQL服务器连接对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>SQL服务器连接对象</returns>");

            strCodeForCs.Append("\r\n public static clsSpecSQLforSql GetSpecSQLObj() ");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");

            strCodeForCs.Append("\r\n //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串");
            strCodeForCs.Append("\r\n if (clsSysPara.bolIsUseConnectStrName  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysPara.strConnectStrName, true);");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n //2. 如果类所指定的连接串非空,就用该类所指定的连接串");
            strCodeForCs.Append("\r\n //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串");
            strCodeForCs.AppendFormat("\r\nif (string.IsNullOrEmpty(cls{0}.ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjSQL = new clsSpecSQLforSql();");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nobjSQL = new clsSpecSQLforSql(cls{0}.ConnectString);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nreturn objSQL;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            ///删除记录 == = ;
            return strCodeForCs.ToString();
        }
        public virtual string Gen_GetSpecSQLObj_Obj5()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取SQL服务器连接对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>SQL服务器连接对象</returns>");

            strCodeForCs.Append("\r\n public clsSpecSQLforSql GetSpecSQLObj_Obj() ");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //1. 如果当前对象有指定的连接串,就用对象连接串");
            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(this.ConnectString_Obj)  ==  false)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql(this.ConnectString_Obj);");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n //2. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串");
            strCodeForCs.Append("\r\n if (clsSysPara.bolIsUseConnectStrName  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql(clsSysPara.strConnectStrName, true);");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n //3. 如果类所指定的连接串非空,就用该类所指定的连接串");
            strCodeForCs.Append("\r\n //4. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串");
            strCodeForCs.AppendFormat("\r\n if (string.IsNullOrEmpty(cls{0}.ConnectString)  ==  true)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n objSQL = new clsSpecSQLforSql();");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n objSQL = new clsSpecSQLforSql(cls{0}.ConnectString);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n return objSQL;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n");
            ///删除记录 == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenDelRecordWithTransactionBak()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            ///删除记录------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 功能:当前对象所指的记录.(带事务处理)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strCodeForCs.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strCodeForCs.Append("\r\n /// <returns>返回删除是否成功?。</returns>");

            strCodeForCs.Append("\r\npublic bool DelRecord(SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstring strSQL = \"\";");
            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            //			if ( objFKSet.GetDelFKTab !=  \")
            //										 {
            //											 strCodeForCs.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //											 strCodeForCs.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strCodeForCs.Append("\r\n//删除" + objPrjTabENEx.TabName + "本表中与当前对象有关的记录");
            strCodeForCs.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr() + ";");
            strCodeForCs.Append("\r\nreturn objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            ///删除记录 == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenDelRecordWithTransaction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///删除记录------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 功能:删除关键字所指的记录,使用事务");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strCodeForCs.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strCodeForCs.Append("\r\n /// <returns>返回删除是否成功?。</returns>");
            strCodeForCs.AppendFormat("\r\npublic bool DelRecord({0}, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) ",
            objPrjTabENEx.KeyVarDefineLstStr);
            strCodeForCs.Append("\r\n{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }
            strCodeForCs.Append("\r\nstring strSQL = \"\";");
            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            //			if ( objFKSet.GetDelFKTab !=  \")
            //										 {
            //											 strCodeForCs.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //											 strCodeForCs.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab + ";");
            //										 }
            strCodeForCs.Append("\r\n//删除" + objPrjTabENEx.TabName + "本表中与当前对象有关的记录");
            strCodeForCs.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strCodeForCs.Append("\r\nreturn objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            ///删除记录 == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenDelMultiRec()
        {
            string strTemp = "";
            StringBuilder strCodeForCs = new StringBuilder();
            ///删除一些记录------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 功能:同时删除多条记录,删除给定关键字列表的记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"lstKey\">给定的关键字值列表</param>");
                strCodeForCs.Append("\r\n /// <returns>返回删除是否成功?</returns>");
                strTemp = string.Format("public int DelRecKeyLsts(List<string> arrKeyLsts)",
                objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + strTemp);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"lstKey\">给定的关键字值列表</param>");
                strCodeForCs.Append("\r\n /// <returns>返回删除是否成功?</returns>");
                strTemp = string.Format("public int Del{0}(List<string> lstKey)",
                objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + strTemp);
            }
            strCodeForCs.Append("\r\n{");


            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {

                strCodeForCs.Append("\r\nif (arrKeyLsts.Count  == 0) return 0;");

                strCodeForCs.Append("\r\n" + "int intCount = 0;");
                strCodeForCs.Append("\r\nforeach (var strKeyLst in arrKeyLsts)");
                strCodeForCs.Append("\r\n{");
                strCodeForCs.Append("\r\n" + "string[] sstrKey = strKeyLst.Split('|');");
                int intIndex = 0;
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    if (objInFor.IsNumberType())
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(sstrKey[{2}]);", objInFor.CsType, objInFor.PrivFuncName, intIndex);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = sstrKey[{2}];", objInFor.CsType, objInFor.PrivFuncName, intIndex);
                    }
                    intIndex++;
                }

                strCodeForCs.AppendFormat("\r\n int intRecNum  = this.DelRecord({0});", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strCodeForCs.Append("\r\n intCount += intRecNum;");
                strCodeForCs.Append("\r\n}");
                strCodeForCs.Append("\r\n return intCount;");

            }
            else
            {
                strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
                strCodeForCs.Append("\r\n //获取连接对象");
                strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\nstring strSQL;");
                strCodeForCs.Append("\r\nstring strKeyList;");
                strCodeForCs.Append("\r\nif (lstKey.Count  == 0) return 0;");
                strCodeForCs.Append("\r\nstrKeyList = \"\";");
                strCodeForCs.Append("\r\nfor (int i = 0; i<lstKey.Count; i++)");
                strCodeForCs.Append("\r\n{");
                ///				if ( (i == 0) strKeyList +=  "'" + lstKey[i].ToString() + "'";
                ///				else strKeyList +=  ", " + "'" + lstKey[i].ToString() + "'";
                if (objPrjTabENEx.arrKeyFldSet.Count == 0)
                {
                    strCodeForCs.Append("\r\n//你的表" + objPrjTabENEx.TabName + " 中没有关键字,请你设置一个关键字!");
                }
                else
                {
                    strCodeForCs.Append("\r\nif (i == 0) strKeyList = strKeyList + " + Mark(objPrjTabENEx.objKeyField0) + " + lstKey[i].ToString() + " + Mark(objPrjTabENEx.objKeyField0) + ";");
                    strCodeForCs.Append("\r\nelse strKeyList +=  \",\" + " + Mark(objPrjTabENEx.objKeyField0) + " + lstKey[i].ToString() + " + Mark(objPrjTabENEx.objKeyField0) + ";");
                    strCodeForCs.Append("\r\n}");
                }
                strCodeForCs.Append("\r\nstrSQL = \"\";");

                strCodeForCs.Append("\r\n//删除" + objPrjTabENEx.TabName + "本表中与当前对象有关的记录");
                if (objPrjTabENEx.arrKeyFldSet.Count == 0)
                {
                    strCodeForCs.Append("\r\n//你的表" + objPrjTabENEx.TabName + " 中没有关键字,请你设置一个关键字!");
                    strCodeForCs.Append("\r\nreturn false;");
                }
                else
                {
                    strCodeForCs.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + objKeyField.FldName + " in (\" + strKeyList + \")\";");
                    strCodeForCs.Append("\r\nreturn objSQL.ExecSql2(strSQL);");
                }
            }
            strCodeForCs.Append("\r\n}");
            ///删除一些记录 == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenDelRecord()
        {
            string strTemp = "";
            StringBuilder strCodeForCs = new StringBuilder();
            ///删除一条记录-----------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 功能:删除关键字所指定的记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <returns>返回删除的记录数</returns>");
            strCodeForCs.Append("\r\n" + string.Format("public int DelRecord({0}) ", objPrjTabENEx.KeyVarDefineLstStr));
            strCodeForCs.Append("\r\n{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }

            strCodeForCs.Append("\r\n//删除单条记录");
            strCodeForCs.Append("\r\nstring strSQL = \"\";");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			if ( objFKSet.GetDelFKTab !=  \")
            //			{
            //				strCodeForCs.Append("\r\n//删除与" + objPrjTabENEx.TabName + "表有关的外键表中的内容");
            //				strCodeForCs.Append("\r\nstrSQL = " + objFKSet.GetDelFKTab2 + ";");
            //			}
            strTemp = string.Format("//删除{0}本表中与当前对象有关的记录",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + strTemp);
            strCodeForCs.Append("\r\nstrSQL = strSQL + \"Delete from " + objPrjTabENEx.TabName + " where " + KeyWhereStr(false) + ";");
            strCodeForCs.Append("\r\n return objSQL.ExecSql2(strSQL);");
            strCodeForCs.Append("\r\n}");
            ///删除一条记录 == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenDelCondRec()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///删除多条记录,删除带条件的记录------------------;
            strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n");
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 功能:删除满足条件的多条记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">需要删除的记录条件</param>");
            strCodeForCs.Append("\r\n /// <returns>返回删除的记录数。</returns>");
            strCodeForCs.AppendFormat("\r\npublic int Del{0}(string strCondition)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = "Del{0}";//, objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Del{0})\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstring strSQL;");
            strCodeForCs.Append("\r\nif (strCondition  ==  \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn 0;	//表示删除0条记录,实际上是不能该表的所有记录");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nstrSQL = \"Delete from {0} where \" + strCondition ;",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nint intRecoCount = objSQL.ExecSql2(strSQL);");
            strCodeForCs.Append("\r\nreturn intRecoCount;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            ///删除多条记录,删除带条件的记录 == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenDelCondRecWithTransaction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///删除多条记录,删除带条件的记录------------------;
            strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n");
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 功能:删除满足条件的多条记录,同时处理事务");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">需要删除的记录条件</param>");
            strCodeForCs.Append("\r\n /// <param name = \"objSqlConnection\">Sql连接对象</param>");
            strCodeForCs.Append("\r\n /// <param name = \"objSqlTransaction\">Sql事务对象</param>");
            strCodeForCs.Append("\r\n /// <returns>返回是否删除成功。</returns>");
            strCodeForCs.AppendFormat("\r\npublic bool Del{0}WithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = "Del{0}WithTransaction_S";//, objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: Del{0}WithTransaction_S)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstring strSQL;");
            strCodeForCs.Append("\r\nif (strCondition  ==  \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;	//表示删除0条记录,实际上是不能该表的所有记录");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nstrSQL = \"Delete from {0} where \" + strCondition ;",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);");
            strCodeForCs.Append("\r\nreturn bolResult;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            ///删除多条记录,删除带条件的记录 == = ;
            return strCodeForCs.ToString();
        }





        public virtual string GenGetRecValueBySP()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一关键值的记录-----------------------------;
            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 获取当前关键字的记录对象,用对象的形式表示.用存储过程{0}_SelectOne来获取。", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要添加到数据库中的对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <returns>是否成功</returns>");
            strCodeForCs.AppendFormat("\r\npublic bool Get{0}OneBySP(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strCodeForCs.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");

            strCodeForCs.Append("\r\n ArrayList values = new ArrayList()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n " + clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase));
            strCodeForCs.Append("\r\n};");


            strCodeForCs.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectOne\",values);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n {4} = {5}; //{0}(字段类型:{1},字段长度:{2},是否可空:{3})",
                        objField.ColCaption,
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                        objField.ObjFieldTabENEx.FldLength,
                        objField.ObjFieldTabENEx.IsNull,
                         strPrivPropNameWithObjectName,
                          AccessNull(objField));
                }
            }

            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            //获取某一关键值的记录 ==  == = ;
            return strCodeForCs.ToString();
        }


        public virtual string GenGetDataTable()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据表DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTable)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据表DataTable</returns>");
            strCodeForCs.AppendFormat("\r\npublic System.Data.DataTable GetDataTable_{0}(string strCondition)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            strFunctionName = "GetDataTable_{0}";//, objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "在输入条件中含有{0},请检查!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTable_{0})\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");


            //获取某一关键值的记录 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByTabName_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据表DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition, string strTabName)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!(给定表名)";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTable)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = string.Format(\"Select * from {0} where {1}\", strTabName, strCondition);");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");

            //获取某一关键值的记录 ==  == = ;
            return strCodeForCs.ToString();
        }


        public virtual string GenGetDataTable_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition, List<string> lstExclude)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable(string strCondition, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTable)\", objException.Message));",
                   objPrjTabENEx.TabName,
                   objPrjTabENEx.ClsName,
                   "{", "}",
                   strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");


            //获取某一关键值的记录 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByTabName_S_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition, string strTabName, List<string> lstExclude)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable(string strCondition, string strTabName, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTable)\", objException.Message));",
                   objPrjTabENEx.TabName,
                   objPrjTabENEx.ClsName,
                   "{", "}",
                   strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = string.Format(\"Select * from {0} where {1}\", strTabName, strCondition);");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");


            //获取某一关键值的记录 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTable_IsCheckSQLAttack()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时可以决定是否检查SQL攻击");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查Sql攻击</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition, bool bolIsCheckSQLAttack)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable(string strCondition, bool bolIsCheckSQLAttack)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTable)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");

            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByTabName_S_IsCheckSQLAttack()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时可以决定是否检查SQL攻击");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strCodeForCs.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查Sql攻击</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable(string strCondition, string strTabName, bool bolIsCheckSQLAttack)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable(string strCondition, string strTabName, bool bolIsCheckSQLAttack)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTable)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nstrSQL = string.Format(\"Select * from {0} where {1}\", strTabName, strCondition);");

            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");

            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }


        public virtual string Gen_GetDataTable_Top_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"objTopPara\">获取顶部对象列表的参数对象</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据表DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");


            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intTopSize\">顶部记录数</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据表DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, string strOrderBy)");
            strCodeForCs.Append("\r\n{");


            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable_Top", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTable_Top)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}}\", intTopSize, strCondition);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}} order by {{2}}\", intTopSize, strCondition, strOrderBy);",
       objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");


            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }


        public virtual string GenGetDataTableByPager_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageIndex\">页序号</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageSize\">页记录数</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据表DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableByPager", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在分页查询中输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在分页查询中输入条件中含有{{0}},请检查!({1}: GetDataTableByPager)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append(this.GeneSqlStrByPaper());

            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string Gen_GetDataTable_Top_S_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intTopSize\">顶部记录数</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTable_Top)\", objException.Message));",
                   objPrjTabENEx.TabName,
                   objPrjTabENEx.ClsName,
                   "{", "}",
                   strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}}\", intTopSize, strCondition);",
         objPrjTabENEx.TabName, "{", "}");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");

            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string Gen_GetDataTable_Top_S_IsCheckSQLAttack()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取顶部记录数据表,用DataTable表示,同时可以决定是否检查SQL攻击");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intTopSize\">顶部记录数</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查Sql攻击</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, bool bolIsCheckSQLAttack)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTable_Top(string strCondition, bool bolIsCheckSQLAttack)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTable_Top)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}}\", intTopSize, strCondition);",
         objPrjTabENEx.TabName, "{", "}");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");



            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public string GeneSqlStrByPaper()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象");

            strCodeForCs.Append("\r\n" + "int intPos_Dot = strOrderBy.IndexOf('|');");
            strCodeForCs.Append("\r\n" + "if (intPos_Dot > 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var sortInfo = clsSortLinkStrParse.ParseSortString(strOrderBy);");
            strCodeForCs.Append("\r\n" + "if (sortInfo.SortDirection == \"\" || sortInfo.SortField == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw new Exception(string.Format(\"在带有特殊排序分页查询中,strOrderBy:[{0}]格式不正确,请检查!(in {1})\",");
            strCodeForCs.Append("\r\n" + "strOrderBy, clsStackTrace.GetCurrClassFunction()));");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "string strLeftLinkStr = clsSortLinkStrParse.BuildLeftJoinClause(sortInfo.JoinTables, sortInfo.JoinConditions);");

            strCodeForCs.Append("\r\n" + $"strSQL = $\"Select Top {{intPageSize}} {objPrjTabENEx.TabName}.* \" + ");
            strCodeForCs.Append("\r\n" + $"$\"from {objPrjTabENEx.TabName} \" + ");
            strCodeForCs.Append("\r\n" + $"$\"{{strLeftLinkStr}} \" + ");
            strCodeForCs.Append("\r\n" + $"$\"where {{strCondition}} and {objPrjTabENEx.TabName}.{objKeyField.FldName} not in \" + ");
            strCodeForCs.Append("\r\n" + $"$\"(Select top {{intTop_In}} {objPrjTabENEx.TabName}.{objKeyField.FldName} from {objPrjTabENEx.TabName} \" + ");
            strCodeForCs.Append("\r\n" + $"$\"{{strLeftLinkStr}} \" +" );
            strCodeForCs.Append("\r\n" + $"$\" where {{strCondition}} \" + ");
            strCodeForCs.Append("\r\n" + $"$\"order by {{sortInfo.SortField}} {{sortInfo.SortDirection}}) \" + ");
            strCodeForCs.Append("\r\n" + $"$\"order by {{sortInfo.SortField}} {{sortInfo.SortDirection}} \";");
            //                strCodeForCs.AppendFormat("\r\n" + "strSQL = string.Format(\"Select Top {{0}} {0}.* from {0} Left Join {{1}} on {{2}} where {{3}} and {0}.{1} not in (Select top {{5}} {0}.{1} from {0} Left Join {{1}} on {{2}} where {{3}} order by {{4}} {{6}}) order by {{4}} {{6}} \",",
            //    objPrjTabENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);");

            //strCodeForCs.Append("\r\n" + "var IsAscOrDesc = \"Asc\";");
            //strCodeForCs.Append("\r\n" + "if (strOrderBy.IndexOf(\" Asc\", StringComparison.InvariantCultureIgnoreCase) > 0)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "strOrderBy = strOrderBy.Replace(\" Asc\", \"\");");
            //strCodeForCs.Append("\r\n" + "IsAscOrDesc = \"Asc\";");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "else if (strOrderBy.IndexOf(\" Desc\", StringComparison.InvariantCultureIgnoreCase) > 0)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "strOrderBy = strOrderBy.Replace(\" Desc\", \"\");");
            //strCodeForCs.Append("\r\n" + "IsAscOrDesc = \"Desc\";");
            //strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "var arrPart = strOrderBy.Split('|');");
            //strCodeForCs.Append("\r\n" + "if (arrPart.Length != 3)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "throw new Exception(string.Format(\"在带有特殊排序分页查询中,strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})\",");
            //strCodeForCs.Append("\r\n" + "strOrderBy, clsStackTrace.GetCurrClassFunction()));");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "string strTabName = arrPart[0];");
            //strCodeForCs.Append("\r\n" + "string strNewOrderBy = arrPart[1];");
            //strCodeForCs.Append("\r\n" + "string strOnCondition = arrPart[2];");
            //strCodeForCs.Append("\r\n" + "try");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strSQL);");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "catch (Exception objEx)");
            //strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}} and {1} not in (Select top {{2}} {1} from {0} where {{1}}) \", intPageSize, strCondition, intTop_In);",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            //   strSQL = string.Format("Select Top {0} * from {0} where {1} and {0}Id not in (Select top {3} {0}Id from {0} where {1} order by {2}) order by {2}", intPageSize, strCondition, strOrderBy, intTop_In);
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}} and {1} not in (Select top {{3}} {1} from {0} where {{1}} order by {{2}}) order by {{2}} \", intPageSize, strCondition, strOrderBy, intTop_In);",
           objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public virtual string GenGetDataTableByPager_S_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageIndex\">页序号</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageSize\">页记录数</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在分页查询中输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在分页查询中输入条件中含有{{0}},请检查!({1}: GetDataTableByPager)\", objException.Message));",
                   objPrjTabENEx.TabName,
                   objPrjTabENEx.ClsName,
                   "{", "}",
                   strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append(this.GeneSqlStrByPaper());

            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByPager_S_IsCheckSQLAttack()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取分页记录数据表,用DataTable表示,同时可以决定是否检查SQL攻击");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageIndex\">页序号</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intPageSize\">页记录数</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查Sql攻击</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, bool bolIsCheckSQLAttack)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, bool bolIsCheckSQLAttack)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在分页查询中输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在分页查询中输入条件中含有{{0}},请检查!({1}: GetDataTableByPager)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append(this.GeneSqlStrByPaper());

            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByRange_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据表DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableByRange", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTableByRange)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                         "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}} order by {0}3{1}) order by {0}3{1}\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");


            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByRange_S_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum, List<string> lstExclude)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTableByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                    "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}} order by {0}3{1}) order by {0}3{1}\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");


            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByRange_S_IsCheckSQLAttack()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取一定范围的数据表,用DataTable表示,同时可以决定是否检查SQL攻击");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查Sql攻击</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum, bool bolIsCheckSQLAttack)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");


            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataTableByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTableByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");

            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByRangeV_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取当前表视图(View)的一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据表DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableVByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableVByRange", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTableVByRange)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                         "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}} order by {0}3{1}) order by {0}3{1}\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");


            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByRangeV_S_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取当前表视图(View)的一定范围的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableVByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableVByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTableVByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");

            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                    "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}} order by {0}3{1}) order by {0}3{1}\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");



            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableByRangeV_S_IsCheckSQLAttack()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取当前表视图(View)的一定范围的数据表,用DataTable表示,同时可以决定是否检查SQL攻击.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查Sql攻击</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableVByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");


            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableVByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTableVByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                 "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}} order by {0}3{1}) order by {0}3{1}\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");



            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableBySP_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查, 用存储过程来获取。");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据表DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTableByCondBySP(string strCondition)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataTableByCondBySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTableByCondBySP)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strCodeForCs.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strCodeForCs.Append("\r\n ArrayList values = new ArrayList()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n strCondition");
            strCodeForCs.Append("\r\n};");
            strCodeForCs.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectByCond\",values);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetCondRecDataSetBySP_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查, 用存储过程来获取。");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据表DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetByCondBySP(string strCondition)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByCondBySP(string strCondition)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");


            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataSetByCondBySP)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strCodeForCs.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strCodeForCs.Append("\r\n ArrayList values = new ArrayList()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n strCondition");
            strCodeForCs.Append("\r\n};");
            strCodeForCs.AppendFormat("\r\n objDS = objSQL.ExecSPReturnDS(\"{0}_SelectByCond\",values, \"{0}\");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn objDS;");
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetDataSetByCondBySP_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查,用存储过程来获取。");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据集DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetByCondBySP(string strCondition)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByCondBySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataSetByCondBySP)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strCodeForCs.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strCodeForCs.Append("\r\n ArrayList values = new ArrayList()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n strCondition");
            strCodeForCs.Append("\r\n};");
            strCodeForCs.AppendFormat("\r\n objDS = objSQL.ExecSPReturnDS(\"{0}_SelectByCond\",values, \"{0}\");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn objDS;");
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetDataSetByCond_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取当前表的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据集DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSet(string strCondition)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSet(string strCondition)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataSet)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n strSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n return objDS;");
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetTopDataSetByCond_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取当前表的顶部数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"intTopSize\">顶部记录数</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据集DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSet_Top(int intTopSize, string strCondition)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSet_Top(string strCondition)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataSet_Top)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select Top {{0}} * from {0} where {{1}}\", intTopSize, strCondition);",
            objPrjTabENEx.TabName, "{", "}");

            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n return objDS;");
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }


        public virtual string GenGetDataSetByCondByRange_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取一定范围数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据集DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByRange", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataSetByRange)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");

            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                         "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                       objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn objDS;");
            strCodeForCs.Append("\r\n}");

            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetDataSetByCondByRange_S_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取一定范围的数据表,用DataSet表示,同时检查是否含有SQL攻击-弱检查(带排除)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据集DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByRange(string strCondition, List<string> lstExclude, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataSet)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                    "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                   objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn objDS;");
            strCodeForCs.Append("\r\n}");


            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetDataSetByCondByRange_S_IsCheckSQLAttack()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取一定范围的数据表,用DataSet表示,同时可以决定是否检查SQL攻击");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查Sql攻击</param>");
            strCodeForCs.Append("\r\n /// <returns>返回满足条件一定范围的DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetByRange(string strCondition, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataSet)ByRange\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");



            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataSetByRange)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\n System.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from {2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From {2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
               "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                       objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn objDS;");
            strCodeForCs.Append("\r\n}");



            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }


        public virtual string GenGetDataSetByCond_V_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取当前表视图的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据集DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetV(string strCondition)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetV", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataSetV)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n strSQL = \"Select * from v" + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"v{0}\");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n return objDS;");
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataSetByCondByRange_V_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取当前表视图的一定范围数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据集DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetVByRange(string strCondition, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetVByRange", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataSetVByRange)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");

            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                         "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                   objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn objDS;");
            strCodeForCs.Append("\r\n}");

            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetDataSetByCondByRange_V_S_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取当前表视图的一定范围的数据集,用DataSet表示,同时检查是否含有SQL攻击-弱检查(带排除)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据集DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetVByRange(string strCondition, List<string> lstExclude, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetVByRange(string strCondition, List<string> lstExclude, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataSetVByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
                    "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
                       objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn objDS;");
            strCodeForCs.Append("\r\n}");

            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetDataSetByCondByRange_V_S_IsCheckSQLAttack()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取当前表视图的一定范围的数据集,用DataSet表示,同时可以决定是否检查SQL攻击");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"bolIsCheckSQLAttack\">是否检查Sql攻击</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">排序方式</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">范围之最小值</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">范围之最大值</param>");
            strCodeForCs.Append("\r\n /// <returns>返回数据集DataSet</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataSet GetDataSetVByRange(string strCondition, bool bolIsCheckSQLAttack, string strOrderBy, int intMinNum, int intMaxNum)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n     if (intMinNum <=  0)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最小值{{0}}非法,应该不小于0,请检查!(cls{2}DA: Get{2}ByRange)\", intMinNum));",
                "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum > 6553005)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值{{0}}非法,应该不大于6553005(可以用其他条件来限制记录的条数),请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n if (intMaxNum < intMinNum)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n throw new Exception(string.Format(\"在输入范围的最大值[{{0}}]不能小于最小值[{{1}}],非法,请检查!(cls{2}DA: Get{2}ByRange)\", intMaxNum, intMinNum));",
                    "{", "}", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");


            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (bolIsCheckSQLAttack  ==  true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL(strCondition);");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataSetVByRange(string strCondition, bool bolIsCheckSQLAttack, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataSetVByRange)\", objException.Message));",
                       objPrjTabENEx.TabName,
                       objPrjTabENEx.ClsName,
                       "{", "}",
                       strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataSet objDS; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\n if (string.IsNullOrEmpty(strOrderBy) == true)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1);",
               "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n else");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n strSQL = string.Format(\"Select top {{1}} * from v{2} a where {0}3{1} And {{0}} And a.{3} not in (Select Top {{2}} {3} From v{2} Where {{0}} order by {0}3{1})\", strCondition, intMaxNum - intMinNum + 1, intMinNum - 1, strOrderBy);",
                "{", "}", objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n }");

            strCodeForCs.AppendFormat("\r\n objDS = objSQL.GetDataSet(strSQL, \"{0}\");",
           objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n return objDS;");
            strCodeForCs.Append("\r\n}");

            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">给定条件</param>");
            strCodeForCs.Append("\r\n /// <returns>返回对象列表</returns>");
            strCodeForCs.AppendFormat("\r\npublic List<cls{0}EN> GetObjLst(string strCondition)",
                    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n try");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetObjLst", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}:GetObjLst)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\nreturn arrObjLst;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                }
            }
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n catch(Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"在根据条件获取对象列表时,发生:{{0}},请检查!({1}: GetObjLst)\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n	}");


            strCodeForCs.Append("\r\nreturn arrObjLst;");
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetObjLstByTabName()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">给定条件</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strTabName\">表名</param>");
            strCodeForCs.Append("\r\n /// <returns>返回对象列表</returns>");
            strCodeForCs.AppendFormat("\r\npublic List<cls{0}EN> GetObjLstByTabName(string strCondition, string strTabName)",
                    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n try");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetObjLstByTabName", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}:GetObjLstByTabName)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nstrSQL = string.Format(\"Select * from {0} where {1}\", strTabName, strCondition);");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\nreturn arrObjLst;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                }
            }
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n catch(Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"在根据条件获取对象列表时,发生:{{0}},请检查!({1}: GetObjLst)\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n	}");


            strCodeForCs.Append("\r\nreturn arrObjLst;");
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 为字段设置条件字段值
        /// </summary>
        /// <returns></returns>
        public virtual string GenSetCondFldValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                //获取某一条件值的记录集-----------------------------;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// 根据条件获取对象列表-{0}[{1}]", objField.ObjFieldTabENEx.FldCnName, objField.ObjFieldTabENEx.FldName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"strCondValue\">字段条件值</param>");
                strCodeForCs.Append("\r\n /// <param name = \"strComparisonOp\">比较运算符</param>");
                strCodeForCs.Append("\r\n /// <returns>void</returns>");
                strCodeForCs.AppendFormat("\r\npublic void SetCond_{0}(string strCondValue, string strComparisonOp)",
                    objKeyField.FldName,
                    objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\n" + "this.{0} = strCondValue;",
                    objKeyField.FldName);
                strCodeForCs.AppendFormat("\r\n" + "if (dicFldComparisonOp.ContainsKey(con{0}) == false)",
                    objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "dicFldComparisonOp.Add(con{0}, strComparisonOp);",
                    objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "dicFldComparisonOp[con{0}] = strComparisonOp;",
                    objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n}");

            }

            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public string GenCopyObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.AppendFormat("\r\npublic void CopyTo(cls{0}EN obj{0}EN)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2}; //{3}",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
            }
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public string GenCopyObj5()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.AppendFormat("\r\npublic void CopyTo(cls{0} obj{0})", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = {2}; //{3}",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
            }
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }
        public string GenCopyObj_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把同一个类的对象,复制到另一个对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\npublic void CopyTo(cls{0}EN obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //只写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public string GenCopyObjToSimObj_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把同一个类的对象,复制到另一个对象(简单)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\npublic void CopyObjToSimObj(cls{0}EN obj{0}ENS, cls{0}EN_Sim obj{0}ENT)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //只写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.sf_UpdFldSetStr = obj{0}ENS.getsfUpdFldSetStr(); //sf_UpdFldSetStr",
                objPrjTabENEx.TabName);
            }
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public string GenCopyObjFromSimObj_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把同一个类的对象,从简化对象复制到对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源简化对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\npublic void CopyObjFromSimObj(cls{0}EN_Sim obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //只写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }


        public string GenCopyObjFromSimObj4Upd_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把同一个类的对象,从简化对象复制到对象. 专门针对修改记录,即脏字段才复制");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源简化对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">目标对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\npublic void CopyObjFromSimObj4Upd(cls{0}EN_Sim obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n   string strsfUpdFldSetStr = obj{0}ENS.sf_UpdFldSetStr;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');");
            strCodeForCs.Append("\r\n   List<string> arrFldSet = new List<string>(sstrFldSet);");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //只写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (arrFldSet.Contains(con{0}.{1}, new clsStrCompareIgnoreCase())  ==  true)",
                         objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                               objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                    strCodeForCs.Append("\r\n" + "}");

                }
            }
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }


        public string GenCopyObj_S5()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把同一个类的对象,复制到另一个对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}S\">源对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}T\">目标对象</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\npublic void CopyTo(cls{0} obj{0}S, cls{0} obj{0}T)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}T.{1} = obj{0}S.{1}; //{3}",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
            }
            strCodeForCs.Append("\r\n}");
            ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetObjLstBySP()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取对象列表,使用存储过程");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">给定条件</param>");
            strCodeForCs.Append("\r\n /// <returns>返回对象列表</returns>");
            strCodeForCs.AppendFormat("\r\npublic List<cls{0}EN> GetObjLstBySP(string strCondition)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetObjLstBySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}:GetObjLstBySP)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.AppendFormat("\r\nList<cls{0}EN> arrObjLst = new List<cls{0}EN>(); ",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strCodeForCs.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strCodeForCs.Append("\r\n ArrayList values = new ArrayList()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n strCondition");
            strCodeForCs.Append("\r\n};");
            strCodeForCs.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectByCond\",values);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\nreturn arrObjLst;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                   objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                }
            }
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n catch(Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"根据条件获取对象列表时,发生:{{0}},请检查!({1}: GetObjLstBySP)\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n	}");


            strCodeForCs.Append("\r\nreturn arrObjLst;");
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public string GenGetRecValueObjByDataRow()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一关键值的记录-----------------------------;
            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 把DataRow转换成记录对象.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"objRow\">所给的DataRow</param>");
            strCodeForCs.AppendFormat("\r\n /// <returns>记录对象</returns>");

            strCodeForCs.AppendFormat("\r\npublic cls{0}EN GetObjByDataRow(DataRow objRow)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (objRow  ==  null)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn null;");
            strCodeForCs.Append("\r\n}");

            strCodeForCs.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[con{0}.{1}] as byte[]; //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        //strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = objRow[con{0}.{1}] as byte[]; //{2}",
                        // objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    }
                }
            }
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n catch(Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"把DataRow转换成记录对象时,发生:{{0}},请检查!({1}: GetObjByDataRow{0})\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 把DataRowView转换成记录对象.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"objRow\">所给的DataRowView</param>");
            strCodeForCs.AppendFormat("\r\n /// <returns>记录对象</returns>");

            strCodeForCs.AppendFormat("\r\npublic cls{0}EN GetObjByDataRow(DataRowView objRow)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (objRow  ==  null)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn null;");
            strCodeForCs.Append("\r\n}");

            strCodeForCs.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull2(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[con{0}.{1}] as byte[]; //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        //strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = objRow[con{0}.{1}] as byte[]; //{2}",
                        // objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull2(objField) + "; //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    }
                }
            }
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n catch(Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"把DataRowView转换成记录对象时,发生:{{0}},请检查!({1}: GetObjByDataRow)\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n}");

            //获取某一关键值的记录 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetFirstCondRecObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取第一条满足条件的记录,以对象形式表示");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">给定条件</param>");
            strCodeForCs.Append("\r\n /// <returns>返回满足条件的第一个对象</returns>");
            strCodeForCs.AppendFormat("\r\npublic cls{0}EN GetFirstObj(string strCondition)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetFirstObj", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetFirstObj)\", objException.Message));",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName,
                    "{", "}",
                    strErrId);
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nstring strSQL; ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\nreturn null;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nDataRow objRow = objDT.Rows[0];");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append(Gen_4BL_GC_GetObjFromDataRow());
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n catch(Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"在根据条件获取第一个对象时,发生:{{0}},请检查!({1}: GetFirstObj)\", objException.Message));",
        objPrjTabENEx.TabName, objPrjTabENEx.ClsName, "{", "}");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetFirstCondRecObjBySP()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取第一条满足条件的记录,以对象形式表示,用存储过程来获取");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">给定条件</param>");
            strCodeForCs.Append("\r\n /// <returns>返回满足条件的第一个对象</returns>");
            strCodeForCs.AppendFormat("\r\npublic cls{0}EN GetFirstObjBySP(string strCondition)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetFirstObjBySP", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}:GetFirstObjBySP)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);

            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strCodeForCs.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");
            strCodeForCs.Append("\r\n ArrayList values = new ArrayList()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n strCondition");
            strCodeForCs.Append("\r\n};");
            strCodeForCs.AppendFormat("\r\n objDT = objSQL.ExecSpReturnDT(\"{0}_SelectTop1ByCond\",values);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\nreturn null;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nDataRow objRow = objDT.Rows[0];");
            strCodeForCs.Append(Gen_4BL_GC_GetObjFromDataRow());

            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\nreturn obj{0}EN;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string GenGetDataTableT_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///获取某一条件的DataTable,其中的代码转换成相应的名称------------------------;
            if (objPrjTabENEx.IsNeedTransCode)
            {
                strCodeForCs = new StringBuilder();
                strCodeForCs.Append("\r\n");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 功能:获取某一条件的DataTable,其中的代码转换成相应的名称");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
                strCodeForCs.Append("\r\n /// <returns>返回已经转换代码的DataTable</returns>");
                strCodeForCs.AppendFormat("\r\npublic System.Data.DataTable Get{0}T(string strCondition)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n{");
                strCodeForCs.Append("\r\ntry");
                strCodeForCs.Append("\r\n{");
                strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
                strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
                strCodeForCs.Append("\r\n}");
                strCodeForCs.Append("\r\ncatch (Exception objException)");
                strCodeForCs.Append("\r\n{");

                string strFunctionName = string.Format("Get{0}T", objPrjTabENEx.TabName, objKeyField.FldName);
                string strExplanation = "在输入条件中含有{0},请检查!";
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                    objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

                strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}:Get{0}T)\", objException.Message));",
                            objPrjTabENEx.TabName,
                            objPrjTabENEx.ClsName,
                            "{", "}",
                            strErrId);
                strCodeForCs.Append("\r\n}");

                strCodeForCs.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
                strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

                strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
                strCodeForCs.Append("\r\n //获取连接对象");
                strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\nstrSQL.Append(\"Select {0}.* \");", objPrjTabENEx.TabName);
                bool bolIsFirst;
                StringBuilder sbTabName = new StringBuilder();
                StringBuilder sbWhereStr = new StringBuilder();
                StringBuilder sbFldStr = new StringBuilder();
                StringBuilder sbLeftJoinStr = new StringBuilder();
                bool bolIsSelfLink = false;
                bolIsFirst = true;
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.ObjFieldTab4CodeConv() != null)
                    {
                        if (objPrjTabENEx.TabId == objField.ObjFieldTab4CodeConv().CodeTabId)
                        {
                            bolIsSelfLink = true;
                        }
                        else
                        {
                            bolIsSelfLink = false;
                        }
                        if (bolIsFirst)
                        {
                            sbTabName.AppendFormat("\r\nstrSQL.Append(\" from {0}, {1}\");",
                            objPrjTabENEx.TabName,
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbWhereStr.AppendFormat("\r\nstrSQL.Append(\" where {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.CodeTabName, objField.ObjFieldTabENEx.CodeTabCode);
                            bolIsFirst = false;
                        }
                        else
                        {
                            sbTabName.AppendFormat("\r\nstrSQL.Append(\" , {0} \");",
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbWhereStr.AppendFormat("\r\nstrSQL.Append(\" && {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.CodeTabName, objField.ObjFieldTabENEx.CodeTabCode);
                        }
                        if (bolIsSelfLink == true)
                        {
                            sbFldStr.AppendFormat("\r\nstrSQL.Append(\", {0}Self.{1} {2}{3} \");",
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbLeftJoinStr.AppendFormat("\r\nstrSQL.Append(\" left JOIN {2} {2}Self on {0}.{1} = {2}Self.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabCode);
                        }
                        else
                        {
                            sbFldStr.AppendFormat("\r\nstrSQL.Append(\", {0}.{1} {2}{3} \");",
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabName);
                            sbLeftJoinStr.AppendFormat("\r\nstrSQL.Append(\" left JOIN {2} on {0}.{1} = {2}.{3} \");",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.CodeTabName,
                            objField.ObjFieldTabENEx.CodeTabCode);
                        }
                    }
                }

                strCodeForCs.Append(sbFldStr.ToString());
                strCodeForCs.AppendFormat("\r\nstrSQL.Append(\" from {0} \");",
                objPrjTabENEx.TabName);
                strCodeForCs.Append(sbLeftJoinStr.ToString());
                /// strCodeForCs.Append(sbTabName.ToString());
                /// strCodeForCs.Append(sbWhereStr.ToString());
                strCodeForCs.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
                strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
                strCodeForCs.Append("\r\nreturn objDT;");
                strCodeForCs.Append("\r\n}");
                strCodeForCs.Append("\r\n");
            }
            ///获取某一条件的DataTable,其中的代码转换成相应的名称 == = ;
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 从视图(SQL View)中获取信息生成 == >DataTable
        /// </summary>
        /// <returns></returns>
        public virtual string GenGetDataTableV_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///获取某一条件的相关表视图(View)------------------------;
            strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n");
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取当前表的视图(View)数据,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回已经转换代码的DataTable</returns>");
            strCodeForCs.AppendFormat("\r\npublic System.Data.DataTable GetDataTableV(string strCondition)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            string strFunctionName = string.Format("GetDataTableV", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTableV)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);

            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\nstrSQL.Append(\"Select v{0}.* \");", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nstrSQL.Append(\" from v{0} \");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取当前表的视图(View)数据,用DataTable表示,同时检查是否含有SQL攻击-弱检查");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回已经转换代码的DataTable</returns>");
            strCodeForCs.AppendFormat("\r\npublic System.Data.DataTable GetDataTable_{0}V(string strCondition)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");

            strFunctionName = "GetDataTable_{0}V";//, objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "在输入条件中含有{0},请检查!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}: GetDataTable_{0}V)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);

            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\nstrSQL.Append(\"Select v{0}.* \");", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nstrSQL.Append(\" from v{0} \");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");

            //获取某一条件的DataTable,其中的代码转换成相应的名称 == = ;
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 从视图(SQL View)中获取信息生成 == >DataTable
        /// </summary>
        /// <returns></returns>
        public virtual string GenGetDataTableV_S_Exclude()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取当前表的视图(View)数据,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <param name = \"lstExclude\">排除的检查字符串列表</param>");
            strCodeForCs.Append("\r\n /// <returns>返回已经转换代码的DataTable</returns>");
            strCodeForCs.AppendFormat("\r\npublic System.Data.DataTable GetDataTableV(string strCondition, List<string> lstExclude)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("GetDataTableV(string strCondition, List<string> lstExclude)", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}:GetDataTableV)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\nStringBuilder strSQL = new StringBuilder(); ");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\nstrSQL.Append(\"Select v{0}.* \");", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nstrSQL.Append(\" from v{0} \");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nstrSQL.Append(\" where \" + strCondition); ");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL.ToString());");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\n");
            ///获取某一条件的DataTable,其中的代码转换成相应的名称 == = ;
            return strCodeForCs.ToString();
        }


        public virtual string GenGetPrimaryKeyID_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///获取某一条件的关键字列表-----------------------------------------;
            strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 功能:获取某一条件的关键字列表");
            strCodeForCs.Append("\r\n ///		 如果表关键字是多个,则多个关键字之间用\"//\"隔开");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>关键字列表</returns>");
            strCodeForCs.Append("\r\npublic static List<string> GetPrimaryKeyID(string strCondition) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstring strSQL ;");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT ;");
            strCodeForCs.Append("\r\nList<string> arrList = new List<string>();");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\nint iRow, iCol; ");
            strCodeForCs.Append("\r\nstring strKeyValue; ");
            strCodeForCs.AppendFormat("\r\nstrSQL = \"Select {0} from {1} where \" + strCondition;",
            objKeyField.FldName, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n//				clsGeneralTab2. LogErrorS(objException, \"\");");
            strCodeForCs.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfinally");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n//				objDT = null;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\nreturn null;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfor (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstrKeyValue = \"\";");
            strCodeForCs.Append("\r\nfor (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (iCol  ==  0)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstrKeyValue +=  objDT.Rows[iRow][iCol].ToString();");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstrKeyValue +=  \"//\" + objDT.Rows[iRow][iCol].ToString();");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\narrList.Add(strKeyValue);");
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nreturn arrList;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            ///获取某一条件的关键字列表 ==  ==  ==  ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetFileFromTabField()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///上传文件以及下载文件相关代码------------------------------------ ;
            if (objPrjTabENEx.IsHaveImageField == true)
            {
                strCodeForCs = new StringBuilder();
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 功能:从数据库表字段中获取内容,并且存放在文件中。");
                strCodeForCs.Append("\r\n ///		说明:表记录条件为当前对象所对应的记录。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"strDownLoadFileName\">获取内容后,所存了的文件名。</param>");
                strCodeForCs.Append("\r\n /// <returns>如果成功获取就返回TRUE,否则为FALSE</returns>");
                strCodeForCs.Append("\r\npublic bool GetFileFromTabField(string strDownLoadFileName)");
                strCodeForCs.Append("\r\n{");
                strCodeForCs.Append("\r\nSpecData.clsSpecSQLforSql objSQL = new SpecData.clsSpecSQLforSql();");
                strCodeForCs.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\nstring strFldName = \"{0}\";", objPrjTabENEx.ImageFieldName);
                strCodeForCs.Append("\r\nStringBuilder strCondition = new StringBuilder();");
                /// strCodeForCs.Append("\r\nstrCondition.AppendFormat(\"Stdid = '{0}'\", objPrjTabENEx.Stdid);");
                strCodeForCs.Append("\r\nstrCondition.AppendFormat(\" ");
                strCodeForCs.AppendFormat("{0}", objKeyField.FldName);
                strCodeForCs.Append(" = '{0}'\", ");
                strCodeForCs.AppendFormat("{0});", clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase));
                strCodeForCs.Append("\r\nobjSQL.GetFile(strDownLoadFileName,strTabName, strFldName, strCondition.ToString());");
                strCodeForCs.Append("\r\nreturn true;");
                strCodeForCs.Append("\r\n}");
            }
            return strCodeForCs.ToString();
        }

        public virtual string GenStoreFileToTabField()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 功能:存储文件。把文件存储到数据库表字段中。");
            strCodeForCs.Append("\r\n ///		说明:表记录条件为当前对象所对应的记录。");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strUpLoadFileName\">所要存储的文件名</param>");
            strCodeForCs.Append("\r\n /// <returns>如果成功就返回TRUE,否则返回FALSE</returns>");
            strCodeForCs.Append("\r\npublic bool StoreFileToTabField(string strUpLoadFileName)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nstring strTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nstring strFldName = \"{0}\";", objPrjTabENEx.ImageFieldName);
            strCodeForCs.Append("\r\nStringBuilder strCondition = new StringBuilder();");
            strCodeForCs.Append("\r\nstrCondition.AppendFormat(\" ");
            strCodeForCs.AppendFormat("{0}", objKeyField.FldName);
            strCodeForCs.Append(" = '{0}'\", ");
            strCodeForCs.AppendFormat("{0});", clsFieldTabBLEx.PrivPropNameWithObjectName(objPrjTabENEx.objKeyField0, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase));
            strCodeForCs.Append("\r\nSpecData.clsSpecSQLforSql objSQL = new SpecData.clsSpecSQLforSql();");
            strCodeForCs.Append("\r\nobjSQL.StoreFile(strUpLoadFileName,strTabName, strFldName, strCondition.ToString());");
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public virtual string GenShowPic_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 功能:显示图片。显示与关键字相关记录的图片");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"imgPic\">需要显示图片的image控件</param>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">记录关键字的值</param>",
            objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <param name = \"strWebFileDir\">用于WEB显示的文件路径,即URL</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strDownloadFileDir\">用于下载文件时,在WEB服务器上文件的目录</param>");
            strCodeForCs.Append("\r\npublic static void ShowPic(System.Web.UI.WebControls.Image imgPic, ");
            strCodeForCs.AppendFormat("\r\n{0} {1}, ",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\nstring strWebFileDir, ");
            strCodeForCs.Append("\r\nstring strDownloadFileDir)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n");
            strCodeForCs.Append("\r\nimgPic.ImageUrl = \"\";");
            strCodeForCs.AppendFormat("\r\nif (cls{0}BL.IsExist({1}) == true)",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\ncls{0}EN obj{0}EN = new cls{0}EN({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\nobj{0}EN.Get{0}();",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nstring strFileName = obj{0}EN.FileName;",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nif (strFileName != \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstring strDownLoadFileName = strDownloadFileDir + strFileName;");
            strCodeForCs.AppendFormat("\r\nobj{0}EN.GetFileFromTabField(strDownLoadFileName);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nimgPic.ImageUrl = strWebFileDir + strFileName;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            return strCodeForCs.ToString();
        }
        public virtual string GenGetFileFromTabField_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 功能:从数据库表字段中下载文件内容。该函数是静态(static)函数。");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strDownLoadFileName\">返回下载的文件名</param>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">记录关键字的值</param>",
            objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <param name = \"strDownloadFileDir\">用于下载文件时,在WEB服务器上文件的目录</param>");
            strCodeForCs.Append("\r\npublic static bool GetFileFromTabField(ref string strDownLoadFileName, ");
            strCodeForCs.AppendFormat("\r\n{0} {1}, ",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\nstring strDownloadFileDir)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nif (cls{0}BL.IsExist({1}) == true)",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\ncls{0}EN obj{0}EN = new cls{0}EN({1});",
            objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\nobj{0}EN.Get{0}();",
            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nstring strFileName = obj{0}EN.FileName;",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nif (strFileName != \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstrDownLoadFileName = strDownloadFileDir + strFileName;");
            strCodeForCs.AppendFormat("\r\nobj{0}EN.GetFileFromTabField(strDownLoadFileName);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");

            ///上传文件以及下载文件相关代码 ==  ==  == ;
            return strCodeForCs.ToString();
        }
        public virtual string GenGetDataTable_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///获取某一SQL串的DataTable---------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据Sql语句获取DataTable");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strSql\">Sql语句</param>");
            strCodeForCs.Append("\r\n /// <returns>返回用于绑定下拉框的DataTable</returns>");
            strCodeForCs.Append("\r\npublic System.Data.DataTable GetDataTable(string strSql)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT; ");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSql);");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");
            ///获取某一SQL串的DataTable ==  == ;
            return strCodeForCs.ToString();
        }
        public virtual string GenIsExist()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///在数据库中是否存在当前对象-----------------------;
            strCodeForCs.Append("\r\npublic bool IsExist()");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"" + KeyWhereStr() + "))");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            ///在数据库中是否存在当前对象 ==  == ;
            return strCodeForCs.ToString();
        }
        public virtual string GenIsExistBySP()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///在数据库中是否存在当前对象-----------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 判断当前表中是否存在给定关键字值的记录, 用存储过程来获取");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <returns>返回是否存在?</returns>");
            strCodeForCs.AppendFormat("\r\npublic bool IsExistBySP({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strCodeForCs.Append("\r\n{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
            }

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nobjSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;");
            strCodeForCs.Append("\r\n//			 gobjSQL.SPConfigXMLFile = \"..\\\\Parameter.xml\"");

            strCodeForCs.Append("\r\n" + "string strIsExist = \"\";");
            strCodeForCs.Append("\r\n ArrayList values = new ArrayList()");
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strCodeForCs.Append("\r\n" + objField.ObjFieldTabENEx.PrivFuncName + ",");
            }
            strCodeForCs.Append("\r\n" + "strIsExist");
            strCodeForCs.Append("\r\n};");

            strCodeForCs.AppendFormat("\r\n" + "ArrayList arrReturn = objSQL.ExecSpWithOutPut(\"{0}_IsExist\", values);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "if (arrReturn[0].ToString()  ==  \"1\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            ///在数据库中是否存在当前对象 ==  == ;
            return strCodeForCs.ToString();
        }
        public virtual string GenIsExist_S()
        {
            string strTemp = "";
            StringBuilder strCodeForCs = new StringBuilder();
            ///在数据库中是否存在当前对象(共享过程函数)-----------------------;
            ///objField.ObjFieldTabENEx.PrivFuncName;
            int i = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {

                if (i == 0)	//是否是第一次
                {
                    strTemp = objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                else
                {
                    strTemp += ", " + objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType + " " + objField.ObjFieldTabENEx.PrivFuncName;
                }
                i++;
            }
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 判断当前表中是否存在给定关键字值的记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">给定的关键字值</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <returns>返回是否存在?</returns>");

            strCodeForCs.Append("\r\npublic bool IsExist(" + strTemp + ")");
            strCodeForCs.Append("\r\n{");
            if (objPrjTabENEx.arrKeyFldSet.Count == 1)
            {
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                {
                    strCodeForCs.AppendFormat("\r\n" + "CheckPrimaryKey({1});", objPrjTabENEx.TabName, objKeyField.PrivFuncName);
                }
            }
            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"" + KeyWhereStr(false) + "))");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            ///在数据库中是否存在当前对象(共享过程函数) ==  == ;
            return strCodeForCs.ToString();
        }
        public virtual string GenIsExistCondRec_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 功能:判断是否存在某一条件的记录");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>");
            strCodeForCs.Append("\r\npublic bool IsExistCondRec(string strCondition)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n clsCheckSql.CheckStrSQL_Weak(strCondition);");
            strCodeForCs.Append("\r\n strCondition = clsString.RemoveElementValue(strCondition, \"exclude\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("IsExistCondRec", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在输入条件中含有{0},请检查!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\nthrow new Exception(string.Format(\"(errid:{4})在输入条件中含有{{0}},请检查!({1}:IsExistCondRec)\", objException.Message));",
                        objPrjTabENEx.TabName,
                        objPrjTabENEx.ClsName,
                        "{", "}",
                        strErrId);
            strCodeForCs.Append("\r\n}");


            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", strCondition))");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public string GenCheckPropertyBak()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");

            strCodeForCs.Append("\r\npublic bool CheckProperty(ref string strResult)");
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
                if (objField.IsTabNullable == false && objField.ObjFieldTabENEx.IsIdentity == false)
                {
                    strCodeForCs.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        strPrivPropNameWithObjectName4Get);
                    strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"\")",
                        strPrivPropNameWithObjectName4Get);
                    if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                    {
                        strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"0\")",
                            strPrivPropNameWithObjectName4Get);
                    }
                    strCodeForCs.Append(")");
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nstrResult = \"字段[" + objField.ColCaption + "]不能为空(NULL)!\";");
                    strCodeForCs.Append("\r\nreturn false;");
                    strCodeForCs.Append("\r\n}");
                }
            }
            ///检查属性长度代码;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strCodeForCs.AppendFormat("\r\nif (!Object.Equals(null, {0}) && GetStrLen({0}) > {1})",
                        strPrivPropNameWithObjectName4Get,
                         objField.ObjFieldTabENEx.FldLength);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nstrResult = \"字段[" + objField.ColCaption + "]的长度不能超过" + objField.ObjFieldTabENEx.FldLength.ToString().Trim() + "!\";");
                    strCodeForCs.Append("\r\nreturn false;");
                    strCodeForCs.Append("\r\n}");
                }
            }
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            ///检查类中属性是否正确 ==  ==  == = ;
            return strCodeForCs.ToString();
        }


        public string GenCheckUniqueness()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///检查类中某属性(非主键)是否唯一-------------------------------------------;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                if (objField.IsTabUnique == true && objField.FieldTypeId != enumFieldType.KeyField_02)
                {

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// 检查唯一性(Uniqueness)--{0}({1}), 如果不唯一,即存在相同的记录,就返回False",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldName);

                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(主键)</param>",
                    objKeyField.PrivFuncName,
                    objKeyField.ColCaption);
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(要求唯一的字段)</param>",
                    objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                    strCodeForCs.Append("\r\n /// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\npublic bool Check{0}Uniqueness({1} {2}, {3} {4})",
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    strCodeForCs.Append("\r\nsbCondition.AppendFormat(\"" + objKeyField.FldName + " !=  '{0}' and "
                 + objField.ObjFieldTabENEx.FldName + " = '{1}'\", " + objKeyField.PrivFuncName + ", " + objField.ObjFieldTabENEx.PrivFuncName + ");");
                    strCodeForCs.AppendFormat("\r\nif (IsExistCondRec(sbCondition.ToString())  ==  true)",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nreturn false;");
                    strCodeForCs.Append("\r\n}");
                    strCodeForCs.Append("\r\nelse");
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nreturn true;");
                    strCodeForCs.Append("\r\n}");
                    strCodeForCs.Append("\r\n}");

                }
            }
            ///检查类中某属性(非主键)是否唯一 ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strCodeForCs.ToString();
        }

        public string GenCheckUniquenessV2()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///检查类中某属性(非主键)是否唯一-------------------------------------------;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == true && objField.FieldTypeId != enumFieldType.KeyField_02)
                {

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// 检查唯一性(Uniqueness)--{0}({1}), 如果不唯一,即存在相同的记录,就返回False",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldName);

                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(主键)</param>",
                    objKeyField.PrivFuncName,
                    objKeyField.ColCaption);
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(要求唯一的字段)</param>",
                    objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                    strCodeForCs.Append("\r\n /// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\npublic bool Check{0}Uniqueness({1} {2}, {3} {4})",
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strCodeForCs.Append("\r\nsbCondition.AppendFormat(\"" + objKeyField.FldName + " !=  '{0}' and "
                     + objField.ObjFieldTabENEx.FldName + " = '{1}'\", " + objKeyField.PrivFuncName + ", " + objField.ObjFieldTabENEx.PrivFuncName + ");");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\nsbCondition.AppendFormat(\"" + objKeyField.FldName + " !=  {0} and "
                      + objField.ObjFieldTabENEx.FldName + " = '{1}'\", " + objKeyField.PrivFuncName + ", " + objField.ObjFieldTabENEx.PrivFuncName + ");");

                    }
                    strCodeForCs.AppendFormat("\r\nif (IsExistCondRec(sbCondition.ToString())  ==  true)",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nreturn false;");
                    strCodeForCs.Append("\r\n}");
                    strCodeForCs.Append("\r\nelse");
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nreturn true;");
                    strCodeForCs.Append("\r\n}");
                    strCodeForCs.Append("\r\n}");

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// 检查唯一性(Uniqueness)--{0}({1}), 如果不唯一,即存在相同的记录,就返回False",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldName);

                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(要求唯一的字段)</param>",
                    objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                    strCodeForCs.Append("\r\n /// <returns></returns>");
                    strCodeForCs.AppendFormat("\r\npublic bool Check{0}Uniqueness({3} {4})",
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    strCodeForCs.Append("\r\nsbCondition.AppendFormat(\"" + objField.ObjFieldTabENEx.FldName + " = '{0}'\", " + objField.ObjFieldTabENEx.PrivFuncName + ");");
                    strCodeForCs.AppendFormat("\r\nif (IsExistCondRec(sbCondition.ToString())  ==  true)",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nreturn false;");
                    strCodeForCs.Append("\r\n}");
                    strCodeForCs.Append("\r\nelse");
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.Append("\r\nreturn true;");
                    strCodeForCs.Append("\r\n}");
                    strCodeForCs.Append("\r\n}");
                }
            }
            ///检查类中某属性(非主键)是否唯一 ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strCodeForCs.ToString();
        }

        public string GenCheckUniquenessV3()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 检查唯一性(Uniqueness)--{0}({1}), 如果不唯一,即存在相同的记录,就返回False",
                          objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(主键)</param>",
            objKeyField.PrivFuncName,
            objKeyField.ColCaption);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(要求唯一的字段)</param>",
                        objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
            }

            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\npublic bool Check{0}Uniqueness({1} {2} ",
                objPrjTabENEx.TabName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                strCodeForCs.AppendFormat(", {0} {1}",
                      objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                      objField.ObjFieldTabENEx.PrivFuncName);
            }
            strCodeForCs.Append(")");

            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
            {
                strCodeForCs.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  {{0}}\", {1});",
                   objKeyField.FldName,
                   objKeyField.PrivFuncName,
                   "{", "}");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  '{{0}}'\", {1});",
                   objKeyField.FldName,
                   objKeyField.PrivFuncName,
                   "{", "}");
            }
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                strCodeForCs.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", {1});",
                            objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.PrivFuncName,
                            "{", "}");
            }
            strCodeForCs.AppendFormat("\r\nif (IsExistCondRec(sbCondition.ToString())  ==  true)",
                    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");

            //StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// 检查唯一性(Uniqueness)--{0}({1}), 如果不唯一,即存在相同的记录,就返回False",
                          objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(主键)</param>",
            //objKeyField.PrivFuncName,
            //objKeyField.ColCaption);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}(要求唯一的字段)</param>",
                        objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
            }

            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\npublic bool Check{0}Uniqueness(",
                objPrjTabENEx.TabName,
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName);
            bool bolIsFirst = true;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                if (bolIsFirst == true)
                {
                    strCodeForCs.AppendFormat("{0} {1}",
                          objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                          objField.ObjFieldTabENEx.PrivFuncName);
                    bolIsFirst = false;

                }
                else
                {
                    strCodeForCs.AppendFormat(", {0} {1}",
                       objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                       objField.ObjFieldTabENEx.PrivFuncName);
                }
            }
            strCodeForCs.Append(")");

            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
            strCodeForCs.AppendFormat("\r\nsbCondition.AppendFormat(\"1 = 1\");",
               objKeyField.FldName,
               objKeyField.PrivFuncName,
               "{", "}");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                strCodeForCs.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", {1});",
                            objField.ObjFieldTabENEx.FldName,
                            objField.ObjFieldTabENEx.PrivFuncName,
                            "{", "}");
            }
            strCodeForCs.AppendFormat("\r\nif (IsExistCondRec(sbCondition.ToString())  ==  true)",
                    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn true;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");


            ///检查类中某属性(非主键)是否唯一 ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 获取唯一性条件串
        /// </summary>
        /// <returns></returns>
        public string GenGetUniquenessConditionString()
        {
            if (objPrjTabENEx.arrPrjConstraintSet().Count == 0) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            int intVerCount = 1;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = string.Format($"_V{intVerCount}"); intVerCount++;

                var arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId);

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// 获取唯一性条件串(Uniqueness)--{0}({1}),根据唯一约束条件来生成",
                              objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">表对象</param>",
                        objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n /// <returns>返回唯一性条件串</returns>");
                strCodeForCs.Append($"\r\npublic string GetUniCondStr{strVersion}(cls{ThisTabName4GC}EN obj{ThisTabName4GC}EN)");
                strCodeForCs.Append("\r\n{");
                strCodeForCs.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                strCodeForCs.AppendFormat("\r\nsbCondition.AppendFormat(\"1 = 1\");",
                objKeyField.FldName,
                objKeyField.PrivFuncName);
                foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                {
                    //if (objField.IsTabUnique == false || objField.FieldTypeId == enumFieldType.KeyField_02) continue;

                    var objPrjTabFld = objField.ObjPrjTabFld();
                    if (objPrjTabFld != null && objPrjTabFld.IsTabNullable == true)
                    {

                        strCodeForCs.AppendFormat("\r\n " + "if (obj{1}EN.{0} == null)",
                                     objField.ObjFieldTab().PropertyName(this.IsFstLcase),
                                     objPrjTabENEx.TabName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} is null\");",
 objField.ObjFieldTab().PropertyName(this.IsFstLcase),
 objPrjTabENEx.TabName);
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "else");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{2});",
                        objField.ObjFieldTab().FldName,
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTab().PropertyName(this.IsFstLcase));
                        strCodeForCs.Append("\r\n" + "}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{2});",
                                     objField.ObjFieldTab().FldName,
                                     objPrjTabENEx.TabName,
                                     objField.ObjFieldTab().PropertyName(this.IsFstLcase));
                    }
                }

                strCodeForCs.Append("\r\nreturn sbCondition.ToString();");
                strCodeForCs.Append("\r\n}");
            }
            ///检查类中某属性(非主键)是否唯一 ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == ;
            return strCodeForCs.ToString();
        }


        public string GenCheckPropertyNew()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\npublic void CheckPropertyNew(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            string strFunctionName = string.Format("CheckPropertyNew[{2}]",
                objPrjTabENEx.TabName, objKeyField.FldName, this.strDataBaseType);
            string strExplanation = "字段[{1}|{0}]不能为空(NULL)!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strCodeForCs.AppendFormat("\r\n" + "//检查字段不能为空(NULL)");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.IsTabNullable == false && objField.FieldTypeId != "02")
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        continue;
                    }

                    if (objField.FldOpTypeId == "0003")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);
                        //strCodeForCs.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        //    strPrivPropNameWithObjectName4Get);
                        //strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"\")",
                        //    strPrivPropNameWithObjectName4Get );
                        //if (string.IsNullOrEmpty(objField.ObjFieldTabENEx.CodeTabId) != true)
                        //{
                        //    strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"0\")",
                        //         strPrivPropNameWithObjectName4Get );
                        //}
                        //strCodeForCs.Append(")");
                        //strCodeForCs.Append("\r\n{");
                        //strCodeForCs.AppendFormat("\r\n throw new clsDbObjException(\"(errid:{2})字段[{1}|{0}]不能为空(NULL)!(cls{3}DA:CheckPropertyNew)\");",
                        //        objField.ColCaption,
                        //        objPrjTabENEx.TabCnName,
                        //        strErrId,
                        //        objPrjTabENEx.TabName);
                        //strCodeForCs.Append("\r\n}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
                  strPrivPropNameWithObjectName,
                  objField.ObjFieldTabENEx.FldLength,
                  objPrjTabENEx.TabName,
                  objField.ObjFieldTabENEx.FldName);
                        //strCodeForCs.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        //    strPrivPropNameWithObjectName );
                        //strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"\")",
                        //     strPrivPropNameWithObjectName );
                        //if (string.IsNullOrEmpty(objField.ObjFieldTabENEx.CodeTabId) != true)
                        //{
                        //    strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"0\")",
                        //         strPrivPropNameWithObjectName );
                        //}
                        //strCodeForCs.Append(")");
                        //strCodeForCs.Append("\r\n{");
                        //strCodeForCs.AppendFormat("\r\n throw new clsDbObjException(\"(errid:{2})字段[{1}|{0}]不能为空(NULL)!(cls{3}DA:CheckPropertyNew)\");",
                        //            objField.ColCaption,
                        //            objPrjTabENEx.TabCnName,
                        //            strErrId,
                        //            objPrjTabENEx.TabName);
                        //strCodeForCs.Append("\r\n}");
                    }
                }


            }
            //检查属性长度代码;

            strFunctionName = string.Format("CheckPropertyNew0", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "字段[{2}({3})|{0}({4})]的长度不能超过{1}!值:{{0}}";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strCodeForCs.AppendFormat("\r\n" + "//检查字段长度");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                 strPrivPropNameWithObjectName,
                 objField.ObjFieldTabENEx.FldLength,
                 objPrjTabENEx.TabName,
                 objField.ObjFieldTabENEx.FldName);
                        //strCodeForCs.AppendFormat("\r\nif (!Object.Equals(null, {0}) && GetStrLen({0}) > {1})", strPrivPropNameWithObjectName4Get, objField.ObjFieldTabENEx.FldLength);
                        //strCodeForCs.Append("\r\n{");
                        //strCodeForCs.AppendFormat("\r\n throw new clsDbObjException(string.Format(\"(errid:{7})字段[{2}({3})|{0}({4})]的长度不能超过{1}!值:{{0}}(cls{3}DA:CheckPropertyNew)\", obj{3}EN.{4}));",
                        //objField.ColCaption,
                        //objField.ObjFieldTabENEx.FldLength.ToString().Trim(),
                        //objPrjTabENEx.TabCnName,
                        //objPrjTabENEx.TabName,
                        //objField.ObjFieldTabENEx.FldName,
                        //"{", "}",
                        //strErrId);
                        // strCodeForCs.Append("\r\n}");
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                             strPrivPropNameWithObjectName,
                            objField.ObjFieldTabENEx.FldLength,
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName);

                    }
                }
            }

            //检查外键字段长度;

            strFunctionName = string.Format("CheckPropertyNew1", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "字段[{2}|{0}]作为外键字段,长度应该为{1}!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strCodeForCs.AppendFormat("\r\n" + "//检查字段外键固定长度");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.IsTabForeignKey == false) continue;//如果不是外键,就不需要检查
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                }
            }
            //strCodeForCs.AppendFormat("\r\n" + "//检查Sql注入");
            //foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            //{
            //    string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

            //    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
            //        && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
            //        && objField.ObjFieldTabENEx.FldLength > 0)
            //    {

            //        //  strCodeForCs.AppendFormat("\r\n" + "//检查Sql注入");
            //        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckSqlInjection4Field({0}, con{1}.{2});",
            //          strPrivPropNameWithObjectName,
            //          objPrjTabENEx.TabName,
            //          objField.ObjFieldTabENEx.FldName);
            //    }
            //}
            strCodeForCs.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n}");

            ///检查类中属性是否正确-------------------------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\npublic void CheckProperty4Update(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            //检查属性长度代码;
            strFunctionName = string.Format("CheckProperty4Update", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "字段[{2}({3})|{0}({4})]的长度不能超过{1}!值:{{0}}";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strCodeForCs.AppendFormat("\r\n" + "//检查字段长度");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FieldTypeId == enumFieldType.KeyField_02) continue;
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                         strPrivPropNameWithObjectName,
                        objField.ObjFieldTabENEx.FldLength,
                      objPrjTabENEx.TabName,
                      objField.ObjFieldTabENEx.FldName);


                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                         strPrivPropNameWithObjectName,
                        objField.ObjFieldTabENEx.FldLength,
                      objPrjTabENEx.TabName,
                      objField.ObjFieldTabENEx.FldName);

                    }
                }
            }
            ///检查外键字段长度;
            strFunctionName = string.Format("CheckProperty4Update", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "字段[{2}|{0}]作为外键字段,长度应该为{1}!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strCodeForCs.AppendFormat("\r\n" + "//检查外键字段长度");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//只读就不需要检查
                if (objField.IsTabForeignKey == false) continue;//如果不是外键,就不需要检查
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                }
            }
            //strCodeForCs.AppendFormat("\r\n" + "//检查Sql注入");
            //foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            //{
            //    string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

            //    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
            //        && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
            //        && objField.ObjFieldTabENEx.FldLength > 0)
            //    {

            //        //  strCodeForCs.AppendFormat("\r\n" + "//检查Sql注入");
            //        strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckSqlInjection4Field({0}, con{1}.{2});",
            //          strPrivPropNameWithObjectName,
            //          objPrjTabENEx.TabName,
            //          objField.ObjFieldTabENEx.FldName);                    
            //    }
            //}
            strCodeForCs.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n}");

            ///检查类中属性是否正确 ==  ==  == = ;
            return strCodeForCs.ToString();
        }


        public string GenCheckProperty4Condition()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///检查类中属性是否正确-------------------------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\npublic void CheckProperty4Condition(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            //FldOpTypeId:
            //0000	未知	
            //0001	可读写	
            //0002	只读	
            //0003	只写	
            //0004	不可读写	

            //FieldTypeId:
            //01	一般字段	NULL
            //02	关键字段	NULL
            //03	名称字段	NULL
            //04	管理字段	NULL

            ///检查属性长度代码;
            string strFunctionName = string.Format("CheckProperty4Condition", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "字段[{2}({3})|{0}({4})]的长度不能超过{1}!值:{{0}}";
            string strErrId1 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strExplanation = "字段[{2}({3})|{0}({4})]的不能包含【 = 】!值:{{0}}";
            string strErrId2 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strExplanation = "字段[{2}({3})|{0}({4})]的不能包含【 and】!值:{{0}}";
            string strErrId3 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strExplanation = "字段[{2}({3})|{0}({4})]的不能包含【and 】!值:{{0}}";
            string strErrId4 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");
            strCodeForCs.AppendFormat("\r\n" + "//检查字段长度");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {

                    strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                        strPrivPropNameWithObjectName,
                        objField.ObjFieldTabENEx.FldLength,
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "//检查Sql注入");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {

                    //  strCodeForCs.AppendFormat("\r\n" + "//检查Sql注入");
                    strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckSqlInjection4Field({0}, con{1}.{2});",
                      strPrivPropNameWithObjectName,
                      objPrjTabENEx.TabName,
                      objField.ObjFieldTabENEx.FldName);


                }
            }
            strCodeForCs.AppendFormat("\r\n" + "//检查外键字段长度");

            ///检查外键字段长度;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabForeignKey == false) continue;//如果不是外键,就不需要检查
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                     strPrivPropNameWithObjectName,
                     objField.ObjFieldTabENEx.FldLength,
                     objPrjTabENEx.TabName,
                     objField.ObjFieldTabENEx.FldName);

                }
            }
            strCodeForCs.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n}");


            ///检查类中属性是否正确 ==  ==  == = ;
            return strCodeForCs.ToString();
        }



        public virtual string GenCurrTabName_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 当前表名");
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n public override string _CurrTabName");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n get");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n return cls{0}EN._CurrTabName;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n }");

            return strCodeForCs.ToString();
        }

        public virtual string GenGetPrimaryKeyID()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取当前表满足条件的所有记录的关键字值列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回的关键字值列表</returns>");

            strCodeForCs.Append("\r\npublic List<string> GetID(string strCondition) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstring strSQL ;");
            strCodeForCs.Append("\r\n System.Data.DataTable objDT ;");
            strCodeForCs.Append("\r\nList<string> arrList = new List<string>();");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nint iRow, iCol; ");
            strCodeForCs.Append("\r\nstring strKeyValue; ");
            //			strCodeForCs.Append("\r\nif (objSQL.IsExistRecord(\"" + objPrjTabENEx.TabName + "\", \"+ " + KeyWhereStr(true) + "))");
            //			strCodeForCs.Append("\r\nreturn arrList;");
            strCodeForCs.Append("\r\nstrSQL = \"Select " + objPrjTabENEx.Keys + " from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strCodeForCs.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfinally");
            strCodeForCs.Append("\r\n{");
            ///			
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\nreturn null;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfor (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstrKeyValue = \"\";");
            strCodeForCs.Append("\r\nfor (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (iCol  ==  0)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstrKeyValue +=  objDT.Rows[iRow][iCol].ToString();");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstrKeyValue +=  \"//\" + objDT.Rows[iRow][iCol].ToString();");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\narrList.Add(strKeyValue);");
            strCodeForCs.Append("\r\n}");

            strCodeForCs.Append("\r\nreturn arrList;");
            strCodeForCs.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strCodeForCs.ToString();
        }


        public string GenGetMaxStrIdByPrefix()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据前缀获取当前表最大字符型关键字ID");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>返回的最大关键字值ID</returns>");
            strCodeForCs.Append("\r\npublic string GetMaxStrIdByPrefix(string strPrefix)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nclsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n//获取连接对象");
            strCodeForCs.AppendFormat("\r\nobjSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nstring strMaxValue = objSQL.GetMaxStrId(cls{0}EN._CurrTabName, con{0}.{1}, {2}, strPrefix);",
            objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.Append("\r\nreturn strMaxValue;");
            strCodeForCs.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strCodeForCs.ToString();
        }
        public virtual string GenGetMaxStrID()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取当前表最大字符型关键字ID");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>返回的最大关键字值ID</returns>");
            strCodeForCs.Append("\r\npublic static string GetMaxStrId()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nclsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n//获取连接对象");
            strCodeForCs.AppendFormat("\r\nobjSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nstring strMaxValue = objSQL.GetMaxStrId(cls{0}EN._CurrTabName, con{0}.{1}, {2}, \"\");",
            objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.Append("\r\nreturn strMaxValue;");
            strCodeForCs.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strCodeForCs.ToString();
        }

        public virtual string GenIsExistTable()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 检查是否存在当前表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>存在就返回True,否则返回False</returns>");
            strCodeForCs.Append("\r\npublic static bool IsExistTable()");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nclsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n//获取连接对象");
            strCodeForCs.AppendFormat("\r\nobjSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\nbool bolIsExist = objSQL.IsExistTable(\"{0}\");",
                                        objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nreturn bolIsExist;");
            strCodeForCs.Append("\r\n}");

            //strCodeForCs.Append("\r\n /// <summary>");
            //strCodeForCs.Append("\r\n /// 检查是否存在给定表");
            //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.Append("\r\n /// </summary>");
            //strCodeForCs.Append("\r\n /// <param name = \"strTabName\">给定表</param>");
            //strCodeForCs.Append("\r\n /// <returns>存在就返回True,否则返回FalseD</returns>");
            //strCodeForCs.Append("\r\npublic static bool IsExistTable(string strTabName)");
            //strCodeForCs.Append("\r\n{");
            //strCodeForCs.Append("\r\nclsSpecSQLforSql objSQL;");
            //strCodeForCs.Append("\r\n//获取连接对象");
            //strCodeForCs.AppendFormat("\r\nobjSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\nbool bolIsExist = objSQL.IsExistTable(strTabName);",
            //                            objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\nreturn bolIsExist;");
            //strCodeForCs.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public virtual string GenGetFirstID()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取当前表满足条件的第一条记录的关键字值");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");

            strCodeForCs.AppendFormat("\r\npublic {0} GetFirstID(string strCondition) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstring strSQL ;");
            strCodeForCs.Append("\r\n System.Data.DataTable objDT ;");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			strCodeForCs.Append("\r\nint iRow, iCol; ");
            strCodeForCs.Append("\r\nstring strKeyValue; ");
            strCodeForCs.Append("\r\nstrSQL = \"Select " + objPrjTabENEx.Keys + " from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strCodeForCs.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfinally");
            strCodeForCs.Append("\r\n{");
            ///			
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.Append("\r\nreturn \"\";");
            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long" || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
            {
                strCodeForCs.Append("\r\nreturn 0;");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\nreturn " + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";",
                objPrjTabENEx.TabName);
            }
            //strCodeForCs.Append("\r\nreturn " + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";");

            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nstrKeyValue = objDT.Rows[0][0].ToString();");

            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "int":
                    strCodeForCs.Append("\r\n" + "return int.Parse(strKeyValue);");
                    break;
                case "double":
                    strCodeForCs.Append("\r\n" + "return double.Parse(strKeyValue);");
                    break;
                case "DateTime":
                    strCodeForCs.Append("\r\n" + "return DateTime.Parse(strKeyValue);");
                    break;
                case "bool":
                    strCodeForCs.Append("\r\n" + "return bool.Parse(strKeyValue);");
                    break;
                case "float":
                    strCodeForCs.Append("\r\n" + "return float.Parse(strKeyValue);");
                    break;
                case "long":
                    strCodeForCs.Append("\r\n" + "return long.Parse(strKeyValue);");
                    break;
                case "short":
                    strCodeForCs.Append("\r\n" + "return short.Parse(strKeyValue);");
                    break;
                default:
                    strCodeForCs.Append("\r\n" + "return strKeyValue;");
                    break;
            }
            strCodeForCs.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成代码:提供条件,查询关键字,结果有多个关键字,获取其中的第一个,返回类型是根据字段本身的类型
        /// </summary>
        /// <returns></returns>
        public virtual string GenGetFirstID_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            /// GetID(根据条件获取关键字的数组);
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取当前表满足条件的第一条记录的关键字值");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strCondition\">条件串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回的第一条记录的关键字值</returns>");

            strCodeForCs.AppendFormat("\r\npublic {0} GetFirstID_S(string strCondition) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstring strSQL ;");
            strCodeForCs.Append("\r\n System.Data.DataTable objDT ;");
            strCodeForCs.Append("\r\n List<string> arrList = new List<string>();");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //			strCodeForCs.Append("\r\nint iRow, iCol; ");
            strCodeForCs.Append("\r\nstring strKeyValue; ");
            strCodeForCs.Append("\r\nstrSQL = \"Select " + objPrjTabENEx.Keys + " from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\nLogErrorS(objException, \"cls{0}\");",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfinally");
            strCodeForCs.Append("\r\n{");
            ///			
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            strCodeForCs.Append("\r\nif (objDT.Rows.Count  ==  0)");
            strCodeForCs.Append("\r\n{");

            //if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType  ==  "string")
            //{
            // strCodeForCs.Append("\r\nreturn " + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";");
            //}
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.Append("\r\nreturn \"\";");
            }
            else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long" || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
            {
                strCodeForCs.Append("\r\nreturn 0;");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\nreturn new cls{0}DA()." + AccessNull("null", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, true) + ";",
                objPrjTabENEx.TabName);
            }
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nstrKeyValue = objDT.Rows[0][0].ToString();");

            switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
            {
                case "int":
                    strCodeForCs.Append("\r\n" + "return int.Parse(strKeyValue);");
                    break;
                case "double":
                    strCodeForCs.Append("\r\n" + "return double.Parse(strKeyValue);");
                    break;
                case "DateTime":
                    strCodeForCs.Append("\r\n" + "return DateTime.Parse(strKeyValue);");
                    break;
                case "bool":
                    strCodeForCs.Append("\r\n" + "return bool.Parse(strKeyValue);");
                    break;
                case "float":
                    strCodeForCs.Append("\r\n" + "return float.Parse(strKeyValue);");
                    break;
                case "long":
                    strCodeForCs.Append("\r\n" + "return long.Parse(strKeyValue);");
                    break;
                case "short":
                    strCodeForCs.Append("\r\n" + "return short.Parse(strKeyValue);");
                    break;
                default:
                    strCodeForCs.Append("\r\n" + "return strKeyValue;");
                    break;
            }
            strCodeForCs.Append("\r\n}");
            ///GetReader(根据条件获取数据Reader);
            return strCodeForCs.ToString();
        }


        public virtual string GenGetReader()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\npublic System.Data.SqlClient.SqlDataReader GetReader(string strCondition) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstring strSQL ;");
            strCodeForCs.Append("\r\nSystem.Data.SqlClient.SqlDataReader objDR ;");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + string.Format("strSQL = \"Select * from {0} where \" + strCondition;", objPrjTabENEx.TabName));
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjDR = objSQL.GetSqlDataReader(strSQL);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strCodeForCs.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfinally");
            strCodeForCs.Append("\r\n{");
            /// strCodeForCs.Append("\r\nobjDR = null;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nreturn objDR;");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public virtual string GenGetTable()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///GetTable(根据条件获取数据表);
            strCodeForCs.Append("\r\npublic DataTable GetTable(string strCondition) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nstring strSQL ;");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT ;");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\nstrSQL = \"Select * from " + objPrjTabENEx.TabName + " where \" + strCondition;");
            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strCodeForCs.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfinally");
            strCodeForCs.Append("\r\n{");
            /// 
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public virtual string GenGetTableBySQL()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///GetTableBySQL(根据SQL语句获取数据表)----------------------------------;
            strCodeForCs.Append("\r\npublic DataTable GetTableBySQL(string strSQL) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nSystem.Data.DataTable objDT ;");

            strCodeForCs.Append("\r\n clsSpecSQLforSql objSQL;");
            strCodeForCs.Append("\r\n //获取连接对象");
            strCodeForCs.AppendFormat("\r\n objSQL = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\ntry");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nobjDT = objSQL.GetDataTable(strSQL);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\ncatch (Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nclsGeneralTab2. LogErrorS(objException, \"\");");
            strCodeForCs.Append("\r\nthrow new Exception(EXCEPTION_MSG + objException.Message, objException);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nfinally");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nreturn objDT;");
            strCodeForCs.Append("\r\n}");
            ///GetTableBySQL(根据SQL语句获取数据表) ==  ==  == ;
            ///公共过程END ==  ==  == ;
            return strCodeForCs.ToString();
        }

        public string GengetStrLen()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///获取字符串长度,其中汉字为2个字节,英文为1个字节---------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 获取字符串长度,其中汉字为2个字节,英文为1个字节");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"strTemp\">给定的原字符串</param>");
            strCodeForCs.Append("\r\n /// <returns>返回字符串长度</returns>");
            strCodeForCs.Append("\r\npublic static int GetStrLen(string strTemp)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nint len ;");
            strCodeForCs.Append("\r\nbyte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);");
            strCodeForCs.Append("\r\nlen = sarr.Length;//will output as 3+3*2 = 9");
            strCodeForCs.Append("\r\nreturn len;");
            strCodeForCs.Append("\r\n}");
            ///获取字符串长度,其中汉字为2个字节,英文为1个;
            ///私有函数 ==  ==  == ;
            return strCodeForCs.ToString();
        }
        public string GenDispose()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///类中析构函数---------------------------------------;
            strCodeForCs.Append("\r\n public void Dispose()");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n if (mblnDisposed  ==  false)");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n try");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n //Free up the database connection resource by ");
            strCodeForCs.Append("\r\n //calling its Dispose method");
            strCodeForCs.Append("\r\n //mobjConnection.Dispose()");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n finally");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n //Because this Dispose method has done the necessary cleanup,");
            strCodeForCs.Append("\r\n //prevent the Finalize method from being called.");
            strCodeForCs.Append("\r\n GC.SuppressFinalize(this);");
            strCodeForCs.Append("\r\n ");
            strCodeForCs.Append("\r\n //Let our class know that Dispose() has been called");
            strCodeForCs.Append("\r\n mblnDisposed = true;");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n }");
            strCodeForCs.Append("\r\n }");
            ///类中析构函数 ==  ==  == ;
            return strCodeForCs.ToString();
        }
        public string GenLogError()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///获取字符串长度,其中汉字为2个字节,英文为1个字节 == ;
            ///错误日志;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把给定的异常对象存储到日志中去");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"objException\">给定的异常对象</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\nprotected void LogError" + "(Exception objException)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n //Log the error information to the Application Log");
            strCodeForCs.Append("\r\n string strLogMsg ;");
            strCodeForCs.Append("\r\n try");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n ");
            strCodeForCs.Append("\r\n strLogMsg = \"An error occurred in the following module: \"");
            strCodeForCs.Append("\r\n+ mstrModuleName + \"Source: \" + objException.Source \r\n");
            strCodeForCs.Append("\r\n+ \"Message: \" + objException.Message ");
            strCodeForCs.Append("\r\n+ \"Stack Trace: \" + objException.StackTrace \r\n");
            strCodeForCs.Append("\r\n+ \"Target Site: \" + objException.TargetSite.ToString();");
            strCodeForCs.Append("\r\n ");
            strCodeForCs.Append("\r\n //Write error to event log");
            strCodeForCs.Append("\r\nSystem.Diagnostics.EventLog.WriteEntry(mstrModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n catch");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }

        public string GenLogError_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///获取字符串长度,其中汉字为2个字节,英文为1个字节 == ;
            ///错误日志;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把给定的异常对象存储到日志中去(含模块名)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"objException\">给定的异常对象</param>", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"strModuleName\">模块名称</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\nprotected static void LogErrorS" + "(Exception objException, string strModuleName)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n //Log the error information to the Application Log");
            strCodeForCs.Append("\r\n string strLogMsg ;");
            strCodeForCs.Append("\r\n try");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n ");
            strCodeForCs.Append("\r\n strLogMsg = \"An error occurred in the following module: \"");
            strCodeForCs.Append("\r\n+ strModuleName + \"Source: \" + objException.Source \r\n");
            strCodeForCs.Append("\r\n+ \"Message: \" + objException.Message ");
            strCodeForCs.Append("\r\n+ \"Stack Trace: \" + objException.StackTrace \r\n");
            strCodeForCs.Append("\r\n+ \"Target Site: \" + objException.TargetSite.ToString();");
            strCodeForCs.Append("\r\n ");
            strCodeForCs.Append("\r\n //Write error to event log");
            strCodeForCs.Append("\r\nSystem.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n catch");
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public string Gen_ClearUpdateState()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 清除修改状态,即清空存储脏字段信息的HashTable列表.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n" + "public void ClearUpdateState()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "htProperty.Clear();");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public virtual string GenComboBoxBindFunction5()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";

            try
            {
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <returns>返回用于绑定下拉框的DataTable</returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static System.Data.DataTable Get{0}()",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                    strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                    strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						if (objField.DsCondStr.Trim()  ==  "")
                    //						{
                    //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						}
                    //						else
                    //						{
                    //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objField.DsCondStr);
                    //						}

                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

                    strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    strCodeForCs.Append("\r\n" + "return objDT;");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 绑定基于Win的下拉框");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name = \"objComboBox\">需要绑定当前表的下拉框</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源为表的下拉框设置内容");
                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                    strValueFieldName);


                    strCodeForCs.AppendFormat("\r\n" + "cls{0} obj{0};",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "//初始化一个对象列表");
                    strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0} = new cls{0}();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = \"0\";",
                    objPrjTabENEx.TabName, strValueFieldName);

                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"选[{2}]...\";",
              objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0});",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//把DataTable中的所有项均加到对象列表中");
                    strCodeForCs.Append("\r\n" + "foreach(DataRow objRow in objDT.Rows)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0} = new cls{0}();",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = objRow[con{0}.{1}].ToString();",
                    objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}.{1} = objRow[con{0}.{1}].ToString();",
                    objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0});",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//设置下拉框的数据源、以及设置值项、显示项");

                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = con{0}.{1};",
                    objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = con{0}.{1};",
                    objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = {0}List;",
                  objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public virtual string GenComboBoxBindFunction()
        {
            return "";
            //StringBuilder strCodeForCs = new StringBuilder();
            //string strTextFieldName = "";
            //string strValueFieldName = "";

            //try
            //{
            //    //第0步:把控件中下拉框ComboBox转换成ComboBox
            //    foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            //    {
            //        if (objField.FieldTypeId == "02")
            //        {
            //            strValueFieldName = objField.ObjFieldTabENEx.FldName;
            //        }
            //        if (objField.FieldTypeId == "03")
            //        {
            //            strTextFieldName = objField.ObjFieldTabENEx.FldName;
            //        }
            //    }
            //    if (strValueFieldName != "" && strTextFieldName != "")
            //    {
            //        strCodeForCs.Append("\r\n /// <summary>");
            //        strCodeForCs.Append("\r\n /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段");
            //        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //        strCodeForCs.Append("\r\n /// </summary>");
            //        strCodeForCs.Append("\r\n /// <returns>返回用于绑定下拉框的DataTable</returns>");
            //        strCodeForCs.AppendFormat("\r\n" + "public static System.Data.DataTable Get{0}()",
            //        strValueFieldName);
            //        strCodeForCs.Append("\r\n" + "{");
            //        strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
            //        strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
            //        strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
            //        //						if (objField.DsCondStr.Trim()  ==  "")
            //        //						{
            //        //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
            //        //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
            //        //						}
            //        //						else
            //        //						{
            //        //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
            //        //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objField.DsCondStr);
            //        //						}

            //        strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

            //        strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
            //        strCodeForCs.Append("\r\n" + "return objDT;");
            //        strCodeForCs.Append("\r\n" + "}");
            //        strCodeForCs.Append("\r\n /// <summary>");
            //        strCodeForCs.Append("\r\n /// 绑定基于Win的下拉框");
            //        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            //        strCodeForCs.Append("\r\n /// </summary>");
            //        strCodeForCs.Append("\r\n /// <param name = \"objComboBox\">需要绑定当前表的下拉框</param>");
            //        strCodeForCs.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
            //        strValueFieldName);
            //        strCodeForCs.Append("\r\n" + "{");
            //        strCodeForCs.Append("\r\n" + "//为数据源为表的下拉框设置内容");
            //        strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
            //        strValueFieldName);


            //        strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
            //        objPrjTabENEx.TabName);
            //        strCodeForCs.AppendFormat("\r\n" + "//初始化一个对象列表");
            //        strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
            //        objPrjTabENEx.TabName);
            //        strCodeForCs.Append("\r\n" + "//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。");
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
            //        objPrjTabENEx.TabName);
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"0\";",
            //        objPrjTabENEx.TabName, strValueFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"请选择1...\";",
            //        objPrjTabENEx.TabName, strTextFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0}EN);",
            //        objPrjTabENEx.TabName);
            //        strCodeForCs.Append("\r\n" + "//把DataTable中的所有项均加到对象列表中");
            //        strCodeForCs.Append("\r\n" + "foreach(DataRow objRow in objDT.Rows)");
            //        strCodeForCs.Append("\r\n" + "{");
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
            //        objPrjTabENEx.TabName);
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[con{0}.{1}].ToString();",
            //        objPrjTabENEx.TabName, strValueFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = objRow[con{0}.{1}].ToString();",
            //        objPrjTabENEx.TabName, strTextFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "{0}List.Add(obj{0}EN);",
            //        objPrjTabENEx.TabName);
            //        strCodeForCs.Append("\r\n" + "}");
            //        strCodeForCs.Append("\r\n" + "//设置下拉框的数据源、以及设置值项、显示项");

            //        strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = con{0}.{1};",
            //        objPrjTabENEx.TabName, strValueFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = con{0}.{1};",
            //       objPrjTabENEx.TabName, strTextFieldName);
            //        strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = {0}List;",
            //      objPrjTabENEx.TabName);
            //        strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
            //        strCodeForCs.Append("\r\n" + "}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    clsEntityBase.LogErrorS(ex, "");
            //    throw new Exception(ex.Message, ex);
            //}
            //return strCodeForCs.ToString();
        }

        public string GenDdlBindFunction__Java()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            try
            {
                ///生成仅有变量;
                //绑定下拉框的函数 代码;
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    //					strCodeForCs.AppendFormat("\r\n" + "public ResultSet Get{0}()", 
                    //						strValueFieldName);
                    //					strCodeForCs.Append("\r\n" + "{");
                    //					strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                    //					strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //						strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //					//									if (objViewCtlField.DsCondStr.Trim() == "")
                    //					//									{
                    //					//										strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //					//											strValueFieldName, strTextFieldName, objViewCtlField.DsTabName);
                    //					//									}
                    //					//									else
                    //					//									{
                    //					//										strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    //					//											strValueFieldName, strTextFieldName, objViewCtlField.DsTabName, objViewCtlField.DsCondStr);
                    //					//									}
                    //					strCodeForCs.Append("\r\n" + "clsSpecSQL mySql = new clsSpecSQL();");
                    //					strCodeForCs.Append("\r\n" + "ResultSet objRS = mySql.GetResultSet(strSQL);");
                    //					strCodeForCs.Append("\r\n" + "return objRS;");
                    //					strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// 绑定基于Web的下拉框");
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.Append("\r\n" + "/// <param name = \"objDDL\">需要绑定当前表的下拉框</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");

                    strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"选[{0}]...\",\"0\");",
                  objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "ResultSet objRS = Get{0}();",
                    strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = \"{0}\";", strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = \"{0}\";", strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objRS;");
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }

            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }




        /// <summary>
        /// 把表中内容绑定到ListView。
        /// </summary>
        /// <returns></returns>
        public string GenBindListView()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //strCodeForCs.Append("\r\n /1//生成绑定ListView的代码");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:根据界面上查询控件中所设置内容查询表记录,");
                strCodeForCs.Append("\r\n ///			 并显示在ListView中。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public int BindLv_{0}(System.Windows.Forms.ListView lv{0}, string strWhereCond)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(共4步)");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "//	3、设置ListView的列头信息");
                strCodeForCs.Append("\r\n" + "//	4、设置ListView的Item信息。即把所有记录显示在ListView中");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件lblRecCount中。");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "System.Windows.Forms.ListViewItem lvi{0}; ",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "ArrayList arr{0}ObjLst;",
                objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = new cls{0}BL.GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	3、设置ListView的列头信息");
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Clear();//清除原来所有Item",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Clear();//清除原来所有列头信息",
                objPrjTabENEx.TabName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId != "04" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")	//不是管理字段
                    {
                        strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Add(\"{1}\", 100, System.Windows.Forms.HorizontalAlignment.Left);",
                        objPrjTabENEx.TabName, objField.ColCaption);
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.View = System.Windows.Forms.View.Details;",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	4、设置ListView的Item信息。即把所有记录显示在ListView中");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLst)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "lvi{0} = new System.Windows.Forms.ListViewItem();",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Tag = obj{0}EN.{1};",
                objPrjTabENEx.TabName, objKeyField.FldName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Text = obj{0}EN.{1}.ToString();",
                objPrjTabENEx.TabName, objKeyField.FldName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objKeyField.FldId == objField.FldId)
                    {
                        continue;
                    }
                    if (objField.FieldTypeId != "04"
                    && objField.IsTabForeignKey == false
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")
                    {
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1});",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1}.ToString());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        }
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Add(lvi{0});",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//	4、设置记录数的状态,");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件txtRecCount中。");
                strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst.Count;",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 把表中内容绑定到ListView。
        /// </summary>
        /// <returns></returns>
        public string GenBindListView5()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //strCodeForCs.Append("\r\n //1/生成绑定ListView的代码");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:根据界面上查询控件中所设置内容查询表记录,");
                strCodeForCs.Append("\r\n ///			 并显示在ListView中。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public int BindLv_{0}(System.Windows.Forms.ListView lv{0}, string strWhereCond)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(共4步)");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "//	3、设置ListView的列头信息");
                strCodeForCs.Append("\r\n" + "//	4、设置ListView的Item信息。即把所有记录显示在ListView中");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件lblRecCount中。");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "System.Windows.Forms.ListViewItem lvi{0}; ",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "ArrayList arr{0}ObjLst;",
                objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = new cls{0}().GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	3、设置ListView的列头信息");
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Clear();//清除原来所有Item",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Clear();//清除原来所有列头信息",
                objPrjTabENEx.TabName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId != "04" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")	//不是管理字段
                    {
                        strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Add(\"{1}\", 100, System.Windows.Forms.HorizontalAlignment.Left);",
                        objPrjTabENEx.TabName, objField.ColCaption);
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.View = System.Windows.Forms.View.Details;",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	4、设置ListView的Item信息。即把所有记录显示在ListView中");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0} obj{0} in arr{0}ObjLst)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "lvi{0} = new System.Windows.Forms.ListViewItem();",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Tag = obj{0}.{1};",
                objPrjTabENEx.TabName, objKeyField.FldName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Text = obj{0}.{1}.ToString();",
                objPrjTabENEx.TabName, objKeyField.FldName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objKeyField.FldId == objField.FldId)
                    {
                        continue;
                    }
                    if (objField.FieldTypeId != "04"
                    && objField.IsTabForeignKey == false
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")
                    {
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}.{1});",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}.{1}.ToString());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        }
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Add(lvi{0});",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//	4、设置记录数的状态,");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件txtRecCount中。");
                strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst.Count;",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        #region 私有函数
        protected void LogError(Exception objException)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {

                strLogMsg = "An error occurred in the following module: "
              + objPrjTabENEx.ModuleName + "\r\nSource: " + objException.Source
              + "Message: " + objException.Message + "\r\n"
              + "Stack Trace: " + objException.StackTrace

              + "Target Site: " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(objPrjTabENEx.ModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }
        #endregion
        public static void CheckTabNameIsNotNull(string strTabName)
        {
            if (string.IsNullOrEmpty(strTabName) == true)
            {
                string strMsg = string.Format("此处表名不能为空!");
                throw new Exception(strMsg);
            }
        }
        public static clsGeneCodeBase4Tab GetClassByName(string strClassName)
        {
            Type expType = Type.GetType(strClassName);
            if (expType == null)
            {
                string strMsg = string.Format("类型:{0}不存在,请检查!", strClassName);
                throw new Exception(strMsg);
            }
            //使用Type对象也可以实例化一个对象同样调用上面方法
            clsGeneCodeBase4Tab objGeneCodeBase = (clsGeneCodeBase4Tab)Activator.CreateInstance(expType);
            return objGeneCodeBase;
        }


        public static clsGeneCodeBase4Tab GetClassByName(string strClassName, string strTabId, string strPrjDataBaseId, string strPrjId)
        {
            Type expType = Type.GetType(strClassName);
            if (expType == null)
            {
                string strMsg = string.Format("类型:{0}不存在,请检查!", strClassName);
                throw new Exception(strMsg);
            }
            //使用Type对象也可以实例化一个对象同样调用上面方法
            clsGeneCodeBase4Tab objGeneCodeBase = null;
            try
            {
                objGeneCodeBase = (clsGeneCodeBase4Tab)Activator.CreateInstance(expType, strTabId, strPrjDataBaseId, strPrjId);
            }
            catch (Exception objException)
            {
                throw objException;
            }
            return objGeneCodeBase;
        }

        //{
        //    string strMsg = string.Format("在扩展类中没有Override该函数,请注意!({0})", clsStackTrace.GetCurrClassFunction());
        //    throw new Exception(strMsg);
        //}

        //public virtual string A_GenEntityLayerCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        //{
        //    string strMsg = string.Format("在扩展类中没有Override该函数,请注意!({0})", clsStackTrace.GetCurrClassFunction());
        //    throw new Exception(strMsg);   
        //}
        //public virtual string A_GenTableFldConstCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        //{
        //    string strMsg = string.Format("在扩展类中没有Override该函数,请注意!({0})", clsStackTrace.GetCurrClassFunction());
        //    throw new Exception(strMsg);
        //}

        public virtual string A_GenEntityLayerCode_Cond(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("在扩展类中没有Override该函数,请注意!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }

        public virtual string A_GenEntityLayerCodeExBak(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("在扩展类中没有Override该函数,请注意!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }


        public virtual string A_GenEntityLayerCode_Sim(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("在扩展类中没有Override该函数,请注意!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }
        //public virtual string A_GenDALCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        //{
        //    string strMsg = string.Format("在扩展类中没有Override该函数,请注意!({0})", clsStackTrace.GetCurrClassFunction());
        //    throw new Exception(strMsg);
        //}
        public virtual string A_GenDALExCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("在扩展类中没有Override该函数,请注意!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }

        public virtual string A_GenDALCode_Java(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("在扩展类中没有Override该函数,请注意!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }
        public virtual string A_GenGeneralLogicCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("在扩展类中没有Override该函数,请注意!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }
        public virtual string A_GenGeneralExLogicCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strMsg = string.Format("在扩展类中没有Override该函数,请注意!({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }



        public string GenClassConstructor2_Java()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n/// <param name = \"{0}\">关键字:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strCodeForCs.AppendFormat("\r\npublic {0}({1})",
                objPrjTabENEx.ClsName,
                 GetKeyPara());
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n hmProperty = new HashMap<String, String>();");
            string strTemp = GetKeyAssign();
            if (string.IsNullOrEmpty(strTemp) == false)
            {
                strCodeForCs.AppendFormat("\r\n {0}", strTemp);
            }
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        public string GenClassConstructor2_JavaScript()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n/// <param name = \"{0}\">关键字:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strCodeForCs.AppendFormat("\r\npublic {0}({1})",
                objPrjTabENEx.ClsName,
                 GetKeyPara());
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n hmProperty = new Dictionary();");
            strCodeForCs.Append("\r\n" + GetKeyAssign() + ";");
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GenClassConstructor2_TypeScript()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n/// <param name = \"{0}\">关键字:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strCodeForCs.AppendFormat("\r\npublic constructor({0}: {1})",
                objKeyField.ObjFieldTabENEx.PrivPropName, objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1} || {2};",
                               this.objKeyField.FldName,
                               this.objKeyField.PrivFuncName,
                                (this.objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true ? "\"\"" : "0")
               );
            strCodeForCs.Append("\r\n hmProperty = new Dictionary();");
            strCodeForCs.Append("\r\n" + GetKeyAssign() + ";");
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        public string GenClassConstructor2_Swift()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n/// <param name = \"{0}\">关键字:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strCodeForCs.AppendFormat("\r\n init({1})",
                objPrjTabENEx.ClsName,
                 GetKeyPara());
            strCodeForCs.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strCodeForCs.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }

            strCodeForCs.Append("\r\n super.init();");
            strCodeForCs.Append("\r\n hmProperty = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n" + GetKeyAssign_Swift());
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GenClassConstructor2_Swift3()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n/// <param name = \"{0}\">关键字:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strCodeForCs.AppendFormat("\r\n init({1})",
                objPrjTabENEx.ClsName,
                 GetKeyPara());
            strCodeForCs.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strCodeForCs.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }

            strCodeForCs.Append("\r\n super.init();");
            strCodeForCs.Append("\r\n hmProperty = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n" + GetKeyAssign_Swift());
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        public string GenClassConstructor2_Swift4()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n/// <param name = \"{0}\">关键字:{1}</param>",
                objKeyField.ObjFieldTabENEx.PrivPropName,
                objKeyField.ColCaption);
            strCodeForCs.AppendFormat("\r\n init({1})",
                objPrjTabENEx.ClsName,
                 GetKeyPara());
            strCodeForCs.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strCodeForCs.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }

            strCodeForCs.Append("\r\n super.init();");
            strCodeForCs.Append("\r\n hmProperty = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n" + GetKeyAssign_Swift());
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);
            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GetKeyAssignBak()
        {
            string strPara, strTemp;
            strPara = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.ObjFieldTabENEx.PrivPropName + " = " + objField.ObjFieldTabENEx.PrivFuncName + ";";
                strPara += "\r\n" + strTemp;
            }
            return strPara;
        }
        public string GetKeyAssign()
        {
            string strPara, strTemp;
            strPara = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = string.Format("this.{0} = {1};",
                    objField.ObjFieldTabENEx.PrivPropName,
                     objField.ObjFieldTabENEx.PrivFuncName);
                strPara += "\r\n" + strTemp;
            }
            return strPara;
        }

        public string GetKeyAssign_Swift()
        {
            string strPara, strTemp;
            strPara = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = string.Format("self.{0} = {1};",
                    objField.ObjFieldTabENEx.PrivPropName,
                     objField.ObjFieldTabENEx.PrivFuncName);
                strPara += "\r\n" + strTemp;
            }
            return strPara;
        }
        public string GenClassConstructor1_Java()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;            
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n public {0}()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n hmProperty = new HashMap<String, String>();");
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        public string GenClassConstructor1_JavaScript()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;            
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n this.init = function()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            strCodeForCs.Append("\r\n this.hmProperty = new Dictionary();");
            strCodeForCs.Append("\r\n this.SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strCodeForCs.Append("\r\n };");
            return strCodeForCs.ToString();
        }
        public string GenClassConstructor1_Swift()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;            
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n override init()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strCodeForCs.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }

            strCodeForCs.Append("\r\n super.init();");
            strCodeForCs.Append("\r\n hmProperty = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GenClassConstructor1_Swift3()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;            
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n override init()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strCodeForCs.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }

            strCodeForCs.Append("\r\n super.init();");
            strCodeForCs.Append("\r\n hmProperty = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        public string GenClassConstructor1_Swift4()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;            
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n override init()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strCodeForCs.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);

            }

            strCodeForCs.Append("\r\n super.init();");
            strCodeForCs.Append("\r\n hmProperty = Dictionary<String, String>();");
            strCodeForCs.Append("\r\n SetInit();");
            strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string GenClassConstructor1_Swift4_Sim()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///类构造器----------------------------------------------;            
            strCodeForCs.Append("\r\n/// <summary>");
            strCodeForCs.Append("\r\n/// 构造函数");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n/// </summary>");
            strCodeForCs.AppendFormat("\r\n init()",
                objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n {");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strInitValue = objField.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(objPrjTabENEx.ProgLangTypeId());
                strCodeForCs.AppendFormat("\r\n" + "self.{0} = {2}; //{1}",
                       objField.ObjFieldTabENEx.PrivPropName,
                       objField.ColCaption, strInitValue);
            }

            strCodeForCs.AppendFormat("\r\n" + "self.sf_UpdFldSetStr = \"\";     //修改字符标志串");

            //strCodeForCs.Append("\r\n super.init();");
            //strCodeForCs.Append("\r\n hmProperty = Dictionary<String, String>();");
            //strCodeForCs.Append("\r\n SetInit();");
            //strCodeForCs.AppendFormat("\r\n CurrTabName = \"{0}\";", objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n KeyFldName = \"{0}\";", objKeyField.FldName);

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 检查表关键字是否合法,是否含有SQL注入
        /// </summary>
        /// <param name = "strWordTypeId">关键字</param>
        /// <returns>是否检查成功</returns>
        public string GenCheckPrimaryKey()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///检查表关键字是否合法,是否含有SQL注入.-----------------------------;
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 检查表关键字是否合法,是否含有SQL注入");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">关键字</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <returns>是否检查成功</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public bool CheckPrimaryKey(string {0})", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0} = {0}.Replace(\"'\", \"''\");",
                objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.Length > {1})", objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.Append("\r\n" + "{");

            string strFunctionName = string.Format("CheckPrimaryKey", objKeyField.PrivFuncName, objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在表:{0}中,检查关键字,长度不正确!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{1})在表:{0}中,检查关键字,长度不正确!(cls{0}DA:CheckPrimaryKey)\");",
                objPrjTabENEx.TabName,
                strErrId);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0})  ==  true)", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strExplanation = "在表:{0}中,关键字不能为空 或 null!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{1})在表:{0}中,关键字不能为空 或 null!(cls{0}DA:CheckPrimaryKey)\");",
                objPrjTabENEx.TabName,
                strErrId);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckStrSQL_Weak({0});", objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strExplanation = "在关键字中含有{0},非法,请检查!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(string.Format(\"(errid:{3})在关键字中含有{{0}},非法,请检查!(cls{2}DA:CheckPrimaryKey)\", objException.Message));",
                    "{", "}",
                    objPrjTabENEx.TabName,
                    strErrId);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return true;");
            strCodeForCs.Append("\r\n" + "}");

            ///检查表关键字是否合法,是否含有SQL注入. ==  == = ;
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 检查表关键字是否合法,是否含有SQL注入
        /// </summary>
        /// <param name = "strWordTypeId">关键字</param>
        /// <returns>是否检查成功</returns>
        public string GenCheckPrimaryKey_Sim()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///检查表关键字是否合法,是否含有SQL注入.-----------------------------;
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 检查表关键字是否合法,是否含有SQL注入");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">关键字</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <returns>是否检查成功</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public bool CheckPrimaryKey_Sim(string {0})", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0} = {0}.Replace(\"'\", \"''\");",
                objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.Length > {1} + 4)", objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.FldLength);
            strCodeForCs.Append("\r\n" + "{");

            string strFunctionName = string.Format("CheckPrimaryKey_Sim", objKeyField.PrivFuncName, objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "在表:{0}中,检查关键字,长度不正确!(简化版)";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{1})在表:{0}中,检查关键字,长度不正确!(简化版)(cls{0}DA:CheckPrimaryKey)\");",
                objPrjTabENEx.TabName,
                strErrId);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0})  ==  true)", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strExplanation = "在表:{0}中,关键字不能为空 或 null!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{1})在表:{0}中,关键字不能为空 或 null!(cls{0}DA:CheckPrimaryKey)\");",
                objPrjTabENEx.TabName,
                strErrId);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckStrSQL_Weak({0});", objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strExplanation = "在关键字中含有{0},非法,请检查!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "生成代码");

            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(string.Format(\"(errid:{3})在关键字中含有{{0}},非法,请检查!(cls{2}DA:CheckPrimaryKey)\", objException.Message));",
                    "{", "}",
                    objPrjTabENEx.TabName,
                    strErrId);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return true;");
            strCodeForCs.Append("\r\n" + "}");

            ///检查表关键字是否合法,是否含有SQL注入. ==  == = ;
            return strCodeForCs.ToString();
        }

        public virtual string Gen_4DAL_GetDataTable4DdlBind()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";

            try
            {
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <returns>返回用于绑定下拉框的DataTable</returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}()",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                    strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                    strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						if (objField.DsCondStr.Trim()  ==  "")
                    //						{
                    //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    //						}
                    //						else
                    //						{
                    //							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    //								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objField.DsCondStr);
                    //						}

                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}DA.GetSpecSQLObj();", objPrjTabENEx.TabName);

                    strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    strCodeForCs.Append("\r\n" + "return objDT;");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string SetProperty4DefaultValue_Swift3(clsPrjTabFldENEx objField)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
            {
                case "String":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );

                    break;
                case "Int32":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Int":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Double":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Float":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Short":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Bool":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Date":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = Date();",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                default:
                    string strMsg = string.Format("Swift数据类型:[{1}]在switch中没有处理。({0})",
                        clsStackTrace.GetCurrClassFunction(),
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                    throw new Exception(strMsg);

            }
            //strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string SetProperty4DefaultValue_Swift4(clsPrjTabFldENEx objField)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //strCodeForCs.AppendFormat("\r\n" + "if (jsonAllKeys.contains(\"{0}\") == true)",
            //     objField.ObjFieldTabENEx.FldName);
            //strCodeForCs.Append("\r\n" + "{");
            //  strCodeForCs.Append("\r\n" + "//print(\"Memo1 is Exist!\");");
            switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType)
            {
                case "String":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );

                    break;
                case "Int32":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Int":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Double":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Float":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Short":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Bool":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = false;",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                case "Date":
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                    objField.ObjFieldTabENEx.DefaultValue4Test_Swift
                         );
                    break;
                default:
                    string strMsg = string.Format("Swift数据类型:[{1}]在switch中没有处理。({0})",
                        clsStackTrace.GetCurrClassFunction(),
                        objField.ObjFieldTabENEx.objDataTypeAbbrEN.SwiftType);
                    throw new Exception(strMsg);

            }
            //strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public abstract string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code);
        //{
        //    string strMsg = string.Format("在扩展类中没有Override该函数,请注意!({0})", clsStackTrace.GetCurrClassFunction());
        //    throw new Exception(strMsg);
        //}     

        public string KeyDataType
        {
            get
            {
                return objKeyField.TypeScriptType;
            }
        }

        /// <summary>
        /// 关键字的字段名
        /// </summary>
        public string KeyFldName
        {
            get
            {
                return objKeyField.FldName;
            }
        }

        /// <summary>
        /// 是否弹出层编辑
        /// </summary>
        public bool IsPopupDivEdit { get; set; }
        /// <summary>
        /// 检查字段名是否是关键字段
        /// </summary>
        /// <param name = "strFldName">提给的字段名</param>
        /// <param name = "objPrjTabENEx"></param>
        /// <returns></returns>
        public bool IsKeyField(string strFldName)
        {
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {

                if (objField.ObjFieldTabENEx.FldName == strFldName)
                {
                    return true;
                }
            }
            return false;
        }
        public string Gen_Controller_Java_BindDdl(string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 绑定下拉框");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(Spinner spnObject, Activity acPage)",
                strValueFld);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "mspnObject = spnObject;");
            strCodeForCs.Append("\r\n" + "macPage = acPage;");
            strCodeForCs.AppendFormat("\r\n" + "if ({1}.arr{0}ObjLstCache != null)",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)",
                strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, {1}.arr{0}ObjLstCache);",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
                strTabName);
            //  strCodeForCs.Append("\r\n" + "SendMessage(\"使用缓存!\");");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}使用缓存!\", 1);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{1}.icls{0}GetJSONObjLstEx iobj{0}GetJSONObjLst = new {1}.icls{0}GetJSONObjLstEx({1}.this);",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_Controller_Java_GetJSONObjLst4DdlBind(string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "public void btnGetJSONObjLst_Click(View myView) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "icls{0}GetJSONObjLstEx iobj{0}GetJSONObjLst = new icls{0}GetJSONObjLstEx({1}.this);",
                objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetJSONObjLst.main();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetJSONObjLstEx  extends  cls{0}_Controller.icls{0}GetJSONObjLst",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}GetJSONObjLstEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "String strWhereCond =\" 1=1 \";");

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.GetJSONObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetRecordJSONObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN objFirstObj = new cls{0}EN();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.set{0}(\"0\");",
               strValueFld, strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.set{0}(\"请选择...\");", strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst.add(0, objFirstObj);",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "{1}.arr{0}ObjLstCache = arr{0}ObjLst;",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setPrompt(\"请选择您的{0}: \");", objPrjTabENEx.TabCnName);

            strCodeForCs.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)", strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, arr{0}ObjLst);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
                strTabName);
            //strCodeForCs.Append("\r\n" + "SendMessage(\"没有使用缓存!\");");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}, 没有使用缓存!\", 1);",
                strTabName);
            //strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = \" 1 = 1 \"; "); 
            //strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s]共获取对象列表数：%s!\", strWhereCond, arr{0}ObjLst.size());",
            //    objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_Controller_Java_btnClickByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //  strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void btn{0}_Click(View myView) ",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "icls{0}_{1}Ex iobj{0}_{1} = new icls{0}_{1}Ex(ac{0}4SD_UnitTest.this);",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}_{1}.main();",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}_{1}Ex  extends  cls{0}4SD_Controller.icls{0}_{1}",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            //    objWebSrvClassENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}_{1}Ex(Object pvcParent)",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}WS4SDController obj{0}WS4SDController = new {0}WS4SDController();",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4SDController.objTableObjWS4ControllerDelegate = this;",
                objWebSrvClassENEx.ClsName);

            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();

            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {
                    strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                       objWebSrvFuncParaEN.ParaName,
                         objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = txt{2}.getText().toString();",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName,
                            objWebSrvFuncParaEN._StrTag);
                    }
                    else
                    {
                        switch (objWebSrvFuncParaEN.DataTypeId)
                        {
                            case enumDataTypeAbbr.float_07:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Float.valueOf(txt{2}.getText().toString());",
                                    objDataTypeAbbrEN.JavaType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            case enumDataTypeAbbr.int_09:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(txt{2}.getText().toString());",
                                    objDataTypeAbbrEN.JavaType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            case enumDataTypeAbbr.money_11:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Double.valueOf(txt{2}.getText().toString());",
                                    objDataTypeAbbrEN.JavaType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            default:
                                strMsg = string.Format("数据类型：[{0}({1})](Java:{2})在函数中没有处理!({3})",
                                    objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                    objDataTypeAbbrEN.JavaType,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                    }
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("{0},", objWebSrvFuncParaEN.ParaName);
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4SDController.{1}({2});",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName,
                    sbParaVarList.ToString());

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//通过WebService执行函数:[{0}],返回的事件函数,这是正确返回,不需要处理执行错误。",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}( String returnString, String strClassName, String strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"返回值为：[%s]!\", returnString);");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, strInfo);",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_Controller_Java_btnClickByCommonFunction(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //  strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void btn{0}_Click(View myView) ",
                objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "icls{0}_{1}Ex iobj{0}_{1} = new icls{0}_{1}Ex(ac{0}_UnitTest.this);",
                objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}_{1}.main();",
                objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}_{1}Ex  extends  cls{0}_Controller.icls{0}_{1}",
                objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            //    objWebSrvClassENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}_{1}Ex(Object pvcParent)",
                objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WS4Controller obj{0}WS4Controller = new cls{0}WS4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.objTableObjWS4ControllerDelegate = this;",
                objPrjTabENEx.TabName);

            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
              clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objvFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {
                        strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                           objFuncPara4CodeEN.ParaName,
                             objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1} = txt{2}.getText().toString();",
                                objDataTypeAbbrEN.JavaType,
                                objFuncPara4CodeEN.ParaName,
                                objFuncPara4CodeEN._StrTag);
                        }
                        else
                        {
                            switch (objFuncPara4CodeEN.DataTypeId)
                            {
                                case enumDataTypeAbbr.float_07:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Float.valueOf(txt{2}.getText().toString());",
                                        objDataTypeAbbrEN.JavaType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.int_09:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(txt{2}.getText().toString());",
                                        objDataTypeAbbrEN.JavaType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.money_11:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Double.valueOf(txt{2}.getText().toString());",
                                        objDataTypeAbbrEN.JavaType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                default:
                                    strMsg = string.Format("数据类型：[{0}({1})](Java:{2})在函数中没有处理!({3})",
                                        objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                        objDataTypeAbbrEN.JavaType,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        if (objSelfDefDataTypeEN_Para != null)
                        {
                            sbParaList.AppendFormat("{0} {1},",
                                objSelfDefDataTypeEN_Para.JavaType,
                                objFuncPara4CodeEN.ParaName);
                        }
                        else
                        {
                            sbParaList.AppendFormat("{0} {1},",
                                objDataTypeAbbrEN.JavaType,
                                objFuncPara4CodeEN.ParaName);
                        }
                        sbParaVarList.AppendFormat("{0},", objFuncPara4CodeEN.ParaName);
                    }
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4Controller.{1}({2});",
                    objPrjTabENEx.TabName,
                    objvFunction4GeneCodeEN.FuncName4Code,
                    sbParaVarList.ToString());

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//通过WebService执行函数:[{0}],返回的事件函数,这是正确返回,不需要处理执行错误。",
                objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}( String returnString, String strClassName, String strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"返回值为：[%s]!\", returnString);");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, strInfo);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }


        public string GetNewParaCtrlName(string strFuncId4GC, string strParaName)
        {
            clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
            clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objvFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
            {
                if (objFuncPara4CodeEN.ParaName == strParaName) return objFuncPara4CodeEN._StrTag;
            }
            return "";
        }
        public string Gen_WA_Controller_Java_BindDdl(string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 绑定下拉框");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(Spinner spnObject, Activity acPage)",
                strValueFld);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "mspnObject = spnObject;");
            strCodeForCs.Append("\r\n" + "macPage = acPage;");
            strCodeForCs.AppendFormat("\r\n" + "if ({1}.arr{0}ObjLstCache != null)",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)",
                strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, {1}.arr{0}ObjLstCache);",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
                strTabName);
            //  strCodeForCs.Append("\r\n" + "SendMessage(\"使用缓存!\");");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}使用缓存!\", 1);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{1}.icls{0}GetObjLstEx iobj{0}GetObjLst = new {1}.icls{0}GetObjLstEx({1}.this);",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetObjLst.main();",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_WA_Controller_Java_GetObjLst4DdlBind(string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "public void btnGetObjLst_Click(View myView) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "icls{0}GetObjLstEx iobj{0}GetObjLst = new icls{0}GetObjLstEx({1}.this);",
                objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}GetObjLst.main();",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}GetObjLstEx  extends  cls{0}_WA_Controller.icls{0}GetObjLst",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}GetObjLstEx(Object pvcParent)",
    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "String strWhereCond =\" 1=1 \";");

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WA4Controller.GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "//通过WebService执行GetRecordObjLst,返回的事件函数,这是正确返回,不需要处理执行错误。");
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(Object returnObjectList, String strClassName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conGetObjLst,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = (List<cls{0}EN>)returnObjectList;",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN objFirstObj = new cls{0}EN();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.set{0}(\"0\");",
               strValueFld, strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.set{0}(\"请选择...\");", strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst.add(0, objFirstObj);",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "{1}.arr{0}ObjLstCache = arr{0}ObjLst;",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setPrompt(\"请选择您的{0}: \");", objPrjTabENEx.TabCnName);

            strCodeForCs.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)", strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, arr{0}ObjLst);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
                strTabName);
            //strCodeForCs.Append("\r\n" + "SendMessage(\"没有使用缓存!\");");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}, 没有使用缓存!\", 1);",
                strTabName);
            //strCodeForCs.AppendFormat("\r\n" + "String strWhereCond = \" 1 = 1 \"; "); 
            //strCodeForCs.AppendFormat("\r\n" + "String strInfo = String.format(\"根据条件:[%s]共获取对象列表数：%s!\", strWhereCond, arr{0}ObjLst.size());",
            //    objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "clsPubFun.ShowMessage((Activity)vcParent, strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_WA_Controller_Java_btnClickByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //  strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void btn{0}_Click(View myView) ",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "icls{0}_{1}Ex iobj{0}_{1} = new icls{0}_{1}Ex(ac{0}4SD_WA_UT.this);",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}_{1}.main();",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}_{1}Ex extends  cls{0}4SD_Controller.icls{0}_{1}",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            //    objWebSrvClassENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}_{1}Ex(Object pvcParent)",
                objWebSrvClassENEx.ClsName, objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}WA4SDController obj{0}WA4SDController = new {0}WA4SDController();",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WA4SDController.objTableObjWA4ControllerDelegate = this;",
                objWebSrvClassENEx.ClsName);

            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();

            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {
                    strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                       objWebSrvFuncParaEN.ParaName,
                         objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = txt{2}.getText().toString();",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName,
                            objWebSrvFuncParaEN._StrTag);
                    }
                    else
                    {
                        switch (objWebSrvFuncParaEN.DataTypeId)
                        {
                            case enumDataTypeAbbr.float_07:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Float.valueOf(txt{2}.getText().toString());",
                                    objDataTypeAbbrEN.JavaType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            case enumDataTypeAbbr.int_09:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(txt{2}.getText().toString());",
                                    objDataTypeAbbrEN.JavaType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            case enumDataTypeAbbr.money_11:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Double.valueOf(txt{2}.getText().toString());",
                                    objDataTypeAbbrEN.JavaType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            default:
                                strMsg = string.Format("数据类型：[{0}({1})](Java:{2})在函数中没有处理!({3})",
                                    objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                    objDataTypeAbbrEN.JavaType,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                    }
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.JavaType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("{0},", objWebSrvFuncParaEN.ParaName);
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WA4SDController.{1}({2});",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName,
                    sbParaVarList.ToString());

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//通过WebService执行函数:[{0}],返回的事件函数,这是正确返回,不需要处理执行错误。",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}( String returnString, String strClassName, String strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"返回值为：[%s]!\", returnString);");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, strInfo);",
                objWebSrvClassENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WA_Controller_Java_btnClickByCommonFunction(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //  strCodeForCs.Append("\r\n /// <param name = \"sender\">事件发送者</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public void btn{0}_Click(View myView) ",
                objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "icls{0}_{1}Ex iobj{0}_{1} = new icls{0}_{1}Ex(ac{0}_WA_UT.this);",
                objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "iobj{0}_{1}.main();",
                objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "class icls{0}_{1}Ex extends  cls{0}_WA_Controller.icls{0}_{1}",
                objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN();",
            //    objWebSrvClassENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "public icls{0}_{1}Ex(Object pvcParent)",
                objPrjTabENEx.TabName, objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "super(pvcParent);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "@Override");

            strCodeForCs.Append("\r\n" + "public void main()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WA4Controller obj{0}WA4Controller = new cls{0}WA4Controller();",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WA4Controller.objTableObjWA4ControllerDelegate = this;",
                objPrjTabENEx.TabName);

            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
              clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objvFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {
                        strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
                           objFuncPara4CodeEN.ParaName,
                             objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1} = txt{2}.getText().toString();",
                                objDataTypeAbbrEN.JavaType,
                                objFuncPara4CodeEN.ParaName,
                                objFuncPara4CodeEN._StrTag);
                        }
                        else
                        {
                            switch (objFuncPara4CodeEN.DataTypeId)
                            {
                                case enumDataTypeAbbr.float_07:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Float.valueOf(txt{2}.getText().toString());",
                                        objDataTypeAbbrEN.JavaType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.int_09:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Integer.valueOf(txt{2}.getText().toString());",
                                        objDataTypeAbbrEN.JavaType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.money_11:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = Double.valueOf(txt{2}.getText().toString());",
                                        objDataTypeAbbrEN.JavaType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                default:
                                    strMsg = string.Format("数据类型：[{0}({1})](Java:{2})在函数中没有处理!({3})",
                                        objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                        objDataTypeAbbrEN.JavaType,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        if (objSelfDefDataTypeEN_Para != null)
                        {
                            sbParaList.AppendFormat("{0} {1},",
                                objSelfDefDataTypeEN_Para.JavaType,
                                objFuncPara4CodeEN.ParaName);
                        }
                        else
                        {
                            sbParaList.AppendFormat("{0} {1},",
                                objDataTypeAbbrEN.JavaType,
                                objFuncPara4CodeEN.ParaName);
                        }
                        sbParaVarList.AppendFormat("{0},", objFuncPara4CodeEN.ParaName);
                    }
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }

            strCodeForCs.AppendFormat("\r\n" + "obj{0}WA4Controller.{1}({2});",
                    objPrjTabENEx.TabName,
                    objvFunction4GeneCodeEN.FuncName4Code,
                    sbParaVarList.ToString());

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//通过WebService执行函数:[{0}],返回的事件函数,这是正确返回,不需要处理执行错误。",
                objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "@Override");
            strCodeForCs.AppendFormat("\r\n" + "public void {0}( String returnString, String strClassName, String strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.Append("\r\n" + "String strInfo = String.format(\"返回值为：[%s]!\", returnString);");
            strCodeForCs.Append("\r\n" + "tvMsg.setText(strInfo);");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strCodeForCs.AppendFormat("\r\n" + "clsPubFun.ShowMessage((Activity) vcParent, strInfo);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }


        public string KeyFldNameLstStrWithAddStr(string strAdditionalStr, clsViewInfoENEx objViewInfoENEx)
        {
            List<string> arrKeyFldNameLst = new List<string>();
            foreach (clsPrjTabFldENEx objField in objViewInfoENEx.arrKeyPrjTabFldSet)
            {
                arrKeyFldNameLst.Add(strAdditionalStr + objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
            }
            string strKeyFldNameLst = clsArray.GetSqlInStrByArray(arrKeyFldNameLst, false);
            return strKeyFldNameLst;
        }

        public string KeyFldNameLstStrWithAddStr(string strAdditionalStr, clsPrjTabENEx objPrjTabENEx)
        {
            List<string> arrKeyFldNameLst = new List<string>();
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                arrKeyFldNameLst.Add(strAdditionalStr + objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
            }
            string strKeyFldNameLst = clsArray.GetSqlInStrByArray(arrKeyFldNameLst, false);
            return strKeyFldNameLst;
        }


        public string TransKeyWords4FuncName(string strFuncName)
        {
            string strFuncName2 = strFuncName.Replace("[Key]", objKeyField.FldName);
            strFuncName2 = strFuncName2.Replace("[key]", objKeyField.FldName);
            strFuncName2 = strFuncName2.Replace("[TabName]", objPrjTabENEx.TabName);
            //strFuncName2 = strFuncName.Replace("[key]", objKeyField.FldName);
            return strFuncName2;
        }
        public bool IsNumberType4Key
        {
            get
            {
                return clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN);
            }
        }


        //拼装关键字的WHERE串
        protected string KeyWhereStrWithObject(clsPrjTabENEx objPrjTabENEx, string strObject)
        {
            //bool isNeed_m = true;
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                strTemp = string.Format("{0} = \" + {1}+ {2}+{1}",
                    objField.ObjFieldTabENEx.FldName,
                     Mark(objField),
                      strPrivPropNameWithObjectName4Get);
                if (i == 0) //是否是第一次
                {
                    WhereStr += strTemp;
                }
                else
                {
                    WhereStr += string.Format(" + \" and {0}", strTemp);
                }
                i++;
            }

            return WhereStr;
        }


        //拼装关键字的WHERE串
        protected string KeyWhereStrWithObject(string strObject)
        {
            //bool isNeed_m = true;
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.ObjFieldTabENEx.FldName + " = \" + " + Mark(objField) + "+ " + clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, strObject, this.IsFstLcase) + "+" + Mark(objField);
                if (i == 0) //是否是第一次
                {
                    WhereStr += strTemp;
                }
                else
                {
                    WhereStr += " + \" and " + strTemp;
                }
                i++;
            }

            return WhereStr;
        }


        protected string AccessNull_Java(clsPrjTabFldENEx objField)
        {
            return AccessNull_Java("objRS.Rows[0][\"" + objField.ObjFieldTabENEx.FldName + "\"].toString().Trim()", objField.JavaType, objField.IsTabNullable);
        }
        protected string AccessNull2_Java(clsPrjTabFldENEx objField)
        {
            string strTemp = "";
            strTemp = objField.JavaType;
            clsString.FstUcase_S(ref strTemp);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("objRS.get{0}(\"{1}\")",
            strTemp, objField.ObjFieldTabENEx.FldName);
            return AccessNull(strCodeForCs.ToString(), objField.JavaType, objField.IsTabNullable);
        }
        protected string AccessNull_Java(string strContent, string strPropType, bool bolIsNullable)
        {
            //			string strReturn;
            //			strReturn = "";
            if (bolIsNullable == false)
            {
                return strContent;
            }
            switch (strPropType)
            {
                case "String":
                    return strContent;
                case "int":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return "Integer.parseInt(" + strContent + ")";
                    }
                case "short":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToShort(" + strContent + ")";
                    }
                    else
                    {
                        return "Short.parseShort(" + strContent + ")";
                    }
                case "Date":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToDate(" + strContent + ")";
                    }
                    else
                    {
                        return "System.DateTime.Parse(" + strContent + ")";
                    }
                case "Single":
                case "float":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToFloat(" + strContent + ")";
                    }
                    else
                    {
                        return "Single.Parse(" + strContent + ")";
                    }
                case "Double":
                case "Money":
                case "double":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToDouble(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.parseDouble(" + strContent + ")";
                    }
                case "boolean":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToBool(" + strContent + ")";
                    }
                    else
                    {
                        return "boolean.parseBoolean(" + strContent + ")";
                    }
                case "Decimal":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToDouble(" + strContent + ")";
                    }
                    else
                    {
                        return "Double.parseDouble(" + strContent + ")";
                    }
                case "Long":
                case "long":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return "Integer.parseInt(" + strContent + ")";
                    }
                case "Byte":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return strContent;
                    }
                case "byte[]":

                    return "(byte[])" + strContent;
                case "byte":

                    return "(byte)" + strContent;
                case "Int16":
                    if (bolIsNullable == true)
                    {
                        return "TransNullToInt(" + strContent + ")";
                    }
                    else
                    {
                        return "Integer.parseInt(" + strContent + ")";
                    }
                case "System.Guid":
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
                default:
                    if (bolIsNullable == true)
                    {
                        return strContent;
                    }
                    else
                    {
                        return strContent;
                    }
            }
        }//end of AccessNull

        protected string getValueStr(clsPrjTabFldENEx pobjField)
        {
            if (pobjField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
            {
                return "'\" + " + pobjField.ObjFieldTabENEx.PropertyName(this.IsFstLcase) + " + \"'";
            }
            else
            {
                return pobjField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
            }
        }



        protected string KeyWhereStr(bool isNeed_m, clsPrjTabENEx objPrjTabENEx)
        {
            string WhereStr, strTemp;
            int i = 0;
            WhereStr = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrKeyFldSet)
            {
                strTemp = objField.ObjFieldTabENEx.FldName + " = \" + " + Mark(objField) + "+ " + (isNeed_m == true ? "m" : "") + objField.ObjFieldTabENEx.PrivFuncName + "+" + Mark(objField);
                ///'strTemp = arrKeyFldSet[i].ColumnName + " = \"" + Mark(arrKeyFldSet[i]) + "+ " + "m" + objField.ObjFieldTabENEx.PrivFuncName + Mark(arrKeyFldSet[i])
                if (i == 0) //是否是第一次
                {
                    WhereStr += strTemp;
                }
                else
                {
                    WhereStr += " + \" and " + strTemp;
                }
                i++;
            }

            return WhereStr;
        }


        public string gfunTransNullToStr()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///私有函数Begin-------------------------------------;
            strCodeForCs.Append("\r\nprivate string TransNullToStr(Object obj) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (obj.ToString() == \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn \"\";");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn obj.ToString();");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public string gfunTransNullToInt()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\nprivate int TransNullToInt(Object obj) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (obj.ToString() == \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn 0;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn Int32.Parse(obj.ToString());");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public string gfunTransNullToDate()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\nprivate DateTime TransNullToDate(Object obj) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (obj.ToString() == \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn DateTime.Parse(\"#1/1/1900#\");");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn DateTime.Parse(obj.ToString());");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }
        public string gfunTransNullToFloat()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\nprivate float TransNullToFloat(Object obj) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (obj.ToString() == \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn 0.0f;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn float.Parse(obj.ToString());");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            return strCodeForCs.ToString();
        }
        public string gfunTransNullToDouble()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\nprivate double TransNullToDouble(Object obj) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (obj.ToString() == \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn 0.0;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn double.Parse(obj.ToString());");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n");
            return strCodeForCs.ToString();
        }
        public string gfunTransNullToBool()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\nprivate bool TransNullToBool(Object obj) ");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nif (obj.ToString() == \"\")");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn false;");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\nelse");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\nreturn bool.Parse(obj.ToString());");
            strCodeForCs.Append("\r\n}");
            strCodeForCs.Append("\r\n}");
            return strCodeForCs.ToString();
        }



        public string Gen_4BL_GC_GetObjLstFromDataTable()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\nforeach(DataRow objRow in objDT.Rows)");
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN();",
            objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            int intCount = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                intCount++;
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull_Static(objField) + "); //{2}",
                 objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    if (intCount == objPrjTabENEx.arrFldSet.Count)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull_Static(objField) + "; //{2}",
objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = " + AccessNull_Static(objField) + "; //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    }

                }
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})\",");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1}, objException.Message, clsStackTrace.GetCurrClassFunction());",
                objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n	};");
            strCodeForCs.AppendFormat("\r\n	arrObjLst.Add(obj{0}EN);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n	}");
            return strCodeForCs.ToString();
        }

        public string Gen_4BL_GC_GetObjFromDataRow()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n	cls{0}EN obj{0}EN = new cls{0}EN()",
      objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            int intCount = 0;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                intCount++;
                if (objField.FldOpTypeId == "0004") continue;//不读不写
                if (objField.FldOpTypeId == "0002") //只读不写
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(" + AccessNull(objField) + "); //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                }
                else
                {
                    if (intCount == objPrjTabENEx.arrFldSet.Count)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{1} = " + AccessNull2(objField) + " //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{1} = " + AccessNull2(objField) + ", //{2}",
                        objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                    }
                }
            }
            strCodeForCs.Append("\r\n};");
            //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();//清除修改状态,即清除脏字段信息",
            //objPrjTabENEx.TabName);

            return strCodeForCs.ToString();
        }


        public clsGeneCodeBase4Tab(string strTabId, string strPrjDataBaseId, string strPrjId)
        {
            arrJsFunction = new List<JsFunction>();
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
            // 
            // TODO: 在此处添加构造函数逻辑
            //

            GetPrjTabInfo(strTabId, strPrjDataBaseId, strPrjId);

            this.Re_objFunction4Code = new clsFunction4CodeEN();
            pubVarTypes = new List<PubVarType>();

        }
        protected clsPrjTabFldENEx objKeyField
        {
            get
            {
                if (mobjKeyField != null)
                {

                    return objPrjTabENEx.objKeyField0;
                }
                return mobjKeyField;
            }
            set
            {
                mobjKeyField = value;
            }
        }

        public List<clsPrjTabFldENEx> arrKeyFldSet
        {
            get
            {
                return objPrjTabENEx.arrKeyFldSet;
            }
        }


        public clsPrjTabFldENEx objDelSignField
        {
            get
            {
                return mobjDelSignField;
            }
            set => mobjDelSignField = value;
        }
    }
}
