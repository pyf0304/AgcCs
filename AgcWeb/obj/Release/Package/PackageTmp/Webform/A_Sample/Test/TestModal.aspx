<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestModal.aspx.cs" Inherits="AGC.Webform.Test.TestModal" %>
<!DOCTYPE HTML>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>模态弹出窗的使用</title>
    
    <script src="../../../Scripts/jquery-3.6.0.min.js"></script>
    
    <script src="../../../Scripts/bootstrap.min.js"></script>
    <link href="../../../Content/bootstrap.min.css" rel="stylesheet" />
    <script>
        function ShowModal()
        {
            $('#mymodal-data').modal('show');
        }
    </script>
</head>
<body>
 
<!-- data-target触发模态弹出窗元素 -->
<button class="btn btn-primary" data-toggle="modal" data-target="#mymodal-data" type="button">通过data-target触发</button>
<button class="btn btn-primary"type="button" onclick="ShowModal()">通过Clickt触发</button>
<!-- 模态弹出窗内容 -->
<div class="modal fade" id="mymodal-data" tabindex="-1" role="dialog" aria-labelledby="mySmallModalLabel" aria-hidden="true">
    <div class="modal-dialog">
		<div class="modal-content">
			<div class="modal-header">
				<button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">×</span><span class="sr-only">Close</span></button>
				<h4 class="modal-title">模态弹出窗标题</h4>
			</div>
			<div class="modal-body">
				<p>模态弹出窗主体内容</p>
			</div>
			<div class="modal-footer">
				<button type="button" class="btn btn-default" data-dismiss="modal">关闭</button>
				<button type="button" class="btn btn-primary">保存</button>
			</div>
		</div>
	</div>
</div>

</body>
</html>
