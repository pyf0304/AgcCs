<%@ Page Language="c#" CodeBehind="wfmTestMoveImg.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmTestMoveImg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>wfmTestMoveImg</title>

    <script language="javascript" type="text/javascript">
		<!--
    var intTabQueryLeft, intTabQueryWidthOld, intTabQueryWidthNew, intImgLeftNew, oldx=0,oldy=0,oldobj=null;
   	var theImgId = new Array(100);
	var theImgLeft = new Array(100);
	var theImgTop = new Array(100);

    var bolIsMouseDown;
	function Img_onMouseDown()
	{
		oldobj=event.srcElement
		oldx=event.x-oldobj.offsetLeft;
		oldy=event.y-oldobj.offsetTop;
		oldobj.style.position="absolute"
		oldobj.setCapture()
		bolIsMouseDown = true;
	}
	function Img_onMouseMove()
	{
		if(oldobj==null)
			return false
		if (bolIsMouseDown == true)
		{
			oldobj.style.left=event.x-oldx;
			oldobj.style.top=event.y-oldy
		}
	}
	function Img_onMouseUp()
	{
		bolIsMouseDown = false;
		if (window.event.x != document.Form1.TextBox1.value || window.event.y != document.Form1.TextBox2.value)
		{
			//document.Form1.TextBox1.value = window.event.x-oldx
			document.Form1.TextBox2.value = window.event.y-oldy
			document.Form1.TextBox3.value = oldobj.id
			intImgLeftNew = event.x-oldx;
			document.Form1.hidString.value = "";
			var WorkStepPoints = document.getElementsByName("wsPoint");
			if (WorkStepPoints.length == 0)
			{
				document.Form1.hidString.value += "lenght=0";
			}
			for(var i=0;i<WorkStepPoints.length;i++)
			{
				/*theImgId[i] = WorkStepPoints[i].id;
				theImgLeft[i] = WorkStepPoints[i].style.left;
				theImgTop[i] = WorkStepPoints[i].style.top;
				*/
				document.Form1.hidString.value += WorkStepPoints[i].id + "," 
												+ WorkStepPoints[i].style.left + ","
												+ WorkStepPoints[i].style.top + ";";
			}
		
			/*for (var i = 0; i<WorkStepPoints.length; i++)
			{
				document.Form1.hidString.value += theImgId[i] + ",";
			}
			*/
//			tabLayout.style.width = 400;
			///重新设置查询区域(tabQuery)的宽度以及内部DATAGRID的宽度。
			//计算查询区域原来的左边界
//			intTabQueryLeft = parseInt(tabQuery.style.left, 10);			
			//计算查询区域原来的宽度
//			intTabQueryWidthOld = tabQuery.style.width;		
			//计算查询区域的新宽度
//			intTabQueryWidthNew = intImgLeftNew - intTabQueryLeft;	
			//设置查询区域的宽度
//			tabQuery.style.width = intTabQueryWidthNew - 5;					
//			var intTabQueryLeft = parseInt(tabQuery.style.left, 10);	
//			var intTabQueryWidthNew2 = tabQuery.style.width;
//			intTabQueryWidthNew = 	parseInt(intTabQueryWidthNew2,10);
//			dgCaseType.style.width = intTabQueryWidthNew - 1;		//设置查询区域中DataGrid的宽度
//			imgSplit.style.left = intTabQueryLeft + intTabQueryWidthNew + 13;
//			tabLayout.style.left = intTabQueryLeft + intTabQueryWidthNew + 18;
//			var intTemp = tabQuery.clientWidth;
//			document.Form1.TextBox2.value = "tabQuery.clientWidth = " + intTemp;	
//			intTemp = tabQuery.offsetWidth;
//			document.Form1.TextBox3.value = "tabQuery.offsetWidth = " + intTemp;	
//			intTemp = tabQuery.style.width;
//			document.Form1.TextBox1.value = "tabQuery.style.width = " + intTemp;	
		}
		oldobj=null;
		document.releaseCapture();
//		var timeid = setTimeout("setLayout",10);
	}
	function initWindows()
	{
		document.Form1.TextBox1.value = "tabQuery.style.width = ";
	}
	function setLayout()
	{
		var intTabQueryLeft = parseInt(tabQuery.style.left, 10);		
		var intTabQueryWidthNew2 = tabQuery.style.width;
		var intTabQueryWidthNew = 	parseInt(intTabQueryWidthNew2,10);
		document.Form1.TextBox1.value = "intTabQueryWidthNew(in setLayout) = " + intTabQueryWidthNew;
		dgCaseType.style.width = intTabQueryWidthNew - 1;		//设置查询区域中DataGrid的宽度
		imgSplit.style.left =intTabQueryLeft + intTabQueryWidthNew + 1;
		//编辑表格(tabLayout)的左定义到新的位置
		tabLayout.style.left = intTabQueryLeft + intTabQueryWidthNew + 5 ;
		//重新设置查询区域的宽度，可能与上部得出的值不一样,因为当一个table的宽度被设置太小时，可能会不接受，系统会有一个表格的最小宽度。
		
	}
	//-->
    </script>

</head>
<body onload="">
    <form id="Form1" method="post" runat="server">
        <table id="tabTitle" style="z-index: 101; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White"
                        Font-Bold="True">测试移动图像</asp:Label></td>
            </tr>
        </table>
        </FONT>
        <asp:TextBox ID="TextBox1" Style="z-index: 102; left: 64px; position: absolute; top: 32px"
            runat="server" Width="264px" Height="128px" TextMode="MultiLine"></asp:TextBox>
        <asp:TextBox ID="TextBox2" Style="z-index: 103; left: 352px; position: absolute;
            top: 32px" runat="server" Width="136px" Height="40px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" Style="z-index: 104; left: 504px; position: absolute;
            top: 32px" runat="server" Width="128px" Height="40px"></asp:TextBox>
        <table id="tabQuery" style="z-index: 105; left: 16px; width: 448px; position: absolute;
            top: 104px; height: 128px" cellspacing="1" cellpadding="1" width="448" border="1">
            <tr>
                <td>
                    <span id="span1" runat="server"></span>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnSaveData" Style="z-index: 106; left: 656px; position: absolute;
            top: 64px" runat="server" Width="112px" Text="保存位置信息"></asp:Button>
        <input id="hidString" style="z-index: 107; left: 648px; position: absolute; top: 32px"
            type="hidden" runat="server">
        &nbsp;
    </form>
</body>
</html>
