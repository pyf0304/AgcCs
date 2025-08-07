using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.taishsoft.commdb;
using AGC.Entity;

using com.taishsoft.common;
using AGC.DAL;

namespace AGC.DAL
{
    public class clsPrjTabDAEx : clsPrjTabDA
    {
        /// <summary>
        /// 获取当前关键字的记录对象,用对象的形式表示.
        /// </summary>
        /// <param name="objPrjTabEN">需要添加到数据库中的对象</param>
        /// <returns>是否成功</returns>
        public bool GetPrjTabEx(ref clsPrjTabENEx objPrjTabEN)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPrjTabDA.GetSpecSQLObj();
            strSQL = "Select * from PrjTab where TabId=" + "'" + objPrjTabEN.TabId + "'";
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            objPrjTabEN.TabId = objDT.Rows[0]["TabId"].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
            objPrjTabEN.TabName = objDT.Rows[0]["TabName"].ToString().Trim(); //表名(字段类型:varchar,字段长度:50,是否可空:False)
            objPrjTabEN.TabCnName = objDT.Rows[0]["TabCnName"].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:40,是否可空:True)
            objPrjTabEN.PrjId = objDT.Rows[0]["PrjId"].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
            //objPrjTabEN.ObjId = objDT.Rows[0]["ObjId"].ToString().Trim(); //所属对象(字段类型:char,字段长度:8,是否可空:False)
            objPrjTabEN.IsNeedTransCode = TransNullToBool(objDT.Rows[0]["IsNeedTransCode"].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
            objPrjTabEN.SqlDsTypeId = objDT.Rows[0]["SqlDsTypeId"].ToString().Trim(); //数据源类型(字段类型:char,字段长度:2,是否可空:False)
            objPrjTabEN.TabStateId = objDT.Rows[0]["TabStateId"].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
            objPrjTabEN.TabNameB = objDT.Rows[0]["TabNameB"].ToString().Trim(); //表名_后备(字段类型:varchar,字段长度:50,是否可空:True)
            objPrjTabEN.IsParaTab = TransNullToBool(objDT.Rows[0]["IsParaTab"].ToString().Trim()); //是否参数表(字段类型:bit,字段长度:1,是否可空:True)
            objPrjTabEN.IsNationStandard = TransNullToBool(objDT.Rows[0]["IsNationStandard"].ToString().Trim()); //是否国标(字段类型:bit,字段长度:1,是否可空:True)
            objPrjTabEN.IsArchive = TransNullToBool(objDT.Rows[0]["IsArchive"].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
            objPrjTabEN.IsChecked = TransNullToBool(objDT.Rows[0]["IsChecked"].ToString().Trim()); //是否核实(字段类型:bit,字段长度:1,是否可空:True)
            objPrjTabEN.IsNeedGeneIndexer = TransNullToBool(objDT.Rows[0]["IsNeedGeneIndexer"].ToString().Trim()); //是否核实(字段类型:bit,字段长度:1,是否可空:True)
            //objPrjTabEN.ErrMsg = objDT.Rows[0]["ErrMsg"].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:1000,是否可空:True)
            objPrjTabEN.FuncModuleAgcId = objDT.Rows[0]["FuncModuleAgcId"].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
            objPrjTabEN.DataBaseName = objDT.Rows[0]["DataBaseName"].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
            objPrjTabEN.Owner = objDT.Rows[0]["Owner"].ToString().Trim(); //拥有者(字段类型:varchar,字段长度:50,是否可空:False)
            objPrjTabEN.RelaTabId4View = objDT.Rows[0]["RelaTabId4View"].ToString().Trim(); //相关视图ID(字段类型:char,字段长度:8,是否可空:False)
            objPrjTabEN.UpdUserId = objDT.Rows[0]["UpdUserId"].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
            objPrjTabEN.UpdDate = objDT.Rows[0]["UpdDate"].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
            //objPrjTabEN.GeneCodeDate = objDT.Rows[0]["GeneCodeDate"].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
            objPrjTabEN.TabTypeId = objDT.Rows[0]["TabTypeId"].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
            objPrjTabEN.Memo = objDT.Rows[0]["Memo"].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
            objDT = null;
            return true;
        }
        /// <summary>
        /// 根据条件获取一定范围数据表，用DataTable表示，同时检查是否含有SQL攻击-弱检查
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <param name="lngMinNum">范围之最小值</param>
        /// <param name="lngMaxNum">范围之最大值</param>
        /// <returns>返回数据表DataTable</returns>
        public static System.Data.DataTable GetPrjTabByRange(string strCondition, long lngMinNum, long lngMaxNum)
        {
            if (lngMinNum <= 0)
            {
                throw new Exception(string.Format("在输入范围的最小值{0}非法，应该不小于0，请检查！(clsPrjTabDA: GetPrjTabByRange)", lngMinNum));
            }
            if (lngMaxNum > 6553005)
            {
                throw new Exception(string.Format("在输入范围的最大值{0}非法，应该不大于6553005(可以用其他条件来限制记录的条数)，请检查！(clsPrjTabDA: GetPrjTabByRange)", lngMaxNum));
            }
            if (lngMaxNum <= lngMinNum)
            {
                throw new Exception(string.Format("在输入范围的最大值[{0}]不能小于最小值[{1}],非法，请检查！(clsPrjTabDA: GetPrjTabByRange)", lngMaxNum, lngMinNum));
            }
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0}，请检查！(clsPrjTabDA: GetPrjTabByRange)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsPrjTabDA.GetSpecSQLObj();
            strSQL = string.Format("Select top {1} * from PrjTab a where {0} And a.TabId not in (Select Top {2} TabId From PrjTab Where {0})", strCondition, lngMaxNum - lngMinNum, lngMinNum - 1);
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }
    }
}
