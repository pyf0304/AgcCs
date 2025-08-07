using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.taishsoft.common;
using AgcCommBase;
using AGC.Entity;

namespace AGC.Entity
{
    public class clsWebSrvClassENEx : clsWebSrvClassEN
    {

        public List<clsWebSrvFunctionsENEx> arrWebSrvFunctionsENExObjLst = null;

        public clsProjectsEN objProjectsEN = null;
        public clsFuncModule_AgcEN ObjFuncModule = null;

        private string mstrFunctionTemplateId;

        //private string mstrProgLevelTypeId;

        //private string mstrModuleName;
        public string CmPrjId { get; set; }

        public string ModuleName { get; set; }

        private string mstrClsName;

        public string ClsName
        {
            get
            {
                return mstrClsName;

            }
            set { mstrClsName = value; }
        }
        private string mstrClsNameEx;

        public string ClsNameEx
        {
            get { return mstrClsNameEx; }
            set { mstrClsNameEx = value; }
        }

        private string mstrCurrUserName;

        public string CurrUserName
        {
            get { return mstrCurrUserName; }
            set { mstrCurrUserName = value; }
        }

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
        private int mintTabFldNum;

        /// <summary>
        /// 表字段数
        /// </summary>
        public int TabFldNum
        {
            get { return mintTabFldNum; }
            set { mintTabFldNum = value; }
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


        private int mintKeyFldNum;
        /// <summary>
        /// 关键字段数
        /// </summary>
        public int KeyFldNum
        {
            get { return mintKeyFldNum; }
            set { mintKeyFldNum = value; }
        }
        public clsWebSrvClassENEx(string strTabId) : base(strTabId)
        {

        }
        private string mstrCurrDate;

        public string CurrDate
        {
            get { return mstrCurrDate; }
            set { mstrCurrDate = value; }
        }

        private string mstrUserId;

        public string UserId
        {
            get { return mstrUserId; }
            set { mstrUserId = value; }
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

        /// <summary>
        /// 编程层类型
        /// 日期：20160530
        /// 作者：潘以锋
        /// </summary>
        public new string CodeTypeId
        {
            get;
            set;
        }
        /// <summary>
        /// 模板Id
        /// </summary>
        public string FunctionTemplateId
        {
            get
            {
                return mstrFunctionTemplateId;
            }

            set
            {
                mstrFunctionTemplateId = value;
            }
        }
        #endregion


    }
}
