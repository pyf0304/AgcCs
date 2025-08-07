<%@ Page Title="生成Win界面代码--NEW" Language="C#" MasterPageFile="~/Webform/MasterPage/mpViewEdit.Master" CodeBehind="wfmDesignView4WinV5_New.aspx.cs" ValidateRequest="false"
    AutoEventWireup="True" Inherits="AGC.Webform.wfmDesignView4WinV5_New" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <script src="../../js/tzPubFun.js"></script>
    
    <script>
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
    <table id="Table3" style="z-index: 103; left: 4px; width: 100%; top: 75px;"
        cellspacing="0" cellpadding="0">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" CssClass="h6" 
                    Text="请选择界面类型:"></asp:Label>
            </td>
            <td colspan="3">
                <asp:Menu ID="Menu1" runat="server" OnMenuItemClick="Menu1_MenuItemClick" Orientation="Horizontal"
                    Width="525px" Style="z-index: 100; " CssClass="TMenu" Font-Size="13px">
                    <Items>
                        <asp:MenuItem Text="单表的QUDI_LV" Value="0"></asp:MenuItem>
                        <asp:MenuItem Text="单表组合界面_ListView" Value="1"></asp:MenuItem>
                        <asp:MenuItem Text="单表组合界面_GridView" Value="2"></asp:MenuItem>
                        <asp:MenuItem Text="单表插入" Value="3"></asp:MenuItem>
                        <asp:MenuItem Text="单表查询" Value="4"></asp:MenuItem>
                    </Items>
                </asp:Menu>
            </td>
            <td>
                <asp:CheckBox ID="chkIsUseCtrl" runat="server" CssClass="NormalContral" Text="在界面中是否使用控件"
                     ></asp:CheckBox>

            </td>
        </tr>
        <tr>
            <td colspan="5" style="height: 5px">
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                        <asp:Button ID="btnGenViewCode01" runat="server"  OnClick="btnGenCode_Click"
                            Text="生成界面代码" Width="110px" CommandArgument="0006" />
                        <asp:Button ID="Button2" runat="server"  OnClick="btnGenCode_Click"
                            Text="生成界面设计代码" Width="135px"  CommandArgument="0018" />
                        <asp:Button ID="Button3" runat="server"  OnClick="btnGenCode_Click"
                            Text="生成子界面代码" Width="110px"  CommandArgument="0016" />
                        <asp:Button ID="Button4" runat="server"  OnClick="btnGenCode_Click"
                            Text="生成子界面设计代码" Width="135px"  CommandArgument="0019" />
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <asp:Button ID="btnGenViewCode02" runat="server"  OnClick="btnGenCode_Click"
                            Text="生成界面代码" Width="110px" CommandArgument="0006"  />
                        <asp:Button ID="btnGenViewDesignCode02" runat="server"  OnClick="btnGenCode_Click"
                            Text="生成界面设计代码" Width="135px"  CommandArgument="0018" />
                        <asp:Button ID="btnGenViewCode02_Sub" runat="server"  OnClick="btnGenCode_Click"
                            Text="生成子界面代码" Width="110px"  CommandArgument="0016" />
                        <asp:Button ID="btnGenViewDesignCode02_Sub" runat="server"  OnClick="btnGenCode_Click"
                            Text="生成子界面设计代码" Width="135px"  CommandArgument="0019" />
                    </asp:View>
                    <asp:View ID="View3" runat="server">
                        <asp:Button ID="btnGenViewCode03" runat="server"  OnClick="btnGenCode_Click"
                            Text="生成界面代码" Width="110px"  CommandArgument="0168" />
                        <asp:Button ID="btnGenViewDesignCode03" runat="server"  OnClick="btnGenCode_Click"
                            Text="生成界面设计代码" Width="135px"  CommandArgument="0169" />
                        <asp:Button ID="btnGenViewCode03_Sub" runat="server"  OnClick="btnGenCode_Click"
                            Text="生成子界面代码" Width="110px"  CommandArgument="0016" />
                        <asp:Button ID="btnGenViewDesignCode03_Sub" runat="server"  OnClick="btnGenCode_Click"
                            Text="生成子界面设计代码" Width="135px"  CommandArgument="0019" />
                    </asp:View>
                    <asp:View ID="View4" runat="server">
                        <asp:Button ID="btnGenViewCode04" runat="server"  OnClick="btnGenCode_Click"
                            Text="生成界面代码" Width="110px" CommandArgument="0006" />
                        <asp:Button ID="Button14" runat="server" 
                            Style="left: -86px; top: 117px" Text="生成表控件代码" Width="103px" />
                        <asp:Button ID="Button15"
                                runat="server"  OnClick="btnGenCode_Click" Style="left: -86px; top: 117px"
                                Text="生成表查询控件" Width="109px" CommandArgument="0006" />
                        <asp:Button ID="Button1" runat="server"  OnClick="btnGenCode_Click"
                            Text="专用于显示的表控件" Visible="False" Width="135px" CommandArgument="0006" />
                    </asp:View>
                    <asp:View ID="View5" runat="server">
                        <asp:Button ID="btnGenViewCode05" runat="server"  OnClick="btnGenCode_Click"
                            Text="生成界面代码" Width="110px" CommandArgument="0006" />
                        <asp:Button ID="Button21" runat="server" 
                            Style="left: -86px; top: 117px" Text="生成表控件代码" Width="103px" />
                        <asp:Button ID="Button22"
                            runat="server"  OnClick="btnGenCode_Click" Style="left: -86px; top: 117px"
                            Text="生成表查询控件" Width="109px" CommandArgument="0006" />
                        <asp:Button ID="Button16" runat="server"  OnClick="btnGenCode_Click"
                            Text="专用于显示的表控件" Visible="False" Width="135px" CommandArgument="0006" />
                    </asp:View>
                </asp:MultiView></td>
        </tr>
        <tr>
            <td colspan="5" style="height: 5px">
                <img alt="" height="5" src="../../pic/bar1.JPG" style="width: 769px;" /></td>
        </tr>
        <tr>
            <td style="width: 190px" colspan="6" rowspan="1">
                <table style="width: 626px">
                    <tr>
                        <td>
                            <asp:Label ID="lblMsg2" runat="server"  
                                Width="144px"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <table style="width: 199px">
                                <tr>
                                    <td style="width: 410px">
                                        <asp:DropDownList ID="ddlFuncList" runat="server" Width="196px">
                                        </asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td style="width: 410px">
                                        <asp:Button ID="btnGenFunc" runat="server" Width="135px"  Text="生成函数"
                                            OnClick="btnGenFunc_Click"></asp:Button></td>
                                </tr>
                                <tr>
                                    <td style="width: 410px">
                                        <img alt="" height="3" src="../../pic/bar1.JPG" style="width: 200px; height: 3px" /></td>
                                </tr>
                                <tr>
                                    <td style="width: 410px"></td>
                                </tr>
                                <tr>
                                    <td style="width: 410px">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="width: 410px; height: 26px;"></td>
                                </tr>
                            </table>
                        </td>
                        <td style="width: 4px">

                            <table id="tabCode" style="width: 616px; height: 551px" cellspacing="1" cellpadding="1"
                                width="816" border="1" runat="server">
                                <tr>
                                    <td colspan="2" style="width: 812px">
                                        <div style="width: 624px; height: 32px; position: relative;">
                                            <asp:Label ID="Label5" Style="z-index: 103; left: 98px; position: absolute; top: 2px"
                                                runat="server" Width="50px" >文件名</asp:Label>
                                            <asp:TextBox ID="txtFileName4GenCode" Style="z-index: 104; left: 147px; position: absolute; top: 1px"
                                                runat="server" Width="316px"></asp:TextBox>
                                            <asp:LinkButton ID="lbDownLoadFile" Style="z-index: 111; left: 486px; position: absolute; top: 4px"
                                                runat="server" Width="65px">下载文件</asp:LinkButton>
                                            <asp:Label ID="lblCaption4GenCode" runat="server" Width="96px"  Font-Names="宋体"
                                                CssClass="h6">生成的代码：</asp:Label>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" style="width: 812px">

                                          <asp:Literal ID="litCode" runat="server"></asp:Literal>

                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>


