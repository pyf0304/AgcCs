using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGC.BusinessLogicEx
{
    public class conErrType{
        public conErrType(){}
        public static string QryRegion = "查询区错误";
        public static string EditRegion = "编辑区错误";
        public static string DetailRegion = "详细区错误";
        public static string ExcelExportRegion = "Excel导出区错误";
        public static string FeatureRegion = "功能区错误";
        public static string ListRegion = "列表区错误";
        public static string TabField = "表字段错误";

    }
    public class clsErrMsgENEx
    {
        public string ErrType { get; set; }
        public int ErrNum { get; set; }
        public override string ToString()
        {
            if (string.IsNullOrEmpty(ErrType) == true) return "";
            if (ErrNum == 0) return "";
            return ErrType + ": " + ErrNum.ToString();
        }
        public clsErrMsgENEx(string strErrMsg)
        {
            var arr = strErrMsg.Split(':');
            if (arr.Length == 0) throw new Exception("错误信息不能为空！");
            if (arr.Length >= 1)
            {
                ErrType = arr[0];
            }
            if (arr.Length >= 2)
            {
                try
                {
                    ErrNum = int.Parse(arr[1]);
                }
                catch
                {
                    ErrNum = 0;
                }
            }
        }
        public clsErrMsgENEx(string strErrType, int intErrNum)
        {
            ErrType = strErrType;
            ErrNum = intErrNum;
        }
    }
    public class clsErrMsgBLEx
    {
        public static List<clsErrMsgENEx> GetErrMsgObjLstByErrMsg(string strErrMsgLst)
        {
            List<clsErrMsgENEx> arrErrMsg = new List<clsErrMsgENEx>();
            if (strErrMsgLst == null) return arrErrMsg;
            var arrErrMsgLst = strErrMsgLst.Split(';');
            if (arrErrMsgLst.Length == 0) return arrErrMsg;
            foreach(string strErrMsg in arrErrMsgLst)
            {
                var objErrMsg = new clsErrMsgENEx(strErrMsg);
                if (objErrMsg != null) arrErrMsg.Add(objErrMsg);
            }
            return arrErrMsg;
        }
        public static string GetErrMsgByObjLst(List<clsErrMsgENEx> arrErrMsg)
        {         
            var arrErrMsgLst = arrErrMsg.Select(x=>x.ToString());
            string strErrMsgLst = string.Join(";", arrErrMsgLst);
            return strErrMsgLst;
        }

        public static bool AddObj(List<clsErrMsgENEx> arrErrMsg, clsErrMsgENEx objErrMsg_New)
        {
            if (arrErrMsg.Count(x=>x.ErrType == objErrMsg_New.ErrType) == 0)
            {
                arrErrMsg.Add(objErrMsg_New);
                return true;
            }
            var arrErrMsg_Del = arrErrMsg.Where(x => x.ErrType == objErrMsg_New.ErrType).ToList();
            arrErrMsg_Del.Add(objErrMsg_New);
            return true;
        }
    }
}
