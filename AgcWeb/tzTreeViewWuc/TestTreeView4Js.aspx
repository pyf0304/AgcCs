<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestTreeView4Js.aspx.cs" Inherits="AGC.Mvc.tzTreeViewWuc.TestTreeView4Js" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script>
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
        function TestNodeClick(strKeyId) {
            console.log(strKeyId);
            alert(strKeyId);
        }
    </script>
      <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TreeView ID="TreeView1" runat="server"></asp:TreeView>
        </div>

    </form>
</body>
</html>
