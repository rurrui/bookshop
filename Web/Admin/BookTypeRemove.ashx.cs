using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shop.Web.Admin
{
    /// <summary>
    /// BookTypeRemove 的摘要说明
    /// </summary>
    public class BookTypeRemove : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request["id"]);
            shop.BLL.BookType btBll = new BLL.BookType();
            if (btBll.Delete(id))
            {
                context.Response.Write(1);
            }
            else
            {
                context.Response.Write(0);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}