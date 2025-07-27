<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmCMFunction_QUDI.aspx.cs" 
    Inherits="AGC.Webform.wfmCMFunction_QUDI" ValidateRequest="false"  %>
<%@ Register TagPrefix="uc1" TagName="wucCMFunction" Src="wucCMFunction.ascx" %>

<%@ Register Src="wucvCMFunction4GV.ascx" TagName="wucvCMFunction4GV" TagPrefix="uc2" %>
<%@ Register Src="~/Webform/CodeMan/wucvCMFunction4GV.ascx" TagPrefix="uc1" TagName="wucvCMFunction4GV" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>函数名4Code维护的维护</title>  
      <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>

<%--    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />--%>
  
    <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
    <script>
        function ClearText(txtCode) {
            var txtCode = getObjByTagAndId("textarea", "txtCode");
            if (txtCode != null) {
                txtCode.value = "";
            }
        }
        function SetStyle4Full() {
            var divLeft = document.getElementById("divLeft");
            if (divLeft == null) return;
            //            divLeft.style = "width:60%; float:left";
            divLeft.style.width = "100%;";
            var divRight = document.getElementById("divRight");
            if (divRight == null) return;
            Tz_HideDiv("divRight");
            console.log("SetStyle4Full");
        }
        function SetStyle4Half() {
            var divLeft = document.getElementById("divLeft");
            if (divLeft == null) return;
            //            divLeft.style = "width:60%; float:left";
            divLeft.style.width = "55%";
            divLeft.style.float = "left";

            var divRight = document.getElementById("divRight");
            if (divRight == null) return;
            Tz_ShowDiv("divRight");
            console.log("SetStyle4Half");
        }

    </script>


    <script type="text/javascript">
 
        function validate() {
 
            var text = document.getElementById("TextBox1").value;
            console.log(text);
            var testArray = text.split('');
 
           
 
            var flag = 0;
 
            for (var a in testArray) {
 
               
 
                if (testArray[a] == '<') {
 
                    testArray[a] = '&lt'//convert it to the legitimate string 
 
                }
 
 
 
                if (testArray[a] == '>') {
 
                    testArray[a] = '&gt'
 
                }
 
            }
 
            document.getElementById("TextBox1").value = testArray.join('');
 
            document.getElementById("HiddenField1").value = testArray.join('');
 
            return true;
 
        }
 
  </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5">函数名4Code维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td>
                            <asp:Label ID="lblCmFunctionIdq"
                                runat="server" CssClass="text-secondary">函数Id</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCmFunctionIdq"
                                runat="server" CssClass="form-control-sm">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblFunctionNameq"
                                runat="server" CssClass="text-secondary">函数名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFunctionNameq"
                                runat="server" Width="200px" CssClass="form-control-sm">
                            </asp:TextBox>
                        </td>
                                                                                           
                        <td>
                            <asp:Label ID="lblClassName"
                                runat="server" CssClass="text-secondary">类名</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlClassName" runat="server" CssClass="form-control-sm">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblTabName"
                                runat="server" CssClass="text-secondary">表名</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlTabName" runat="server" CssClass="form-control-sm" >
                            </asp:DropDownList>
                        </td>
                       
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblFuncCHName4Codeq"
                                runat="server" CssClass="text-secondary">中文名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFuncCHName4Codeq"
                                runat="server" CssClass="form-control-sm">
                            </asp:TextBox>
                        </td>
                      
                        <td>
                            <asp:Label ID="lblApplicationTypeIdq"
                                runat="server" CssClass="text-secondary">应用类型</asp:Label>
                        </td>
                        <td class="ValueTD">
                            <asp:DropDownList ID="ddlApplicationTypeIdq" runat="server" class="form-control-sm"></asp:DropDownList>
                        </td>
                                             
                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 119; width: 80px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click"
                                runat="server" CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                        </td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>

            <div id="divList" class="div_List"
                runat="server">
                <div id="tabGridFunction" style="width: 100%; height: 32px" class="msgtable">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblCMFunctionList" runat="server"
                                CssClass="h6" Width="250px">函数名4Code列表</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click"
                                CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCloneNewRec4Gv" runat="server" OnClick="btnCloneNewRec4Gv_Click"
                                CssClass="btn btn-outline-info btn-sm" Text="克隆"></asp:Button>
                        </li>
                         
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" runat="server"
                                CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" runat="server"
                                CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                        </li>
                        

                        <li class="nav-item ml-3">
                            <asp:Button ID="btnEditPara" OnClick="btnEditPara_Click" runat="server"
                                CssClass="btn btn-outline-info btn-sm" Text="编辑参数"></asp:Button>

                        </li>
                      
                      
                                              
                    </ul>
                </div>
                <div style="width: 100%;">
<%--                    <div id="divLeft" style="width: 55%; float: left">--%>
                        <div id="divLeft" style="width: 100%" runat="server">
                        <uc2:wucvCMFunction4GV ID="wucCMFunction4GV1" runat="server" />
                    </div>
                   
                </div>
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditCMFunctionRegion" class="tab_Edit"
                runat="server">
                <div>
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditCMFunction" runat="server" Width="250px"
                                CssClass="h6">函数名4Code编辑区域</asp:Label>
                        </li>

                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </li>

                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelCMFunctionEdit"
                                runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelCMFunctionEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsgEdit" runat="server"
                                Width="208px" CssClass="text-warning"></asp:Label>
                        </li>

                    </ul>
                </div>
                <div>
                    <uc1:wucCMFunction ID="wucCMFunctionB1" runat="server" />
                </div>
            </div>


        </div>
    </form>
</body>
</html>


