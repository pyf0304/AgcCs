
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:wucvProgLangType4Gv
 表名:ProgLangType
 生成代码版本:2018.04.29.1
 生成日期:2018/04/29 11:48:06
 生成者:
 工程名称:AGC
 工程ID:0005
 相关数据库:101.251.68.133,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统参数
 模块英文名:SysPara
 框架-层名:Web界面层
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
//生成与表相关的控件控制层代码
namespace AGC.Webform
{

using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using com.taishsoft.commdb;
using com.taishsoft.common;
using com.taishsoft.datetime;
using CommFunc4WebForm;


using AGC.Entity;
using AGC.BusinessLogic;using AGC.FunClass;


 /// <summary>
 ///		wucvProgLangType4Gv 的摘要说明。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:A_Gen_wucTabName4Gv)
 /// </summary>
public partial class wucvProgLangType4Gv : System.Web.UI.UserControl
{
/// <summary>
/// 在GridView中，单击[修改]按钮时，所引发的修改事件
/// </summary>
public event OnGvUpdateClick GvUpdateClick;
        /// <summary>
/// 在GridView中，单击[删除]按钮时，所引发的修改事件
/// </summary>
public event OnGvDeleteClick GvDeleteClick;
#region 控件页面启动函数
 /// <summary>
 /// 函数功能:用户定义控件页面导入,当页面开始运行时所发生的事件
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPage_LoadCode4Wuc)
 /// </summary>
 /// <param name = "sender"></param>
 /// <param name = "e"></param>
protected void Page_Load(object sender, System.EventArgs e)
{
// 在此处放置用户代码以初始化页面

}

#endregion 控件页面启动函数
 /// <summary>
 /// 函数功能:把查询数据绑定在GridView上。根据界面上查询控件中所设置内容查询表记录,
 ///			 并显示在GridView中。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBindGridView4Wuc)
 /// </summary>
public void BindGv_ProgLangType(string strWhereCond)
{
//操作步骤:(共5步)
//	1、组合界面条件串；
//	2、根据条件串获取该表满足条件的DataTable；
//	4、设置GridView的数据源(DataSource)；
//	5、绑定GridView,即把DataTable的内容显示在GridView中
//	6、设置记录数的状态,
//		在本界面中是把状态显示在控件txtRecCount中。

System.Data.DataTable objDT = null;
try
{
vsWhereCond = strWhereCond;
//	2、根据条件串获取该表满足条件的DataTable；
objDT = clsvProgLangTypeBL.GetDataTable(strWhereCond);
}
catch (Exception objException)
{
seErrMessage = "(errid:WebI000001)获取数据表(DataTable)不成功!" + objException.Message;
seBackErrPageLinkStr = Page.Request.Url.AbsolutePath;
Response.Redirect(clsSysParaEN.ErrorPage);
}
//	4、设置GRIDView的数据源(DataSource)；
DataView objDV = objDT.DefaultView;
objDV.Sort = vsSortProgLangTypeBy; ///注意这一行代码有可能需要注释掉,目前这行仅仅在单独的查询界面中起作用
 ///设置GridView中每页的记录数
if (string.IsNullOrEmpty(PageSize) == false)
{
int intPageSize = int.Parse(PageSize);
gvProgLangType.PageSize = intPageSize;
}
else
{
PageSize = "10";
gvProgLangType.PageSize = 10;
}
this.gvProgLangType.DataSource = objDV;
//	5、绑定GridView,即把DataTable的内容显示在GridView中
this.gvProgLangType.DataBind();

 ///生成专门用于BindGv中的跳页相关代码
GridViewRow pagerRow = gvProgLangType.BottomPagerRow;
if (pagerRow == null)
{
return;
}
Label lblRecCount = (Label)pagerRow.FindControl("lblRecCount");
Label lblAllPages = (Label)pagerRow.FindControl("lblAllPages");
Label lblCurrentPage = (Label)pagerRow.FindControl("lblCurrentPage");
TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
Button btnNextPage = (Button)pagerRow.FindControl("btnNextPage");
Button btnPrevPage = (Button)pagerRow.FindControl("btnPrevPage");
Button tabJumpPage = (Button)pagerRow.FindControl("tabJumpPage");
DropDownList ddlPagerRecCount = (DropDownList)pagerRow.FindControl("ddlPagerRecCount");
if (lblRecCount != null)
{
//当前记录数
lblRecCount.Text = objDT.Rows.Count.ToString(); 
//当前页数
lblAllPages.Text = this.gvProgLangType.PageCount.ToString(); 
//当前页序数
lblCurrentPage.Text = (this.gvProgLangType.PageIndex+1).ToString();
//当前即将跳到的页序数
txtJump2Page.Text = (this.gvProgLangType.PageIndex+1).ToString();
//如果当前页序数为0,则<前一页>按钮无效
if(this.gvProgLangType.PageIndex == 0) 
{
btnPrevPage.Enabled = false; 
}
else 
{ 
btnPrevPage.Enabled = true; 
} 
//如果当前页序数已为最后一页,则<前一页>按钮无效
if(this.gvProgLangType.PageIndex == this.gvProgLangType.PageCount-1) 
{ 
btnNextPage.Enabled = false; 
} 
else 
{ 
btnNextPage.Enabled = true; 
} 
//设置分页器中每页记录数的下拉框的值
if (string.IsNullOrEmpty(PageSize) == false)
{
ddlPagerRecCount.Text = PageSize;
}
else
{
PageSize = "10";
ddlPagerRecCount.Text = PageSize;
}
} 
gvProgLangType.BottomPagerRow.Visible = true;
}



/// <summary>
/// 事件函数:生成与跳页的相关函数.在GridView的脚部，当单击跳转按钮时发生的事件，在这里主要处理:跳转到GridView的某一数。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenJumpPage_RelaFunction)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void btnJumpPage_Click(object sender, EventArgs e)
{
GridViewRow pagerRow = gvProgLangType.BottomPagerRow;
TextBox txtJump2Page = (TextBox)pagerRow.FindControl("txtJump2Page");
if (txtJump2Page != null)
{
if(txtJump2Page.Text.Trim()!= "" && 
int.Parse(txtJump2Page.Text)>0 && 
int.Parse(txtJump2Page.Text)-1<this.gvProgLangType.PageCount) 
{ 
this.gvProgLangType.PageIndex = int.Parse(txtJump2Page.Text)-1; 
} 
BindGv_ProgLangType(vsWhereCond);
}
}


/// <summary>
/// 事件函数:在GridView的脚部，当每页记录数的下拉框发生改变时发生的事件，在这里主要处理:改变GridView的每页记录数。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenddlPagerRecCount_SelectedIndexChanged)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void ddlPagerRecCount_SelectedIndexChanged(object sender, EventArgs e)
{
DropDownList ddlPagerRecCount = (DropDownList)sender;
string strPageSize = ddlPagerRecCount.Text;
if (clsDateTime.IsNumeric(strPageSize) == true)
{
int intPageSize = int.Parse(strPageSize);
if (intPageSize >= 1)
{
PageSize = intPageSize.ToString();
BindGv_ProgLangType(vsWhereCond);
}
}
}

/// <summary>
/// 事件函数:在GridView中，当单击GeidView行中的命令按钮时发生的事件，在这里主要处理:在列头显示单击全选按钮时全选GridView的所有行。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowCommand)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void gvProgLangType_RowCommand(object sender, GridViewCommandEventArgs e)
{
string strCommandName = e.CommandName;
switch (strCommandName)
{
case "lbSelAll":
System.Web.UI.WebControls.LinkButton lbSelAll;
lbSelAll = (LinkButton)e.CommandSource;
if (lbSelAll.CommandName != "lbSelAll")
{
return;
}
if (lbSelAll.Text == "全选")
{
clsCommForWebForm.Set_GridViewAllChecked(gvProgLangType, true);
lbSelAll.Text = "不选";
}
else if (lbSelAll.Text == "不选")
{
clsCommForWebForm.Set_GridViewAllChecked(gvProgLangType, false);
lbSelAll.Text = "全选";
}
break;
}
}
/// <summary>
/// 事件函数:在GridView中，当GeidView行建立时发生的事件，在这里主要处理:数据行中处理删除时显示提示信息，还有在列头显示排序标志。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowCreated)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void gvProgLangType_RowCreated(object sender, GridViewRowEventArgs e)
{
if (e.Row.RowType == DataControlRowType.DataRow)
{
System.Web.UI.WebControls.LinkButton myDeleteButton;
myDeleteButton = (System.Web.UI.WebControls.LinkButton)e.Row.FindControl("lbDelete");
if (myDeleteButton != null)
{
myDeleteButton.Attributes.Add("onclick", "return confirm('您真的要删除第 " + (e.Row.RowIndex + 1).ToString() + " 行吗？');");
}
}
int intIndex;
if (vsSortProgLangTypeBy == "") return ;
if (e.Row.RowType == DataControlRowType.Header)//点击控件是否为页眉；
{
string strSortEx;
for(int i = 0;i<this.gvProgLangType.Columns.Count;i++)
{
strSortEx = this.gvProgLangType.Columns[i].SortExpression;
if (strSortEx == "") continue;
intIndex = vsSortProgLangTypeBy.IndexOf(strSortEx + " ");
if(intIndex >= 0) //视图状态的排序表达式是否为该列的字段；
{
Label lblSort = new Label();
lblSort.Font.Name = "webdings";//设置字体,在"webdings"中5是上三角,6是下三角；
intIndex = vsSortProgLangTypeBy.IndexOf("Asc");
lblSort.Text = (intIndex>0?" 5":" 6");//是否为升序,而且为string型；
e.Row.Cells[i].Controls.Add(lblSort);//被引用项的第i个单元格中增添一控件；
break;
}
}
}
}

 /// <summary>
 /// 函数功能:事件函数,在更改GridView的当前页索引时激发的函数。
 ///			 具体功能是重新显示新页(所单击页索引)的内容。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_PageIndexChanging)
 /// </summary>
 /// <param name = "source"></param>
 /// <param name = "e"></param>
protected void gvProgLangType_PageIndexChanging(object sender, GridViewPageEventArgs e)
{
//操作步骤:(共2步)
//1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
//2、重新绑定GridView,使之内容更新,变化到新的页

if (e.NewPageIndex != -1)
{
//1、设置当前页的页索引,即把新单击的页索引赋给当前页索引
gvProgLangType.PageIndex = e.NewPageIndex;
//2、重新绑定GridView,使之内容更新,变化到新的页
BindGv_ProgLangType(vsWhereCond);
}
}
 ///
/// <summary>
/// 事件函数:在GridView中，当GeidView行单击修改时发生的事件，在这里主要处理:数据行中处理修改相关记录。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowUpdating)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void gvProgLangType_RowUpdating(object sender, GridViewUpdateEventArgs e)
{
string strProgLangTypeId = gvProgLangType.DataKeys[e.RowIndex]["ProgLangTypeId"].ToString();
if (GvUpdateClick != null)
{             
clsEventArgs4Update objEventArgs4Update = new clsEventArgs4Update();
objEventArgs4Update.KeyId = strProgLangTypeId.ToString();
GvUpdateClick(this, objEventArgs4Update);
}
}
/// <summary>
/// 事件函数:在GridView中，进行行删除(RowDeleting)
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_RowDeleting)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void gvProgLangType_RowDeleting(object sender, GridViewDeleteEventArgs e)
{
string strProgLangTypeId = gvProgLangType.DataKeys[e.RowIndex]["ProgLangTypeId"].ToString();
if (GvDeleteClick != null)
{             
clsEventArgs4Delete objEventArgs4Delete = new clsEventArgs4Delete();
objEventArgs4Delete.KeyId = strProgLangTypeId.ToString();
GvDeleteClick(this, objEventArgs4Delete);
}
}

 /// <summary>
 /// 专门用于记录GridView中的每页记录数
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenPageSizeViewState)
 /// </summary>
protected string PageSize
{
get
{
string strPageSize;
strPageSize = (string)ViewState["PageSize"];
if (strPageSize == null) 
{
strPageSize = "";
}
return strPageSize;
}
set
{
string strPageSize = value;
ViewState.Add("PageSize", strPageSize);
}
}



 /// <summary>
 /// 设置GridView中的页序号
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_PageIndex)
 /// </summary>
public int PageIndex
{
set
{
this.gvProgLangType.PageIndex = value;
}
}


#region 排序相关函数
/// <summary>
/// 事件函数:在GridView中，单击列头进行排序所发生的事件
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
/// </summary>
/// <param name = "sender"></param>
/// <param name = "e"></param>
protected void gvProgLangType_Sorting(object sender, GridViewSortEventArgs e)
{
int intIndex;
//判断是否是新的排序字段
intIndex = vsSortProgLangTypeBy.IndexOf(e.SortExpression);
if (intIndex == -1)
{
vsSortProgLangTypeBy = e.SortExpression + " Asc";
BindGv_ProgLangType(vsWhereCond);
return ;
}
//检查原来是升序
intIndex = vsSortProgLangTypeBy.IndexOf(" Asc");
if (intIndex == -1)		//如果原来不是升序就设置为升序
{
vsSortProgLangTypeBy = e.SortExpression + " Asc";
}
else			///否则设置为降序
{
vsSortProgLangTypeBy = e.SortExpression + " Desc";
}
BindGv_ProgLangType(vsWhereCond);
}

 /// <summary>
 /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_GridView_Sorting)
 /// </summary>
protected string vsSortProgLangTypeBy
{
get
{
string sSortProgLangTypeBy;
sSortProgLangTypeBy = (string)ViewState["SortProgLangTypeBy"];
if (sSortProgLangTypeBy == null) 
{
sSortProgLangTypeBy = "";
}
return sSortProgLangTypeBy;
}
set
{
string sSortProgLangTypeBy = value;
ViewState.Add("SortProgLangTypeBy", sSortProgLangTypeBy);
}
}
#endregion 排序相关函数
 /// <summary>
 /// 用于记录GridView中的当前排序表达式,以便决定下一次是升序,还是降序排序。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_vsWhereCond)
 /// </summary>
protected string vsWhereCond
{
get
{
string sWhereCond;
sWhereCond = (string)ViewState["WhereCond"];
if (sWhereCond == null) 
{
sWhereCond = "";
}
return sWhereCond;
}
set
{
string sWhereCond = value;
ViewState.Add("WhereCond", sWhereCond);
}
}

 /// <summary>
 /// Session属性:错误信息的Session属性,该Session传递给显示出错页面,显示相应的错误内容。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenErrMessageSession)
 /// </summary>
protected string seErrMessage
{
get
{
string strErrMessage;
strErrMessage = (string)Session["ErrMessage"];
if (strErrMessage == null) 
{
strErrMessage = "";
}
return strErrMessage;
}
set
{
string strErrMessage = value;
Session.Add("ErrMessage", strErrMessage);
}
}


 /// <summary>
 /// Session属性:返回链接串的Session属性,该Session用于告诉出错页面,哪一个页面是需要返回的页面。
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GenBackLinkStrSession)
 /// </summary>
protected string seBackErrPageLinkStr
{
get
{
string strBackErrPageLinkStr;
strBackErrPageLinkStr = (string)Session["BackErrPageLinkStr"];
if (strBackErrPageLinkStr == null) 
{
strBackErrPageLinkStr = "";
}
return strBackErrPageLinkStr;
}
set
{
string strBackErrPageLinkStr = value;
Session.Add("BackErrPageLinkStr", strBackErrPageLinkStr);
}
}



 /// <summary>
 /// 设置GridView字段的可见性
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_SetGvVisibility)
 /// </summary>
public void SetGvVisibility(string strColumnName, bool bolIsVisible)
{
clsCommForWebForm.SetGvVisibility(gvProgLangType, strColumnName, bolIsVisible);
}


 /// <summary>
 /// 设置GridView的可见性
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_SetVisible)
 /// </summary>
public void SetVisible(bool bolVisible)
{
gvProgLangType.Visible = bolVisible;
}


 /// <summary>
 ///从列表中获取所有选择的关键字
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GetAllCheckedKeysFromGv4Wuc)
 /// </summary>/// <returns>返回所有选择的关键字列表</returns>
public List<string> GetAllCheckedKeysFromGv()
{
List<string> lstProgLangTypeId = clsCommForWebForm.GetAllCheckedItemFromGv(gvProgLangType, "chkCheckRec", conProgLangType.ProgLangTypeId);
if (lstProgLangTypeId.Count == 0) 
{
clsCommonJsFunc.Alert(this, "(errid:WebI000016)没有选择记录,请选择有效的表记录!");
return null;
}
return lstProgLangTypeId;
}


 /// <summary>
 ///从列表中获取选择的第一个关键字
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:GetFirstCheckedKeyFromGv4Wuc)
 /// </summary>/// <returns>返回选择的第一个关键字</returns>
public string GetFirstCheckedKeyFromGv()
{
List<string> lstProgLangTypeId = clsCommForWebForm.GetFirstCheckedItemFromGv(gvProgLangType,conProgLangType.ProgLangTypeId);
if (lstProgLangTypeId.Count == 0) 
{
clsCommonJsFunc.Alert(this, "(errid:WebI000015)没有选择记录,请选择有效的表记录!");
return "";
}
//1、显示该关键字的数据让用户修改该关键字记录；
string strProgLangTypeId = lstProgLangTypeId[0];
 return strProgLangTypeId;
}


 /// <summary>
 /// 设置在GridView中选择一个项(一条记录)
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_SetCheckedItemForGv)
 /// </summary>
public bool SetCheckedItemForGv(string strProgLangTypeId)
{
clsCommForWebForm.SetCheckedItemForGv(gvProgLangType, 1, strProgLangTypeId.ToString());
return true;
}


 /// <summary>
 /// 设置GridView的可见性
 /// (AutoGCLib.AutoGC_Cs_CWeb_PubFun:Gen_SetSortBy)
 /// </summary>
public void SetSortBy(string strSortBy)
{
vsSortProgLangTypeBy = strSortBy;
}
}
}