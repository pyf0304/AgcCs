<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucDGRegion.ascx.cs"
    Inherits="AGC.Webform.wucDGRegion" %>

<table id="tabwucDGRegion" cellspacing="1" cellpadding="1" width="600" border="0"
    style="width: 600px; height: 408px">
    <tr>
        <td colspan="4">
            
                <div style="width: 632px; position: relative; height: 212px">
                    <asp:Label ID="Label27" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
                        CssClass="RegionTitleH3" Font-Names="幼圆" runat="server" Width="616px">1、DataGrid基本信息</asp:Label>
                    <table id="Table6" style="z-index: 106; left: 16px; width: 616px; position: absolute;
                        top: 32px; height: 40px" cellspacing="1" cellpadding="1" width="616" border="0">
                        <tr>
                            <td style="width: 95px" valign="top">
                                <asp:Label ID="lblViewDgName" CssClass="col-form-label text-right"
                                    runat="server">界面Dg名称</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtViewDgName" runat="server"
                                    Width="200px"></asp:TextBox></td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 255px; height: 18px">
                                    生成的DataGrid的名称</font></div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 95px">
                                <asp:Label ID="lblDGStyleId" CssClass="col-form-label text-right"
                                    runat="server">DG模式ID</asp:Label></td>
                            <td>
                                <asp:DropDownList ID="ddlDGStyleId" runat="server"
                                    Width="200px">
                                </asp:DropDownList></td>
                            <td>
                                
                                    <div class="MemoStyle1" style="display: inline; width: 286px; height: 32px">
                                        程序员选择一个模式后可以决定DataGrid的部分属性</div>
                                </font>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 95px">
                                <asp:Label ID="lblRunat" runat="server">运行在</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtRunat" runat="server"
                                    Width="200px"></asp:TextBox></td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 287px; height: 15px">
                                    一般默认为Server,说明是服务器端控件。</div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 95px">
                                <asp:Label ID="lblFontName" runat="server">字体</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtFontName" runat="server"
                                    Width="200px"></asp:TextBox></td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 287px; height: 15px">
                                    DataGrid的字体</div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 95px">
                                <asp:Label ID="lblFontSize" CssClass="col-form-label text-right"
                                    runat="server">字号</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtFontSize" runat="server"
                                    Width="200px"></asp:TextBox></td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 287px; height: 15px">
                                    DataGrid的字号</div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 95px">
                                <asp:CheckBox ID="chkAutoGenerateColumns"
                                    runat="server" Text="自动生成列" CssClass="Check_Defa"></asp:CheckBox></td>
                            <td>
                            </td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 287px; height: 15px">
                                    DataGrid是否相关数据源的字段列</div>
                            </td>
                        </tr>
                    </table>
                </div>
            </font></font>
        </td>
    </tr>
    <tr>
        <td>
            
        </td>
        <td>
        </td>
        <td>
            
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            
                <div style="width: 632px; position: relative; height: 155px">
                    
                    <asp:Label ID="Label22" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
                        CssClass="RegionTitleH3" Font-Names="幼圆" runat="server" Width="616px">2、分页、排序</asp:Label>
                    <table id="Table5" style="z-index: 106; left: 16px; width: 616px; position: absolute;
                        top: 32px; height: 40px" cellspacing="1" cellpadding="1" width="616" border="0">
                        <tr>
                            <td style="width: 81px" valign="top">
                                <asp:Label ID="Label18" runat="server" CssClass="col-form-label text-right">允许分页</asp:Label></td>
                            <td style="width: 225px">
                                <asp:CheckBox ID="chkAllowPaging" runat="server"
                                    Text="允许分页" CssClass="Check_Defa"></asp:CheckBox></td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 288px; height: 32px">
                                    DataGrid是否可以分页，使DataGrid可以多页显示数据表的记录。</div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 81px">
                                <asp:Label ID="lblPageSize" runat="server" CssClass="col-form-label text-right">页大小</asp:Label></td>
                            <td style="width: 225px">
                                <asp:TextBox ID="txtPageSize" runat="server"
                                    ></asp:TextBox>
                                <asp:CompareValidator ID="ComValid_PageSize"
                                    runat="server" EnableClientScript="false" Operator="DataTypeCheck" Type="Integer"
                                    ControlToValidate="txtPageSize" ErrorMessage="请输入整型数值!" CssClass="text-warning"></asp:CompareValidator></td>
                            <td>
                                
                                    <div class="MemoStyle1" style="display: inline; width: 288px; height: 24px">
                                        DataGrid若分页，决定每一页的大小</div>
                                </font>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 81px">
                                <asp:CheckBox ID="chkIsJumpPage" runat="server"
                                    Text="是否跳页" CssClass="Check_Defa"></asp:CheckBox></td>
                            <td style="width: 225px">
                            </td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 288px; height: 15px">
                                    在DataGrid的下方，是否显示跳页控件，例如：&lt;上一页&gt;、&lt;下一页&gt;、&lt;第一页&gt;、&lt;最后一页&gt;。</div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 81px">
                                <asp:CheckBox ID="chkAllowSorting" runat="server"
                                    Text="允许排序" CssClass="Check_Defa"></asp:CheckBox></td>
                            <td style="width: 225px">
                            </td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 288px; height: 15px">
                                    DataGrid是否具有排序功能。</div>
                            </td>
                        </tr>
                    </table>
                </div>
            </font>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <div style="width: 632px; position: relative; height: 114px">
                
                <asp:Label ID="Label1" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
                    CssClass="RegionTitleH3" Font-Names="幼圆" runat="server" Width="616px">3、选取记录的方式</asp:Label>
                <table id="Table1" style="z-index: 106; left: 16px; width: 616px; position: absolute;
                    top: 32px; height: 76px" cellspacing="1" cellpadding="1" width="616" border="0">
                    <tr>
                        <td style="width: 81px" valign="top">
                            <asp:RadioButton ID="rbIsCheck" runat="server"
                                Text="复选框" GroupName="SelRecordMode" CssClass="Radio_DEfa"></asp:RadioButton></td>
                        <td>
                            <asp:Label ID="Label2" CssClass="MemoStyle1"
                                runat="server">DataGrid使用复选框来选取记录，可一次选取多条记录，但多选时只修改选取的第一条记录；</asp:Label></td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 81px">
                            <asp:RadioButton ID="rbIsRadio" runat="server"
                                Text="单选框" GroupName="SelRecordMode" CssClass="Radio_DEfa"></asp:RadioButton></td>
                        <td>
                            <asp:Label ID="Label3" CssClass="MemoStyle1"
                                runat="server">DataGrid使用单选框来选取记录，一次只能选取一条记录。</asp:Label></td>
                        <td>
                            
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 81px">
                            <asp:RadioButton ID="rbNoSelRecordMode"
                                runat="server" Text="无单复选" GroupName="SelRecordMode" CssClass="Radio_DEfa"></asp:RadioButton></td>
                        <td>
                            
                                <asp:Label ID="Label4" CssClass="MemoStyle1"
                                    runat="server">DataGrid不使用单选框，也不使用复选框。</asp:Label></font></td>
                        <td>
                            
                        </td>
                    </tr>
                </table>
            </div>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            
                <div style="width: 632px; position: relative; height: 116px">
                    <asp:Label ID="Label5" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
                        CssClass="RegionTitleH3" runat="server" Width="616px">4、DataGrid的按钮情况</asp:Label>
                    <table id="Table2" style="z-index: 103; left: 16px; width: 616px; position: absolute;
                        top: 32px; height: 77px" cellspacing="1" cellpadding="1" width="616" border="0">
                        <tr>
                            <td style="width: 124px">
                                <asp:CheckBox ID="chkIsHaveUpdBtn" runat="server"
                                    Text="是否有修改按钮" CssClass="Check_Defa"></asp:CheckBox></td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 472px; height: 19px">
                                    在DataGrid中，专门生成一功能列&lt;修改&gt;，单击后可以触发修改记录的事件过程</div>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 124px">
                                <asp:CheckBox ID="chkIsHaveDelBtn" runat="server"
                                    Text="是否有删除按钮" CssClass="Check_Defa"></asp:CheckBox></td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 70px; height: 15px">
                                    <div class="MemoStyle1" style="display: inline; width: 472px; height: 19px">
                                        在DataGrid中，生成功能列&lt;删除&gt;，单击后可以触发删除记录的事件过程</div>
                                </div>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 124px">
                                <asp:CheckBox ID="chkIsHaveDetailBtn" runat="server"
                                    Text="是否有详细按钮" CssClass="Check_Defa"></asp:CheckBox></td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 472px; height: 19px">
                                    在DataGrid中，生成功能列&lt;详细信息&gt;，可以触发显示详细信息的事件过程</div>
                            </td>
                            <td>
                            </td>
                        </tr>
                    </table>
                </div>
            </font>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <div style="width: 632px; position: relative; height: 225px">
                <asp:Label ID="Label12" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
                    CssClass="RegionTitleH3" runat="server" Width="616px">5、DataGrid的大小、位置</asp:Label>
                <table id="Table3" style="z-index: 103; left: 16px; width: 616px; position: absolute;
                    top: 32px; height: 77px" cellspacing="1" cellpadding="1" width="616" border="0">
                    <tr>
                        <td style="width: 124px">
                            <asp:Label ID="lblWidth" runat="server" CssClass="text-secondary">宽</asp:Label></td>
                        <td>
                            
                                <asp:TextBox ID="txtWidth" runat="server"
                                    Width="120px"></asp:TextBox>
                                <asp:CompareValidator ID="ComValid_Width"
                                    runat="server" EnableClientScript="false" Operator="DataTypeCheck" Type="Integer"
                                    ControlToValidate="txtWidth" ErrorMessage="请输入整型数值!" CssClass="text-warning"></asp:CompareValidator></font></td>
                        <td>
                            <div class="MemoStyle1" style="display: inline; width: 168px; height: 21px">
                                DataGrid的宽度</div>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 124px">
                            <asp:Label ID="lblHeight" runat="server" CssClass="text-secondary">高度</asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtHeight" runat="server"
                                Width="120px"></asp:TextBox>
                            <asp:CompareValidator ID="ComValid_Height"
                                runat="server" EnableClientScript="false" Operator="DataTypeCheck" Type="Integer"
                                ControlToValidate="txtHeight" ErrorMessage="请输入整型数值!" CssClass="text-warning"></asp:CompareValidator></td>
                        <td>
                            <div class="MemoStyle1" style="display: inline; width: 168px; height: 15px">
                                DataGrid的高度</div>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 124px">
                            
                                <asp:Label ID="lblStyle_Zindex" runat="server" CssClass="text-secondary">Style_Zindex</asp:Label></font></td>
                        <td>
                            <asp:TextBox ID="txtStyle_Zindex" runat="server"
                                Width="120px"></asp:TextBox>
                            <asp:CompareValidator ID="ComValid_Style_Zindex"
                                runat="server" EnableClientScript="false" Operator="DataTypeCheck" Type="Integer"
                                ControlToValidate="txtStyle_Zindex" ErrorMessage="请输入整型数值!" CssClass="text-warning"></asp:CompareValidator></td>
                        <td>
                            <div class="MemoStyle1" style="display: inline; width: 168px; height: 15px">
                                说明</div>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 124px">
                            <asp:Label ID="lblStyle_Position" runat="server" CssClass="text-secondary">Style_Position</asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtStyle_Position" runat="server"
                                Width="120px"></asp:TextBox></td>
                        <td>
                            <div class="MemoStyle1" style="display: inline; width: 220px; height: 32px">
                                DataGrid的位置类型：绝对、相对等</div>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 124px">
                            <asp:Label ID="lblStyle_Left" runat="server" CssClass="text-secondary">Style_Left</asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtStyle_Left" runat="server"
                                Width="120px"></asp:TextBox>
                            <asp:CompareValidator ID="ComValid_Style_Left"
                                runat="server" EnableClientScript="false" Operator="DataTypeCheck" Type="Integer"
                                ControlToValidate="txtStyle_Left" ErrorMessage="请输入整型数值!" CssClass="text-warning"></asp:CompareValidator></td>
                        <td>
                            <div class="MemoStyle1" style="display: inline; width: 168px; height: 15px">
                                DataGrid的距左页边的距离</div>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 124px">
                            <asp:Label ID="lblStyle_Top" runat="server" CssClass="text-secondary">Style_Top</asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtStyle_Top" runat="server"
                                Width="120px"></asp:TextBox>
                            <asp:CompareValidator ID="ComValid_Style_Top"
                                runat="server" EnableClientScript="false" Operator="DataTypeCheck" Type="Integer"
                                ControlToValidate="txtStyle_Top" ErrorMessage="请输入整型数值!" CssClass="text-warning"></asp:CompareValidator></td>
                        <td>
                            <div class="MemoStyle1" style="display: inline; width: 168px; height: 15px">
                                DataGrid的距上页边的距离</div>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 124px">
                        </td>
                        <td>
                        </td>
                        <td>
                            
                        </td>
                        <td>
                        </td>
                    </tr>
                </table>
            </div>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            
                <div style="width: 632px; position: relative; height: 117px">
                    <asp:Label ID="Label19" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
                        CssClass="RegionTitleH3" runat="server" Width="616px">6、其他属性</asp:Label>
                    <table id="Table4" style="z-index: 103; left: 16px; width: 616px; position: absolute;
                        top: 32px; height: 24px" cellspacing="1" cellpadding="1" width="616" border="0">
                        <tr>
                            <td style="width: 145px">
                                <asp:CheckBox ID="chkIsInTab" runat="server"
                                    Text="是否生成DG在表中" CssClass="Check_Defa"></asp:CheckBox></td>
                            <td>
                            </td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 254px; height: 15px">
                                    DataGrid是否放在一个表格中。</div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 145px">
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                        </tr>
                    </table>
                </div>
            </font>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
        </td>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" >说明</asp:Label>
        </td>
        <td colspan="3">
            
                <asp:TextBox ID="txtMemo" runat="server" 
                    Width="402px" Height="74px" TextMode="MultiLine"></asp:TextBox></font></td>
    </tr>
    <tr>
        <td width="120">
            
        </td>
        <td width="150" colspan="1" rowspan="1">
            
        </td>
        <td width="150">
            
        </td>
        <td width="150" colspan="1" rowspan="1">
        </td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
    <tr>
        <td>
            <asp:Label ID="lblStyle" runat="server"  CssClass="col-form-label text-right"
                >类型</asp:Label></td>
        <td>
            <asp:TextBox ID="txtStyle" runat="server"
                Visible="False"></asp:TextBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
