<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookTypeList.aspx.cs" Inherits="shop.Web.Admin.BookTypeList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Context/zTreeStyle/zTreeStyle.css" rel="stylesheet" />
    <script src="../js/jquery-3.2.1.min.js"></script>
    <script src="../js/jquery.ztree.core-3.5.min.js"></script>
    <script>
        function PromptDo(id,isParent) {
            var temp = prompt("请输入您要进行的操作,1.添加子级,2.修改,3.删除");
            switch (temp) {
                case '1'://增加子级
                    location.href = 'BookTypeAdd.aspx?pid=' + id;
                    break;
                case '2'://修改
                    location.href = 'BookTypeEdit.aspx?id=' + id;
                    break;
                case '3'://删除
                    //判断删除的项是否为父节点
                    if (isParent) {
                        alert("该节点下包含子节点，不可以直接删除！");
                        return
                    }
                    $.post(
                        'BookTypeRemove.ashx',
                        {
                            id: id
                        },
                        function (msg) {
                            if (msg == 1) {
                                location.href= 'BookTypeList.aspx';
                            }
                            else {
                                alert("删除失败！！！");
                            }
                        }
                    )
                    break;
                case "":

                    break;
                case null:

                    break;
                default:
                    alert("输入有误！！！");
                    break;
            }
        }
    </script>
    <title></title>
</head>
<body>
    <a href="BookTypeAdd.aspx?pid=0">添加一级分类</a>
    <br/>
    <ul id="treeDemo" class="ztree"></ul>
    <script>
        var setting = {
            data: {
                simpleData: {
                    enable: true
                }
            },
            callback: {
                beforeClick: function (treeId, treeNode) {
                    PromptDo(treeNode.id, treeNode.isParent);
                }
            }
        };
        var zNodes =<%=ZTree%>;
        //[
        //{ id: 1, pId: 0, name: "父节点1 - 展开", open: true },
        //];
        $.fn.zTree.init($("#treeDemo"), setting, zNodes);
    </script>
</body>
</html>
