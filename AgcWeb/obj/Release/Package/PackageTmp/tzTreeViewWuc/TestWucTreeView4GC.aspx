<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestWucTreeView4GC.aspx.cs" Inherits="AGC.Webform.TestWucTreeView4GC" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta http-equiv="Cache-Control" content="no-siteapp" />
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />

    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>

    <link href="../tzMenuWuc/cssMenu1.css" rel="stylesheet" />
    <link href="./cssTreeView.css" rel="stylesheet" type="text/css" />

    <script src="../js/tzPubFun.js"></script>
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
        function GetHelloWorld() {
            $.ajax({
                type: "post",
                datatype: "json",
                url: "/Agc/Webform/Table/wfmPrjTab_QUDI3.aspx/HelloWorld",
                contentType: "application/json",
                success: function (result) {
                    alert(result.d);
                }
            });
        }
        function GeneCode2(strCodeTypeId, strTabId) {
            $.ajax({
                type: "post",
                datatype: "json",
                data: '{"strCodeTypeId": "0001",' +
                    '"strTabId": "01160063",' +
                    '"strViewId":""}',
                url: "TestWucTreeView4GC.aspx/GeneCode",
                contentType: "application/json",
                success: function (result) {
                    ShowCode(result.d);
                }
            });
        }
        function GeneCode(strCodeTypeId, strTabId, intApplicationTypeId) {
            //返回长度超过一定数量就不能返回了，怎么办？
            $.ajax({
                type: "post",
                datatype: "json",
                data: '{"strCodeTypeId":"' + strCodeTypeId + '",' +
                    '"strTabId":"' + strTabId + '",' +
                    '"intApplicationTypeId":"' + intApplicationTypeId + '",' +
                    '"strViewId":""}',
                url: "/Agc/Webform/Table/wfmPrjTab_QUDI3.aspx/GeneCode",
                contentType: "application/json",
                success: function (result) {
                    ShowCode(result.d);
                }
            });
        }

        function GeneCode4Func(strCodeTypeId, strTabId, strFuncId, intApplicationTypeId) {
            //返回长度超过一定数量就不能返回了，怎么办？
            $.ajax({
                type: "post",
                datatype: "json",
                data: '{"strCodeTypeId":"' + strCodeTypeId + '",' +
                    '"strTabId":"' + strTabId + '",' +
                    '"strFuncId":"' + strFuncId + '",' +
                    '"intApplicationTypeId":"' + intApplicationTypeId + '",' +
                    '"strViewId":""}',
                url: "/Agc/Webform/Table/wfmPrjTab_QUDI3.aspx/GeneCode4Func",
                contentType: "application/json",
                success: function (result) {
                    ShowCode(result.d);
                }
            });
        }

        function ShowCode(strCode) {

             var txtCode = document.getElementById("txtCode");
            var objJSON = JSON.parse(strCode)
            txtCode.value = objJSON.Code;
            var txtClassName4GC = document.getElementById("txtClassName4GC");
            if (txtClassName4GC != null) {
                txtClassName4GC.value = objJSON.ClassName;
            }
            if (txtFileName4GC != null) {
                txtFileName4GC.value = objJSON.FileName;
            }
            //$('#txtCode').val(strCode);
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

        /*End    顶部菜单////////////////////////////////////////////////////////////************/
    </style>
    
    <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true">
        </asp:ScriptManager>
        <div style="width: 100%; float: left">
            <table style="width: 100%;">
                <tr>
                    <td rowspan="14" style="vertical-align: top">
                        <uc1:wucTreeView runat="server" ID="wucTreeView4PrjTab" OnafterSelect_Tz="wucTreeView4PrjTab_afterSelect_Tz" />
                        <uc1:wucTreeView runat="server" ID="wucTreeView4ViewInfo" OnafterSelect_Tz="wucTreeView4ViewInfo_afterSelect_Tz" />

                    </td>
                    <td rowspan="14" style="vertical-align: top">
                        <uc1:wucTreeView runat="server" ID="wucTreeView1" OnafterSelect_Tz="wucTreeView1_afterSelect_Tz" />
                    </td>
                    <td>

                        <asp:Button ID="btnBindTv" runat="server" Text="重新绑定树" OnClick="btnBindTv_Click" />

                        <asp:Button ID="btnModalDialogTest" runat="server" Text="测试模态对话框生成" OnClick="btnModalDialogTest_Click" />
                        <input id="btnGeneCodeByJs" type="button" value="生成代码ByJs" onclick="GeneCode2();" />

                    </td>
                    <td>
                        <input id="btnInvokeHelloWorld" type="button" value="调用后台HelloWorld" onclick="GetHelloWorld();" /></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="vertical-align: top">
                        <asp:Literal ID="litCode" runat="server"></asp:Literal>
                        <textarea id="txtCode" style="width: 80%; height: 700px;" cols="20" rows="2"></textarea>

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

                        <asp:Label ID="lblMsgList" runat="server" Text="Label"></asp:Label>
                        <asp:TextBox ID="txtFileName4GenCode" runat="server" Width="393px">00620001</asp:TextBox>
                    </td>
                    <td>

                        <asp:Button ID="btnGetCurrNodeValuePath" runat="server" Text="获取当前结点的值路径" OnClick="btnGetCurrNodeValuePath_Click" Width="165px" />
                    </td>
                    <td>

                        <asp:Button ID="btnGetAllCheckedNodeValueLst" runat="server" Text="获取所有复选结点的选择的值列表" OnClick="btnGetAllCheckedNodeValueLst_Click" Width="222px" />

                        <br />

                        <asp:Button ID="btnGetAllCheckedPathNodeValueLst" runat="server" Text="获取所有复选结点的选择的值列表，含相关父结点" OnClick="btnGetAllCheckedPathNodeValueLst_Click" Width="305px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>

                    <td colspan="3" rowspan="4" style="vertical-align: top">
                        <asp:ListBox ID="ListBox1" runat="server" Height="406px" Width="235px"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
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
