<%@ Page Language="c#" CodeBehind="wfmViewDgFld_Edit.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmViewDgFld_Edit" %>

<%@ Register TagPrefix="uc1" TagName="wucViewDgFld" Src="wucViewDgFld.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表PrjTabFld的查询、修改、删除、添加记录</title>
    

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
      <script type="text/javascript" src="../../Scripts/jquery-3.4.1.min.js"></script>
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
        
            <asp:Label ID="Label3" Style="z-index: 103; left: 8px; position: absolute; top: 8px"
                runat="server" Font-Size="Larger" Font-Names="黑体" Width="216px"
                ForeColor="Blue">界面维护->界面DG维护字段</asp:Label>
            <asp:Label ID="lblCurrTabName" Style="z-index: 112; left: 8px; position: absolute;
                top: 32px" runat="server" ForeColor="#FF8080" Width="440px" 
                 Font-Bold="True">Label</asp:Label>
            <asp:LinkButton ID="lbReturn" Style="z-index: 106; left: 744px; position: absolute;
                top: 48px" runat="server"  
                Width="32px">返回</asp:LinkButton>
            <asp:Label ID="Label2" Style="z-index: 102; left: 232px; position: absolute; top: 8px"
                runat="server"  Width="42px"
                ForeColor="#004040" Font-Bold="True">说明：</asp:Label>
            <asp:Label ID="Label4" Style="z-index: 101; left: 328px; position: absolute; top: 8px"
                runat="server"  Height="32px" Width="464px"
                ForeColor="#004040">项目表主要用来维护管理项目相关的表，该界面主要维护项目表中字段的查看、添加、删除、修改等，以便开发者快速查询项目中相关表的字段信息。</asp:Label>
            <table id="tabHidden" style="z-index: 104; left: 904px; position: absolute; top: 8px"
                cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
                <tr>
                    <td>
                        <asp:Label ID="lblMId_q" runat="server" 
                            >编号</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtMId_q" runat="server"  Width="100px"></asp:TextBox></td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblFldID_q" runat="server" 
                            >字段编号</asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddlFldID_q" runat="server"  Width="100px">
                        </asp:DropDownList></td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlTabId_q" runat="server" Width="100px"  Enabled="False">
                        </asp:DropDownList></td>
                    <td>
                        <asp:Label ID="lblTabId_q" runat="server" 
                            >表编号</asp:Label></td>
                    <td>
                    </td>
                </tr>
            </table>
            <table id="Table1" style="z-index: 105; left: 8px; width: 456px; position: absolute;
                top: 48px; height: 32px" cellspacing="1" cellpadding="1" width="456" border="1">
                <tr>
                    <td style="height: 18px">
                        <asp:Label ID="Label1" runat="server"  
                            >是否主关键字</asp:Label></td>
                    <td style="height: 18px">
                        <asp:DropDownList ID="ddlIsPrimary_q" runat="server" Width="112px">
                        </asp:DropDownList></td>
                    <td style="height: 18px">
                        <asp:Label ID="lblPrimaryTypeId_q" runat="server" 
                            >主关键字类型</asp:Label></td>
                    <td style="height: 18px">
                        <asp:DropDownList ID="ddlPrimaryTypeId_q" runat="server"  Width="100px">
                        </asp:DropDownList></td>
                    <td style="height: 18px">
                        <asp:Button ID="btnQuery" runat="server" Width="78px" Text="查询"></asp:Button></td>
                </tr>
            </table>
            <input id="rd" style="z-index: 107; left: 928px; width: 16px; position: absolute;
                top: 96px; height: 22px" type="hidden" runat="server">
            <input style="display: none; z-index: 108; left: 944px; position: absolute; top: 88px"
                type="radio" name="RadioName">
            <div style="z-index: 109; left: 8px; width: 745px; position: absolute; top: 88px;
                height: 24px">
                <asp:Button ID="btnAdd" Style="z-index: 101; left: 0px; position: absolute; top: 0px"
                    runat="server" Text="添加表字段"></asp:Button>
                <asp:Button ID="btnSetTabFldProperty" Style="z-index: 102; left: 184px; position: absolute;
                    top: 0px" runat="server" Width="104px" Text="设置表字段属性"></asp:Button>
                <asp:Button ID="btnDelRec" Style="z-index: 103; left: 96px; position: absolute; top: 0px"
                    runat="server" Width="88px" Text="删除表字段"></asp:Button>
                <asp:Button ID="btnCopyFldFromRelaObj" Style="z-index: 104; left: 400px; position: absolute;
                    top: 0px" runat="server" Width="136px" Text="从相关对象复制字段"></asp:Button>
                <asp:Button ID="btnSetFldProperty" Style="z-index: 105; left: 288px; position: absolute;
                    top: 0px" runat="server" Width="104px" Text="设置字段属性"></asp:Button>
                <asp:Label ID="lblMsg3" Style="z-index: 106; left: 608px; position: absolute; top: 0px"
                    runat="server" ForeColor="Red" Width="136px"></asp:Label>
                <asp:Button ID="btnExportExcel" Style="z-index: 107; left: 544px; position: absolute;
                    top: 0px" runat="server"   Text="导出Excel"></asp:Button>
            </div>
            <table id="tabWhole" style="z-index: 110; left: 8px; width: 560px; position: absolute;
                top: 120px" cellspacing="1" cellpadding="1" width="560" border="1">
                <tr>
                    <td>
                        <table id="tabPrjTabFld" style="width: 448px" cellspacing="0" cellpadding="0" width="448"
                            border="0" runat="server">
                            <tr>
                                <td colspan="2" style="width: 522px">
                                    <asp:DataGrid ID="dgPrjTabFld" runat="server" Width="520px" Height="154px" Font-Names="宋体"
                                        Font-Size="Smaller" AllowPaging="True" AutoGenerateColumns="False" AllowSorting="True"
                                        PageSize="12">
                                        <Columns>
                                            <asp:TemplateColumn>
                                                <HeaderTemplate>
                                                    选择
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <input type="radio" onclick="radioClick()" name="RadioName" value='<%# DataBinder.Eval(Container.DataItem, "MId")%>'>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            <asp:BoundColumn DataField="SequenceNumber" SortExpression="SequenceNumber" HeaderText="序号">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="MId" HeaderText="编号"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="FldName" SortExpression="FldName" HeaderText="字段名"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="Caption" SortExpression="Caption" HeaderText="字段标题"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="DataTypeName" SortExpression="DataTypeName" HeaderText="类型">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="IsTabNullable" SortExpression="IsTabNullable" HeaderText="可空">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="IsTabPrimary" SortExpression="IsTabPrimary" HeaderText="主关键字">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="PrimaryTypeName" SortExpression="PrimaryTypeName" HeaderText="主关键字类型">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="IsTabForeignKey" SortExpression="IsTabForeignKey" HeaderText="外键">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="IsParentObj" SortExpression="IsParentObj" HeaderText="父对象ID">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="Memo" HeaderText="说明"></asp:BoundColumn>
                                            <asp:ButtonColumn Visible="False" Text="修改" HeaderText="功能列" CommandName="Update"></asp:ButtonColumn>
                                            <asp:TemplateColumn Visible="False" HeaderText="功能列">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            <asp:BoundColumn DataField="ForeignTabName" SortExpression="ForeignTabName" HeaderText="外键表">
                                            </asp:BoundColumn>
                                        </Columns>
                                        <PagerStyle Mode="NumericPages"></PagerStyle>
                                    </asp:DataGrid></td>
                                <td>
                                    <div style="width: 28px; position: relative; height: 227px">
                                        <asp:ImageButton ID="ibDown" Style="z-index: 116; left: 0px; position: absolute;
                                            top: 48px" runat="server" Width="24px" Height="28px" ImageUrl="../../pic/Down.JPG">
                                        </asp:ImageButton>
                                        <asp:ImageButton ID="ibUp" Style="z-index: 116; left: 0px; position: absolute; top: 8px"
                                            runat="server" Width="24px" Height="28px" ImageUrl="../../pic/Up.JPG"></asp:ImageButton>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblRecCount" runat="server" Width="110px"  Font-Names="宋体"
                                        Font-Size="Smaller">查询结果记录数：</asp:Label></td>
                                <td style="width: 303px">
                                    <asp:TextBox ID="txtRecCount" runat="server" Width="111px"  Font-Names="宋体"
                                        Font-Size="Smaller" ReadOnly="True"></asp:TextBox>
                                    <asp:Label ID="lblMsg2" runat="server" ForeColor="Red" Width="85px" Height="10px"></asp:Label></td>
                                <td>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table id="Table4" cellspacing="1" cellpadding="1" width="300" border="0" runat="server">
                            <tr>
                                <td style="font-family: Verdana; height: 18px">
                                    对象：
                                    <asp:DropDownList ID="ddlPrjObject" runat="server" Width="128px" AutoPostBack="True">
                                    </asp:DropDownList>
                                    <asp:LinkButton ID="lbDispTabFld" runat="server">显示表字段</asp:LinkButton></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DataGrid ID="dgObjFld4Sel" runat="server" Width="400px" 
                                         AllowPaging="True" AutoGenerateColumns="False" BorderColor="#CCCCCC"
                                        BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="1" CellSpacing="1"
                                        AllowSorting="True">
                                        <FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
                                        <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
                                        <ItemStyle ForeColor="#000066"></ItemStyle>
                                        <HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
                                        <Columns>
                                            <asp:TemplateColumn HeaderText="选择">
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="ckb1" runat="server"></asp:CheckBox>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            <asp:BoundColumn Visible="False" DataField="FldId" HeaderText="字段编号"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="FldName" SortExpression="FldName" HeaderText="字段名称"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="DataTypeName" SortExpression="DataTypeName" HeaderText="字段类型">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="FldLength" SortExpression="FldLength" HeaderText="字段长度">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="IsNull" SortExpression="IsNull" HeaderText="是否为空"></asp:BoundColumn>
                                        </Columns>
                                        <PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages">
                                        </PagerStyle>
                                    </asp:DataGrid></td>
                            </tr>
                            <tr>
                                <td>
                                    <div id="divTabFld4Sel" style="width: 392px; position: relative">
                                        <asp:Label ID="Label5" Style="z-index: 101; left: 0px; position: absolute; top: 0px"
                                            runat="server" Width="56px"  Font-Names="宋体" Font-Size="Smaller">记录数：</asp:Label>
                                        <asp:TextBox ID="txtRecCount_PrjTabFld" Style="z-index: 102; left: 64px; position: absolute;
                                            top: 0px" runat="server"   Font-Names="宋体" Font-Size="Smaller"
                                            ReadOnly="True"></asp:TextBox>
                                        <asp:CheckBox ID="chkSelAll" Style="z-index: 103; left: 120px; position: absolute;
                                            top: 0px" runat="server" AutoPostBack="True"
                                            Text="全选"></asp:CheckBox>
                                        <asp:Button ID="btnOkAdd" Style="z-index: 104; left: 176px; position: absolute; top: 0px"
                                            runat="server" Text="确认添加"></asp:Button>
                                        <asp:Label ID="lblMsg1" Style="z-index: 105; left: 256px; position: absolute; top: 0px"
                                            runat="server" ForeColor="Red" Width="128px"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <table id="Table3" cellspacing="1" cellpadding="1" width="240" border="1" runat="server"
                style="z-index: 111; left: 568px; width: 240px; position: absolute; top: 112px;
                height: 83px">
                <tr>
                    <td>
                        <uc1:wucViewDgFld id="wucViewDgFld1" runat="server">
                        </uc1:wucViewDgFld></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnOKEdit" runat="server" Text="确定修改"></asp:Button>
                        <asp:Label ID="lblMsg" runat="server" ForeColor="Red" Width="144px" ></asp:Label></td>
                </tr>
                <tr>
                    <td>
                    </td>
                </tr>
            </table>
        </font>
    </form>
</body>
</html>
