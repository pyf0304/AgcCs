<%@ Register TagPrefix="uc1" TagName="wucSoftStructure" Src="wucSoftStructure.ascx" %>
<%@ Page language="c#" AutoEventWireup="True" CodeBehind="wfmSoftStructure_QUDI.aspx.cs" Inherits="AGC.Webform.wfmSoftStructure_QUDI" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>SoftStructure的维护</title>

</head>
<body>
<form id="form1" runat="server">
<table id="tabLayout" style="z-index: 105; left: 0px; position: absolute; top: 0px" cellspacing="2"
cellpadding="2" width="300" border="0" runat="server">
<tr>
<td>

<div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
<asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >SoftStructure表的维护
</asp:Label>
<asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 105;
left: 54px; position: relative; top: 4px" Width="347px"></asp:Label>
	</div>
</td>
</tr>
<tr>
<td>

<div id="divSoftStructure" style="position: relative; width: 600px; height: 70px"> 

<asp:Label id="lblSoftStructureIdq" style="z-index: 104; left: 10px; position: absolute; top: 5px" 
runat="server" Width="70px" CssClass="text-secondary">架构ID</asp:Label>
<asp:TextBox id="txtSoftStructureIdq" style="z-index: 105; left: 85px; 
position: absolute; top: 5px" 
runat="server" Width="70px"  CssClass="Textbox_Defa">
</asp:TextBox>

<asp:Label id="lblSoftStructureNameq" style="z-index: 107; left: 260px; position: absolute; top: 5px" 
runat="server" Width="70px" CssClass="text-secondary">架构名称</asp:Label>
<asp:TextBox id="txtSoftStructureNameq" style="z-index: 108; left: 335px; 
position: absolute; top: 5px" 
runat="server" Width="70px"  CssClass="Textbox_Defa">
</asp:TextBox>

<asp:Button id="btnQuery" 
 style="z-index: 110; left: 10px; 
 position: relative; top: 35px" 
runat="server" 
   
 Text="查询" CssClass="btn btn-outline-warning btn-sm" 
 OnClick="btnQuery_Click" 
></asp:Button>
</div>
</td>
<td></td>
<td></td>
</tr>
<tr>
<td></td>
<td></td>
<td></td>
</tr>
<tr>
<td>

<table id="tabSoftStructureGridView" style="width: 552px" 
 runat="server">
<tr>
<td>
<div style="width: 750px; position: relative; height: 32px" id="divGridFunction" >
<asp:label id="lblSoftStructureList" runat="server" style="z-index: 105; left: 0px; position: relative; top: 0px"  
CssClass="h6" >软件架构列表</asp:label>
<asp:button id="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" style="z-index: 106; left: 390px; position: absolute; top: 4px"
 CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:button>
<asp:button id="btnDelete4Gv" OnClick="btnDelete4Gv_Click" style="z-index: 104; left: 475px; position: absolute; top: 4px" runat="server"
 CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:button>
<asp:button id="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" style="z-index: 105; left: 560px; position: absolute; top: 4px" runat="server"
 CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:button>
<asp:button id="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click"  style="z-index: 107; left: 645px; position: absolute; top: 4px"
runat="server"  CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:button>
</div>
</td>
</tr>
<tr>
<td>
<asp:GridView id="gvSoftStructure" style="z-index: 111; position: relative;" runat="server" 
Width="800px" AutoGenerateColumns="False" 
 PageSize="10" AllowPaging="true" 
AllowSorting="true" 
OnSorting="gvSoftStructure_Sorting" 
OnPageIndexChanging="gvSoftStructure_PageIndexChanging" 
OnRowCreated="gvSoftStructure_RowCreated"
OnRowCommand="gvSoftStructure_RowCommand"
OnRowDeleting="gvSoftStructure_RowDeleting" 
OnRowUpdating="gvSoftStructure_RowUpdating" 
BackColor="White" 
BorderColor="#E7E7FF" 
BorderStyle="None" 
BorderWidth="1px"
cellpadding="3" 
GridLines="Horizontal" 
Height="1px" 
DataKeyNames="SoftStructureId" 
CssClass="table table-striped table-bordered table-condensed">
<Columns>
<asp:TemplateField HeaderText="全选">
<HeaderStyle Width="35px" />
<HeaderTemplate>
<asp:LinkButton id="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap text-white" >全选</asp:LinkButton>
</HeaderTemplate>
<ItemTemplate>
<asp:CheckBox id="chkCheckRec" runat="server"></asp:CheckBox>
</ItemTemplate>
</asp:TemplateField>
<asp:BoundField DataField="SoftStructureId" SortExpression="SoftStructureId" HeaderText="架构ID"></asp:BoundField>
<asp:BoundField DataField="SoftStructureName" SortExpression="SoftStructureName" HeaderText="架构名称"></asp:BoundField>
<asp:BoundField DataField="SoftStructureDesc" SortExpression="SoftStructureDesc" HeaderText="架构描述"></asp:BoundField>
<asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundField>
<asp:TemplateField>
<ItemTemplate>
<asp:linkButton id="lbUpdate" runat="Server" CommandName="Update" Text="修改"></asp:linkButton>
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField>
<ItemTemplate>
<asp:linkButton id="lbDelete" runat="Server" CommandName="Delete" Text="删除"></asp:linkButton>
</ItemTemplate>
</asp:TemplateField>
</Columns>
<PagerTemplate>
<span class="text-secondary">共有记录:</span>
<asp:Label ID="lblRecCount" runat="server" CssClass ="Label_DefaInPager" ForeColor="#000066" Width="46px">0</asp:Label>
<span style="background-color: #c0c0c0">
<div style="display: inline; width: 16px; height: 13px">
</div>
</span><span class="text-secondary">总页数:</span>
<asp:Label ID="lblAllPages" runat="server" CssClass ="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
<div style="display: inline; width: 16px; height: 13px">
</div>
<span class="text-secondary">当前页:</span>
<asp:Label ID="lblCurrentPage" runat="server" CssClass ="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
<div style="display: inline; width: 16px; height: 13px">
</div>
<asp:Button ID="btnPrevPage" runat="server" CssClass ="Button_DefaInPager" Text="上一页"
Width="60px" CommandArgument="Prev" CommandName="Page" /><span style="font-family: Verdana">
</span>
<asp:Button ID="btnNextPage" runat="server" CssClass ="Button_DefaInPager" Text="下一页"
Width="60px" CommandArgument="Next" CommandName="Page" />
到第
<asp:TextBox ID="txtJump2Page" runat="server" CssClass ="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
<asp:Button ID="btnJumpPage" runat="server" CssClass ="Button_DefaInPager" OnClick="btnJumpPage_Click"
Text="确定" Width="45px" CommandName="Page" />
<span class="text-secondary">页记录数:</span>
<asp:DropDownList ID="ddlPagerRecCount" runat="server" CssClass="DropDown_DefaInPager"
Width="41px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
<asp:ListItem>5</asp:ListItem>
<asp:ListItem>10</asp:ListItem>
<asp:ListItem>15</asp:ListItem>
<asp:ListItem>20</asp:ListItem>
<asp:ListItem>30</asp:ListItem>
<asp:ListItem>50</asp:ListItem>
<asp:ListItem>100</asp:ListItem>
<asp:ListItem>1000</asp:ListItem>
<asp:ListItem></asp:ListItem>
</asp:DropDownList>
<asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
</PagerTemplate>
<FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
<RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
<SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
<PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
<HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
<AlternatingRowStyle BackColor="#F7F7F7" />
</asp:GridView>
</td>
</tr>
</table>
</td>
<td></td>
<td></td>
</tr>
<tr>
<td></td>
<td></td>
<td></td>
</tr>
<tr>
<td>
<table id="tabEditSoftStructureRegion" style="z-index: 111;  width: 750px" 
cellspacing="1" cellpadding="1" width="750" border="1"  runat="server">
<tr>
<td>
<div style="width: 730px; position: relative; height: 32px" >
<asp:label id="lblEditSoftStructure" style="z-index: 104; left: 0px; position: relative; top: 4px" runat="server"
CssClass="h6" >软件架构编辑区域</asp:label>
<asp:Label id="lblMsgEdit" style="z-index: 105; left: 54px; position: relative; top: 1px" runat="server" 
Width="208px" CssClass="text-warning" ></asp:Label>
<asp:Button id="btnOKUpd" style="z-index: 106; left: 68px; position: relative; top: 4px" runat="server" 
 Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
<asp:Button id="btnCancelSoftStructureEdit" style="z-index: 107; left: 90px; position: relative; top: 4px"
runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelSoftStructureEdit_Click"></asp:Button>
</div>
</td>
</tr>
<tr>
<td>
<uc1:wucSoftStructure id="wucSoftStructure1" runat="server" />
</td>
</tr>
</table>
</td>
<td></td>
<td></td>
</tr>
</table>
</form>
</body>
</html>