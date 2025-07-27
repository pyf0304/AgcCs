<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="wfmFeatureGroupEdit.aspx.cs"
    Inherits="AGC.Webform.wfmFeatureGroupEdit" ValidateRequest="false" %>

<%@ Register TagPrefix="uc4" TagName="wucFieldTab" Src="~/Webform/Field/wucFieldTab.ascx" %>
<%@ Register Src="~/Webform/Table/wucReplaceFieldName.ascx" TagPrefix="uc1" TagName="wucReplaceFieldName" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>
<%@ Register TagPrefix="uc2" TagName="wucvPrjTabFld4Gv" Src="../../Webform/Table/wucvPrjTabFld4Gv.ascx" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <%--   <meta name="viewport" content="width=device-width,initial-scale=1,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no" />
    --%>
    <title>表字段综合维护</title>
    <script src="../../Scripts/jquery-3.6.0.min.js"></script>

    <%--<script src="../../Scripts/bootstrap.js"></script>--%>
    <script src="../../Scripts/bootstrap.min.js"></script>

    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />

    <%--    --%>

    <script src="../../js/tzPubFun.js" type="text/javascript"></script>
    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />
    <script type="text/javascript">
        //主要处理字段类型下拉框选项改变时为字段长度和小数位数提供默认值
        var strTabIndexCurr = 1;
        //function ShowTabHome() {

        //    //$('#txtTest').val('aaaaaaaa');
        //    //$('#lblTest')[0].innerHTML = 'msg';
        //    var btn = $('#a_Tab_PrjTabField');
        //    console.log(btn);
        //    btn.click();
        //    $('#a_Tab_PrjTabField').click();
        //    var strTabName4Show = '#myTab li:eq(' + strTabIndexCurr + ') a'
        //    $(strTabName4Show).tab('show');
        //    //            $('#myTab a[href="#ViewPrjTabField"]').tab('show')
        //}

    </script>


    <style type="text/css">
        iframe {
            width: 100%;
            min-width: 1020px;
            height: 100%;
            min-height: 800px;
            border: none;
            background: none;
        }
        /*.myiframe {
            width: 100%;
            height: 100%;
            border: none;
            background: none;
        }*/
    </style>

    <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div style="width: 100%; float: left">
            <div style="width: 91%; float: left">
                <asp:Label ID="lblTabNameObjName" runat="server" CssClass="h5"></asp:Label>
                <asp:Label runat="server" Visible="false" ID="CurrentTab" />


            </div>
            <div style="width: 8%; float: right;">
                <asp:Button ID="btnReturnPrjTabList" runat="server" CssClass="btn btn-outline-warning btn-sm" OnClick="btnReturnPrjTabList_Click" ToolTip="返回[工程表列表]" Text="返回" />
            </div>
        </div>
        <div style="width: 100%;">
            <div id="divGeneCodeMenu" style="float: left; width: 15%">
                  <asp:DropDownList ID="ddlApplicationTypeId" Width="224px" runat="server" AutoPostBack="True"
                OnSelectedIndexChanged="ddlApplicationTypeId_SelectedIndexChanged">
            </asp:DropDownList><br />
                <uc1:wucTreeView runat="server" ID="wucTreeView1" OnafterSelect_Tz="wucTreeView1_afterSelect_Tz" />
            </div>

            <div style="width: 85%; float: right">
                <ul id="myTab" class="nav nav-tabs" role="tablist">
                    <li class="nav-item"><a class="nav-link" href="#ViewPrjTab" data-toggle="tab" role="tab">功能属性</a></li>
                    <li class="nav-item active"><a class="nav-link active" href="#FeatureFieldTypeRela" data-toggle="tab" role="tab">功能字段类型</a>                        </li>
                    <li class="nav-item"><a class="nav-link" href="#FeatureFuncRela" data-toggle="tab" role="tab">功能函数</a>                     </li>
                    <li class="nav-item"><a class="nav-link" href="#FeatureButtonRela" data-toggle="tab" role="tab">功能按钮</a>                     </li>
                    <li class="nav-item"><a class="nav-link" href="#FeatureAppTypeRela" data-toggle="tab" role="tab">功能应用类型</a>                     </li>
                    <li class="nav-item"><a class="nav-link" href="#CheckConsistency" data-toggle="tab" role="tab">检查一致性</a>                     </li>
                    <li class="nav-item"><a class="nav-link" href="#ViewGeneCode" data-toggle="tab" role="tab">生成代码</a>                     </li>
                </ul>
                <div class="tab-content">
                    <div class="tab-pane" id="ViewPrjTab">
                        <span>ViewPrjTab</span>
                    </div>
                    <div class="tab-pane active" id="FeatureFieldTypeRela">
                        <iframe id="myIframe1" src="wfmFeatureFieldTypeRelaB_QUDI.aspx?FeatureId=0136" name="content" class="myiframe" runat="server"></iframe>
                    </div>
                    <div class="tab-pane" id="FeatureFuncRela">
                        <iframe id="myIframe2" src="wfmFeatureFuncRelaB_QUDI.aspx?FeatureId=0136" name="content" class="myiframe" runat="server"></iframe>
                    </div>
                    <div class="tab-pane" id="FeatureButtonRela">
                        <iframe id="myIframe3" src="wfmFeatureButtonRelaB_QUDI.aspx?FeatureId=0136" name="content" class="myiframe" runat="server"></iframe>
                    </div>
                    <div class="tab-pane" id="FeatureAppTypeRela">
                        <iframe id="myIframe4" src="wfmFeatureAppTypeRela_QUDI.aspx?FeatureId=0136" name="content" class="myiframe" runat="server"></iframe>
                    </div>
                    <div class="tab-pane" id="CheckConsistency">
                        <iframe id="myIframe6" src="wfmConstraintFieldsB_QUDI.aspx?FeatureId=0136" name="content" class="myiframe" runat="server"></iframe>
                    </div>
                    <div class="tab-pane" id="ViewGeneCode">
                        <span>ViewGeneCode</span>
                    </div>

                </div>
            </div>

        </div>
        <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="max-width: 200px;"></asp:Label>


        <asp:Literal ID="litTabIndex" runat="server"></asp:Literal>
        <script>
            //getJsonObjLst();
            //ShowTabHome();
            //$('#myTab li:eq(1) a').tab('show');
        </script>
    </form>
</body>
</html>
