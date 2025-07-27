using AGC.BusinessLogic;
using AGC.DAL;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGC.BusinessLogicEx
{
    public partial class clsPrjFeatureBLEx:clsPrjFeatureBL
    {
       
        /// <summary>
        /// 把一组记录移到最顶部
        /// </summary>
        /// <param name="arrKeyId">一组记录（关键字列表）</param>
        /// <returns></returns>
        public static bool GoTop(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsPrjFeatureDAEx().GoTop(arrKeyId);
                bolResult = new clsPrjFeatureDAEx().ReOrder();

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 把当前记录移到最顶部，第一条
        /// </summary>
        /// <param name="strKeyId">需要移动的记录（关键字）</param>
        /// <returns></returns>
        public static bool GoTop(string strKeyId)
        {
            try
            {
                List<string> arrKeyId = new List<string>();
                arrKeyId.Add(strKeyId);
                bool bolResult = new clsPrjFeatureDAEx().GoTop(arrKeyId);
                bolResult = new clsPrjFeatureDAEx().ReOrder();

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置顶出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 把一组记录移到最后
        /// </summary>
        /// <param name="arrKeyId">一组记录（关键字列表）</param>
        /// <returns></returns>
        public static bool GoBottom(List<string> arrKeyId)
        {
            try
            {
                bool bolResult = new clsPrjFeatureDAEx().GoBottom(arrKeyId);
                bolResult = new clsPrjFeatureDAEx().ReOrder();

                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 把当前记录移到最后一条
        /// </summary>
        /// <param name="strKeyId">需要移动的记录（关键字）</param>
        /// <returns></returns>
        public static bool GoBottom(string strKeyId)
        {
            try
            {
                List<string> arrKeyId = new List<string>();
                arrKeyId.Add(strKeyId);
                bool bolResult = new clsPrjFeatureDAEx().GoBottom(arrKeyId);
                bolResult = new clsPrjFeatureDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("置底出错！\r\n" + objException.Message);
            }
        }

        /// <summary>
        /// 调整次序
        /// </summary>
        /// <param name="strDirect">方向</param>
        /// <param name="strPrjFeatureId">需要调整的记录关键字(部门Id)</param>
        /// <returns></returns>
        public static bool AdjustSequenceNumber(string strDirect, string strPrjFeatureId)
        {
            try
            {
                bool bolResult = new clsPrjFeatureDAEx().AdjustSequenceNumber(strDirect, strPrjFeatureId);
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("调整记录次序出错！\r\n" + objException.Message);
            }
        }
        /// <summary>
        /// 重序
        /// </summary>
        /// <returns></returns>
        public static bool ReOrder()
        {
            try
            {
                bool bolResult = new clsPrjFeatureDAEx().ReOrder();
                return bolResult;
            }
            catch (Exception objException)
            {
                throw new Exception("重新调整所有记录次序出错！\r\n" + objException.Message);
            }

        }

    }
}
