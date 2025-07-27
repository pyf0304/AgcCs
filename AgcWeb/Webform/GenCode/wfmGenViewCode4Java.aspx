<%@ Page Language="c#" CodeBehind="wfmGenViewCode4Java.aspx.cs" AutoEventWireup="True"
    ValidateRequest="false" Inherits="AGC.Webform.wfmGenViewCode4Java" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表ViewInfo的查询、修改、删除、添加记录</title>
    

    <script language="javascript" type="text/javascript">
		<!--
    function radioClick() {
        if (document.Form1.RadioName != null) {
            for (i = 0; i < document.Form1.RadioName.length; i++) {
                if (document.Form1.RadioName[i].checked == true) {
                    document.Form1.rd.value = document.Form1.RadioName[i].value;
                    //document.getElementById("TextBox1").value = document.Form1.rd.value;
                }
            }
        }
    }
    //-->
    </script>

</head>
<body>
    <form id="Form1" method="post" runat="server">

        <asp:Label ID="Label3" Style="z-index: 102; left: 8px; position: absolute; top: 8px"
            runat="server" Width="256px" CssClass="h5">生成Jsp&Struts代码->界面代码</asp:Label>
        <table id="tabHidden" style="z-index: 101; left: 840px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
            <tr>
                <td></td>
                <td></td>
                <td style="width: 61px">
                    <asp:Label ID="lblUserIdq" runat="server" >用户ID</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtUserIdq" runat="server" Width="49px" ></asp:TextBox></td>
                <td>
                    <asp:Label ID="lblPrjIdq" runat="server" >工程ID</asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddlPrjIdq" runat="server" Width="112px">
                    </asp:DropDownList></td>
            </tr>
        </table>
        &nbsp;
            <input id="rd" style="z-index: 103; left: 896px; width: 24px; position: absolute; top: 48px; height: 22px"
                type="hidden" name="rd" runat="server">
        <input style="display: none; z-index: 104; left: 8px; position: absolute; top: 8px"
            type="radio" checked="checked" name="RadioName">
        <table id="Table1" style="z-index: 105; left: 8px; position: absolute; top: 40px"
            cellspacing="0" cellpadding="0" width="300" border="0">
            <tr>
                <td>
                    <table id="tabQuery1" cellspacing="1" cellpadding="1" width="300"
                        border="4" runat="server">
                        <tr>
                            <td colspan="2">
                                <table id="tabQuery" style="width: 792px; height: 65px" bordercolor="#666666" cellspacing="1"
                                    cellpadding="1" width="792" border="4">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblViewNameq" runat="server" Width="56px" CssClass="text-secondary">界面名称</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="txtViewNameq" runat="server" Width="109px"></asp:TextBox></td>
                                        <td style="width: 62px">
                                            <asp:Label ID="lblApplicationTypeIdq" runat="server"
                                                Width="79px" CssClass="text-secondary">应用程序类型</asp:Label></td>
                                        <td>
                                            <asp:DropDownList ID="ddlApplicationTypeIdq" runat="server" Width="126px">
                                            </asp:DropDownList></td>
                                        <td>
                                            <asp:Label ID="Label5" runat="server" Width="56px" CssClass="text-secondary">功能模块</asp:Label></td>
                                        <td>
                                            <asp:DropDownList ID="ddlFuncModuleIdq" runat="server" Width="240px">
                                            </asp:DropDownList></td>
                                        <td>
                                            <asp:Button ID="btnQuery" runat="server"  
                                                Text="查询" OnClick="btnQuery_Click"></asp:Button></td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblMainTabNameq" runat="server" Width="56px" CssClass="text-secondary">界面表名</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="txtMainTabNameq" runat="server" Width="104px"></asp:TextBox></td>
                                        
                                        <td>
                                            <asp:Label ID="lblViewGroupIdq" runat="server"
                                                 CssClass="text-secondary">界面组</asp:Label></td>
                                        <td>
                                            <asp:DropDownList ID="ddlViewGroupIdq" runat="server" Width="240px">
                                            </asp:DropDownList></td>
                                        <td></td>
                                        <td></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <div style="width: 849px; position: relative; height: 56px">
                                    <asp:Button ID="btnGenViewCode" Style="z-index: 100; left: 48px; position: absolute; top: 0px"
                                        runat="server" Width="112px"  Text="生成界面JSP代码" OnClick="btnGenViewCode_Click"></asp:Button>
                                    <asp:Button ID="btnGenActionCode" Style="z-index: 101; left: 160px; position: absolute; top: 0px"
                                        runat="server" Width="128px"  Text="生成界面Action代码" OnClick="btnGenActionCode_Click"></asp:Button>
                                    <asp:Button ID="btnGenGeneLogicCode" Style="z-index: 102; left: 584px; position: absolute; top: 0px"
                                        runat="server" Width="128px"  Text="生成GeneLogic代码" OnClick="btnGenGeneLogicCode_Click"></asp:Button>
                                    <asp:Button ID="btnGenGeneExLogicCode" Style="z-index: 107; left: 712px; position: absolute; top: 0px"
                                        runat="server" Width="128px"  Text="生成GeneLogic代码" OnClick="btnGenGeneExLogicCode_Click"></asp:Button>
                                    <asp:Button ID="btnLogicManagerCode" Style="z-index: 108; left: 288px; position: absolute; top: 0px"
                                        runat="server" Width="136px"  Text="生成逻辑Manager代码" OnClick="btnLogicManagerCode_Click"></asp:Button>
                                    <asp:Button ID="btnGeneStrutsConfig" Style="z-index: 109; left: 424px; position: absolute; top: 0px"
                                        runat="server"  Width="136px" Text="生成Struts-config" OnClick="btnGeneStrutsConfig_Click"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height: 201px">
                                <asp:DataGrid ID="dgViewInfo" runat="server" Width="840px" Height="214px" Font-Names="宋体"
                                    Font-Size="Smaller" GridLines="Vertical" CellPadding="0" BackColor="White" BorderWidth="1px"
                                    BorderStyle="Ridge" BorderColor="White" AutoGenerateColumns="False" AllowPaging="True"
                                    AllowSorting="True" OnItemCreated="dgViewInfo_ItemCreated" OnItemDataBound="dgViewInfo_ItemDataBound" OnPageIndexChanged="dgViewInfo_PageIndexChanged" OnSortCommand="dgViewInfo_SortCommand">
                                    <FooterStyle HorizontalAlign="Left" ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
                                    <ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
                                    <Columns>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <input onclick="radioClick()" type="radio" value='<%# DataBinder.Eval(Container.DataItem, "ViewId")%>'
                                                    name="RadioName" />
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn Visible="False" DataField="ViewId" HeaderText="界面ID"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewName" SortExpression="ViewName" HeaderText="界面名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewTypeName" SortExpression="ViewTypeName" HeaderText="界面类型码"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="功能模块"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="DataBaseName" SortExpression="DataBaseName"
                                            HeaderText="数据库名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="MainTabName" SortExpression="MainTabName" HeaderText="界面表名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="DetailTabName" SortExpression="DetailTabName" HeaderText="明细表名"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="KeyForMainTab" SortExpression="KeyForMainTab"
                                            HeaderText="主表关键字"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="KeyForDetailTab" SortExpression="KeyForDetailTab"
                                            HeaderText="明细表关键字"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="IsNeedSort" HeaderText="是否需要排序"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="IsNeedTransCode" HeaderText="是否需要转换代码"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="UserId" HeaderText="用户ID"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="PrjName" HeaderText="工程ID"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewFunction" HeaderText="界面功能"></asp:BoundColumn>
                                    </Columns>
                                    <PagerStyle NextPageText="&amp;lt;下一页&amp;gt;" PrevPageText="&amp;lt;下一页&amp;gt;"
                                        HorizontalAlign="Left" ForeColor="Black" BackColor="#C6C3C6"></PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblRecCount" runat="server" Width="110px" Font-Names="宋体"
                                    Font-Size="Smaller">查询结果记录数：</asp:Label></td>
                            <td rowspan="1">
                                <asp:TextBox ID="txtRecCount" runat="server" Width="111px" Font-Names="宋体"
                                    Font-Size="Smaller" ReadOnly="True"></asp:TextBox></td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td style="height: 26px"></td>
                <td style="height: 26px"></td>
                <td style="height: 26px"></td>
            </tr>
            <tr>
                <td>
                    <table id="tabCode" style="width: 776px; height: 44px" cellspacing="1" cellpadding="1"
                        width="776" border="1" runat="server">
                        <tr>
                            <td colspan="2">
                                <div style="width: 760px; position: relative; height: 32px">
                                    <asp:Label ID="lblCaption4GenCode" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
                                        runat="server" Width="120px" Font-Names="宋体" Font-Size="Smaller">生成的逻辑层代码：</asp:Label>
                                    <asp:LinkButton ID="lbDispTabList" Style="z-index: 102; left: 664px; position: absolute; top: 8px"
                                        runat="server" OnClick="lbDispTabList_Click">显示界面列表</asp:LinkButton>
                                    <asp:Label ID="Label1" Style="z-index: 103; left: 152px; position: absolute; top: 8px"
                                        runat="server" >生成文件名：</asp:Label>
                                    <asp:TextBox ID="txtFileName4GenCode" Style="z-index: 104; left: 248px; position: absolute; top: 8px"
                                        runat="server" Width="336px"></asp:TextBox>
                                    <asp:LinkButton ID="lbDownLoadFile" Style="z-index: 111; left: 600px; position: absolute; top: 8px"
                                        runat="server" Width="56px" OnClick="lbDownLoadFile_Click">下载文件</asp:LinkButton>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">

                                  <asp:Literal ID="litCode" runat="server"></asp:Literal>
                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
        </table>
        <asp:Label ID="lblMsg2" Style="z-index: 106; left: 280px; position: absolute; top: 8px"
            runat="server" Height="13px" Width="432px"
            ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
