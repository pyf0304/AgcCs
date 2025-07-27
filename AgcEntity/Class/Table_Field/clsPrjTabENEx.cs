using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.taishsoft.common;
using AgcCommBase;
using AGC.Entity;

namespace AGC.Entity
{
    public class clsPrjTabENEx : clsPrjTabEN
    {
        public string SqlDsTypeName { get; set; }

        public string TabStateName { get; set; }
        public string FuncModuleName { get; set; }
        public string TabTypeName { get; set; }
        public string RelaTabName4View { get; set; }
        public string UpdDate_Sim { get; set; }
        private bool mbolIsAppliedInViewList = false;
        /// <summary>
        /// 是否在视图列表区中应用
        /// </summary>
        public bool IsAppliedInViewList
        {
            get
            {
                return mbolIsAppliedInViewList;
            }
            set
            {
                mbolIsAppliedInViewList = value;
            }
        }

        private bool mbolIsAppliedInViewList4CmPrjId = false;
        /// <summary>
        /// 是否在视图列表区中应用
        /// </summary>
        public bool IsAppliedInViewList4CmPrjId
        {
            get
            {
                return mbolIsAppliedInViewList4CmPrjId;
            }
            set
            {
                mbolIsAppliedInViewList4CmPrjId = value;
            }
        }

        public List<clsFieldTabENEx> arrFieldTabExObjLst = null;			//界面相关详细表字段集合

        private List<clsPrjTabFldENEx> marrFldSet = null;
        private List<clsPrjTabFldENEx> marrFldSetEx = null;

        public List<clsPrjTabFldENEx> arrFldSet {
            get {
                return this.marrFldSet;
            }
            set {
                this.marrFldSet = value;
            }         
        }

        public List<clsPrjTabFldENEx> arrFldSetEx
        {
            get
            {
                return this.marrFldSetEx;
            }
            set
            {
                this.marrFldSetEx = value;
            }
        }

        private List<clsPrjTabFldENEx> marrFldSetAll = null;
        public List<clsPrjTabFldENEx> arrFldSetAll
        {
            get
            {
                return this.marrFldSetAll;
            }
            set
            {
                this.marrFldSetAll = value;
            }
        }
        private List<clsPrjTabFldENEx> marrKeyFldSet = null;

        //public List<clsPrjConstraintENEx> arrPrjConstraintSet = null;
        //public List<clsConstraintFieldsENEx> arrConstraintFieldsSet = null;
        //public List<clsTabFeatureENEx> arrTabFeatureSet = null;
        public List<clsTabFunctionPropEN> arrTabFunctionProp = null;
        /// <summary>
        /// 关键字段的表字段对象
        /// </summary>
        public clsPrjTabFldENEx objKeyField0 = null;
        public clsPrjTabFldENEx objNameField = null;
        public clsPrjTabFldENEx objOrderNumField = null;
        public clsPrjTabFldENEx objDelSignField = null;
        public clsFieldTabENEx objSortField = null;
        public clsPrjTabFldENEx objCacheClassifyFld { get; set; } 
        public clsPrjTabFldENEx objCacheClassifyFld2 = null;
        private clsPrjTabFldENEx objCacheClassifyFld_TS = null;
        private clsPrjTabFldENEx objCacheClassifyFld2_TS = null;

        /// <summary>
        /// 名称字段的表字段对象
        /// </summary>
        public clsPrjTabFldENEx objPrjTabFld4NameFld = null;//名称字段的表字段对象

        public clsProjectsEN objProjectsEN = null;
   
        public clsFuncModule_AgcEN ObjFuncModule { get; set; }
        public string PrjInnerFileName { get; set; }
        public string FullFileName { get; set; }

        public string FuncId4GC { get; set; }
        public string SuffixPath { get; set; }
        //public bool IsCheckDate { get; set; }
        //public DateTime NewestPublishDate { get; set; }

        //private string mstrFunctionTemplateId;

        //    private string mstrProgLevelTypeId;

        //private string mstrModuleName;

        public string ModuleName { get; set; }

        public int ApplicationTypeId { get; set; }

        private string mstrClsName;

        public string ClsName
        {
            get { return mstrClsName;
                               
                    }
            set { mstrClsName = value; }
        }
        private string mstrClsNameEx;

        public string ClsNameEx
        {
            get { return mstrClsNameEx; }
            set { mstrClsNameEx = value; }
        }

        //private string mstrCurrUserName;

        //public string CurrUserName
        //{
        //    get {
        //        return mstrCurrUserName;
        //    }
        //    set {
        //        mstrCurrUserName = value;
        //    }
        //}

        private string mstrPrjDataBaseId;

        /// <summary>
        /// 工程数据库Id
        /// </summary>
        public string PrjDataBaseId
        {
            get { return mstrPrjDataBaseId; }
            set { mstrPrjDataBaseId = value; }
        }

        //protected bool mbolIsForSilverLight;//是否针对SliverLight
        ///// <summary>
        ///// 是否针对SliverLight
        ///// </summary>
        //public bool IsForSilverLight
        //{
        //    get { return mbolIsForSilverLight; }
        //    set { mbolIsForSilverLight = value; }
        //}
        //private int mintTabFldNum;

        ///// <summary>
        ///// 表字段数
        ///// </summary>
        //public int TabFldNum
        //{
        //    get { return mintTabFldNum; }
        //    set { mintTabFldNum = value; }
        //}

        private clsPrjTabFldENEx mobjPrefixField = null;
        public clsPrjTabFldENEx PrefixField
        {
            get { return mobjPrefixField; }
            set { mobjPrefixField = value; }
        }
        private string mstrTabSpace;

        public string TabSpace
        {
            get { return mstrTabSpace; }
            set { mstrTabSpace = value; }
        }
        private clsPubConst.LangType mstrLangType = clsPubConst.LangType.CSharp;// "C#.NET";

        public clsPubConst.LangType LangType
        {
            get { return mstrLangType; }
            set { mstrLangType = value; }
        }


        //private int mintKeyFldNum;
        ///// <summary>
        ///// 关键字段数
        ///// </summary>
        //public int KeyFldNum
        //{
        //    get { return mintKeyFldNum; }
        //    set { mintKeyFldNum = value; }
        //}
        public List<clsPrjTabFldENEx> arrPrjTabFldENExObjLst = null;
        public clsPrjTabENEx(string strTabId):base(strTabId)
        {

        }
        public clsPrjTabENEx() : base()
        {

        }
        public clsPrjTabENEx(clsPrjTabEN objPrjTabEN)
        {
            this.TabId = objPrjTabEN.TabId; //表ID
            this.TabName = objPrjTabEN.TabName; //表名
            this.TabCnName = objPrjTabEN.TabCnName; //表中文名
            this.PrjId = objPrjTabEN.PrjId; //工程ID
            //this.ObjId = objPrjTabEN.ObjId; //所属对象
            this.IsNeedTransCode = objPrjTabEN.IsNeedTransCode; //是否需要转换代码
            this.SqlDsTypeId = objPrjTabEN.SqlDsTypeId; //数据源类型
            this.TabStateId = objPrjTabEN.TabStateId; //表状态ID
            this.TabNameB = objPrjTabEN.TabNameB; //表名_后备
            this.IsParaTab = objPrjTabEN.IsParaTab; //是否参数表
            this.IsNationStandard = objPrjTabEN.IsNationStandard; //是否国标
            this.IsArchive = objPrjTabEN.IsArchive; //是否存档
            this.IsChecked = objPrjTabEN.IsChecked; //是否核实
            //this.ErrMsg = objPrjTabEN.ErrMsg; //错误信息
            this.FuncModuleAgcId = objPrjTabEN.FuncModuleAgcId; //功能模块Id
            this.DataBaseName = objPrjTabEN.DataBaseName; //数据库名
            this.Owner = objPrjTabEN.Owner; //拥有者
            this.RelaTabId4View = objPrjTabEN.RelaTabId4View; //相关视图ID
            this.UpdUserId = objPrjTabEN.UpdUserId; //修改用户Id
            this.UpdDate = objPrjTabEN.UpdDate; //修改日期
            //this.GeneCodeDate = objPrjTabEN.GeneCodeDate; //生成代码日期
            this.Memo = objPrjTabEN.Memo; //说明

        }
        private string mstrCurrDate;

        public string CurrDate
        {
            get { return mstrCurrDate; }
            set { mstrCurrDate = value; }
        }
        //public string CmPrjId { get; set; }

        private string mstrUserId;

        public string UserId
        {
            get { return mstrUserId; }
            set { mstrUserId = value; }
        }
        /// <summary>
        /// 字段名列表串
        /// </summary>
        public string FieldNameLstStr
        {
            get
            {
                return GetFieldNameLstStrByFieldObjLst(arrFldSet);
            }
        }
        /// <summary>
        /// 通过字段对象列表获取字段名列表串
        /// </summary>
        /// <param name="arrFieldSet">字段对象列表</param>
        /// <returns>字段名列表串</returns>
        public string GetFieldNameLstStrByFieldObjLst(List<clsPrjTabFldENEx> arrFieldSet)
        {
            List<string> arrFieldNameLst = GetFieldNameLstByFieldObjLst(arrFieldSet);
            string strFieldNameLst = clsArray.GetSqlInStrByArray(arrFieldNameLst, false);
            return strFieldNameLst;
        }

        /// <summary>
        /// 通过字段对象列表获取字段名列表
        /// </summary>
        /// <param name="arrFieldSet">字段对象列表</param>
        /// <returns>字段名列表</returns>
        public List<string> GetFieldNameLstByFieldObjLst(List<clsPrjTabFldENEx> arrFieldSet)
        {
            List<string> arrFieldNameLst = new List<string>();
            foreach (clsPrjTabFldENEx objField in arrFieldSet)
            {
                arrFieldNameLst.Add(objField.ObjFieldTabENEx.FldName);
            }
            return arrFieldNameLst;
        }

        /// <summary>
        /// 关键字字段名的列表串
        /// </summary>
        public string KeyFldNameLstStr
        {
            get
            {
                List<string> arrKeyFldNameLst = new List<string>();
                foreach (clsPrjTabFldENEx objField in arrKeyFldSet)
                {
                    arrKeyFldNameLst.Add(objField.ObjFieldTabENEx.FldName);
                }
                string strKeyFldNameLst = clsArray.GetSqlInStrByArray(arrKeyFldNameLst, false);
                return strKeyFldNameLst;
            }
        }

   
        /// <summary>
        /// 关键字函数变量的列表串
        /// </summary>
        public string KeyPrivFuncFldNameLstStr
        {
            get
            {
                List<string> arrKeyPrivFuncFldNameLst = new List<string>();
                foreach (clsPrjTabFldENEx objField in arrKeyFldSet)
                {
                    arrKeyPrivFuncFldNameLst.Add(objField.ObjFieldTabENEx.PrivFuncName);
                }
                string strKeyPrivFuncFldNameLst = clsArray.GetSqlInStrByArray(arrKeyPrivFuncFldNameLst, false);
                return strKeyPrivFuncFldNameLst;
            }
        }
        public string KeyPrivFuncFldNameLstStr_TS
        {
            get
            {
                List<string> arrKeyPrivFuncFldNameLst = new List<string>();
                foreach (clsPrjTabFldENEx objField in arrKeyFldSet)
                {
                    arrKeyPrivFuncFldNameLst.Add(objField.ObjFieldTabENEx.PrivFuncName);
                }
                string strKeyPrivFuncFldNameLst = clsArray.GetSqlInStrByArray(arrKeyPrivFuncFldNameLst, false);
                return strKeyPrivFuncFldNameLst;
            }
        }
        public string KeyPropNameLstStrWithKeyLst_TS
        {
            get
            {
                List<string> arrKeyPrivFuncFldNameLst = new List<string>();
                foreach (clsPrjTabFldENEx objField in arrKeyFldSet)
                {
                    arrKeyPrivFuncFldNameLst.Add(objField.ObjFieldTabENEx.PrivPropNameWithObjectName_TS("objKeyLst"));
                }
                string strKeyPrivFuncFldNameLst = clsArray.GetSqlInStrByArray(arrKeyPrivFuncFldNameLst, false);
                return strKeyPrivFuncFldNameLst;
            }
        }

        public string KeyPropNameLstStrWithObjName_TS
        {
            get
            {
                List<string> arrKeyPrivFuncFldNameLst = new List<string>();
                foreach (clsPrjTabFldENEx objField in arrKeyFldSet)
                {
                    arrKeyPrivFuncFldNameLst.Add(objField.ObjFieldTabENEx.PrivPropNameWithObjectName_TS($"obj{this.TabName}EN"));
                }
                string strKeyPrivFuncFldNameLst = clsArray.GetSqlInStrByArray(arrKeyPrivFuncFldNameLst, false);
                return strKeyPrivFuncFldNameLst;
            }
        }
        /// <summary>
        /// 关键字变量定义的列表串
        /// </summary>
        public string KeyVarDefineLstStr
        {
            get
            {
                List<string> arrKeyVarDefLst = new List<string>();
                foreach (clsPrjTabFldENEx objField in arrKeyFldSet)
                {
                    arrKeyVarDefLst.Add(objField.ObjFieldTabENEx.KeyVarDefineStr);
                }
                string strKeyVarDefLst = clsArray.GetSqlInStrByArray(arrKeyVarDefLst, false);
                return strKeyVarDefLst;
            }
        }

        /// <summary>
        /// 关键字变量定义的列表串
        /// </summary>
        public string KeyVarDefineLstStr_TS
        {
            get
            {
                List<string> arrKeyVarDefLst = new List<string>();
                foreach (clsPrjTabFldENEx objField in arrKeyFldSet)
                {
                    arrKeyVarDefLst.Add(objField.ObjFieldTabENEx.KeyVarDefineStr_TS);
                }
                string strKeyVarDefLst = clsArray.GetSqlInStrByArray(arrKeyVarDefLst, false);
                return strKeyVarDefLst;
            }
        }

        public string Keys
        {
            get
            {
                string strT;
                int i = 0;
                strT = "";
                foreach (clsPrjTabFldENEx objField in arrKeyFldSet)
                {
                    if (i == 0)//是否是第一次
                    {

                        strT += objField.ObjFieldTabENEx.FldName;
                    }
                    else
                    {
                        strT += "," + objField.ObjFieldTabENEx.FldName;
                    }
                    i++;
                }
                return strT;

            }
        }


        protected int intViewFldNum;
        protected int intTabKeyFldNum;		//相关表的关键字段数
        #region 属性函数

        public int TabKeyFldNum
        {
            get
            {
                return intTabKeyFldNum;
            }
        }
        public int ViewFldNum
        {
            get
            {
                return intViewFldNum;
            }
        }

        protected string mstrFolderName_Root; // '根文件目录名

        public string FolderName_Root
        {
            get { return mstrFolderName_Root; }
            set { mstrFolderName_Root = value; }
        }

        protected string mstrBackupFolderName; // '文件目录名
        /// <summary>
        /// 备份的文件目录
        /// </summary>
        public string BackupFolderName
        {
            get { return mstrBackupFolderName; }
            set { mstrBackupFolderName = value; }
        }


        private bool mbolIsHaveImageField;

        public bool IsHaveImageField
        {
            get { return mbolIsHaveImageField; }
            set { mbolIsHaveImageField = value; }
        }


        private string mstrImageFieldName;

        public string ImageFieldName
        {
            get { return mstrImageFieldName; }
            set { mstrImageFieldName = value; }
        }

        private string mstrSimpleFileName;

        public string SimpleFileName
        {
            get { return mstrSimpleFileName; }
            set { mstrSimpleFileName = value; }
        }


        private string mstrFolderName;
        public string FolderName
        {
            get
            {
                return mstrFolderName; // '文件目录名
            }
            set
            {
                mstrFolderName = value;
            }
        }
        private string mstrFileName;
        public string FileName
        {
            get
            {
                return mstrFileName;
            }
            set
            {
                mstrFileName = value;
            }
        }
        public string TabName_Java
        {
            get
            {
                return clsString.FstLcaseS(mstrTabName);
            }
        }

    
        /// <summary>
        /// 编程层类型
        /// 日期：20160530
        /// 作者：潘以锋
        /// </summary>
        public string CodeTypeId
        {
            get;
            set;
        }
        ///// <summary>
        ///// 模板Id
        ///// </summary>
        //public string FunctionTemplateId
        //{
        //    get
        //    {
        //        return mstrFunctionTemplateId;
        //    }

        //    set
        //    {
        //        mstrFunctionTemplateId = value;
        //    }
        //}
        #endregion

        /// <summary>
        /// 表名，首字母大写
        /// </summary>
        public string TabName_FstUcase
        {
            get
            {
                 return clsString.FirstUcaseS(mstrTabName); 
            }
        }
        /// <summary>
        /// 表名，首字母小写
        /// </summary>
        public string TabName_FstLcase
        {
            get
            {
                return clsString.FirstLcaseS(mstrTabName);
            }
        }

        public List<clsPrjTabFldENEx> arrKeyFldSet
        {
            get
            {
                return marrKeyFldSet;
            }
            set
            {
                marrKeyFldSet = value;
            }
        }

        public clsPrjTabFldENEx ObjCacheClassifyFld_TS { get => objCacheClassifyFld_TS; set => objCacheClassifyFld_TS = value; }
        public clsPrjTabFldENEx ObjCacheClassifyFld2_TS { get => objCacheClassifyFld2_TS; set => objCacheClassifyFld2_TS = value; }
    }
}
