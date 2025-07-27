using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.taishsoft.common;

namespace AGC.Entity
{
    public class clsViewGroupENEx : clsViewGroupEN
    {
        private string mstrCurrUserName;

        public string CurrUserName
        {
            get
            {
                if (string.IsNullOrEmpty(mstrCurrUserName) == true)
                {
                    throw new Exception("用户名称为空！请检查！");
                }
                return mstrCurrUserName;
            }
            set { mstrCurrUserName = value; }
        }
        protected string mstrFileName; //
        protected string mstrFolderName; // '文件目录名
        //		protected string mstrTabName; // '表名

        //		private bool mbolIsUseCtl = true;
        //clsViewGroupENEx objViewGroupEx = null;
        public clsViewInfoENEx objViewAdd = null;
        public clsViewInfoENEx objViewUpdate = null;
        public clsViewInfoENEx objViewDetail = null;
        public clsViewInfoENEx objViewList = null;
        public clsViewInfoENEx objViewQuery = null;
        //public clsEditRegionENEx objEditRegion = null;		//查询区域字段集合
        //public clsDGRegionENEx objDGRegion = null;		//查询区域字段集合
        //public clsListViewRegionENEx objListViewRegion = null;		//编辑区域字段集合
        //public clsQueryRegionENEx objQueryRegion = null;	//ListView区域字段集合
        //public List<clsFieldTabENEx> arrFieldTabExObjLst1Bak = null;			//界面相关详细表字段集合

        public ArrayList arrQryRegionFldSet_Query;		//查询区域字段集合
        public List<clsEditRegionFldsENEx> arrEditRegionFldSet_Add;		//编辑区域字段集合
        public List<clsEditRegionFldsENEx> arrEditRegionFldSet_Update;		//编辑区域字段集合
        public List<clsEditRegionFldsENEx> arrEditRegionFldSet_Detail;		//编辑区域字段集合
        public ArrayList arrDetailFldSet;		//编辑区域字段集合
        public List<clsDGRegionFldsENEx> arrDGRegionFldSet_List;			//DG区域字段集合
        public List<clsPrjTabFldENEx> arrOUTTabFldSet;			//界面相关主表字段集合
        public List<clsPrjTabFldENEx> arrINTabFldSet;			//界面相关详细表字段集合
        
        public clsPrjTabENEx objOUTPrjTab = null;
        public clsPrjTabENEx objINPrjTab = null;

        public clsPrjTabFldENEx objMainTabKeyFld = null;	//界面相关主表关键字段对象
        public clsPrjTabFldENEx objDetailTabKeyFld = null;	//界面相关主表关键字段对象




        public string TabName_Java
        {
            get
            {
                return clsString.FstLcaseS(this.objINPrjTab.TabName);
            }
        }
        /// <summary>
        /// 编程用表名,首字母小写
        /// </summary>
        public string TableNameForProg_FstLcase
        {
            get
            {
                return clsString.FstLcaseS(this.TableNameForProg);
            }
        }
        /// <summary>
        /// 编程用表名,首字母大写
        /// </summary>
        public string TableNameForProg_FstUcase
        {
            get
            {
                string strTableName = clsString.FirstUcaseS(this.TableNameForProg);
                return strTableName;
            }
        }
        /// <summary>
        /// Manager类
        /// </summary>
        public string StutsManagerClass
        {
            get
            {
                return this.PrjDomain + "." + this.TableNameForProg_FstUcase + "Manager";
            }
        }
        /// <summary>
        /// Manager对象
        /// </summary>
        public string StutsManagerObject
        {
            get
            {
                return this.TableNameForProg_FstLcase + "Manager";
            }
        }
        /// <summary>
        /// Manager对象
        /// </summary>
        public string StutsManagerObject_Sim
        {
            get
            {
                return this.TableNameForProg_FstLcase + "Manager";
            }
        }
        public string StutsActionClass
        {
            get
            {
                return this.PrjDomain + "." + this.TableNameForProg_FstUcase + "Action";
            }
        }
        /// <summary>
        /// 界面组的Action对象
        /// </summary>
        public string StutsActionObject
        {
            get
            {
                return this.ActionPath + "/" + this.TableNameForProg_FstLcase + "Action";
            }
        }
        public string StutsActionFormClass
        {
            get
            {
                return this.PrjDomain + "." + this.TableNameForProg_FstUcase + "Form";
            }
        }
        public string StutsActionFormClass_Sim
        {
            get
            {
                return this.TableNameForProg_FstUcase + "Form";
            }
        }
        public string StutsActionFormObject
        {
            get
            {
                return this.PrjDomain + "." + this.TableNameForProg_FstLcase + "Form";
            }
        }
        public string StutsActionFormObject_Sim
        {
            get
            {
                return this.TableNameForProg_FstLcase + "Form";
            }
        }
        /// <summary>
        /// ACTION中的添加方法
        /// </summary>
        public string StutsActionMethod_Add
        {
            get
            {
                return "add" + this.TableNameForProg_FstUcase;
            }
        }

        public string StutsActionMethod_AddSave
        {
            get
            {
                return "add" + this.TableNameForProg_FstUcase + "Save";
            }
        }

        public string StutsActionMethod_Update
        {
            get
            {
                return "update" + this.TableNameForProg_FstUcase;
            }
        }

        public string StutsActionMethod_UpdateSave
        {
            get
            {
                return "update" + this.TableNameForProg_FstUcase + "Save";
            }
        }

        public string StutsActionMethod_List
        {
            get
            {
                return "list" + this.TableNameForProg_FstUcase;
            }
        }
        public string StutsActionMethod_Delete
        {
            get
            {
                return "delete" + this.TableNameForProg_FstUcase;
            }
        }
        public string StutsActionMethod_Detail
        {
            get
            {
                return "detail" + this.TableNameForProg_FstUcase;
            }
        }
        public string StutsActionMethod_Query
        {
            get
            {
                return "query" + this.TableNameForProg_FstUcase;
            }
        }

    }
}
