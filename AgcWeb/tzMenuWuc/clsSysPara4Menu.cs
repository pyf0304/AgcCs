using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGC.web.menu
{
    /// <summary>
    /// clsSysPara4Ctrl 的摘要说明。
    /// </summary>
    public class clsSysPara4Menu
    {
        public static string strXMLFolder = @"\SchoolOfficeSys\XML\";
        public static string ConfigFileName;
        //临时文件目录FOR WEB
        public static string TempWebFolder = @"\SchoolOfficeSys\TempFiles\";
        public static string TempFileFolder;    //临时文件物理目录
        public static string FileSvrFileName;
        public static string CurrYear;  //当前学年
        public static string CurrTerm;  //当前学期
        public static string strUserId = "Sandy";       //当前登录的用户
        public static string strUserIp;     //当前登录的用户IP
        public static string strUserStateId;        //当前登录用户的状态ID
        public static string strDepartmentId;		//当前登录用户的部门ID
        public static bool bolIsNotShowGradeWithoutGraduate = false;	//是否不显示已经毕业的年级
        public static bool bolIsHaveClgCondition = false;	//是否有学院条件
        public static bool bolIsAddCollegeCode = false;	//是否加学院代码
        public static bool bolIsShowEmptyNode = true;	//是否显示空的子结点
        public static bool bolIsShowUniversityCourse = true;//是否显示校级课程

        public static string strId_College = "";
        public static string strCollegeCondition = "";//学院条件串
        public clsSysPara4Menu()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
    }
}