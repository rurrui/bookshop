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
namespace shop.Web.BookShop
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int Bid=(Convert.ToInt32(strid));
					ShowInfo(Bid);
				}
			}
		}
		
	private void ShowInfo(int Bid)
	{
		shop.BLL.BookShop bll=new shop.BLL.BookShop();
		shop.Model.BookShop model=bll.GetModel(Bid);
		this.lblBid.Text=model.Bid.ToString();
		this.lblTitle.Text=model.Title;
		this.lblTitleHot.Text=model.TitleHot;
		this.lblPriceOld.Text=model.PriceOld.ToString();
		this.lblPriceNew.Text=model.PriceNew.ToString();
		this.lblAuthor.Text=model.Author;
		this.lblPublisher.Text=model.Publisher;
		this.lblPublishDate.Text=model.PublishDate.ToString();
		this.lblOnSaleDate.Text=model.OnSaleDate.ToString();
		this.lblISBN.Text=model.ISBN;
		this.lblTypeId.Text=model.TypeId;
		this.lblDetails.Text=model.Details;
		this.lblImgTitle.Text=model.ImgTitle;

	}


    }
}
