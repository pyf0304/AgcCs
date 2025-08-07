
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvPrjTab_SimENEx
表名:vPrjTab_Sim(00050597)
生成代码版本:2021.11.29.1
生成日期:2021/11/30 00:09:17
生成者:pyf
生成服务器IP:103.116.76.183
工程名称:AGC(0005)
CM工程:AgcSpa后端(变量首字母不限定)
相关数据库:103.116.76.183,9433AGC_CS12
PrjDataBaseId:0005
模块中文名:字段、表维护(Table_Field)
框架-层名:实体扩展层(EntityLayerEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace AGC.Entity
{
    /// <summary>
    /// v工程表_Sim(vPrjTab_Sim)
    /// (AutoGCLib.EntityLayerEx4CSharp:GeneCode)
    /// </summary>
    [Serializable]
    public class clsvPrjTab_SimENEx : clsvPrjTab_SimEN
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4CSharp:Gen_ENEx_ClassConstructor1)
        /// </summary>
        public clsvPrjTab_SimENEx()
        {
        }

        public clsProjectsEN objProjectsEN = null;
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


        public clsFuncModule_AgcEN ObjFuncModule { get; set; }
        public string PrjInnerFileName { get; set; }
        public string FullFileName { get; set; }

        public string FuncId4GC { get; set; }
        public string SuffixPath { get; set; }

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

        private string mstrTabSpace;

        public string TabSpace
        {
            get { return mstrTabSpace; }
            set { mstrTabSpace = value; }
        }
    }
}