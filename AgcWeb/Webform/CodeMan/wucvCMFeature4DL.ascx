<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvCMFeature4DL.ascx.cs" Inherits="AGC.Webform.wucvCMFeature4DL" %>

<script type="text/javascript" src="../../JS/tzPubFun.js"></script>

<script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
<style type="text/css">
    body {
        /*font-size: 0.875rem;*/
    }
</style>

<div id="divList" class="div_List" runat="server" style="width: 100%">
    <div style="padding: 10px">
       
        <span style="background-color: #c0c0c0; margin-left: 400px; margin-top: 10px;">共有记录:</span>
        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="36px">0</asp:Label>
        <span style="background-color: #c0c0c0; width: 16px;"></span><span style="background-color: #c0c0c0">总页数:</span>
        <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
        <div style="display: inline; width: 16px; height: 13px">
        </div>
        <span style="background-color: #c0c0c0;">当前页:</span>
        <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>

        <asp:LinkButton ID="lbFirstPage" OnCommand="IndexChanging" CommandArgument="FirstPage" runat="server">[首页]</asp:LinkButton>
        <asp:LinkButton ID="lkPre" OnCommand="IndexChanging" CommandArgument="pre" runat="server">[前一页]</asp:LinkButton>
        <asp:LinkButton ID="lkNext" OnCommand="IndexChanging" CommandArgument="next" runat="server">[下一页]</asp:LinkButton>
        <asp:LinkButton ID="lbLastPage" OnCommand="IndexChanging" CommandArgument="LastPage" runat="server">[尾页]</asp:LinkButton>

    </div>
    <div>
        <asp:DataList ID="dlCMFeature" runat="server" DataKeyField="CmFeatureId" OnItemDataBound="dlCMFeature_ItemDataBound" OnItemCommand="dlCMFeature_ItemCommand" OnSelectedIndexChanged="dlCMFeature_SelectedIndexChanged" BorderStyle="None" >
            <HeaderTemplate>
                <table style="width: 1203px; border-bottom-color: brown; border-collapse:collapse; " id="tabT<%# DataBinder.Eval(Container.DataItem, "CmFeatureId")%>" border="0" class="mt-4">
            </HeaderTemplate>

            
            <ItemStyle CssClass="border-0" />

            
            <ItemTemplate>
                <asp:Literal ID="litTR4FuncModule" runat="server"></asp:Literal>

                <tr style="border:1px" >
                    <td style="border:solid; border-width:1px; width: 60px; vertical-align: top; text-align:right" class="text-success mr-2">
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("CMFeatureNameTitle")%>' CssClass="text-primary text-nowrap mr-1"></asp:Label>
                    </td>
                    <td id="td3" style="border:solid; border-width:1px; width: 800px;" class="ValueTD" runat="server">
                        <div>
                            <div class="float-left" style="width: 65%">
                                <asp:Literal ID="litTR" runat="server"></asp:Literal>
                            </div>
                            <div class="float-right" style="width: 35%; text-align:right">
                                <ul class="nav">
                                    <li class="nav-item ml-3">
                                        <div class="btn-group" role="group" aria-label="Basic example">
                                            <asp:Button ID="btnClone" CommandArgument='<%# Eval("CmFeatureId") %>' CommandName="Clone" runat="server"
                                                CssClass="btn btn-outline-info btn-sm" Text="克隆"></asp:Button>
                                            <asp:Button ID="btnDelete" CommandArgument='<%# Eval("CmFeatureId") %>' CommandName="Delete" runat="server"
                                                CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                                            <asp:Button ID="btnUpdate" CommandArgument='<%# Eval("CmFeatureId") %>' CommandName="Update" runat="server"
                                                CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                                 <%--       </div>
                                    </li>
                                    <li class="nav-item ml-2">
                                        <div class="btn-group" role="group" aria-label="Basic example">--%>
                                            <asp:Button ID="btnGoTop" CommandArgument='<%# Eval("CmFeatureId") %>' CommandName="GoTop" runat="server" Text="移顶" CssClass="btn btn-outline-info btn-sm" />
                                            <asp:Button ID="btnUpMove" CommandArgument='<%# Eval("CmFeatureId") %>' CommandName="UpMove" runat="server" Text="上移" CssClass="btn btn-outline-info btn-sm ml-1" />
                                            <asp:Button ID="btnDownMove" CommandArgument='<%# Eval("CmFeatureId") %>' CommandName="DownMove" runat="server" Text="下移" CssClass="btn btn-outline-info btn-sm ml-1" />
                                            <asp:Button ID="btnGoBottum" CommandArgument='<%# Eval("CmFeatureId") %>' CommandName="GoBottum" runat="server" CssClass="btn btn-outline-info btn-sm ml-1" Text="移底" />
<%--                                            <asp:Button ID="btnReOrder" CommandArgument='<%# Eval("CmFeatureId") %>' CommandName="ReOrder" runat="server" Text="重序" CssClass="btn btn-outline-info btn-sm ml-1" />--%>

                                        </div>
                                    </li>
                                </ul>
                            </div>
                        </div>

                    </td>
                </tr>

                <tr class="mt-1 mb-2">
                    <td style="width: 55px; vertical-align: top; text-align:right" class="mt-2">
                        <div class="ml-2 mt-1 mb-2">
                        <asp:Label ID="Label2" runat="server" Text="说明" CssClass="text-primary text-nowrap mr-1"></asp:Label>
                            </div>
                    </td>
                    <td id="td1" style="width: 1500px;" class="text-secondary" runat="server">
                        <div style="width:80%" class="ml-2 mt-1 mb-1">                        
                            <%# DataBinder.Eval(Container.DataItem, "FeatureDescription")%>                        
                        </div>

                    </td>
                </tr>
                 <asp:Literal ID="litRelaRequirement" runat="server"></asp:Literal>

            </ItemTemplate>
       
            <EditItemStyle CssClass=" border-0" />
       
            <FooterTemplate>
                </table>
            </FooterTemplate>
         
        </asp:DataList>

    </div>
    <div style="height: 40px;">
        <span style="background-color: #c0c0c0; margin-left: 200px">共有记录::</span>
        <asp:Label ID="lblRecCount2" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="36px">0</asp:Label>
        <span style="background-color: #c0c0c0; width: 16px;"></span><span style="background-color: #c0c0c0">总页数:</span>
        <asp:Label ID="lblAllPages2" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
        <div style="display: inline; width: 16px; height: 13px">
        </div>
        <span style="background-color: #c0c0c0;">当前页:</span>
        <asp:Label ID="lblCurrentPage2" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>

        <asp:LinkButton ID="LinkButton2" OnCommand="IndexChanging" CommandArgument="FirstPage" runat="server">[首页]</asp:LinkButton>
        <asp:LinkButton ID="LinkButton3" OnCommand="IndexChanging" CommandArgument="pre" runat="server">[前一页]</asp:LinkButton>
        <asp:LinkButton ID="LinkButton4" OnCommand="IndexChanging" CommandArgument="next" runat="server">[下一页]</asp:LinkButton>
        <asp:LinkButton ID="LinkButton5" OnCommand="IndexChanging" CommandArgument="LastPage" runat="server">[尾页]</asp:LinkButton>
        <br />
        <div style="display: inline; width: 16px; height: 23px">
        </div>

    </div>
</div>

