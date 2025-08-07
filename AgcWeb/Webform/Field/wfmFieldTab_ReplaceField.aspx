<%@ Page Language="c#" CodeBehind="wfmFieldTab_ReplaceField.aspx.cs" AutoEventWireup="True" 
    Inherits="AGC.Webform.wfmFieldTab_ReplaceField" EnableEventValidation="false" %>

<%@ Register TagPrefix="uc1" TagName="wucFieldTab" Src="wucFieldTab.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>表字段替换</title>
    
    <link href="../css/button.css" rel="stylesheet" type="text/css" />
    <link href="../css/LinkButton.css" rel="stylesheet" type="text/css" />
    
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
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true">
        </asp:ScriptManager>


        <table id="Table2" style="z-index: 107; left: 4px; position: absolute; top: 32px; border-color: #ff3300"
            cellspacing="0" cellpadding="0" width="100%" border="0">
            <tr>
                <td style="width: 200px">
                    <asp:Label ID="Label3" Style="z-index: 102; left: 8px;"
                        runat="server" CssClass="h5" Width="254px">表字段管理->表字段替换</asp:Label>
                </td>
                <td style="width: 600px">
                    <asp:Label ID="Label1" Style="z-index: 101; left: 208px; top: 8px"
                        runat="server" CssClass="MemoStyle1" Width="638px">主要用来本工程中一个字段替换成另一个字段。</asp:Label>
                </td>
            </tr>

            
            <tr>
                <td style="width: 200px; text-align: right; height: 30px">
                                                        &nbsp;</td>
                <td style="width: 500px">
                    &nbsp;</td>
                <td style="width: 60px">
                    &nbsp;</td>

            </tr>

            
            <tr>
                <td style="width: 200px; text-align:right">
                                                        <asp:Label ID="Label12" Style="z-index: 101; left: 0px; top: 8px"
                                                            runat="server" CssClass="h6" Width="72px">替换区域</asp:Label>
                                                    </td>
                <td style="width: 500px">
                    &nbsp;</td>
                <td style="width: 60px">
                    &nbsp;</td>

            </tr>

            
            <tr>
                <td style="width: 200px; text-align:right">
                     <asp:Label ID="Label2" Style="z-index: 102; left: 8px;"
                        runat="server" CssClass="NameLabel2">原字段</asp:Label></td>
                <td style="width: 500px">
                    <asp:Label ID="lblSourceField" runat="server" Text="源字段信息" CssClass="ValueLabel2"></asp:Label>
                </td>
                <td style="width: 60px">
                    <asp:Button ID="btnSetSourceField" runat="server" Text="设置源字段" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetSourceField_Click" />
                    <asp:HiddenField ID="hfSourceFieldId" runat="server" />
                    </td>

            </tr>

            
            <tr>
                <td style="width: 200px; text-align:right">
                     <asp:Label ID="Label11" Style="z-index: 102; "
                        runat="server" CssClass="NameLabel2">目标字段</asp:Label></td>
                <td style="width: 500px">
                    <asp:Label ID="lblTargetField" runat="server" Text="目标字段信息" CssClass="ValueLabel2"></asp:Label>
                    </td>
                <td>
                    <asp:Button ID="btnSetTargetField" runat="server" Text="设置目标字段" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetTargetField_Click" />
                     <asp:HiddenField ID="hfTargetFieldId" runat="server" />
                </td>
            </tr>

            
            <tr>
                <td style="width: 200px">
                    &nbsp;</td>
                <td style="width: 500px">
                    <asp:Button ID="btnSumbitReplace" runat="server" Text="确认替换" CssClass="btn btn-outline-info btn-sm" OnClick="btnSumbitReplace_Click" />
                    </td>
                   <td style="width: 60px">
                       &nbsp;</td>
            </tr>

            
            <tr>
                <td style="width: 200px; height: 20px">
                    &nbsp;</td>
                <td style="width: 500px">
                    &nbsp;</td>
                   <td style="width: 60px">
                       &nbsp;</td>
            </tr>

            
            <tr>
                <td colspan="3">
                    <table id="tabQuery" style="width: 100%; border-color: #0066ff" cellspacing="0" cellpadding="0"
                        border="0" runat="server" width="100%">
                        <tr>
                            <td colspan="5">
                                <table id="Table3" cellspacing="0" cellpadding="0" width="300" border="0">
                                    <tr>
                                        <td>
                                            <table id="Table1" style="width: 800px" cellspacing="1" cellpadding="1" width="800"
                                                border="0">
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label7" Style="z-index: 101; left: 0px; top: 8px"
                                                            runat="server" CssClass="h6" Width="72px">基本查询</asp:Label>
                                                    </td>

                                                </tr>
                                                <tr>
                                                    <td align="left" rowspan="1">
                                                        <table style="width: 827px; height: 44px; position: relative; left: 0px; top: 0px;">
                                                            <tr>
                                                                <td>
                                                                    <asp:Label ID="Label10" runat="server" Width="56px" Style="z-index: 100; left: 14px; top: 5px"
                                                                        CssClass="text-secondary">功能模块</asp:Label>
                                                                </td>
                                                                <td>
                                                                    <asp:DropDownList ID="ddlFuncModuleIdq" runat="server" Width="216px" AutoPostBack="True"
                                                                        OnSelectedIndexChanged="ddlFuncModuleId_q_SelectedIndexChanged" Style="z-index: 101; left: 74px; top: 4px">
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td>
                                                                    <asp:Label ID="Label4" runat="server" Style="z-index: 102; left: 303px; top: 7px"
                                                                        CssClass="text-secondary">相关对象</asp:Label>
                                                                </td>
                                                                <td>
                                                                    <asp:DropDownList ID="ddlTabIdq" runat="server" Width="168px" AutoPostBack="True"
                                                                        Style="z-index: 103; left: 373px; top: 5px" OnSelectedIndexChanged="ddlObjId_q_SelectedIndexChanged">
                                                                    </asp:DropDownList>
                                                                </td>
                                                                <td>
                                                                    <asp:Label ID="lblFldNameq" runat="server" Style="z-index: 104; left: 558px; top: 10px"
                                                                        CssClass="text-secondary">字段名称</asp:Label>
                                                                </td>
                                                                <td>
                                                                    <asp:TextBox ID="txtFldNameq" runat="server" Width="133px" Style="z-index: 105; left: 625px; top: 9px"></asp:TextBox>
                                                                </td>
                                                                <td>
                                                                    <asp:Button ID="btnQuery" Style="z-index: 102; left: 632px;"
                                                                        runat="server"  Text="查询" OnClick="btnQuery_Click" CssClass="btn btn-outline-warning btn-sm"></asp:Button>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>

                                    </tr>


                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">

                                <table style="width: 100%;">
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label8"  runat="server" CssClass="h6">工程字段列表</asp:Label>
                                        </td>
                                        <td>
                                            <asp:Label ID="lblMsgList" runat="server" Style="z-index: 103;" Width="157px" CssClass="text-warning"></asp:Label>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:LinkButton ID="lbSetField" runat="server" 
                                                CssClass="btn btn-outline-info btn-sm" OnClick="lbSetField_Click">设置字段</asp:LinkButton>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td></td>
                                        <td></td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <asp:GridView ID="gvFieldTab" runat="server" AllowPaging="True" AllowSorting="True"
                                    AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
                                    BorderWidth="1px" CellPadding="2" CssClass="table table-striped table-bordered table-condensed" DataKeyNames="FldId" GridLines="Horizontal"
                                    Height="1px" OnPageIndexChanging="gvFieldTab_PageIndexChanging" OnRowCommand="gvFieldTab_RowCommand"
                                    OnRowCreated="gvFieldTab_RowCreated" OnRowDeleting="gvFieldTab_RowDeleting" OnRowUpdating="gvFieldTab_RowUpdating"
                                    OnSorting="gvFieldTab_Sorting" Style="z-index: 175; position: relative" Width="100%">
                                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                    <Columns>
                                        <asp:TemplateField>
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" runat="server" CommandName="lbSelAll" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <HeaderStyle Width="35px" />
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="FldId" HeaderText="字段ID" Visible="False" />
                                        <asp:BoundField DataField="FldName" HeaderText="字段名称" SortExpression="FldName">
                                            <HeaderStyle Width="130px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="FldBName_B" HeaderText="字段名称_后备" SortExpression="FldBName_B"
                                            Visible="False">
                                            <HeaderStyle Width="130px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="FldName_G" HeaderText="字段名称_国标" SortExpression="FldName_G"
                                            Visible="False">
                                            <HeaderStyle Width="130px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="Caption" HeaderText="标题名称" SortExpression="Caption">
                                            <HeaderStyle Width="100px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="DataTypeName" HeaderText="类型" SortExpression="DataTypeName">
                                            <HeaderStyle  />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="FldLength" HeaderText="长度">
                                            <HeaderStyle  />
                                        </asp:BoundField>
                                        <asp:CheckBoxField DataField="IsNull" HeaderText="可空" SortExpression="IsNull" />
                                        <asp:CheckBoxField DataField="IsPrimaryKey" HeaderText="主键" SortExpression="IsPrimaryKey" />
                                        <asp:BoundField DataField="IsNationStandard" HeaderText="国标" Visible="False" />
                                        <asp:BoundField DataField="MaxValue" HeaderText="最大值" Visible="False" />
                                        <asp:BoundField DataField="MinValue" HeaderText="最小值" Visible="False" />
                                        <asp:BoundField DataField="DefaultValue" HeaderText="缺省值" Visible="False" />
             <%--                           <asp:BoundField DataField="CodeTab" HeaderText="代码表" SortExpression="CodeTab" />
                                        <asp:BoundField DataField="CodeTabName" HeaderText="名称字段" Visible="False" />
                                        <asp:BoundField DataField="CodeTabCode" HeaderText="代码字段" Visible="False" />--%>
                                        <asp:BoundField DataField="TabNum" HeaderText="表数" SortExpression="TabNum" />
                                        <asp:BoundField DataField="AppliedScope" HeaderText="适用范围" Visible="False" />
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="Memo" HeaderText="备注" SortExpression="Memo">
                                            <ItemStyle CssClass="text-warning" />
                                        </asp:BoundField>
                                    </Columns>
                                    <PagerTemplate>
                                        <span class="text-secondary">共有记录:</span>
                                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                                            Width="46px">0</asp:Label>
                                        <span style="background-color: #c0c0c0">
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                        </span><span class="text-secondary">总页数:</span>
                                        <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <span class="text-secondary">当前页:</span>
                                        <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnPrevPage" runat="server" CommandArgument="Prev" CommandName="Page"
                                            CssClass="btn btn-outline-warning btn-sm small" Text="上一页" Width="50px" /><span style="font-family: Verdana">
                                            </span>
                                        <asp:Button ID="btnNextPage" runat="server" CommandArgument="Next" CommandName="Page"
                                            CssClass="btn btn-outline-warning btn-sm small" Text="下一页" Width="50px" />
                                        到第
                                    <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
                                    <asp:Button ID="btnJumpPage" runat="server" CommandName="Page" CssClass="btn btn-outline-warning btn-sm small"
                                        OnClick="btnJumpPage_Click" Text="确定" Width="35px" />
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
            </tr>
            <tr>
                <td style="height:20px"></td>
            </tr>
            <tr>
                <td  colspan="3">
                    <table id="tabPrjTab" runat="server">
                        <tr>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="同时有源字段和目标字段的表：" CssClass="Region_Title1"></asp:Label></td>
                        </tr>
                         <tr>
                            <td>                       <asp:GridView ID="gvPrjTab" Style="z-index: 120; position: relative;" runat="server"
                                Width="100%" AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True"
                                BackColor="White" BorderColor="#E7E7FF"
                                BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="1px"
                                DataKeyNames="TabId" CssClass="table table-striped table-bordered table-condensed">
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
                                    <asp:BoundField DataField="TabId" SortExpression="TabId" HeaderText="表ID" Visible="False">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="TabName" SortExpression="TabName" HeaderText="表名"></asp:BoundField>
                                    <asp:BoundField DataField="TabCnName" SortExpression="TabCnName" HeaderText="表中文名">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="功能模块">
                                    </asp:BoundField>

                                    <asp:BoundField DataField="SqlDsTypeName" SortExpression="SqlDsTypeName" HeaderText="表类型">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="DataBaseName" SortExpression="DataBaseName" HeaderText="数据库名"
                                        Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="FldNum" SortExpression="FldNum" HeaderText="字段数"></asp:BoundField>
                                    <asp:CheckBoxField DataField="IsChecked" HeaderText="核实?" SortExpression="IsChecked" />
                                    <asp:BoundField DataField="IsArchive" SortExpression="IsArchive" HeaderText="是否存档"
                                        Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="KeyFldName" SortExpression="KeyFldName" HeaderText="主键">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="PrimaryTypeName" SortExpression="PrimaryTypeName" HeaderText="主键类型">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="SQLDSTypeName" SortExpression="SQLDSTypeName" HeaderText="数据源类型">
                                    </asp:BoundField>
                       
                                    <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
                                    <asp:BoundField DataField="TabTypeName" SortExpression="TabTypeName" HeaderText="表类型"></asp:BoundField>
                                    <asp:BoundField DataField="ErrMsg" HeaderText="错误" SortExpression="ErrMsg">
                                        <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                            Font-Underline="False" ForeColor="#FF3300" />
                                    </asp:BoundField>
                                         <asp:BoundField DataField="TabStateName" SortExpression="TabStateName" HeaderText="使用状态">
                                    </asp:BoundField>
     <asp:BoundField DataField="IsReleToSqlTab" SortExpression="IsReleToSqlTab" HeaderText="SQL表相关?">
                                    </asp:BoundField>

                                    <asp:BoundField DataField="Owner" HeaderText="拥有者" SortExpression="Owner" Visible="false" />
                               <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbEditObjectAndTabFields" runat="Server" CommandName="EditObjectAndTabFields" ToolTip ="为当前表编辑相关内容：对象属性、表属性、表字段等。" Text="综合维护"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                       </Columns>
                                <PagerTemplate>
                                    <span class="text-secondary">共有记录:</span>
                                    <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                                        Width="24px">0</asp:Label>
                                    <span style="background-color: #c0c0c0">
                                        <div style="display: inline; width: 16px; ">
                                        </div>
                                    </span><span class="text-secondary">总页数:</span>
                                    <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; ">
                                    </div>
                                    <span class="text-secondary">当前页:</span>
                                    <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; ">
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
       </td>
                        </tr>
                    </table>
                  
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
