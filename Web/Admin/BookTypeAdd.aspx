<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookTypeAdd.aspx.cs" Inherits="shop.Web.Admin.BookTypeAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="hidden" name="pid" value="<%=Request["pid"] %>""/>
            分类名称：<input type="text" name="title"/>
            <br/>
            <input type="submit" value="添加"/>
        </div>
    </form>
</body>
</html>
