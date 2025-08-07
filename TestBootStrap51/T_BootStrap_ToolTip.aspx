<%@ Page Language="vb" AutoEventWireup="false"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Scripts/jquery-3.5.1.slim.min.js"></script>    
    <script src="Scripts/umd/popper.min.js"></script>
        <link href="./Content/bootstrap.min.css" rel="stylesheet" />
        <script type="text/javascript" src="./Scripts/bootstrap.min.js"></script>

<%--    <script src="Scripts/popper.min.js"></script>

    <script src="./Scripts/bootstrap.bundle.min.js"></script>

    --%>
    <%--    <script src="https://cdn.jsdelivr.net/npm/jquery@3.5.1/dist/jquery.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.0/dist/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.0/dist/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>--%>


</head>

<body>

    <button type="button" class="btn btn-secondary" data-toggle="tooltip" data-placement="top" title="Tooltip on top">
        Tooltip on top
    </button>
    <button type="button" class="btn btn-secondary" data-toggle="tooltip" data-placement="right" title="Tooltip on right">
        Tooltip on right
    </button>
    <button type="button" class="btn btn-secondary" data-toggle="tooltip" data-placement="bottom" title="Tooltip on bottom">
        Tooltip on bottom
    </button>
    <button type="button" class="btn btn-secondary" data-toggle="tooltip" data-placement="left" title="Tooltip on left">
        Tooltip on left
    </button>


    <input keyid="00005452" id="btnUpdate" type="button" name="" class="btn btn-outline-info btn-sm text-nowrap" value="修改" data-toggle="tooltip" data-placement="left" data-html="true" title="修改<br/>Id:btnUpdateRecord<br/>Update ==>PrjTabFld" />

    <button keyid="00005452" id="btnUpdate1" type="button" name="" class="btn btn-outline-info btn-sm text-nowrap" data-toggle="tooltip" data-placement="left" data-html="true" title="修改<br/>Id:btnUpdateRecord<br/>Update ==>PrjTabFld">
        修改
    </button>
    <button type="button" class="btn btn-secondary" data-toggle="tooltip" data-html="true" title="<em>Tooltip</em> <u>with</u> <b>HTML</b>">
        Tooltip with HTML
    </button>
    <br />

    <!-- HTML to write -->
    <a href="#" data-toggle="tooltip" title="Some tooltip text!">Hover over me-pyf</a>

    <!-- Generated markup by the plugin -->
    <div class="tooltip bs-tooltip-top" role="tooltip">
        <div class="arrow"></div>
        <div class="tooltip-inner">
            pyf-Some tooltip text!pyf
        </div>
    </div>

</body>
</html>
