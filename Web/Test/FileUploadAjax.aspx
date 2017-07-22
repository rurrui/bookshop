<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUploadAjax.aspx.cs" Inherits="shop.Web.Test.FileUploadAjax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="../js/jquery-3.2.1.min.js"></script>
    <script src="../js/ajaxfileupload.js"></script>
    <script>
        $(function () {
            $("#btnUpload").click(function () {
                $.ajaxFileUpload({
                    url: 'FileUploadAjax.ashx',
                    fileElementId: 'UpImg1',
                    success: function (data) {
                        $("#img1").attr("src", $(data).text());
                    }
                })
            })
        })
    </script>
    <title></title>
</head>
<body>
    <input type="file" id="UpImg1" name="UpImg1"/>
    <input type="button" id="btnUpload" value="上传"/>
    <br/>
    <img id="img1" src=""/>
</body>
</html>
