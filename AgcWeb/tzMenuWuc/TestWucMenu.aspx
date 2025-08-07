<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="TestWucMenu.aspx.cs" Inherits="AGC.Webform.CommonPage.TestWucMenu" %>

<%@ Register Src="~/tzMenuWuc/wucMenu.ascx" TagPrefix="uc1" TagName="wucMenu" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../tzMenuWuc/cssMenu1.css" rel="stylesheet" />
    <style>
        /*Start    顶部菜单////////////////////////////////////////////////////////////************/


        .mnuTopMenu {
            background-color: Transparent;
            font-family: 宋体;
            font-size: 12px;
            position: relative;
            top: 34px;
        }

        .DynamicMenuStyle /*动态菜单矩形区域样式*/ {
            background-color: white;
            border: solid 1px #ACC3DF;
            padding: 1px 1px 1px 1px;
            text-align: left;
        }

        .DynamicHoverStyle /*动态菜单项:鼠标悬停时的样式*/ {
            background-color: #F7DFA5; /*#7C6F57;*/
            color: #333333;
        }

        .DynamicSelectedStyle /*动态菜单项:选择时的样式*/ {
            /*background-color:Gainsboro;*/
            color: red;
        }

        .DynamicMenuItemStyle /*动态菜单项样式*/ {
            padding: 2px 5px 2px 5px;
            color: #333333;
        }


        .StaticSelectedStyle /*静态菜单项:选择时的样式*/ {
            /*background-color:Gainsboro;*/
            color: red;
        }

        .StaticMenuItemStyle /*静态菜单项样式*/ {
            cursor: hand;
            padding: 2px 5px 2px 5px;
            color: #333333;
            background-color: : Transparent;
            font-size: 18px;
        }

        .StaticHoverStyle /*静态菜单项:鼠标悬停时的样式*/ {
            background-color: #84BCCD; /*#7C6F57;*/
            cursor: hand;
            color: #333333;
        }

        /*End    顶部菜单////////////////////////////////////////////////////////////************/
    </style>
    <link href="./cssTreeView.css" rel="stylesheet" type="text/css" />
      <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 100%; height: 500px">

            <div style="width: 30%; float: left; ">

                <uc1:wucMenu runat="server" ID="wucMenu1" CssClass="tzMenu_L0" StaticDisplayLevels="2" OnafterSelect_Tz="wucMenu1_afterSelect_Tz" />

                <br />
            </div>

            <div style="width: 60%; float: right; ">

                <uc1:wucMenu runat="server" ID="wucMenu2" CssClass="tzMenu_L0" StaticDisplayLevels="1" OnafterSelect_Tz="wucMenu1_afterSelect_Tz" />

                <br />
            </div>
        </div>
        <div style="width: 100%; float: left; height: 200px;">
            <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
            <br />

            <asp:Menu ID="Menu1" runat="server" StaticDisplayLevels="2" CssClass="tzMenu_L0" OnMenuItemClick="Menu1_MenuItemClick">
                <Items>
                    <asp:MenuItem Text="AAA" Value="AAA"></asp:MenuItem>
                    <asp:MenuItem Text="BBB" Value="BBB">
                        <asp:MenuItem Text="BBB1" Value="BBB1"></asp:MenuItem>
                        <asp:MenuItem Text="BBB3" Value="BBB3"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="BBB2" Value="BBB2"></asp:MenuItem>
                </Items>
                <%--    <LevelMenuItemStyles>
                    <asp:MenuItemStyle CssClass="tzMenu_L1" Font-Underline="False" />
                </LevelMenuItemStyles>
                <LevelSelectedStyles>
                    <asp:MenuItemStyle Font-Underline="False" CssClass="tzMenu_l3" />
                </LevelSelectedStyles>
                <LevelSubMenuStyles>
                    <asp:SubMenuStyle CssClass="tzMenu_L4" Font-Underline="False" />
                </LevelSubMenuStyles>
                <%-- <StaticMenuItemStyle CssClass="tzMenu_L2" Width="100px" />

                <StaticHoverStyle CssClass="tzMenu_L1" />
                <DynamicMenuItemStyle CssClass="tzMenu_L2" Width="150px" />--%>
            </asp:Menu>
        </div>
        <div style="width: 100%; float: left; height: 200px;">
            <asp:Menu ID="mnuTopMenu" runat="server" DynamicEnableDefaultPopOutImage="False"
                DynamicHorizontalOffset="-1" Font-Bold="false" StaticEnableDefaultPopOutImage="False"
                StaticSubMenuIndent="10px" DisappearAfter="600"
                StaticSelectedStyle-CssClass="StaticSelectedStyle"
                StaticMenuItemStyle-CssClass="StaticMenuItemStyle"
                StaticHoverStyle-CssClass="StaticHoverStyle"
                DynamicMenuStyle-CssClass="DynamicMenuStyle"
                DynamicSelectedStyle-CssClass="DynamicSelectedStyle"
                DynamicMenuItemStyle-CssClass="DynamicMenuItemStyle"
                DynamicHoverStyle-CssClass="DynamicHoverStyle"
                OnMenuItemClick="mnuTopMenu_MenuItemClick" StaticDisplayLevels="2">
                <Items>
                    <asp:MenuItem Text="AAA" Value="AAA"></asp:MenuItem>
                    <asp:MenuItem Text="BBB" Value="BBB">
                        <asp:MenuItem Text="BBB1" Value="BBB1">
                            <asp:MenuItem Text="新建项" Value="新建项"></asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem Text="BBB3" Value="BBB3"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="BBB2" Value="BBB2"></asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
    </form>
</body>
</html>
