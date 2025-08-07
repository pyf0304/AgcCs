<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="T_AddEvent.aspx.cs" Inherits="AgcMvc3.Webform.A_Sample.T_AddEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script>
        window.onload = function () {
            var ddlCtlTypeId = document.getElementById('ddlCtlTypeId');
            ddlCtlTypeId.addEventListener('change', function (e) { myonchange(); });

            $("#Select1").bind('change', function () {
                alert("Changed");
            });
        }
        function myonchange() {
            alert('onchange');
        }
    </script>

    <script>
        window.onload = function () {
            //需求：京东的获取焦点
            //思路：京东的input按钮获取了插入条光标立刻删除内容。失去插入条光标显示文字
            //获取事件源和相关元素
            var inp1 = document.getElementById("inp1");
            console.log("inp1", inp1);
            //绑定事件
            inp1.onfocus = function () {

                //书写驱动程序
                if (this.value == "我是京东") {
                    this.value = "";
                }
            }
            inp1.onblur = function () {
                if (this.value === "") {
                    this.value = "我是京东";
                }
            }

        }

    </script>
    <script>
        function getAttr() {
            var txtSetAttr = document.getElementById("txtSetAttr");

            var txtCtrlId = txtSetAttr.getAttribute("CtrlId");
            alert(txtCtrlId);
        }
    </script>
    <style type="text/css">
        #TextArea1 {
            height: 95px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlCtlTypeId" runat="server">
                <asp:ListItem>AAA</asp:ListItem>
                <asp:ListItem>BBB</asp:ListItem>
                <asp:ListItem>CCC</asp:ListItem>
            </asp:DropDownList>

            <select id="Select1">
                <option>aaa</option>
                <option>aaa2</option>
                <option>aaa3</option>

            </select>
            <textarea id="TextArea1" cols="20" name="S1"></textarea>
        </div>

        <asp:TextBox ID="txtSetAttr" runat="server"></asp:TextBox>
        京东：<input type="text" name="jd" id="inp1" value="我是京东" />
        <br />
        淘宝：<label for="inp2">我是淘宝</label><input type="text" name="tb" id="inp2" /><br />
        placeholder：<input type="text" placeholder="我是placeholder" />
        <input id="btnGetAttr" type="button" value="获取属性" onclick="getAttr()" />

        <input id="Radio1" type="radio" />
    </form>

</body>
</html>
