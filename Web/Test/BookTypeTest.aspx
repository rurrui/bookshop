<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookTypeTest.aspx.cs" Inherits="shop.Web.Test.BookTypeTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1" OnSelectedIndexChanged="ListView1_SelectedIndexChanged" DataKeyNames="TypeId" InsertItemPosition="LastItem">
                <AlternatingItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
                            <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                        </td>
                        <td>
                            <asp:Label ID="TypeIdLabel" runat="server" Text='<%# Eval("TypeId") %>' />
                        </td>
                        <td>
                            <asp:Label ID="TypeTitleLabel" runat="server" Text='<%# Eval("TypeTitle") %>' />
                        </td>
                        <td>
                            <asp:Label ID="TypeParentIdLabel" runat="server" Text='<%# Eval("TypeParentId") %>' />
                        </td>
                    </tr>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="更新" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="取消" />
                        </td>
                        <td>
                            <asp:Label ID="TypeIdLabel1" runat="server" Text='<%# Eval("TypeId") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="TypeTitleTextBox" runat="server" Text='<%# Bind("TypeTitle") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="TypeParentIdTextBox" runat="server" Text='<%# Bind("TypeParentId") %>' />
                        </td>
                    </tr>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table runat="server" style="">
                        <tr>
                            <td>未返回数据。</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <InsertItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="插入" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="清除" />
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:TextBox ID="TypeTitleTextBox" runat="server" Text='<%# Bind("TypeTitle") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="TypeParentIdTextBox" runat="server" Text='<%# Bind("TypeParentId") %>' />
                        </td>
                    </tr>
                </InsertItemTemplate>
                <ItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
                            <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                        </td>
                        <td>
                            <asp:Label ID="TypeIdLabel" runat="server" Text='<%# Eval("TypeId") %>' />
                        </td>
                        <td>
                            <asp:Label ID="TypeTitleLabel" runat="server" Text='<%# Eval("TypeTitle") %>' />
                        </td>
                        <td>
                            <asp:Label ID="TypeParentIdLabel" runat="server" Text='<%# Eval("TypeParentId") %>' />
                        </td>
                    </tr>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                    <tr runat="server" style="">
                                        <th runat="server"></th>
                                        <th runat="server">TypeId</th>
                                        <th runat="server">TypeTitle</th>
                                        <th runat="server">TypeParentId</th>
                                    </tr>
                                    <tr id="itemPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style=""></td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="删除" />
                            <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="编辑" />
                        </td>
                        <td>
                            <asp:Label ID="TypeIdLabel" runat="server" Text='<%# Eval("TypeId") %>' />
                        </td>
                        <td>
                            <asp:Label ID="TypeTitleLabel" runat="server" Text='<%# Eval("TypeTitle") %>' />
                        </td>
                        <td>
                            <asp:Label ID="TypeParentIdLabel" runat="server" Text='<%# Eval("TypeParentId") %>' />
                        </td>
                    </tr>
                </SelectedItemTemplate>
            </asp:ListView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BookShopConnectionString %>" DeleteCommand="DELETE FROM [BookType] WHERE [TypeId] = @TypeId" InsertCommand="INSERT INTO [BookType] ([TypeTitle], [TypeParentId]) VALUES (@TypeTitle, @TypeParentId)" SelectCommand="SELECT * FROM [BookType]" UpdateCommand="UPDATE [BookType] SET [TypeTitle] = @TypeTitle, [TypeParentId] = @TypeParentId WHERE [TypeId] = @TypeId">
                <DeleteParameters>
                    <asp:Parameter Name="TypeId" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="TypeTitle" Type="String" />
                    <asp:Parameter Name="TypeParentId" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="TypeTitle" Type="String" />
                    <asp:Parameter Name="TypeParentId" Type="Int32" />
                    <asp:Parameter Name="TypeId" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="shop.Model.BookType" DeleteMethod="Delete" InsertMethod="Add" SelectMethod="GetAllList" TypeName="shop.BLL.BookType" UpdateMethod="Update">
            </asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
