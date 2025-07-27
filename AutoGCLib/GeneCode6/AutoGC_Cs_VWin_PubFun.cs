using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Text;

namespace AutoGCLib
{
    public class AutoGC_Cs_VWin_PubFun: clsGeneCodeBase4View
    {
        #region 构造函数
        public AutoGC_Cs_VWin_PubFun()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
        }
        public AutoGC_Cs_VWin_PubFun(string strViewId)
       : base(strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            clsErrorIdManageBLEx.arrErrIdLstCache = null;
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public AutoGC_Cs_VWin_PubFun( string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        #endregion
                      
        /// <summary>
        /// 初始化页面设置
        /// </summary>

        public void InitPageSetup()
        {
            //			intZIndex = 100;		///控件焦点序号
            //			intCurrLeft = 10;  ///控件的左边空;
            //			intCurrTop = 10;
        }


        public string GenShowDataCode_Win()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate
                    || objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate
|| objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 函数功能:把以该关键字的记录内容显示在界面上,");
                    strCodeForCs.Append("\r\n ///　　　   在这里是把值传到表控件中");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">表记录的关键字,显示该表关键字的内容</param>",
                      objKeyField.PrivFuncName);

                    strCodeForCs.AppendFormat("\r\n" + "private void ShowData({0} {1})",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//操作步骤:");
                    strCodeForCs.Append("\r\n" + "//1、检查关键字是否为空；");
                    strCodeForCs.Append("\r\n" + "//2、检查该关键字的记录是否存在,如果不存在就返回不显示；");
                    strCodeForCs.Append("\r\n" + "//3、用提供的关键字初始化一个类对象；");
                    strCodeForCs.Append("\r\n" + "//4、获取类对象的所有属性；");
                    strCodeForCs.Append("\r\n" + "//5、把该对象的所有属性显示在界面上,在这里显示在表控件中");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "//1、检查关键字是否为空；");
                    if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long" || 
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0) return ;		//如果关键字为空就返回退出",
                          objKeyField.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if ({0} == \"\") return ;		//如果关键字为空就返回退出",
                          objKeyField.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "//2、检查该关键字的记录是否存在,如果不存在就返回不显示；");
                    strCodeForCs.AppendFormat("\r\n" + "if (cls{0}BL.IsExist({1}) == false)		//检查该关键字的记录是否存在",
                      objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "{");
                    string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                         objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "ShowData", "在表[{1}]中,关键字为:[{0}]的记录不存在!", "生成代码");

                    strCodeForCs.AppendFormat("\r\n" + "string strMsg = \"(errid:{2})在表[{1}]中,关键字为:[{0}]的记录不存在!\";",
                      objKeyField.PrivFuncName,
                      objViewInfoENEx.TabName, strErrId);

                    //strCodeForCs.AppendFormat("\r\n" + "string ss = \"在表【{1}】中,关键字为:\" + {0}.ToString() + \"的不存在!\";",
                    //objKeyField.PrivFuncName, objViewInfoENEx.TabName);

                    strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");
                    strCodeForCs.Append("\r\n" + "return ;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "//3、用提供的关键字初始化一个类对象；");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN({1});",
                      objViewInfoENEx.TabName, objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "//4、获取类对象的所有属性；");
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.Get{0}(ref obj{0}EN);",
                      objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//5、把该对象的所有属性显示在界面上,在这里显示在表控件中");
                    strCodeForCs.AppendFormat("\r\n" + "GetDataFrom{0}Class(obj{0}EN);",
                      objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "}");

                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_btnAdd_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:事件函数,当单击<添加>时发生的事件函数,");
                strCodeForCs.Append("\r\n ///      具体功能为把界面内容同步数据库中,把界面内容保存到数据库中");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "private void btnAdd_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "frm{0}_UI frm = new frm{0}_UI();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "frm.iBindListView = this;");
                strCodeForCs.Append("\r\n" + "frm.OperateType = \"Add\";");
                strCodeForCs.Append("\r\n" + "frm.ShowDialog();");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Gen_btnAdd_Click", "生成单击<添加>按钮时发生的事件函数出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成单击<添加>按钮时发生的事件函数出错!({1}: btnAdd_Click())\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_btnDelRec_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n" + "private void btnDelRec_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Delete{0}Record();",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Gen_btnDelRec_Click", "生成单击<删除>按钮时发生的事件函数出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成单击<删除>按钮时发生的事件函数出错!({1}: btnDelRec_Click())\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        //生成插入记录准备过程代码
        public string GenAddRecordCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                //生成的插入记录准备过程代码for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 为插入记录做准备工作");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "protected void Add{0}Record()",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                clsEditRegionFldsENEx objEditRegionKeyFld = getEditRegionKeyFld();
                if (objEditRegionKeyFld != null)    //如果编辑区存在主关键字
                {
                    if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        //if (objViewInfoENEx.IsUseCtl == true)
                        //{
                        //    strCodeForCs.AppendFormat("\r\n" + "wuc{0}1.SetKeyReadOnly(false);",
                        //      objViewInfoENEx.TabName);
                        //}
                        //else
                        //{
                        strCodeForCs.AppendFormat("\r\n" + "this.SetKeyReadOnly(false);",
                          objViewInfoENEx.TabName);
                        //}
                    }
                }
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认添加\";");
                //strCodeForCs.AppendFormat("\r\n" + "btnCancel{0}Edit.Text = \"取消添加\";",
                //  objViewInfoENEx.TabName);

                //获取最大值
                //if (objViewInfoENEx.IsUseCtl == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n" + "//wuc{0}1.{1} = cls{0}BL.GetMaxStrId_S();",
                //      objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName, objKeyField.ObjFieldTabENEx.FldLength);
                //}
                //else
                //{
                strCodeForCs.AppendFormat("\r\n" + "//this.{1} = cls{0}BL.GetMaxStrId_S();",
                  objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName, objKeyField.ObjFieldTabENEx.FldLength);
                //}
                strCodeForCs.AppendFormat("\r\n" + "//DispEdit{0}Region();",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        //生成插入记录存盘过程代码
        public string GenAddRecordSaveCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                //插入记录存盘过程代码for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 插入记录存盘到数据表中");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>插入记录是否成功？</returns>");
                strCodeForCs.AppendFormat("\r\n" + "private void Add{0}RecordSave()",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:");
                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.Append("\r\n" + "//2、定义对象并初始化对象");
                strCodeForCs.Append("\r\n" + "//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在");
                strCodeForCs.Append("\r\n" + "//4、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.Append("\r\n" + "//5、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "//6、把数据实体层的数据存贮到数据库中");
                strCodeForCs.Append("\r\n" + "//7、把新添的记录内容显示在GridView中");
                strCodeForCs.Append("\r\n" + "string strMsg;	//专门用于传递信息的变量");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//用于传递在检验对象属性时结果值的变量");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1};",
                  objViewInfoENEx.TabName, objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");

                strCodeForCs.Append("\r\n" + "if (!this.IsValid(ref strResult))");

                strCodeForCs.Append("\r\n" + "{");

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSave()", "控件中输入数据类型不正确请检查!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})控件中输入数据类型不正确请检查!\";", strErrId);

                //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"控件中输入数据类型不正确请检查!\";");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//2、初始化相关类对象");
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN();	//初始化新对象",
                      objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                }
                else
                {
                    if (objViewInfoENEx.IsUseCtl == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN(wuc{2}1.{3});	//初始化新对象",
                          objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN(this.{3});	//初始化新对象",
                          objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (cls{0}BL.IsExist({1}))	//判断是否有相同的关键字",
                      objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                      objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSave", "关键字字段已有相同的值!", "生成代码");

                    //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{2})关键字字段已有相同的值!({1}: Add{0}RecordSave).\");",
                     objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId, "{", "}");
                    strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.Append("\r\n" + "//4、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//把界面的值传到", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//5、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//6、把数据实体层的数据存贮到数据库中");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddNewRecord();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSave", "添加记录不成功!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{2})添加记录不成功!({1}: Add{0}RecordSave)错误信息:{{0}}.\", objException.Message);",
                 objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId, "{", "}");

                strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "strMsg = \"添加记录成功!\";");
                strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "//7、恢复<确认添加>变成<添加>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"添加\";");
                strCodeForCs.Append("\r\n" + "//8、调用父窗体中函数BINDLISTVIEW()把父窗体中的LISTVIEW内容重新显示一下。");
                strCodeForCs.Append("\r\n" + "iBindListView.BindListView();");

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //生成插入记录存盘过程代码
        public string GenAddRecordSaveCodeV5()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                //插入记录存盘过程代码for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 插入记录存盘到数据表中,V5版");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>插入记录是否成功？</returns>");

                strCodeForCs.AppendFormat("\r\n" + "private void Add{0}RecordSaveV5()",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:");
                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.Append("\r\n" + "//2、定义对象并初始化对象");
                strCodeForCs.Append("\r\n" + "//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在");
                strCodeForCs.Append("\r\n" + "//4、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.Append("\r\n" + "//5、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "//6、把数据实体层的数据存贮到数据库中");
                strCodeForCs.Append("\r\n" + "//7、把新添的记录内容显示在GridView中");
                strCodeForCs.Append("\r\n" + "string strMsg;	//专门用于传递信息的变量");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//用于传递在检验对象属性时结果值的变量");
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1};",
                  objViewInfoENEx.TabName, objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.AppendFormat("\r\n" + "if (!wuc{0}1.IsValid(ref strResult))",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");


                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSaveV5", "控件中输入数据类型不正确请检查!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})控件中输入数据类型不正确请检查!\";", strErrId);

                //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"控件中输入数据类型不正确请检查!\";");
                strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//2、定义对象并初始化对象");
                strCodeForCs.AppendFormat("\r\n" + "//cls{0}EN obj{1};	//定义对象", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN();	//初始化新对象",
                      objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN(wuc{2}1.{3});	//初始化新对象",
                      objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);
                }
                strCodeForCs.Append("\r\n" + "//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在");
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (cls{0}BL.IsExist({1}))	//判断是否有相同的关键字",
                      objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
          objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSaveV5", "关键字字段已有相同的值!", "生成代码");

                    //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{2})关键字字段已有相同的值!({1}: Add{0}RecordSaveV5).\");",
                     objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId, "{", "}");
                    strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.Append("\r\n" + "//4、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//把界面的值传到", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//5、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//6、把数据实体层的数据存贮到数据库中");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.AddNewRecord();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Add{0}RecordSaveV5", "添加记录不成功!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{2})添加记录不成功!({1}: Add{0}RecordSaveV5)错误信息:{{0}}.\", objException.Message);",
                 objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId, "{", "}");

                strCodeForCs.Append("\r\n" + "seErrMessage = strMsg;");
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "strMsg = \"添加记录成功!\";");
                strCodeForCs.Append("\r\n" + "Response.Write(\"<script>alert('\" + strMsg + \"')</script>\");");
                strCodeForCs.Append("\r\n" + "lblMsg.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "//7、把新添的记录内容显示在GridView中");
                strCodeForCs.AppendFormat("\r\n" + "BindDg_{0}();", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "wuc{0}1.Clear();		//清空控件中内容",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n ///恢复<确认添加>变成<添加>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"添加\";");
                strCodeForCs.Append("\r\n" + "//8、调用父窗体中函数BINDLISTVIEW()把父窗体中的LISTVIEW内容重新显示一下。");
                strCodeForCs.Append("\r\n" + "iBindListView.BindListView();");

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        //生成修改存盘准备过程代码
        public string GenUpdateRecordSaveCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                //修改存盘准备过程代码 for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 修改记录存盘到数据表中");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的实体对象</param>", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n /// <returns>修改是否成功？</returns>");
                strCodeForCs.AppendFormat("\r\n" + "private void Update{0}RecordSave(cls{0}EN obj{0}EN)",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:");
                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.Append("\r\n" + "//2、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.Append("\r\n" + "//3、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "//4、把数据实体层的数据存贮到数据库中");
                strCodeForCs.Append("\r\n" + "//5、把修改后的内容显示在GridView中");
                strCodeForCs.Append("\r\n" + "string strMsg;	//专门用于传递信息的变量");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//用于传递在检验对象属性时结果值的变量");

                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                if (objViewInfoENEx.IsUseCtl == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (!uc{0}1.IsValid(ref strResult))",
                      objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "if (!this.IsValid(ref strResult))");
                }
                strCodeForCs.Append("\r\n" + "{");


                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update{0}RecordSave", "控件中输入数据类型不正确请检查!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})控件中输入数据类型不正确请检查!\";", strErrId);

                //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"控件中输入数据类型不正确请检查!\";");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//2、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//把界面的值传到",
                  objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//3、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//6、把数据实体层的数据存贮到数据库中");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Update();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update{0}RecordSave", "修改记录不成功!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{2})修改记录不成功!({1}: Update{0}RecordSave)错误信息:{{0}}.\", objException.Message);",
                     objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId, "{", "}");

                strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return ; ");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "strMsg = \"修改记录成功!\";");
                strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "this.Close();");

                strCodeForCs.Append("\r\n" + "//5、恢复<确认修改>变成<添加>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"添加\";");
                strCodeForCs.Append("\r\n" + "//6、调用父窗体中函数BINDLISTVIEW()把父窗体中的LISTVIEW内容重新显示一下。");
                strCodeForCs.Append("\r\n" + "iBindListView.BindListView();");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        //生成修改存盘准备过程代码
        public string GenUpdateRecordSaveCodeV5()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                //修改存盘准备过程代码 for C#
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 修改记录存盘到数据表中, V5版");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">需要修改的实体对象</param>", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n /// <returns>修改是否成功？</returns>");
                strCodeForCs.AppendFormat("\r\n" + "private void Update{0}RecordSaveV5(cls{0}EN obj{0}EN)",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:");
                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.Append("\r\n" + "//2、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.Append("\r\n" + "//3、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "//4、把数据实体层的数据存贮到数据库中");
                strCodeForCs.Append("\r\n" + "//5、把修改后的内容显示在GridView中");
                strCodeForCs.Append("\r\n" + "string strMsg;	//专门用于传递信息的变量");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//用于传递在检验对象属性时结果值的变量");

                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.AppendFormat("\r\n" + "if (!wuc{0}1.IsValid(ref strResult))",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update{0}RecordSaveV5", "控件中输入数据类型不正确请检查!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = \"(errid:{0})控件中输入数据类型不正确请检查!\";", strErrId);

                //strCodeForCs.Append("\r\n" + "lblMsg.Text = \"控件中输入数据类型不正确请检查!\";");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//2、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//把界面的值传到",
                  objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//3、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//6、把数据实体层的数据存贮到数据库中");
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Update();", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update{0}RecordSaveV5", "修改记录不成功!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{2})修改记录不成功!({1}: Update{0}RecordSaveV5)错误信息:{{0}}.\", objException.Message);",
                   objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId, "{", "}");

                strCodeForCs.Append("\r\n" + "seErrMessage = strMsg;");
                strCodeForCs.Append("\r\n" + "seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;");
                strCodeForCs.Append("\r\n" + "Response.Redirect(clsSysParaEN.ErrorPage);");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "strMsg = \"修改记录成功!\";");
                strCodeForCs.Append("\r\n" + "Response.Write(\"<script>alert('\" + strMsg + \"')</script>\");");
                strCodeForCs.Append("\r\n" + "lblMsg.Text = strMsg;");

                strCodeForCs.Append("\r\n" + "//5、把修改后的内容显示在GridView中");
                strCodeForCs.AppendFormat("\r\n" + "BindDg_{0}();",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "wuc{0}1.Clear();//添空控件中的内容",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//恢复<确认修改>变成<添加>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"添加\";");
                strCodeForCs.Append("\r\n" + "//8、调用父窗体中函数BINDLISTVIEW()把父窗体中的LISTVIEW内容重新显示一下。");
                strCodeForCs.Append("\r\n" + "iBindListView.BindListView();");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //生成删除记录过程代码
        public string GenDelRecordCode()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                //删除记录过程代码for C#"
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 根据给定关键字删除记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">给定关键字</param>", objViewInfoENEx.KeyPrivFuncFldNameLstStr);

                strCodeForCs.AppendFormat("\r\n" + "private void Delete{2}Record()",
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                  objKeyField.PrivFuncName,
                  objViewInfoENEx.TabName
                 );
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "DialogResult result;");
                strCodeForCs.Append("\r\n" + "result = MessageBox.Show(\"你真的要删除该记录吗？\", \"确认删除\", MessageBoxButtons.YesNo);");
                strCodeForCs.Append("\r\n" + "if (result == DialogResult.Yes)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "foreach(ListViewItem lvi in this.lv{0}.SelectedItems)",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{1} {2} = GetCurrKey(lvi);",
                  objViewInfoENEx.TabName_Out,
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                  objKeyField.PrivFuncName);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if(cls{0}BL.DelRecord({1}) > 0)",
                   objViewInfoENEx.TabName_In,
                   objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "}");


                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Delete{0}Record", "删除记录失败!", "生成代码");

             
                strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{2})删除记录失败!({1}: Delete{0}Record)错误信息:{{0}}.\", objException.Message);",
                      objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId, "{", "}");
                strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");

                strCodeForCs.AppendFormat("\r\n" + "BindLv_{0}();",
                  objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "MessageBox.Show(\"删除记录成功!\");");
                strCodeForCs.AppendFormat("\r\n" + "BindLv_{0}();",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //生成删除记录过程代码
        public string GenDelRecordCode4DataGridView()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                //删除记录过程代码for C#"
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 根据给定关键字删除记录");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">给定关键字</param>", objViewInfoENEx.KeyPrivFuncFldNameLstStr);

                strCodeForCs.AppendFormat("\r\n" + "private void Delete{2}Record()",
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                  objKeyField.PrivFuncName,
                  objViewInfoENEx.TabName
                 );
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//主键变量");

                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long"
                  || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = 0;",
                          objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                          objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = \"\";",
                          objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                          objKeyField.PrivFuncName);

                }
                strCodeForCs.Append("\r\n" + "DialogResult result;");
                strCodeForCs.Append("\r\n" + "result = MessageBox.Show(\"你真的要删除该记录吗？\", \"确认删除\", MessageBoxButtons.YesNo);");
                strCodeForCs.Append("\r\n" + "if (result == DialogResult.Yes)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (dgv{0}.SelectedRows.Count > 0)",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "foreach(DataGridViewRow objDGVR in this.dgv{0}.SelectedRows)",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0} = GetCurrKey(objDGVR);",
                  objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "if(cls{0}BL.DelRecord({1}) == 0)",
                  objViewInfoENEx.TabName_In,
                  objKeyField.PrivFuncName);

                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                 objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Delete{0}Record", "删除记录失败(For DataGridView)!", "生成代码");

             
                strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{2})删除记录失败(For DataGridView)!({1}: Delete{0}Record).\");",
                      objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId, "{", "}");
                strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");

                strCodeForCs.AppendFormat("\r\n" + "BindDgv_{0}();",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0} = GetCurrKey(dgv{1});",
                    objKeyField.PrivFuncName,
                    objViewInfoENEx.TabName_Out);


                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long"
               || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} > 0)",
                      objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == false)",
                     objKeyField.PrivFuncName);
                }


                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if(cls{0}BL.DelRecord({1}) == 0)",
                  objViewInfoENEx.TabName_In,
                  objKeyField.PrivFuncName);

                strCodeForCs.Append("\r\n" + "{");
                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                 objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Delete{0}Record", "删除记录失败!", "生成代码");
                               
                strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{2})删除记录失败!({1}: Delete{0}Record).\");",
                      objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId, "{", "}");

                strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");
                strCodeForCs.AppendFormat("\r\n" + "BindDgv_{0}();",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "MessageBox.Show(\"删除记录成功!\");");
                strCodeForCs.AppendFormat("\r\n" + "BindDgv_{0}();",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");

                string strErr = ex.Message;

                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //生成修改记录准备过程代码
        public string GenUpdateRecordCode()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                //生成修改记录准备过程代码 for C#;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "private void Update{2}Record()",
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                  objKeyField.PrivFuncName,
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "if(this.lv{0}.SelectedItems.Count!= 1)",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "DialogResult result;");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update{2}Record()", "请选择一条记录!", "生成代码");
                                
                strCodeForCs.AppendFormat("\r\n" + "result = MessageBox.Show(\"(errid:{0})请选择一条记录!\");", strErrId);
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "frm{0}_UI frm = new frm{0}_UI();", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "string strKeyId = this.lv{1}.SelectedItems[0].Tag.ToString();",
                  objKeyField.ObjFieldTabENEx.FldName,
                  objViewInfoENEx.TabName_Out);
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long"
                  || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "frm.{0}_key = {1}.Parse(strKeyId);",
                     objKeyField.ObjFieldTabENEx.FldName,
                     objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "frm.{0}_key = strKeyId;",
                      objKeyField.ObjFieldTabENEx.FldName);
                }
                strCodeForCs.Append("\r\n" + "frm.iBindListView = this;");
                strCodeForCs.Append("\r\n" + "frm.OperateType = \"Update\";");
                strCodeForCs.Append("\r\n" + "frm.ShowDialog();");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //生成修改记录准备过程代码
        public string GenUpdateRecordCode4DataGridView()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                //生成修改记录准备过程代码 for C#;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 为修改记录做准备过程,把给定关键字的记录字段值显示在用户控件上");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\n" + "private void Update{2}Record()",
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                  objKeyField.PrivFuncName,
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//主键变量");
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long"
                  || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = 0;",
                          objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                          objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = \"\";",
                          objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                          objKeyField.PrivFuncName);

                }
                strCodeForCs.AppendFormat("\r\n" + "if(this.dgv{0}.SelectedRows.Count>0)",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//修改当前选择行的第1行");
                strCodeForCs.AppendFormat("\r\n" + "{0} = GetCurrKey(this.dgv{1}.SelectedRows[0]);",
                  objKeyField.PrivFuncName,
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//修改当前行");
                strCodeForCs.AppendFormat("\r\n" + "{0} = GetCurrKey(this.dgv{1});",
                  objKeyField.PrivFuncName,
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");

                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long"
                  || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "if ({0} == 0)",
                      objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true)",
                     objKeyField.PrivFuncName);

                }


                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "DialogResult result;");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Update{2}Record()", "请选择一条记录!", "生成代码");
                               
                strCodeForCs.AppendFormat("\r\n" + "result = MessageBox.Show(\"(errid:{0})请选择一条记录!\");", strErrId);

                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "frm{0}_UI frm = new frm{0}_UI();", objViewInfoENEx.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "string strKeyId = GetCurrKey(this.dgv{1});",
                //  objViewInfoENEx. objMainTabKeyField.ObjFieldTabENEx.FldName,
                //  objViewInfoENEx.TabName_Out);
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long"
                  || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "frm.{0}_key = {2};",
                     objKeyField.ObjFieldTabENEx.FldName,
                     objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                     objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "frm.{0}_key = {1};",
                      objKeyField.ObjFieldTabENEx.FldName,
                      objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "frm.iBindListView = this;");
                strCodeForCs.Append("\r\n" + "frm.OperateType = \"Update\";");
                strCodeForCs.Append("\r\n" + "frm.ShowDialog();");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        public string GenbtnOKUpd_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,");
                strCodeForCs.Append("\r\n ///      具体功能为把界面内容同步数据库中,把界面内容保存到数据库中");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "private void btnOKUpd_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "string strMsg;	//专门用于传递信息的变量");
                //strCodeForCs.Append("\r\n" + "string strResult = \" \";	//用于传递在检验对象属性时结果值的变量");
                strCodeForCs.Append("\r\n" + "string strCommandText;");
                strCodeForCs.Append("\r\n" + "Button btnTemp = (Button) sender;");
                strCodeForCs.Append("\r\n" + "strCommandText = btnTemp.Text;");
                strCodeForCs.Append("\r\n" + "switch(strCommandText)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case \"添加\":");
                strCodeForCs.AppendFormat("\r\n" + "Add{0}Record();",
          objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "break;				");
                strCodeForCs.Append("\r\n" + "case \"确认添加\":");
                strCodeForCs.Append("\r\n" + "//这是一个单表的插入的代码,由于逻辑层太简单,");
                strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                strCodeForCs.AppendFormat("\r\n" + "Add{0}RecordSave();",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"确认修改\":");
                strCodeForCs.Append("\r\n" + "//这是一个单表的修改的代码,由于逻辑层太简单,");
                strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");

                strCodeForCs.AppendFormat("\r\n" + "Update{0}RecordSave(obj{0}EN);",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
         objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GenbtnOKUpd_Click", "生成函数[btnOKUpd_Click]出错!", "生成代码");

                
                string strMsg = string.Format("(errid:{2})生成函数[btnOKUpd_Click]出错!({1}: GenbtnOKUpd_Click)\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string GenbtnOKUpd_Click4UC()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,");
                strCodeForCs.Append("\r\n ///      具体功能为把界面内容同步数据库中,把界面内容保存到数据库中");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "private void btnOKUpd_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg;	//专门用于传递信息的变量");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//用于传递在检验对象属性时结果值的变量");
                strCodeForCs.Append("\r\n" + "string strCommandText;");
                strCodeForCs.Append("\r\n" + "Button btnTemp = (Button) sender;");
                strCodeForCs.Append("\r\n" + "strCommandText = btnTemp.Text;");
                strCodeForCs.Append("\r\n" + "switch(strCommandText)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case \"添加\":");
                if (getEditRegionKeyFld().PrimaryTypeId() != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "uc{0}1.SetKeyReadOnly(false);",
                      objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认添加\";");
                //获取最大值
                strCodeForCs.AppendFormat("\r\n" + "//uc{0}1.{1} = cls{0}BL.GetMaxStrId_S();",
                  objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName, objKeyField.ObjFieldTabENEx.FldLength);

                strCodeForCs.Append("\r\n" + "break;				");
                strCodeForCs.Append("\r\n" + "case \"确认添加\":");
                strCodeForCs.Append("\r\n" + "//这是一个单表的插入的代码,由于逻辑层太简单,");
                strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                strCodeForCs.Append("\r\n" + "//操作步骤:");
                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.Append("\r\n" + "//2、定义对象并初始化对象");
                strCodeForCs.Append("\r\n" + "//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在");
                strCodeForCs.Append("\r\n" + "//4、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.Append("\r\n" + "//5、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "//6、把数据实体层的数据存贮到数据库中");
                strCodeForCs.Append("\r\n" + "//7、把新添的记录内容显示在ListView中");
                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.AppendFormat("\r\n" + "if (!uc{0}1.IsValid(ref strResult))",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnOKUpd_Click", "在编辑控件中输入数据类型不正确请检查!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = strResult + \"(errid:{0})在编辑控件中输入数据类型不正确请检查!\";", strErrId);

                //strCodeForCs.Append("\r\n" + "lblMsg.Text = strResult + \"在编辑控件中输入数据类型不正确请检查!\";");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//2、初始化相关类对象");
                if (getEditRegionKeyFld().PrimaryTypeId() != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN();	//初始化新对象",
                      objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{1}EN(uc{2}1.{3});	//初始化新对象",
                      objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);
                }
                strCodeForCs.Append("\r\n" + "//3、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在");
                if (getEditRegionKeyFld().PrimaryTypeId() != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (cls{0}BL.IsExist({1}))	//判断是否有相同的关键字",
                      objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                        objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnOKUpd_Click", "关键字字段已有相同的值!", "生成代码");

                    //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{2})关键字字段已有相同的值!({1}: btnOKUpd_Click)\");",
                        objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId, "{", "}");

                    strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                strCodeForCs.Append("\r\n" + "//4、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//把界面的值传到", objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//5、检查传进去的对象属性是否合法");
                strCodeForCs.AppendFormat("\r\n" + "if (cls{0}BL.CheckProperty(ref strResult) == false)", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "MessageBox.Show(strResult);");
                strCodeForCs.Append("\r\n" + "return ; ");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//6、把数据实体层的数据存贮到数据库中");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.AddNewRecord() == false) ", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnOKUpd_Click", "添加记录不成功!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{2})添加记录不成功!({1}: btnOKUpd_Click)错误信息:{{0}}.\", objException.Message);",
                 objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId, "{", "}");

                strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strMsg = \"添加记录成功!\";");
                strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//7、把新添的记录内容显示在ListView中");
                strCodeForCs.AppendFormat("\r\n" + "BindLv_{0}();", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "uc{0}1.Clear();		//清空控件中内容",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n ///恢复<确认添加>变成<添加>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"添加\";");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"确认修改\":");
                strCodeForCs.Append("\r\n" + "//这是一个单表的修改的代码,由于逻辑层太简单,");
                strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                strCodeForCs.Append("\r\n" + "//操作步骤:");
                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.Append("\r\n" + "//2、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.Append("\r\n" + "//3、检查传进去的对象属性是否合法");
                strCodeForCs.Append("\r\n" + "//4、把数据实体层的数据存贮到数据库中");
                strCodeForCs.Append("\r\n" + "//5、把修改后的内容显示在ListView中");
                strCodeForCs.Append("\r\n" + "//1、检查控件中输入数据类型是否正确");
                strCodeForCs.AppendFormat("\r\n" + "if (!uc{0}1.IsValid(ref strResult))",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                 objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnOKUpd_Click", "控件中输入数据类型不正确请检查!", "生成代码");

                strCodeForCs.AppendFormat("\r\n" + "lblMsg.Text = strResult + \"(errid:{0})控件中输入数据类型不正确请检查!\";", strErrId);


                //strCodeForCs.Append("\r\n" + "lblMsg.Text = strResult + \"控件中输入数据类型不正确请检查!\";");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//2、把值从界面层传到逻辑层或数据实体层");
                strCodeForCs.AppendFormat("\r\n" + "PutDataTo{0}Class(obj{1}EN);		//把界面的值传到",
                  objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//3、检查传进去的对象属性是否合法");
                strCodeForCs.AppendFormat("\r\n" + "if (cls{0}BL.CheckProperty(ref strResult) == false)",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "MessageBox.Show(strResult);");
                strCodeForCs.Append("\r\n" + "return ; ");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//4、把数据实体层的数据修改同步到数据库中");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.Update() == false) ",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                 objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "btnOKUpd_Click", "修改记录不成功!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{2})修改记录不成功!({1}: btnOKUpd_Click)错误信息:{{0}}.\", objException.Message);",
                 objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId, "{", "}");

                strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strMsg = \"修改记录成功!\";");
                strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//5、把修改后的内容显示在ListView中");
                strCodeForCs.AppendFormat("\r\n" + "BindLv_{0}();",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "uc{0}1.Clear();//添空控件中的内容",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//恢复<确认修改>变成<添加>");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"添加\";");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");



            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GenbtnOKUpd_Click4UC", "生成函数[btnOKUpd_Click]出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成函数[btnOKUpd_Click]出错!({1}: GenbtnOKUpd_Click4UC)\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string GenbtnOKUpd_Click4UCAndFunc()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,");
                strCodeForCs.Append("\r\n ///      具体功能为把界面内容同步数据库中,把界面内容保存到数据库中");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "private void btnOKUpd_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg;	//专门用于传递信息的变量");
                strCodeForCs.Append("\r\n" + "string strResult = \" \";	//用于传递在检验对象属性时结果值的变量");
                strCodeForCs.Append("\r\n" + "string strCommandText;");
                strCodeForCs.Append("\r\n" + "Button btnTemp = (Button) sender;");
                strCodeForCs.Append("\r\n" + "strCommandText = btnTemp.Text;");
                strCodeForCs.Append("\r\n" + "switch(strCommandText)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "case \"添加\":");
                clsEditRegionFldsENEx objEditRegionKeyFld = getEditRegionKeyFld();
                if (objEditRegionKeyFld != null)    //如果编辑区存在主关键字
                {
                    if (getEditRegionKeyFld().PrimaryTypeId() != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "uc{0}1.SetKeyReadOnly(false);",
                          objViewInfoENEx.TabName);
                    }
                }
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认添加\";");
                //获取最大值
                strCodeForCs.AppendFormat("\r\n" + "//uc{0}1.{1} = cls{0}BL.GetMaxStrId_S();",
                  objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName, objKeyField.ObjFieldTabENEx.FldLength);

                strCodeForCs.Append("\r\n" + "break;				");
                strCodeForCs.Append("\r\n" + "case \"确认添加\":");
                strCodeForCs.Append("\r\n" + "//这是一个单表的插入的代码,由于逻辑层太简单,");
                strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                strCodeForCs.AppendFormat("\r\n" + "Add{0}RecordSave();",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "case \"确认修改\":");
                strCodeForCs.Append("\r\n" + "//这是一个单表的修改的代码,由于逻辑层太简单,");
                strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");

                strCodeForCs.AppendFormat("\r\n" + "Update{0}RecordSave(obj{0}EN);",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GenbtnOKUpd_Click4UC", "生成函数[btnOKUpd_Click]出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成函数[btnOKUpd_Click]出错!({1}: GenbtnOKUpd_Click4UC)\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        public string Genfun_SetAllComboBox4Query()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 下拉框的绑定函数");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void SetAllComboBox()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.objCtlType.CtlTypeName != "ComboBox") continue;

                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsComboBox.BindCbo_TrueAndFalse({0});",
                                    objQryRegionFldsEx.CtrlId4Win);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "cls{2}BL.BindCbo_{0}(this.cbo{1});",
                          objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.FldName,
                          objQryRegionFldsEx.ObjFieldTabENEx.CodeTabName);
                    }

                }
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Genfun_SetAllComboBox4Query", "生成查询区域绑定下拉框函数[SetAllComboBox]出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成查询区域绑定下拉框函数[SetAllComboBox]出错!({1}: SetAllComboBox())\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成界面控件属性
        /// </summary>
        /// <param name = "objViewInfoENEx"></param>
        /// <returns></returns>
        public string Genfun_ViewCtrlProperty4Query()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    ///如果该字段不为标识递增型就生成该字段控件,否则就不生成;
                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.Append("\r\n /// <summary>");
                        strCodeForCs.Append("\r\n /// 查询区的控件属性");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n /// </summary>");
                        strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                          objQryRegionFldsEx.ObjFieldTabENEx.CsType(),
                          objQryRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "return {0}.Checked;",
                                  objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = value;",
                                  objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;

                            case "ComboBox":  ///如果控件是下拉框;
                                if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                {
                                    strCodeForCs.Append("\r\n" + "get");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex == 1)",
                                      objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "return true;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "return false;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "set");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "if (value == true)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 1;",
                                      objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 2;",
                                      objQryRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "get");
                                    strCodeForCs.Append("\r\n" + "{");
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue.ToString() == \"0\")",
                                    objQryRegionFldsEx.CtrlId4Win);
                                        strCodeForCs.AppendFormat("\r\n" + "return 0;");
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Parse({1}.SelectedValue.ToString());",
                                         objQryRegionFldsEx.ObjFieldTabENEx.CsType(),
                                         objQryRegionFldsEx.CtrlId4Win);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue.ToString() == \"0\")",
                                    objQryRegionFldsEx.CtrlId4Win);
                                        strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.SelectedValue.ToString();",
                                          objQryRegionFldsEx.CtrlId4Win);
                                    }
                                  
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "set");
                                    strCodeForCs.Append("\r\n" + "{");
                                    if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                    {
                                        strCodeForCs.Append("\r\n" + "if (value == 0)");
                                        strCodeForCs.Append("\r\n" + "{");
                                        strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                                          objQryRegionFldsEx.CtrlId4Win);
                                        strCodeForCs.Append("\r\n" + "}");
                                        strCodeForCs.Append("\r\n" + "else");
                                        strCodeForCs.Append("\r\n" + "{");
                                        strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value.ToString();",
                                          objQryRegionFldsEx.CtrlId4Win);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    else
                                    {
                                        strCodeForCs.Append("\r\n" + "if (value == \"\")");
                                        strCodeForCs.Append("\r\n" + "{");
                                        strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                                          objQryRegionFldsEx.CtrlId4Win);
                                        strCodeForCs.Append("\r\n" + "}");
                                        strCodeForCs.Append("\r\n" + "else");
                                        strCodeForCs.Append("\r\n" + "{");
                                        strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value;",
                                          objQryRegionFldsEx.CtrlId4Win);
                                        strCodeForCs.Append("\r\n" + "}");
                                    }
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                break;

                            case "HyperLink":
                                break;

                            case "Image":
                                break;

                            case "ImageButton":
                                break;

                            case "Label":
                                break;

                            case "Link1Button":
                                break;

                            case "ListBox":
                                break;

                            case "Panel":
                                break;

                            case "RadioButton":
                                break;

                            case "RadioButtonList":
                                break;

                            case "TextBox":   ///如果控件类型是文本框;
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "short":
                                        strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "double":

                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "DateTime":

                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            default:

                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "short":
                                        strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "double":
                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "DateTime":
                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objQryRegionFldsEx.CtrlId4Win);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "");
                    }
                }
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GenViewCtrlProperty", "生成界面控件属性出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成界面控件属性出错!({1}: Public 0 1)\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Genfun_Clear4EditResion()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 清除用户自定义控件中,所有控件的值");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "public void Clear()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;",
                                      objEditRegionFldsEx.CtrlId4Win);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = {1};",
                                      objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "ComboBox":  ///如果控件是下拉框;
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                  objEditRegionFldsEx.CtrlId4Win);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox":   ///如果控件类型是文本框;

                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                      objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DefaValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                      objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }

                                break;
                            default:
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                      objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DefaValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                      objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GenfunClear", "生成清除函数(Clear())出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成清除函数(Clear())出错!({1}: Clear())\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Genfun_Clear4QryRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 清除用户自定义控件中,所有控件的值");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "public void Clear()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;",
                                      objQryRegionFldsEx.CtrlId4Win);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = {1};",
                                      objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "ComboBox":  ///如果控件是下拉框;
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                  objQryRegionFldsEx.CtrlId4Win);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox":   ///如果控件类型是文本框;

                                if (objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                      objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DefaValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                      objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                        objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DefaValue);

                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "GenfunClear", "生成清除函数(Clear())出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成清除函数(Clear())出错!({1}: Clear())\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Genfun_SetDefaultValue4EditRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 设置该控件在插入状态下的缺省值");
                strCodeForCs.Append("\r\n /// 一般规则:");
                strCodeForCs.Append("\r\n ///		1、如果是整型就默认为0；");
                strCodeForCs.Append("\r\n ///		2、如果是浮点型不默认为0.0；");
                strCodeForCs.Append("\r\n ///		3、如果是日期型就默认为当前的日期；");
                strCodeForCs.Append("\r\n ///		4、如果是位(bit)型就默认为false;");
                strCodeForCs.Append("\r\n ///		这些默认值可以再行修改");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public void SetDefaultValue()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///如果该字段不为标识递增型就生成该字段控件,否则就不生成;
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;", objEditRegionFldsEx.CtrlId4Win);
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "ComboBox":  ///如果控件是下拉框;
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                  objEditRegionFldsEx.CtrlId4Win);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox":   ///如果控件类型是文本框;
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                      objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DefaValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                      objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }

                                break;
                            default:
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                      objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DefaValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                      objEditRegionFldsEx.CtrlId4Win, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Genfun_SetDefaultValue", "生成设置控件缺省值函数(SetDefaultValue())出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成设置控件缺省值函数(SetDefaultValue())出错!({1}: SetDefaultValue())\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Genfun_SetDefaultValue4QryRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 设置该控件在插入状态下的缺省值");
                strCodeForCs.Append("\r\n /// 一般规则:");
                strCodeForCs.Append("\r\n ///		1、如果是整型就默认为0；");
                strCodeForCs.Append("\r\n ///		2、如果是浮点型不默认为0.0；");
                strCodeForCs.Append("\r\n ///		3、如果是日期型就默认为当前的日期；");
                strCodeForCs.Append("\r\n ///		4、如果是位(bit)型就默认为false;");
                strCodeForCs.Append("\r\n ///		这些默认值可以再行修改");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "public void SetDefaultValue()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    ///如果该字段不为标识递增型就生成该字段控件,否则就不生成;
                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = false;", objQryRegionFldsEx.CtrlId4Win);
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "ComboBox":  ///如果控件是下拉框;
                                strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 0;",
                                  objQryRegionFldsEx.CtrlId4Win);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox":   ///如果控件类型是文本框;
                                if (objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                      objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DefaValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                      objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }

                                break;
                            default:
                                if (objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                      objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.DefaValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.Text = \"{1}\";",
                                      objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                        }
                    }
                }
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Genfun_SetDefaultValue", "生成设置控件缺省值函数(SetDefaultValue())出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成设置控件缺省值函数(SetDefaultValue())出错!({1}: SetDefaultValue())\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Genfun_IsValid()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 校验自定义控件中自子控件的类型数值是否是合法正确的。");
                strCodeForCs.Append("\r\n /// 一般规则:");
                strCodeForCs.Append("\r\n ///		1、首先校验类型:整型、浮点型、日期型等,");
                strCodeForCs.Append("\r\n ///			这些代码由自动生成代码帮助生成");
                strCodeForCs.Append("\r\n ///		2、校验最值,即最大值和最小值等");
                strCodeForCs.Append("\r\n ///			这些代码由自动生成代码帮助生成");
                strCodeForCs.Append("\r\n ///		这些生成内容可以修改");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns></returns>");
                strCodeForCs.Append("\r\n" + "public bool IsValid(ref string strResult)");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.CtlTypeId == enumCtlType.DropDownList_06) continue;
                    if (objQryRegionFldsEx.CtlTypeId == enumCtlType.DropDownList_Bool_18) continue;

                    switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType())
                    {
                        case "int":
                        case "long":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsNumeric({0}.Text) == false)",
                              objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"请输入正确的整型!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "double":
                        case "float":
                        case "single":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsString.IsFloat({0}.Text) == false)",
                              objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"请输入正确的浮点型!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DateTime":
                            strCodeForCs.AppendFormat("\r\n" + "if (clsDateTime.IsDate({0}.Text) == false)",
                              objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "strResult = \"请输入正确的日期型!\";");
                            strCodeForCs.Append("\r\n" + "return false;");
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "bool":
                            break;
                        default:
                            break;

                    }
                }
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Genfun_IsValid", "生成校验函数(IsValid())出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成校验函数(IsValid())出错!({1}: IsValid())\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_btnQuery_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n" + "private void btnQuery_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//把表记录的内容显示在ListView中");
                strCodeForCs.AppendFormat("\r\n" + "BindLv_{0}();",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Gen_btnQuery_Click", "生成校验函数(btnQuery_Click())出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成校验函数(IsValid())出错!({1}: btnQuery_Click())\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_btnQuery_Click4Dgv()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n" + "private void btnQuery_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//把表记录的内容显示在ListView中");
                strCodeForCs.AppendFormat("\r\n" + "BindDgv_{0}();",
                objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Gen_btnQuery_Click", "生成校验函数(btnQuery_Click())出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成校验函数(IsValid())出错!({1}: btnQuery_Click())\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_lvListView_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.AppendFormat("\r\n" + "private void lv{0}_Click(object sender, System.EventArgs e)",
                 objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.JudgebtnDelRec(); //用来判断删除按钮是否可用");
                strCodeForCs.Append("\r\n" + "this.JudgebtnUpdate(); //用来判断修改按钮是否可用");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Gen_lvListView_Click", "生成校验函数(lv{0}_Click)出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成校验函数(IsValid())出错!({1}: lv{0}_Click)\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_btnUpdate_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:事件函数,当单击<确定修改>时发生的事件函数,");
                strCodeForCs.Append("\r\n ///      具体功能为把界面内容同步数据库中,把界面内容保存到数据库中");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"sender\"></param>");
                strCodeForCs.Append("\r\n /// <param name = \"e\"></param>");
                strCodeForCs.Append("\r\n" + "private void btnUpdate_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Update{2}Record();",
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                  objKeyField.PrivFuncName,
                  objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Gen_btnUpdate_Click", "生成单击<确定修改>时发生的事件函数出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成单击<确定修改>时发生的事件函数出错!({1}: btnUpdate_Click())\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 生成界面控件属性
        /// </summary>
        /// <param name = "objViewInfoENEx"></param>
        /// <returns></returns>
        public string Genfun_ViewCtrlProperty4Edit()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    ///如果该字段不为标识递增型就生成该字段控件,否则就不生成;
                    if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.Append("\r\n /// <summary>");
                        strCodeForCs.AppendFormat("\r\n /// {0}",
                          objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n /// </summary>");

                        strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                          objEditRegionFldsEx.ObjFieldTabENEx.CsType(), objEditRegionFldsEx.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "return {0}.Checked;",
                                  objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Checked = value;",
                                  objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;

                            case "ComboBox":  ///如果控件是下拉框;
                                if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                                {
                                    strCodeForCs.Append("\r\n" + "get");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedIndex == 1)",
                                      objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "return true;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "return false;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "set");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                                      objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "if (value == true)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 1;",
                                      objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedIndex = 2;",
                                      objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "get");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count == 0)",
                                      objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.SelectedValue.ToString() == \"0\")",
                                      objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.AppendFormat("\r\n" + "return \"\";");
                                    strCodeForCs.AppendFormat("\r\n" + "return {0}.SelectedValue.ToString();",
                                      objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "set");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.Items.Count>0)",
                                      objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "if (value == \"\")");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = \"0\";",
                                      objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "else");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.SelectedValue = value;",
                                      objEditRegionFldsEx.CtrlId4Win);
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "}");
                                }
                                break;

                            case "HyperLink":
                                break;

                            case "Image":
                                break;

                            case "ImageButton":
                                break;

                            case "Label":
                                break;

                            case "Link1Button":
                                break;

                            case "ListBox":
                                break;

                            case "Panel":
                                break;

                            case "RadioButton":
                                break;

                            case "RadioButtonList":
                                break;

                            case "TextBox":   ///如果控件类型是文本框;
                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "short":
                                        strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "double":

                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "DateTime":

                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            default:

                                strCodeForCs.Append("\r\n" + "get");
                                strCodeForCs.Append("\r\n" + "{");
                                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
                                {
                                    case "int":
                                        strCodeForCs.AppendFormat("\r\n" + "return int.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "short":
                                        strCodeForCs.AppendFormat("\r\n" + "return short.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;

                                    case "double":
                                        strCodeForCs.AppendFormat("\r\n" + "return double.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "DateTime":
                                        strCodeForCs.AppendFormat("\r\n" + "return DateTime.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "bool":
                                        strCodeForCs.AppendFormat("\r\n" + "return bool.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "float":
                                        strCodeForCs.AppendFormat("\r\n" + "return float.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    case "long":
                                        strCodeForCs.AppendFormat("\r\n" + "return long.Parse({0}.Text.Trim());", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                    default:
                                        strCodeForCs.AppendFormat("\r\n" + "return {0}.Text.Trim();", objEditRegionFldsEx.CtrlId4Win);
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "set");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "{0}.Text = value.ToString();", objEditRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "");
                    }
                }
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Genfun_ViewCtrlProperty4Edit", "生成界面编辑区域控件属性出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成界面编辑区域控件属性出错!({1}: Public 0 1())\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Genfun_SetAllComboBox4Edit()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 下拉框的绑定函数");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void SetAllComboBox()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldEx.objCtlType.CtlTypeName != "ComboBox") continue;

                    if (objEditRegionFldEx.ObjFieldTabENEx.CsType() == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsComboBox.BindCbo_TrueAndFalse({0});",
                                    objEditRegionFldEx.CtrlId4Win);
                    }
                    else
                    {

                        strCodeForCs.AppendFormat("\r\n" + "cls{2}BL.BindCbo_{3}(this.cbo{1});",
                          objEditRegionFldEx.ObjFieldTabENEx.FldName,
                          objEditRegionFldEx.ObjFieldTabENEx.FldName,
                          objEditRegionFldEx.ObjFieldTabENEx.CodeTabName,
                          objEditRegionFldEx.ObjFieldTabENEx.CodeTabCode);
                    }

                }
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception objException)
            {
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                    objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "Genfun_SetAllComboBox4Edit", "生成编辑区域绑定下拉框函数[SetAllComboBox]出错!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                string strMsg = string.Format("(errid:{2})生成编辑区域绑定下拉框函数[SetAllComboBox]出错!({1}: SetAllComboBox())\\r\\n" + objException.Message,
                    objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId);
                clsEntityBase.LogErrorS(objException, "");
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string GenGetDataFromClass()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;

                if ((objViewInfoENEx.IsUseCtl == false))
                {
                    ///从类中取数据传给窗体:private void GetDataFromClass;
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 函数功能:把类对象的属性内容显示到界面上");
                    strCodeForCs.Append("\r\n ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值");
                    strCodeForCs.Append("\r\n ///   如果在设置数据库时,就应该一级字段在前,二级字段在后");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"pobj{0}EN\">表实体类对象</param>",
                      objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "private void GetDataFrom{0}Class(cls" + objViewInfoENEx.TabName + "EN pobj" + objViewInfoENEx.TabName + "EN)", objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值");
                    strCodeForCs.Append("\r\n ///   如果在设置数据库时,就应该一级字段在前,二级字段在后");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "this.{1} = pobj{2}EN.{3};",
                              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 函数功能:把类对象的属性内容显示到界面上");
                    strCodeForCs.Append("\r\n ///注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值");
                    strCodeForCs.Append("\r\n ///   如果在设置数据库时,就应该一级字段在前,二级字段在后");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"pobj{0}EN\">表实体类对象</param>",
                      objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "private void GetDataFrom{0}Class(cls{1}EN pobj{2}EN)",
                      objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "uc{0}1.{1} = pobj{2}EN.{3};",
                              objViewInfoENEx.TabName, objEditRegionFldsEx.FldName, objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string GenPutDataToClass()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;
                //strCodeForCs.Append("\r\n" + "///1生成从界面层到逻辑层的数据传输函数代码");
                if ((objViewInfoENEx.IsUseCtl == false))
                {
                    ///从类中取数据传给窗体:private void PutDataToClass;
                    strCodeForCs.AppendFormat("\r\n" + "private void PutDataTo{0}Class(cls" + objViewInfoENEx.TabName + "EN pobj" + objViewInfoENEx.TabName + "EN)", objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{3};",
                              objViewInfoENEx.TabName,
                              objEditRegionFldsEx.FldName,
                              objViewInfoENEx.TabName,
                              objEditRegionFldsEx.FldName);
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// 函数功能:把界面上的属性数据传到类对象中");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"pobj{0}\">数据传输的目的类对象</param>",
                      objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "private void PutDataTo{0}Class(cls{1}EN pobj{2}EN)",
                      objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.PrimaryTypeId()!= clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = uc{2}1.{3};",
                              objViewInfoENEx.TabName,
                              objEditRegionFldsEx.FldName,
                              objViewInfoENEx.TabName,
                              objEditRegionFldsEx.FldName);
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "");
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 导出EXCEL文件事件函数。
        /// </summary>
        /// <returns></returns>
        public string gfunGenbtnExportExcel4Dg_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (objViewInfoENEx.arrExcelExportRegionFldSet == null || objViewInfoENEx.arrExcelExportRegionFldSet.Count == 0)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    string strViewName = objViewInfoENEx.ViewName;
                    sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有EXCEL导出区域,或者EXCEL导出区域没有字段。\r\n请检查!", strViewName);
                    sbMessage.AppendFormat("\r\n" + "当前模块名:{0},\r\n当前函数名:{1}。",
                      objViewInfoENEx.GetType().ToString(), "gfunGenbtnExportExcel4Dg_Click");
                    throw new clsDbObjException(sbMessage.ToString());
                }

                strCodeForCs.Append("\r\n" + "private void btnExportExcel4Dg_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = uc{0}Query1.Combine{0}Condition();",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = cls{0}BL.GetDataTable(strWhereCond);",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "ArrayList arrCnName = new ArrayList();");
                strCodeForCs.Append("\r\n" + "ArrayList arrColName = new ArrayList();");

                strCodeForCs.AppendFormat("\r\n" + "string strFileName = \"{0}信息导出.xls\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "string strFolderName;");
                strCodeForCs.Append("\r\n" + "string strDownLoadFileName;");
                foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "arrColName.Add(cls{2}EN.con_{0}); arrCnName.Add(\"{1}\");",
                      objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName,
                      objExcelExportRegionFldsEx.ColCaption,
                      objViewInfoENEx.TabName);
                }
                strCodeForCs.AppendFormat("\r\n" + "//strFolderName = Application.StartupPath + \"\\\\TempFiles\";");
                strCodeForCs.Append("\r\n" + "//if (Directory.Exists(strFolderName) == false)");
                strCodeForCs.Append("\r\n" + "//{");
                strCodeForCs.Append("\r\n" + "//Directory.CreateDirectory(strFolderName);");
                strCodeForCs.Append("\r\n" + "//}");
                strCodeForCs.Append("\r\n" + "//strDownLoadFileName = strFolderName + \"\\\\\" + strFileName;");

                strCodeForCs.Append("\r\n" + "System.Windows.Forms.SaveFileDialog objSaveFileDialog = new SaveFileDialog();");
                strCodeForCs.Append("\r\n" + "objSaveFileDialog.DefaultExt = \"xls\";");
                strCodeForCs.Append("\r\n" + "objSaveFileDialog.Filter = \"Excle文件(*.xls)|*.xls|所有文件(*.*)|*.*\";");
                strCodeForCs.Append("\r\n" + "objSaveFileDialog.ShowDialog();");
                strCodeForCs.Append("\r\n" + "strDownLoadFileName = objSaveFileDialog.FileName;");
                strCodeForCs.Append("\r\n" + "if (strDownLoadFileName == \"\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable objExcel = new GetExcelFromDataTable.clsGetExcelFromDataTable();");
                strCodeForCs.Append("\r\n" + "objExcel.GetExcelFromDataTableByArrAndArray(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "MessageBox.Show(\"导出Excel成功!,文件存放在:\" + strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 导出EXCEL文件,其中导出的字段完全与ListView一致。
        /// </summary>
        /// <returns></returns>
        public string gfunGenbtnExportExcel4ListView_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    string strViewName = objViewInfoENEx.ViewName;
                    sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有ListView区域,或者ListView区域没有字段。\r\n请检查!", strViewName);
                    sbMessage.AppendFormat("\r\n" + "当前模块名:{0},\r\n当前函数名:{1}。",
                      objViewInfoENEx.GetType().ToString(), "gfunGenbtnExportExcel4ListView_Click");
                    throw new clsDbObjException(sbMessage.ToString());
                }
                strCodeForCs.Append("\r\n" + "private void btnExportExcel4Dg_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "ExportExcel_SelColumns();	//新的导出EXCEL方式,用户可以选择导出字段列");
                strCodeForCs.Append("\r\n" + "//ExportExcel();	//原来的方式导出EXCEL,用户不能选择导出字段列");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 导出EXCEL文件的函数,。
        /// </summary>
        /// <returns></returns>
        public string gfunGenExportExcel()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (objViewInfoENEx.arrExcelExportRegionFldSet == null || objViewInfoENEx.arrExcelExportRegionFldSet.Count == 0)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    string strViewName = objViewInfoENEx.ViewName;
                    sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有EXCEL导出区域,或者EXCEL导出区域没有字段。\r\n请检查!", strViewName);
                    sbMessage.AppendFormat("\r\n" + "当前模块名:{0},\r\n当前函数名:{1}。",
                      objViewInfoENEx.GetType().ToString(), "gfunGenExportExcel");
                    throw new clsDbObjException(sbMessage.ToString());
                }
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 导出EXCEL的函数");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void ExportExcel()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                if (objViewInfoENEx.IsUseCtl == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = uc{0}Query1.Combine{0}Condition();",
                      objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = this.Combine{0}Condition();",
                      objViewInfoENEx.TabName);

                }
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = cls{0}BL.GetDataTable(strWhereCond);",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "ArrayList arrCnName = new ArrayList();");
                strCodeForCs.Append("\r\n" + "ArrayList arrColName = new ArrayList();");

                strCodeForCs.AppendFormat("\r\n" + "//string strFileName = string.Format(\"{0}导出{{0}}.xls\", clsDateTime.GetToday2(0));",
                  objViewInfoENEx.objOutRelaTab.TabCnName, "{", "}");
                strCodeForCs.Append("\r\n" + "//string strFolderName;");
                strCodeForCs.Append("\r\n" + "string strDownLoadFileName;");
                foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "arrColName.Add(cls{2}EN.con_{0}); arrCnName.Add(\"{1}\");",
                      objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName,
                      objExcelExportRegionFldsEx.ColCaption,
                      objViewInfoENEx.TabName_Out);
                }
                strCodeForCs.AppendFormat("\r\n" + "//strFolderName = Application.StartupPath + \"\\\\TempFiles\";");
                strCodeForCs.Append("\r\n" + "//if (Directory.Exists(strFolderName) == false)");
                strCodeForCs.Append("\r\n" + "//{");
                strCodeForCs.Append("\r\n" + "//Directory.CreateDirectory(strFolderName);");
                strCodeForCs.Append("\r\n" + "//}");
                strCodeForCs.Append("\r\n" + "//strDownLoadFileName = strFolderName + \"\\\\\" + strFileName;");

                strCodeForCs.Append("\r\n" + "System.Windows.Forms.SaveFileDialog objSaveFileDialog = new SaveFileDialog();");
                strCodeForCs.Append("\r\n" + "objSaveFileDialog.DefaultExt = \"xls\";");
                strCodeForCs.Append("\r\n" + "objSaveFileDialog.Filter = \"Excle文件(*.xls)|*.xls|所有文件(*.*)|*.*\";");
                strCodeForCs.Append("\r\n" + "objSaveFileDialog.ShowDialog();");
                strCodeForCs.Append("\r\n" + "strDownLoadFileName = objSaveFileDialog.FileName;");
                strCodeForCs.Append("\r\n" + "if (strDownLoadFileName == \"\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "GetExcelFromDataTable.clsGetExcelFromDataTable objExcel = new GetExcelFromDataTable.clsGetExcelFromDataTable();");
                strCodeForCs.Append("\r\n" + "objExcel.GetExcelFromDataTableByArrAndArray(objDT, arrColName, arrCnName, strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "MessageBox.Show(\"导出Excel成功!,文件存放在:\" + strDownLoadFileName);");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 导出EXCEL文件的函数,。
        /// </summary>
        /// <returns></returns>
        public string gfunGenExportExcel_SelColumns()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                if (objViewInfoENEx.arrExcelExportRegionFldSet == null || objViewInfoENEx.arrExcelExportRegionFldSet.Count == 0)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    string strViewName = objViewInfoENEx.ViewName;
                    sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有EXCEL导出区域,或者EXCEL导出区域没有字段。\r\n请检查!", strViewName);
                    sbMessage.AppendFormat("\r\n" + "当前模块名:{0},\r\n当前函数名:{1}。",
                      objViewInfoENEx.GetType().ToString(), "gfunGenExportExcel_SelColumns");
                    throw new clsDbObjException(sbMessage.ToString());
                }
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 导出EXCEL的函数, 导出EXCEL时可以选择列");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void ExportExcel_SelColumns()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                if (objViewInfoENEx.IsUseCtl == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = uc{0}Query1.Combine{0}Condition();",
                      objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = this.Combine{0}Condition();",
                      objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "//	2、设置表列数据字段名,以及表列标题");
                strCodeForCs.Append("\r\n" + "ArrayList arrCnName = new ArrayList();");
                strCodeForCs.Append("\r\n" + "ArrayList arrColName = new ArrayList();");
                foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "arrColName.Add(cls{2}EN.con_{0}); arrCnName.Add(\"{1}\");",
                      objExcelExportRegionFldsEx.ObjFieldTabENEx.FldName,
                      objExcelExportRegionFldsEx.ColCaption,
                      objViewInfoENEx.TabName_Out);
                }

                strCodeForCs.Append("\r\n" + "ArrayList arrExportExcelList = new ArrayList();");
                strCodeForCs.Append("\r\n" + "clsExportField objExportField = null;");
                strCodeForCs.Append("\r\n" + "int intColNum = arrColName.Count;");
                strCodeForCs.Append("\r\n" + "for(int i = 0; i<intColNum; i++)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "objExportField = new clsExportField();");
                strCodeForCs.Append("\r\n" + "objExportField.FieldEnglishName = arrColName[i].ToString();");
                strCodeForCs.Append("\r\n" + "objExportField.FieldChineseName = arrCnName[i].ToString();");
                strCodeForCs.Append("\r\n" + "arrExportExcelList.Add(objExportField);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n /// 3、调用公用的导出EXCEL的界面,选择列后再导出");
                strCodeForCs.Append("\r\n" + "frmExportExcel frm1 = new frmExportExcel();");
                strCodeForCs.Append("\r\n" + "frm1.arrExportExcelList = arrExportExcelList;");
                strCodeForCs.AppendFormat("\r\n" + "frm1.strTableName = \"{0}\";",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "frm1.strTableChineseName = \"{0}\";",
                  objViewInfoENEx.objOutRelaTab.TabCnName);
                strCodeForCs.AppendFormat("\r\n" + "frm1.strViewName = \"{0}\";",
                  objViewInfoENEx.ViewCnName);
                strCodeForCs.Append("\r\n" + "frm1.strWhereCondition = strWhereCond;");

                strCodeForCs.Append("\r\n" + "frm1.Show();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 把表中内容绑定到ListView。
        /// </summary>
        /// <returns></returns>
        public string gfunGenBindListView()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //strCodeForCs.Append("\r\n //1/生成绑定ListView的代码");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:根据界面上查询控件中所设置内容查询表记录,");
                strCodeForCs.Append("\r\n ///			 并显示在ListView中。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "private void BindLv_{0}()",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(共4步)");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "//	3、设置ListView的列头信息");
                strCodeForCs.Append("\r\n" + "//	4、设置ListView的Item信息。即把所有记录显示在ListView中");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件lblRecCount中。");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "ListViewItem lvi{0}; ",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst;",
                  objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                if (objViewInfoENEx.IsUseCtl == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = uc{0}Query1.Combine{0}Condition();	// Combine{0}Condition();",
                      objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = this.Combine{0}Condition();	// Combine{0}Condition();",
                      objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = cls{0}BL.GetObjLst(strWhereCond);",
          objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "MessageBox.Show(objException.Message);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//	3、设置ListView的列头信息");
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Items.Clear();//清除原来所有Item",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Columns.Clear();//清除原来所有列头信息",
                  objViewInfoENEx.TabName_Out);
                foreach (clsDGRegionFldsENEx ObjLstViewRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (ObjLstViewRegionFldsEx.ObjFieldTabENEx == null) continue;
                    if (ObjLstViewRegionFldsEx.ObjFieldTabENEx.CsType() == "byte[]") continue;
                    strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Columns.Add(\"{1}\", 100, HorizontalAlignment.Left);",
                      objViewInfoENEx.TabName_Out,
                      ObjLstViewRegionFldsEx.HeaderText);
                }
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.View = View.Details;",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "//	4、设置ListView的Item信息。即把所有记录显示在ListView中");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLst)",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "lvi{0} = new ListViewItem();",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Tag = obj{0}EN.{1};",
                  objViewInfoENEx.TabName_Out,
                  objKeyField.ObjFieldTabENEx.FldName);
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long"
                  || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Text = obj{0}EN.{1}.ToString();",
                      objViewInfoENEx.TabName_Out,
                      objKeyField.ObjFieldTabENEx.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Text = obj{0}EN.{1};",
                     objViewInfoENEx.TabName_Out,
                     objKeyField.ObjFieldTabENEx.FldName);
                }
                foreach (clsDGRegionFldsENEx ObjLstViewRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (ObjLstViewRegionFldsEx.ObjFieldTabENEx == null) continue;
                    if (objKeyField.FldId == ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldId)
                    {
                        continue;
                    }
                    strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1}.ToString());",
                            objViewInfoENEx.TabName_Out,
                            ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                    //if (ObjLstViewRegionFldsEx.ObjFieldTabENEx.IsTabForeignKey == false
                    //  && ObjLstViewRegionFldsEx.ObjFieldTabENEx.CsType() != "byte[]")
                    //{
                    //    if (ObjLstViewRegionFldsEx.ObjFieldTabENEx.CsType() == "string")
                    //    {
                    //        strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1});",
                    //          objViewInfoENEx.TabName_Out,
                    //          ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                    //    }
                    //    else
                    //    {
                    //        strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1}.ToString());",
                    //          objViewInfoENEx.TabName_Out,
                    //          ObjLstViewRegionFldsEx.ObjFieldTabENEx.FldName);
                    //    }
                    //}
                }
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Items.Add(lvi{0});",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//	4、设置记录数的状态,");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件txtRecCount中。");
                strCodeForCs.AppendFormat("\r\n" + "this.lblRecNum.Text = \"记录数:\" + arr{0}ObjLst.Count.ToString();",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 把表中内容绑定到DataGridView。
        /// </summary>
        /// <returns></returns>
        public string gfunGenBindDataGridView()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n ///生成绑定DataGridView的代码");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:根据界面上查询控件中所设置内容查询表记录,");
                strCodeForCs.Append("\r\n ///			 并显示在DataGridView中。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "private void BindDgv_{0}()",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(共4步)");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "//	3、设置ListView的列头信息");
                strCodeForCs.Append("\r\n" + "//	4、设置ListView的Item信息。即把所有记录显示在ListView中");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件lblRecCount中。");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "ListViewItem lvi{0}; ",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "DataTable objDT;",
                  objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                if (objViewInfoENEx.IsUseCtl == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = uc{0}Query1.Combine{0}Condition();	// Combine{0}Condition();",
                      objViewInfoENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = this.Combine{0}Condition();	// Combine{0}Condition();",
                      objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.AppendFormat("\r\n" + "objDT = cls{0}BL.GetDataTable(strWhereCond);",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "BindDgv_{0}", "获取数据不成功!", "生成代码");

                //strCodeForCs.AppendFormat("\r\n" + "lblMsg_Edit.Text = \"(errid:{0})生成函数[btnOKUpd_Click]出错!\";", strErrId);

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{2})获取数据不成功!({1}: BindDgv_{0})错误信息:{{0}}.\", objException.Message);",
                 objViewInfoENEx.TabName, objViewInfoENEx.WebFormName, strErrId, "{", "}");

                strCodeForCs.Append("\r\n" + "MessageBox.Show(strMsg);");
                strCodeForCs.Append("\r\n" + "lblMsg.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.AutoGenerateColumns = false;", objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.dgv{0}.DataSource = objDT;", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "//	4、设置记录数的状态,");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件txtRecCount中。");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Text = \"记录数:\" + objDT.Rows.Count.ToString();");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 用来判断删除按钮是否可用。
        /// </summary>
        /// <returns></returns>
        public string gfunGenJudgebtnDelete()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:用来判断删除按钮是否可用。");
                strCodeForCs.Append("\r\n ///			 如果在LISTVIEW中选中记录就显示删除按钮,否则就不显示");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void JudgebtnDelRec()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (this.lv{0}.SelectedItems.Count >= 1)",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Enabled = true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{       ");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Enabled = false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 用来判断删除按钮是否可用。
        /// </summary>
        /// <returns></returns>
        public string gfunGenJudgebtnDelete4DataGridView()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:用来判断删除按钮是否可用。");
                strCodeForCs.Append("\r\n ///			 如果在LISTVIEW中选中记录就显示删除按钮,否则就不显示");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void JudgebtnDelRec()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (this.dgv{0}.SelectedRows.Count >= 1)",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Enabled = true;");
                strCodeForCs.Append("\r\n" + "return ;");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{       ");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Enabled = false;");
                strCodeForCs.Append("\r\n" + "}");
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                {
                    strCodeForCs.AppendFormat("\r\n" + "long lngKeyId = GetCurrKey(dgv{0});",
                    objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + "if (lngKeyId == 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "this.btnDelRec.Enabled = false;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{       ");
                    strCodeForCs.Append("\r\n" + "this.btnDelRec.Enabled = true;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "int intKeyId = GetCurrKey(dgv{0});",
                    objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + "if (intKeyId == 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "this.btnDelRec.Enabled = true;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{       ");
                    strCodeForCs.Append("\r\n" + "this.btnDelRec.Enabled = false;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "string strKeyId = GetCurrKey(dgv{0});",
                              objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strKeyId) == false)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "this.btnDelRec.Enabled = true;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{       ");
                    strCodeForCs.Append("\r\n" + "this.btnDelRec.Enabled = false;");
                    strCodeForCs.Append("\r\n" + "}");
                }

                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        //第十步:生成获取DataGrid中当前行的主键值。
        public string gfunGenGetCurrKey4DataGrid()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //第十步:生成获取DataGrid中当前行的主键值。
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 获取DataGrid中当前行的主键值");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"objDataGrid\">所单击的DataGrid</param>");
                strCodeForCs.Append("\r\n /// <returns>当前行的主键值</returns>");
                strCodeForCs.AppendFormat("\r\n" + "private {0} GetCurrKey(DataGrid objDataGrid)",
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "int intCurrRow = objDataGrid.CurrentRowIndex;");
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                {
                    strCodeForCs.AppendFormat("\r\n" + "string str{1} = objDT{2}.Rows[intCurrRow][\"{3}\"].ToString();",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.FldName, objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);

                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = long.Parse(str{2});",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "return {0};",
                      objKeyField.PrivFuncName);
                }
                else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "string str{1} = objDT{2}.Rows[intCurrRow][\"{3}\"].ToString();",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.FldName, objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);

                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = int.Parse(str{2});",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "return {0};",
                      objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = objDT{2}.Rows[intCurrRow][\"{3}\"].ToString();",
                   objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName, objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "return {0};",
                      objKeyField.PrivFuncName);

                }
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        //第十步:生成获取DataGrid中当前行的主键值。
        public string gfunGenGetCurrKey4DataGridView()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //第十步:生成获取DataGrid中当前行的主键值。
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 获取DataGrid中当前行的主键值");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"objDataGrid\">所单击的DataGrid</param>");
                strCodeForCs.Append("\r\n /// <returns>当前行的主键值</returns>");
                strCodeForCs.AppendFormat("\r\n" + "private {0} GetCurrKey(DataGridView objDataGridView)",
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n" + "{");
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                {
                    strCodeForCs.Append("\r\n" + "if (objDataGridView.CurrentRow == null) return 0;");
                    strCodeForCs.AppendFormat("\r\n" + "string str{1} = objDataGridView.CurrentRow.Cells[\"dgvc{1}\"].Value.ToString();",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.FldName, objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\") return 0;",
                          objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = long.Parse(str{2});",
                          objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                          objKeyField.PrivFuncName,
                          objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "return {0};",
                          objKeyField.PrivFuncName);
                }
                else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                {
                    strCodeForCs.Append("\r\n" + "if (objDataGridView.CurrentRow == null) return \"\";");

                    strCodeForCs.AppendFormat("\r\n" + "string str{1} = objDataGridView.CurrentRow.Cells[\"dgvc{1}\"].Value.ToString();",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.FldName_FstUcase, objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\") return 0;",
                          objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = int.Parse(str{2});",
                          objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                          objKeyField.PrivFuncName,
                          objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "return {0};",
                          objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "if (objDataGridView.CurrentRow == null) return \"\";");
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = objDataGridView.CurrentRow.Cells[\"dgvc{3}\"].Value.ToString();",
                         objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName, objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                    strCodeForCs.AppendFormat("\r\n" + "return {0};",
                      objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 获取DataGrid中当前行的主键值");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"objDataGrid\">所单击的DataGrid</param>");
                strCodeForCs.Append("\r\n /// <returns>当前行的主键值</returns>");
                strCodeForCs.AppendFormat("\r\n" + "private {0} GetCurrKey(DataGridViewRow objDataGridViewRow)",
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n" + "{");
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                {
                    strCodeForCs.Append("\r\n" + "if (objDataGridViewRow == null) return 0;");

                    strCodeForCs.AppendFormat("\r\n" + "string str{1} = objDataGridViewRow.Cells[\"dgvc{3}\"].Value.ToString();",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.FldName, objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);

                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = long.Parse(str{2});",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "return {0};",
                      objKeyField.PrivFuncName);
                }
                else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "string str{1} = objDataGridViewRow.Cells[\"dgvc{3}\"].Value.ToString();",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.FldName, objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);

                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = int.Parse(str{2});",
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "return {0};",
                      objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = objDataGridViewRow.Cells[\"dgvc{3}\"].Value.ToString();",
                         objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName, objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "return {0};",
                      objKeyField.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "}");



            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //第十步:生成获取ListView中当前行的主键值。
        public string gfunGenGetCurrKey4ListView()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                //第十步:生成获取ListView中当前行的主键值。

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 获取ListView中当前行的主键值");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"ObjLstView\">所单击的ListView</param>");
                strCodeForCs.Append("\r\n /// <returns>当前行的主键值</returns>");
                strCodeForCs.AppendFormat("\r\n" + "private {0} GetCurrKey(ListView ObjLstView)",
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (ObjLstView.SelectedItems.Count == 0)");
                strCodeForCs.Append("\r\n" + "{");
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long"
                  || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                {
                    strCodeForCs.Append("\r\n" + "return 0;");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "return \"\";");
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "ListViewItem lvi{0};",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0} = ObjLstView.SelectedItems[0];",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "string str{0}Id = lvi{0}.Tag.ToString();",
                  objViewInfoENEx.TabName);
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long"
                  || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                {

                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(str{2}Id);",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName,
                        objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "return {0};",
                       objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "return str{0}Id;",
                      objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 获取ListView所给项的主键值");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <param name = \"ObjLstView\">所单击的ListView项</param>");
                strCodeForCs.Append("\r\n /// <returns>当前行的主键值</returns>");
                strCodeForCs.AppendFormat("\r\n" + "private {0} GetCurrKey(ListViewItem ObjLstViewItem)",
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string str{0}Id = ObjLstViewItem.Tag.ToString();",
                  objViewInfoENEx.TabName);
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long"
                  || objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                {

                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = {0}.Parse(str{2}Id);",
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName,
                        objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "return {0};",
                       objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "return str{0}Id;",
                      objViewInfoENEx.TabName);
                }
                strCodeForCs.Append("\r\n" + "}");



            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 用来判断修改按钮是否可用。
        /// </summary>
        /// <returns></returns>
        public string gfunGenJudgebtnUpdate()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:用来判断删除按钮是否可用。");
                strCodeForCs.Append("\r\n ///			 如果在LISTVIEW中选中记录就显示删除按钮,否则就不显示");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void JudgebtnUpdate()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (this.lv{0}.SelectedItems.Count >= 1)",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Enabled = true;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{       ");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Enabled = false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 用来判断修改按钮是否可用。
        /// </summary>
        /// <returns></returns>
        public string gfunGenJudgebtnUpdate4DataGridView()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:用来判断删除按钮是否可用。");
                strCodeForCs.Append("\r\n ///			 如果在LISTVIEW中选中记录就显示删除按钮,否则就不显示");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void JudgebtnUpdate()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (this.dgv{0}.SelectedRows.Count >= 1)",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Enabled = true;");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{       ");
                strCodeForCs.Append("\r\n" + "this.btnUpdate.Enabled = false;");
                strCodeForCs.Append("\r\n" + "}");

                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "long")
                {
                    strCodeForCs.AppendFormat("\r\n" + "long lngKeyId = GetCurrKey(dgv{0});",
                    objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + "if (lngKeyId == 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "this.btnUpdate.Enabled = false;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{       ");
                    strCodeForCs.Append("\r\n" + "this.btnUpdate.Enabled = true;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "int")
                {
                    strCodeForCs.AppendFormat("\r\n" + "int intKeyId = GetCurrKey(dgv{0});",
                    objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + "if (intKeyId == 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "this.btnUpdate.Enabled = true;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{       ");
                    strCodeForCs.Append("\r\n" + "this.btnUpdate.Enabled = false;");
                    strCodeForCs.Append("\r\n" + "}");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "string strKeyId = GetCurrKey(dgv{0});",
                              objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strKeyId) == false)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "this.btnUpdate.Enabled = true;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{       ");
                    strCodeForCs.Append("\r\n" + "this.btnUpdate.Enabled = false;");
                    strCodeForCs.Append("\r\n" + "}");
                }


                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 实现接口函数,通过子窗体调用,来实现本窗体(父窗体)的LISTVIEW重新绑定功能。
        /// </summary>
        /// <returns></returns>
        public string gfunGenIBindListView_BindListView()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 实现接口函数,通过子窗体调用,来实现本窗体(父窗体)的LISTVIEW重新绑定功能");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "void IBindListView.BindListView()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "BindLv_{0}();",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 实现接口函数,通过子窗体调用,来实现本窗体(父窗体)的LISTVIEW重新绑定功能。
        /// </summary>
        /// <returns></returns>
        public string gfunGenIBindListView_BindListView4DataGridView()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 实现接口函数,通过子窗体调用,来实现本窗体(父窗体)的LISTVIEW重新绑定功能");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "void IBindListView.BindListView()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "BindDgv_{0}();",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 生成LISTVIEW 列单击的排序函数
        /// </summary>
        /// <returns></returns>
        public string gfunGenListView_ColumnClick()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:LISTVIEW的列单击事件函数");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "private void lv{0}_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (e.Column == this.obj{0}Sorter.SortColumn)",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "this.obj{0}Sorter.SortColumn = e.Column;",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "if (this.obj{0}Sorter.SortOrder == SortOrder.Ascending)",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "this.obj{0}Sorter.SortOrder = SortOrder.Descending;",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "if(intLastSelected{0}ColumIndex == e.Column) //看是否重复点击一列",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Columns[e.Column].Text = this.lv{0}.Columns[e.Column].Text.Trim('▲','▼') + \"▼\";",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "intLastSelected{0}ColumIndex = e.Column;",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else //如果点击另外一列了,那么前面点击的一列三角去掉");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Columns[e.Column].Text = this.lv{0}.Columns[e.Column].Text.Trim('▲','▼') + \"▼\";",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Columns[intLastSelected{0}ColumIndex].Text = this.lv{0}.Columns[intLastSelected{0}ColumIndex].Text.Trim('▼','▲');",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "intLastSelected{0}ColumIndex = e.Column;",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "else if (this.obj{0}Sorter.SortOrder == SortOrder.Descending) // ▲ ▼",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "this.obj{0}Sorter.SortOrder = SortOrder.Ascending;",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "if(intLastSelected{0}ColumIndex == e.Column)",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Columns[e.Column].Text = this.lv{0}.Columns[e.Column].Text.Trim('▲','▼') + \"▲\";",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "intLastSelected{0}ColumIndex = e.Column;",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Columns[e.Column].Text = this.lv{0}.Columns[e.Column].Text.Trim('▲','▼') + \"▲\";",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Columns[intLastSelected{0}ColumIndex].Text = this.lv{0}.Columns[intLastSelected{0}ColumIndex].Text.Trim('▲','▼');",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "intLastSelected{0}ColumIndex = e.Column;",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "return ;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "this.lv{0}.Sort();",
                  objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string GenCombineCondition(List<clsQryRegionFldsENEx> ArrQueryCtlList, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>条件串(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public string Combine{0}Condition()", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "Button":
                            break;
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                              objQryRegionFldsEx.CtrlId4Win);
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", cls{1}EN.con_{0});",
                              objQryRegionFldsEx.FldName,
                                objViewInfoENEx.TabName_Out,
                                   "{", "}");
                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", cls{1}EN.con_{0});",
                              objQryRegionFldsEx.FldName,
                                objViewInfoENEx.TabName_Out,
                                   "{", "}");
                            break;
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "ComboBox":  ///如果控件是下拉框;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedIndex == 1)",
                                  objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", cls{1}EN.con_{0}); ",
                                   objQryRegionFldsEx.FldName,
                                  objViewInfoENEx.TabName_Out,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if (this.{0}.SelectedIndex == 2)",
                                  objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\",cls{1}EN.con_{0});",
                                  objQryRegionFldsEx.FldName,
                                  objViewInfoENEx.TabName_Out,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.SelectedValue.ToString()!= \"\" && this.{1}.SelectedValue.ToString()!= \"0\")",
                                  objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1}.SelectedValue);",
                                  objQryRegionFldsEx.FldName,
                                  objQryRegionFldsEx.CtrlId4Win,
                                  objViewInfoENEx.TabName_Out,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                        case "HyperLink":
                            break;
                        case "Image":
                            break;
                        case "ImageButton":
                            break;
                        case "Label":
                            break;
                        case "Link1Button":
                            break;
                        case "ListBox":
                            break;
                        case "Panel":
                            break;
                        case "RadioButton":
                            break;
                        case "RadioButtonList":
                            break;
                        case "TextBox":   ///如果控件类型是文本框;
                            if ((objQryRegionFldsEx.QueryOptionId == "00") || (objQryRegionFldsEx.QueryOptionId == "01"))  ///相等查询;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {4}0{5} = '{4}1{5}'\", cls{3}EN.con_{0}, this.{1}.Text.Trim());",
                                  objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win,
                                  objViewInfoENEx.TabName,
                                  objViewInfoENEx.TabName_Out,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "02")   ///模糊查询;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {4}0{5} like '%{4}1{5}%'\", cls{3}EN.con_{0}, this.{1}.Text.Trim());",
                                  objQryRegionFldsEx.FldName,
                                  objQryRegionFldsEx.CtrlId4Win,
                                  objViewInfoENEx.TabName,
                                  objViewInfoENEx.TabName_Out,
                                "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == "03")
                            {   ///范围查询;
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1}.Text.Trim());",
                                  objQryRegionFldsEx.FldName,
                                  objQryRegionFldsEx.CtrlId4Win,
                                  objViewInfoENEx.TabName_Out,
                                "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Text.Trim()!= \"\")", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '{{1}}'\", cls{2}EN.con_{0}, this.{1}.Text.Trim());",
                                      objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.CtrlId4Win,
                                     objViewInfoENEx.TabName_Out,
                                     "{", "}");
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;
                    }
                }
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

     
        protected void CheckEditRegion()
        {
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }
        }

        protected void CheckDGRegion()
        {
            if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有DG区域,或者DG区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }
        }

        protected void CheckListViewRegion()
        {
            if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有ListView区域,或者ListView区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }
        }


        protected void CheckQueryRegion()
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null || objViewInfoENEx.arrQryRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有查询区域,或者查询区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }
        }

        protected void CheckExcelExportRegion()
        {
            if (objViewInfoENEx.arrExcelExportRegionFldSet == null || objViewInfoENEx.arrExcelExportRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有Excel导出区域,或者Excel导出区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }
        }


        public string A_GenQueryRecCode(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            Point pntLocation = new Point();
            string strTemp;
            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);

            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_Q";
           objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.WebFormFName = "frm" + objViewInfoENEx.TabName + "_Q.cs";
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}",
                objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName != "DropDownList") continue;

                    objEditRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                    objEditRegionFldsEx.CtrlId4Win = objEditRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");

                }

                //第一步:生成导入域名空间

                //类名开始
                ///
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//生成与表相关的控件控制层代码");
                strCodeForCs.Append("\r\n" + "using System;");
                strCodeForCs.Append("\r\n" + "using System.Collections;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                strCodeForCs.Append("\r\n" + "using System.Data;");
                strCodeForCs.Append("\r\n" + "using System.Drawing;");
                strCodeForCs.Append("\r\n" + "using System.IO;");
                strCodeForCs.Append("\r\n" + "using System.Windows.Forms;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
          

                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);

                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Form", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //第二步:生成控件类名
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_Q 的摘要说明。", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public class frm{0}_Q : System.Windows.Forms.Form", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //第三步:生成控件中内部控件变量的名称
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Button btnQuery;");
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.DataGrid dg{0};",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Button btnExportExcel4Dg;");
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label lblRecNum;");
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;");
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (objDGRegionFldsEx.ObjFieldTabENEx == null) continue;

                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.DataGridTextBoxColumn dataGridTxt{0};",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                }
                strCodeForCs.AppendFormat("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "private {0}.uc{1}Query uc{1}Query1;",
                  objViewInfoENEx.NameSpace, objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "private System.Data.DataTable objDT{0};",
                  objViewInfoENEx.TabName);

                //第四步:生成必需的设计器变量
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 必需的设计器变量。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private System.ComponentModel.Container components = null;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "public frm{0}_Q()",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 该调用是 Windows.Forms 窗体设计器所必需的。");
                strCodeForCs.Append("\r\n" + "InitializeComponent();");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "// TODO: 在 InitializeComponent 调用后添加任何初始化");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                //第五步:清理所有正在使用的资源
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 清理所有正在使用的资源。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected override void Dispose( bool disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if( disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if(components != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "components.Dispose();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "base.Dispose( disposing);");
                strCodeForCs.Append("\r\n" + "}");
                //第六步:组件设计器生成的代码

                strCodeForCs.Append("\r\n" + "#region 组件设计器生成的代码");
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 设计器支持所需的方法 - 不要使用代码编辑器 ");
                strCodeForCs.Append("\r\n /// 修改此方法的内容。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void InitializeComponent()");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}Query1 = new {1}.uc{0}Query();",
                  objViewInfoENEx.TabName, objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "this.btnQuery = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.lblRecNum = new System.Windows.Forms.Label();");
                strCodeForCs.Append("\r\n" + "this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();");
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (objDGRegionFldsEx.ObjFieldTabENEx == null) continue;

                    strCodeForCs.AppendFormat("\r\n" + "this.dataGridTxt{0} = new System.Windows.Forms.DataGridTextBoxColumn();",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName);

                }

                strCodeForCs.AppendFormat("\r\n" + "this.dg{0} = new System.Windows.Forms.DataGrid();",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "((System.ComponentModel.ISupportInitialize)(this.dg{0})).BeginInit();",
                  objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "this.SuspendLayout();");

                int intIndex = 1;
                pntLocation.X = 10;
                pntLocation.Y = 10;


                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// uc{0}Query1",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}Query1.Location = new System.Drawing.Point(0, 0);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}Query1.Name = \"uc{0}Query1\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}Query1.Size = new System.Drawing.Size(400, 60);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}Query1.TabIndex = {1};",
                  objViewInfoENEx.TabName, intIndex++);


                //
                //查询按钮<btnQuery>
                //
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnQuery");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Location = new System.Drawing.Point(508, 16);");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Name = \"btnQuery\";");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Size = new System.Drawing.Size(80, 20);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnQuery.TabIndex = {0};",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnQuery.Text = \"查询\";");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);");

                // 
                // btnExportExcel4Dg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnExportExcel4Dg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Location = new System.Drawing.Point(524, 56);");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Name = \"btnExportExcel4Dg\";");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Size = new System.Drawing.Size(80, 20);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnExportExcel4Dg.TabIndex = {0};",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Text = \"导出Excel\";");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Click += new System.EventHandler(this.btnExportExcel4Dg_Click);");

                strCodeForCs.AppendFormat("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// dg{0}",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.DataMember = \"\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.HeaderForeColor = System.Drawing.SystemColors.ControlText;",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.Location = new System.Drawing.Point(8, 80);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.Name = \"dg{0}\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.Size = new System.Drawing.Size(624, 152);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.TabIndex = {1};",
                  objViewInfoENEx.TabName, intIndex++);
                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] ",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{this.dataGridTableStyle1});");

                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.Click += new System.EventHandler(this.dg{0}_Click);",
                  objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// dataGridTableStyle1");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.dataGridTableStyle1.DataGrid = this.dg{0};",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {");
                bool bolIsFirst = true;
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (objDGRegionFldsEx.ObjFieldTabENEx == null) continue;

                    if (bolIsFirst == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.dataGridTxt{0}",
                          objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                        bolIsFirst = false;
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + ", this.dataGridTxt{0}",
                          objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                    }
                }
                strCodeForCs.Append(" });");
                strCodeForCs.Append("\r\n" + "this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;");
                strCodeForCs.Append("\r\n" + "this.dataGridTableStyle1.MappingName = \"\";");

                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (objDGRegionFldsEx.ObjFieldTabENEx == null) continue;

                    strCodeForCs.Append("\r\n" + "// ");
                    strCodeForCs.AppendFormat("\r\n" + "// dataGridTxt{0}",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "// ");
                    strCodeForCs.AppendFormat("\r\n" + "this.dataGridTxt{0}.Format = \"\";",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.dataGridTxt{0}.FormatInfo = null;",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.dataGridTxt{0}.HeaderText = \"{1}\";",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName,
                      objDGRegionFldsEx.HeaderText);
                    strCodeForCs.AppendFormat("\r\n" + "this.dataGridTxt{0}.MappingName = \"{0}\";",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.dataGridTxt{0}.Width = 75;",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName);

                }
                // 
                // lblRecNum
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblRecNum");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Location = new System.Drawing.Point(16, 240);");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Name = \"lblRecNum\";");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Size = new System.Drawing.Size(112, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblRecNum.TabIndex = {0};",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Text = \"记录数:\";");


                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// uc{0}",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//");
                //向控件的内部控件集合中添加内部控件
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// frm{0}_Q",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);");
                strCodeForCs.Append("\r\n" + "this.ClientSize = new System.Drawing.Size(720, 510);");
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.uc{0}Query1);",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.btnQuery);");
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.btnExportExcel4Dg);");
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.dg{0});",
                  objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.lblRecNum);");

                strCodeForCs.AppendFormat("\r\n" + "this.Name = \"frm{0}_Q\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Text = \"frm{0}_Q\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Load += new System.EventHandler(this.frm{0}_Q_Load);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "((System.ComponentModel.ISupportInitialize)(this.dg{0})).EndInit();",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.ResumeLayout(false);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "#endregion");

                //第七步:生成objViewInfoENEx.load代码

                strCodeForCs.AppendFormat("\r\n" + "private void frm{0}_Q_Load(object sender, System.EventArgs e)",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");

                strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.objCtlType.CtlTypeName != "ComboBox") continue;
                    strCodeForCs.AppendFormat("\r\n" + "uc{0}Query1.SetCbo_{1}();",
                      objViewInfoENEx.TabName, objQryRegionFldsEx.FldName);
                }

                strCodeForCs.AppendFormat("\r\n" + "BindDg_{0}();",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                //第八步:生成绑定GridView的代码

                //strCodeForCs.Append("\r\n ///生1成绑定GridView的代码");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,");
                strCodeForCs.Append("\r\n ///			 并显示在GridView中。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "private void BindDg_{0}()",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(共4步)");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "//	3、设置GridView的数据源(DataSource)；");
                strCodeForCs.Append("\r\n" + "//	4、设置记录数的状态,");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件lblRecCount中。");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = uc{0}Query1.Combine{0}Condition();	// Combine{0}Condition();",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "objDT{0} = cls{0}BL.GetDataTable(strWhereCond);",
                          objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "MessageBox.Show(objException.Message);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//	3、设置GridView的数据源(DataSource)；");
                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.DataSource = objDT{0};",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	4、设置记录数的状态,");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件txtRecCount中。");
                strCodeForCs.AppendFormat("\r\n" + "this.lblRecNum.Text = \"记录数:\" + objDT{0}.Rows.Count.ToString();",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");


                //第九步:生成处理查询按钮的单击事件。
                strTemp = Gen_btnQuery_Click();
                strCodeForCs.Append(strTemp);

                //第十步:生成获取DataGrid中当前行的主键值。
                strTemp = gfunGenGetCurrKey4DataGrid();
                strCodeForCs.Append(strTemp);

                //第十一步:生成处理DataGrid的单击事件。
                strCodeForCs.AppendFormat("\r\n" + "private void dg{0}_Click(object sender, System.EventArgs e)",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = GetCurrKey((DataGrid)sender);",
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);

                strCodeForCs.AppendFormat("\r\n" + "frm{0}_U frm1 = new frm{0}_U();",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "frm1.{0} = {1};",
                  objKeyField.ObjFieldTabENEx.FldName, objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n" + "frm1.ShowDialog();");
                strCodeForCs.AppendFormat("\r\n" + "BindDg_{0}();",
                  objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");

                //第十二步:生成导出Excel按钮的单击事件函数
                strTemp = gfunGenbtnExportExcel4Dg_Click();
                strCodeForCs.Append(strTemp);

                //最后一步:生成类的结束符和域名空间的结束符
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //clsPubFun4BLEx.SaveClassContentToFile(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), objViewInfoENEx.FolderName_Root, myEncoding);

            //      //检查该文件名的文件夹名,并判断是否存在;
            //      strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            //if (System.IO.Directory.Exists(strFolder) == false)
            //{
            //  Directory.CreateDirectory(strFolder);
            //}

            //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            //{
            //  string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            //  string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.FolderName_Root, strSimpleFileName);
            //  while (string.IsNullOrEmpty(strFindFileFullFile) == false)
            //  {
            //    string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
            //    throw new Exception(strMsg);
            //  }
            //}
            ////UTF8Encoding utf8 = new UTF8Encoding(false);
            //clsFile.1CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), myEncoding);
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成专用于查询表控件代码
        /// </summary>
        /// <returns></returns>
        public string A_GenCtlCodeforTab4Query(Encoding myEncoding, clsViewInfoENEx objViewInfoENEx)
        {
            //让用户设置属性;
            //string strFolder;
            string strTemp;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            ArrayList arrInnerCtlSet = new ArrayList();     //内部控件集合
                                                            //			ArrayList arrViewCtlFldSet4Query = new ArrayList();	//界面控件字段集合
            int intLblHeight = 18;
            int intLblWidth = 75;
            int intTxtHeight = 20;
            int intTxtWidth = 100;

            float intCtlHeight = 200, intCtlWidth = 750;
            Point pntLocation = new Point();
            objViewInfoENEx.WinUserCtlCsFName = objViewInfoENEx.FolderName + "uc" + objViewInfoENEx.TabName + "Query.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WinUserCtlCsFName;


            //			if (objViewInfoENEx.arrQryRegionFldSet == null || objViewInfoENEx.arrQryRegionFldSet.Count == 0)
            //			{
            //				StringBuilder sbMessage = new StringBuilder();
            //				string strViewName = objViewInfoENEx.ViewName;
            //				sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!" , strViewName);
            //				throw new clsDbObjException(sbMessage.ToString());
            //			}
         


            try
            {

                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.objCtlType.CtlTypeName != "DropDownList") continue;
                    objQryRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                    objQryRegionFldsEx.CtrlId4Win = objQryRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                }
                //第一步:生成导入域名空间


                //类名开始
                ///
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//生成与表相关的控件控制层代码");
                strCodeForCs.Append("\r\n" + "using System;");
                strCodeForCs.Append("\r\n" + "using System.Collections;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                strCodeForCs.Append("\r\n" + "using System.Data;");
                strCodeForCs.Append("\r\n" + "using System.Drawing;");
                strCodeForCs.Append("\r\n" + "using System.Windows.Forms;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                strCodeForCs.Append("\r\n" + "");
     

                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //第二步:生成控件类名
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		uc{0}Query 的摘要说明。", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public class uc{0}Query : System.Windows.Forms.UserControl", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //第三步:生成控件中内部控件变量的名称
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label {0};", "lbl" + objQryRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.{1} {0};", objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.objCtlType.CtlTypeName);
                }
                //第四步:生成必需的设计器变量
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 必需的设计器变量。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private System.ComponentModel.Container components = null;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "public uc{0}Query()",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 该调用是 Windows.Forms 窗体设计器所必需的。");
                strCodeForCs.Append("\r\n" + "InitializeComponent();");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "// TODO: 在 InitializeComponent 调用后添加任何初始化");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                //第五步:清理所有正在使用的资源
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 清理所有正在使用的资源。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected override void Dispose( bool disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if( disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if(components != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "components.Dispose();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "base.Dispose( disposing);");
                strCodeForCs.Append("\r\n" + "}");
                //第六步:组件设计器生成的代码

                strCodeForCs.Append("\r\n" + "#region 组件设计器生成的代码");
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 设计器支持所需的方法 - 不要使用代码编辑器 ");
                strCodeForCs.Append("\r\n /// 修改此方法的内容。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void InitializeComponent()");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    strCodeForCs.AppendFormat("\r\n" + "this.lbl{0} = new System.Windows.Forms.Label();",
                      objQryRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = new System.Windows.Forms.{1}();",
                      objQryRegionFldsEx.CtrlId4Win, objQryRegionFldsEx.objCtlType.CtlTypeName);
                }
                strCodeForCs.Append("\r\n" + "this.SuspendLayout();");
                int intIndex = 1;
                pntLocation.X = 10;
                pntLocation.Y = 10;
                clsBiDimDistribute objBiDimDistribue = new clsBiDimDistribute();
                objBiDimDistribue.StartX = 10;
                objBiDimDistribue.StartY = 10;
                objBiDimDistribue.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
                objBiDimDistribue.ColWidth = 250;
                objBiDimDistribue.LineHeight = 30;
                int intFieldIndex = 0;

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    ///如果该字段不是标识递增型就生成控件,否则就不生成;
                    if (objQryRegionFldsEx.PrimaryTypeId() != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                        {
                            case "CheckBox":
                                // 
                                // checkBox1
                                // 
                                //定义控件
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objQryRegionFldsEx.CtrlId4Win,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                  objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                  objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"{1}\";",
                                  objQryRegionFldsEx.CtrlId4Win,
                                  objQryRegionFldsEx.LabelCaption);
                                //把当前内部控件添加内部控件集合中
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                            default:

                                //定义控件相应的Label
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// lbl{0}", objQryRegionFldsEx.FldName);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objQryRegionFldsEx.FldName,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Name = \"lbl{0}\";",
                                  objQryRegionFldsEx.FldName);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objQryRegionFldsEx.FldName, intLblWidth, intLblHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.TabIndex = {1};",
                                  objQryRegionFldsEx.FldName, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.lbl{0}.Text = \"{1}\";",
                                  objQryRegionFldsEx.FldName,
                                  objQryRegionFldsEx.LabelCaption);
                                //把当前内部控件添加内部控件集合中
                                arrInnerCtlSet.Add("this.lbl" + objQryRegionFldsEx.FldName);

                                //定义控件
                                strCodeForCs.Append("\r\n" + "//");
                                strCodeForCs.AppendFormat("\r\n" + "// {0}", objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.Append("\r\n" + "//");

                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Location = new System.Drawing.Point({1}, {2});",
                                  objQryRegionFldsEx.CtrlId4Win,
                                  objBiDimDistribue.GetPosition(intFieldIndex).X + 80,
                                  objBiDimDistribue.GetPosition(intFieldIndex).Y);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Name = \"{0}\";",
                                  objQryRegionFldsEx.CtrlId4Win);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Size = new System.Drawing.Size({1}, {2});",
                                  objQryRegionFldsEx.CtrlId4Win, intTxtWidth, intTxtHeight);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.TabIndex = {1};",
                                  objQryRegionFldsEx.CtrlId4Win, intIndex++);
                                strCodeForCs.AppendFormat("\r\n" + "this.{0}.Text = \"\";",
                                  objQryRegionFldsEx.CtrlId4Win);
                                //把当前内部控件添加内部控件集合中
                                arrInnerCtlSet.Add("this." + objQryRegionFldsEx.CtrlId4Win);
                                pntLocation.Y += 30;
                                break;
                                //end of switch
                        }
                        //end of if(objQryRegionFldsEx.IsIdentity = false && objQryRegionFldsEx.IsCtlField == true)
                    }
                    //end of foreach(clsEditRegionFldsENEx objQryRegionFldsEx in arrViewCtlFldSet4Query)
                    intFieldIndex++;    //字段序号增1
                }

                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// uc{0}Query",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//");
                //向控件的内部控件集合中添加内部控件
                foreach (string strCtlName in arrInnerCtlSet)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add({0});",
                      strCtlName);
                }
                strCodeForCs.AppendFormat("\r\n" + "this.Name = \"uc{0}Query\";", objViewInfoENEx.TabName);
                intCtlHeight = objBiDimDistribue.GetCtlHeigh(intFieldIndex);
                intCtlWidth = objBiDimDistribue.GetCtlWidth();

                strCodeForCs.AppendFormat("\r\n" + "this.Font = new System.Drawing.Font(\"宋体\", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));");
                strCodeForCs.AppendFormat("\r\n" + "this.Size = new System.Drawing.Size({0}, {1});",
                  intCtlWidth, intCtlHeight);
                strCodeForCs.AppendFormat("\r\n" + "this.Load += new System.EventHandler(this.uc{0}Query_Load);",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.ResumeLayout(false);");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "#endregion");
                //第七步:生成objViewInfoENEx.load代码
                strCodeForCs.AppendFormat("\r\n" + "private void uc{0}Query_Load(object sender, System.EventArgs e)",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                //第八步:生成控件属性,一般为每个内部控件都相应配置一个属性

                strTemp = Genfun_ViewCtrlProperty4Edit();
                strCodeForCs.Append(strTemp);


                //第九步:生成设置控件中关键字只读特性。SetKeyReadOnly
                clsEditRegionFldsENEx objEditRegionKeyFld = getEditRegionKeyFld();
                if (objEditRegionKeyFld != null)    //如果编辑区存在主关键字
                {
                    if (getEditRegionKeyFld().PrimaryTypeId() != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.Append("\r\n" + "/// 在用户自定义控件中,设置关键字的值,是否只读");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");
                        strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">是否只读</param>");

                        strCodeForCs.Append("\r\n" + "public void SetKeyReadOnly(bool bolReadonly)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.ReadOnly = bolReadonly;", getEditRegionKeyFld().CtrlId4Win);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                //第十步:生成Clear()函数。用来初始化控件中内部控件的值。
                strTemp = Genfun_Clear4QryRegion();
                strCodeForCs.Append(strTemp);

                //第十一步:生成设置缺省值的函数。设置该控件在插入状态下的缺省值;
                ///设置该控件在插入状态下的缺省值;
                strTemp = Genfun_SetDefaultValue4QryRegion();
                strCodeForCs.Append(strTemp);


                //第十二步:生成校验函数(IsValid())。校验自定义控件中自子控件的类型数值是否是合法正确的;
                strTemp = Genfun_IsValid();
                strCodeForCs.Append(strTemp);

                //第十三步:生成获取当前日期的字符串(getTodayStr) 获取当前日期的字符串以及获取当前月的字符串;
                //strTemp = clsPubFun4GC.GenGetCurrMonth();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenGetTodayStr();
                //strCodeForCs.Append(strTemp);

                //第十四步:生成控件中下拉框的BIND函数,即添加下拉框列表项的函数;
                //strTemp = GenComboBoxBindFunction();
                //strCodeForCs.Append(strTemp);

                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.objCtlType.CtlTypeName != "ComboBox") continue;
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.AppendFormat("\r\n" + "/// 设置绑定下拉框,针对字段:[{0}]",
                      objQryRegionFldsEx.FldName);
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public void SetCbo_{0}()", objQryRegionFldsEx.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsComboBox.BindCbo_TrueAndFalse({0});",
                                    objQryRegionFldsEx.CtrlId4Win);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "cls{2}BL.BindCbo_{0}({1});",
                          objQryRegionFldsEx.FldName, objQryRegionFldsEx.CtrlId4Win,
                          objQryRegionFldsEx.ObjFieldTabENEx.CodeTabName);

                    }
                    strCodeForCs.Append("\r\n" + "}");

                }
                //第十五步:生成一些判断数据类型的的公共函数

                //				strTemp = clsPubFun4GC.GenIsDate();
                //				strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.1GenIsDigit();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenIsFloat();
                //strCodeForCs.Append(strTemp);
                //strTemp = clsPubFun4GC.GenIsNumeric();
                //strCodeForCs.Append(strTemp);

                //第十六步:生成用于组合查询条件的函数
                strTemp = GenCombineCondition(objViewInfoENEx.arrQryRegionFldSet, objViewInfoENEx);
                strCodeForCs.Append(strTemp);
                //strTemp = GenCombineConditionWithSel(objViewInfoENEx.arrQryRegionFldSet, objViewInfoENEx);
                //strCodeForCs.Append(strTemp);
                //strTemp = GenCombineConditionWithTabName(objViewInfoENEx.arrQryRegionFldSet, objViewInfoENEx);
                //strCodeForCs.Append(strTemp);

                //最后一步:生成类的结束符和域名空间的结束符
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");


                //把生成写到文件中;
                clsPubFun4BLEx.SaveClassContentToFile_NoCover(objViewInfoENEx.WinUserCtlCsFName, 
                    strCodeForCs.ToString(), objViewInfoENEx.FolderName_Root, null, myEncoding);

                ////检查该文件名的文件夹名,并判断是否存在;
                //strFolder = clsString.ParentDir_S(objViewInfoENEx.WinUserCtlCsFName);
                //if (System.IO.Directory.Exists(strFolder) == false)
                //{
                //    Directory.CreateDirectory(strFolder);
                //}

                //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
                //{
                //    string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WinUserCtlCsFName);
                //    string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.FolderName_Root, strSimpleFileName);
                //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                //    {
                //        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
                //        throw new Exception(strMsg);
                //    }
                //}
                ////UTF8Encoding utf8 = new UTF8Encoding(false);
                //clsFile.1CreateFileByString(objViewInfoENEx.WinUserCtlCsFName, strCodeForCs.ToString(), myEncoding);

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public bool DispQryRegionCtrl()
        {

            return true;
        }

        public string A_GenUpdRecCode(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            Point pntLocation = new Point();
            string strTemp;
            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);

            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_U";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.WebFormFName = "frm" + objViewInfoENEx.TabName + "_U.cs";
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}",
                objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {

                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName != "DropDownList") continue;
                    objEditRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                    objEditRegionFldsEx.CtrlId4Win = objEditRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");
                }

                //第一步:生成导入域名空间

                //类名开始
                ///
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//生成与表相关的控件控制层代码");
                strCodeForCs.Append("\r\n" + "using System;");
                strCodeForCs.Append("\r\n" + "using System.Collections;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                strCodeForCs.Append("\r\n" + "using System.Data;");
                strCodeForCs.Append("\r\n" + "using System.Drawing;");
                strCodeForCs.Append("\r\n" + "using System.IO;");
                strCodeForCs.Append("\r\n" + "using System.Windows.Forms;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                
                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);

                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Form", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //第二步:生成控件类名
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_U 的摘要说明。", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public class frm{0}_U : System.Windows.Forms.Form", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //第三步:生成控件中内部控件变量的名称
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label lblMsg; ");
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Button btnOKUpd;");
                strCodeForCs.AppendFormat("\r\n" + "private {0}.uc{1} uc{1}1;",
                  objViewInfoENEx.NameSpace, objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "private System.Windows.Forms.Button btnClose;");
                strCodeForCs.AppendFormat("\r\n" + "private string {0};		//用于传递关键字值的变量",
                  objKeyField.ObjFieldTabENEx.PrivPropName);

                //第四步:生成必需的设计器变量
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 必需的设计器变量。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private System.ComponentModel.Container components = null;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "public frm{0}_U()",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 该调用是 Windows.Forms 窗体设计器所必需的。");
                strCodeForCs.Append("\r\n" + "InitializeComponent();");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "// TODO: 在 InitializeComponent 调用后添加任何初始化");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                //第五步:清理所有正在使用的资源
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 清理所有正在使用的资源。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected override void Dispose( bool disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if( disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if(components != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "components.Dispose();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "base.Dispose( disposing);");
                strCodeForCs.Append("\r\n" + "}");
                //第六步:组件设计器生成的代码

                strCodeForCs.Append("\r\n" + "#region 组件设计器生成的代码");
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 设计器支持所需的方法 - 不要使用代码编辑器 ");
                strCodeForCs.Append("\r\n /// 修改此方法的内容。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void InitializeComponent()");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "this.lblMsg = new System.Windows.Forms.Label();");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd = new System.Windows.Forms.Button();");
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}1 = new {1}.uc{0}();",
                  objViewInfoENEx.TabName, objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "this.btnClose = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.SuspendLayout();");

                int intIndex = 1;
                pntLocation.X = 10;
                pntLocation.Y = 10;

                // 
                // lblMsg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblMsg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Location = new System.Drawing.Point(200, 240);");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Name = \"lblMsg\";");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Size = new System.Drawing.Size(128, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.TabIndex = {0};",
                  intIndex++);
                // 
                // btnOKUpd
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnOKUpd");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Location = new System.Drawing.Point(200, 304);");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Name = \"btnOKUpd\";");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Size = new System.Drawing.Size(96, 32);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnOKUpd.TabIndex = ;",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Text = \"添加\";");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// uc{0}1",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}1.Location = new System.Drawing.Point(8, 248);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}1.Name = \"uc{0}1\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}1.Size = new System.Drawing.Size(184, 240);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}1.TabIndex = {1};",
                  objViewInfoENEx.TabName, intIndex++);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// uc{0}",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//");

                // 
                // btnClose
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnClose");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnClose.Location = new System.Drawing.Point(240, 152);");
                strCodeForCs.Append("\r\n" + "this.btnClose.Name = \"btnClose\";");
                strCodeForCs.Append("\r\n" + "this.btnClose.Size = new System.Drawing.Size(96, 24);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnClose.TabIndex = {0};",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnClose.Text = \"关闭\";");
                strCodeForCs.Append("\r\n" + "this.btnClose.Click += new System.EventHandler(this.btnClose_Click);");

                //向控件的内部控件集合中添加内部控件
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// frm{0}_QUDI",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);");
                strCodeForCs.Append("\r\n" + "this.ClientSize = new System.Drawing.Size(720, 510);");
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.btnClose);");
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.btnOKUpd);");
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.lblMsg);");
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.uc{0}1);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Name = \"frm{0}_U\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Text = \"frm{0}_U\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Load += new System.EventHandler(this.frm{0}_U_Load);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "((System.ComponentModel.ISupportInitialize)(this.dg{0})).EndInit();",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.ResumeLayout(false);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "#endregion");

                //第七步:生成objViewInfoENEx.load代码

                strCodeForCs.AppendFormat("\r\n" + "private void frm{0}_U_Load(object sender, System.EventArgs e)",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");

                strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName != "ComboBox") continue;
                    strCodeForCs.AppendFormat("\r\n" + "uc{0}1.SetCbo_{1}();",
                      objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                }
                strCodeForCs.AppendFormat("\r\n" + "ShowData({0});",
                  objKeyField.ObjFieldTabENEx.PrivPropName);
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认修改\";");

                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");


                //第十二步:生成显示数据函数(ShowData)校验函数。
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate || objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {
                    strCodeForCs.Append("\r\n" + GenShowDataCode_Win());
                }


                //第十三步:生成把类对象的属性内容显示到界面上;
                strTemp = GenGetDataFromClass();
                strCodeForCs.Append(strTemp);

                //第十四步://生成确定修改的事件函数
                strTemp = GenbtnOKUpd_Click4UC();
                strCodeForCs.Append(strTemp);

                //第十五步:生成把界面上的属性数据传到类对象中的代码
                strTemp = GenPutDataToClass();
                strCodeForCs.Append(strTemp);
                //第十六步:生成关闭窗体的的单击事件函数
                strCodeForCs.Append("\r\n" + "private void btnClose_Click(object sender, System.EventArgs e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "this.Close();");
                strCodeForCs.Append("\r\n" + "}");
                //第十六步:生成用于传递关键字值的属性函数
                strCodeForCs.AppendFormat("\r\n" + "public {0} {1}",
                  objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.FldName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "get");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "return {0};",
                  objKeyField.ObjFieldTabENEx.PrivPropName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "set");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0} = value;",
                  objKeyField.ObjFieldTabENEx.PrivPropName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                //最后一步:生成类的结束符和域名空间的结束符
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //clsPubFun4BLEx.SaveClassContentToFile(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), objViewInfoENEx.FolderName_Root, myEncoding);

            ////检查该文件名的文件夹名,并判断是否存在;
            //strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            //if (System.IO.Directory.Exists(strFolder) == false)
            //{
            //    Directory.CreateDirectory(strFolder);
            //}

            //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            //{
            //    string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            //    string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.FolderName_Root, strSimpleFileName);
            //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
            //    {
            //        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
            //        throw new Exception(strMsg);
            //    }
            //}
            ////UTF8Encoding utf8 = new UTF8Encoding(false);
            //clsFile.1CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), myEncoding);
            return strCodeForCs.ToString();



        }

        public string A_GenQueryUpdDelInsRecCode(clsViewInfoENEx objViewInfoENEx, ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            Point pntLocation = new Point();
            string strTemp;
            //让用户设置属性;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;

            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有DG区域,或者DG区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }
         
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);

            objViewInfoENEx.WebFormName = "frm" + objViewInfoENEx.TabName + "_QUDI";
           objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.WebFormFName = "frm" + objViewInfoENEx.TabName + "_QUDI.cs";
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}",
                objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {

                //第0步:把控件中下拉框ComboBox转换成ComboBox
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName != "DropDownList") continue;

                    objEditRegionFldsEx.objCtlType.CtlTypeName = "ComboBox";
                    objEditRegionFldsEx.CtrlId4Win = objEditRegionFldsEx.CtrlId4Win.Replace("ddl", "cbo");

                }

                //第一步:生成导入域名空间

                //类名开始
                ///
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                strCodeForCs.Append("\r\n" + "//生成与表相关的控件控制层代码");
                strCodeForCs.Append("\r\n" + "using System;");
                strCodeForCs.Append("\r\n" + "using System.Collections;");
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;");
                strCodeForCs.Append("\r\n" + "using System.Data;");
                strCodeForCs.Append("\r\n" + "using System.Drawing;");
                strCodeForCs.Append("\r\n" + "using System.IO;");
                strCodeForCs.Append("\r\n" + "using System.Windows.Forms;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;");
                strCodeForCs.Append("\r\n" + "using com.taishsoft.datetime;");
                
                clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProject.PrjDomain);
                strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProject.PrjDomain);

                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Form", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                //第二步:生成控件类名
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n ///		frm{0}_QUDI 的摘要说明。", objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public class frm{0}_QUDI : System.Windows.Forms.Form", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                //第三步:生成控件中内部控件变量的名称
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Button btnQuery;");
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.DataGrid dg{0};",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label lblMsg; ");
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Button btnOKUpd;");
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Button btnDelRec;");
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Button btnExportExcel4Dg;");
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.Label lblRecNum;");
                strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;");
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (objDGRegionFldsEx.ObjFieldTabENEx == null) continue;

                    strCodeForCs.AppendFormat("\r\n" + "private System.Windows.Forms.DataGridTextBoxColumn dataGridTxt{0};",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                }
                strCodeForCs.AppendFormat("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "private {0}.uc{1}Query uc{1}Query1;",
                  objViewInfoENEx.NameSpace, objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "private {0}.uc{1} uc{1}1;",
                  objViewInfoENEx.NameSpace, objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "private System.Data.DataTable objDT{0};",
                  objViewInfoENEx.TabName);

                //第四步:生成必需的设计器变量
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 必需的设计器变量。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private System.ComponentModel.Container components = null;");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "public frm{0}_QUDI()",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 该调用是 Windows.Forms 窗体设计器所必需的。");
                strCodeForCs.Append("\r\n" + "InitializeComponent();");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "// TODO: 在 InitializeComponent 调用后添加任何初始化");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");
                //第五步:清理所有正在使用的资源
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 清理所有正在使用的资源。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "protected override void Dispose( bool disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if( disposing)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if(components != null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "components.Dispose();");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "base.Dispose( disposing);");
                strCodeForCs.Append("\r\n" + "}");
                //第六步:组件设计器生成的代码

                strCodeForCs.Append("\r\n" + "#region 组件设计器生成的代码");
                strCodeForCs.Append("\r\n /// <summary> ");
                strCodeForCs.Append("\r\n /// 设计器支持所需的方法 - 不要使用代码编辑器 ");
                strCodeForCs.Append("\r\n /// 修改此方法的内容。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "private void InitializeComponent()");
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "this.btnQuery = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.lblMsg = new System.Windows.Forms.Label();");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnDelRec = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg = new System.Windows.Forms.Button();");
                strCodeForCs.Append("\r\n" + "this.lblRecNum = new System.Windows.Forms.Label();");
                strCodeForCs.Append("\r\n" + "this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();");
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (objDGRegionFldsEx.ObjFieldTabENEx == null) continue;

                    strCodeForCs.AppendFormat("\r\n" + "this.dataGridTxt{0} = new System.Windows.Forms.DataGridTextBoxColumn();",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                }

                strCodeForCs.AppendFormat("\r\n" + "this.dg{0} = new System.Windows.Forms.DataGrid();",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}Query1 = new {1}.uc{0}Query();",
                  objViewInfoENEx.TabName, objViewInfoENEx.NameSpace);
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}1 = new {1}.uc{0}();",
                  objViewInfoENEx.TabName, objViewInfoENEx.NameSpace);
                strCodeForCs.AppendFormat("\r\n" + "((System.ComponentModel.ISupportInitialize)(this.dg{0})).BeginInit();",
                  objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "this.SuspendLayout();");

                int intIndex = 1;
                pntLocation.X = 10;
                pntLocation.Y = 10;
                //
                //查询按钮<btnQuery>
                //
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnQuery");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Location = new System.Drawing.Point(408, 16);");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Name = \"btnQuery\";");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Size = new System.Drawing.Size(80, 24);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnQuery.TabIndex = {0};",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnQuery.Text = \"查询\";");
                strCodeForCs.Append("\r\n" + "this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);");

                // 
                // lblMsg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblMsg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Location = new System.Drawing.Point(200, 240);");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Name = \"lblMsg\";");
                strCodeForCs.Append("\r\n" + "this.lblMsg.Size = new System.Drawing.Size(128, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblMsg.TabIndex = {0};",
                  intIndex++);
                // 
                // btnOKUpd
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnOKUpd");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Location = new System.Drawing.Point(200, 304);");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Name = \"btnOKUpd\";");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Size = new System.Drawing.Size(96, 32);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnOKUpd.TabIndex = ;",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Text = \"添加\";");
                strCodeForCs.Append("\r\n" + "this.btnOKUpd.Click += new System.EventHandler(this.btnOKUpd_Click);");
                // 
                // btnDelRec
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnDelRec");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Location = new System.Drawing.Point(328, 56);");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Name = \"btnDelRec\";");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Size = new System.Drawing.Size(80, 24);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnDelRec.TabIndex = ;",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Text = \"删除记录\";");
                strCodeForCs.Append("\r\n" + "this.btnDelRec.Click += new System.EventHandler(this.btnDelRec_Click);");
                // 
                // btnExportExcel4Dg
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// btnExportExcel4Dg");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Location = new System.Drawing.Point(424, 56);");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Name = \"btnExportExcel4Dg\";");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Size = new System.Drawing.Size(88, 24);");
                strCodeForCs.AppendFormat("\r\n" + "this.btnExportExcel4Dg.TabIndex = {0};",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Text = \"导出Excel\";");
                strCodeForCs.Append("\r\n" + "this.btnExportExcel4Dg.Click += new System.EventHandler(this.btnExportExcel4Dg_Click);");
                // 
                // lblRecNum
                // 
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// lblRecNum");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Location = new System.Drawing.Point(16, 240);");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Name = \"lblRecNum\";");
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Size = new System.Drawing.Size(112, 16);");
                strCodeForCs.AppendFormat("\r\n" + "this.lblRecNum.TabIndex = {0} ;",
                  intIndex++);
                strCodeForCs.Append("\r\n" + "this.lblRecNum.Text = \"记录数:\";");

                strCodeForCs.AppendFormat("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// dg{0}",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.DataMember = \"\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.HeaderForeColor = System.Drawing.SystemColors.ControlText;",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.Location = new System.Drawing.Point(8, 80);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.Name = \"dg{0}\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.Size = new System.Drawing.Size(624, 152);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.TabIndex = {1};",
                  objViewInfoENEx.TabName, intIndex++);
                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] ",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{this.dataGridTableStyle1});");

                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.Click += new System.EventHandler(this.dg{0}_Click);",
                  objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "// dataGridTableStyle1");
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.dataGridTableStyle1.DataGrid = this.dg{0};",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {");
                bool bolIsFirst = true;
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (objDGRegionFldsEx.ObjFieldTabENEx == null) continue;

                    if (bolIsFirst == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.dataGridTxt{0}",
                          objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                        bolIsFirst = false;
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + ", this.dataGridTxt{0}",
                          objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                    }
                }
                strCodeForCs.Append(" });");
                strCodeForCs.Append("\r\n" + "this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;");
                strCodeForCs.Append("\r\n" + "this.dataGridTableStyle1.MappingName = \"\";");

                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    if (objDGRegionFldsEx.ObjFieldTabENEx == null) continue;

                    strCodeForCs.Append("\r\n" + "// ");
                    strCodeForCs.AppendFormat("\r\n" + "// dataGridTxt{0}",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.Append("\r\n" + "// ");
                    strCodeForCs.AppendFormat("\r\n" + "this.dataGridTxt{0}.Format = \"\";",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.dataGridTxt{0}.FormatInfo = null;",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.dataGridTxt{0}.HeaderText = \"{1}\";",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName,
                      objDGRegionFldsEx.HeaderText);
                    strCodeForCs.AppendFormat("\r\n" + "this.dataGridTxt{0}.MappingName = \"{0}\";",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "this.dataGridTxt{0}.Width = 75;",
                      objDGRegionFldsEx.ObjFieldTabENEx.FldName);
                }

                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// uc{0}Query1",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}Query1.Location = new System.Drawing.Point(0, 0);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}Query1.Name = \"uc{0}Query1\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}Query1.Size = new System.Drawing.Size(200, 100);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}Query1.TabIndex = {1};",
                  objViewInfoENEx.TabName, intIndex++);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// uc{0}1",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}1.Location = new System.Drawing.Point(8, 248);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}1.Name = \"uc{0}1\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}1.Size = new System.Drawing.Size(184, 240);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.uc{0}1.TabIndex = {1};",
                  objViewInfoENEx.TabName, intIndex++);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// uc{0}",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//");
                //向控件的内部控件集合中添加内部控件
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.AppendFormat("\r\n" + "// frm{0}_QUDI",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "// ");
                strCodeForCs.Append("\r\n" + "this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);");
                strCodeForCs.Append("\r\n" + "this.ClientSize = new System.Drawing.Size(720, 510);");
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.btnExportExcel4Dg);");
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.btnDelRec);");
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.btnOKUpd);");
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.lblMsg);");
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.lblRecNum);");

                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.uc{0}Query1);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.uc{0}1);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Controls.Add(this.dg{0});",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.Controls.Add(this.btnQuery);");
                strCodeForCs.AppendFormat("\r\n" + "this.Name = \"frm{0}_QUDI\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Text = \"frm{0}_QUDI\";",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "this.Load += new System.EventHandler(this.frm{0}_QUDI_Load);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "((System.ComponentModel.ISupportInitialize)(this.dg{0})).EndInit();",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "this.ResumeLayout(false);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "#endregion");

                //第七步:生成objViewInfoENEx.load代码

                strCodeForCs.AppendFormat("\r\n" + "private void frm{0}_QUDI_Load(object sender, System.EventArgs e)",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");

                strCodeForCs.Append("\r\n" + "//1、为下拉框设置数据源,绑定列表数据");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlType.CtlTypeName != "ComboBox") continue;
                    strCodeForCs.AppendFormat("\r\n" + "uc{0}1.SetCbo_{1}();",
                      objViewInfoENEx.TabName, objEditRegionFldsEx.FldName);
                }
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.NonQueryField_04) continue;

                    if (objQryRegionFldsEx.objCtlType.CtlTypeName != "ComboBox") continue;
                    strCodeForCs.AppendFormat("\r\n" + "uc{0}Query1.SetCbo_{1}();",
                      objViewInfoENEx.TabName,
                      objQryRegionFldsEx.FldName);
                }

                strCodeForCs.AppendFormat("\r\n" + "BindDg_{0}();",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "}");

                //第八步:生成绑定GridView的代码

       
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,");
                strCodeForCs.Append("\r\n ///			 并显示在GridView中。");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "private void BindDg_{0}()",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//操作步骤:(共4步)");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "//	3、设置GridView的数据源(DataSource)；");
                strCodeForCs.Append("\r\n" + "//	4、设置记录数的状态,");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件lblRecCount中。");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "//	1、组合界面条件串；");
                strCodeForCs.AppendFormat("\r\n" + "string strWhereCond = uc{0}Query1.Combine{0}Condition();	// Combine{0}Condition();",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	2、根据条件串获取该表满足条件的DataTable；");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "objDT{0} = cls{0}BL.GetDataTable(strWhereCond);",
                          objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "MessageBox.Show(objException.Message);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//	3、设置GridView的数据源(DataSource)；");
                strCodeForCs.AppendFormat("\r\n" + "this.dg{0}.DataSource = objDT{0};",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	4、设置记录数的状态,");
                strCodeForCs.Append("\r\n" + "//		在本界面中是把状态显示在控件txtRecCount中。");
                strCodeForCs.AppendFormat("\r\n" + "this.lblRecNum.Text = \"记录数:\" + objDT{0}.Rows.Count.ToString();",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");


                //第九步:生成处理查询按钮的单击事件。

                strTemp = Gen_btnQuery_Click();
                strCodeForCs.Append(strTemp);


                //第十步:生成获取DataGrid中当前行的主键值。
                strTemp = gfunGenGetCurrKey4DataGrid();
                strCodeForCs.Append(strTemp);

                //第十一步:生成处理DataGrid的单击事件。
                strCodeForCs.AppendFormat("\r\n" + "private void dg{0}_Click(object sender, System.EventArgs e)",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string str{0}Id = GetCurrKey((DataGrid)sender);",
                  objViewInfoENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "ShowData(str{0}Id);",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "//2、清空提示信息的内容,同时使<确定修改>按钮可用；");
                strCodeForCs.Append("\r\n" + "btnOKUpd.Enabled = true;");
                strCodeForCs.AppendFormat("\r\n" + "uc{0}1.SetKeyReadOnly(true);",
                  objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "btnOKUpd.Text = \"确认修改\";");
                strCodeForCs.Append("\r\n" + "lblMsg.Text = \"\";");
                strCodeForCs.Append("\r\n" + "}");

                //第十二步:生成显示数据函数(ShowData)校验函数。
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate || objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {
                    strCodeForCs.Append("\r\n" + GenShowDataCode_Win());
                }

                //第十三步:生成把类对象的属性内容显示到界面上;
                strTemp = GenGetDataFromClass();
                strCodeForCs.Append(strTemp);

                //第十四步://生成确定修改的事件函数
                strTemp = GenbtnOKUpd_Click4UC();
                strCodeForCs.Append(strTemp);

                //第十五步:生成把界面上的属性数据传到类对象中的代码
                strTemp = GenPutDataToClass();
                strCodeForCs.Append(strTemp);
                //第十六步:生成删除按钮的单击事件函数
                strTemp = Gen_btnDelRec_Click();
                strCodeForCs.Append(strTemp);

                //第十七步:生成导出Excel按钮的单击事件函数
                strTemp = gfunGenbtnExportExcel4Dg_Click();
                strCodeForCs.Append(strTemp);

                //最后一步:生成类的结束符和域名空间的结束符
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            //把生成写到文件中;
            //clsPubFun4BLEx.SaveClassContentToFile(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), objViewInfoENEx.FolderName_Root, myEncoding);

            ////检查该文件名的文件夹名,并判断是否存在;
            //strFolder = clsString.ParentDir_S(objViewInfoENEx.WebFormFName);
            //if (System.IO.Directory.Exists(strFolder) == false)
            //{
            //    Directory.CreateDirectory(strFolder);
            //}

            //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
            //{
            //    string strSimpleFileName = clsString.GetSimpleFName_S(objViewInfoENEx.WebFormFName);
            //    string strFindFileFullFile = clsFile.FindFileFromFolder(objViewInfoENEx.FolderName_Root, strSimpleFileName);
            //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
            //    {
            //        string strMsg = string.Format("文件:{0}已经存在!", strFindFileFullFile);
            //        throw new Exception(strMsg);
            //    }
            //}
            ////UTF8Encoding utf8 = new UTF8Encoding(false);
            //clsFile.1CreateFileByString(objViewInfoENEx.WebFormFName, strCodeForCs.ToString(), myEncoding);
            return strCodeForCs.ToString();
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(AutoGC_Cs_VWin_PubFun);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                    if (mt.GetParameters().Length == 0)
                    {
                        strCode = (string)mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strMsg = "";
                if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
                {
                    strMsg = objException.InnerException.Message;
                }
                else
                {
                    strMsg = objException.Message;
                }
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", strFuncName, strMsg);
                throw new Exception(sbMessage.ToString());
            }
        }
        public override void GetClsName()
        {
            this.ClsName = string.Format("cls{0}DA1", objViewInfoENEx.TabName);
            objViewInfoENEx.ClsName = this.ClsName;
        }
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            return "";
        }
    }
}
