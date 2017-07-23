<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="wangEditor.aspx.cs" 
    Inherits="shop.Web.Test.wangEditor"
    ValidateRequest="false"%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>wangEditor demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="editor">
            <p>欢迎使用 <b>wangEditor</b> 富文本编辑器</p>
        </div>
        
        
        <script type="text/javascript" src="../js/wangEditor.min.js"></script>
        <script type="text/javascript">
            var E = window.wangEditor
            var editor = new E('#editor')
            //上传图片到服务器
            editor.customConfig.uploadImgShowBase64 = true
            editor.customConfig.uploadImgMaxSize = 3 * 1024 * 1024
            editor.create();
        </script>
        
    </form>
</body>
</html>
