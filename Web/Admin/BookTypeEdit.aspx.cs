using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shop.Web.Admin
{
    public partial class BookTypeEdit : System.Web.UI.Page
    {
        protected shop.Model.BookType btModel { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            shop.BLL.BookType btBll = new BLL.BookType();
           // shop.Model.BookType btModel = new Model.BookType();
            if (!IsPostBack)
            {
                //第一次访问页面，展示待修改数据
                int id = int.Parse(Request["id"]);
                btModel = btBll.GetModel(id);
            }
            else
            {
                //更新数据
                shop.Model.BookType model = new Model.BookType()
                {
                    TypeId=int.Parse(Request["tid"]),
                    TypeTitle=Request["tTitle"],
                    TypeParentId=int.Parse(Request["tpid"]),
                };
                if (btBll.Update(model))
                {
                    Response.Redirect("BookTypeList.aspx");
                }
                else
                {
                    Response.Write("更新失败");
                }
            }
        }
    }
}