<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="shop.Web.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名：<input type="text" name="uname"/>
            <br/>
            密码：<input type="password" name="upwd"/>
            <br/>
            验证码：<input type="text" name="vcode"/>
            <img src="../VCode.ashx"/>
            <br/>
            <input type="submit" value="登录"/>
            <br/>
            <%=Msg %>
        </div>
    </form>
</body>
</html>
