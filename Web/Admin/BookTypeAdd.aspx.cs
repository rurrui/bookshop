using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shop.Web.Admin
{
    public partial class BookTypeAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                shop.Model.BookType btModle = new Model.BookType()
                {
                    TypeTitle=Request["title"],
                    TypeParentId=int.Parse(Request["pid"]),
                };
                shop.BLL.BookType btBll = new BLL.BookType();
                if (btBll.Add(btModle)>0)
                {
                    Response.Redirect("BookTypeList.aspx");
                }
                else
                {
                    Response.Write("添加失败！！！");
                }
            }
        }
    }
}