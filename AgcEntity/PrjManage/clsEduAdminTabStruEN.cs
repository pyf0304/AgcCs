
///----------------------
///生成代码版本：2012.11.9.1
///生成日期：2012/11/20
///生成者：潘以锋
///工程名称：AGC
///工程ID：0005
///模块中文名：工程管理
///模块英文名：PrjManage
///注意：1、需要数据底层（PubDataBase.dll）的版本：2012.10.20.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2012.10.23.1
///========================
using System;
using System.Text;
using System.Collections;
using com.taishsoft.comm_db_obj;

namespace AGC.Entity
{
    /// <summary>
    /// 教务管理表结构(EduAdminTabStru)
    /// </summary>
    [Serializable]
    public class clsEduAdminTabStruEN : clsEntityBase2
    {
        public const string CurrTabName_S = "EduAdminTabStru"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 11;
        public static string[] AttributeName = new string[] { "mId", "TabName", "TabCnName", "TabMemo", "FldName", "FLdCaption", "FldType", "FldLength", "DefaValue", "IsNull", "FldMemo" };
        //以下是属性变量


        /// <summary> 
        /// mId(字段类型:bigint,字段长度:8,是否可空:False)
        /// </summary>
        protected long mlngmId;

        /// <summary> 
        /// 表名(字段类型:varchar,字段长度:60,是否可空:False)
        /// </summary>
        protected string mstrTabName;

        /// <summary> 
        /// 表中文名(字段类型:varchar,字段长度:60,是否可空:True)
        /// </summary>
        protected string mstrTabCnName;

        /// <summary> 
        /// TabMemo(字段类型:nvarchar,字段长度:510,是否可空:True)
        /// </summary>
        protected string mstrTabMemo;

        /// <summary> 
        /// 字段名(字段类型:varchar,字段长度:50,是否可空:False)
        /// </summary>
        protected string mstrFldName;

        /// <summary> 
        /// FLdCaption(字段类型:nvarchar,字段长度:510,是否可空:True)
        /// </summary>
        protected string mstrFLdCaption;

        /// <summary> 
        /// 字段类型(字段类型:varchar,字段长度:2,是否可空:False)
        /// </summary>
        protected string mstrFldType;

        /// <summary> 
        /// 字段长度(字段类型:int,字段长度:4,是否可空:False)
        /// </summary>
        protected int mintFldLength;

        /// <summary> 
        /// DefaValue(字段类型:nvarchar,字段长度:510,是否可空:True)
        /// </summary>
        protected string mstrDefaValue;

        /// <summary> 
        /// 是否可空(字段类型:bit,字段长度:1,是否可空:False)
        /// </summary>
        protected bool mbolIsNull;

        /// <summary> 
        /// FldMemo(字段类型:nvarchar,字段长度:510,是否可空:True)
        /// </summary>
        protected string mstrFldMemo;
        
        public clsEduAdminTabStruEN()
        {
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "EduAdminTabStru";
            lstKeyFldNames.Add("mId");
        }

        public clsEduAdminTabStruEN(long lngmId)
        {
            if (lngmId == 0)
            {
                throw new Exception("关键字不能为0！");
            }

            mlngmId = lngmId;
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "EduAdminTabStru";
            lstKeyFldNames.Add("mId");
        }

        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;
            }
        }
        public object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == "mId")
                {
                    return mlngmId;
                }
                else if (strAttributeName == "TabName")
                {
                    return mstrTabName;
                }
                else if (strAttributeName == "TabCnName")
                {
                    return mstrTabCnName;
                }
                else if (strAttributeName == "TabMemo")
                {
                    return mstrTabMemo;
                }
                else if (strAttributeName == "FldName")
                {
                    return mstrFldName;
                }
                else if (strAttributeName == "FLdCaption")
                {
                    return mstrFLdCaption;
                }
                else if (strAttributeName == "FldType")
                {
                    return mstrFldType;
                }
                else if (strAttributeName == "FldLength")
                {
                    return mintFldLength;
                }
                else if (strAttributeName == "DefaValue")
                {
                    return mstrDefaValue;
                }
                else if (strAttributeName == "IsNull")
                {
                    return mbolIsNull;
                }
                else if (strAttributeName == "FldMemo")
                {
                    return mstrFldMemo;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "mId")
                {
                    mlngmId = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "TabName")
                {
                    mstrTabName = value.ToString();
                }
                else if (strAttributeName == "TabCnName")
                {
                    mstrTabCnName = value.ToString();
                }
                else if (strAttributeName == "TabMemo")
                {
                    mstrTabMemo = value.ToString();
                }
                else if (strAttributeName == "FldName")
                {
                    mstrFldName = value.ToString();
                }
                else if (strAttributeName == "FLdCaption")
                {
                    mstrFLdCaption = value.ToString();
                }
                else if (strAttributeName == "FldType")
                {
                    mstrFldType = value.ToString();
                }
                else if (strAttributeName == "FldLength")
                {
                    mintFldLength = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "DefaValue")
                {
                    mstrDefaValue = value.ToString();
                }
                else if (strAttributeName == "IsNull")
                {
                    mbolIsNull = TransNullToBool(value.ToString());
                }
                else if (strAttributeName == "FldMemo")
                {
                    mstrFldMemo = value.ToString();
                }
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if ("mId" == AttributeName[intIndex])
                {
                    return mlngmId;
                }
                else if ("TabName" == AttributeName[intIndex])
                {
                    return mstrTabName;
                }
                else if ("TabCnName" == AttributeName[intIndex])
                {
                    return mstrTabCnName;
                }
                else if ("TabMemo" == AttributeName[intIndex])
                {
                    return mstrTabMemo;
                }
                else if ("FldName" == AttributeName[intIndex])
                {
                    return mstrFldName;
                }
                else if ("FLdCaption" == AttributeName[intIndex])
                {
                    return mstrFLdCaption;
                }
                else if ("FldType" == AttributeName[intIndex])
                {
                    return mstrFldType;
                }
                else if ("FldLength" == AttributeName[intIndex])
                {
                    return mintFldLength;
                }
                else if ("DefaValue" == AttributeName[intIndex])
                {
                    return mstrDefaValue;
                }
                else if ("IsNull" == AttributeName[intIndex])
                {
                    return mbolIsNull;
                }
                else if ("FldMemo" == AttributeName[intIndex])
                {
                    return mstrFldMemo;
                }
                return null;
            }
            set
            {
                if ("mId" == AttributeName[intIndex])
                {
                    mlngmId = TransNullToInt(value.ToString());
                }
                else if ("TabName" == AttributeName[intIndex])
                {
                    mstrTabName = value.ToString();
                }
                else if ("TabCnName" == AttributeName[intIndex])
                {
                    mstrTabCnName = value.ToString();
                }
                else if ("TabMemo" == AttributeName[intIndex])
                {
                    mstrTabMemo = value.ToString();
                }
                else if ("FldName" == AttributeName[intIndex])
                {
                    mstrFldName = value.ToString();
                }
                else if ("FLdCaption" == AttributeName[intIndex])
                {
                    mstrFLdCaption = value.ToString();
                }
                else if ("FldType" == AttributeName[intIndex])
                {
                    mstrFldType = value.ToString();
                }
                else if ("FldLength" == AttributeName[intIndex])
                {
                    mintFldLength = TransNullToInt(value.ToString());
                }
                else if ("DefaValue" == AttributeName[intIndex])
                {
                    mstrDefaValue = value.ToString();
                }
                else if ("IsNull" == AttributeName[intIndex])
                {
                    mbolIsNull = TransNullToBool(value.ToString());
                }
                else if ("FldMemo" == AttributeName[intIndex])
                {
                    mstrFldMemo = value.ToString();
                }
            }
        }

        /// <summary>
        /// mId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
        /// </summary>
        public long mId
        {
            get
            {
                return mlngmId;
            }
            set
            {
                mlngmId = value;
                //记录修改过的字段
                AddUpdatedFld("mId");
            }
        }
        /// <summary>
        /// 表名(说明:;字段类型:varchar;字段长度:60;是否可空:False)
        /// </summary>
        public string TabName
        {
            get
            {
                return mstrTabName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTabName = value;
                }
                else
                {
                    mstrTabName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("TabName");
            }
        }
        /// <summary>
        /// 表中文名(说明:;字段类型:varchar;字段长度:60;是否可空:True)
        /// </summary>
        public string TabCnName
        {
            get
            {
                return mstrTabCnName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTabCnName = value;
                }
                else
                {
                    mstrTabCnName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("TabCnName");
            }
        }
        /// <summary>
        /// TabMemo(说明:;字段类型:nvarchar;字段长度:510;是否可空:True)
        /// </summary>
        public string TabMemo
        {
            get
            {
                return mstrTabMemo;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTabMemo = value;
                }
                else
                {
                    mstrTabMemo = value;
                }
                //记录修改过的字段
                AddUpdatedFld("TabMemo");
            }
        }
        /// <summary>
        /// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
        /// </summary>
        public string FldName
        {
            get
            {
                return mstrFldName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFldName = value;
                }
                else
                {
                    mstrFldName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("FldName");
            }
        }
        /// <summary>
        /// FLdCaption(说明:;字段类型:nvarchar;字段长度:510;是否可空:True)
        /// </summary>
        public string FLdCaption
        {
            get
            {
                return mstrFLdCaption;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFLdCaption = value;
                }
                else
                {
                    mstrFLdCaption = value;
                }
                //记录修改过的字段
                AddUpdatedFld("FLdCaption");
            }
        }
        /// <summary>
        /// 字段类型(说明:;字段类型:varchar;字段长度:2;是否可空:False)
        /// </summary>
        public string FldType
        {
            get
            {
                return mstrFldType;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFldType = value;
                }
                else
                {
                    mstrFldType = value;
                }
                //记录修改过的字段
                AddUpdatedFld("FldType");
            }
        }
        /// <summary>
        /// 字段长度(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// </summary>
        public int FldLength
        {
            get
            {
                return mintFldLength;
            }
            set
            {
                mintFldLength = value;
                //记录修改过的字段
                AddUpdatedFld("FldLength");
            }
        }
        /// <summary>
        /// DefaValue(说明:;字段类型:nvarchar;字段长度:510;是否可空:True)
        /// </summary>
        public string DefaValue
        {
            get
            {
                return mstrDefaValue;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDefaValue = value;
                }
                else
                {
                    mstrDefaValue = value;
                }
                //记录修改过的字段
                AddUpdatedFld("DefaValue");
            }
        }
        /// <summary>
        /// 是否可空(说明:;字段类型:bit;字段长度:1;是否可空:False)
        /// </summary>
        public bool IsNull
        {
            get
            {
                return mbolIsNull;
            }
            set
            {
                mbolIsNull = value;
                //记录修改过的字段
                AddUpdatedFld("IsNull");
            }
        }
        /// <summary>
        /// FldMemo(说明:;字段类型:nvarchar;字段长度:510;是否可空:True)
        /// </summary>
        public string FldMemo
        {
            get
            {
                return mstrFldMemo;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFldMemo = value;
                }
                else
                {
                    mstrFldMemo = value;
                }
                //记录修改过的字段
                AddUpdatedFld("FldMemo");
            }
        }

    }
}