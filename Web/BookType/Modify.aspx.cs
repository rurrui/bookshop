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
namespace shop.Web.BookType
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int TypeId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(TypeId);
				}
			}
		}
			
	private void ShowInfo(int TypeId)
	{
		shop.BLL.BookType bll=new shop.BLL.BookType();
		shop.Model.BookType model=bll.GetModel(TypeId);
		this.lblTypeId.Text=model.TypeId.ToString();
		this.txtTypeTitle.Text=model.TypeTitle;
		this.txtTypeParentId.Text=model.TypeParentId.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtTypeTitle.Text.Trim().Length==0)
			{
				strErr+="TypeTitle不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtTypeParentId.Text))
			{
				strErr+="TypeParentId格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int TypeId=int.Parse(this.lblTypeId.Text);
			string TypeTitle=this.txtTypeTitle.Text;
			int TypeParentId=int.Parse(this.txtTypeParentId.Text);


			shop.Model.BookType model=new shop.Model.BookType();
			model.TypeId=TypeId;
			model.TypeTitle=TypeTitle;
			model.TypeParentId=TypeParentId;

			shop.BLL.BookType bll=new shop.BLL.BookType();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
