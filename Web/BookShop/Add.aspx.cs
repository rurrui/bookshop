﻿using System;
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
namespace shop.Web.BookShop
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtTitle.Text.Trim().Length==0)
			{
				strErr+="Title不能为空！\\n";	
			}
			if(this.txtTitleHot.Text.Trim().Length==0)
			{
				strErr+="TitleHot不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPriceOld.Text))
			{
				strErr+="PriceOld格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPriceNew.Text))
			{
				strErr+="PriceNew格式错误！\\n";	
			}
			if(this.txtAuthor.Text.Trim().Length==0)
			{
				strErr+="Author不能为空！\\n";	
			}
			if(this.txtPublisher.Text.Trim().Length==0)
			{
				strErr+="Publisher不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtPublishDate.Text))
			{
				strErr+="PublishDate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOnSaleDate.Text))
			{
				strErr+="OnSaleDate格式错误！\\n";	
			}
			if(this.txtISBN.Text.Trim().Length==0)
			{
				strErr+="ISBN不能为空！\\n";	
			}
			if(this.txtTypeId.Text.Trim().Length==0)
			{
				strErr+="TypeId不能为空！\\n";	
			}
			if(this.txtDetails.Text.Trim().Length==0)
			{
				strErr+="Details不能为空！\\n";	
			}
			if(this.txtImgTitle.Text.Trim().Length==0)
			{
				strErr+="ImgTitle不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Title=this.txtTitle.Text;
			string TitleHot=this.txtTitleHot.Text;
			decimal PriceOld=decimal.Parse(this.txtPriceOld.Text);
			decimal PriceNew=decimal.Parse(this.txtPriceNew.Text);
			string Author=this.txtAuthor.Text;
			string Publisher=this.txtPublisher.Text;
			DateTime PublishDate=DateTime.Parse(this.txtPublishDate.Text);
			DateTime OnSaleDate=DateTime.Parse(this.txtOnSaleDate.Text);
			string ISBN=this.txtISBN.Text;
			string TypeId=this.txtTypeId.Text;
			string Details=this.txtDetails.Text;
			string ImgTitle=this.txtImgTitle.Text;

			shop.Model.BookShop model=new shop.Model.BookShop();
			model.Title=Title;
			model.TitleHot=TitleHot;
			model.PriceOld=PriceOld;
			model.PriceNew=PriceNew;
			model.Author=Author;
			model.Publisher=Publisher;
			model.PublishDate=PublishDate;
			model.OnSaleDate=OnSaleDate;
			model.ISBN=ISBN;
			model.TypeId=TypeId;
			model.Details=Details;
			model.ImgTitle=ImgTitle;

			shop.BLL.BookShop bll=new shop.BLL.BookShop();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
