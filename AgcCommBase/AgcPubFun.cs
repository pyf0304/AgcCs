using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AgcCommBase
{
    public class AgcPubFun
    {
        public static int intAdditionalSeed = 1;
        /// <summary>
        /// 获取Swift脚本中的ID，随机生成
        /// </summary>
        /// <returns>获取随机生成的Swift脚本中的ID</returns>
        public static string getSwiftID()
        {

            string str1 = clsString.MakeRandom(3, intAdditionalSeed++);
            string str2 = clsString.MakeRandom(2, intAdditionalSeed++);
            string str3 = clsString.MakeRandom(3, intAdditionalSeed++);
            string strResult = string.Format("{0}-{1}-{2}", str1, str2, str3);
            return strResult;
        }

        /// <summary>
        /// 获取Android脚本中的ID，随机生成
        /// </summary>
        /// <returns>获取随机生成的Android脚本中的ID</returns>
        public static string getAndroidID()
        {

            string str1 = clsString.MakeRandom(3, intAdditionalSeed++);
            string str2 = clsString.MakeRandom(2, intAdditionalSeed++);
            string str3 = clsString.MakeRandom(3, intAdditionalSeed++);
            string strResult = string.Format("{0}-{1}-{2}", str1, str2, str3);
            return strResult;
        }

        /// <summary>
        /// 获取Android脚本中的ID，随机生成
        /// </summary>
        /// <returns>获取随机生成的Android脚本中的ID</returns>
        public static string getASPNETID()
        {

            string str1 = clsString.MakeRandom(3, intAdditionalSeed++);
            string str2 = clsString.MakeRandom(2, intAdditionalSeed++);
            string str3 = clsString.MakeRandom(3, intAdditionalSeed++);
            string strResult = string.Format("{0}-{1}-{2}", str1, str2, str3);
            return strResult;
        }
        /// <summary>
        /// 把其他类型转换成字符串型的相关代码
        /// </summary>
        /// <param name="strDataType"></param>
        /// <param name="strVarName"></param>
        /// <returns></returns>
        public static string getToStringCode4DataType4Java(string strDataType, string strVarName)
        {
            string strNewCode = "";
            switch (strDataType)
            {
                case "float":
                    strNewCode = string.Format("Float.toString({0})", strVarName);
                    break;
                case "double":
                    strNewCode = string.Format("Double.toString({0})", strVarName);
                    break;
                case "int":
                    strNewCode = string.Format("Integer.toString({0})", strVarName);
                    break;
                case "long":
                    strNewCode = string.Format("Long.toString({0})", strVarName);
                    break;
                case "boolean":
                    strNewCode = string.Format("Boolean.toString({0})", strVarName);
                    break;
                case "Date":
                    strNewCode = string.Format("clsDate.DateToStr({0})", strVarName);
                    break;
                    
                case "String":
                    strNewCode = strVarName;
                    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!({1})",
                        strDataType, clsStackTrace.GetCurrClassFunction()));
                    //break;

            }
            return strNewCode;
        }
        /// <summary>
        /// 把字符型转换成其他类型的相关代码
        /// </summary>
        /// <param name="strDataType"></param>
        /// <param name="strSourceExpression"></param>
        /// <returns></returns>
        public static string getStringToOtherTypeCode4DataType4Java(string strDataType, string strSourceExpression)
        {
            string strNewCode = "";
            switch (strDataType)
            {
                case "float":
                    strNewCode = string.Format("Float.valueOf({0})", strSourceExpression);
                    break;
                case "double":
                    strNewCode = string.Format("Double.valueOf({0})", strSourceExpression);
                    break;
                case "int":
                    strNewCode = string.Format("Integer.valueOf({0})", strSourceExpression);
                    break;
                case "long":
                    strNewCode = string.Format("Long.valueOf({0})", strSourceExpression);
                    break;
                case "boolean":
                    strNewCode = string.Format("Boolean.valueOf({0})", strSourceExpression);
                    break;
                case "Date":
                    strNewCode = string.Format("clsDate.StrToDate({0})", strSourceExpression);
                    break;

                case "String":
                    strNewCode = strSourceExpression;
                    break;

                default:
                    throw new Exception(string.Format("类型:{0}不存在,请检查!({1})",
                        strDataType, clsStackTrace.GetCurrClassFunction()));
                    //break;

            }
            return strNewCode;
        }
    }
}
