using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

namespace shop.Web.Admin
{
    public partial class BookTypeList : System.Web.UI.Page
    {
        protected string ZTree { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            shop.BLL.BookType btBll = new BLL.BookType();
            DataTable dt = btBll.GetAllList().Tables[0];

            List<BookTypeTree> list = new List<BookTypeTree>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new BookTypeTree()
                {
                    id = Convert.ToInt32(row["TypeId"]),
                    pId = Convert.ToInt32(row["TypeParentId"]),
                    name = row["TypeTitle"].ToString(),
                    open = true,
                    isParent=true,
                });
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            ZTree = js.Serialize(list);
        }
    }
}