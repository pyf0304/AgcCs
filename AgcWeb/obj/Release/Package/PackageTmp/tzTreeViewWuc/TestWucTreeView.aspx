<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestWucTreeView.aspx.cs" Inherits="AGC.Webform.TestWucTreeView" %>

<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="../js/tzPubFun.js"></script>
    <link href="../tzMenuWuc/cssMenu1.css" rel="stylesheet" />
    <script>
        function ClearText(txtCode) {
            var txtCode = getObjByTagAndId("textarea", "txtCode");
            if (txtCode != null) {
                txtCode.value = "";
            }
            var txtCode_Sim = getObjByTagAndId("textarea", "txtCode_Sim");
            if (txtCode_Sim != null) {
                txtCode_Sim.value = "";
            }
        }
        function TestNodeClick(strKeyId) {
            console.log(strKeyId);
            alert(strKeyId);
        }
    </script>
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

       
    </style>
    <link href="./cssTreeView.css" rel="stylesheet" type="text/css" />
        <style type="text/css">
        body{
            font-size:0.875rem;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">

        <div style="width: 100%; float: left">
            <table style="width: 100%;">
                <tr>
                    <td rowspan="14" style="vertical-align: top">
                        <uc1:wucTreeView runat="server" ID="wucTreeView1" OnafterSelect_Tz="wucTreeView1_afterSelect_Tz" />
                   
                    </td>
                    <td class="auto-style1">

                        <asp:Button ID="btnBindTv" runat="server" Text="重新绑定树" OnClick="btnBindTv_Click" /></td>
                    <td class="auto-style1">
                        </td>
                         <td class="auto-style1">
                        </td>
                         <td class="auto-style1">
                        </td>
                         <td class="auto-style1">
                        </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtKeyId" runat="server" Width="103px">00620001</asp:TextBox>
                        <br />
                        <asp:TextBox ID="txtKeyId2" runat="server" Width="103px">00620013</asp:TextBox>

                        <br />

                        <asp:Button ID="btnSelectNode" runat="server" Text="选择结点" OnClick="btnSelectNode_Click" /></td>
                    <td>
                        <asp:TextBox ID="txtKeyId_Sel" runat="server" Width="103px">00620001</asp:TextBox>
                        <br />
                        <asp:Button ID="btnExpandNode" runat="server" Text="扩展某一个结点" OnClick="btnExpandNode_Click" /></td>
                    <td>
                        <asp:Button ID="btnGetCurrNodeRelaValue" runat="server" Text="获取当前结点的相关值" OnClick="btnGetCurrNodeRelaValue_Click" />

                        <asp:Label ID="lblMsg2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td rowspan="2">

                        <asp:Button ID="btnTestStruct" runat="server" Text="测试属性结构" OnClick="btnTestStruct_Click" />

                        <br />

                        <asp:Button ID="btnGetAllPropNameValue" runat="server" Text="获取所有属性名值" OnClick="btnGetAllPropNameValue_Click" Width="136px" />

                        <br />

                        <asp:Button ID="btnGetPropNameLst" runat="server" Text="获取属性名列表" OnClick="btnGetPropNameLst_Click" />

                        <br />

                        <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>

                        <asp:Button ID="btnGetCurrNodeValuePath" runat="server" Text="获取当前结点的值路径" OnClick="btnGetCurrNodeValuePath_Click" Width="165px" />
                    </td>
                    <td>

                        <asp:Button ID="btnGetAllCheckedNodeValueLst" runat="server" Text="获取所有复选结点的选择的值列表" OnClick="btnGetAllCheckedNodeValueLst_Click" Width="222px" />

                        <br />

                        <asp:Button ID="btnGetAllCheckedPathNodeValueLst" runat="server" Text="获取所有复选结点的选择的值列表，含相关父结点" OnClick="btnGetAllCheckedPathNodeValueLst_Click" Width="305px" />
                    </td>
                    <td>

                        &nbsp;</td>
                </tr>
                <tr>
                   
                    <td colspan="3" rowspan="4" style="vertical-align: top">
                        <asp:ListBox ID="ListBox1" runat="server" Height="406px" Width="513px"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
            </table>


            <br />
        </div>
        

    </form>
</body>
</html>
