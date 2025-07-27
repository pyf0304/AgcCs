<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucFieldTabBak20170705.ascx.cs"
    Inherits="AGC.Webform.wucFieldTabBak20170705" %>
<link href="../css/taishweb2.css" rel="stylesheet" type="text/css" />
<table id="tabwucFieldTab" style="width: 828px" cellspacing="1" cellpadding="1" border="0">
    <tr>
        <td colspan="6">
            <asp:Label ID="Label4" runat="server" CssClass="RegionTitleH2" Width="160px">字段基本信息:</asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="6" style="height: 5px">
            <img style="width: 600px; height: 3px" height="3" alt="" src="../../pic/兰色直线1.gif"
                width="768">
        </td>
    </tr>
    <tr>
        <td>
            <table style="width: 685px">
                <tr>
                    <td style="width: 65px">
                        <asp:Label ID="lblFldName" runat="server" CssClass="text-secondary"
                           >字段名称</asp:Label>
                    </td>
                    <td style="width: 143px">
                        <asp:TextBox ID="txtFldName" runat="server" Width="280px"></asp:TextBox>
                    </td>
                    <td style="width: 57px">
                        <asp:Label ID="lblFldStateId" runat="server" CssClass="text-secondary">字段状态</asp:Label>
                    </td>
                    <td style="width: 78px">

                        <asp:DropDownList ID="ddlFldStateId" Width="144px" runat="server">
                        </asp:DropDownList>

                    </td>

                </tr>
                <tr>
                    <td style="width: 65px">
                        <asp:Label ID="lblCaption" runat="server" CssClass="text-secondary">标题名称</asp:Label>
                    </td>
                    <td style="width: 143px">
                        <asp:TextBox ID="txtCaption" runat="server" Width="280px"></asp:TextBox>
                    </td>
                    <td style="width: 157px" colspan="2">
                        <div style="width: 288px; position: relative; height: 20px">
                            <asp:CheckBox ID="chkIsPrimaryKey" runat="server" Text="是否主键" Style="z-index: 101; left: 0px; position: absolute; top: 0px"
                                CssClass="text-secondary"></asp:CheckBox>
                            <asp:CheckBox ID="chkIsIdentity" Style="z-index: 102; left: 76px; position: absolute; top: 0px"
                                runat="server" Text="是否Identity" CssClass="text-secondary"></asp:CheckBox>
                            <asp:CheckBox ID="chkIsNationStandard" runat="server" Text="是否国标" Style="z-index: 103; left: 190px; position: absolute; top: 0px"
                                CssClass="text-secondary"></asp:CheckBox>
                        </div>
                    </td>

                </tr>
                <tr>
                    <td style="width: 65px">
                        
                            <asp:Label ID="Label7" runat="server"  CssClass="text-secondary">后备名称</asp:Label></font>
                    </td>
                    <td style="width: 143px">
                        <asp:TextBox ID="txtFldName_B" Width="280px" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td style="width: 157px">
                        <asp:Label ID="Label6" runat="server" CssClass="text-secondary">国标名称</asp:Label>
                    </td>
                    <td style="width: 58px">
                        <asp:TextBox ID="txtFldName_G" Width="250px" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label5" runat="server" Width="132px" CssClass="RegionTitleH2">字段类型信息:</asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="字段长度不能为空!"
                ControlToValidate="txtFldLength" CssClass="text-warning" Width="159px"></asp:RequiredFieldValidator><font
                    face="宋体"></font>
        </td>
    </tr>
    <tr>
        <td colspan="6">
            
                <img style="width: 600px; height: 3px" height="3" alt="" src="../../pic/兰色直线1.gif"
                    width="768"></font>
        </td>
    </tr>
    <tr>
        <td>
            <table style="width: 810px">
                <tr>
                    <td style="width: 65px">
                        <asp:Label ID="lblFldType" runat="server" CssClass="text-secondary">字段类型</asp:Label>
                    </td>
                    <td style="width: 127px">
                        <asp:DropDownList ID="ddlFldType" runat="server" Width="150px">
                        </asp:DropDownList>
                    </td>
                    <td style="width: 77px">
                        <asp:Label ID="lblFldLength" runat="server" CssClass="text-secondary">字段长度</asp:Label>
                    </td>
                    <td style="width: 68px">
                        <asp:TextBox ID="txtFldLength" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td style="width: 58px">
                        <asp:Label ID="lblMaxValue0" runat="server" CssClass="text-secondary" Width="70px">小数位数</asp:Label>
                    </td>
                    <td style="width: 98px">
                        <asp:TextBox ID="txtFldPrecision" runat="server" ></asp:TextBox>
                    </td>
                    <td style="width: 98px">&nbsp;</td>
                    <td style="width: 98px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 65px">
                        <asp:Label ID="lblIsNull" runat="server" CssClass="text-secondary">是否可空</asp:Label>
                    </td>
                    <td style="width: 127px">
                        <asp:DropDownList ID="ddlIsNull" runat="server" Width="150px">
                        </asp:DropDownList>
                    </td>
                    <td style="width: 77px">
                        <asp:Label ID="lblDefaultValue" runat="server" CssClass="text-secondary">缺省值</asp:Label>
                    </td>
                    <td style="width: 68px">
                        <asp:TextBox ID="txtDefaultValue" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td style="width: 58px">
                        <asp:Label ID="lblMinValue" runat="server" CssClass="text-secondary">最小值</asp:Label>
                    </td>
                    <td style="width: 98px">
                        <asp:TextBox ID="txtMinValue" runat="server" ></asp:TextBox>
                    </td>
                    <td style="width: 98px">
                        <asp:Label ID="lblMaxValue" runat="server" CssClass="text-secondary">最大值</asp:Label>
                    </td>
                    <td style="width: 98px">
                        <asp:TextBox ID="txtMaxValue" runat="server" ></asp:TextBox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" CssClass="RegionTitleH2">相关对象:</asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="6">
            <img style="width: 600px; height: 3px" height="3" alt="" src="../../pic/兰色直线1.gif"
                width="680">
        </td>
    </tr>
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div style="width: 747px; position: relative; height: 140px; left: 11px; top: 8px;">
                        <asp:Label ID="Label8" Style="z-index: 102; left: 8px; position: absolute; top: 0px"
                            runat="server" CssClass="text-secondary">源对象列表</asp:Label>
                        <asp:ListBox ID="lstObjList" Style="z-index: 103; left: 304px; position: absolute; top: 16px"
                            Width="209" runat="server" Height="104" SelectionMode="Multiple"></asp:ListBox>
                        <asp:Label ID="Label9" Style="z-index: 104; left: 304px; position: absolute; top: 0px"
                            runat="server" CssClass="text-secondary">所选对象列表</asp:Label>
                        <asp:LinkButton ID="lbAddObject" Style="z-index: 105; left: 248px; position: absolute; top: 40px; height: 16px;"
                            runat="server" OnClick="lbAddObject_Click">>></asp:LinkButton>
                        <asp:LinkButton ID="lbDelObject" Style="z-index: 106; left: 248px; position: absolute; top: 72px"
                            runat="server" OnClick="lbDelObject_Click"><<</asp:LinkButton>
                        <asp:ListBox ID="lstSouObjList" Style="z-index: 107; left: 8px; position: absolute; top: 16px"
                            Width="209px" runat="server" Height="104"></asp:ListBox>
                        <asp:LinkButton ID="lbEditTab" OnClick="lbEditTab_Click" Style="z-index: 107; left: 534px; position: absolute; top: 18px"
                            runat="server">编辑所选对象</asp:LinkButton>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td>
            
                <asp:Label ID="Label2"  runat="server" CssClass="RegionTitleH2">代码转换:</asp:Label></font>
        </td>
    </tr>
    <tr>
        <td colspan="6">
            
                <img style="width: 600px; height: 3px" height="3" alt="" src="../../pic/兰色直线1.gif"
                    width="768"></font>
        </td>
    </tr>
    <tr>
        <td>
            <asp:UpdatePanel ID="FieldTabUpdatePanel" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <table>
                        <tr>
                            <td colspan="2">
                                <asp:CheckBox ID="chkIsNeedTransCode" runat="server" Width="244px" Text="是否需要代码转名称"
                                    AutoPostBack="True" CssClass="text-secondary" OnCheckedChanged="chkIsNeedTransCode_CheckedChanged"></asp:CheckBox>
                            </td>
                            <td>
                                <asp:Label ID="lblCodeTab" runat="server"  CssClass="text-secondary">代码表</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlCodeTab" runat="server" Width="300px" AutoPostBack="True"
                                    Visible="False" 
                                    OnSelectedIndexChanged="ddlCodeTab_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblCodeTabCode" runat="server" 
                                    CssClass="text-secondary">代码字段</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlCodeTabCode" runat="server" Width="280px"
                                    Visible="False" >
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="lblCodeTabName" runat="server" 
                                    CssClass="text-secondary" Width="70px">名称字段</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlCodeTabName" runat="server" Width="280px"
                                    Visible="False" Style="z-index: 103;">
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
            &nbsp; &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" CssClass="RegionTitleH2">字段说明:</asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            
                <img style="width: 574px; height: 3px" height="3" alt="" src="../../pic/兰色直线1.gif"></font>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtFldInfo" runat="server" Width="575px" Height="80px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtUserId" runat="server" Width="49px" Visible="False"></asp:TextBox>
            <asp:TextBox ID="txtUpdDate" runat="server" Width="56px" Visible="False"></asp:TextBox>
            <asp:CompareValidator ID="ComValid_FldLength" runat="server" Width="160px" EnableClientScript="False"
                Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtFldLength" ErrorMessage="请输入整型数值!"
                CssClass="text-warning"></asp:CompareValidator>&nbsp;
        </td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="0" runat="server">
    <tr>
        <td>
            <asp:Label ID="lblPrjId" runat="server" CssClass="text-secondary">工程ID</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlPrjId" runat="server" Width="150px">
            </asp:DropDownList>
        </td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblAppliedScope" runat="server" CssClass="text-secondary">适用范围</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtAppliedScope" runat="server" Width="150px"></asp:TextBox>
        </td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblFldID" runat="server" CssClass="text-secondary">字段ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFldID" Width="96px" runat="server"></asp:TextBox>
        </td>
        <td></td>
    </tr>
</table>
