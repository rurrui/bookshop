<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookTypeList.aspx.cs" Inherits="shop.Web.Admin.BookTypeList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Context/zTreeStyle/zTreeStyle.css" rel="stylesheet" />
    <script src="../js/jquery-3.2.1.min.js"></script>
    <script src="../js/jquery.ztree.core-3.5.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <div class="zTreeDemoBackground left">
        <ul id="treeDemo" class="ztree"></ul>
        <script>
                var setting = {
                    data: {
                        simpleData: {
                            enable: true
                        }
                    }
                };
            var zNodes =<%=ZTree%>;
                //[
                    //{ id: 1, pId: 0, name: "父节点1 - 展开", open: true },
                //];
                $.fn.zTree.init($("#treeDemo"), setting, zNodes);
        </script>
    </div>
    </form>
</body>
</html>
