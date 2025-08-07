<%@ Page Language="c#" CodeBehind="wfmGenViewCode_WebV5.aspx.cs" AutoEventWireup="True"
    ValidateRequest="false" Inherits="AGC.Webform.wfmGenViewCode_WebV5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>表ViewInfo的查询、修改、删除、添加记录</title>
    

    <script language="javascript" type="text/javascript">
		<!--
    function radioClick() {
        if (document.Form1.RadioName != null) {
            for (i = 0; i < document.Form1.RadioName.length; i++) {
                if (document.Form1.RadioName[i].checked == true) {
                    document.Form1.rd.value = document.Form1.RadioName[i].value;
                    //document.getElementById("TextBox1").value = document.Form1.rd.value;
                }
            }
        }
    }
    //-->
    </script>

</head>
<body>
    <form id="Form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Label ID="Label3" Style="z-index: 102; left: 8px; position: absolute; top: 8px"
            runat="server" Width="240px" CssClass="h5">生成C#代码->WEB界面代码V5</asp:Label>
        <table id="tabHidden" style="z-index: 101; left: 840px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
            <tr>
                <td></td>
                <td></td>
                <td style="width: 61px">
                    <asp:Label ID="lblUserIdq" runat="server" >用户ID</asp:Label></td>
                <td>
                    <asp:TextBox ID="txtUserIdq" runat="server" Width="49px" ></asp:TextBox></td>
                <td>
                    <asp:Label ID="lblPrjIdq" runat="server" >工程ID</asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddlPrjIdq" runat="server" Width="112px">
                    </asp:DropDownList></td>
            </tr>
        </table>
        &nbsp;
        <input id="rd" style="z-index: 103; left: 896px; width: 24px; position: absolute; top: 48px; height: 22px"
            type="hidden" name="rd" runat="server" />
        <input style="display: none; z-index: 104; left: 8px; position: absolute; top: 8px"
            type="radio" name="RadioName" />
        <table id="Table1" style="z-index: 105; left: 8px; position: absolute; top: 32px"
            cellspacing="0" cellpadding="0" width="300" border="0">
            <tr>
                <td>
                    <table id="tabQuery1" style="border-color: #666666" cellspacing="1" cellpadding="1"
                        width="300" border="2" runat="server">
                        <tr>
                            <td colspan="2" style="height: 70px">
                                <table id="tabQuery" style="width: 804px; height: 32px; border-color: #666666" cellspacing="1"
                                    cellpadding="1" width="804" border="2">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblViewNameq" runat="server" Width="56px" CssClass="text-secondary">界面名称</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="txtViewNameq" runat="server" Width="109px"></asp:TextBox></td>
                                        <td style="width: 62px">
                                            <asp:Label ID="lblApplicationTypeIdq" runat="server" Width="79px"
                                                CssClass="text-secondary">应用程序类型</asp:Label></td>
                                        <td>
                                            <asp:DropDownList ID="ddlApplicationTypeIdq" runat="server" Width="126px"
                                                AutoPostBack="True" OnSelectedIndexChanged="ddlApplicationTypeId_q_SelectedIndexChanged">
                                            </asp:DropDownList></td>
                                        <td>
                                            <asp:Label ID="Label5" runat="server" Width="56px" CssClass="text-secondary">功能模块</asp:Label></td>
                                        <td>
                                            <asp:DropDownList ID="ddlFuncModuleIdq" runat="server" Width="224px">
                                            </asp:DropDownList></td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblMainTabNameq" runat="server" Width="56px" CssClass="text-secondary">界面表名</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="txtMainTabNameq" runat="server" Width="104px"></asp:TextBox></td>
                                        <td style="width: 62px">
                                            <asp:Label ID="lblViewTypeCodeq" runat="server" Width="72px" CssClass="text-secondary">界面类型码</asp:Label></td>
                                        <td>
                                            <asp:DropDownList ID="ddlViewTypeCodeq" runat="server" Width="124px">
                                            </asp:DropDownList></td>
                                        <td>
                                            <asp:Label ID="lblViewGroupIdq" runat="server"  CssClass="text-secondary">界面组</asp:Label></td>
                                        <td>
                                            <asp:DropDownList ID="ddlViewGroupIdq" runat="server" Width="168px">
                                            </asp:DropDownList></td>
                                        <td>
                                            <asp:Button ID="btnQuery" runat="server"   Text="查询" OnClick="btnQuery_Click"></asp:Button></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height: 53px; width: auto">
                                <div style="width: 833px; height: 173px;">
                                    <table id="Table3" style="z-index: 101; left: 8px; width: 808px; top: 32px; height: 122px"
                                        cellspacing="2" cellpadding="2" width="808" border="0">
                                        <tr>
                                            <td colspan="5">
                                                <table style="width: 753px">
                                                    <tr>
                                                        <td style="height: 11px; width: 200px;" valign="top">
                                                            <asp:Label ID="Label4" runat="server" CssClass="RegionTitleH3" Width="164px">生成一般控件、界面</asp:Label></td>
                                                        <td style="height: 11px; width: 238px;" valign="top">
                                                            <asp:RadioButtonList ID="rblNetVersion" runat="server" Width="200px" RepeatDirection="Horizontal"
                                                                CssClass="Radio_Defa">
                                                                <asp:ListItem Value="Net2005">Net2005</asp:ListItem>
                                                                <asp:ListItem Value="Net2010" Selected="True">Net2010</asp:ListItem>
                                                            </asp:RadioButtonList></td>
                                                        <td style="height: 11px" valign="top">
                                                            <asp:CheckBox ID="chkNewStructure" runat="server" Text="新架构" /></td>
                                                        <td style="width: 176px; height: 11px" valign="top">
                                                            <asp:LinkButton ID="lbDispDivGeneQueryCtl" runat="server" Width="108px" OnClick="lbDispDivGeneQueryCtl_Click">生成查询显示控件</asp:LinkButton></td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Button ID="btnCtlViewCode" runat="server"  Width="110px" Text="表控件View代码"
                                                    OnClick="btnCtlViewCode_Click"></asp:Button></td>
                                            <td>
                                                <div class="MemoStyle1" style="width: 192px; height: 17px">
                                                    编辑区控件的View代码(HTML)
                                                </div>
                                            </td>
                                            <td>
                                                <asp:Button ID="btnGenGeneLogicCode" runat="server" Width="100px"  Text="数据逻辑层"
                                                    OnClick="btnGenGeneLogicCode_Click"></asp:Button></td>
                                            <td>
                                                <asp:Button ID="btnGenGeneExLogicCode" runat="server"  Width="100px"
                                                    Text="数据逻辑层Ex" OnClick="btnGenGeneExLogicCode_Click"></asp:Button>
                                            </td>
                                            <td style="width: 210px">
                                                <div class="MemoStyle1" style="width: 176px; height: 17px">
                                                    专门用于SQL的数据逻辑层
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Button ID="btnCtlControlCode" runat="server"  Width="110px" Text="表控件Control代码"
                                                    OnClick="btnCtlControlCode_Click"></asp:Button></td>
                                            <td>
                                                <div class="MemoStyle1" style="display: inline; width: 192px; height: 17px">
                                                    编辑区控件的后台代码(C#)
                                                </div>
                                            </td>
                                            <td>
                                                <asp:Button ID="btnGenGeneLogicCode_Oracle" runat="server"  Width="100px"
                                                    Text="数据逻辑层_Ora" OnClick="btnGenGeneLogicCode_Oracle_Click"></asp:Button></td>
                                            <td>
                                                <asp:Button ID="btnGenGeneLogicCodeEx_Oracle" runat="server"  Width="100px"
                                                    Text="逻辑层Ex_Ora" OnClick="btnGenGeneLogicCodeEx_Oracle_Click"></asp:Button>
                                            </td>
                                            <td style="width: 210px">
                                                <div class="MemoStyle1" style="display: inline; width: 192px; height: 17px">
                                                    专门用于Oracle的数据逻辑层
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Button ID="btnGenViewCode" runat="server" Width="110px"  Text="界面View代码"
                                                    OnClick="btnGenViewCode_Click"></asp:Button></td>
                                            <td>
                                                <div class="MemoStyle1" style="display: inline; width: 192px; height: 17px">
                                                    界面的View代码(HTML代码)
                                                </div>
                                            </td>
                                            <td>
                                                <asp:Button ID="btnPreView" runat="server"  Width="100px" Text="预览各区域"
                                                    OnClick="btnPreView_Click"></asp:Button></td>
                                            <td></td>
                                            <td style="width: 210px">
                                                <div class="MemoStyle1" style="display: inline; width: 192px; height: 17px">
                                                    显示界面中各区域的界面效果。
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 28px">
                                                <asp:Button ID="btnGenControlCode" runat="server" Width="110px"  Text="界面Control代码"
                                                    OnClick="btnGenControlCode_Click"></asp:Button></td>
                                            <td style="height: 28px">
                                                <div class="MemoStyle1" style="display: inline; width: 189px; height: 17px">
                                                    界面的后台代码(C#代码)
                                                </div>
                                            </td>
                                            <td style="height: 28px">
                                                <asp:Button ID="btnGeneCode" runat="server"  OnClick="btnGeneCode_Click"
                                                    Text="生成代码V6" Width="100px" /></td>
                                            <td style="height: 28px"></td>
                                            <td style="width: 210px; height: 28px;"></td>
                                        </tr>
                                    </table>
                                    &nbsp;&nbsp;
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <div id="divGeneQueryCtl" style="width: 783px; position: relative; height: 131px; left: 0px; top: 0px;"
                                    runat="server">
                                    <table id="Table2" style="width: 736px; height: 122px" cellspacing="2" cellpadding="2"
                                        width="736" border="0">
                                        <tr>
                                            <td colspan="2">
                                                <asp:Label ID="Label2" runat="server" CssClass="RegionTitleH3" Width="681px">生成查询显示控件</asp:Label>
                                                <asp:LinkButton ID="lbCloseDivQueryCtl" Style="left: 605px; top: 49px" runat="server"
                                                    OnClick="lbCloseDivQueryCtl_Click">关闭</asp:LinkButton></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Button ID="btnCtlViewCode_Disp" runat="server"  Width="136px" Text="专用于显示的表控件"
                                                    OnClick="btnCtlViewCode_Disp_Click"></asp:Button></td>
                                            <td style="width: 92px">
                                                <div class="MemoStyle1" style="display: inline; width: 216px; height: 15px">
                                                    说明
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 28px">
                                                <asp:Button ID="btnCtlViewCtlCode_Disp" runat="server"  Width="168px"
                                                    Text="专用于显示的表控件Ctl代码" OnClick="btnCtlViewCtlCode_Disp_Click"></asp:Button></td>
                                            <td style="width: 92px; height: 28px;">
                                                <div class="MemoStyle1" style="display: inline; width: 70px; height: 15px">
                                                    说明
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 28px">
                                                <asp:Button ID="btnCtlViewCode4Query" runat="server"  Width="152px"
                                                    Text="生成表查询控件View代码" OnClick="btnCtlViewCode4Query_Click"></asp:Button></td>
                                            <td style="width: 92px; height: 28px;">
                                                <div class="MemoStyle1" style="display: inline; width: 70px; height: 15px">
                                                    说明
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Button ID="btnCtlControlCode4Query" runat="server"  Width="168px"
                                                    Text="生成表查询控件Control代码" OnClick="btnCtlControlCode4Query_Click"></asp:Button></td>
                                            <td style="width: 92px">
                                                <div class="MemoStyle1" style="display: inline; width: 70px; height: 15px">
                                                    说明
                                                </div>
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height: 241px">&nbsp;<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:DataGrid ID="dgViewInfo" runat="server" Width="828px" Height="214px" Font-Names="宋体"
                                        Font-Size="Smaller" GridLines="Vertical" CellPadding="0" BackColor="White" BorderWidth="1px"
                                        BorderStyle="Ridge" BorderColor="White" AutoGenerateColumns="False" AllowPaging="True"
                                        AllowSorting="True" PageSize="15" OnItemCreated="dgViewInfo_ItemCreated" OnItemDataBound="dgViewInfo_ItemDataBound"
                                        OnPageIndexChanged="dgViewInfo_PageIndexChanged" OnSortCommand="dgViewInfo_SortCommand">
                                        <FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
                                        <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
                                        <ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
                                        <HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
                                        <Columns>
                                            <asp:TemplateColumn>
                                                <ItemTemplate>
                                                    <input onclick="radioClick()" type="radio" value='<%# DataBinder.Eval(Container.DataItem, "ViewId")%>'
                                                        name="RadioName">
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            <asp:BoundColumn Visible="False" DataField="ViewId" HeaderText="界面ID"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="ApplicationTypeName" SortExpression="ApplicationTypeName"
                                                HeaderText="应用程序类型"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="ViewGroupName" SortExpression="ViewGroupName" HeaderText="界面组"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="ViewName" SortExpression="ViewName" HeaderText="界面名称"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="ViewTypeName" SortExpression="ViewTypeName" HeaderText="界面类型码"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="功能模块"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="DataBaseName" SortExpression="DataBaseName"
                                                HeaderText="数据库名"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="MainTabName" SortExpression="MainTabName" HeaderText="界面表名"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="DetailTabName" SortExpression="DetailTabName"
                                                HeaderText="明细表名"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="KeyForMainTab" SortExpression="KeyForMainTab"
                                                HeaderText="主表关键字"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="KeyForDetailTab" SortExpression="KeyForDetailTab"
                                                HeaderText="明细表关键字"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="IsNeedSort" HeaderText="是否需要排序"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="IsNeedTransCode" HeaderText="是否需要转换代码"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="UserId" HeaderText="用户ID"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="PrjName" HeaderText="工程ID"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="ViewFunction" HeaderText="界面功能" Visible="False"></asp:BoundColumn>
                                        </Columns>
                                        <PagerStyle NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Right" ForeColor="Black"
                                            BackColor="#C6C3C6"></PagerStyle>
                                    </asp:DataGrid>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnQuery" EventName="Click" />
                                </Triggers>
                            </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblRecCount" runat="server" Width="110px"  Font-Names="宋体"
                                    Font-Size="Smaller">查询结果记录数：</asp:Label></td>
                            <td rowspan="1">
                                <asp:TextBox ID="txtRecCount" runat="server" Width="111px" Font-Names="宋体"
                                    Font-Size="Smaller" ReadOnly="True"></asp:TextBox></td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabCode" style="width: 776px; height: 44px" cellspacing="1" cellpadding="1"
                        width="776" border="1" runat="server">
                        <tr>
                            <td colspan="2">
                                <div style="width: 760px; position: relative; height: 32px">
                                    <asp:Label ID="lblCaption4GenCode" runat="server" Width="120px"  Font-Names="宋体"
                                        Font-Size="Smaller" Style="z-index: 101; left: 8px; position: absolute; top: 8px">生成的逻辑层代码：</asp:Label>
                                    <asp:LinkButton ID="lbDispTabList" runat="server" Style="z-index: 102; left: 664px; position: absolute; top: 8px"
                                        OnClick="lbDispTabList_Click">显示界面列表</asp:LinkButton>
                                    <asp:Label ID="Label1" Style="z-index: 103; left: 152px; position: absolute; top: 8px"
                                        runat="server"   CssClass="text-secondary">生成文件名：</asp:Label>
                                    <asp:TextBox ID="txtFileName4GenCode" Style="z-index: 104; left: 248px; position: absolute; top: 8px"
                                        runat="server" Width="336px"></asp:TextBox>
                                    <asp:LinkButton ID="lbDownLoadFile" Style="z-index: 111; left: 600px; position: absolute; top: 8px"
                                        runat="server"  Width="56px" OnClick="lbDownLoadFile_Click">下载文件</asp:LinkButton>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                  <asp:Literal ID="litCode" runat="server"></asp:Literal>

                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
        </table>
        <asp:Label ID="lblMsg2" Style="z-index: 106; left: 272px; position: absolute; top: 8px"
            runat="server" Height="13px" Width="448px" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
