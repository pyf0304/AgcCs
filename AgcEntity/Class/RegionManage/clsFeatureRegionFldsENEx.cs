using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgcCommBase;
using com.taishsoft.common;

namespace AGC.Entity
{
    public class clsFeatureRegionFldsENEx : clsFeatureRegionFldsEN, IRegionFlds
    {

        public clsFeatureRegionFldsENEx()
            : base()
         {
         }
        private clsFieldTabENEx objFieldTabENEx = null;
        public clsCtlTypeEN objCtlType = null;
        
        public string FldName_Java
        {
            get
            {
                return clsString.FstLcaseS(this.ObjFieldTabENEx.FldName.ToLower());
            }
        }
        public string Action4Ajax
        {
            get
            {
                return this.objCtlType.CtlTypeAbbr + this.ButtonName + "Ajax";
            }
        }
        private string mstrCtlName;
        public string CtlName
        {
            get
            {
                mstrCtlName = this.objCtlType.CtlTypeAbbr + this.ObjFieldTabENEx.FldName;
                return mstrCtlName;
            }
            set
            {
                mstrCtlName = value;
            }
        }

        public string CtlName4Win
        {
            get
            {
                mstrCtlName = this.objCtlType.CtlTypeAbbr + this.ObjFieldTabENEx.FldName;

                return mstrCtlName.Replace("ddl", "cbo");
            }
            set
            {
                mstrCtlName = value;
            }
        }
        /// <summary>
        /// 是否针对可视化
        /// </summary>
        public bool Is4Visible { get; set; }
        public clsFieldTabENEx ObjFieldTabENEx
        {
            get
            {
                if (objFieldTabENEx == null)
                {
                    string strMsg = "字段对象没有被初始化！";
                    throw new Exception(strMsg);
                }
                return objFieldTabENEx;

            }
            set => objFieldTabENEx = value;
        }
        //public clsFeatureRegionFldsENEx(clsFeatureRegionFldsEN objFeatureRegionFldsEN)
        //{
        //    this.mId = objFeatureRegionFldsEN.mId; //mId
        //    this.RegionId = objFeatureRegionFldsEN.RegionId; //区域Id
        //    this.ButtonName = objFeatureRegionFldsEN.ButtonName; //按钮名称
        //    this.Text = objFeatureRegionFldsEN.Text; //文本内容
        //    this.CtlTypeId = objFeatureRegionFldsEN.CtlTypeId; //控件类型号
        //    this.Height = objFeatureRegionFldsEN.Height; //高度
        //    this.Width = objFeatureRegionFldsEN.Width; //宽
        //    this.SeqNum = objFeatureRegionFldsEN.SeqNum; //字段序号
        //    this.CssClass = objFeatureRegionFldsEN.CssClass; //样式表
        //    this.ImageUrl = objFeatureRegionFldsEN.ImageUrl; //图片资源
        //    this.UserId = objFeatureRegionFldsEN.UserId; //用户ID
        //    this.UpdDate = objFeatureRegionFldsEN.UpdDate; //修改日期
        //    this.Memo = objFeatureRegionFldsEN.Memo; //说明

        //}

        string IRegionFlds.OutFldId
        {
            get
            {
                return "";
            }
            set
            {

            }
        }

        string IRegionFlds.PrjId
        {
            get
            {
                return mstrPrjId;
            }
            set
            {
                mstrPrjId = value;
            }
        }
        string IRegionFlds.RegionId
        {
            get { return this.RegionId; }
            set { }
        }
        string IRegionFlds.FldId
        {
            get
            {
                return "";
            }
            set
            {

            }
        }
    }
}
