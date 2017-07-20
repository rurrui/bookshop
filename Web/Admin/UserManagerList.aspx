<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManagerList.aspx.cs" Inherits="shop.Web.Admin.UserManagerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="inc/css.css" rel="stylesheet" />
    <link href="../layui/build/css/layui.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="../js/jquery-3.2.1.min.js"></script>
    <script>
        function RemoveConfirm(id) {
            if (confirm("确定要删除吗?")) {


                $.post(
                    'UserManagerRemove.ashx',
                    {
                        id: id
                    },
                    function (msg) {
                        if (msg == 1) {
                            window.location.reload();
                        } else {
                            alert("删除失败！");
                        }
                    }
                )
            }
        }
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table width="100%" border="0" align="center" cellpadding="2" cellspacing="1" bordercolor="#799AE1" class="tableBorder">
                        <tbody>
                            <tr>
                                <th align="center" colspan="16" style="height: 23px">管理员列表</th>
                            </tr>
                            <tr bgcolor="#DEE5FA">
                                <td colspan="16" align="center" class="txlrow">&nbsp;</td>
                            </tr>
                            <tr align="center" bgcolor="#799AE1">
                                <td width="30%" align="center" class="txlHeaderBackgroundAlternate">编号</td>
                                <td width="40%" align="center" class="txlHeaderBackgroundAlternate">用户名</td>
                                <td width="30%" align="center" class="txlHeaderBackgroundAlternate">操作</td>
                            </tr>
                </HeaderTemplate>

                <FooterTemplate>
                    <tr>
                        <td align="center" class="txlrow" colspan="3">
                            <%=PagerBar%>
                        </td>
                    </tr>
                    </tbody></table>
                </FooterTemplate>

                <ItemTemplate>
                    <tr bgcolor="#DEE5FA">
                        <td align="center" class="txlrow"><%#Eval("UserId") %></td>
                        <td align="center" class="txlrow"><%#Eval("UserName") %></td>
                        <td align="center" class="txlrow">
                            <a href='UserManagerEdit.aspx?id=<%#Eval("UserId") %>'>修改</a>
                            <a href='javascript:RemoveConfirm(<%# Eval("UserId") %>)'>删除</a>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
    <script src="../layui/build/layui.js"></script>
</body>
</html>
