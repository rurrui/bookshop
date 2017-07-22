using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shop.Web.Test
{
    /// <summary>
    /// FileUploadAjax1 的摘要说明
    /// </summary>
    public class FileUploadAjax1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            HttpPostedFile file1 = context.Request.Files["UpImg1"];

            //图片的虚拟路径
            string Path1 = "/Cover/" + file1.FileName;
            //图片的绝对路径
            string Path2 = context.Request.MapPath(Path1);

            file1.SaveAs(Path2);
            context.Response.Write(Path1);
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