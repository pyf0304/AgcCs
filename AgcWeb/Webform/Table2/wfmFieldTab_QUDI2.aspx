<%@ Page Title="" Language="C#" MasterPageFile="~/Webform/Table2/EditTable.master"
    AutoEventWireup="True" CodeBehind="wfmFieldTab_QUDI2.aspx.cs" Inherits="AGC.Webform.wfmFieldTab_QUDI2" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<%@ Register TagPrefix="uc4" TagName="wucFieldTab" Src="~/Webform/Field/wucFieldTab.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>表字段综合维护</title>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <table style="width: 572px">
        <tr>
            <td>
                <table id="tabGridView" style="width: 100%;">
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" CssClass="h6"  >工程字段列表</asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 103;"
                                Width="157px"></asp:Label>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbCopyField" runat="server" CssClass="LinkButton_Defa" OnClick="lbCopyField_Click"
                                >复制</asp:LinkButton>
                            &nbsp;
                        </td>
                        <td>
                            <asp:LinkButton ID="lbUpdate" runat="server" CssClass="LinkButton_Defa" OnClick="lbUpdate_Click"
                                >修改</asp:LinkButton>
                            &nbsp;
                        </td>
                        <td>
                            <asp:LinkButton ID="lbDelFld" runat="server" CssClass="LinkButton_Defa" OnClick="lbDelFld_Click"
                                Style="z-index: 103;">删除</asp:LinkButton>
                            &nbsp;
                        </td>
                        <td>
                            <asp:LinkButton ID="lbAddToObj" runat="server" CssClass="LinkButton_Defa" OnClick="lbAddToObj_Click"
                                Style="z-index: 103;">添加到表</asp:LinkButton>
                            &nbsp;
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTabId_AddTo" runat="server" Style="z-index: 107; height: 20px;
                                width: 240px;" TabIndex="105"  Width="207px">
                            </asp:DropDownList>
                            &nbsp;
                        </td>
                        <td>
                            <asp:LinkButton ID="lbDelFieldTabEx" runat="server" CssClass="LinkButton_Defa" OnClick="lbDelFieldTabEx_Click"
                                 Visible="False">扩展删除</asp:LinkButton>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbCheckField" runat="server" CssClass="LinkButton_Defa" OnClick="lbCheckField_Click"
                                >检查字段</asp:LinkButton>
                        </td>
                        <td>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:GridView ID="gvFieldTab" runat="server" AllowPaging="True" AllowSorting="True"
                            AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
                            BorderWidth="1px" CellPadding="2" CssClass="table table-striped table-bordered table-condensed" DataKeyNames="FldId" GridLines="Horizontal"
                            Height="1px" OnPageIndexChanging="gvFieldTab_PageIndexChanging" OnRowCommand="gvFieldTab_RowCommand"
                            OnRowCreated="gvFieldTab_RowCreated" OnRowDeleting="gvFieldTab_RowDeleting" OnRowUpdating="gvFieldTab_RowUpdating"
                            OnSorting="gvFieldTab_Sorting" Style="z-index: 175; position: relative" Width="849px">
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
                                <asp:CheckBoxField DataField="IsNull" HeaderText="可空" />
                                <asp:CheckBoxField DataField="IsPrimaryKey" HeaderText="主键" SortExpression="IsPrimaryKey" />
                                <asp:BoundField DataField="IsNationStandard" HeaderText="国标" Visible="False" />
                                <asp:BoundField DataField="MaxValue" HeaderText="最大值" Visible="False" />
                                <asp:BoundField DataField="MinValue" HeaderText="最小值" Visible="False" />
                                <asp:BoundField DataField="DefaultValue" HeaderText="缺省值" Visible="False" />
                                <asp:BoundField DataField="CodeTab" HeaderText="代码表" />
                                <asp:BoundField DataField="CodeTabName" HeaderText="名称字段" Visible="False" />
                                <asp:BoundField DataField="CodeTabCode" HeaderText="代码字段" Visible="False" />
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
                            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                            <AlternatingRowStyle BackColor="#F7F7F7" />
                        </asp:GridView>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="lbInsNewRec" EventName="Click" />
                        <asp:AsyncPostBackTrigger ControlID="lbDelFld" EventName="Click" />
                    </Triggers>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td style="height: 21px">
                <div style="width: 857px; position: relative; height: 24px">
                    <asp:TextBox ID="txtFldName" runat="server" Style="z-index: 101; left: 32px; position: absolute;
                        top: 0px" TabIndex="100" Width="144px"></asp:TextBox>
                        <ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" ServiceMethod="GetCompleteList"
                                                ServicePath="~/WebService/WS_FieldName.asmx" Enabled="true" MinimumPrefixLength="2"
                                                CompletionSetCount="10" TargetControlID="txtFldName">
                                            </ajaxToolkit:AutoCompleteExtender>
                    <asp:DropDownList ID="ddlFldType" runat="server" Style="z-index: 102; left: 280px;
                        position: absolute; top: 0px" TabIndex="102" >
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlIsNull" runat="server" Style="z-index: 103; left: 448px;
                        position: absolute; top: 0px" TabIndex="104" Width="46px">
                    </asp:DropDownList>
                    <asp:TextBox ID="txtFldLength" runat="server" Style="z-index: 104; left: 360px; position: absolute;
                        top: 0px" TabIndex="103" ></asp:TextBox>
                    &nbsp;
                    <asp:TextBox ID="txtCaption" runat="server" Style="z-index: 106; left: 176px; position: absolute;
                        top: 0px" TabIndex="101" Width="100px"></asp:TextBox>
                    <asp:DropDownList ID="ddlIsPrimaryKey" runat="server" Style="z-index: 107; left: 496px;
                        position: absolute; top: 0px" TabIndex="105" Width="54px">
                    </asp:DropDownList>
                    &nbsp;
                    <asp:LinkButton ID="lbInsNewRec" runat="server" OnClick="lbInsNewRec_Click" Style="z-index: 109;
                        left: 784px; position: absolute; top: 8px" TabIndex="107" Width="72px">插入新记录</asp:LinkButton>
                </div>
                &nbsp;&nbsp;
                <asp:Label ID="lblMsg4AddRecord" runat="server" CssClass="text-warning" Width="360px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFldLength"
                    CssClass="text-warning" ErrorMessage="字段长度不能为空!" Enabled="false"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtFldLength"
                    CssClass="text-warning" ErrorMessage="请输入整型值" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
    </table>
    </td> </tr>
    <tr>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <table id="tabEditTabField" runat="server" border="0" cellpadding="0" cellspacing="0"
                style="border-left-color: #666666; border-bottom-color: #666666; width: 480px;
                border-top-color: #666666; height: 200px; border-right-color: #666666" width="480">
                <tr>
                    <td style="height: 19px" valign="top">
                        <div style="width: 848px; position: relative; height: 27px">
                            <asp:LinkButton ID="lbDispFieldList" runat="server" OnClick="lbDispFieldList_Click"
                                Style="z-index: 101; left: 760px; position: absolute; top: 8px" Width="83px">显示字段列表</asp:LinkButton>
                            <asp:Button ID="btnOKUpdFieldTab" runat="server"  OnClick="btnOKUpdFieldTab_Click"
                                Style="z-index: 102; left: 672px; position: absolute; top: 3px" Text="添加"  />
                            <asp:Label ID="lblMsg" runat="server" CssClass="text-warning" Style="z-index: 103;
                                left: 432px; position: absolute; top: 7px" Width="232px"></asp:Label>
                            <asp:Label ID="Label9" runat="server" BorderColor="#004040" CssClass="h6"
                                Style="z-index: 104; left: 0px; position: absolute; top: 7px">工程字段属性</asp:Label>
                        </div>
                    </td>
                    <td style="height: 19px" valign="top">
                    </td>
                </tr>
                <tr>
                    <td colspan="2" valign="top">
                        <uc4:wucFieldTab ID="wucFieldTab1" runat="server"></uc4:wucFieldTab>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    </table>
</asp:Content>
