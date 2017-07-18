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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string TypeTitle=this.txtTypeTitle.Text;
			int TypeParentId=int.Parse(this.txtTypeParentId.Text);

			shop.Model.BookType model=new shop.Model.BookType();
			model.TypeTitle=TypeTitle;
			model.TypeParentId=TypeParentId;

			shop.BLL.BookType bll=new shop.BLL.BookType();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
