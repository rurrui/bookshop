<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManagerEdit.aspx.cs" Inherits="shop.Web.Admin.UserManagerEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <input type="hidden" name="uid" value="<%=UMModel.UserId %>"""/>
        用户名：<input type="text" name="uname" value="<%=UMModel.UserName %>""/>
        <br/>
        密码：<input type="password" name="upwd" value="<%=UMModel.UserPwd %>""/>
        <input type="hidden" name="upwd2" value="<%=UMModel.UserPwd %>"/>
        <br/>
        <input type="submit" value="修改"/>
    </form>
</body>
</html>
