<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmGenFunction4Code.aspx.cs"
    Inherits="AGC.Webform.wfmGenFunction4Code" ValidateRequest="false" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width,initial-scale=1,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no" />
    <meta name="renderer" content="webkit|ie-comp|ie-stand" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta http-equiv="Cache-Control" content="no-siteapp" />
    <meta name="keywords" content="scclui框架" />
    <meta name="description" content="工程表维护" />

    <title>工程表维护</title>
    
    <link href="../../css/button.css" rel="stylesheet" type="text/css" />
    <link href="../../css/LinkButton.css" rel="stylesheet" type="text/css" />
    <link href="../../css/tz_MenuButton/tz_sccl.css" rel="stylesheet" />
    <script src="../../js/tzPubFun.js" type="text/javascript"></script>
    <script type="text/javascript">
        function GenControlCode() {
            var txtCode = getObjByTagAndId("textarea", "txtCode");
            if (txtCode != null) {
                txtCode.value = "";
            }
            var txtCode_Sim = getObjByTagAndId("textarea", "txtCode_Sim");
            if (txtCode_Sim != null) {
                txtCode_Sim.value = "";
            }
            var divCode = getObjByTagAndId("div", "divCode");
            CallServer("GenControlCode|1!", divCode);
        }
        function GenCtlControlCode() {
            var txtCode = getObjByTagAndId("textarea", "txtCode");
            if (txtCode != null) {
                txtCode.value = "";
            }
            var txtCode_Sim = getObjByTagAndId("textarea", "txtCode_Sim");
            if (txtCode_Sim != null) {
                txtCode_Sim.value = "";
            }
            var divCode = getObjByTagAndId("div", "divCode");
            CallServer("GenCtlControlCode|1!", divCode);
        }
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
    </script>
    <script type="text/javascript">


        function ChangeLangType(strFunName, strLangType) {
            //if (event.keyCode == 13) {
            //event.cancelBubble = true;
            //event.returnValue = false;
            var lblLangTypeName = getObjByTagAndId("span", "lblLangTypeName");
            if (lblLangTypeName != null) {
                lblLangTypeName.innerHTML = strLangType;
            }
            else {
                alert("找不到lblLangTypeName");
            }
            document.all.FunName.value = strFunName;// "enter";
            document.all.hidLangType.value = strLangType;

            document.forms[0].submit();
            //}
        }
        function ChangeDataBaseType(strFunName, strDataBaseType) {
            //if (event.keyCode == 13) {
            //event.cancelBubble = true;
            //event.returnValue = false;
            document.all.FunName.value = strFunName;// "enter";
            document.all.hidDataBaseType.value = strDataBaseType;

            document.forms[0].submit();
            //}
        }
    </script>
    <style type="text/css">
        #btnSetFieldLst4Show {
            width: 100px;
        }

       
    </style>
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
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true">
        </asp:ScriptManager>
        <div id="Div1" class="tab_layout"
            runat="server">

            <%-- 标题层 --%>

            <div style="position: relative; width: 100%; height: 25px; left: 0px; top: 0px;">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" Width="252px">表字段管理->项目表维护                    </asp:Label>
                        </td>

                     
                        <td>&nbsp;</td>
                        <td>
                            <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" 
                                Width="263px"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>


            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table id="tabQueryCondition" border="0" style="width: 848px; padding: 2px;"
                    width="848" runat="server">
                    <tr>
                        <td style="text-align: right;">
                            <asp:Label ID="lblTabNameq" runat="server" CssClass="NameLabelRightAlign" Width="140px">WebService地址</asp:Label>
                        </td>
                        <td >
                            <asp:TextBox ID="txtWebSrvUrl" runat="server" Width="774px"></asp:TextBox>
                        </td>
                        <td style="text-align: right;">&nbsp;</td>
                        <td >&nbsp;</td>
                        <td ></td>
                        <td style="width: 118px; text-align: right">&nbsp;</td>
                        <td ></td>
                        <td >
                            <asp:Button ID="btnDIspFunctionInfo" runat="server" OnClick="btnDIspFunctionInfo_Click" CssClass="btn btn-outline-info btn-sm" Text="显示类函数信息" Width="110px" />
                        </td>
                        <td >&nbsp;</td>

                        <td >&nbsp;</td>

                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr id="trAdvanceQuery">
                        <td style="text-align: right">
                            <asp:Label ID="lblTabCnNameq" runat="server" CssClass="NameLabelRightAlign" Width="52px">中文名</asp:Label>
                        </td>
                        <td >
                            <asp:TextBox ID="txtTabCnNameq" runat="server" Width="220px"></asp:TextBox>
                        </td>
                        <td >&nbsp;</td>
                        <td >&nbsp;</td>
                        <td ></td>
                        <td style="width: 118px; height: 15px">&nbsp;</td>
                        <td >&nbsp;</td>
                        <td >&nbsp;</td>
                        <td colspan="4">&nbsp;</td>
                    </tr>
                </table>
            </div>
            <div id="divBaseOperate" class="tz-layout-menu" runat="server" style="width: 100%; height: 40px">
                <span class="menu-logo">基本操作:</span>
                <a class="menu-menu-btn" href="javascript:;"><i class="icon-font">&#xe600;</i></a>
                <ul class="menu-bar">
                    <li class="menu-bar-nav">
                        <a href="javascript:;">
                            <asp:Label ID="lblLangTypeName" Width="50px" CssClass="btn btn-outline-info btn-sm" runat="server" Text="DotNet"></asp:Label>
                            <i class="icon-font" style="margin-left: 5px;">&#xe60c;</i></a>

                        <ul class="menu-dropdown-menu">

                            <li><a href="javascript:ChangeLangType('ChangeLangType', 'DotNet');">DotNet</a></li>
                            <li><a href="javascript:ChangeLangType('ChangeLangType', 'Java');">Java</a></li>
                            <li><a href="javascript:ChangeLangType('ChangeLangType', 'Swift');">Swift</a></li>
                            <li><a href="javascript:ChangeLangType('ChangeLangType', 'Swift3');">Swift3</a></li>
                            <li><a href="javascript:ChangeLangType('ChangeLangType', 'JavaScript');">JavaScript</a></li>
                            <li><a href="javascript:ChangeLangType('ChangeLangType', 'SilverLight');">SilverLight</a></li>
                            <li></li>
                        </ul>
                    </li>
                    <li class="menu-bar-nav">
                        <a href="javascript:;">
                            <asp:Label ID="lblDataBaseType" Width="50px" CssClass="btn btn-outline-info btn-sm" runat="server" Text="Ms Sql"></asp:Label>
                            <i class="icon-font" style="margin-left: 5px;">&#xe60c;</i></a>

                        <ul class="menu-dropdown-menu">

                            <li><a href="javascript:ChangeDataBaseType('ChangeDataBaseType', 'Ms Sql');">Ms Sql</a></li>
                            <li><a href="javascript:ChangeDataBaseType('ChangeDataBaseType', 'Oracle');">Oracle</a></li>
                            <li><a href="javascript:ChangeDataBaseType('ChangeDataBaseType', 'MySql');">MySql</a></li>
                            <li></li>
                        </ul>
                    </li>
                    <li class="menu-bar-nav">
                        <a href="javascript:;">
                            <asp:Label ID="Label2" CssClass="btn btn-outline-info btn-sm" runat="server" Text="生成代码"></asp:Label>
                            <i class="icon-font" style="margin-left: 5px;">&#xe60c;</i></a>

                        <ul class="menu-dropdown-menu">
                            <li>
                                <asp:LinkButton ID="lbGeneWebServiceTransCode"
                                    runat="server" OnClick="lbGeneWebServiceTransCode_Click" Text="WEB服务转换层"></asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton ID="lbGeneControllerInvokeWS"
                                    runat="server" OnClick="lbGeneControllerInvokeWS_Click" CssClass="btn btn-outline-info btn-sm" Text="控制层(调Web服务转换)" Width="160px"></asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton ID="lbGeneController"
                                    runat="server" OnClick="lbGeneController_Click" Text="控制层"></asp:LinkButton>
                            </li>
                          <%--  <li>
                                <asp:LinkButton ID="lbGeneDict_PageName_Dir" runat="server" OnClick="lbGeneDict_PageName_Dir_Click" Text="页面目录字典"></asp:LinkButton>
                            </li>--%>
                            <li></li>
                        </ul>
                    </li>

                    <li class="menu-bar-nav">
                    </li>
                  
                        <%-- <li class="ChildDiv2">
                        <asp:Button ID="lbAddField" runat="server" OnClick="lbAddField_Click" CssClass="btn btn-outline-info btn-sm"
                            Width="73px" Text="维护表字段"></asp:Button>
                    </li>--%>
                    <li class="menu-bar-nav">
                    </li>
                    <li class="menu-bar-nav">
                    </li>
                    <li class="menu-bar-nav">
                    </li>

                   
                    <li class="menu-bar-nav"></li>
                </ul>
            </div>


            <%-- 列表层 --%>

            <div id="divList" class="div_List" runat="server">
                <asp:GridView ID="gvFunction4Code" Style="z-index: 120; position: relative;" runat="server"
                    Width="100%" AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True"
                    OnSorting="gvFunction4Code_Sorting" OnPageIndexChanging="gvFunction4Code_PageIndexChanging"
                    OnRowCreated="gvFunction4Code_RowCreated" OnRowCommand="gvFunction4Code_RowCommand" OnRowDeleting="gvFunction4Code_RowDeleting"
                    OnRowUpdating="gvFunction4Code_RowUpdating" BackColor="White" BorderColor="#E7E7FF"
                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="1px"
                    DataKeyNames="FuncId4Code" CssClass="table table-striped table-bordered table-condensed">
                    <Columns>
                        <asp:TemplateField HeaderText="全选">
                            <HeaderStyle Width="35px" />
                            <HeaderTemplate>
                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="FuncId4Code" SortExpression="FuncId4Code" HeaderText="序号" Visible="true"></asp:BoundField>
                        <asp:BoundField DataField="FuncName4Code" SortExpression="FuncName4Code" HeaderText="函数名">
                            <HeaderStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="GetCustomAttributes" SortExpression="GetCustomAttributes" HeaderText="GetCustomAttributes">
                            <HeaderStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                           <asp:BoundField DataField="ReturnTypeID" SortExpression="ReturnTypeID" HeaderText="返回类型Id">
                            <HeaderStyle HorizontalAlign="Left" />
                        </asp:BoundField>
                        <asp:BoundField DataField="FunctionSignature" SortExpression="FunctionSignature" HeaderText="函数签名">
                            <ItemStyle Width="50%" />
                        </asp:BoundField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lbEditObjectAndTabFields" runat="Server" CommandName="EditObjectAndTabFields" ToolTip="为当前表编辑相关内容：对象属性、表属性、表字段等。" Text="综合维护"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <PagerTemplate>
                        <span class="text-secondary">共有记录:</span>
                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                            Width="24px">0</asp:Label>
                        <span style="background-color: #c0c0c0">
                            <div style="display: inline; width: 16px;">
                            </div>
                        </span><span class="text-secondary">总页数:</span>
                        <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                        <div style="display: inline; width: 16px;">
                        </div>
                        <span class="text-secondary">当前页:</span>
                        <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                        <div style="display: inline; width: 16px;">
                        </div>
                        <asp:Button ID="btnPrevPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" Text="上一页"
                            CommandArgument="Prev" CommandName="Page" /><span style="font-family: Verdana">
                            </span>
                        <asp:Button ID="btnNextPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" Text="下一页"
                            CommandArgument="Next" CommandName="Page" />
                        到第
                                    <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
                                    <asp:Button ID="btnJumpPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" OnClick="btnJumpPage_Click"
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
                            ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>&nbsp;
                    </PagerTemplate>
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                </asp:GridView>

            </div>

            <div id="divCode" runat="server">
                <table id="tabCode" runat="server" border="1" cellpadding="1" cellspacing="1" style="width: 90%; height: 618px">
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Font-Names="宋体" Font-Size="Smaller"
                                Width="144px">生成的逻辑层代码：</asp:Label>
                            <asp:TextBox ID="txtFileName4GenCode" runat="server" Width="528px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbDispTabList" runat="server" Width="150px" CssClass="btn btn-outline-info btn-sm" OnClick="lbDispTabList_Click">显示表名列表</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            
                              <asp:Literal ID="litCode" runat="server"></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:TextBox ID="txtCode_Sim" runat="server" Height="250px" TextMode="MultiLine" Width="100%"></asp:TextBox>
                        </td>
                    </tr>
                </table>

            </div>

        </div>
        
        <script src="../../Scripts/jquery-3.6.0.min.js"></script>
        <script type="text/javascript" src="../../js/tz_MenuButton/tz_sccl.js"></script>
        <script type="text/javascript" src="../../js/tz_MenuButton/tz_sccl-util.js"></script>
        <input type="hidden" name="FunName" />
        <input type="hidden" name="hidLangType" />
        <input type="hidden" name="hidDataBaseType" />

    </form>
</body>
</html>
