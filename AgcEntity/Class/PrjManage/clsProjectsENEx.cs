using AgcCommBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AGC.Entity;

namespace AGC.Entity
{
    public class clsProjectsENEx : clsProjectsEN
    {
        //public clsPrjDataBaseENEx objPrjDataBaseENEx = null;
        public clsProjectsENEx() :base()
        {

        }
        public clsProjectsENEx(string strPrjId) : base(strPrjId)
        {

        }
        //public clsProjectsENEx(clsProjectsEN objProjectsEN)
        //{
            
        //    this.PrjId = objProjectsEN.PrjId; //工程ID
        //    this.PrjName = objProjectsEN.PrjName; //工程名称
        //    this.PrjDomain = objProjectsEN.PrjDomain; //域/包名
        //    this.VirtualDirectory = objProjectsEN.VirtualDirectory; //虚拟目录
        //    this.PrjRootDirectory = objProjectsEN.PrjRootDirectory; //工程根目录
        //    this.IsRelaDataBase = objProjectsEN.IsRelaDataBase; //是否关联数据库
        //    this.JavaPackageName = objProjectsEN.JavaPackageName; //是否关联数据库

        //    this.SoftStructureId = objProjectsEN.SoftStructureId; //架构ID
        //    //this.PrjDataBaseId = objProjectsEN.PrjDataBaseId; //项目数据库Id
        //    this.ApplicationTypeId = objProjectsEN.ApplicationTypeId; //应用程序类型ID
        //    this.IsSupportMvc = objProjectsEN.IsSupportMvc; //应用程序类型ID
        //    this.UserId = objProjectsEN.UserId; //用户ID
        //    this.UpdDate = objProjectsEN.UpdDate; //修改日期
        //    //this.IsAccess = objProjectsEN.IsAccess; //IsAccess
        //    this.UseStateId = objProjectsEN.UseStateId; //使用状态Id
        //    this.Memo = objProjectsEN.Memo; //说明

        //}
        private clsPubConst.LangType mstrLangType = clsPubConst.LangType.CSharp;// "C#.NET";

        public clsPubConst.LangType LangType
        {
            get { return mstrLangType; }
            set { mstrLangType = value; }
        }
        private int mintConnectWay;

        public int ConnectWay
        {
            get { return mintConnectWay; }
            set { mintConnectWay = value; }
        }

        private string mstrCurrDate;

        public string CurrDate
        {
            get { return mstrCurrDate; }
            set { mstrCurrDate = value; }
        }

        //private string mstrUserId;

        //public string UserId
        //{
        //    get { return mstrUserId; }
        //    set { mstrUserId = value; }
        //}


        private string mstrCurrUserName;

        public string CurrUserName
        {
            get { return mstrCurrUserName; }
            set { mstrCurrUserName = value; }
        }
        //public string ConnectString
        //{
        //    get
        //    {
        //        objPrjDataBaseENEx.ConnectWay = this.ConnectWay;
        //        return objPrjDataBaseENEx.ConnectString;
        //    }
        //}
    }
}
