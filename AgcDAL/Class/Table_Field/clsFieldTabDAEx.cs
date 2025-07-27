using AGC.Entity;
using com.taishsoft.common;
using System;
using System.Collections.Generic;

namespace AGC.DAL
{
    public class clsFieldTabDAEx : clsFieldTabDA
    {

        public List<clsFieldTabENEx> GetFieldTabENExObjList(string strCondition)
        {
            try
            {
                clsCommonRegular.CheckStrSQL_Weak(strCondition);
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("在输入条件中含有{0}，请检查！", objException.Message));
            }
            List<clsFieldTabEN> arrObjList = GetObjLst(strCondition);
            List<clsFieldTabENEx> arrObjExList = new List<clsFieldTabENEx>();
            foreach (clsFieldTabEN objFieldTabEN in arrObjList)
            {
                clsFieldTabENEx objFieldTabENEx = new clsFieldTabENEx();
                CopyTo(objFieldTabEN, objFieldTabENEx);
              
                //clsFieldTabENEx objFieldTabENEx =objFieldTabEN as  clsFieldTabENEx;

                arrObjExList.Add(objFieldTabENEx);
            }
            return arrObjExList;
        }

        public void CopyTo(clsFieldTabEN objFieldTabENS, clsFieldTabENEx objFieldTabENT)
        {
            objFieldTabENT.FldId = objFieldTabENS.FldId; //字段ID
            objFieldTabENT.PrjId = objFieldTabENS.PrjId; //工程ID
            objFieldTabENT.FldName = objFieldTabENS.FldName; //字段名
            objFieldTabENT.DataTypeId = objFieldTabENS.DataTypeId; //字段类型
            objFieldTabENT.FldLength = objFieldTabENS.FldLength; //字段长度
            objFieldTabENT.Caption = objFieldTabENS.Caption; //标题
            objFieldTabENT.FldInfo = objFieldTabENS.FldInfo; //字段信息
            objFieldTabENT.IsNull = objFieldTabENS.IsNull; //是否可空
            objFieldTabENT.IsPrimaryKey = objFieldTabENS.IsPrimaryKey; //是否主键
            objFieldTabENT.IsIdentity = objFieldTabENS.IsIdentity; //是否Identity
            objFieldTabENT.IsChecked = objFieldTabENS.IsChecked; //是否核实
            objFieldTabENT.IsArchive = objFieldTabENS.IsArchive; //是否存档
            objFieldTabENT.IsOnlyOne = objFieldTabENS.IsOnlyOne; //是否唯一
            objFieldTabENT.MaxValue = objFieldTabENS.MaxValue; //最大值
            objFieldTabENT.MinValue = objFieldTabENS.MinValue; //最小值
            objFieldTabENT.DefaultValue = objFieldTabENS.DefaultValue; //缺省值
            //objFieldTabENT.IsNeedTransCode = objFieldTabENS.IsNeedTransCode; //是否需要转换代码
            //objFieldTabENT.CodeTabId = objFieldTabENS.CodeTabId; //代码表
            //objFieldTabENT.CodeTabNameId = objFieldTabENS.CodeTabNameId; //代码表_名称
            //objFieldTabENT.CodeTabCodeId = objFieldTabENS.CodeTabCodeId; //代码表_代码
            objFieldTabENT.UpdUser = objFieldTabENS.UpdUser; //用户ID
            objFieldTabENT.FldStateId = objFieldTabENS.FldStateId; //字段状态Id
            objFieldTabENT.UpdDate = objFieldTabENS.UpdDate; //修改日期
            objFieldTabENT.FldPrecision = objFieldTabENS.FldPrecision; //精确度
            objFieldTabENT.Memo = objFieldTabENS.Memo; //说明
        }

    }
}
