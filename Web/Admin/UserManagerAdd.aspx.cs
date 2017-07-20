using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shop.Web.Admin
{
    public partial class UserManagerAdd : MyPageBase//System.Web.UI.Page
    {
        protected string Msg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request["uname"]))
            {
                shop.Model.UserManager umModel = new Model.UserManager()
                {
                    UserName = Request["uname"],
                    UserPwd =shop.Common.DEncrypt.MD5Encrypt.EncryptString(Request["upwd"]),
                };
                shop.BLL.UserManager umBll = new BLL.UserManager();
                if (umBll.Add(umModel)>0)
                {
                    Response.Redirect("UserManagerList.aspx");
                }
                else
                {
                    Msg = "出现错误，添加失败";
                }
            }
        }
    }
}