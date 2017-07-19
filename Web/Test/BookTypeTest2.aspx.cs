using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shop.Web.Test
{
    public partial class BookTypeTest2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            shop.BLL.BookType btBll = new BLL.BookType();
            Repeater1.DataSource = btBll.GetAllList();
            Repeater1.DataBind();
        }
    }
}