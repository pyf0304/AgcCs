<%@ Register TagPrefix="uc1" TagName="wucCaseType" Src="wucCaseType.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmCaseType_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmCaseType_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>表CaseType的查询、修改、删除、添加记录</title>
    

    <script language="javascript" type="text/javascript">
		<!--
    var intTabQueryLeft, intTabQueryWidthOld, intTabQueryWidthNew, intImgLeftNew, oldx=0,oldy=0,oldobj=null;
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
		}
//		oldobj.style.top=event.y-oldy
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
//			tabLayout.style.width = 400;
			///重新设置查询区域(tabQuery)的宽度以及内部DATAGRID的宽度。
			//计算查询区域原来的左边界
			intTabQueryLeft = parseInt(tabQuery.style.left, 10);			
			//计算查询区域原来的宽度
			intTabQueryWidthOld = tabQuery.style.width;		
			//计算查询区域的新宽度
			intTabQueryWidthNew = intImgLeftNew - intTabQueryLeft;	
			//设置查询区域的宽度
			tabQuery.style.width = intTabQueryWidthNew - 5;					
			var intTabQueryLeft = parseInt(tabQuery.style.left, 10);	
			var intTabQueryWidthNew2 = tabQuery.style.width;
			intTabQueryWidthNew = 	parseInt(intTabQueryWidthNew2,10);
			dgCaseType.style.width = intTabQueryWidthNew - 1;		//设置查询区域中DataGrid的宽度
			imgSplit.style.left = intTabQueryLeft + intTabQueryWidthNew + 13;
			tabLayout.style.left = intTabQueryLeft + intTabQueryWidthNew + 18;
			var intTemp = tabQuery.clientWidth;
			document.Form1.TextBox2.value = "tabQuery.clientWidth = " + intTemp;	
			intTemp = tabQuery.offsetWidth;
			document.Form1.TextBox3.value = "tabQuery.offsetWidth = " + intTemp;	
			intTemp = tabQuery.style.width;
			document.Form1.TextBox1.value = "tabQuery.style.width = " + intTemp;	
		}
		oldobj=null;
		document.releaseCapture();
		var timeid = setTimeout("setLayout",10);
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
<body>
    <form id="Form1" method="post" runat="server">
        
            <asp:Label ID="Label3" Style="z-index: 104; left: 8px; position: absolute; top: 8px"
                runat="server" ForeColor="Blue" Font-Size="Larger" Font-Names="黑体" 
                Width="240px">项目用例管理->用例类型维护</asp:Label>
            <asp:Label ID="Label2" Style="z-index: 102; left: 256px; position: absolute; top: 8px"
                runat="server" ForeColor="#004040"  
                Width="42px" Font-Bold="True">说明：</asp:Label>
            <asp:Label ID="Label1" Style="z-index: 101; left: 304px; position: absolute; top: 8px"
                runat="server" ForeColor="#004040"  Height="32px"
                Width="368px">用例对象主要用来维护在项目中用户或程序员对功能需要方面所作的简短的语言。</asp:Label>
            <table id="tabLayout" style="z-index: 103; left: 518px; width: 304px; position: absolute;
                top: 48px; height: 200px" bordercolor="#666666" cellspacing="1" cellpadding="1"
                width="304" border="4">
                <tr>
                    <td valign="top">
                        <asp:Button ID="btnOKUpd" runat="server" 
                            Height="31px" Width="83px" Text="添加"></asp:Button><asp:Label ID="lblMsg" runat="server"
                                 Height="27px" Width="215px"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <uc1:wuccasetype id="wucCaseType1" runat="server">
                        </uc1:wuccasetype></td>
                </tr>
            </table>
            <table id="tabHidden" style="z-index: 105; left: 680px; position: absolute; top: 0px"
                cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
                <tr>
                    <td>
                        <asp:Label ID="lblMemoq" runat="server" 
                             Width="32px">备注</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtMemoq" runat="server" 
                             Width="100px"></asp:TextBox></td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
            <table id="tabQuery" style="z-index: 106; left: 8px; width: 504px; position: absolute;
                top: 48px; height: 234px" bordercolor="#000066" cellspacing="1" cellpadding="1"
                width="504" border="4">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblCaseTypeIdq" runat="server" 
                             Width="72px">用例类型号</asp:Label><asp:TextBox ID="txtCaseTypeIdq" runat="server"
                                  Width="100px"></asp:TextBox></td>
                    <td colspan="2">
                        <asp:Label ID="lblCaseTypeq" runat="server" 
                             Width="85px">用例类型名称</asp:Label><asp:TextBox ID="txtCaseTypeq" runat="server"
                                  Width="100px"></asp:TextBox></td>
                    <td>
                        <asp:Button ID="btnQuery" runat="server" 
                             Width="78px" Text="查询"></asp:Button></td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:DataGrid ID="dgCaseType" runat="server" 
                            Height="154px" Width="463px" AutoGenerateColumns="False" PageSize="5" AllowPaging="True">
                            <Columns>
                                <asp:BoundColumn DataField="CaseTypeId" HeaderText="用例类型号"></asp:BoundColumn>
                                <asp:BoundColumn DataField="CaseType" HeaderText="用例类型名称"></asp:BoundColumn>
                                <asp:BoundColumn DataField="Memo" HeaderText="备注"></asp:BoundColumn>
                                <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                <asp:TemplateColumn>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                            </Columns>
                            <PagerStyle Mode="NumericPages"></PagerStyle>
                        </asp:DataGrid></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblRecCount" runat="server" 
                             Width="110px">查询结果记录数：</asp:Label></td>
                    <td colspan="3">
                        <asp:TextBox ID="txtRecCount" runat="server" 
                             Width="111px" ReadOnly="True"></asp:TextBox></td>
                </tr>
            </table>
        </font>
        <asp:TextBox ID="TextBox1" runat="server" Width="18px" Style="z-index: 108; left: 16px;
            position: absolute; top: 328px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Width="74px" Style="z-index: 109; left: 16px;
            position: absolute; top: 360px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" Width="42px" Style="z-index: 110; left: 16px;
            position: absolute; top: 392px"></asp:TextBox>
    </form>
    <img onmouseup="Img_onMouseUp()" onmousemove="Img_onMouseMove()" onmousedown="Img_onMouseDown()"
        id="imgSplit" style="z-index: 107; left: 513px; position: absolute; top: 40px"
        height="580" src="../../pic/newbtm8.jpg" width="4" name="imgSplit" runat="server">
    </img>
</body>
</html>
