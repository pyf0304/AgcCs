<%@ Page Language="C#" AutoEventWireup="True" MasterPageFile="~/Webform/MasterPage/Main1.Master"
    CodeBehind="wfmDownLoadClsFile.aspx.cs" Inherits="AGC.Webform.wfmDownLoadClsFile" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .myli{
            float:left; 
            list-style:none;
            vertical-align:bottom;
        }
    </style>
    <div class="download">
        <div style="float: left;">
            <ul>
                <li class="myli" style="width:180px">生成代码必备文件下载</li>
                <li class="myli" style="width:50px"><span onclick="location.href='../../index.aspx'">返回首页</span></li>
                <li class="myli" style="width:60px">
                    <span id="spanReturn" runat="server" onclick="location.href='../../Frame1/Admin/index.aspx'">返回</span>
                    <%--<asp:HyperLink ID="hlReturn" CssClass="LinkButton_Defa" NavigateUrl="../../Frame1/Admin/index.aspx" runat="server">返回</asp:HyperLink>--%>

                </li>

            </ul>
            </div>
        <div style="float: left;">
            <p><b>说明：</b>在使用生成时，必须要下载以下的文件，这里下载的文件都是最新版。</p>
        </div>
        <ul>
            <li>
                <asp:LinkButton ID="lbDownPubDataBase" Style="z-index: 103; float: left;" runat="server" OnClick="lbDownPubDataBase_Click">下载数据底层</asp:LinkButton></li>
            <li>
                <asp:LinkButton ID="lbDownSimplePrj" Style="z-index: 100; float: left;" runat="server" OnClick="lbDownSimplePrj_Click">下载简单样例工程</asp:LinkButton></li>
             <li>
                <asp:LinkButton ID="lbDownAndroidSample" Style="z-index: 100; float: left;" runat="server" OnClick="lbDownAndroidSample_Click">下载安卓样例工程</asp:LinkButton></li>
            <li>
                <asp:LinkButton ID="lbDownCommFunc4Web" Style="z-index: 103; float: left;" runat="server" OnClick="lbDownCommFunc4Web_Click">下载基于Web的常用函数</asp:LinkButton></li>
            <li>
                <asp:LinkButton ID="lbDownWinClient" Style="z-index: 100; float: left;" runat="server" OnClick="lbDownWinClient_Click">下载Win版生成代码客户端</asp:LinkButton></li>
            <li>
                <asp:LinkButton ID="lbDownCommFunc4Win" Style="z-index: 103; float: left;" runat="server" OnClick="lbDownCommFunc4Win_Click">下载基于Win的常用函数</asp:LinkButton></li>
            <li>
                <asp:LinkButton ID="lbDownExportExcel" Style="z-index: 103; float: left;" runat="server" OnClick="lbDownExportExcel_Click">下载用于Excel导出的公共类</asp:LinkButton></li>
            <li>
                <asp:LinkButton ID="lbDownGeneralPlatform4WS" Style="z-index: 103; float: left;" runat="server" OnClick="lbDownGeneralPlatform4WS_Click">下载用户管理统一平台操作类</asp:LinkButton></li>
        </ul>


    </div>
</asp:Content>
