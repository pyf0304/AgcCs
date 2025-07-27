<%@ Register TagPrefix="uc1" TagName="wucViewDgInfo" Src="wucViewDgInfo.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmViewDgInfo_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmViewDgInfo_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表ViewDgInfo的查询、修改、删除、添加记录</title>
    

    <script language="javascript" type="text/javascript">
		<!--
	function radioClick()
	{
		if (document.Form1.RadioName !=null)
		{
			for (i=0; i<document.Form1.RadioName.length; i++)
			{
			    if (document.Form1.RadioName[i].checked == true)
			    {
					document.Form1.rd.value = document.Form1.RadioName[i].value;
					//document.getElementById("TextBox1").value = document.Form1.rd.value;
				}
			}
		}
	}
		//-->
    </script>
      <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
      <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
        
            <img style="z-index: 101; left: 8px; position: absolute; top: 8px" height="30" alt=""
                src="../../pic/兰色标题.gif" width="840">
            <div style="display: inline; z-index: 102; left: 16px; width: 300px;
                color: #000066; position: absolute; top: 16px; height: 15px">
                ViewDgInfo表的查询、修改、删除、添加
            </div>
            <div id="divViewDgInfo" style="z-index: 105; left: 8px; width: 608px; position: absolute;
                top: 35px; height: 64px" runat="server">
                <asp:Label ID="lblViewDgNameq" Style="z-index: 104; left: 10px; position: absolute;
                    top: 5px" runat="server"  
                    Width="70px">
  界面Dg名称</asp:Label>
                <asp:TextBox ID="txtViewDgNameq" Style="z-index: 105; left: 85px; position: absolute;
                    top: 5px" runat="server"  Width="160px"></asp:TextBox>
                <asp:Label ID="lblSqlDsTypeIdq" Style="z-index: 107; left: 10px; position: absolute;
                    top: 33px" runat="server"  
                    Width="70px">
  数据源类型</asp:Label>
                <asp:DropDownList ID="ddlSqlDsTypeIdq" Style="z-index: 108; left: 85px; position: absolute;
                    top: 33px" runat="server"  Width="160px">
                </asp:DropDownList>
                <asp:Label ID="lblSqlDsIdq" Style="z-index: 110; left: 256px; position: absolute;
                    top: 40px" runat="server"  
                    Width="112px">
  数据源表/视图Id</asp:Label>
                <asp:DropDownList ID="ddlSqlDsIdq" Style="z-index: 111; left: 376px; position: absolute;
                    top: 40px" runat="server"  Width="136px">
                </asp:DropDownList>
                <asp:Label ID="lblDgStyleIdq" Style="z-index: 113; left: 296px; position: absolute;
                    top: 8px" runat="server"  
                    Width="64px">
  DG模式ID</asp:Label>
                <asp:DropDownList ID="ddlDgStyleIdq" Style="z-index: 114; left: 376px; position: absolute;
                    top: 8px" runat="server"  Width="144px">
                </asp:DropDownList>
                <asp:Button ID="btnQuery" Style="z-index: 116; left: 520px; position: absolute; top: 40px"
                    runat="server"   
                    Text="查询"></asp:Button>
            </div>
            &nbsp;
            <input id="rd" style="z-index: 103; left: 896px; width: 24px; position: absolute;
                top: 48px; height: 22px" type="hidden" size="1" name="rd" runat="server">
            <input style="display: none; z-index: 104; left: 8px; position: absolute; top: 8px"
                type="radio" checked name="RadioName">
            <table id="tabViewDgInfoDataGrid" style="z-index: 106; left: 8px;
                width: 608px; position: absolute; top: 144px; height: 152px" cellspacing="0"
                cellpadding="0" width="608" border="0" runat="server">
                <tr>
                    <td>
                        <asp:DataGrid ID="dgViewDgInfo" runat="server" 
                            Height="134px" Width="600px" AllowSorting="True" AllowPaging="True" PageSize="3"
                            AutoGenerateColumns="False">
                            <Columns>
                                <asp:TemplateColumn>
                                    <ItemTemplate>
                                        <input onclick="radioClick()" type="radio" value='<%# DataBinder.Eval(Container.DataItem, "ViewDgID")%>'
                                            name="RadioName">
                                        </ItemTemplate> </asp:TemplateColumn>
                                        <asp:BoundColumn DataField="ViewDgID" SortExpression="ViewDgID" HeaderText="界面DgId">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewDgName" SortExpression="ViewDgName" HeaderText="界面Dg名称">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewInfoViewName" SortExpression="ViewId" HeaderText="界面ID">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="SQLDSTypeSqlDsTypeName" SortExpression="SqlDsTypeId"
                                            HeaderText="数据源类型"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="SqlDsId" SortExpression="SqlDsId" HeaderText="数据源表/视图Id">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="DataGridStyleDgStyleName" SortExpression="DgStyleId"
                                            HeaderText="DG模式ID"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="Width" SortExpression="Width" HeaderText="宽">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="Height" SortExpression="Height" HeaderText="高度">
                                        </asp:BoundColumn>
                                        <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                        <asp:TemplateColumn>
                                            <itemtemplate>
											<asp:linkButton id="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:linkButton>
										</itemtemplate>
                                        </asp:TemplateColumn>
                                        </Columns>
                                        <pagerstyle mode="NumericPages"></pagerstyle>
                                        </asp:datagrid></td> </tr> </table>
                                        <table id="tabLayout" style="z-index: 107; left: 10px; width: 373px; position: absolute;
                                            top: 328px; height: 200px" cellspacing="1" cellpadding="1" width="373" border="1">
                                            <tr>
                                                <td>
                                                    <asp:Button ID="btnOKUpd" runat="server" 
                                                          Text="添加"></asp:Button><asp:Label ID="lblMsg" runat="server"
                                                             Width="70px"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <uc1:wucviewdginfo id="wucViewDgInfo1" runat="server">
                                                    </uc1:wucviewdginfo></td>
                                            </tr>
                                        </table>
                                        <asp:LinkButton ID="lbAddViewDgFld" Style="z-index: 108; left: 272px; position: absolute;
                                            top: 120px" runat="server"  
                                            Width="120px">添加界面DG字段</asp:LinkButton>
                    </FONT></form> </body> </html> 