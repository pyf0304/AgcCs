<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Default2.aspx.cs" Inherits="Webform_Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <P>
		<table border=1 width=350 height=250>
		<tr>
		<td>
		<OBJECT id=AVCAXCTL classid="clsid:DF4584ED-2BDB-4AA3-99F2-6F07184BB5AA" width=450 height=350>
		</OBJECT>
		</td>
		</tr>
		</table>
		<script language="javascript" type="text/javascript"> 
			var obj=document.getElementById("AVCAXCTL"); 
	  	function OpenA2AClick()
	  	{
	  		try
    		{
            	var name ="e:/fac621e5-a6b2-4d10-8f93-d04a753b46ae.wmv";
	  			obj.OpenFile(name);
    		}
  			catch(e)
    		{
               if (confirm("请先安装播放器"))
               {
                   window.open('./AvsPlayerActiveXSetup.exe');	
               }
     		}
	  	}
	  	function FullClick()
	  	{
	  	alert(obj.playState)
	  		if(obj.playState==3)
	  		{
	  		obj.fullscreen=1;
	  		}
	  		else
	  		{
	  		obj.ProcessFullScreen(1);
	  		}
	  	}
	  	function NormalClick()
	  	{
	  		obj.ProcessFullScreen(0);
	  	}
	  	function ClosePlayer()
	  	{
	  		obj.DestroyPlayer();
	  	}
		OpenA2AClick();OpenA2AClick();
		</script>

		<input type="button" value="播放" onclick="OpenA2AClick()">
		<input type="button" value="全屏" onclick="FullClick()">
		<input type="button" value="正常" onclick="NormalClick()">
		<input type="button" value="关闭" onclick="ClosePlayer()">&nbsp;
        <input onclick="javascript:OpenA2AClick('//AGC//AGC//Upload//fac621e5-a6b2-4d10-8f93-d04a753b46ae.wmv')"
            type="button" value="播放视频" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></P>
    </div>
    </form>
</body>
</html>
