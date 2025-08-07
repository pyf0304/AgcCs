<%@ Page Title="" Language="C#" MasterPageFile="~/Webform/Table2/EditTable.master"
    AutoEventWireup="True" CodeBehind="wfmPrjTabFld_QUDI2.aspx.cs" Inherits="AGC.Webform.wfmPrjTabFld_QUDI2" %>

<%@ Register TagPrefix="uc5" TagName="wucPrjTabFld" Src="../Table/wucPrjTabFld.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../css/taishweb2.css" rel="stylesheet" type="text/css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <table id="tabWhole" border="0" cellpadding="0" cellspacing="0" width="560">
        <tr>
            <td>
                <table id="tabPrjTabFld" runat="server" border="0" cellpadding="0" cellspacing="0" width="448">
                    <tr>
                        <td colspan="2">
                            <div style="left: 16px; width: 797px">
                                <asp:Label ID="Label7" runat="server" CssClass="h6" Style="z-index: 107;
                                    left: 6px;">工程表字段列表</asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Style="z-index: 101;
                                    left: 251px; top: 0px; width: 84px;" Text="添加表字段" />
                                &nbsp;<asp:Button ID="btnDelRec" runat="server" OnClick="btnDelRec_Click" Style="z-index: 103;
                                    left: 362px; top: 0px; width: 83px;" Text="删除表字段" Width="74px" />
                                <asp:Button ID="btnSetTabFldProperty" runat="server" OnClick="btnSetProperty_Click"
                                    Style="z-index: 102; left: 484px; top: 0px" Text="设置表字段" Width="86px" />
                                <asp:Button ID="Button1" runat="server" OnClick="btnSetFldProperty_Click" Style="z-index: 105;
                                    left: 592px; top: 2px" Text="设置字段属性" Width="88px" />
                                &nbsp;<asp:Button ID="btnSetCanNull" runat="server" OnClick="btnSetCanNull_Click"
                                    Style="z-index: 105; left: 592px; top: 2px" Text="设置可空" Width="70px" />
                                <asp:Button ID="btnSetCanNotNull" runat="server" OnClick="btnSetCanNotNull_Click"
                                    Style="z-index: 105; left: 592px; top: 2px" Text="设置非空" Width="70px" />
                                <asp:Button ID="btnExportExcel" runat="server"  OnClick="btnExportExcel_Click"
                                    Style="z-index: 106; left: 704px;" Text="导出Exl" Width="49px" />
                                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Width="95px"></asp:Label>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <table style="width: 100%; height: 45px;">
                                <tr>
                                    <td class="style1">
                                       
                                        <asp:LinkButton ID="lbMoveRecTo" runat="server" OnClick="lbMoveRecTo_Click">移动记录到：</asp:LinkButton>
                                    </td>
                                    <td class="style2">
                                        <asp:RadioButtonList ID="rblSeqNum" runat="server" CssClass="Radio_Defa" 
                                            RepeatDirection="Horizontal">
                                            <asp:ListItem Value="第一">第一</asp:ListItem>
                                            <asp:ListItem Value="最后">最后</asp:ListItem>
                                            <asp:ListItem Value="第几">第几</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtRecSeqNum" runat="server" Width="42px">0</asp:TextBox>
                                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtRecSeqNum"
                                            CssClass="text-warning" ErrorMessage="请输入整数数字!" ForeColor="" Operator="DataTypeCheck"
                                            Type="Integer" Width="114px"></asp:CompareValidator>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:LinkButton ID="lbSynchWithTab" runat="server" OnClick="lbSynchWithTab_Click"
                                            ToolTip="把表与相关对象的所有字段完全同步，既使表与对象的字段列表完全一样。">与相关对象同步字段</asp:LinkButton>
                                    </td>
                                </tr>
                                <tr id="trErrMsg" runat="server">
                                    <td align="right"  colspan="5">
                                       
                                <asp:Label ID="lblErrMsg" runat="server" CssClass="text-warning"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            &nbsp;<asp:GridView ID="gvPrjTabFld" runat="server" AllowPaging="True" AllowSorting="True"
                                AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
                                BorderWidth="1px" CellPadding="3" CssClass="table table-striped table-bordered table-condensed" DataKeyNames="mId" GridLines="Horizontal"
                                Height="1px" OnPageIndexChanging="gvPrjTabFld_PageIndexChanging" OnRowCommand="gvPrjTabFld_RowCommand"
                                OnRowCreated="gvPrjTabFld_RowCreated" OnRowDataBound="gvPrjTabFld_RowDataBound"
                                OnSorting="gvPrjTabFld_Sorting" Width="800px">
                                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                <Columns>
                                    <asp:TemplateField HeaderText="全选">
                                        <HeaderTemplate>
                                            <asp:LinkButton ID="lbSelAll" runat="server" CommandName="lbSelAll" CssClass="btn btn-link btn-sm text-nowrap">全选</asp:LinkButton>
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkCheckRec" runat="server" />
                                        </ItemTemplate>
                                        <HeaderStyle Width="35px" />
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="SequenceNumber" HeaderText="序号" SortExpression="SequenceNumber" />
                                    <asp:BoundField DataField="FldName" HeaderText="字段名" SortExpression="FldName" />
                                    <asp:BoundField DataField="Caption" HeaderText="标题" SortExpression="Caption" />
                                    <asp:BoundField DataField="DataTypeName" HeaderText="类型" SortExpression="DataTypeName" />
                                    <asp:BoundField DataField="FldLength" HeaderText="长度" SortExpression="FldLength" />
                                    <asp:BoundField DataField="IsTabNullable" HeaderText="可空?" SortExpression="IsTabNullable" />
                                    
                                    <asp:BoundField DataField="PrimaryTypeName" HeaderText="主键类型" SortExpression="PrimaryTypeName" />
                                    <asp:BoundField DataField="FieldTypeName" HeaderText="字段类型" SortExpression="FieldTypeName" />
                                    <asp:BoundField DataField="IsTabUnique" HeaderText="唯一" SortExpression="IsTabUnique" />
                                    <asp:BoundField DataField="FldOpTypeName" HeaderText="操作类型" SortExpression="FldOpTypeName" />
                                    <asp:BoundField DataField="IsTabForeignKey" HeaderText="外键?" SortExpression="IsTabForeignKey" />
                                    <asp:BoundField DataField="IsParentObj" HeaderText="父对象?" SortExpression="IsParentObj" />
                                    <asp:BoundField DataField="ForeignTabName" HeaderText="外键表" SortExpression="ForeignTabName" />
                                    <asp:BoundField DataField="TabName" HeaderText="表名" SortExpression="TabName" Visible="False" />
                                    <asp:BoundField DataField="IsNull" HeaderText="可空" SortExpression="IsNull" Visible="False" />
                                    <asp:BoundField DataField="CodeTab" HeaderText="代码表" SortExpression="CodeTab" Visible="False" />
                                    <asp:BoundField DataField="CodeTabName" HeaderText="代码表_名称" SortExpression="CodeTabName"
                                        Visible="False" />
                                    <asp:BoundField DataField="CodeTabCode" HeaderText="代码表_代码" SortExpression="CodeTabCode"
                                        Visible="False" />
                                    <asp:BoundField DataField="DefaultValue" HeaderText="缺省值" SortExpression="DefaultValue"
                                        Visible="False" />
                                    <asp:BoundField DataField="MinValue" HeaderText="最小值" SortExpression="MinValue" Visible="False" />
                                    <asp:BoundField DataField="MaxValue" HeaderText="最大值" SortExpression="MaxValue" Visible="False" />
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
                                        OnClick="btnJumpPagePrjTabFld_Click" Text="确定" Width="35px" />
                                    <span class="text-secondary">页记录数:</span>
                                    <asp:DropDownList ID="ddlPagerRecCount" runat="server" AutoPostBack="True" CssClass="DropDown_DefaInPager"
                                        OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged" Width="41px">
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>10</asp:ListItem>
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
                                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <AlternatingRowStyle BackColor="#F7F7F7" />
                            </asp:GridView>
                        </td>
                        <td>
                            <div style="width: 33px; position: relative; height: 136px">
                                <asp:ImageButton ID="ibDown" runat="server" Height="28px" ImageUrl="~/pic/Down.JPG"
                                    OnClick="ibDown_Click" Style="z-index: 101; left: 0px; position: absolute; top: 48px"
                                    Width="24px" />
                                <asp:ImageButton ID="ibUp" runat="server" Height="28px" ImageUrl="~/pic/Up.JPG" OnClick="ibUp_Click"
                                    Style="z-index: 102; left: 0px; position: absolute; top: 8px" Width="24px" />
                                <asp:Button ID="btnReOrder" runat="server" Height="40px" OnClick="btnReOrder_Click"
                                    Style="z-index: 103; left: 0px; position: absolute; top: 88px" Text="重序" Width="30px" />
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <div style="width: 696px; position: relative; height: 26px">
                                <asp:Label ID="lblRecCount" runat="server" Font-Names="宋体" Font-Size="Smaller" 
                                    Style="z-index: 100; left: 8px; position: absolute; top: 8px" Width="56px">记录数：</asp:Label>
                                <asp:TextBox ID="txtRecCount" runat="server" Font-Names="宋体" Font-Size="Smaller"
                                     ReadOnly="True" Style="z-index: 101; left: 64px; position: absolute;
                                    top: 0px" ></asp:TextBox>
                                <asp:Label ID="lblMsg2" runat="server" ForeColor="Red"  Style="z-index: 102;
                                    left: 584px; position: absolute; top: 0px" Width="85px"></asp:Label>
                                &nbsp; &nbsp;&nbsp;
                            </div>
                        </td>
                        <td>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table id="tabEditPrjTabFld" runat="server" border="1" cellpadding="1" cellspacing="1"
                    style="width: 240px; height: 83px" width="240">
                    <tr>
                        <td>
                            <div style="width: 760px; position: relative; height: 26px">
                                <asp:Button ID="btnOKEdit" runat="server" OnClick="btnOKEdit_Click" Style="z-index: 101;
                                    left: 595px; position: absolute; top: 0px" Text="确定修改" Width="83px" />
                                <asp:Label ID="Label3" runat="server" CssClass="text-warning"  Style="z-index: 102;
                                    left: 247px; position: absolute; top: 8px" Width="345px"></asp:Label>
                                <asp:Label ID="Label4" runat="server" CssClass="text-secondary" Style="z-index: 103;
                                    left: 0px; position: absolute; top: 8px">工程表字段编辑</asp:Label>
                                <asp:LinkButton ID="lbDispTabFld2" runat="server" OnClick="lbDispTabFld2_Click" Style="z-index: 104;
                                    left: 688px; position: absolute; top: 8px">显示表字段</asp:LinkButton>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <uc5:wucPrjTabFld ID="wucPrjTabFld1" runat="server"></uc5:wucPrjTabFld>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table id="tabFieldTab" runat="server" border="0" cellpadding="1" cellspacing="1"
                    style="width: 474px">
                    <tr>
                        <td style="font-family: Verdana; height: 18px">
                            <table style="width: 100%;">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label10" runat="server" Style="z-index: 103;">源工程字段列表</asp:Label>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td colspan="2">
                                        &nbsp;
                                    </td>
                                    <td>
                                        <asp:LinkButton ID="lbDispTabFld" runat="server" OnClick="lbDispTabFld_Click" >显示表字段</asp:LinkButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <asp:Label ID="Label6" runat="server" CssClass="text-secondary" Font-Names="宋体" 
                                             Width="35px">对象</asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlPrjObject" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPrjObject_SelectedIndexChanged"
                                             Width="189px">
                                        </asp:DropDownList>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblFldID" runat="server">字段名称</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtFldName" runat="server" class="form-control-sm" Style="" Width="109px"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnQuery" runat="server"  OnClick="btnQuery_Click" Style=""
                                            Text="查询" Width="77px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td colspan="4">
                                        <asp:Label ID="lblMsg_Field" runat="server" CssClass="text-warning" ForeColor="Red" Height="19px"
                                            Style="z-index: 105; margin-bottom: 0px;" Width="105px"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnOkAdd" runat="server" OnClick="btnOkAdd_Click" 
                                            Text="确认添加" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <asp:DataGrid ID="dgObjFld4Sel" runat="server" AllowPaging="True" AllowSorting="True"
                                AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
                                BorderWidth="1px" CellPadding="1" CellSpacing="1" CssClass="table table-striped table-bordered table-condensed" OnItemCreated="dgObjFld4Sel_ItemCreated"
                                OnItemDataBound="dgObjFld4Sel_ItemDataBound" OnPageIndexChanged="dgObjFld4Sel_PageIndexChanged"
                                OnSortCommand="dgObjFld4Sel_SortCommand" Width="807px">
                                <FooterStyle BackColor="White" ForeColor="#000066" />
                                <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                <ItemStyle ForeColor="#000066" />
                                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                <Columns>
                                    <asp:TemplateColumn HeaderText="选择">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="ckb1" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateColumn>
                                    <asp:BoundColumn DataField="FldId" HeaderText="字段编号" Visible="False"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="FldName" HeaderText="字段名称" SortExpression="FldName">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="Caption" HeaderText="标题"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="DataTypeName" HeaderText="字段类型" SortExpression="DataTypeName">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="FldLength" HeaderText="字段长度" SortExpression="FldLength">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="IsNull" HeaderText="是否为空" SortExpression="IsNull"></asp:BoundColumn>
                                </Columns>
                                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" Mode="NumericPages" />
                            </asp:DataGrid>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div id="divTabFld4Sel" style="width: 184px; position: relative; height: 22px">
                                <asp:Label ID="Label5" runat="server" Font-Names="宋体" Font-Size="Smaller" 
                                    Style="z-index: 101; left: 0px; position: absolute; top: 0px" Width="56px">记录数：</asp:Label>
                                <asp:TextBox ID="txtRecCount_PrjTabFld" runat="server" CssClass="TextBox_Defa" Font-Names="宋体"
                                    Font-Size="Smaller" ReadOnly="True" Style="z-index: 102; left: 64px; position: absolute;
                                    top: 0px" ></asp:TextBox>
                                <asp:CheckBox ID="chkSelAll" runat="server" AutoPostBack="True" CssClass="text-secondary"
                                    OnCheckedChanged="chkSelAll_CheckedChanged" Style="z-index: 103; left: 120px;
                                    position: absolute; top: 0px" Text="全选" />
                            </div>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
