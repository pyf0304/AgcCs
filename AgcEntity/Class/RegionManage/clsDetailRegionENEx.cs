
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsDetailRegionENEx
表名:DetailRegion(00050543)
生成代码版本:2020.05.24.1
生成日期:2020/05/26 02:27:30
生成者:
生成服务器IP:192.168.1.10
工程名称:AGC
工程ID:0005
相关数据库:tzar.tpddns.cn,19433AGC_CS12
PrjDataBaseId:0213
模块中文名:区域管理
模块英文名:RegionManage
框架-层名:实体扩展层(EntityLayerEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace AGC.Entity
{
    /// <summary>
    /// 详细信息区域(DetailRegion)
    /// (AutoGCLib.EntityLayerEx4CSharp:GeneCode)
    /// </summary>
    [Serializable]
    public class clsDetailRegionENEx : clsDetailRegionEN
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4CSharp:Gen_ENEx_ClassConstructor1)
        /// </summary>
        public clsDetailRegionENEx()
        {
        }

        public clsViewRegionEN objViewRegionEN = null;

        public clsDetailRegionENEx(long lngRegionId) : base(lngRegionId)
        {

        }
        private int mintFieldNum;	//字段数

        public int FieldNum
        {
            get { return mintFieldNum; }
            set { mintFieldNum = value; }
        }
    }
}