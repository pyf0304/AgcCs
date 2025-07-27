using com.taishsoft.common;
using CommFunc4WebForm;
using AGC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using com.taishsoft.web;
using AGC.Webform;
using com.taishsoft.web.treeview;

using com.taishsoft.util;

namespace AGC.web.treeview
{
    /// <summary>
    /// 树模式
    /// </summary>
    public enum TreeModel
    {
        NULL,
        /// <summary>
        /// 课程类型
		/// </summary>
        ApplicationType_CodeType_PrjFeature_Function4GeneCode4View,
        /// <summary>
        /// 课程类型--课程系列
        /// </summary>
		COURSETYPE,       //课程类型--课程系列

        /// <summary>
        /// 课程管理类型_学院_课程类型
        /// </summary>
        COLLEGE_COURSETYPE,
        /// <summary>
        /// 学院--年级
        /// </summary>
        COLLEGE_GRADE,	//学院--年级
        /// <summary>
        /// 学院--年级--专业--教学计划
        /// </summary>
        COLLEGE_GRADEBASE_MAJOR,    //学院--年级--专业--教学计划

        /// <summary>
        /// 学院--专业--年级--教学计划
        /// </summary>
        COLLEGE_MAJOR_GRADEBASE,   //学院--专业--年级--教学计划

        /// <summary>
        /// 学院-排考考试组
        /// </summary>
        COLLEGE,          //学院-排考考试组

        /// <summary>
        /// 学院--用户
        /// </summary>
        COLLEGE_USER,	                    //学院--用户
        /// <summary>
        /// 年级--学院--专业
        /// </summary>
        GRADEBASE_COLLEGE_MAJOR,                //年级--学院--专业

        /// <summary>
        /// 年级--学院--专业二专
        /// </summary>
        GRADE_COLLEGE,        //年级--学院--专业二专

        /// <summary>
        /// 年级--专业--学生类型
        /// </summary>
        GRADEBASE_MAJOR,    //年级--专业--学生类型

        /// <summary>
        /// 年级--学制学生类型--学院--专业
        /// </summary>
        GRADE_COLLEGE_MAJOR,	//年级--学制学生类型--学院--专业
        /// <summary>
        /// 年级--学院--校区
        /// </summary>
        GRADEBASE_COLLEGE_UNIZONE,				//年级--学院--校区
        /// <summary>
        /// 年级--校区--学院
        /// </summary>
        GRADEBASE_UNIZONE_COLLEGE,				//年级--校区--学院
        /// <summary>
        /// 权限类型
        /// </summary>
        RIGHTTYPE,				            //权限类型
        /// <summary>
        /// 权限类型--权限
        /// </summary>
        RIGHTTYPE_RIGHT,				    //权限类型--权限
        /// <summary>
        /// 角色
        /// </summary>
        ROLE,				                //角色
        /// <summary>
        /// 角色-用户
        /// </summary>
        ROLE_USER,				            //角色-用户
        /// <summary>
        /// 学校
        /// </summary>
        PrjFeature,
        /// <summary>
        /// 约束类型-约束
        /// </summary>
        ConstraintType_PrjConstraint,
        /// <summary>
        /// 功能类型-功能
        /// </summary>
        PrjFeatureType_PrjFeature,
        PrjFeatureType,

        /// <summary>
        /// 功能类型-功能-函数
        /// </summary>
        PrjFeatureType_PrjFeature_Function4GeneCode,
        CodeType_PrjFeature_Function4GeneCode,
        /// <summary>
        /// 学校-学院
        /// </summary>
        PrjFeature_Function4Code,                //学校-学院

        /// <summary>
        /// 学校-学院
        /// </summary>
        PrjFeature_Function4CodeByAppId,                //学校-学院

        ApplicationType_CodeType_CMClass,
        ApplicationType_CodeType_NameSpace_CMClass,

        ApplicationType_CMProject_FuncModule_Agc4Requirement,
        ApplicationType_CMProject_FuncModule_Agc4Feature,
        ApplicationType_CMProject_FuncModule_PrjTab,
        ApplicationType_CMProject_FuncModule,

        PrjFeature_Function4GeneCodeByAppId,
        /// <summary>
        /// 学校-课程-年级-批次-成绩统计模式
        /// </summary>
        ApplicationType_CodeType,         //学校-成绩统计模式

        ApplicationType_CodeTypeByProgLangTypeId,         //应用-代码类型By语言

        /// <summary>
        /// 学校-课程-年级-成绩统计模式-批次
        /// </summary>
        ViewInfo_PrjFeature_Function4Code,         //学校-课程-年级-成绩统计模式-批次

        /// <summary>
        /// 学校-课程-年级-成绩统计模式-批次
        /// </summary>
        ViewInfo_PrjFeature_Function4GeneCode,         //学校-课程-年级-成绩统计模式-批次

        /// <summary>
        /// 学校-年级-成绩统计模式-课程-批次
        /// </summary>
        ProgLangType_CodeType,         //学校-课程-年级-成绩统计模式-批次

        ///// <summary>
        ///// 年级-课程-批次
        ///// </summary>
        //ApplicationType_CodeType,         //年级-课程-批次

        /// <summary>
        /// 年级-课程-批次
        /// </summary>
        ApplicationType_CodeType_Function4GeneCode,
        ApplicationType_CodeType_ClassName_Function4GeneCode,

        /// <summary>
        /// 年级-课程-批次
        /// </summary>
        ApplicationType_CodeType_Function4GeneCode4View,

        /// <summary>
        /// 年级-课程-批次
        /// </summary>
        FuncModule_Agc_PrjTab,
        /// <summary>
        /// 模块-表-类名-函数名
        /// </summary>
        FuncModule_Agc_PrjTab_ClassName_FuncName,

        /// <summary>
        /// 模块-表-区域名
        /// </summary>
        FuncModule_Agc_PrjTab_ViewRegion,
        /// <summary>
        /// 表-区域名
        /// </summary>
        PrjTab_ViewRegion,


        /// <summary>
        /// 模块-表-区域名
        /// </summary>
        FuncModule_Agc_ViewInfo_ViewRegion,

        /// <summary>
        /// 功能-表功能
        /// </summary>
        PrjFeature_TabFeature,
        /// <summary>
        /// 界面分区-功能
        /// </summary>
        ViewRegion_PrjFeature,

        /// <summary>
        /// 分区-界面功能
        /// </summary>
        ViewRegion_ViewFeature,
        
        /// <summary>
        /// 界面区域
        /// </summary>
        ViewRegion,



        /// <summary>
        /// 年级-课程-批次
        /// </summary>
        FuncModule_Agc_ViewInfo,

        ///// <summary>
        ///// 年级-课程-批次
        ///// </summary>
        //ApplicationType_CodeType_Function4GeneCode,
        /// <summary>
        /// 年级-成绩性质-统计批次
        /// </summary>
        Grade_CjScoreKind_ExamStatsBatch,         //年级-成绩性质-统计批次

        /// <summary>
        /// 年级-成绩性质-统计批次-行政班
        /// </summary>
        Grade_CjScoreKind_ExamStatsBatch_XzAdminCls,         //年级-成绩性质-统计批次-行政班



        /// <summary>
        /// 学校-校区-学院-年级-专业-行政班
        /// </summary>
        ApplicationType_CodeType__MAJOR_ADMINCLS,    //学校-校区-学院-年级-专业-行政班

        /// <summary>
        /// 学校-校区-年级-学院-专业
        /// </summary>
        ApplicationType_CodeType_MAJOR,     //学校-校区-年级-学院-专业
                                            /// <summary>
                                            /// 学校-校区-年级-学院-专业-行政班
                                            /// </summary>
        ApplicationType_CodeType_MAJOR_ADMINCLS,    //学校-校区-年级-学院-专业-行政班

        /// <summary>
        /// 校区-学院-课程类型-选课教学班
        /// </summary>
        UNIZONE_COLLEGE_COURSETYPE,  //校区-学院-课程类型-选课教学班
                                     /// <summary>
                                     /// 校区-学院-课程类型-选课教学班
                                     /// </summary>
        UNIZONE_COLLEGE_COURSETYPE_CURREDUCLASS,	//校区-学院-课程类型-选课教学班
        /// <summary>
        /// 校区-学院-专业-年级
        /// </summary>
        UNIZONE_COLLEGE_MAJOR_GRADE,			//校区-学院-专业-年级
        /// <summary>
        /// 校区-学院-排考考试组
        /// </summary>
        UNIZONE_COLLEGE,			//校区-学院-排考考试组
        /// <summary>
        /// 校区-教学楼
        /// </summary>
        UNIZONE_BUILD,                          //校区-教学楼
                                                /// <summary>
                                                /// XLS数据导入表
                                                /// </summary>
        XLSDATAIMPORTTAB        //XLS数据导入表

    };
    //public enum TreeNodeType
    //{
    //    NULL,       //不能确定的结点类型
    //    PrjFeature,     //学校
    //    COLLEGE,    //学院
    //    MAJOR,      //专业
    //    SUBJECTDIRECTION,		//学科方向
    //    EXAMBATCH,      //考试批次
    //    EXAMSTATSBATCH, //考试统计批次
    //    GRADE,      //年级
    //    GRADEBASE,      //年级(入学)
    //    MAJORGRADE, //专业年级
    //    ADMINCLS,   //行政班
    //    COURSE, //课程
    //    COURSETYPE, //课程类型
    //    CJSTATSMODE, //成绩统计方式
    //    CURREDUCLASS,   //当前教学班
    //    COURSETYPEADMINTYPE, //课程类型管理类型
    //    STUDENTTYPE, //学生类型
    //    PKAOEXAMGROUP, //排考考试组
    //    BUILD,      //教学楼
    //    TEACHPLANPlanTEMPLETE,      //教学计划模板
    //    JXTPXXTEMPLETE,             //教学计划选修模板
    //    COLLECT,        //教学班集合
    //    XKEDUCLASS,     //选课教学班
    //    TEACHINGPLAN,   //教学计划
    //    JXTEACHPLANSERIES,  //教学计划课程系列
    //    JXSERIESGROUP,      //教学计划系列组
    //    JXSERGROUPREQMODE,  //教学计划系列组模式
    //    PKSCHEGROUP,    //排课组
    //    UNIZONE,		//校区
    //    XLSIMPORTTAB,		//XLS导入表
    //    ROLE,   		//角色
    //    USER,	    	//用户
    //    RIGHTTYPE,	    	//权限类型
    //    RIGHT,	    	//权限
    //    AUSER           //用户

    //};

    public delegate void AfterSelect_Tz(object sender, clsEventArgs4TreeView e);
    /// <summary>
    /// myTreeView 的摘要说明。
    /// </summary>

    [Serializable]
    public class TreeNodeData
    {
        private string mstrErrMsg = "";

        //private string mstrTabId = "";
        private string mstrCodeTypeId = "";
        private string mstrDepartmentId = "";

        private string mstrMenuId_Up = "";
        private string mstrMenuId_Sub = "";
        private string mstrMenuId_Leaf = "";

        private string mstrCodeTypeIdGrade = "";
        private string mstrRoleId = "";
        private string mstrGroupId = "";

        private string mstrPotenceTypeId = "";

        private string mstrPotenceId = "";
        private string mstrUserId = "";

        private string mstrQxPrjId = "";
        private string mstrMenuSetId = "";
        private string mstrProgLangTypeId = "";

        private string mstrCodeTypeIdAdminType = "";
        private string mstrid = "";
        private string mstrId_UniZone = "";
        private string mstrId_Build = "";
        private string mstrid_TpTemplet = "";
        private string mstrid_TpXxTemplet = "";     //选修课模式ID
        private string mstrid_EduClsCollect = "";   //教学班集合ID
        private string mstrid_xkEduCls = "";    //选课教学班ID
        private string mstrid_EduClass = "";    //选课教学班ID
        private string mstrid_TeachPlanSeries = ""; //教学计划课程系列ID
        private string mstrid_SeriesGroup = "";	//教学计划系列组ID
        private string mstrid_GroupReqMode = "";	//教学计划系列组模式ID
        private string mstrid_Role = "";	//角色ID
        private string mstrIdUser = "";	//用户ID
        private string mstrid_RightType = "";	//权限类型ID
        private string mstrid_Right = "";	//权限ID
        private string mstrCollegeCondition = "";   //学院条件串

        private string mstrFuncId4Code = "";
        private string mstrFuncModuleAgcId = "";
        private string mstrFuncId4GC = "";
        private string mstrFeatureId = "";
        private string mstrStatsModeId = "";
        private string mstrExamStatsBatchId = "";

        private string mstrId_Course = "";
        private string mstrExamBatchId = "";
        private string mstrExamDate = "";

        private string mstrId_Grade = "";
        private string mstrApplicationTypeId = "";

        /// <summary>
        /// 学院条件串
        /// </summary>
        public string CollegeCondition
        {
            get { return mstrCollegeCondition; }
            set { clsSysPara4TreeView.strCollegeCondition = value; }
        }


        protected string mstrid_Tab;            //XLS导入表ID

        protected string mstrid_PkScheGroup;        //排课组ID
        protected string mstrViewId;

        /// <summary>
        /// 教学计划流水号
        /// </summary>
        public string ViewId
        {
            get
            {
                //conViewInfo.ViewId
                return mstrViewId;
            }
            set
            {
                if (value == "")
                {
                    mstrViewId = value;
                }
                else
                {
                    mstrViewId = value;
                }
            }
        }


        /// <summary>
        /// 表Id
        /// </summary>
        public string TabId { get; set; }
        public string ConstraintTypeId { get; set; }
        public string PrjConstraintId { get; set; }
        public string PrjFeatureTypeId { get; set; }
        public string TabFeatureId { get; set; }
        public string CmFeatureId { get; set; }

        public string CmPrjId { get; set; }


        /// <summary>
        /// 部门Id
        /// </summary>
        public string DepartmentId
        {
            get
            {

                return mstrDepartmentId;
            }
            set
            {
                mstrDepartmentId = value;
            }
        }

        /// <summary>
        /// 专业流水号
        /// </summary>
        public string CodeTypeId
        {
            get
            {
                //conCodeType.CodeTypeId
                return mstrCodeTypeId;
            }
            set
            {
                mstrCodeTypeId = value;
            }
        }
        /// <summary>
        /// 顶层菜单Id
        /// </summary>
        public string MenuId_Up
        {
            get
            {
                return mstrMenuId_Up;
            }
            set
            {
                mstrMenuId_Up = value;
            }
        }

        /// <summary>
        /// 顶层菜单Id
        /// </summary>
        public string MenuId_Leaf
        {
            get
            {
                return mstrMenuId_Leaf;
            }
            set
            {
                mstrMenuId_Leaf = value;
            }
        }
        /// <summary>
        ///子菜单Id
        /// </summary>
        public string MenuId_Sub
        {
            get
            {
                return mstrMenuId_Sub;
            }
            set
            {
                mstrMenuId_Sub = value;
            }
        }
        /// <summary>
        /// 角色Id
        /// </summary>
        public string RoleId
        {
            get
            {
                return mstrRoleId;
            }
            set
            {
                mstrRoleId = value;
            }
        }

        /// <summary>
        /// 组Id
        /// </summary>
        public string GroupId
        {
            get
            {
                return mstrGroupId;
            }
            set
            {
                mstrGroupId = value;
            }
        }
        /// <summary>
        /// 	考试统计批次ID
        /// </summary>
        public string PotenceTypeId
        {
            get
            {
                return mstrPotenceTypeId;
            }
            set
            {
                mstrPotenceTypeId = value;
            }
        }
        /// <summary>
        /// 课程流水号Id
        /// </summary>
        public string PotenceId
        {
            get
            {
                return mstrPotenceId;
            }
            set
            {
                mstrPotenceId = value;
            }
        }

        /// <summary>
        /// 统计方式Id
        /// </summary>
        public string UserId
        {
            get
            {
                return mstrUserId;
            }
            set
            {
                mstrUserId = value;
            }
        }
        /// <summary>
        /// 工程Id
        /// </summary>
        public string QxPrjId
        {
            get
            {
                return mstrQxPrjId;
            }
            set
            {
                mstrQxPrjId = value;
            }
        }
        /// <summary>
        /// 菜单集Id
        /// </summary>
        public string MenuSetId
        {
            get
            {
                return mstrMenuSetId;
            }
            set
            {
                mstrMenuSetId = value;
            }
        }
        /// <summary>
        /// 专业年级流水号
        /// </summary>
        public string CodeTypeIdGrade
        {
            get
            {
                return mstrCodeTypeIdGrade;
            }
            set
            {
                mstrCodeTypeIdGrade = value;
            }
        }

        /// <summary>
        /// 行政班流水号
        /// </summary>
        public string ProgLangTypeId
        {
            get
            {
                return mstrProgLangTypeId;
            }
            set
            {
                mstrProgLangTypeId = value;
            }
        }



        /// <summary>
        /// 课程类型管理类型流水号
        /// </summary>
        public string CodeTypeIdAdminType
        {
            get
            {
                return mstrCodeTypeIdAdminType;
            }
            set
            {
                mstrCodeTypeIdAdminType = value;
            }
        }

        /// <summary>
        /// 学生类型流水号
        /// </summary>
        public string Id
        {
            get
            {
                return mstrid;
            }
            set
            {
                mstrid = value;
            }
        }

        /// <summary>
        /// 校区流水号
        /// </summary>
        public string Id_UniZone
        {
            get
            {
                return mstrId_UniZone;
            }
            set
            {
                mstrId_UniZone = value;
            }
        }

        /// <summary>
        /// 教学楼流水号
        /// </summary>
        public string Id_Build
        {
            get
            {
                return mstrId_Build;
            }
            set
            {
                mstrId_Build = value;
            }
        }
        /// <summary>
        /// 教学计划模板流水号
        /// </summary>
		public string Id_TpTemplet
        {
            get
            {
                return mstrid_TpTemplet;
            }
            set
            {
                mstrid_TpTemplet = value;
            }
        }

        /// <summary>
        /// 教学计划。。。模板流水号
        /// </summary>
        public string Id_TpXxTemplet
        {
            get
            {
                return mstrid_TpXxTemplet;
            }
            set
            {
                mstrid_TpXxTemplet = value;
            }
        }
        /// <summary>
        /// 教学班集合流水号
        /// </summary>
		public string Id_EduClsCollect  //教学班集合ID
        {
            get
            {
                return mstrid_EduClsCollect;
            }
            set
            {
                mstrid_EduClsCollect = value;
            }
        }

        /// <summary>
        /// 选课教学班流水号
        /// </summary>
        public string Id_xkEduCls   //选课教学班ID
        {
            get
            {
                return mstrid_xkEduCls;
            }
            set
            {
                mstrid_xkEduCls = value;
            }
        }

        /// <summary>
        /// 教学班流水号
        /// </summary>
        public string Id_EduClass   //当前教学班ID
        {
            get
            {
                return mstrid_EduClass;
            }
            set
            {
                mstrid_EduClass = value;
            }
        }

        /// <summary>
        /// 排课组流水号
        /// </summary>
        public string Id_PkScheGroup    //选课教学班ID
        {
            get
            {
                return mstrid_PkScheGroup;
            }
            set
            {
                mstrid_PkScheGroup = value;
            }
        }

        /// <summary>
        /// Xls表ID
        /// </summary>
        public string Id_XlsTab //Xls表ID
        {
            get
            {
                return mstrid_Tab;
            }
            set
            {
                mstrid_Tab = value;
            }
        }

        /// <summary>
        /// 教学计划系列流水号
        /// </summary>
        public string id_TeachPlanSeries
        {
            get
            {
                return mstrid_TeachPlanSeries;
            }
            set
            {
                if (value == "")
                {
                    mstrid_TeachPlanSeries = value;
                }
                else
                {
                    mstrid_TeachPlanSeries = value;
                }
            }
        }

        /// <summary>
        /// 系列分组流水号
        /// </summary>
        public string Id_SeriesGroup
        {
            get
            {
                return mstrid_SeriesGroup;
            }
            set
            {
                mstrid_SeriesGroup = value;
            }
        }

        /// <summary>
        /// 分组需求模式
        /// </summary>
		public string Id_GroupReqMode
        {
            get
            {
                return mstrid_GroupReqMode;
            }
            set
            {
                mstrid_GroupReqMode = value;
            }
        }
        /// <summary>
        /// 角色流水号
        /// </summary>
        public string Id_Role
        {
            get
            {
                return mstrid_Role;
            }
            set
            {
                mstrid_Role = value;
            }
        }
        /// <summary>
        /// 用户流水号
        /// </summary>
        public string Id_User
        {
            get
            {
                return mstrIdUser;
            }
            set
            {
                mstrIdUser = value;
            }
        }
        /// <summary>
        /// 权限类型流水号
        /// </summary>
        public string Id_RightType
        {
            get
            {
                return mstrid_RightType;
            }
            set
            {
                mstrid_RightType = value;
            }
        }
        /// <summary>
        /// 权限流水号
        /// </summary>
        public string Id_Right
        {
            get
            {
                return mstrid_Right;
            }
            set
            {
                mstrid_Right = value;
            }
        }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrMsg
        {
            get
            {
                return mstrErrMsg;
            }
            set
            {
                mstrErrMsg = value;
            }
        }

        private string mstrSS;

        public string SS
        {
            get
            {
                return mstrSS;
            }

            set
            {
                mstrSS = value;
            }
        }
        private int mintTT;

        public int TT
        {
            get
            {
                return mintTT;
            }

            set
            {
                mintTT = value;
            }
        }

        private float mfltMyFloat;

        public float MyFloat
        {
            get
            {
                return mfltMyFloat;
            }

            set
            {
                mfltMyFloat = value;
            }
        }

        private double mdblMyDouble;

        public double MyDouble
        {
            get
            {
                return mdblMyDouble;
            }

            set
            {
                mdblMyDouble = value;
            }
        }
        private bool mbolMyBool;

        public bool MyBool
        {
            get
            {
                return mbolMyBool;
            }

            set
            {
                mbolMyBool = value;
            }
        }

        /// <summary>
        /// 学科方向流水号
        /// </summary>
        public string FuncId4GC
        {
            get
            {
                //convFunction4GeneCode.FuncId4GC
                return mstrFuncId4GC;
            }
            set
            {
                mstrFuncId4GC = value;
            }
        }

        /// <summary>
        /// 学科方向流水号
        /// </summary>
        public string FuncId4Code
        {
            get
            {
                //conFunction4Code.FuncId4Code
                return mstrFuncId4Code;
            }
            set
            {
                mstrFuncId4Code = value;
            }
        }

        /// <summary>
        /// 学科方向流水号
        /// </summary>
        public string FuncModuleAgcId
        {
            get
            {
                //conFuncModule_Agc.FuncModuleAgcId
                return mstrFuncModuleAgcId;
            }
            set
            {
                mstrFuncModuleAgcId = value;
            }
        }
        /// <summary>
        /// 年级流水号
        /// </summary>
        public string FeatureId
        {
            get
            {
                //conPrjFeature.FeatureId
                return mstrFeatureId;
            }
            set
            {
                mstrFeatureId = value;
            }
        }
        /// <summary>
        /// 统计方式Id
        /// </summary>
        public string StatsModeId
        {
            get
            {
                return mstrStatsModeId;
            }
            set
            {
                mstrStatsModeId = value;
            }
        }
        /// <summary>
        /// 	考试统计批次ID
        /// </summary>
        public string ExamStatsBatchId
        {
            get
            {
                return mstrExamStatsBatchId;
            }
            set
            {
                mstrExamStatsBatchId = value;
            }
        }
        /// <summary>
        /// 课程流水号Id
        /// </summary>
        public string Id_Course
        {
            get
            {
                return mstrId_Course;
            }
            set
            {
                mstrId_Course = value;
            }
        }

        /// <summary>
        /// 统计方式Id
        /// </summary>
        public string ExamBatchId
        {
            get
            {
                return mstrExamBatchId;
            }
            set
            {
                mstrExamBatchId = value;
            }
        }


        /// <summary>
        /// 考试日期
        /// </summary>
        public string ExamDate
        {
            get
            {
                return mstrExamDate;
            }
            set
            {
                mstrExamDate = value;
            }
        }
        /// <summary>
        /// 年级流水号
        /// </summary>
        public string Id_Grade
        {
            get
            {
                return mstrId_Grade;
            }
            set
            {
                mstrId_Grade = value;
            }

        }



        public string ApplicationTypeId
        {
            get
            {
                return mstrApplicationTypeId;
            }

            set
            {
                mstrApplicationTypeId = value;
            }
        }
    }

    public partial class wucTreeView : clsTreeView4WucBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //		private string strCond4Bindlv_XzAdminCls = " 1=1 ";
        private TreeNode TnSelected;



        protected string mstrid_Tab;            //XLS导入表ID

        protected string mstrid_PkScheGroup;        //排课组ID
        private string mstrViewId;
        private string mstrFunctionTemplateId;
        private string mstrProgLangTypeId;
        private string mstrDependsOn;//依赖于：(表 or 界面)
        private string mstrTabId;//依赖于：(表 or 界面)

        private string mstrPrjId;//依赖于：(表 or 界面)

        private int mintApplicationTypeId;

        private List<clsTreeModelMenu> arrTreeModelObjList = new List<clsTreeModelMenu>();
        private List<clsTreeNodeTypeMenu> arrTreeNodeTypeObjList = new List<clsTreeNodeTypeMenu>();
        //private bool mbolIsAutoSelSubNode = false;	//是否自动选择下级子结点
        //private bool mbolIsShowEmptyNode = true;//是否显示空的子结点
        //private bool mbolIsShowContextMenu;			//是否显示快捷菜单
        //private bool mbolIsShowUniversityCourse = true;//是否显示校级课程
        /// <summary>
        /// 是否显示校级课程
        /// </summary>
        public bool IsShowUniversityCourse
        {
            get { return clsSysPara4TreeView.bolIsShowUniversityCourse; }
            set { clsSysPara4TreeView.bolIsShowUniversityCourse = value; }
        }

        /// <summary>
        /// 是否不显示已经毕业的年级
        /// </summary>
        public bool IsNotShowGradeWithoutGraduate
        {
            get { return clsSysPara4TreeView.bolIsNotShowGradeWithoutGraduate; }
            set { clsSysPara4TreeView.bolIsNotShowGradeWithoutGraduate = value; }
        }


        //		private bool mbolIsAddCollegeCodeInTree = false;//是树中是否加学院代码
        private string mstrNodeType;
        public TreeModel tmTreeModel
        {
            get
            {
                TreeModel sTreeModel;
                sTreeModel = (TreeModel)ViewState["TreeModel"];
                if (sTreeModel == TreeModel.NULL)
                {
                    sTreeModel = TreeModel.NULL;
                }
                return sTreeModel;
            }
            set
            {
                TreeModel sTreeModel = value;
                ViewState.Add("TreeModel", sTreeModel);
            }
        }
        //private System.Windows.Forms.ContextMenu contextMenu1;
        //private System.Windows.Forms.MenuItem miTreeModelGroup;

        ///// <summary>
        ///// 定义delegate对象类型，它有两个参数，第一个参数是事件发送者对象，第二个参数是事件参数类对象
        ///// 声明一个:发生在单击登录之后的事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //public delegate void OnClickLogin(object sender, clsEventArgs4TreeView e);
        ///// <summary>
        ///// 用event关键字定义事件对象，它同时也是一个delegate对象:
        /////       发生在单击登录之后的事件
        ///// </summary>
        //public event OnClickLogin myClickLogin;

        //定义各种事件

        public event AfterSelect_Tz afterSelect_Tz;

        public delegate void AfterCheck_Tz(object sender, clsEventArgs4TreeView e);
        //public event AfterCheck_Tz afterCheck_Tz;

        public delegate void MenuItemRightClick(string strMenuName);
        public event MenuItemRightClick menuItemRightClick;

        ///// <summary> 
        ///// 必需的设计器变量。
        ///// </summary>
        //private System.ComponentModel.Container components = null;

        public wucTreeView()
        {
            // 该调用是 Windows.Forms 窗体设计器所必需的。
            InitializeComponent();
            // TODO: 在 InitializeComponent 调用后添加任何初始化

        }



        #region 组件设计器生成的代码
        /// <summary> 
        /// 设计器支持所需的方法 - 不要使用代码编辑器 
        /// 修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            //this.treeView1 = new System.Windows.Forms.TreeView();
            //this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            //this.miTreeModelGroup = new System.Windows.Forms.MenuItem();
            //this.SuspendLayout();
            // 
            // treeView1
            // 
            //this.treeView1.ImageIndex = -1;
            //this.treeView1.Location = new System.Drawing.Point(0, 8);
            //this.treeView1.Name = "treeView1";
            //this.treeView1.SelectedImageIndex = -1;
            //this.treeView1.Size = new System.Drawing.Size(176, 208);
            //this.treeView1.TabIndex = 0;
            //this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            //this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            //this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // contextMenu1
            // 
            //this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            //                                                                             this.miTreeModelGroup});
            //// 
            // miTreeModelGroup
            // 
            //this.miTreeModelGroup.Index = 0;
            //this.miTreeModelGroup.Text = "排序方式";
            //// 
            //// myTreeView
            //// 
            //this.Controls.Add(this.treeView1);
            //this.Name = "myTreeView";
            //this.Size = new System.Drawing.Size(184, 232);
            //this.Resize += new System.EventHandler(this.myTreeView_Resize);
            //this.Load += new System.EventHandler(this.myTreeView_Load);
            //this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// 是否有学院条件
        /// </summary>
        public bool IsHaveClgCondition
        {
            get
            {
                return clsSysPara4TreeView.bolIsHaveClgCondition;
            }
            set
            {
                clsSysPara4TreeView.bolIsHaveClgCondition = value;
            }
        }
        /// <summary>
        /// 是否在结点前面添加学院代码
        /// </summary>
        public bool IsAddCollegeCode
        {
            get
            {
                return clsSysPara4TreeView.bolIsAddCollegeCode;
            }
            set
            {
                clsSysPara4TreeView.bolIsAddCollegeCode = value;
            }
        }
        /// <summary>
        /// 是否显示空结点，可以通过此属性来是否显示没有下级结点的结点
        /// </summary>
        public bool IsShowEmptyNode
        {
            get
            {
                return clsSysPara4TreeView.bolIsShowEmptyNode;
            }
            set
            {
                clsSysPara4TreeView.bolIsShowEmptyNode = value;
            }
        }
        /// <summary>
        /// 错误信息
        /// </summary>

        //public bool CheckBoxes
        //{
        //    get
        //    {
        //        return treeView1.CheckBoxes;
        //    }
        //    set
        //    {
        //        treeView1.CheckBoxes = value;
        //    }
        //}

        /// <summary>
        /// 当前结点的类型
        /// </summary>
        public string NodeType
        {
            get
            {
                return mstrNodeType;
            }
        }

        //private void myTreeView_Resize(object sender, System.EventArgs e)
        //{
        //    treeView1.Left = 0;
        //    treeView1.Top = 0;
        //    treeView1.Width = this.Width;
        //    treeView1.Height = this.Height;
        //}
        public override TreeView objCurrTreeView
        {
            get
            {
                return treeView1;
            }
        }
        private void myTreeView_Load(object sender, System.EventArgs e)
        {

        }
        public void BindTv()
        {
            if (IsUseJsEvent == true)
            {
                treeView1.SelectedNodeChanged -= treeView1_SelectedNodeChanged;
                treeView1.TreeNodeCheckChanged -= treeView1_TreeNodeCheckChanged;
            }
            switch (tmTreeModel)
            {
                //学校
                case TreeModel.CodeType_PrjFeature_Function4GeneCode:
                    clsTreeViewBindDoubleTable.Bindtv_CodeType_PrjFeature_Function4GeneCode(treeView1);
                    break;

                case TreeModel.ViewRegion:
                    clsTreeViewBindDoubleTable.Bindtv_ViewRegion(treeView1);
                    break;

                case TreeModel.ApplicationType_CMProject_FuncModule:
                    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CMProject_FuncModule(treeView1, PrjId);
                    break;
                case TreeModel.ApplicationType_CMProject_FuncModule_PrjTab:
                    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CMProject_FuncModule_PrjTab(treeView1, PrjId);
                    break;
                case TreeModel.ApplicationType_CMProject_FuncModule_Agc4Feature:
                    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CMProject_FuncModule_Agc4Feature(treeView1, PrjId, UserId, DispNoFunctionClass);
                    break;
                case TreeModel.ApplicationType_CMProject_FuncModule_Agc4Requirement:
                    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CMProject_FuncModule_Agc4Requirement(treeView1, PrjId, UserId, DispNoFunctionClass);
                    break;

                case TreeModel.ApplicationType_CodeType_NameSpace_CMClass:
                    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CodeType_NameSpace_CMClass(treeView1, PrjId, UserId, DispNoFunctionClass);
                    break;

                case TreeModel.ApplicationType_CodeType_CMClass:
                    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CodeType_CMClass(treeView1, PrjId);
                    break;
                case TreeModel.ViewRegion_ViewFeature:
                    clsTreeViewBindDoubleTable.Bindtv_ViewRegion_ViewFeature(treeView1);
                    break;
                case TreeModel.ViewRegion_PrjFeature:
                    clsTreeViewBindDoubleTable.Bindtv_ViewRegion_PrjFeature(treeView1);
                    break;
                //学校
                case TreeModel.PrjFeature_TabFeature:
                    clsTreeViewBindDoubleTable.Bindtv_PrjFeature_TabFeature(treeView1);
                    break;
                //学校
                case TreeModel.PrjFeatureType_PrjFeature:
                    clsTreeViewBindDoubleTable.Bindtv_PrjFeatureType_PrjFeature(treeView1);
                    break;
                case TreeModel.PrjFeatureType:
                    clsTreeViewBindDoubleTable.Bindtv_PrjFeatureType(treeView1);
                    break;

                //学校
                case TreeModel.PrjFeatureType_PrjFeature_Function4GeneCode:
                    clsTreeViewBindDoubleTable.Bindtv_PrjFeatureType_PrjFeature_Function4GeneCodeByAppId(treeView1);
                    break;
                //学校
                case TreeModel.ConstraintType_PrjConstraint:
                    clsTreeViewBindDoubleTable.Bindtv_ConstraintType_PrjConstraint(treeView1, TabId);
                    break;

                //学校
                case TreeModel.PrjFeature:
                    clsTreeViewBindDoubleTable.Bindtv_PrjFeature(treeView1);
                    break;
                //学校-学院
                case TreeModel.PrjFeature_Function4Code:
                    clsTreeViewBindDoubleTable.Bindtv_PrjFeature_Function4Code(treeView1, ApplicationTypeId);
                    //treeView1.Nodes[0].Expand();
                    break;
                case TreeModel.PrjFeature_Function4CodeByAppId:
                    clsTreeViewBindDoubleTable.Bindtv_PrjFeature_Function4CodeByAppId(treeView1, ApplicationTypeId);
                    //treeView1.Nodes[0].Expand();
                    break;
                case TreeModel.PrjFeature_Function4GeneCodeByAppId:
                    clsTreeViewBindDoubleTable.Bindtv_PrjFeature_Function4GeneCodeByAppId(treeView1, ApplicationTypeId);
                    //treeView1.Nodes[0].Expand();
                    break;
                //学校-成绩统计方式
                case TreeModel.ApplicationType_CodeType:
                    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CodeType(treeView1);
                    //treeView1.Nodes[0].Expand();
                    break;

                case TreeModel.ApplicationType_CodeTypeByProgLangTypeId:
                    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CodeTypeByProgLangTypeId(treeView1);                    
                    break;

                //学校-成绩统计方式
                case TreeModel.ViewInfo_PrjFeature_Function4Code:
                    clsTreeViewBindDoubleTable.Bindtv_ViewInfo_PrjFeature_Function4Code(treeView1, ViewId, PrjId);
                    //treeView1.Nodes[0].Expand();
                    break;
                //学校-成绩统计方式
                case TreeModel.ViewInfo_PrjFeature_Function4GeneCode:
                    clsTreeViewBindDoubleTable.Bindtv_ViewInfo_PrjFeature_Function4GeneCode(treeView1, ViewId, PrjId);
                    //treeView1.Nodes[0].Expand();
                    break;
                //学校-成绩统计方式
                case TreeModel.ProgLangType_CodeType:
                    clsTreeViewBindDoubleTable.Bindtv_ProgLangType_CodeType(treeView1);
                    //treeView1.Nodes[0].Expand();
                    break;



                //case TreeModel.ProgLangType_ApplicationType_CodeType:
                //    clsTreeViewBindDoubleTable.Bindtv_ProgLangType_ApplicationType_CodeType(treeView1, DependsOn);
                //    //treeView1.Nodes[0].Expand();
                //    break;

                //学校-校区-年级
                case TreeModel.ApplicationType_CodeType_ClassName_Function4GeneCode:
                    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CodeType_ClassName_Function4GeneCode(treeView1, DependsOn, FunctionTemplateId, TabId, CmPrjId, PrjId);
                    break;

                case TreeModel.ApplicationType_CodeType_Function4GeneCode:
                    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CodeType_Function4GeneCode(treeView1, DependsOn, FunctionTemplateId, TabId, PrjId);
                    break;
                //case TreeModel.ApplicationType_CodeType_Function4GeneCode:
                //    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CodeType_Function4GeneCode(treeView1, DependsOn, FunctionTemplateId);
                //    break;
                case TreeModel.FuncModule_Agc_PrjTab_ClassName_FuncName:
                    clsTreeViewBindDoubleTable.Bindtv_FuncModule_Agc_PrjTab_ClassName_FuncName(treeView1, PrjId);
                    break;
                case TreeModel.FuncModule_Agc_PrjTab_ViewRegion:
                    clsTreeViewBindDoubleTable.Bindtv_FuncModule_Agc_PrjTab_RegionName(treeView1, PrjId, ApplicationTypeId, RegionTypeId);
                    break;

                case TreeModel.PrjTab_ViewRegion:
                    clsTreeViewBindDoubleTable.Bindtv_PrjTab_RegionName(treeView1, PrjId, ApplicationTypeId, RegionTypeId);
                    break;
                case TreeModel.FuncModule_Agc_ViewInfo_ViewRegion:
                    clsTreeViewBindDoubleTable.Bindtv_FuncModule_Agc_ViewInfo_RegionName(treeView1, PrjId, ApplicationTypeId, RegionTypeId);
                    break;

                case TreeModel.FuncModule_Agc_PrjTab:
                    clsTreeViewBindDoubleTable.Bindtv_FuncModule_Agc_PrjTab(treeView1, PrjId);
                    break;
                //学校-校区-年级(入学)
                case TreeModel.FuncModule_Agc_ViewInfo:
                    clsTreeViewBindDoubleTable.Bindtv_FuncModule_Agc_ViewInfo(treeView1, PrjId);
                    break;
                //学校-校区-年级-行政班
                case TreeModel.ApplicationType_CodeType_Function4GeneCode4View:
                    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CodeType_Function4GeneCode4View(treeView1, DependsOn, FunctionTemplateId, ViewId, PrjId);
                    break;
                //学校-校区
                case TreeModel.ApplicationType_CodeType_PrjFeature_Function4GeneCode4View:
                    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CodeType_PrjFeature_Function4GeneCode4View(treeView1, FunctionTemplateId, ViewId, PrjId);
                    //					treeView1.Nodes[0].Expand();
                    break;
                ////学校-校区-学院
                //case TreeModel.ApplicationType_CodeType_PrjFeature_:
                //    clsTreeViewBindDoubleTable.Bindtv_UniZone_College(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-学院-校区
                //case TreeModel.PrjFeature_Function4Code_UNIZONE:
                //    clsTreeViewBindDoubleTable.Bindtv_UniZone_College(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-校区-教学楼
                //case TreeModel.ApplicationType_CodeType_PrjFeature_Function4GeneCode4View_BUILD:
                //    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CodeType_PrjFeature_Function4GeneCode4View_Build(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-校区-学院-年级-专业
                //case TreeModel.ApplicationType_CodeType__MAJOR:
                //    clsTreeViewBindDoubleTable.Bindtv_UniZone_College_GradeBase_Major(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-校区-年级-学院-专业
                //case TreeModel.ApplicationType_CodeType_PrjFeature_:
                //    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CodeType_PrjFeature_(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-校区-年级-学院-专业
                //case TreeModel.ApplicationType_CodeType_MAJOR:
                //    clsTreeViewBindDoubleTable.Bindtv_UniZone_GradeBase_College_Major(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-校区-学院-年级-专业-行政班
                //case TreeModel.ApplicationType_CodeType__MAJOR_ADMINCLS:
                //    clsTreeViewBindDoubleTable.Bindtv_UniZone_College_GradeBase_Major_PkAdminCls(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-校区-年级-学院-专业-行政班
                //case TreeModel.ApplicationType_CodeType_MAJOR_ADMINCLS:
                //    clsTreeViewBindDoubleTable.Bindtv_UniZone_GradeBase_College_Major_PkAdminCls(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-学院-专业
                ////				case TreeModel.PrjFeature_Function4Code_MAJOR:
                ////					clsTreeViewBindDoubleTable.Bindtv_College_Major(treeView1);
                //////					treeView1.Nodes[0].Expand();
                ////					break;
                ////学校-学院-选课集合
                //case TreeModel.PrjFeature:
                //    clsTreeViewBindDoubleTable.Bindtv_PrjFeature_EduClsCollect(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-学院-选课集合-选课教学班
                //case TreeModel.PrjFeature:
                //    clsTreeViewBindDoubleTable.Bindtv_PrjFeature_EduClsCollect_EduCls(treeView1);
                //    treeView1.Nodes[0].Expand();
                //    break;
                ////校区-学校-学院-选课集合-选课教学班
                //case TreeModel.ApplicationType_CodeType_PrjFeature_Function4GeneCode4View:
                //    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CodeType_PrjFeature_Function4GeneCode4View_EduClsCollect(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////校区-学校-学院-选课集合-选课教学班
                //case TreeModel.ApplicationType_CodeType_PrjFeature_Function4GeneCode4View:
                //    clsTreeViewBindDoubleTable.Bindtv_ApplicationType_CodeType_PrjFeature_Function4GeneCode4View_EduClsCollect_XkEduCls(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////校区-学校-学院-课程类型-当前教学班
                //case TreeModel.UNIZONE_COLLEGE_COURSETYPE_CURREDUCLASS:
                //    clsTreeViewBindDoubleTable.Bindtv_UniZone_College_CourseType_CurrEduCls(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////校区-学院-课程类型-选课教学班
                //case TreeModel.UNIZONE_COLLEGE_COURSETYPE:
                //    clsTreeViewBindDoubleTable.Bindtv_UniZone_College_CourseType_XkEduCls(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;

                ////校区-学院-专业-年级
                //case TreeModel.UNIZONE_COLLEGE_MAJOR_GRADE:
                //    clsTreeViewBindDoubleTable.Bindtv_UniZone_College_Major_Grade(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;

                ////学校-学院-专业-年级-学生类型
                //case TreeModel.PrjFeature_Function4Code_MAJOR_GRADEBASE:
                //    clsTreeViewBindDoubleTable.Bindtv_College_Major_GradeBase(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-年级-学生类型-学院-专业
                //case TreeModel.FuncModule_Agc_ViewInfo_COLLEGE_MAJOR:
                //    clsTreeViewBindDoubleTable.Bindtv_PrjFeature_GradeBase_College_Major(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-年级-学生类型-学院-专业
                //case TreeModel.FuncModule_Agc_ViewInfo_COLLEGE_MAJOR:
                //    clsTreeViewBindDoubleTable.Bindtv_PrjFeature_GradeBase_College_Major(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;


                ////学校-学院-专业-年级-行政班
                //case TreeModel.PrjFeature_Function4Code_MAJOR_GRADEBASE_ADMINCLS:
                //    clsTreeViewBindDoubleTable.Bindtv_College_Major_GradeBase_AdminCls(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-学院-专业-年级-行政班
                //case TreeModel.PrjFeature_Function4Code_MAJOR_GRADEBASE_PKADMINCLS:
                //    clsTreeViewBindDoubleTable.Bindtv_College_Major_GradeBase_PkAdminCls(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;

                ////课程类型-教学计划系列
                //case TreeModel.COURSETYPE:
                //    clsTreeViewBindDoubleTable.Bindtv_CourseType(treeView1, MstrViewId);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////课程类型-教学计划系列
                //case TreeModel.COURSETYPE:
                //    clsTreeViewBindDoubleTable.Bindtv_CourseType(treeView1, MstrViewId);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////课程类型-系列组-教学计划系列
                //case TreeModel.COURSETYPE:
                //    clsTreeViewBindDoubleTable.Bindtv_CourseType(treeView1, MstrViewId);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////选课模式类型-系列组-教学计划系列
                //case TreeModel.JXSERGROUPREQMODE:
                //    clsTreeViewBindDoubleTable.Bindtv_JxSerGroupReqMode(treeView1, MstrViewId);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-教学计划模板
                //case TreeModel.PrjFeature_TEACHPLANPlanTEMPLETE:
                //    clsTreeViewBindDoubleTable.Bindtv_TeachPlanTemplete(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-教学计划模板
                //case TreeModel.PrjFeature_GRADE_TEACHPLANPlanTEMPLETE:
                //    clsTreeViewBindDoubleTable.Bindtv_Grade_TeachPlanTemplete(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-教学计划选修模板
                //case TreeModel.PrjFeature_JXTPXXTEMPLETE:
                //    clsTreeViewBindDoubleTable.Bindtv_JxTpXxTemplet(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学院-年级-专业-教学计划
                //case TreeModel.COLLEGE_GRADEBASE_MAJOR:
                //    clsTreeViewBindDoubleTable.Bindtv_College_GradeBase_Major(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学院-专业-年级-教学计划
                //case TreeModel.COLLEGE_MAJOR_GRADEBASE:
                //    clsTreeViewBindDoubleTable.Bindtv_College_Major_GradeBase(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学院-专业-年级-教学计划
                //case TreeModel.GRADEBASE_MAJOR:
                //    clsTreeViewBindDoubleTable.Bindtv_GradeBase_Major(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-专业-年级
                //case TreeModel.FuncModule_Agc_ViewInfo_MAJOR:
                //    clsTreeViewBindDoubleTable.Bindtv_GradeBase_Major(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////年级-学院-专业
                //case TreeModel.GRADEBASE_COLLEGE_MAJOR:
                //    clsTreeViewBindDoubleTable.Bindtv_GradeBase_College_Major(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;

                ////年级-学院-专业
                //case TreeModel.GRADE_COLLEGE:
                //    clsTreeViewBindDoubleTable.Bindtv_GradeBase_College(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////年级-学院-专业-学生类型
                //case TreeModel.GRADEBASE_COLLEGE_MAJOR:
                //    clsTreeViewBindDoubleTable.Bindtv_GradeBase_College_Major(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;

                ////学院-年级-专业-学生类型
                //case TreeModel.COLLEGE_GRADEBASE_MAJOR:
                //    clsTreeViewBindDoubleTable.Bindtv_College_GradeBase_Major(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学院-年级-专业-学生类型
                //case TreeModel.GRADEBASE_MAJOR:
                //    clsTreeViewBindDoubleTable.Bindtv_GradeBase_Major(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学院-年级-专业-学生类型
                //case TreeModel.GRADEBASE_MAJOR4JxTheahingPlan:
                //    clsTreeViewBindDoubleTable.Bindtv_GradeBase_Major4JxTeachingPlan(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////年级-学院-专业-教学计划
                //case TreeModel.GRADEBASE_COLLEGE_MAJOR:
                //    clsTreeViewBindDoubleTable.Bindtv_GradeBase_College_Major(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////年级-学院-专业-教学计划
                //case TreeModel.GRADEBASE_COLLEGE_MAJOR:
                //    clsTreeViewBindDoubleTable.Bindtv_GradeBase_College_Major(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-校区-学院-年级
                //case TreeModel.ApplicationType_CodeType_PrjFeature__GRADE:
                //    clsTreeViewBindDoubleTable.Bindtv_UniZone_College_GradeBase(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////年级-学院-校区
                //case TreeModel.GRADEBASE_COLLEGE_UNIZONE:
                //    clsTreeViewBindDoubleTable.Bindtv_GradeBase_College_UniZone(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////年级-校区-学院
                //case TreeModel.GRADEBASE_UNIZONE_COLLEGE:
                //    clsTreeViewBindDoubleTable.Bindtv_GradeBase_UniZone_College(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////学校-排课组
                //case TreeModel.PrjFeature_PKSCHEGROUP:
                //    clsTreeViewBindDoubleTable.Bindtv_PrjFeature_PkScheGroup(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////XLS导入表
                //case TreeModel.XLSDATAIMPORTTAB:
                //    clsTreeViewBindDoubleTable.Bindtv_XlsDataImportTab(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////角色
                //case TreeModel.ROLE:
                //    clsTreeViewBindDoubleTable.Bindtv_Role(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////角色-用户
                //case TreeModel.ROLE_USER:
                //    clsTreeViewBindDoubleTable.Bindtv_Role_User(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////权限类型
                //case TreeModel.RIGHTTYPE:
                //    clsTreeViewBindDoubleTable.Bindtv_QxRightType(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;
                ////权限类型--权限
                //case TreeModel.RIGHTTYPE_RIGHT:
                //    clsTreeViewBindDoubleTable.Bindtv_QxRightType_Right(treeView1);
                //    //					treeView1.Nodes[0].Expand();
                //    break;


                default:
                    string strMsg = string.Format("本树模式:[{0}]没有相应的绑定程序，请问该控件设计者!({1})", tmTreeModel, clsStackTrace.GetCurrClassFunction());
                    clsCommonJsFunc.Alert(this.Page, strMsg);
                    break;

            }
        }


        //private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        //{
        //    if (this.TnSelected == null)
        //    {
        //        this.TnSelected = this.treeView1.SelectedNode;
        //        this.TnSelected.ForeColor = System.Drawing.Color.Blue;
        //    }
        //    else
        //    {
        //        this.TnSelected.ForeColor = System.Drawing.Color.Black;
        //        this.TnSelected = this.treeView1.SelectedNode;
        //        this.TnSelected.ForeColor = System.Drawing.Color.Blue;
        //    }
        //    mstrTabId = "";
        //    mstrCodeTypeId = "";
        //    mstrFuncId4Code = "";

        //    mstrFeatureId = "";
        //    mstrId_Grade = "";
        //    mstrCodeTypeIdGrade = "";
        //    mstrId_AdminCls = "";
        //    mstrCodeTypeId = "";
        //    mstrCodeTypeIdAdminType = "";
        //    mstrId_UniZone = "";
        //    mstrid = "";
        //    mstrid = "";
        //    mstrId_Build = "";
        //    mstrid_TpTemplet = "";
        //    mstrid_TeachPlanSeries = "";
        //    mstrid_SeriesGroup = "";    //教学计划系列组ID
        //    mstrid_GroupReqMode = "";   //教学计划系列组模式ID
        //    mstrCodeTypeId = "";
        //    mstrid_EduClsCollect = "";  //教学班集合ID
        //    mstrid_xkEduCls = "";   //选课教学班ID
        //    mstrid_EduClass = "";   //当前教学班ID
        //    mstrViewId = "";   //教学计划ID
        //    mstrid_PkScheGroup = "";    //教学计划ID
        //    mstrid_TpXxTemplet = "";        //选修课模式ID
        //    mstrExamBatchId = "";
        //    mstrExamStatsBatchId = "";


        //    string strTypeName = GetCurrKeyTypeName((TreeView)sender);
        //    //获取被选结点类型
        //    TreeNode tnTemp = ((TreeView)sender).SelectedNode;
        //    mstrNodeType = GetNodeType(tnTemp, 1);
        //    //获取各层的结点值
        //    GetNodeValue4AllLier(tnTemp);

        //    if (afterSelect_Tz != null)
        //    {
        //        afterSelect_Tz(sender, e);
        //    }


        //}

        //  private void treeView1_AfterCheck(object sender, System.Windows.Forms.TreeViewEventArgs e)
        //  {
        //      if (mbolIsAutoSelSubNode == true)
        //      {
        //          if (e.Action != TreeViewAction.Unknown)
        //          {
        //              if (e.Node.Nodes.Count > 0)
        //              {
        //                  /* Calls the CheckAllChildNodes method, passing in the current 
        //Checked value of the TreeNode whose checked state changed. */
        //                  clsTreeViewBindDoubleTable.CheckAllChildNodes(e.Node, e.Node.Checked);
        //              }
        //          }
        //      }
        //      if (afterCheck_Tz != null)
        //      {
        //          afterCheck_Tz(sender, e);
        //      }
        //  }

        //
        private void menuItemSwitchMenu_Click(object sender, System.EventArgs e)
        {
            MenuItem objMenuItem = (MenuItem)sender;
            if (objMenuItem.Text == "专业-年级模式")
            {
                tmTreeModel = TreeModel.ApplicationType_CodeType;
                BindTv();
            }
            //else if (objMenuItem.Text == "年级-专业模式")
            //{
            //	tmTreeModel = TreeModel.PrjFeature_Function4Code_GRADE_MAJOR;		
            //	BindTv();
            //}
            else
            {
                TreeModel tmTemp = getTreeModel(objMenuItem.Text);
                if (tmTemp != TreeModel.NULL)
                {
                    tmTreeModel = tmTemp;
                    BindTv();
                }
            }
            if (menuItemRightClick != null)
            {
                menuItemRightClick(objMenuItem.Text);
            }
        }
        private TreeModel getTreeModel(string strMenuName)
        {
            foreach (clsTreeModelMenu objTreeModelMenu in arrTreeModelObjList)
            {
                if (strMenuName == objTreeModelMenu.TreeModelMenuName)
                {
                    return objTreeModelMenu.tmTreeModel;
                }
            }
            return TreeModel.NULL;
        }
        private void MenuOnClick()
        {

        }
        //private void treeView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
        //    //			TreeView tnRightClick = ((TreeView)sender).SelectedNode;
        //    //			node=treeView1.GetNodeAt(e.X,e.Y);

        //    TreeNode tnRightClick = treeView1.GetNodeAt(e.X, e.Y);
        //    if (tnRightClick == null)
        //    {
        //        return;
        //    }
        //    treeView1.SelectedNode = tnRightClick;
        //    //			TreeNode tnRightClick = ((TreeView)sender).SelectedNode;
        //    TreeNodeType tntRightClick = GetNodeType(tnRightClick, 1);
        //    if (e.Button == MouseButtons.Right) //如果单击右键，就弹击菜单
        //    {

        //        if (mbolIsShowContextMenu == true)
        //        {
        //            foreach (MenuItem objMenuItem in contextMenu1.MenuItems)
        //            {
        //                string strMenuName = objMenuItem.Text;
        //                TreeNodeType tntTemp = getTreeNodeTypeByMenuName(strMenuName);
        //                if (tntTemp != TreeNodeType.NULL)
        //                {
        //                    if (tntTemp == tntRightClick)
        //                    {
        //                        objMenuItem.Visible = true;
        //                    }
        //                    else
        //                    {
        //                        objMenuItem.Visible = false;
        //                    }
        //                }
        //            }
        //            contextMenu1.Show(treeView1, new Point(e.X, e.Y));
        //        }
        //    }
        //}
        private string getTreeNodeTypeByMenuName(string strMenuName)
        {
            foreach (clsTreeNodeTypeMenu objTreeNodeTypeMenu in arrTreeNodeTypeObjList)
            {
                if (objTreeNodeTypeMenu.MenuName == strMenuName)
                {
                    return objTreeNodeTypeMenu.strTreeNodeType;
                }
            }
            return "";
        }
        public void SetNodeChecked(string strNeedNodeType, List<string> arrKeyId)
        {
            //string strNeedNodeType = clsEnumHelper.EnumToString(tntNeedNodeType);
            foreach (string strKeyId in arrKeyId)
            {
                SetNodeChecked(treeView1.Nodes[0], strNeedNodeType, strKeyId);
            }
        }
        public void AddTreeModelContextMenu(string strMenuName, TreeModel tmTemp)
        {
            clsTreeModelMenu objTreeModelMenu = new clsTreeModelMenu();
            objTreeModelMenu.TreeModelMenuName = strMenuName;
            objTreeModelMenu.tmTreeModel = tmTemp;
            arrTreeModelObjList.Add(objTreeModelMenu);
            MenuItem objMenuItem = new MenuItem();
            objMenuItem.Text = strMenuName;
            //objMenuItem.Click += new EventHandler(menuItemSwitchMenu_Click);
            //miTreeModelGroup.MenuItems.Add(objMenuItem);
        }
        public void AddTreeNodeTypeContextMenu(string strMenuName, string strNeedNodeType)
        {
            clsTreeNodeTypeMenu objTreeNodeTypeMenu = new clsTreeNodeTypeMenu();
            objTreeNodeTypeMenu.MenuName = strMenuName;
            objTreeNodeTypeMenu.strTreeNodeType = strNeedNodeType;
            arrTreeNodeTypeObjList.Add(objTreeNodeTypeMenu);
            MenuItem objMenuItem = new MenuItem();
            objMenuItem.Text = strMenuName;
            //objMenuItem.Click += new EventHandler(menuItemSwitchMenu_Click);
            //contextMenu1.MenuItems.Add(objMenuItem);
        }
        public void AddContextMenu(string strMenuName)
        {
            MenuItem objMenuItem = new MenuItem();
            objMenuItem.Text = strMenuName;
            //objMenuItem.Click += new EventHandler(menuItemSwitchMenu_Click);
            //contextMenu1.MenuItems.Add(objMenuItem);
        }
        public void ClearContextMenu()
        {
            //contextMenu1.MenuItems.Clear();
        }

        protected override void GetNodeValue(TreeNode objTN)
        {
            string strTag = objTN.Value.ToString();
            string[] strArr = strTag.Split(',');
            string strTypeName = strArr[0];
            int intLoopTimes;
            if (strArr.Length <= 2)
            {
                intLoopTimes = 1;
            }
            else
            {
                intLoopTimes = 2;
            }
            for (int i = 0; i < intLoopTimes; i++)
            {
                if (i == 1)
                {
                    strTypeName = strArr[2];
                }
                switch (strTypeName)
                {
                    case "Root"://学校

                        vsNodeData.TabId = strArr[2 * i + 1];
                        break;
                    case conCMProject._CurrTabName://功能类型

                        vsNodeData.CmPrjId = strArr[2 * i + 1];
                        break;
                    case conCMFeature._CurrTabName://功能类型

                        vsNodeData.CmFeatureId = strArr[2 * i + 1];
                        break;
                    case conTabFeature._CurrTabName://功能类型

                        vsNodeData.TabFeatureId = strArr[2 * i + 1];
                        break;
                    case conPrjFeatureType._CurrTabName://功能类型

                        vsNodeData.PrjFeatureTypeId = strArr[2 * i + 1];
                        break;
                    case conConstraintType._CurrTabName://约束类型

                        vsNodeData.ConstraintTypeId = strArr[2 * i + 1];
                        break;
                    case conPrjConstraint._CurrTabName://约束
                    case convPrjConstraint._CurrTabName://约束

                        vsNodeData.PrjConstraintId = strArr[2 * i + 1];
                        break;

                    case conPrjTab._CurrTabName://工程表

                        vsNodeData.TabId = strArr[2 * i + 1];
                        break;

                    case conApplicationType._CurrTabName://应用类型

                        vsNodeData.ApplicationTypeId = strArr[2 * i + 1];
                        break;
                    case conViewInfo._CurrTabName://界面
                        vsNodeData.ViewId = strArr[2 * i + 1];
                        break;
                    case conFunction4Code._CurrTabName://函数
                    case convFunction4Code._CurrTabName://函数
                        vsNodeData.FuncId4Code = strArr[2 * i + 1];
                        break;
                    case conFuncModule_Agc._CurrTabName://学校
                        vsNodeData.FuncModuleAgcId = strArr[2 * i + 1];
                        break;

                    case conFunction4GeneCode._CurrTabName://函数4GC
                    case convFunction4GeneCode._CurrTabName://函数4GC
                        vsNodeData.FuncId4GC = strArr[2 * i + 1];
                        break;
                    case conProgLangType._CurrTabName://语言类型

                        vsNodeData.ProgLangTypeId = strArr[2 * i + 1];
                        break;
                    case conCodeType._CurrTabName: //代码类型

                        vsNodeData.CodeTypeId = strArr[2 * i + 1];
                        break;
                    case conPrjFeature._CurrTabName: //功能
                    case convPrjFeature._CurrTabName: //功能
                        vsNodeData.FeatureId = strArr[2 * i + 1];
                        break;
                    default:
                        vsNodeData.ErrMsg = "不能确定的结点类型";       //不能确定的结点类型
                        break;
                }
            }
        }

        private void GetNodeObj(TreeNode objTN, clsNodeObj objNodeObj)
        {
            string strTag = objTN.Value.ToString();
            string[] strArr = strTag.Split(',');
            string strTypeName = strArr[0];
            int intLoopTimes;
            if (strArr.Length <= 2)
            {
                intLoopTimes = 1;
            }
            else
            {
                intLoopTimes = 2;
            }
            for (int i = 0; i < intLoopTimes; i++)
            {
                if (i == 1)
                {
                    strTypeName = strArr[2];
                }
                switch (strTypeName)
                {
                    case "Root"://学校

                        vsNodeData.TabId = strArr[2 * i + 1];
                        objNodeObj["TabId"] = vsNodeData.TabId;
                        break;
                    case conDepartmentInfo._CurrTabName:  //学院             
                        vsNodeData.DepartmentId = strArr[2 * i + 1];
                        objNodeObj[conDepartmentInfo.DepartmentId] = vsNodeData.DepartmentId;
                        break;
                    case conPrjFeature._CurrTabName:  //年级                
                        vsNodeData.FeatureId = strArr[2 * i + 1];
                        objNodeObj[conPrjFeature.FeatureId] = vsNodeData.FeatureId;
                        break;

                    case conCodeType._CurrTabName:  //专业

                        vsNodeData.CodeTypeId = strArr[2 * i + 1];
                        objNodeObj[conCodeType.CodeTypeId] = vsNodeData.CodeTypeId;
                        break;
                    case conProgLangType._CurrTabName:  //学科方向

                        vsNodeData.ProgLangTypeId = strArr[2 * i + 1];
                        objNodeObj[conProgLangType.ProgLangTypeId] = vsNodeData.ProgLangTypeId;
                        break;

                    default:

                        vsNodeData.ErrMsg = "不能确定的结点类型";       //不能确定的结点类型
                        break;
                }
            }
        }
        private void GetNodeObj4AllLier(TreeNode objTN, clsNodeObj objNodeObj)
        {
            TreeNode tnTemp = objTN;
            while (tnTemp != null)
            {
                GetNodeObj(tnTemp, objNodeObj); //获取本结点的值；
                tnTemp = tnTemp.Parent;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tnTemp"></param>
        /// <param name="arrLst"></param>
        /// <param name="tntNeedNodeType"></param>
        private void GetCheckedLeafNodeObj(TreeNode tnTemp, List<clsNodeObj> arrLst,
            string strNeedNodeType)
        {
            string strNodeType = GetNodeType(tnTemp, 1);
            //			string strNodeKeyId = GetCurrKey(tnTemp);
            if (tnTemp.ShowCheckBox == true && tnTemp.Checked == true
                && strNodeType == strNeedNodeType)
            {
                clsNodeObj objNodeObj = new clsNodeObj();
                GetNodeObj4AllLier(tnTemp, objNodeObj);
                arrLst.Add(objNodeObj);
            }
            foreach (TreeNode tn in tnTemp.ChildNodes)
            {
                GetCheckedLeafNodeObj(tn, arrLst, strNeedNodeType);
            }
        }

        protected void treeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            if (this.TnSelected == null)
            {
                this.TnSelected = this.treeView1.SelectedNode;

                //this.TnSelected.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                //this.TnSelected.ForeColor = System.Drawing.Color.Black;
                this.TnSelected = this.treeView1.SelectedNode;
                //this.TnSelected.ForeColor = System.Drawing.Color.Blue;
            }
            InitPropertyValue4Obj(NodeData);

            string strTypeName = GetCurrNodeType();
            //获取被选结点类型
            TreeNode tnTemp = ((TreeView)sender).SelectedNode;
            mstrNodeType = GetNodeType(tnTemp, 1);
            string strKeyId = GetNodeKeyId(tnTemp);
            //获取各层的结点值
            GetNodeValue4AllLier(tnTemp);

            if (afterSelect_Tz != null)
            {
                clsEventArgs4TreeView objEventArgs4TreeView = new clsEventArgs4TreeView();
                objEventArgs4TreeView.KeyId = strKeyId;
                objEventArgs4TreeView.NodeType = strTypeName;
                afterSelect_Tz(sender, objEventArgs4TreeView);
            }
        }

        /// <summary>
        /// 结点数据
        /// </summary>
        public TreeNodeData NodeData
        {
            get
            {
                TreeNodeData objNodeData = vsNodeData;
                if (objNodeData == null)
                {
                    objNodeData = new TreeNodeData();
                    vsNodeData = objNodeData;
                }
                return objNodeData;
            }

            set
            {
                vsNodeData = value;
            }
        }
        protected void treeView1_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e)
        {

        }




        public string Jsfunc_onclick
        {
            get
            {
                string sJsfunc_onclick;
                sJsfunc_onclick = (string)ViewState["Jsfunc_onclick"];
                if (sJsfunc_onclick == null)
                {
                    sJsfunc_onclick = "";
                }
                return sJsfunc_onclick;
            }
            set
            {
                string sJsfunc_onclick = value;
                ViewState.Add("Jsfunc_onclick", sJsfunc_onclick);
                treeView1.Attributes.Add("onclick", value);
            }
        }
        //public bool SelectNode(string strNeedNodeType, string strKeyId)
        //{
        //    if (string.IsNullOrEmpty( strNeedNodeType )== true
        //        || strKeyId == "")
        //    {
        //        return false;
        //    }

        //    TreeNode tnNode = GetNodeByTypeAndKeyIdInTV(strNeedNodeType, strKeyId);
        //    if (tnNode != null)
        //    {

        //        //T tntNeedNodeType1 = GetNodeTypeString(vsLastSelectedNodeType);
        //        if (string.IsNullOrEmpty( vsLastSelectedNodeType ) != true)
        //        {
        //            TreeNode tnLastSelectNode = GetNodeByTypeAndKeyIdInTV(vsLastSelectedNodeType, vsLastSelectedKeyId);
        //            if (tnLastSelectNode != null)
        //            {
        //                tnLastSelectNode.Text = vsSelectedText;
        //            }
        //        }
        //        vsSelectedText = tnNode.Text;
        //        vsLastSelectedNodeType = GetNodeTypeString(tnNode, 3);
        //        vsLastSelectedKeyId = GetNodeKeyId(tnNode);
        //        tnNode.Text = string.Format("<span class='selectedNode'>{0}</span>", tnNode.Text);
        //        tnNode.Select();
        //        return true;
        //    }
        //    return false;
        //}
        /// <summary>
        /// 获取被选的叶子结点
        /// </summary>
        /// <param name="tntTemp">结点类型</param>
        /// <returns></returns>
        public List<clsNodeObj> GetCheckedLeafNodeObjList(string strNeedNodeType)
        {
            List<clsNodeObj> arrAllCheckedLeafNodeList = new List<clsNodeObj>();
            foreach (TreeNode tnNode in objCurrTreeView.Nodes)
            {
                GetCheckedLeafNodeObj(tnNode, arrAllCheckedLeafNodeList, strNeedNodeType);
            }
            return arrAllCheckedLeafNodeList;
        }
        /// <summary>
        /// 上一次选中的结点文本
        /// </summary>
        protected TreeNodeData vsNodeData
        {
            get
            {
                TreeNodeData sNodeData;
                sNodeData = (TreeNodeData)ViewState["NodeData"];
                if (sNodeData == null)
                {
                    sNodeData = null;
                }
                return sNodeData;
            }
            set
            {
                TreeNodeData sNodeData = value;
                ViewState.Add("NodeData", sNodeData);
            }
        }
        /// <summary>
        /// 界面Id
        /// </summary>
        public string ViewId
        {
            get
            {
                return mstrViewId;
            }

            set
            {
                mstrViewId = value;
            }
        }

        /// <summary>
        /// 函数模块Id
        /// </summary>
        public string FunctionTemplateId
        {
            get
            {
                return mstrFunctionTemplateId;
            }

            set
            {
                mstrFunctionTemplateId = value;
            }
        }

        /// <summary>
        /// 界面Id
        /// </summary>
        public string ProgLangTypeId
        {
            get
            {
                return mstrProgLangTypeId;
            }

            set
            {
                mstrProgLangTypeId = value;
            }
        }

        /// <summary>
        /// 依赖于：(表 or 界面)
        /// </summary>
        public string DependsOn
        {
            get
            {
                return mstrDependsOn;
            }

            set
            {
                mstrDependsOn = value;
            }
        }

        public string GroupName { get; set; }
        public bool IsUseJsEvent { get; set; }
        public string TabMainTypeId { get; set; }
        /// <summary>
        /// 依赖于：(表 or 界面)
        /// </summary>
        public string TabId
        {
            get
            {
                return mstrTabId;
            }

            set
            {
                mstrTabId = value;
            }
        }
        public string CmPrjId { set; get; }
        /// <summary>
        /// 依赖于：(表 or 界面)
        /// </summary>
        public string PrjId
        {
            get
            {
                return mstrPrjId;
            }

            set
            {
                mstrPrjId = value;
            }
        }
        public string UserId { get; set; }
        /// <summary>
        /// 显示无函数类？
        /// </summary>
        public bool DispNoFunctionClass { get; set; }
        public int ApplicationTypeId
        {
            get
            {
                return mintApplicationTypeId;
            }

            set
            {
                mintApplicationTypeId = value;
            }
        }
        public string RegionTypeId { get; set; }
    }
}

