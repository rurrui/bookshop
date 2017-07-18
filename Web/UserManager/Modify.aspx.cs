using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace shop.Web.UserManager
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int UserId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(UserId);
				}
			}
		}
			
	private void ShowInfo(int UserId)
	{
		shop.BLL.UserManager bll=new shop.BLL.UserManager();
		shop.Model.UserManager model=bll.GetModel(UserId);
		this.lblUserId.Text=model.UserId.ToString();
		this.txtUserName.Text=model.UserName;
		this.txtUserPwd.Text=model.UserPwd;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserName.Text.Trim().Length==0)
			{
				strErr+="UserName不能为空！\\n";	
			}
			if(this.txtUserPwd.Text.Trim().Length==0)
			{
				strErr+="UserPwd不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int UserId=int.Parse(this.lblUserId.Text);
			string UserName=this.txtUserName.Text;
			string UserPwd=this.txtUserPwd.Text;


			shop.Model.UserManager model=new shop.Model.UserManager();
			model.UserId=UserId;
			model.UserName=UserName;
			model.UserPwd=UserPwd;

			shop.BLL.UserManager bll=new shop.BLL.UserManager();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
