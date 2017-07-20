using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shop.Web.Admin
{
    public partial class UserManagerEdit : System.Web.UI.Page
    {
        protected shop.Model.UserManager UMModel { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            shop.BLL.UserManager umBll = new BLL.UserManager();
            if (IsPostBack)
            {
                //shop.BLL.UserManager umBll = new BLL.UserManager();
                bool isPwdEdit = false;
                //修改处理
                UMModel = new shop.Model.UserManager()
                {
                    UserId = int.Parse(Request["uid"]),
                    UserName = Request["uname"],
                };
                //判断密码是否修改
                if (!Request["upwd"].Equals(Request["upwd2"]))
                {
                    isPwdEdit = true;
                    UMModel.UserPwd = shop.Common.DEncrypt.MD5Encrypt.EncryptString(Request["upwd"]);
                }
                if (umBll.Update(UMModel, isPwdEdit))
                {
                    Response.Redirect("UserManagerList.aspx");
                }
                else
                {
                    Response.Write("修改失败！");
                }
            }
            else
            {
                //修改展示
                int id = int.Parse(Request["id"]);
               
                UMModel = umBll.GetModel(id);
            }
        }
    }
}