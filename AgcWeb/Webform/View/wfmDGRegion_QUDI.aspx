<%@ Register TagPrefix="uc1" TagName="wucDGRegion" Src="wucDGRegion.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmDGRegion_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmDGRegion_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表DGRegion的查询、修改、删除、添加记录</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <table id="tabTitle" style="z-index: 102; left: 8px; position: absolute; top: 8px;
            background-color: #ff6666" cellspacing="1" cellpadding="1" width="100%" border="0">
            <tr>
                <td style="background-color:#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White"
                        Font-Bold="True">DGRegion表的查询、修改、删除、添加</asp:Label>
                </td>
            </tr>
        </table>
        <div id="divDGRegion" style="z-index: 119; left: 8px; width: 256px; position: absolute;
            top: 35px; height: 740px" runat="server">
            <asp:Label ID="lblRegionId_q" Style="z-index: 104; left: 10px; position: absolute;
                top: 5px" runat="server" Width="70px" >
  区域Id</asp:Label>
            <asp:TextBox ID="txtRegionId_q" Style="z-index: 105; left: 85px; position: absolute;
                top: 5px" runat="server" Width="70px" ></asp:TextBox>
            <asp:Label ID="lblViewDgName_q" Style="z-index: 107; left: 10px; position: absolute;
                top: 33px" runat="server" Width="70px" >
  界面Dg名称</asp:Label>
            <asp:TextBox ID="txtViewDgName_q" Style="z-index: 108; left: 85px; position: absolute;
                top: 33px" runat="server" Width="70px" ></asp:TextBox>
            <asp:Label ID="lblDGStyleId_q" Style="z-index: 110; left: 10px; position: absolute;
                top: 61px" runat="server" Width="70px" >
  DG模式ID</asp:Label>
            <asp:DropDownList ID="ddlDGStyleId_q" Style="z-index: 111; left: 85px; position: absolute;
                top: 61px" runat="server" Width="70px" >
            </asp:DropDownList>
            <asp:Label ID="lblRunat_q" Style="z-index: 113; left: 10px; position: absolute; top: 89px"
                runat="server" Width="70px" >
  运行在</asp:Label>
            <asp:TextBox ID="txtRunat_q" Style="z-index: 114; left: 85px; position: absolute;
                top: 89px" runat="server" Width="70px" ></asp:TextBox>
            <asp:Label ID="lblFontSize_q" Style="z-index: 116; left: 10px; position: absolute;
                top: 117px" runat="server" Width="70px" >
  字号</asp:Label>
            <asp:TextBox ID="txtFontSize_q" Style="z-index: 117; left: 85px; position: absolute;
                top: 117px" runat="server" Width="70px" ></asp:TextBox>
            <asp:Label ID="lblFontName_q" Style="z-index: 119; left: 10px; position: absolute;
                top: 145px" runat="server" Width="70px" >
  字体</asp:Label>
            <asp:TextBox ID="txtFontName_q" Style="z-index: 120; left: 85px; position: absolute;
                top: 145px" runat="server" Width="70px" ></asp:TextBox>
            <asp:CheckBox ID="chkAllowPaging_q" Style="z-index: 122; left: 10px; position: absolute;
                top: 173px" runat="server" Width="100px"  Text="允许分页"></asp:CheckBox>
            <asp:Label ID="lblPageSize_q" Style="z-index: 124; left: 10px; position: absolute;
                top: 201px" runat="server" Width="70px" >
  页大小</asp:Label>
            <asp:TextBox ID="txtPageSize_q" Style="z-index: 125; left: 85px; position: absolute;
                top: 201px" runat="server" Width="70px" ></asp:TextBox>
            <asp:CheckBox ID="chkAutoGenerateColumns_q" Style="z-index: 127; left: 10px; position: absolute;
                top: 229px" runat="server" Width="100px"  Text="自动生成列"></asp:CheckBox>
            <asp:CheckBox ID="chkAllowSorting_q" Style="z-index: 129; left: 10px; position: absolute;
                top: 257px" runat="server" Width="100px"  Text="允许排序"></asp:CheckBox>
            <asp:CheckBox ID="chkIsRadio_q" Style="z-index: 131; left: 10px; position: absolute;
                top: 285px" runat="server" Width="100px"  Text="是否单选框"></asp:CheckBox>
            <asp:CheckBox ID="chkIsCheck_q" Style="z-index: 133; left: 10px; position: absolute;
                top: 313px" runat="server" Width="100px"  Text="是否复选框"></asp:CheckBox>
            <asp:CheckBox ID="chkIsJumpPage_q" Style="z-index: 135; left: 10px; position: absolute;
                top: 341px" runat="server" Width="100px"  Text="是否跳页"></asp:CheckBox>
            <asp:CheckBox ID="chkIsHaveUpdBtn_q" Style="z-index: 137; left: 10px; position: absolute;
                top: 369px" runat="server" Width="100px"  Text="是否有修改按钮"></asp:CheckBox>
            <asp:CheckBox ID="chkIsHaveDelBtn_q" Style="z-index: 139; left: 10px; position: absolute;
                top: 397px" runat="server" Width="100px"  Text="是否有删除按钮"></asp:CheckBox>
            <asp:CheckBox ID="chkIsHaveDetailBtn_q" Style="z-index: 141; left: 10px; position: absolute;
                top: 425px" runat="server" Width="100px"  Text="是否有详细按钮"></asp:CheckBox>
            <asp:CheckBox ID="chkIsInTab_q" Style="z-index: 143; left: 10px; position: absolute;
                top: 453px" runat="server" Width="100px"  Text="是否生成DG在表中"></asp:CheckBox>
            <asp:Label ID="lblStyle_Zindex_q" Style="z-index: 145; left: 10px; position: absolute;
                top: 481px" runat="server" Width="70px" >
  Style_Zindex</asp:Label>
            <asp:TextBox ID="txtStyle_Zindex_q" Style="z-index: 146; left: 85px; position: absolute;
                top: 481px" runat="server" Width="70px" ></asp:TextBox>
            <asp:Label ID="lblStyle_Left_q" Style="z-index: 148; left: 10px; position: absolute;
                top: 509px" runat="server" Width="70px" >
  Style_Left</asp:Label>
            <asp:TextBox ID="txtStyle_Left_q" Style="z-index: 149; left: 85px; position: absolute;
                top: 509px" runat="server" Width="70px" ></asp:TextBox>
            <asp:Label ID="lblStyle_Position_q" Style="z-index: 151; left: 10px; position: absolute;
                top: 537px" runat="server" Width="70px" >
  Style_Position</asp:Label>
            <asp:TextBox ID="txtStyle_Position_q" Style="z-index: 152; left: 85px; position: absolute;
                top: 537px" runat="server" Width="70px" ></asp:TextBox>
            <asp:Label ID="lblStyle_Top_q" Style="z-index: 154; left: 10px; position: absolute;
                top: 565px" runat="server" Width="70px" >
  Style_Top</asp:Label>
            <asp:TextBox ID="txtStyle_Top_q" Style="z-index: 155; left: 85px; position: absolute;
                top: 565px" runat="server" Width="70px" ></asp:TextBox>
            <asp:Label ID="lblWidth_q" Style="z-index: 157; left: 10px; position: absolute; top: 593px"
                runat="server" Width="70px" >
  宽</asp:Label>
            <asp:TextBox ID="txtWidth_q" Style="z-index: 158; left: 85px; position: absolute;
                top: 593px" runat="server" Width="70px" ></asp:TextBox>
            <asp:Label ID="lblHeight_q" Style="z-index: 160; left: 10px; position: absolute;
                top: 621px" runat="server" Width="70px" >
  高度</asp:Label>
            <asp:TextBox ID="txtHeight_q" Style="z-index: 161; left: 85px; position: absolute;
                top: 621px" runat="server" Width="70px" ></asp:TextBox>
            <asp:Label ID="lblStyle_q" Style="z-index: 163; left: 10px; position: absolute; top: 649px"
                runat="server" Width="70px" >
  类型</asp:Label>
            <asp:TextBox ID="txtStyle_q" Style="z-index: 164; left: 85px; position: absolute;
                top: 649px" runat="server" Width="70px" ></asp:TextBox>
            <asp:Label ID="lblMemo_q" Style="z-index: 166; left: 10px; position: absolute; top: 677px"
                runat="server" Width="70px" >
  说明</asp:Label>
            <asp:TextBox ID="txtMemo_q" Style="z-index: 167; left: 85px; position: absolute;
                top: 677px" runat="server" Width="70px" ></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 169; left: 10px; position: absolute; top: 705px"
                runat="server"  Text="查询"></asp:Button>
        </div>
        <table id="tabDGRegionDataGrid" style="z-index: 225; left: 8px; width: 552px; position: absolute;
            top: 785px" cellspacing="0" cellpadding="0" width="552" border="0" runat="server">
            <tr>
                <td>
                    <div style="display: inline; width: 500px; position: relative; height: 24px">
                        <asp:Button ID="btnAddNewRec4Dg" Style="z-index: 106; left: 50px; position: absolute;
                            top: 0px" runat="server"   Text="添加"></asp:Button>
                        <asp:Button ID="btnDelete4Dg" Style="z-index: 104; left: 135px; position: absolute;
                            top: 0px" runat="server"   Text="删除"></asp:Button>
                        <asp:Button ID="btnUpdate4Dg" Style="z-index: 105; left: 220px; position: absolute;
                            top: 0px" runat="server"   Text="修改"></asp:Button>
                        <asp:Button ID="btnExportExcel4Dg" Style="z-index: 107; left: 305px; position: absolute;
                            top: 0px" runat="server"   Text="导出Excel"></asp:Button>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DataGrid ID="dgDGRegion" runat="server" Width="500px" AutoGenerateColumns="False"
                        PageSize="10" AllowPaging="true" AllowSorting="true">
                        <Columns>
                            <asp:TemplateColumn HeaderText="选择">
                                <HeaderStyle Width="15px"></HeaderStyle>
                                <HeaderTemplate>
                                    <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server">全选</asp:LinkButton>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="RegionId" SortExpression="RegionId" HeaderText="区域Id"></asp:BoundColumn>
                            <asp:BoundColumn DataField="ViewDgName" SortExpression="ViewDgName" HeaderText="界面Dg名称">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="DataGridStyleDGStyleName" SortExpression="DGStyleId"
                                HeaderText="DG模式ID"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Runat" SortExpression="Runat" HeaderText="运行在"></asp:BoundColumn>
                            <asp:BoundColumn DataField="FontSize" SortExpression="FontSize" HeaderText="字号"></asp:BoundColumn>
                            <asp:BoundColumn DataField="FontName" SortExpression="FontName" HeaderText="字体"></asp:BoundColumn>
                            <asp:BoundColumn DataField="AllowPaging" SortExpression="AllowPaging" HeaderText="允许分页">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="PageSize" SortExpression="PageSize" HeaderText="页大小"></asp:BoundColumn>
                            <asp:BoundColumn DataField="AutoGenerateColumns" SortExpression="AutoGenerateColumns"
                                HeaderText="自动生成列"></asp:BoundColumn>
                            <asp:BoundColumn DataField="AllowSorting" SortExpression="AllowSorting" HeaderText="允许排序">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="IsRadio" SortExpression="IsRadio" HeaderText="是否单选框"></asp:BoundColumn>
                            <asp:BoundColumn DataField="IsCheck" SortExpression="IsCheck" HeaderText="是否复选框"></asp:BoundColumn>
                            <asp:BoundColumn DataField="IsJumpPage" SortExpression="IsJumpPage" HeaderText="是否跳页">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="IsHaveUpdBtn" SortExpression="IsHaveUpdBtn" HeaderText="是否有修改按钮">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="IsHaveDelBtn" SortExpression="IsHaveDelBtn" HeaderText="是否有删除按钮">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="IsHaveDetailBtn" SortExpression="IsHaveDetailBtn" HeaderText="是否有详细按钮">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="IsInTab" SortExpression="IsInTab" HeaderText="是否生成DG在表中">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="Style_Zindex" SortExpression="Style_Zindex" HeaderText="Style_Zindex">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="Style_Left" SortExpression="Style_Left" HeaderText="Style_Left">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="Style_Position" SortExpression="Style_Position" HeaderText="Style_Position">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="Style_Top" SortExpression="Style_Top" HeaderText="Style_Top">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="Width" SortExpression="Width" HeaderText="宽"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Height" SortExpression="Height" HeaderText="高度"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Style" SortExpression="Style" HeaderText="类型"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Memo" SortExpression="Memo" HeaderText="说明"></asp:BoundColumn>
                            <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <PagerStyle Mode="NumericPages"></PagerStyle>
                    </asp:DataGrid>
                </td>
            </tr>
            <tr>
                <td style="width: 605px; background-color:silver">
                    <table id="tabDGRegionJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                        cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                        <tr>
                            <td>
                                <span class="text-secondary">共有记录:</span>
                                <asp:Label ID="lblDGRegionRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                <div style="display: inline; width: 16px; height: 13px">
                                </div>
                                <span class="text-secondary">总页数:</span>
                                <asp:Label ID="lblDGRegionAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                <div style="display: inline; width: 16px; height: 13px">
                                </div>
                                <span class="text-secondary">当前页:</span>
                                <asp:Label ID="lblDGRegionCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                <div style="display: inline; width: 16px; height: 13px">
                                </div>
                                <asp:Button ID="btnDGRegionPrevPage" runat="server"  Width="50px" Text="上一页">
                                </asp:Button>
                                <asp:Button ID="btnDGRegionNextPage" runat="server"  Width="50px" Text="下一页">
                                </asp:Button>
                                到第
                                <asp:TextBox ID="txtDGRegionJump2Page" runat="server"  Width="35px"></asp:TextBox>页
                                <asp:Button ID="btnDGRegionJumpPage" runat="server"  Width="35px" Text="确定">
                                </asp:Button>
                                <asp:CompareValidator ID="DGRegionCompareValidator1" runat="server" ForeColor="DarkOrange"
                                    ErrorMessage="错误！" ControlToValidate="txtDGRegionJump2Page" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <table id="tabEditDGRegionRegion" style="z-index: 341; left: 10px; width: 373px;
            position: absolute; top: 1160px; height: 200px" cellspacing="1" cellpadding="1"
            width="373" border="1">
            <tr>
                <td>
                    <div style="width: 360px; position: relative; height: 24px">
                        <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 8px; position: absolute; top: 0px"
                            runat="server"   Text="添加"></asp:Button>
                        <asp:Label ID="lblMsg" Style="z-index: 105; left: 96px; position: absolute; top: 8px"
                            runat="server" Width="208px" ></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <uc1:wucDGRegion ID="wucDGRegion1" Runat="server"></uc1:wucDGRegion>
                </td>
            </tr>
            <tr>
                <td>
                    <div style="width: 360px; position: relative; height: 24px">
                        <asp:Button ID="btnOKUpd2" Style="z-index: 106; left: 8px; position: absolute; top: 0px"
                            runat="server"   Text="添加"></asp:Button>
                        <asp:Label ID="lblMsg2" Style="z-index: 105; left: 96px; position: absolute; top: 8px"
                            runat="server" Width="208px" ></asp:Label>
                    </div>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
