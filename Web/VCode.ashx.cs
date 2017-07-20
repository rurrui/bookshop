using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace shop.Web
{
    /// <summary>
    /// ValidateCode 的摘要说明
    /// </summary>
    public class VCode : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image/jpeg";

            int codeLength = 4;

            string sourceString = "abcdef0123456789";

            string temp = "";
            Random r = new Random();
            for (int i = 0; i < codeLength; i++)
            {
                temp += sourceString[r.Next(0, sourceString.Length)];
            }
            context.Session["ValidateCode"] = temp;

            Bitmap bitmap = new Bitmap(50, 20);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            g.DrawRectangle(new Pen(Color.Black), 0, 0, bitmap.Width - 1, bitmap.Height - 1);
            g.DrawString(temp, new Font("Consolas", 14), new SolidBrush(Color.Blue), 0, 0, new StringFormat(StringFormatFlags.LineLimit));

            bitmap.Save(context.Response.OutputStream, ImageFormat.Jpeg);
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