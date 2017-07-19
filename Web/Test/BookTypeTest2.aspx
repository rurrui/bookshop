<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookTypeTest2.aspx.cs" Inherits="shop.Web.Test.BookTypeTest2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table border="1">
                        <tr>
                            <th>编号</th>
                            <th>标题</th>
                        </tr>
                </HeaderTemplate>
                <FooterTemplate>
                     </table>
                </FooterTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("TypeId")%></td>
                        <td><%#Eval("TypeTitle")%></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
