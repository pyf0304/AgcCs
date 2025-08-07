<%@ Page Title="界面预览" Language="C#" MasterPageFile="~/Webform/MasterPage/mpViewEdit.Master" CodeBehind="wfmPreviewViewRegion3.aspx.cs" AutoEventWireup="True"
    ValidateRequest="FALSE" Inherits="AGC.Webform.wfmPreviewViewRegion3" %>

<%@ Register Src="~/Webform/CommonControl/wucQryRegion4Preview.ascx" TagPrefix="uc1" TagName="wucQryRegion4Preview" %>
<%@ Register Src="~/Webform/CommonControl/wucListRegion4Preview.ascx" TagPrefix="uc1" TagName="wucListRegion4Preview" %>
<%@ Register Src="~/Webform/CommonControl/wucFeatureRegionButton4Visible.ascx" TagPrefix="uc1" TagName="wucFeatureRegionButton4Visible" %>
<%@ Register Src="~/Webform/CommonControl/wucEditRegion4PreviewV2.ascx" TagPrefix="uc1" TagName="wucEditRegion4Preview" %>
<%@ Register Src="~/Webform/CommonControl/wucExcelExportRegion4Preview.ascx" TagPrefix="uc1" TagName="wucExcelExportRegion4Preview" %>
<%@ Register Src="~/Webform/CommonControl/wucDetailRegion4Preview.ascx" TagPrefix="uc1" TagName="wucDetailRegion4Preview" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <script src="../../Scripts/jquery-3.6.0.min.js"></script>
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery.ui.position.js"></script>
    <script src="../../Scripts/jquery.contextMenu.js"></script>
    <link href="../../Content/jquery.contextMenu.css" rel="stylesheet" />
    <script>
         function BindAll() {
            var arrBtn_Collect = document.getElementsByTagName("button");
            var arrBtn = GetArray(arrBtn_Collect);
            arrBtn.forEach(x => {
                attachContext(x.id);
                //x.setAttribute("data-toggle", "context");
                //x.setAttribute("data-target", "#context-menu");
            });
        }
        function SetNotInUse(menuName, id) {
            alert("点击了：" + menuName + id);
            //            alert("SetNotInUse() ");
        }
    </script>
    
    <script>
        function attachContext(mySelector) {
            console.log(mySelector);
            $.contextMenu({
                selector: '#' + mySelector,
                onContextMenu: function (e) {
                    var obj = e.target;//鼠标点击的目标
                    /*然后对鼠标点击的目标进行一些特定的操作*/
                    console.log("onContextMenu:");
                    console.log(obj);
                    return true;//返回true则显示小菜单，返回false则不显示小菜单

                },
                callback: function (key, options) {
                    console.log("点击了：" + key);
                    console.log(options);
                },
                items: {
                    "SetNoInUse": {
                        name: "设置不用",
                        icon: "edit",
                        callback: function (itemKey, opt, rootMenu, originalEvent) {
                            console.log(itemKey);
                            console.log(opt);
                            console.log(rootMenu);
                            console.log(originalEvent);
                            SetNotInUse("SetNoInUse", mySelector)
                            var groupNodeId = href.slice(1, href.length);                         
                        }
                    },
                    "UpMove": {
                        name: "上移",
                        icon: "edit",
                        callback: function (itemKey, opt, rootMenu, originalEvent) {
                            SetNotInUse("UpMove", mySelector);
                        }
                    },
                    "DownMove": {
                        name: "下移",
                        icon: "edit",
                        callback: function (itemKey, opt, rootMenu, originalEvent) {
                            SetNotInUse("DownMove", mySelector);
                        }
                    },
                    "deleteNote": {
                        name: "删除节点",
                        icon: "delete",
                        callback: function (itemKey, opt, rootMenu, originalEvent) {
                            var href = $('.list-group-item.node-div_group.context-menu-active a').attr('href');
                            var groupNodeId = href.slice(1, href.length);
                            $.ajax({
                                url: '${root}/group/delNode.do?seq=' + groupNodeId,
                                dataType: 'json',
                                type: 'post',
                                async: false,
                                success: function (data) {
                                    var msg = data.message;
                                    if (data.successful == true) {
                                        alert("删除节点成功!");
                                        window.location.reload();
                                    } else if (msg == "sRelated") {
                                        alert("子节点和按钮关联了，不能删除");
                                    } else if (msg == "related") {
                                        alert("根节点或者其子节点和按钮关联了，不能删除");
                                    } else {
                                        alert(msg);
                                    }

                                },
                                error: function (error) {
                                    alert("系统错误!");
                                }
                            });
                        }
                    }
                }
            });


        }
        document.oncontextmenu = function (e) {
            e = e || event;
            var tag = e.target || e.srcElement;
            console.log(tag.id);
            //alert(tag.innerHTML);
            //return false;
        }
    </script>
    <script>
        function GetArray(arr) {
            var arrLst = new Array();
            for (var i = 0; i < arr.length; i++) {
                var chk = arr[i];// as HTMLElement;
                arrLst.push(chk);
            }
            return arrLst;
        }
           function SetContentMenuBak20200331() {
               var arrSpan_Collect = document.getElementsByTagName("span");
               var arrSpan = GetArray(arrSpan_Collect);
               arrSpan.forEach(x => {
                   x.setAttribute("data-toggle", "context");
                   x.setAttribute("data-target", "#context-menu");
               });
         
            var context_menu = document.getElementById("context-menu");
            var arrChild = context_menu.childNodes;
            var arrChild2 = GetArray(arrChild);
            var myUl = arrChild2.find(x => x.className == "dropdown-menu");
            console.log(myUl);
            var myLi = document.createElement("li");
            var myA = document.createElement("a");
            //myA.href = "http://www.shnu.edu.cn";
            myA.setAttribute("onclick", "showMsg()");
            myA.innerText = "myA";
            myLi.appendChild(myA);
            myUl.appendChild(myLi);
        }

           function SetContentMenu() {
               var arrSpan_Collect = document.getElementsByTagName("span");
               var arrSpan = GetArray(arrSpan_Collect);
               arrSpan.forEach(x => {
                   attachContext(x.id);
               });
         
     
        }


         function showMsg(context, e) {
            e = e || event;
            var tag = e.target || e.srcElement;
            alert(tag.innerHTML);

            console.log(context);
            console.log(e);

            //    alert($(e.target).text());
//            alert("showMsg()");
        }
     
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-info mt-2">
        <div class="panel-body">
            <ul class="nav">
                <li class="nav-item">
                    <asp:Label ID="lblTitle" runat="server" Text="区域信息" Width="100px" CssClass="h6 text-warning"></asp:Label>
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_QueryRegion" Text="使用查询区" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_FeatureRegion" Text="使用功能区" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_ListRegion" Text="使用列表区" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_EditRegion" Text="使用编辑区" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_DetailRegion" Text="使用详细信息区" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse_ExcelExportRegion" Text="使用导出区" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>
                <li class="nav-item ml-2">
                    <input id="btnSetContentMenu" type="button" value="button" onclick="SetContentMenu()" />
                </li>
            </ul>
        </div>
    </div>
       <div id="context-menu">
        <ul class="dropdown-menu" role="menu">
            <li><a onclick="SetNotInUse()" tabindex="-1">不用</a></li>
            <li><a tabindex="-1">Another action</a></li>
            <li><a tabindex="-1">Something else here</a></li>
            <li class="divider"></li>
            <li><a tabindex="-1">Separated link</a></li>
        </ul>
    </div>
    <asp:Label ID="lblMsg" Style="z-index: 111; left: 278px; position: absolute; top: 21px" runat="server" CssClass="text-warning" Width="272px"></asp:Label>
    <div class="panel panel-info mt-2">
        <div class="panel-body">
            <uc1:wucQryRegion4Preview runat="server" ID="wucQryRegion4Preview1" />
        </div>
    </div>
    <div class="panel panel-info mt-2">
        <div class="panel-body">
            <uc1:wucFeatureRegionButton4Visible runat="server" ID="wucFeatureRegionButton4Visible1" />
        </div>
    </div>
    <div class="panel panel-info mt-2">
        <div class="panel-body">
            <uc1:wucListRegion4Preview runat="server" ID="wucListRegion4Preview1" />
        </div>
    </div>
    <div style="width: 100%">
        <uc1:wucEditRegion4Preview runat="server" ID="wucEditRegion4Preview1" />
    </div>
          <div style="width: 100%" >
            <uc1:wucDetailRegion4Preview runat="server" ID="wucDetailRegion4Preview1" />
    </div>
    <div style="width: 100%">

        <uc1:wucExcelExportRegion4Preview runat="server" ID="wucExcelExportRegion4Preview1" />
    </div>



</asp:Content>
