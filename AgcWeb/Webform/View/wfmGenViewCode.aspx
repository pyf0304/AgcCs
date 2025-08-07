<%@ Page Title="表ViewInfo的查询、修改、删除、添加记录" Language="C#" MasterPageFile="~/Webform/MasterPage/mpViewEdit.Master" CodeBehind="wfmGenViewCode.aspx.cs" AutoEventWireup="True"
    ValidateRequest="false" Inherits="AGC.Webform.wfmGenViewCode" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../css/taishweb2.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../../js/tzPubFun.js"></script>

    <style>
        .ulhorizontal li {
            float: left;
        }
    </style>
      <script type="text/javascript">
          function GeneCode(strCodeTypeId, strViewId, strCmPrjId, intApplicationTypeId) {
            //返回长度超过一定数量就不能返回了，怎么办？
            $.ajax({
                type: "post",
                datatype: "json",
                data: '{"strCodeTypeId":"' + strCodeTypeId + '",' +
                    '"strTabId":"",' +
                    '"intApplicationTypeId":"' + intApplicationTypeId + '",' +
                    '"strCmPrjId":"' + strCmPrjId + '",' +
                    '"strViewId":"'+strViewId+ '"}',
                url: "wfmGenViewCode.aspx/GeneCode",
                contentType: "application/json",
                success: function (result) {
                    ShowCode(result.d);
                }
            });
        }
                 function GeneCode4Func(strCodeTypeId, strTabId, strFuncId, intApplicationTypeId) {
            //返回长度超过一定数量就不能返回了，怎么办？
            $.ajax({
                type: "post",
                datatype: "json",
                data: '{"strCodeTypeId":"' + strCodeTypeId + '",' +
                    '"strTabId":"' + strTabId + '",' +
                    '"strFuncId":"' + strFuncId + '",' +
                    '"intApplicationTypeId":"' + intApplicationTypeId + '",' +
                    '"strViewId":""}',
                url: "wfmPrjTab_QUDI3.aspx/GeneCode4Func",
                contentType: "application/json",
                success: function (result) {
                    ShowCode(result.d);
                }
            });
        }

        function ShowCode(strCode) {
            var txtCode = document.getElementById("txtCode");
            var objJSON = JSON.parse(strCode)
            txtCode.value = objJSON.Code;
            var txtClassName4GC = document.getElementById("txtClassName4GC");
            if (txtClassName4GC != null) {
                txtClassName4GC.value = objJSON.ClassName;
            }
            var txtFolderName4GenCode = document.getElementById("txtFolderName4GenCode");
            if (txtFolderName4GenCode != null) {
                txtFolderName4GenCode.value = objJSON.FileName;
            }
            //$('#txtCode').val(strCode);
        }
               
      </script>
    <script>
        function GenControlCode() {

            var txtCode = getObjByTagAndId("textarea", "txtCode");
            if (txtCode != null) {
                txtCode.value = "";
            }
            var txtCode_Sim = getObjByTagAndId("textarea", "txtCode_Sim");
            if (txtCode_Sim != null) {
                txtCode_Sim.value = "";
            }
            var divCode = getObjByTagAndId("div", "divCode");
            CallServer("GenControlCode|1!", divCode);

        }
        function GenCtlControlCode() {

            var txtCode = getObjByTagAndId("textarea", "txtCode");
            if (txtCode != null) {
                txtCode.value = "";
            }
            var txtCode_Sim = getObjByTagAndId("textarea", "txtCode_Sim");
            if (txtCode_Sim != null) {
                txtCode_Sim.value = "";
            }
            var divCode = getObjByTagAndId("div", "divCode");
            CallServer("GenCtlControlCode|1!", divCode);

        }
        function ClearText(txtCode) {
            var txtCode = getObjByTagAndId("textarea", "txtCode");
            if (txtCode != null) {
                txtCode.value = "";
            }
            var txtCode_Sim = getObjByTagAndId("textarea", "txtCode_Sim");
            if (txtCode_Sim != null) {
                txtCode_Sim.value = "";
            }
        }
    </script>

    <div class="row" style="width: 100%">
        <div class="col-7" >
            <iframe id="myIframe1" name="content" class="myiframe" style="width: 100%; height: 1200px;" runat="server"></iframe>
        </div>

        <div id="Table1" class="col-5"  >
            <div style="width: 100%; float: left;" >
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="lblPageTitle" runat="server" CssClass="h5 text-info">生成Android App界面</asp:Label>
                    </li>
                    <li class="nav-item ml-2">
                        <asp:Label ID="lblMsg2" runat="server" Height="13px" ForeColor="Red"></asp:Label>
                    </li>
                </ul>
            </div>
            <div style="width: 100%; float: left; min-height: 100px;">
                <asp:Panel ID="pnlCodeTypeLst" Style="width: 100%; left: 0px; text-align: left; min-height: 60px; line-height:40px;" runat="server">
                </asp:Panel>
            </div>
            <div style="width: 100%" class="mt-4">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditDepartmentInfo" runat="server"
                                    CssClass="h6 text-info">代码区域</asp:Label>
                                </th>
                            <th>
                                <asp:Label ID="lblMsgEdit" runat="server"
                                    Width="380px" CssClass="auto-style10"></asp:Label>
                            </th>

                        </tr>
                    </table>
                </div>

                <div id="divCodeRegion" style="width: 100%;" runat="server">

                    <div style="width: 700px; height: 52px">
                        <table>
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" Style="z-index: 103; "  runat="server" CssClass="text-secondary font-weight-bold text-right">类名:</asp:Label>
                                </td>
                                <td>
                                    <input id="txtClassName4GC" type="text" style="width:490px;" class="text-primary" />
                                </td>
                                <td>
                                    <asp:LinkButton ID="lbDownLoadFile" Style="z-index: 111; " runat="server" OnClick="lbDownLoadFile_Click">下载文件</asp:LinkButton>
                                </td>
                            </tr>
                            <tr>
                                <td> <asp:Label ID="Label5" runat="server" Width="60px" CssClass="text-secondary font-weight-bold text-right">文件路径:</asp:Label></td>
                                <td colspan="2"> <input id="txtFolderName4GenCode" type="text" style="width:550px" class="text-primary" /></td>
                                
                            </tr>
                        </table>
                    </div>
                    
                    <div id="divCode" style="width: 100%; " class="mt-2">
                        <asp:Literal ID="litCode" runat="server"></asp:Literal>
                         <textarea id="txtCode" style="width: 99%; height: 700px;" rows="2"></textarea>

                    </div>
                    <div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

