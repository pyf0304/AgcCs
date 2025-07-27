<%@ Page Language="c#" CodeBehind="wfmImportViewInfoFromSQL2.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.wfmImportViewInfoFromSQL2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>WebForm1</title>
    
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
      
            <asp:Label ID="lblServer" Style="z-index: 104; left: 110px; position: absolute; top: 64px"
                runat="server" Font-Names="新宋体"  Width="100px" >服务器的IP为：</asp:Label>
            <asp:LinkButton ID="lbReturnFieldTab" Style="z-index: 135; left: 688px; position: absolute;
                top: 16px" runat="server"  OnClick="lbReturnFieldTab_Click" >返回工程表编辑界面</asp:LinkButton>
            <asp:Button ID="btnOkAdd" Style="z-index: 134; left: 424px; position: absolute; top: 304px"
                runat="server" Text="确认导入" OnClick="btnOkAdd_Click"></asp:Button>
            <asp:CheckBox ID="chkSelAll" Style="z-index: 133; left: 424px; position: absolute;
                top: 344px" runat="server"  Text="全选"
                AutoPostBack="True" OnCheckedChanged="chkSelAll_CheckedChanged"></asp:CheckBox>
            <asp:DataGrid ID="dgTabFields" Style="z-index: 132; left: 32px; position: absolute;
                top: 296px" runat="server" Height="128px" Width="380px" Font-Size="Smaller" Font-Names="宋体"
                AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanged="dgTabFields_PageIndexChanged">
                <Columns>
                    <asp:TemplateColumn>
                        <HeaderStyle Width="20px"></HeaderStyle>
                        <ItemTemplate>
                            <asp:CheckBox ID="ckb1" runat="server"></asp:CheckBox>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                    <asp:BoundColumn DataField="Column_Name" HeaderText="字段名"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Type_Name" HeaderText="字段类型"></asp:BoundColumn>
                    <asp:BoundColumn DataField="length" HeaderText="字段长度"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Is_Nullable" HeaderText="是否可空"></asp:BoundColumn>
                </Columns>
                <PagerStyle Mode="NumericPages"></PagerStyle>
            </asp:DataGrid>
            <img style="z-index: 131; left: 10px; width: 800px; position: absolute; top: 288px;
                height: 3px" height="3" alt="" src="../../pic/兰色直线1.gif" width="800">
            <img style="z-index: 126; left: 10px; width: 800px; position: absolute; top: 168px;
                height: 3px" height="3" alt="" src="../../pic/兰色直线1.gif" width="800">
            <img style="z-index: 125; left: 10px; width: 800px; position: absolute; top: 56px;
                height: 3px" height="3" alt="" src="../../pic/兰色直线1.gif" width="800">
            <asp:Label ID="Label4" Style="z-index: 124; left: 8px; position: absolute; top: 8px"
                runat="server" Width="272px" CssClass="h5">表字段管理->导入SQL视图信息</asp:Label>
            &nbsp;
            <asp:TextBox ID="txtServer" Style="z-index: 101; left: 224px; position: absolute;
                top: 64px" runat="server" Font-Names="新宋体"  Width="164" ></asp:TextBox>
            <asp:Label ID="lblUserIdForMaster" Style="z-index: 116; left: 28px; position: absolute;
                top: 88px" runat="server" Font-Names="新宋体"  Width="182px"
                >数据库库master库的用户名：</asp:Label>
            <asp:TextBox ID="txtUserIdForMaster" Style="z-index: 103; left: 224px; position: absolute;
                top: 88px" runat="server" Font-Names="新宋体"  Width="164" ></asp:TextBox>
            <asp:Label ID="lblPassWordForMaster" Style="z-index: 115; left: 168px; position: absolute;
                top: 112px" runat="server" Font-Names="新宋体"  Width="42px"
                >口令：</asp:Label>
            <asp:TextBox ID="txtPassWordForMaster" Style="z-index: 105; left: 224px; position: absolute;
                top: 112px" runat="server" Font-Names="新宋体"  Width="164px"
                 TextMode="Password"  AUTOCOMPLETE="off"></asp:TextBox>
            <asp:Label ID="lblMsgForDB" Style="z-index: 120; left: 448px; position: absolute;
                top: 232px" runat="server" Font-Names="新宋体"  Width="164px"
               ></asp:Label>
            <asp:Label ID="lblDatabase" Style="z-index: 117; left: 128px; position: absolute;
                top: 176px" runat="server" Font-Names="新宋体"  Width="84px"
                >数据库名为：</asp:Label>
            <asp:DropDownList ID="ddlDatabase" Style="z-index: 106; left: 224px; position: absolute;
                top: 176px" runat="server" Font-Names="新宋体"  Width="320px"
                Height="26px">
            </asp:DropDownList>
            <asp:Label ID="Label15" Style="z-index: 119; left: 16px; position: absolute; top: 272px"
                runat="server" Font-Names="新宋体" 
                Font-Bold="True" ForeColor="Teal">第三步：</asp:Label>
            <asp:Button ID="btnGO2" Style="z-index: 118; left: 392px; position: absolute; top: 224px"
                runat="server" Font-Names="新宋体"   Text="GO" Enabled="False" OnClick="btnGO2_Click">
            </asp:Button>
            <asp:Label ID="Label10" Style="z-index: 114; left: 16px; position: absolute; top: 152px"
                runat="server" Font-Names="新宋体" 
                Font-Bold="True" ForeColor="Teal">第二步：</asp:Label>
            <asp:Label ID="Label9" Style="z-index: 113; left: 16px; position: absolute; top: 40px"
                runat="server" Font-Names="新宋体" 
                Font-Bold="True" ForeColor="Teal">第一步：</asp:Label>
            <asp:Label ID="lblMsgForOK" Style="z-index: 112; left: 512px; position: absolute;
                top: 344px" runat="server" Width="330px" Height="21px" CssClass="text-warning"></asp:Label>
            <asp:Label ID="lblTable" Style="z-index: 109; left: 80px; position: absolute; top: 272px"
                runat="server" Font-Names="新宋体"  Width="128px" >请选择视图名：</asp:Label>
            <asp:DropDownList ID="ddlTable" Style="z-index: 108; left: 224px; position: absolute;
                top: 264px" runat="server" Font-Names="新宋体"  Width="328px"
                 AutoPostBack="True" OnSelectedIndexChanged="ddlTable_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Label ID="Label3" Style="z-index: 107; left: 88px; position: absolute; top: 152px"
                runat="server" Font-Names="新宋体"  Width="357px" >请选择数据库名，以及填写相应数据库的用户名和口令：</asp:Label>
            <asp:Label ID="Label1" Style="z-index: 102; left: 88px; position: absolute; top: 40px"
                runat="server" Font-Names="新宋体"  Width="547px">数据库服务器的IP地址、数据服务器中Master库的用户名和口令：</asp:Label>
            <asp:Button ID="btnGO1" Style="z-index: 110; left: 400px; position: absolute; top: 112px"
                runat="server" Font-Names="新宋体"   Text="GO" OnClick="btnGO_Click"></asp:Button>
            <asp:Label ID="lblMsgForServer" Style="z-index: 111; left: 456px; position: absolute;
                top: 112px" runat="server" Font-Names="新宋体"  Width="164px"
                Height="21px"></asp:Label>
        </font>
        <asp:CheckBox ID="chkIsIdentical" Style="z-index: 121; left: 392px; position: absolute;
            top: 200px" runat="server"  Width="255px" Height="23px" Text="数据库的用户名、口令和Master一致"
            Checked="True"></asp:CheckBox>
        <asp:Panel ID="pnlSession" Style="z-index: 122; left: 976px; position: absolute;
            top: 16px" runat="server" Height="192px" Width="208px">
            
                <asp:Label ID="Label2" runat="server"  Width="42px" 
                    Font-Names="新宋体">用户ID</asp:Label></font></asp:Panel>
        <asp:TextBox ID="txtUserId" Style="z-index: 123; left: 920px; position: absolute;
            top: 272px" runat="server" Width="88px"></asp:TextBox>
        <asp:Label ID="lblUserIdForDB" Style="z-index: 127; left: 72px; position: absolute;
            top: 200px" runat="server" Width="140px"  Font-Names="新宋体">用户数据库的用户名：</asp:Label>
        <p>
            <asp:TextBox ID="txtUserIdForDB" Style="z-index: 128; left: 224px; position: absolute;
                top: 200px" runat="server"  Width="160px"  Font-Names="新宋体"></asp:TextBox>
            <asp:Label ID="lblPassWordForDB" Style="z-index: 129; left: 168px; position: absolute;
                top: 224px" runat="server" Width="42px"  Font-Names="新宋体">口令：</asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtPassWordForDB" Style="z-index: 130; left: 224px; position: absolute;
                top: 224px" runat="server"  Width="160px"  Font-Names="新宋体"
                TextMode="Password"  AUTOCOMPLETE="off"></asp:TextBox>
            <asp:Label ID="lblMsg1" runat="server"  Width="336px" ForeColor="Red"
                Style="z-index: 136; left: 512px; position: absolute; top: 368px"></asp:Label>
        </p>
    </form>
</body>
</html>
