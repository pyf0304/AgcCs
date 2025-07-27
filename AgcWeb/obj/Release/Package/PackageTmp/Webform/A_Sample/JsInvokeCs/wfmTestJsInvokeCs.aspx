<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfmTestJsInvokeCs.aspx.cs" Inherits="AGC.Webform.wfmTestJsInvokeCs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../../js/tzPubFun.js"></script>
      <script type="text/javascript">
          function ReceiveServerData(result, context) {
              if (result != "") {
                  context.innerHTML = result;
              }
          }

          //在另一页面显示视频，用于显示一个单独的视频
          function ShowVideo(start) {
              var url = window.location.href;
              var caseid = document.all.ctl00_ContentPlaceHolder1_hidId_ClsRmTeachingCase.value; //  url.substring(url.indexOf('id=') + 3, url.length);
              window.open('VedioPlayer.aspx?caseid=' + caseid + '&start=' + start + '', '', 'width=450px,height=360px,top=100px,left=150px');
          }


          // alert('SetClass4DualVedio');

    </script>
    <script>

        function BindTextBox() {

            var divTest = getObjByTagAndId("div", "divTest");
            CallServer("BindTextBox|1!", divTest);
        }
    </script>

<script type="text/javascript">
    //<![CDATA[
    //function CallServer(arg, context) {
    //    context.innerHTML = 'Loading';
    //    WebForm_DoCallback('__Page', arg, ReceiveServerData, context, null, false);
    //}//]]>
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
<asp:Label ID="Label1" runat="server" Text="注意该文件不能放在中文的文件夹中"></asp:Label>
        </div>
        
    <div id="divTest" runat="server">
        <asp:TextBox ID="TextBox1" TextMode="MultiLine" runat="server"></asp:TextBox>
    </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button_aspx" />
            <input id="Button2" type="button" onclick="BindTextBox()" value="button_html" runat="server" />


        </div>
    </div>
    </form>
</body>
</html>
