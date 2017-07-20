using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shop.Web.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected string Msg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //验证码
                if (Session["ValidateCode"]==null)
                {
                    return;
                }
                if (Request["vcode"].Equals(Session["ValidateCode"].ToString()))
                {
                    //用户名和密码
                    shop.Model.UserManager umModel = new Model.UserManager()
                    {
                        UserName=Request["uname"],
                        UserPwd=shop.Common.DEncrypt.MD5Encrypt.EncryptString(Request["upwd"]),
                    };
                    shop.BLL.UserManager umBll = new BLL.UserManager();
                    int id = 0;
                    if (umBll.Exists(umModel,out id))
                    {
                        Session["ValidateCode"] = null;
                        umModel.UserId = id;
                        //标记登录成功
                        Session["UserModel"] = umModel;
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        Msg = "用户名或密码错误！";
                    }
                   
                }
                else
                {
                    Msg = "验证码错误";
                }
               
            }
        }
    }
}