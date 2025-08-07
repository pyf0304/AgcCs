<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvCMFunction4DL.ascx.cs" Inherits="AGC.Webform.wucvCMFunction4DL" %>

    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>

    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>

<div id="divList" class="div_List" runat="server" style="width: 100%">
     <div style="padding: 10px">
                       
                        <span style="background-color: #c0c0c0; margin-left: 200px; margin-top: 10px;">共有记录:</span>
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
    <asp:DataList ID="dlCMFunction" runat="server" DataKeyField="CMFunctionId" OnItemDataBound="dlCMFunction_ItemDataBound"
        Width="1000px" OnItemCommand="dlCMFunction_ItemCommand" OnSelectedIndexChanged="dlCMFunction_SelectedIndexChanged">
        <ItemTemplate>
            <table style="width: 1203px; border-bottom-color:brown" id="tabT<%# DataBinder.Eval(Container.DataItem, "CMFunctionId")%>"  border="1">
               
                <tr>
                    <td style="width: 60px; " class="ErrMsg" valign="top">
                        <asp:Label ID="Label3" runat="server" Text="函数名" CssClass="NameLabel2"></asp:Label>
                    </td>
                    <td id="td3" style="width: 800px;" class="ValueTD" runat="server">
                        <div>
                            <div class="float-left" style="width:50%">
                                  <ul class="nav">
                            <li class="nav-item">
                                  <%#   DataBinder.Eval(Container.DataItem, "FunctionName")%> (<%#   DataBinder.Eval(Container.DataItem, "CMFunctionId")%>)     
                         </li>
                                      <li class="nav-item ml-3">修改日期:</li>
                            <li class="nav-item ml-1">  
                                <%#   DataBinder.Eval(Container.DataItem, "UpdDate")%>
                            </li>

                                <li class="nav-item ml-3">
                                          </li>
                                                 <li class="nav-item ml-3">
                                          </li>
                                         <li class="nav-item ml-3">
                                          </li>
                            </ul>
                            </div>
                            <div class="float-right" style="width:50%">
                                              <ul class="nav">
                               
                                
                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnClone" CommandArgument='<%# Eval("CMFunctionId") %>' CommandName="Clone" runat="server" 
                                        CssClass="btn btn-outline-info btn-sm" Text="克隆"></asp:Button>
                                </li>

                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnDelete"  CommandArgument='<%# Eval("CMFunctionId") %>' CommandName="Delete" runat="server"
                                        CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                                </li>
                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnUpdate"  CommandArgument='<%# Eval("CMFunctionId") %>' CommandName="Update" runat="server"
                                        CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                                </li>


                                <li class="nav-item ml-3">
                                    <asp:Button ID="btnEditPara"  CommandArgument='<%# Eval("CMFunctionId") %>' CommandName="EditPara" runat="server"
                                        CssClass="btn btn-outline-info btn-sm" Text="编辑参数"></asp:Button>
                                </li>
                                                                
                            </ul>
                            </div>
                        </div>
                           
                    </td>
                </tr>
                  <tr>
                    <td style="width: 10px; height: 22px" class="ErrMsg" valign="top">
                        <asp:Label ID="Label4" runat="server" Text="相关类" CssClass="NameLabel2"></asp:Label>
                    </td>
                    <td id="td4" style="width: 800px;" class="code" runat="server">
                        <ul class="nav">
                            <li class="nav-item">
                                <code>
                                    <%#   DataBinder.Eval(Container.DataItem, "ClassName")%>
                                </code>
                            </li>
                            <li class="nav-item ml-3">域名:</li>
                            <li class="nav-item ml-1">  
                                <%#   DataBinder.Eval(Container.DataItem, "NameSpace")%>
                            </li>
                              <li class="nav-item ml-3">工程:</li>
                            <li class="nav-item ml-1">                                    
                                <%#   DataBinder.Eval(Container.DataItem, "PrjName")%>
                            </li>
                              <li class="nav-item ml-3">用户:</li>
                            <li class="nav-item ml-1">                                    
                                <%#   DataBinder.Eval(Container.DataItem, "UserId")%>
                            </li>
                              <li class="nav-item ml-3">文件:</li>
                            <li class="nav-item ml-1">                                    
                                <%#   DataBinder.Eval(Container.DataItem, "FileName")%>
                            </li>
                              <li class="nav-item ml-3">路径:</li>
                            <li class="nav-item ml-1">                                    
                                <%#   DataBinder.Eval(Container.DataItem, "FilePath")%>
                            </li>
                            <li class="nav-item ml-3"></li>
                        </ul>
                    </td>
                </tr>
                  <tr>
                    <td style="width: 10px; height: 22px" class="ErrMsg" valign="top">
                        <asp:Label ID="Label5" runat="server" Text="关键字" CssClass="NameLabel2"></asp:Label>
                    </td>
                    <td id="td5" style="width: 800px;" class="text-primary" runat="server">
                     <%--   <pre>--%>
                              <code class="text-primary">
                            <%#   DataBinder.Eval(Container.DataItem, "KeyWords")%>
                                  </code>
                        <%--</pre>--%>

                    </td>
                </tr>
                <tr>
                    <td style="width: 10px; height: 22px" class="ErrMsg" valign="top">
                        <asp:Label ID="Label1" runat="server" Text="函数注释" CssClass="NameLabel2"></asp:Label>
                    </td>
                    <td id="td2" style="width: 800px;" class="text-primary" runat="server">
                     <%--   <pre>--%>
                              <code class="text-primary">
                            <%#   DataBinder.Eval(Container.DataItem, "FuncComments")%>
                                  </code>
                        <%--</pre>--%>

                    </td>
                </tr>

                <tr>
                    <td style="width: 50px; height: 22px" class="ErrMsg" valign="top">
                        <asp:Label ID="Label2" runat="server" Text="函数内容" CssClass="NameLabel2"></asp:Label>
                    </td>
                    <td id="td1" style="width: 1500px;" class="text-info" runat="server">
                        <%--<pre>--%>
                            <code class="text-info">
                            <%# DataBinder.Eval(Container.DataItem, "FuncContent")%>
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

