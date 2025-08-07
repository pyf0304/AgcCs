<%@ Register TagPrefix="uc1" TagName="DataNode_Edit" Src="DataNode_Edit.ascx" %>
<%@ Register TagPrefix="uc2" TagName="DataNode4Gv" Src="DataNode4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true" CodeBehind="DataNode_QUDI.aspx.cs" Inherits="AGC.Webform.DataNode_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>数据结点维护的维护</title>
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
</head>
<body>
    <form id="form1" runat="server" class="form-horizontal">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">数据结点维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabEdit" style="width: 70%" class="table table-bordered table-hover table td table-sm">
                    <tr>
                           <td style="text-align: right;">
                        <asp:Label ID="Label2" runat="server" CssClass="text-info  font-weight-bold " Width="70px">CM项目</asp:Label>
                    </td>
                    <td >
                        <asp:DropDownList ID="ddlCmPrjIdq" runat="server" CssClass="text-danger  font-weight-bold" OnSelectedIndexChanged="ddlCmPrjId_q_SelectedIndexChanged" AutoPostBack="true" Width="120px">                        </asp:DropDownList>
                        
                    </td>
                        <td class="text-left">
                            <asp:Label ID="lblDataNodeIdq" name="lblDataNodeIdq" CssClass="col-form-label text-right" Width="50px" Text="结点Id" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:TextBox ID="txtDataNodeIdq" name="txtDataNodeIdq" CssClass="form-control" Width="80px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblDataNodeNameq" name="lblDataNodeNameq" CssClass="col-form-label text-right" Width="50px" Text="结点名" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:TextBox ID="txtDataNodeNameq" name="txtDataNodeNameq" CssClass="form-control" Width="120px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblTabIdq" name="lblTabIdq" CssClass="col-form-label text-right" Width="30px" Text="表" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlTabIdq" name="ddlTabIdq" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblFldIdq" name="lblFldIdq" CssClass="col-form-label text-right" Width="40px" Text="字段" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlFldIdq" name="ddlFldIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>

                        <td class="text-left">
                            <asp:Label ID="lblDataNodeTypeIdq" name="lblDataNodeTypeIdq" CssClass="col-form-label text-right" Width="70px" Text="结点类型" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlDataNodeTypeIdq" name="ddlDataNodeTypeIdq" CssClass="form-control" Width="120px" runat="server" />
                        </td>

                        <td class="text-left">
                            <asp:Label ID="Label1" name="lblDataNodeTypeIdq" CssClass="col-form-label text-right" Width="50px" Text="子图名" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlSubGraphNameq" name="ddlDataNodeTypeIdq" CssClass="form-control" Width="140px" runat="server" />
                        </td>


                        

                        <td class="text-left">
                            <asp:Button ID="btnQuery" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnQuery_Click" Text="查询" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Button ID="btnExportExcel" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="table table-bordered table-hover">
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="lblDataNodeList" name="lblDataNodeList" CssClass="col-form-label text-info" Width="250px" Text="数据结点列表" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecordWithMaxId" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnAddNewRecordWithMaxId_Click" Text="添加" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnCopyRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnCopyRecord_Click" Text="复制新版本" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnUpdateRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnDelRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                    </li>

                    <li class="nav-item ml-3">
                        <asp:Button ID="btnImportNode4KeyAndName" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnImportNode4KeyAndName_Click" Text="导入关键结点与名称结点" runat="server" />
                    </li>

                    <li class="nav-item ml-3">
                        <asp:Button ID="btnImportSameSourceBy4KeyNode" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnImportSameSourceBy4KeyNode_Click" Text="导入关键结点的同源结点" runat="server" />
                    </li>
                        <li class="nav-item ml-3">
                        <asp:Button ID="btnGetAllConnectedSubGroup" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnGetAllConnectedSubGroup_Click" Text="获取所有连通子图" runat="server" />
                    </li>
                      <li class="nav-item ml-3">
                          <asp:Button ID="btnImportNode4TabId" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnImportNode4TabId_Click" Text="导入查询表中所有字段" runat="server" />
                    
                    </li>

                    <li class="nav-item ml-3">
                        <asp:TextBox ID="txtStartNode" placehold="开始结点" runat="server" Width="110px"></asp:TextBox>
                        <asp:Button ID="btnSetStartNode" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnSetStartNode_Click" Text="设置开始结点" runat="server" />

                    </li>
                    <li class="nav-item ml-3">
                        <asp:TextBox ID="txtEndNode" placehold="结束结点" runat="server" Width="112px"></asp:TextBox>
                        <asp:Button ID="btnSetEndNode" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnSetEndNode_Click" Text="设置结束结点" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnGetGraphPath" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnGetGraphPath_Click" Text="获取图的路径" runat="server" />
                        <asp:DropDownList ID="ddlGraphPath" runat="server" Width="109px"></asp:DropDownList>
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnGetConnectedNode" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnGetConnectedNode_Click" Text="根据起点获取连通结点路径" runat="server" />
                        <asp:DropDownList ID="ddlConnectedNode" runat="server" Width="129px" AutoPostBack="True" OnSelectedIndexChanged="ddlConnectedNode_SelectedIndexChanged"></asp:DropDownList>

                    </li>
                      <li class="nav-item ml-3">
                        <asp:Button ID="btnGetConnectedNodeByEndNode" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnGetConnectedNodeByEndNode_Click" Text="根据终点获取连通结点路径" runat="server" />
                        <asp:DropDownList ID="ddlConnectedNodeByEndNode" runat="server" Width="129px" AutoPostBack="True" OnSelectedIndexChanged="ddlConnectedNodeByEndNode_SelectedIndexChanged"></asp:DropDownList>

                    </li>
                    <li class="nav-item ml-3">
                        <asp:DropDownList ID="ddlConnectedNode4TabId" runat="server" Width="129px" AutoPostBack="True" OnSelectedIndexChanged="ddlConnectedNode4TabId_SelectedIndexChanged"></asp:DropDownList>

                    </li>
                                        <li class="nav-item ml-3">
                          <div class="btn-group" role="group" aria-label="Basic example">
                      <asp:Button ID="btnCopyTo" CssClass="btn btn-outline-info text-nowrap" OnClick="btnCopyTo_Click" Text="复制到" runat="server" />
                            <asp:DropDownList ID="ddlCmPrjId_Copy" CssClass="form-control-sm" Width="150px" runat="server" />
                                 </div>
                                            
                    </li>
                </ul>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:DataNode4Gv runat="server" ID="DataNode4Gv1"
                    OnGvUpdateClick="DataNode4Gv1_GvUpdateClick"
                    OnGvDeleteClick="DataNode4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditDataNodeRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditDataNode" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">数据结点编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelDataNodeEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelDataNodeEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:DataNode_Edit ID="DataNode_Edit1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
