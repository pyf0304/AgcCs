<%@ Page Language="c#" CodeBehind="wfmDesignView4WinV5.aspx.cs" ValidateRequest="false"
    AutoEventWireup="True" Inherits="AGC.Webform.wfmDesignView4WinV5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>界面操作流程</title>
    

    <script language="javascript" type="text/javascript">
		<!--
	function radioClick()
	{
		if (document.Form1.RadioName !=null)
		{
			for (i=0; i<document.Form1.RadioName.length; i++)
			{
			    if (document.Form1.RadioName[i].checked == true)
			    {
					document.Form1.rd.value = document.Form1.RadioName[i].value;
					document.Form1.TestBox1.value = document.Form1.rd.value ;
				}
			}
		}
	}
		//-->
    </script>

</head>
<body>
    <form id="Form1" method="post" runat="server">
        &nbsp; &nbsp;
        <input id="rd" style="z-index: 103; left: 896px; position: absolute; top: 8px" type="hidden"
            name="rd" runat="server" />
        <input style="visibility: hidden" onclick="radioClick()" type="radio" value="0" name="RadioName" />
        <table id="Table3" style="z-index: 104; left: 4px; width: 832px; position: absolute;
            top: 2px;" cellspacing="0" cellpadding="0" width="832" border="4">
            <tr>
                <td style="width: 64px">
        <asp:Label ID="Label3"
            runat="server"  Width="208px" CssClass="h5">项目界面管理->设计界面</asp:Label></td>
                <td style="width: 116px">
                    <asp:Label ID="Label1" runat="server" Width="58px" Font-Bold="True">界面名称</asp:Label></td>
                <td valign="middle">
                        &nbsp;
                    <asp:Label ID="lblViewName" runat="server" Width="176px">Label</asp:Label></td>
                <td>
                    <asp:Label ID="Label9" runat="server" Width="70px" Font-Bold="True">界面功能：</asp:Label></td>
                <td colspan="1" style="width: 333px">
                    &nbsp;<asp:Label ID="lblViewFunction" runat="server" Width="271px">Label</asp:Label>
        <asp:LinkButton ID="lbReturn" runat="server" Width="32px" OnClick="lbReturn_Click">返回</asp:LinkButton></td>
                <td rowspan="3">
                </td>
            </tr>
            <tr>
                <td colspan="5" style="height: 5px">
                    <img alt="" height="5" src="../../pic/bar1.JPG" style="width: 769px;" /></td>
            </tr>
            <tr>
                <td style="width: 190px" colspan="6" rowspan="1">
                    <div style="width: 832px; position: relative; height: 719px; left: 0px; top: 0px;">
                        <table style="width: 626px">
                            <tr>
                                <td valign="top">
                                    <table style="width: 235px">

                                        <tr>
                                            <td style="width: 410px">
                                                <asp:Label ID="Label7" runat="server" Width="128px" Font-Bold="True">请选择子界面类型：</asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 410px">
                                                &nbsp;<asp:DropDownList ID="ddlSubViewName" runat="server" Width="216px">
                                                </asp:DropDownList></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 410px">
                                                <asp:CheckBox ID="chkIsUseCtrl" runat="server" CssClass="NormalContral" Text="在界面中是否使用控件">
                                                </asp:CheckBox>
                                            </td>
                                        </tr>
                                      
                                        <tr>
                                            <td style="width: 410px">
                                                <img alt="" height="3" src="../../pic/bar1.JPG" style="width: 200px; height: 3px" /></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 410px">
                                                <asp:Button ID="btnGenViewCode" runat="server" Width="135px"  Text="生成界面代码"
                                                    OnClick="btnGenViewCode_Click"></asp:Button></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 410px">
                                                <asp:Button ID="btnGenViewDesignCode" runat="server"  OnClick="btnGenViewDesignCode_Click"
                                                    Text="生成界面设计代码" Width="135px" /></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 410px">
                                                <asp:Button ID="btnGenGeneLogicCode" runat="server" Width="135px"  Text="生成GeneLogic代码"
                                                    OnClick="btnGenGeneLogicCode_Click"></asp:Button></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 410px">
                                                <asp:Button ID="btnGenGeneLogicCodeEx"
                                                        runat="server" Width="135px"  Text="生成扩展逻辑层代码" OnClick="btnGenGeneLogicCodeEx_Click">
                                                    </asp:Button></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 410px">
                                                <asp:Button ID="btnGenGeneLogicCode_Oracle" runat="server"  OnClick="btnGenGeneLogicCode_Oracle_Click"
                                                    Text="数据逻辑层_Ora" ToolTip="专门用于Oracle的数据逻辑层" Width="136px" /></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 410px">
                                                <asp:Button ID="btnGenGeneLogicCodeEx_Oracle" runat="server"  OnClick="btnGenGeneLogicCodeEx_Oracle_Click"
                                                    Text="逻辑层Ex_Ora" Width="135px" /></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 410px">
                                                <img alt="" height="3" src="../../pic/bar1.JPG" style="width: 200px; height: 3px" /></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 410px">
                                                <asp:Button ID="btnCtlViewCode" Style="left: -86px; top: 117px" runat="server" Width="135px"
                                                     Text="生成表控件代码"></asp:Button><asp:HyperLink ID="HyperLink2" Style="left: -86px;
                                                        top: 117px" runat="server" CssClass="MemoStyle1" Width="91px">设置控件编辑区字段</asp:HyperLink></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 410px">
                                                <asp:Button ID="btnCtlViewCode4Query" Style="left: -86px; top: 117px" runat="server"
                                                    Width="135px"  Text="生成表查询控件" OnClick="btnCtlViewCode4Query_Click">
                                                </asp:Button>
                                                <asp:HyperLink ID="HyperLink1" Style="left: -86px; top: 117px" runat="server" CssClass="MemoStyle1" Width="89px">设置查询区字段</asp:HyperLink></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 410px">
                                                <asp:Button ID="btnCtlViewCode_Disp" runat="server" Width="135px"  Visible="False"
                                                    Text="专用于显示的表控件"></asp:Button></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 410px">
                                                <img alt="" height="3" src="../../pic/bar1.JPG" style="width: 200px; height: 3px" /></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 410px">
                                                <asp:Label ID="Label11" runat="server" Width="72px" Font-Bold="True">函数列表：</asp:Label>
                                                </td>
                                        </tr>
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
                                            <td style="width: 410px">
                                                <asp:HyperLink ID="HyperLink3" runat="server">设置列表显示区字段</asp:HyperLink></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 410px">
                                                <asp:CheckBoxList ID="cbkShowMode" runat="server" Width="144px">
                                                    <asp:ListItem Value="界面所有字段">界面所有字段</asp:ListItem>
                                                    <asp:ListItem Value="查询字段列表">查询字段列表</asp:ListItem>
                                                    <asp:ListItem Value="显示信息字段列表">显示信息字段列表</asp:ListItem>
                                                    <asp:ListItem Value="编辑控件字段列表">编辑控件字段列表</asp:ListItem>
                                                </asp:CheckBoxList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 410px; height: 26px;">
                                                <asp:Button ID="btnShowRelaFldList" runat="server" Width="135px"  Text="显示相关字段信息">
                                                </asp:Button></td>
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
                                                        runat="server" Width="45px" >文件名</asp:Label>
                                                    <asp:TextBox ID="txtFileName4GenCode" Style="z-index: 104; left: 147px; position: absolute;
                                                        top: 1px" runat="server" Width="316px" ></asp:TextBox>
                                                    <asp:LinkButton ID="lbDownLoadFile" Style="z-index: 111; left: 486px; position: absolute;
                                                        top: 4px" runat="server" Width="56px" >下载文件</asp:LinkButton>
                                                <asp:Label ID="lblCaption4GenCode" runat="server" Width="93px"  Font-Names="宋体"
                                                    CssClass="h6">生成的代码：</asp:Label></div>
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
                    </div>
                </td>
            </tr>
            <tr>
                <td colspan="6">
                    <div id="divViewFldList" style="width: 835px; position: relative; height: 210px"
                        runat="server">
                        <asp:ImageButton ID="ibDown" runat="server" Height="28px" Width="24px" ImageUrl="../../pic/Down.JPG"
                            Style="z-index: 100; left: 0px; position: absolute; top: 136px"></asp:ImageButton>
                        <asp:ImageButton ID="ibUp" runat="server" Height="28px" Width="24px" ImageUrl="../../pic/Up.JPG"
                            Style="z-index: 101; left: 0px; position: absolute; top: 72px"></asp:ImageButton>
                        <asp:DataGrid ID="dgViewFldInfo" runat="server" Font-Names="宋体" Width="784px" AutoGenerateColumns="False"
                            AllowPaging="True" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
                            BackColor="White" CellPadding="3" GridLines="Horizontal" Style="z-index: 102;
                            left: 24px; position: absolute; top: 32px" PageSize="5" CssClass="table table-striped table-bordered table-condensed">
                            <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                            <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                            <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                            <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                            <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                            <Columns>
                                <asp:TemplateColumn>
                                    <ItemTemplate>
                                        <input name="RadioName" onclick="radioClick()" type="radio" value='<%# DataBinder.Eval(Container.DataItem, "mId")%>'>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:BoundColumn Visible="False" DataField="MId" HeaderText="MId"></asp:BoundColumn>
                                <asp:BoundColumn DataField="FieldTabFldName" HeaderText="字段ID"></asp:BoundColumn>
                                <asp:BoundColumn Visible="False" DataField="ViewInfoViewName" HeaderText="界面ID"></asp:BoundColumn>
                                <asp:BoundColumn DataField="PrjTabTabName" HeaderText="表"></asp:BoundColumn>
                                <asp:BoundColumn DataField="CtlTypeAbbrCtlTypeName" HeaderText="控件类型"></asp:BoundColumn>
                                <asp:BoundColumn DataField="DDLItemsOptionDDLItemsOption" HeaderText="下拉框列表项来源选项"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsQuery" HeaderText="查询字段?"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsDataGrid" HeaderText="DataGrid字段?"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsNeedSort" HeaderText="需要排序?"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsCtlField" HeaderText="控件字段?"></asp:BoundColumn>
                            </Columns>
                            <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                            </PagerStyle>
                        </asp:DataGrid>
                        <asp:Label ID="Label6" runat="server" Width="104px" Font-Bold="True"
                            Style="z-index: 103; left: 8px; position: absolute; top: 8px">界面字段情况：</asp:Label>
                        <asp:Button ID="btnSetFld" Style="z-index: 114; left: 264px; position: absolute;
                            top: 8px" runat="server"  Text="设置字段"></asp:Button>
                        <asp:Label ID="lblMsg2" Style="z-index: 114; left: 328px; position: absolute; top: 16px"
                            runat="server" Width="144px" ></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td colspan="6">
                    <div id="divQueryFldList" style="width: 817px; position: relative; height: 210px"
                        runat="server">
                        <asp:Label ID="Label12" Style="z-index: 101; left: 40px; position: absolute; top: 8px"
                            runat="server" Font-Bold="True">查询控件字段列表：</asp:Label>
                        <asp:ImageButton ID="Imagebutton2" Style="z-index: 102; left: 0px; position: absolute;
                            top: 144px" runat="server" Width="24px" Height="28px" ImageUrl="../../pic/Down.JPG">
                        </asp:ImageButton>
                        <asp:ImageButton ID="Imagebutton3" Style="z-index: 103; left: 0px; position: absolute;
                            top: 48px" runat="server" Width="24px" Height="28px" ImageUrl="../../pic/Up.JPG">
                        </asp:ImageButton>
                        <asp:DataGrid ID="Datagrid1" Style="z-index: 104; left: 32px; position: absolute;
                            top: 32px" runat="server" Width="784px" Font-Names="宋体" PageSize="5" GridLines="Horizontal"
                            CellPadding="3" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#E7E7FF"
                            AllowPaging="True" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-condensed">
                            <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                            <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                            <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                            <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                            <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                            <Columns>
                                <asp:TemplateColumn>
                                    <ItemTemplate>
                                        <input name="RadioName" onclick="radioClick()" type="radio" value='<%# DataBinder.Eval(Container.DataItem, "mId")%>'>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:BoundColumn Visible="False" DataField="MId" HeaderText="MId"></asp:BoundColumn>
                                <asp:BoundColumn DataField="FieldTabFldName" HeaderText="字段ID"></asp:BoundColumn>
                                <asp:BoundColumn Visible="False" DataField="ViewInfoViewName" HeaderText="界面ID"></asp:BoundColumn>
                                <asp:BoundColumn DataField="PrjTabTabName" HeaderText="表"></asp:BoundColumn>
                                <asp:BoundColumn DataField="CtlTypeAbbrCtlTypeName" HeaderText="控件类型"></asp:BoundColumn>
                                <asp:BoundColumn DataField="DDLItemsOptionDDLItemsOption" HeaderText="下拉框列表项来源选项"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsQuery" HeaderText="查询字段?"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsDataGrid" HeaderText="DataGrid字段?"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsNeedSort" HeaderText="需要排序?"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsCtlField" HeaderText="控件字段?"></asp:BoundColumn>
                            </Columns>
                            <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                            </PagerStyle>
                        </asp:DataGrid>
                    </div>
                </td>
            </tr>
            <tr>
                <td style="width: 67px" colspan="6">
                    <div id="divDispDataFldList" style="width: 817px; position: relative; height: 210px"
                        runat="server">
                        <asp:Label ID="Label13" Style="z-index: 111; left: 32px; position: absolute; top: 8px"
                            runat="server" Font-Bold="True">显示信息字段列表：</asp:Label>
                        <asp:ImageButton ID="Imagebutton1" Style="z-index: 112; left: 0px; position: absolute;
                            top: 136px" runat="server" Width="24px" Height="28px" ImageUrl="../../pic/Down.JPG">
                        </asp:ImageButton>
                        <asp:ImageButton ID="Imagebutton4" Style="z-index: 113; left: 0px; position: absolute;
                            top: 80px" runat="server" Width="24px" Height="28px" ImageUrl="../../pic/Up.JPG">
                        </asp:ImageButton>
                        <asp:DataGrid ID="Datagrid2" Style="z-index: 114; left: 32px; position: absolute;
                            top: 32px" runat="server" Width="784px" Font-Names="宋体" PageSize="5" GridLines="Horizontal"
                            CellPadding="3" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#E7E7FF"
                            AllowPaging="True" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-condensed">
                            <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                            <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                            <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                            <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                            <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                            <Columns>
                                <asp:TemplateColumn>
                                    <ItemTemplate>
                                        <input name="RadioName" onclick="radioClick()" type="radio" value='<%# DataBinder.Eval(Container.DataItem, "mId")%>'>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:BoundColumn Visible="False" DataField="MId" HeaderText="MId"></asp:BoundColumn>
                                <asp:BoundColumn DataField="FieldTabFldName" HeaderText="字段ID"></asp:BoundColumn>
                                <asp:BoundColumn Visible="False" DataField="ViewInfoViewName" HeaderText="界面ID"></asp:BoundColumn>
                                <asp:BoundColumn DataField="PrjTabTabName" HeaderText="表"></asp:BoundColumn>
                                <asp:BoundColumn DataField="CtlTypeAbbrCtlTypeName" HeaderText="控件类型"></asp:BoundColumn>
                                <asp:BoundColumn DataField="DDLItemsOptionDDLItemsOption" HeaderText="下拉框列表项来源选项"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsQuery" HeaderText="查询字段?"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsDataGrid" HeaderText="DataGrid字段?"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsNeedSort" HeaderText="需要排序?"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsCtlField" HeaderText="控件字段?"></asp:BoundColumn>
                            </Columns>
                            <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                            </PagerStyle>
                        </asp:DataGrid>
                    </div>
                </td>
            </tr>
            <tr>
                <td style="width: 67px" colspan="6">
                    <div id="divEditCtrlFldList" style="width: 825px; position: relative; height: 210px"
                        runat="server">
                        <asp:Label ID="Label14" Style="z-index: 100; left: 40px; position: absolute; top: 8px"
                            runat="server" Font-Bold="True">编辑控件字段列表：</asp:Label>
                        <asp:DataGrid ID="Datagrid3" Style="z-index: 101; left: 32px; position: absolute;
                            top: 32px" runat="server" Width="784px" Font-Names="宋体" PageSize="5" GridLines="Horizontal"
                            CellPadding="3" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#E7E7FF"
                            AllowPaging="True" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-condensed">
                            <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                            <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                            <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                            <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                            <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                            <Columns>
                                <asp:TemplateColumn>
                                    <ItemTemplate>
                                        <input name="RadioName" onclick="radioClick()" type="radio" value='<%# DataBinder.Eval(Container.DataItem, "mId")%>'>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                                <asp:BoundColumn Visible="False" DataField="MId" HeaderText="MId"></asp:BoundColumn>
                                <asp:BoundColumn DataField="FieldTabFldName" HeaderText="字段ID"></asp:BoundColumn>
                                <asp:BoundColumn Visible="False" DataField="ViewInfoViewName" HeaderText="界面ID"></asp:BoundColumn>
                                <asp:BoundColumn DataField="PrjTabTabName" HeaderText="表"></asp:BoundColumn>
                                <asp:BoundColumn DataField="CtlTypeAbbrCtlTypeName" HeaderText="控件类型"></asp:BoundColumn>
                                <asp:BoundColumn DataField="DDLItemsOptionDDLItemsOption" HeaderText="下拉框列表项来源选项"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsQuery" HeaderText="查询字段?"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsDataGrid" HeaderText="DataGrid字段?"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsNeedSort" HeaderText="需要排序?"></asp:BoundColumn>
                                <asp:BoundColumn DataField="IsCtlField" HeaderText="控件字段?"></asp:BoundColumn>
                            </Columns>
                            <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                            </PagerStyle>
                        </asp:DataGrid>
                        <asp:ImageButton ID="Imagebutton5" Style="z-index: 102; left: 0px; position: absolute;
                            top: 136px" runat="server" Width="24px" Height="28px" ImageUrl="../../pic/Down.JPG">
                        </asp:ImageButton>
                        <asp:ImageButton ID="Imagebutton6" Style="z-index: 104; left: 0px; position: absolute;
                            top: 80px" runat="server" Width="24px" Height="28px" ImageUrl="../../pic/Up.JPG">
                        </asp:ImageButton>
                    </div>
                </td>
            </tr>
            <tr>
                <td style="width: 190px" colspan="2" rowspan="1">
                    <asp:Label ID="lblRecCount" runat="server" Font-Names="宋体"  Width="110px">查询结果记录数：</asp:Label></td>
                <td style="width: 404px" colspan="2" rowspan="1">
                    <asp:TextBox ID="txtRecCount" runat="server" Font-Names="宋体"  Width="111px"
                        ReadOnly="True"></asp:TextBox></td>
                <td style="width: 333px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="width: 239px" colspan="6" rowspan="1">
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
