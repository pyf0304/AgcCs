<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvCMRequirement4DL.ascx.cs" Inherits="AGC.Webform.wucvCMRequirement4DL" %>

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
        <asp:DataList ID="dlCMRequirement" runat="server" DataKeyField="ReqId" OnItemDataBound="dlCMRequirement_ItemDataBound"
            Width="1000px" OnItemCommand="dlCMRequirement_ItemCommand" OnSelectedIndexChanged="dlCMRequirement_SelectedIndexChanged">
            <ItemTemplate>
                <table style="width: 1203px; border-bottom-color: brown; border-spacing:inherit" id="tabT<%# DataBinder.Eval(Container.DataItem, "ReqId")%>" border="1" class="mt-2">

                    <tr>
                        <td style="width: 60px;" class="ErrMsg" valign="top">
                            <asp:Label ID="Label3" runat="server" Text="需求名" CssClass="text-primary text-nowrap"></asp:Label>
                        </td>
                        <td id="td3" style="width: 800px;" class="ValueTD" runat="server">
                            <div>
                                <div class="float-left" style="width: 50%">
                                    <%#   DataBinder.Eval(Container.DataItem, " RequirementName")%> (<%#   DataBinder.Eval(Container.DataItem, "ReqId")%>)     
                       
                                </div>
                                <div class="float-right" style="width: 50%">
                                    <ul class="nav">


                                        <li class="nav-item ml-3">
                                            <asp:Button ID="btnClone" CommandArgument='<%# Eval("ReqId") %>' CommandName="Clone" runat="server"
                                                CssClass="btn btn-outline-info btn-sm" Text="克隆"></asp:Button>
                                        </li>

                                        <li class="nav-item ml-3">
                                            <asp:Button ID="btnDelete" CommandArgument='<%# Eval("ReqId") %>' CommandName="Delete" runat="server"
                                                CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                                        </li>
                                        <li class="nav-item ml-3">
                                            <asp:Button ID="btnUpdate" CommandArgument='<%# Eval("ReqId") %>' CommandName="Update" runat="server"
                                                CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                                        </li>

                                    </ul>
                                </div>
                            </div>

                        </td>
                    </tr>
                    <tr>
                        <td style="width: 10px; height: 22px" class="ErrMsg" valign="top">
                            <asp:Label ID="Label4" runat="server" Text="工程" CssClass="text-primary text-nowrap"></asp:Label>
                        </td>
                        <td id="td4" style="width: 800px;" class="code" runat="server">
                            <ul class="nav">
                                <li class="nav-item">
                                    <code>
                                        <%#   DataBinder.Eval(Container.DataItem, "CmPrjName")%>
                                    </code>
                                </li>
                                <li class="nav-item ml-3">模块:</li>
                                <li class="nav-item ml-1">
                                    <%#   DataBinder.Eval(Container.DataItem, "FuncModuleName")%>
                                </li>
                                <li class="nav-item ml-3">应用:</li>
                                <li class="nav-item ml-1">
                                    <%#   DataBinder.Eval(Container.DataItem, "ApplicationTypeSimName")%>
                                </li>
                                <li class="nav-item ml-3">用户:</li>
                                <li class="nav-item ml-1">
                                    <%#   DataBinder.Eval(Container.DataItem, "UpdUser")%>
                                </li>
                                <li class="nav-item ml-3">日期:</li>
                                <li class="nav-item ml-1">
                                    <%#   DataBinder.Eval(Container.DataItem, "UpdDate")%>
                                </li>
                                <li class="nav-item ml-3"></li>
                            </ul>
                        </td>
                    </tr>
                  
                    <tr>
                        <td style="width: 50px; height: 22px" class="ErrMsg" valign="top">
                            <asp:Label ID="Label2" runat="server" Text="需求内容" CssClass="text-primary font-weight-bold text-nowrap"></asp:Label>
                        </td>
                        <td id="td1" style="width: 1500px;" class="text-info" runat="server">
                            <%--<pre>--%>
                            <code class="text-info">
                                <%# DataBinder.Eval(Container.DataItem, "ReqContent")%>
                            </code>
                            <%--</pre>--%>

                        </td>
                    </tr>

                </table>
            </ItemTemplate>
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

