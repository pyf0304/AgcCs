<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewInfoBak1.ascx.cs"
    Inherits="AGC.Webform.wucViewInfoBak" %>
<table id="tabwucViewInfo" cellspacing="1" cellpadding="1" width="744" border="0"
    style="width: 744px; height: 448px">
    <tr>
        <td colspan="6" style="width: 75px">
            
                <asp:Label ID="Label1" runat="server" Width="96px"  ForeColor="#004040">界面基本信息:</asp:Label></font></td>
    </tr>
    <tr>
        <td colspan="6" style="width: 75px">
            <img style="width: 700px; height: 3px" height="3" alt="" src="../../pic/兰色直线1.gif"
                width="768"></td>
    </tr>
    <tr>
        <td style="width: 75px">
            <asp:Label ID="lblViewName" runat="server">界面名称</asp:Label>
        </td>
        <td style="width: 123px">
            <asp:TextBox ID="txtViewName" runat="server"  Width="200px" AutoPostBack="True"></asp:TextBox>
        </td>
        <td style="width: 59px">
            
                <asp:Label ID="lblViewCnName" runat="server">中文名称</asp:Label></font>
        </td>
        <td style="width: 120px">
            <asp:TextBox ID="txtViewCnName" runat="server" Width="181px" AutoPostBack="True"></asp:TextBox></td>

    </tr>
    <tr>
        <td style="width: 75px">
            <asp:Label ID="lblFileName" runat="server">文件名</asp:Label></td>
        <td style="width: 123px">
            <asp:TextBox ID="txtFileName" runat="server" Width="200px"></asp:TextBox></td>
        <td style="width: 59px">
            
                <asp:Label ID="lblFilePath" runat="server">文件路径</asp:Label></font></td>
        <td style="width: 120px">
            <asp:TextBox ID="txtFilePath" runat="server" Width="181"></asp:TextBox></td>
        <td style="width: 70px">
            <asp:Label ID="lblFuncModuleId" runat="server">功能模块Id</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlFuncModuleId" runat="server" Width="128px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td style="width: 75px" colspan="2">
            <asp:CheckBox ID="chkIsNeedSort" runat="server" Text="DataGrid是否需要排序" Width="160px">
            </asp:CheckBox></td>
        <td style="width: 83px" colspan="2">
            <asp:CheckBox ID="chkIsNeedTransCode" runat="server" Width="208px" Text="DataGrid中是否需要转换代码">
            </asp:CheckBox></td>
        <td style="width: 70px">
            
                <asp:Label ID="lblDefaMenuName" runat="server">默认菜单名</asp:Label></font></td>
        <td>
            
                <asp:TextBox ID="txtDefaMenuName" runat="server" Width="136px"></asp:TextBox></font></td>
    </tr>
    <tr>
        <td style="width: 75px" colspan="6">
            
                <asp:Label ID="Label3" runat="server" Width="128px"  ForeColor="#004040">界面相关表信息:</asp:Label></font></td>
    </tr>
    <tr>
        <td style="width: 75px" colspan="6">
            <img style="width: 700px; height: 3px" height="3" alt="" src="../../pic/兰色直线1.gif"
                width="768"></td>
    </tr>
    <tr>
        <td style="width: 75px">
            <asp:RadioButtonList ID="rblMainTabType" Width="55px" runat="server" AutoPostBack="True">
                <asp:ListItem Value="表" Selected="True">表</asp:ListItem>
                <asp:ListItem Value="视图">视图</asp:ListItem>
            </asp:RadioButtonList></td>
        <td style="width: 123px">
            <div style="width: 185px; position: relative; height: 22px" id="divMainTab" runat="server">
                <asp:Label ID="lblMainTabName" runat="server" Style="z-index: 101; left: 0px; position: absolute;
                    top: 0px">主表名</asp:Label>
                <asp:DropDownList ID="ddlMainTabId" runat="server" Width="128px" Style="z-index: 102;
                    left: 56px; position: absolute; top: 0px">
                </asp:DropDownList>
            </div>
            <div style="width: 185px; position: relative; height: 22px" id="divMainView" runat="server">
                <asp:Label ID="lblMainViewName" runat="server" Style="z-index: 101; left: 0px; position: absolute;
                    top: 0px">主视图名</asp:Label>
                <asp:DropDownList ID="ddlMainViewId" runat="server" Width="128px" Style="z-index: 102;
                    left: 56px; position: absolute; top: 0px">
                </asp:DropDownList>
            </div>
        </td>
        <td style="width: 123px">
        </td>
        <td colspan="3" align="left">
            
                <div style="width: 376px; position: relative; height: 32px">
                    <asp:Label ID="lblKeyForMainTab" Style="z-index: 101; left: 16px; position: absolute;
                        top: 0px" runat="server">主表关键字</asp:Label>
                    <asp:TextBox ID="txtKeyForMainTab" Style="z-index: 102; left: 80px; position: absolute;
                        top: 0px"  Width="168px" runat="server"></asp:TextBox>
                </div>
            </font>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDetailTabName" runat="server">明细表名</asp:Label>
        </td>
        <td style="width: 123px">
            
                <asp:DropDownList ID="ddlDetailTabId" runat="server" Width="152px">
                </asp:DropDownList></font></td>
        <td style="width: 123px">
            
                <asp:RadioButtonList ID="rblDetailTabType" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="表" Selected="True">表</asp:ListItem>
                    <asp:ListItem Value="视图">视图</asp:ListItem>
                </asp:RadioButtonList></font>
        </td>
        <td colspan="4" align="left">
            <div style="width: 444px; position: relative; height: 32px">
                <asp:Label ID="lblKeyForDetailTab" Style="z-index: 101; left: 0px; position: absolute;
                    top: 0px" runat="server">明细表关键字</asp:Label>
                <asp:TextBox ID="txtKeyForDetailTab" Style="z-index: 102; left: 80px; position: absolute;
                    top: 0px"  Width="168px" runat="server"></asp:TextBox>
            </div>
        </td>
    </tr>
    <tr>
        <td colspan="6" style="width: 75px">
            
                <asp:Label ID="Label5" runat="server" Width="128px"  ForeColor="#004040">界面功能及说明:</asp:Label></font></td>
    </tr>
    <tr>
        <td colspan="6" style="width: 75px">
            <img style="width: 700px; height: 3px" height="3" alt="" src="../../pic/兰色直线1.gif"
                width="768"></td>
    </tr>
    <tr>
        <td style="width: 75px" valign="top">
            <asp:Label ID="lblViewFunction" runat="server">界面功能</asp:Label>
        </td>
        <td colspan="5">
            <asp:TextBox ID="txtViewFunction" runat="server" Width="568px" Height="168px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 75px" valign="top" colspan="1" rowspan="1">
            <asp:Label ID="lblViewDetail" runat="server">界面说明</asp:Label>
        </td>
        <td colspan="5" rowspan="1">
            <asp:TextBox ID="txtViewDetail" runat="server" Width="568px" Height="80px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
    <tr>
        <td>
            <asp:Label ID="lblUserId" runat="server">用户ID</asp:Label></td>
        <td>
            <asp:TextBox ID="txtUserId" runat="server"  ></asp:TextBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPrjId" runat="server">工程ID</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlPrjId" runat="server" Width="120px">
            </asp:DropDownList></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDataBaseName" runat="server">数据库名</asp:Label></td>
        <td>
            <asp:TextBox ID="txtDataBaseName" runat="server" Width="120px" ></asp:TextBox></td>
        <td>
            
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblViewId" runat="server">界面ID</asp:Label></td>
        <td>
            <asp:TextBox ID="txtViewId" runat="server" Width="120px" ></asp:TextBox></td>
        <td>
        </td>
    </tr>
</table>
