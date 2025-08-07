<%@ Register TagPrefix="uc1" TagName="wucQryRegionFlds" Src="wucQryRegionFlds.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmPreviewViewRegion.aspx.cs" AutoEventWireup="True"
    ValidateRequest="FALSE" Inherits="AGC.Webform.wfmPreviewViewRegion" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>表QryRegionFlds的查询、修改、删除、添加记录</title>
    
      <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
      <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <div id="divQryRegionFlds" style="z-index: 102; left: 8px; width: 792px; position: absolute;
            top: 35px; height: 32px" runat="server">
            <asp:Label ID="lblRegionIdq" Style="z-index: 101; left: 8px; position: absolute;
                top: 8px" runat="server" CssClass="text-secondary">
  界面名称</asp:Label>
            <asp:Button ID="btnQuery" Style="z-index: 106; left: 704px; position: absolute; top: 8px"
                runat="server"  Text="查询" OnClick="btnQuery_Click"></asp:Button>
            <asp:Label ID="lblViewName" Style="z-index: 107; left: 80px; position: absolute;
                top: 8px" runat="server" CssClass="ValueLabelH1"></asp:Label>
        </div>
        <asp:Label ID="lblMsg" Style="z-index: 111; left: 272px; position: absolute; top: 16px"
            runat="server" CssClass="text-warning" Width="272px"></asp:Label>
        <table id="Table1" style="z-index: 104; left: 8px; position: absolute; top: 88px"
            cellspacing="0" cellpadding="0" width="300" border="0">
            <tr>
                <td>
                    <table id="tabQryRegionPreview" cellspacing="1" cellpadding="1" width="300" border="1"
                        runat="server">
                        <tr>
                            <td>
                                <div style="width: 808px; position: relative; height: 24px">
                                    <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                        height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776" />
                                    <asp:Label ID="Label1" Style="z-index: 109; left: 8px; position: absolute; top: 8px"
                                        runat="server" CssClass="h6">查询区域预览</asp:Label>
                                </div>
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div id="Div1" style="width: 720px;" runat="server">
                                    <asp:PlaceHolder ID="phQryRegion" runat="server"></asp:PlaceHolder>
                                </div>
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
                </td>
            </tr>
            <tr>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabDGRegionPreview" cellspacing="1" cellpadding="1" width="300" border="1"
                        runat="server">
                        <tr>
                            <td>
                                <div style="width: 808px; position: relative; height: 24px">
                                    <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                        height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776" />
                                    <asp:Label ID="Label2" Style="z-index: 109; left: 8px; position: absolute; top: 8px"
                                        runat="server" CssClass="h6">列表区域预览</asp:Label>
                                </div>
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div id="Div2" style="width: 720px;" runat="server">
                                    <asp:PlaceHolder ID="phDataGrid" runat="server"></asp:PlaceHolder>
                                </div>
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
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabListViewRegionPreview" cellspacing="1" cellpadding="1" width="300"
                        border="1" runat="server">
                        <tr>
                            <td>
                                <div style="width: 808px; position: relative; height: 24px">
                                    <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                        height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776" />
                                    <asp:Label ID="Label6" Style="z-index: 109; left: 8px; position: absolute; top: 8px"
                                        runat="server" CssClass="h6">ListView区域预览</asp:Label>
                                </div>
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div id="Div4" style="width: 720px;" runat="server">
                                    <asp:PlaceHolder ID="phListView" runat="server"></asp:PlaceHolder>
                                </div>
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
                </td>
            </tr>
            <tr>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditRegionPreview" cellspacing="1" cellpadding="1" width="300" border="1"
                        runat="server">
                        <tr>
                            <td>
                                <div style="width: 808px; position: relative; height: 24px">
                                    <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                        height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776" />
                                    <asp:Label ID="Label3" Style="z-index: 109; left: 8px; position: absolute; top: 8px"
                                        runat="server" CssClass="h6">编辑区域预览</asp:Label>
                                </div>
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div id="Div3" style="width: 720px;" runat="server">
                                    <asp:PlaceHolder ID="phEditRegion" runat="server"></asp:PlaceHolder>
                                </div>
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
                </td>
            </tr>
            <tr>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabDetailRegionPreview" cellspacing="1" cellpadding="1" width="300" border="1"
                        runat="server">
                        <tr>
                            <td>
                                <div style="width: 808px; position: relative; height: 24px">
                                    <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                        height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776" />
                                    <asp:Label ID="Label4" Style="z-index: 109; left: 8px; position: absolute; top: 8px"
                                        runat="server" CssClass="h6">详细信息区域预览</asp:Label>
                                </div>
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div id="divQryRegionPreview" style="width: 720px;"
                                    runat="server">
                                    <asp:PlaceHolder ID="phDetailRegion" runat="server"></asp:PlaceHolder>
                                </div>
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
                </td>
            </tr>
            <tr>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabExcelExportRegionPreview" cellspacing="1" cellpadding="1" width="300"
                        border="1" runat="server">
                        <tr>
                            <td>
                                <div style="width: 808px; position: relative; height: 24px">
                                    <img style="z-index: 108; left: 0px; width: 776px; position: absolute; top: 0px;
                                        height: 2px" height="2" alt="" src="../../pic/兰色直线1.gif" width="776" />
                                    <asp:Label ID="Label7" Style="z-index: 109; left: 8px; position: absolute; top: 8px"
                                        runat="server" CssClass="h6">Excel导出区域预览</asp:Label>
                                </div>
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div id="Div5" style="width: 720px;" runat="server">
                                    <asp:PlaceHolder ID="phExcelExportRegion" runat="server"></asp:PlaceHolder>
                                </div>
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
                </td>
            </tr>
            <tr>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabCode" style="width: 816px; height: 551px" cellspacing="1" cellpadding="1"
                        width="816" border="1" runat="server">
                        <tr>
                            <td colspan="2">
                                <div style="width: 800px; position: relative; height: 32px">
                                    <asp:Label ID="lblCaption4GenCode" Style="z-index: 101; left: 8px; position: absolute;
                                        top: 8px" runat="server" Font-Names="宋体"  Font-Size="Smaller" Width="120px">生成的逻辑层代码：</asp:Label>
                                    <asp:LinkButton ID="lbDispTabList" Style="z-index: 102; left: 664px; position: absolute;
                                        top: 8px" runat="server">显示界面列表</asp:LinkButton>
                                    <asp:Label ID="Label5" Style="z-index: 103; left: 152px; position: absolute; top: 8px"
                                        runat="server"  >生成文件名：</asp:Label>
                                    <asp:TextBox ID="txtFileName4GenCode" Style="z-index: 104; left: 248px; position: absolute;
                                        top: 8px" runat="server"  Width="336px"></asp:TextBox>
                                    <asp:LinkButton ID="lbDownLoadFile" Style="z-index: 111; left: 600px; position: absolute;
                                        top: 8px" runat="server"  Width="56px">下载文件</asp:LinkButton>
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
            </tr>
        </table>
        <asp:Label ID="lblViewTile" runat="server" Font-Bold="True" Style="z-index: 110;
            left: 8px; position: absolute; top: 8px" CssClass="h5">界面分区域预览</asp:Label>
        <asp:LinkButton ID="btnGoBack" Style="z-index: 111; left: 784px; position: absolute;
            top: 8px" runat="server"   Text="返回" OnClick="btnGoBack_Click"></asp:LinkButton>
    </form>
</body>
</html>
