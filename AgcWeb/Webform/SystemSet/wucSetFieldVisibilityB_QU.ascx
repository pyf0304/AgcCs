<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucSetFieldVisibilityB_QU.ascx.cs" Inherits="AGC.Webform.wucSetFieldVisibilityB_QU" %>



<div id="divSetFieldVisibility" class="tab_layout" runat="server">
    <%-- 标题层 --%>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >设置字段可视性维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query" style="visibility: collapse">
                <table class="msgtable" style="width: 64%;">
                    <tr>


                        <td class="auto-style2">
                            <asp:DropDownList ID="ddlUserIdq" 
                                runat="server" CssClass="TextBox_Defa" Enabled="False" Width="1px">
                            </asp:DropDownList>
                        </td>

                        <td class="auto-style2" style="text-align:right">
                            <asp:Label ID="lblViewNameq" 
                                runat="server" CssClass="text-secondary">界面名称</asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtViewNameq" 
                                runat="server" CssClass="TextBox_Defa" Enabled="False" Width="100px"></asp:TextBox>
                        </td>

                        <td class="auto-style2" style="text-align:right">
                            <asp:Label ID="lblFieldNameq" 
                                runat="server" CssClass="text-secondary">字段名</asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtFieldNameq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>


                        <td class="auto-style2">

                            <asp:Button ID="btnQuery"
                                Style="z-index: 116; Width: 80px; "
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>

                        <td class="auto-style2">&nbsp;</td>


                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>

            <div id="divList" class="div_List" runat="server">
                <table id="tabGridFunction" style="width: 64%; height: 32px" class="msgtable">
                    <tr>
                        <td>
                            <asp:Label ID="lblSetFieldVisibilityList" runat="server" 
                                CssClass="h6" Width="250px">设置字段可视性列表</asp:Label>
                        </td>

                        <td>

                            <asp:Button ID="btnRefreshFldList4GridView"
                                Style="z-index: 116;"
                                runat="server"
                                Text="刷新字段列表" CssClass="btn btn-outline-info btn-sm"
                                OnClick="btnRefreshFldList4GridView_Click" Width="90px"></asp:Button>
                        </td>

                        <td>
                            <asp:Button ID="btnSetIsVisible" runat="server" 
                                Text="设置可见" OnClick="btnSetIsVisible_Click" />
                        </td>
                        <td>
                            <asp:Button ID="btnSetIsNotVisible" runat="server"
                                 Text="设置不可见" OnClick="btnSetIsNotVisible_Click" />
                        </td>

                        <td>
                            <asp:Button ID="btnSubmitSet" runat="server"
                                 Text="确定设置" OnClick="btnSubmitSet_Click" />
                        </td>
                        <td class="auto-style1">
                            <input id="btnCloseDiv2" type="button" value="关闭" onclick="Tz_HideDiv('divSetFieldVisibilityB_QU');" /></td>
                    </tr>
                </table>
                <asp:GridView ID="gvSetFieldVisibility" Style="z-index: 117;" runat="server"
                    Width="64%" AutoGenerateColumns="False"
                    PageSize="10" AllowPaging="true"
                    AllowSorting="true"
                    OnSorting="gvSetFieldVisibility_Sorting"
                    OnPageIndexChanging="gvSetFieldVisibility_PageIndexChanging"
                    OnRowCreated="gvSetFieldVisibility_RowCreated"
                    OnRowCommand="gvSetFieldVisibility_RowCommand"
                    BackColor="White"
                    BorderColor="#E7E7FF"
                    BorderStyle="None"
                    BorderWidth="1px"
                    CellPadding="3"
                    GridLines="Horizontal"
                    Height="1px"
                    DataKeyNames="mId"
                    CssClass="table table-striped table-bordered table-condensed">
                    <Columns>
                        <asp:TemplateField HeaderText="全选">
                            <HeaderStyle Width="35px" />
                            <HeaderTemplate>
                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="DgSelAll2">全选</asp:LinkButton>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="mId" SortExpression="mId" HeaderText="mId" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="UserId" SortExpression="UserId" HeaderText="用户ID" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="SchoolId" SortExpression="SchoolId" HeaderText="学校Id" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="SchoolName" SortExpression="SchoolName" HeaderText="学校名称" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="ViewName" SortExpression="ViewName" HeaderText="界面名称" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="CtrlType" SortExpression="CtrlType" HeaderText="控件类型" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="FieldName" SortExpression="FieldName" HeaderText="字段名"></asp:BoundField>
                        <asp:BoundField DataField="Caption" SortExpression="Caption" HeaderText="标题"></asp:BoundField>
                        <asp:BoundField DataField="IsVisible" SortExpression="IsVisible" HeaderText="是否显示"></asp:BoundField>
                        <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
                        <asp:BoundField DataField="UpdUserId" SortExpression="UpdUserId" HeaderText="修改用户Id" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明" Visible="false"></asp:BoundField>

                    </Columns>
                    <PagerTemplate>
                        <span class="text-secondary">共有记录:</span>
                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="46px">0</asp:Label>
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
                            Width="55px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                            <asp:ListItem>30</asp:ListItem>
                            <asp:ListItem>50</asp:ListItem>
                            <asp:ListItem>100</asp:ListItem>
                            <asp:ListItem>1000</asp:ListItem>
                        </asp:DropDownList>
                        <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                            ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                    </PagerTemplate>
                    <FooterStyle CssClass="FooterStyle" />
                    <RowStyle CssClass="RowStyle" />
                    <EmptyDataRowStyle CssClass="EmptyDataRowStyle" />
                    <SelectedRowStyle CssClass="SelectedRowStyle" />
                    <PagerStyle CssClass="PagerStyle" />
                    <HeaderStyle CssClass="HeaderStyle" />
                    <EditRowStyle CssClass="EditRowStyle" />
                    <AlternatingRowStyle CssClass="AlternatingRowStyle" />
                </asp:GridView>
            </div>

        </ContentTemplate>

    </asp:UpdatePanel>
</div>
