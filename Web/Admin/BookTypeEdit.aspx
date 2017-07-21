<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookTypeEdit.aspx.cs" Inherits="shop.Web.Admin.BookTypeEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       编号：<%=btModel.TypeId %>
        <br/>
        <input type="hidden" name="tid" value="<%=btModel.TypeId %>""/>
        名称：<input type="text" name="tTitle" value="<%=btModel.TypeTitle %>""/>
        <br/>
        <input type="hidden" name="tpid" value="<%=btModel.TypeParentId %>""/>
        <input type="submit" value="修改"/>
    </form>
</body>
</html>
