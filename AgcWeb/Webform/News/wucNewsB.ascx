<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucNewsB.ascx.cs" Inherits="CompanyPage.Webform.wucNewsB" %>
<%@ Register Assembly="DotNetTextBox" Namespace="DotNetTextBox" TagPrefix="DNTB" %>
<link rel="stylesheet" type="text/css" href="../../Css/Images/style.css" />
<script src="../../Scripts/jquery-3.6.0.min.js"></script>
<script src="../../Scripts/jquery.validate.min.js"></script>
<script type="text/javascript" src="../../Js/messages_cn.js"></script>
<script src="../../Scripts/jquery-form.js"></script>
<script type="text/javascript" src="../../Js/cursorfocus.js"></script>
<script type="text/javascript" language="javascript" src="../../Js/My97DatePicker/WdatePicker.js">
</script>
<script type="text/javascript">
    $(function () {
        //表单验证JS
        $("#form1").validate({
            //出错时添加的标签
            errorElement: "span",
            success: function (label) {
                //正确时的样式
                label.text(" ").addClass("success");
            }
        });

    });
</script>
<table width="100%" border="0" cellspacing="0" cellpadding="0" class="msgtable">
    <tr>
        <th colspan="2" align="left">
            资讯编辑
        </th>
    </tr>
    <tr>
        <td align="right">
            标题：
        </td>
        <td >
            <asp:TextBox ID="txtNewsTitle" runat="server" CssClass="input w380 required" MaxLength="50" Width="500px"
                minlength="3" HintTitle="发布的文章标题" HintInfo="控制在50个字数内，标题文本尽量不要太长。"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            资讯类型：
        </td>
        <td>
            <asp:DropDownList ID="ddlNewsTypeId" runat="server" CssClass="input">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="right">
            是否置顶：
        </td>
        <td>
            <asp:CheckBox ID="chkIsTop" runat="server" Text="" CssClass="Check_Defa"></asp:CheckBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            图片路径：
        </td>
        <td>
            <asp:FileUpload runat="server" ID="fupImageUrl" runat="server" CssClass="input w250 left"
                HintTitle="中心的图片" HintInfo="请在右边点击“浏览”上传中心大图，大小请保持在50KB以内。" />
            <asp:Image runat="server" ID="ImgUrl" runat="server" Height="70px" Width="120px"
                Visible="false" />
        </td>
    </tr>
    <tr>
        <td align="right">
            文章内容：
        </td>
        <td>
            <DNTB:WebEditor ID="txtNewsContent" runat="server"></DNTB:WebEditor>
        </td>
    </tr>
    <tr>
        <td align="right">
            编辑人：
        </td>
        <td>
            <asp:TextBox ID="txtEditPeople" runat="server" CssClass="input w250 required" MaxLength="10"
                HintTitle="编辑人" HintInfo="控制在10个字数内，如“管理员”。"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            编辑时间：
        </td>
        <td>
            <asp:TextBox ID="txtEditTime" runat="server" onfocus="new WdatePicker(this,'%Y-%M-%D',true,'whyGreen')"
                CssClass="input w250 required" MaxLength="16" HintTitle="日期" HintInfo="控制在16个字数内，如“1988-07-22”。"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            来源：
        </td>
        <td>
            <asp:TextBox ID="txtSource" runat="server" CssClass="input w250 required" MaxLength="10"
                HintTitle="来源" HintInfo="控制在10个字数内，如“中国教育网”。"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            浏览量：
        </td>
        <td>
            <asp:TextBox ID="txtViews" runat="server" CssClass="input required number" size="10"
                MaxLength="10" HintTitle="文章的浏览次数" HintInfo="纯数字，本文章被阅读的次数。">0</asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            备注：
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" CssClass="input w380 left" Height="80px"
                HintInfo="控制在1000个字数内，可以标注一些备忘。" HintTitle="备注" MaxLength="1000" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
