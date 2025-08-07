<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestVar.aspx.cs" Inherits="AGC.Webform.TestDebug.TestVar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnVarReturn" runat="server" Text="测试可变化返回值" OnClick="btnVarReturn_Click" />
            <asp:Button ID="btnVarReturnObjLst" runat="server" Text="返回可变化对象列表" OnClick="btnVarReturnObjLst_Click" />
            <asp:Button ID="btnReturnObjByKey" runat="server" Text="根据表名、关键字返回对象" OnClick="btnReturnObjByKey_Click" />
            <asp:Button ID="btnReturnObjByKeyV2" runat="server" Text="根据表名、关键字返回对象V2" OnClick="btnReturnObjByKeyV2_Click" />
            <asp:Button ID="btnGetObjLst" runat="server" Text="根据表名、条件返回对象列表" OnClick="btnGetObjLst_Click" />
            <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
