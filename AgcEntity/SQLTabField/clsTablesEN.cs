
///----------------------
///生成代码版本：2012.11.9.1
///生成日期：2012/11/20
///生成者：潘以锋
///工程名称：AGC
///工程ID：0005
///模块中文名：SQL表字段管理
///模块英文名：SQLTabField
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
    /// SQL表(Tables)
    /// </summary>
    [Serializable]
    public class clsTablesEN : clsEntityBase2
    {
        public const string CurrTabName_S = "Tables"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "TabName"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 4;
        public static string[] AttributeName = new string[] { "TabName", "ColumnsNum", "DataBaseName", "PrjId" };
        //以下是属性变量


        /// <summary> 
        /// 表名(字段类型:varchar,字段长度:60,是否可空:False)
        /// </summary>
        protected string mstrTabName;

        /// <summary> 
        /// 字段数(字段类型:int,字段长度:4,是否可空:False)
        /// </summary>
        protected int mintColumnsNum;

        /// <summary> 
        /// 数据库名(字段类型:varchar,字段长度:50,是否可空:False)
        /// </summary>
        protected string mstrDataBaseName;

        /// <summary> 
        /// 工程ID(字段类型:char,字段长度:4,是否可空:False)
        /// </summary>
        protected string mstrPrjId;

        public clsTablesEN()
        {
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "Tables";
            lstKeyFldNames.Add("TabName");
        }

        public clsTablesEN(string strTabName)
        {
            if (string.IsNullOrEmpty(strTabName) == true)
            {
                throw new Exception("关键字不能为空或null！");
            }

            mstrTabName = strTabName;
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "Tables";
            lstKeyFldNames.Add("TabName");
        }

        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;
            }
        }
        public new object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == "TabName")
                {
                    return mstrTabName;
                }
                else if (strAttributeName == "ColumnsNum")
                {
                    return mintColumnsNum;
                }
                else if (strAttributeName == "DataBaseName")
                {
                    return mstrDataBaseName;
                }
                else if (strAttributeName == "PrjId")
                {
                    return mstrPrjId;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "TabName")
                {
                    mstrTabName = value.ToString();
                }
                else if (strAttributeName == "ColumnsNum")
                {
                    mintColumnsNum = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "DataBaseName")
                {
                    mstrDataBaseName = value.ToString();
                }
                else if (strAttributeName == "PrjId")
                {
                    mstrPrjId = value.ToString();
                }
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if ("TabName" == AttributeName[intIndex])
                {
                    return mstrTabName;
                }
                else if ("ColumnsNum" == AttributeName[intIndex])
                {
                    return mintColumnsNum;
                }
                else if ("DataBaseName" == AttributeName[intIndex])
                {
                    return mstrDataBaseName;
                }
                else if ("PrjId" == AttributeName[intIndex])
                {
                    return mstrPrjId;
                }
                return null;
            }
            set
            {
                if ("TabName" == AttributeName[intIndex])
                {
                    mstrTabName = value.ToString();
                }
                else if ("ColumnsNum" == AttributeName[intIndex])
                {
                    mintColumnsNum = TransNullToInt(value.ToString());
                }
                else if ("DataBaseName" == AttributeName[intIndex])
                {
                    mstrDataBaseName = value.ToString();
                }
                else if ("PrjId" == AttributeName[intIndex])
                {
                    mstrPrjId = value.ToString();
                }
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
        /// 字段数(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// </summary>
        public int ColumnsNum
        {
            get
            {
                return mintColumnsNum;
            }
            set
            {
                mintColumnsNum = value;
                //记录修改过的字段
                AddUpdatedFld("ColumnsNum");
            }
        }
        /// <summary>
        /// 数据库名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
        /// </summary>
        public string DataBaseName
        {
            get
            {
                return mstrDataBaseName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDataBaseName = value;
                }
                else
                {
                    mstrDataBaseName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("DataBaseName");
            }
        }
        /// <summary>
        /// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
        /// </summary>
        public string PrjId
        {
            get
            {
                return mstrPrjId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPrjId = value;
                }
                else
                {
                    mstrPrjId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("PrjId");
            }
        }
    }
}