using System;
using System.Collections.Generic;
using System.Text;
using AGC.DAL;
using AGC.Entity;
using com.taishsoft.common;
using com.taishsoft.datetime;
using AGC.BusinessLogic;

namespace AGC.BusinessLogicEx
{
    public class clsExportExcel4UsersBLEx : clsExportExcel4UsersBL
    {
        public static bool GoTop(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsExportExcel4UsersDAEx().GoTop(arrKeyId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }
        public static bool GoTop(List<string> arrKeyId, string strIdExportExcel4Users)
        {
            try
            {

                bool bolResult = new clsExportExcel4UsersDAEx().GoTop(arrKeyId);
                bolResult = new clsExportExcel4UsersDAEx().ReOrder(strIdExportExcel4Users);

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }
        public static bool GoTop(string strKeyId, string strIdExportExcel4Users)
        {
            try
            {
                List<string> arrKeyId = new List<string>();
                arrKeyId.Add(strKeyId);
                bool bolResult = new clsExportExcel4UsersDAEx().GoTop(arrKeyId);
                bolResult = new clsExportExcel4UsersDAEx().ReOrder(strIdExportExcel4Users);

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }
        public static bool GoBottom(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsExportExcel4UsersDAEx().GoBottom(arrKeyId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }
        public static bool GoBottom(string strKeyId, string strIdExportExcel4Users)
        {
            try
            {
                List<string> arrKeyId = new List<string>();
                arrKeyId.Add(strKeyId);
                bool bolResult = new clsExportExcel4UsersDAEx().GoBottom(arrKeyId);
                bolResult = new clsExportExcel4UsersDAEx().ReOrder(strIdExportExcel4Users);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }

        public static bool GoBottom(List<string> arrKeyId, string strIdExportExcel4Users)
        {
            try
            {

                bool bolResult = new clsExportExcel4UsersDAEx().GoBottom(arrKeyId);
                bolResult = new clsExportExcel4UsersDAEx().ReOrder(strIdExportExcel4Users);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }

        public static bool AdjustSequenceNumber(string strDirect, long lngmId)
        {
            try
            {
                bool bolResult = new clsExportExcel4UsersDAEx().AdjustSequenceNumber(strDirect, lngmId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错！\r\n" + objException.Message);
            }
        }
        public static bool ReOrder(string strIdExportExcel4Users)
        {
            try
            {
                bool bolResult = new clsExportExcel4UsersDAEx().ReOrder(strIdExportExcel4Users);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错！\r\n" + objException.Message);
            }

        }
        public static bool ChangeExportStatus(long lngMid, string strUserId)
        {
            clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN(lngMid);
            clsExportExcel4UsersBL.GetExportExcel4Users(ref objExportExcel4UsersEN);
            objExportExcel4UsersEN.IsExport = !objExportExcel4UsersEN.IsExport;
            objExportExcel4UsersEN.UpdUserId = strUserId;
            objExportExcel4UsersEN.UpdDate = clsDateTime.getTodayStr(0);
            return clsExportExcel4UsersBL.UpdateBySql2(objExportExcel4UsersEN);

        }
    }
}
