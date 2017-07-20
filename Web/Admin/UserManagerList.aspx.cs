using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace shop.Web.Admin
{
    public partial class UserManagerList : MyPageBase//System.Web.UI.Page
    {
        protected string PagerBar { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            shop.BLL.UserManager umBll = new BLL.UserManager();
            int pageIndex = 1;
            int pageSize = 5;
            //接收分页信息
            if (!string.IsNullOrEmpty(Request["pIndex"]))
            {
                pageIndex = int.Parse(Request["pIndex"]);
            }
            //验证分页的有效性
            int rowsCount = umBll.GetRecordCount("");
            int pageCount = Convert.ToInt32(Math.Ceiling(rowsCount * 1.0 / pageSize));
            if (pageIndex<=1)
            {
                pageIndex = 1;
            }
            if (pageIndex>=pageCount)
            {
                pageIndex = pageCount;
            }
            //查询当前页的数据

            int startIndex = (pageIndex - 1) * pageSize + 1;
            int endIndex = pageIndex * pageSize;
            Repeater1.DataSource=umBll.GetListByPage("", "UserId", startIndex, endIndex);
            Repeater1.DataBind();
            //构建分类字符串
           
            StringBuilder sb = new StringBuilder();
            if (pageIndex<=1)
            {
                sb.Append("首页 上一页");
            }
            else
            {
                sb.Append("<a href='?pIndex=1'>首页</a><a href='?pIndex="+(pageIndex-1)+"'>上一页</a>");
            }
            
            if (pageIndex>=pageCount)
            {
                sb.Append("下一页 末页");
            }
            else
            {
                sb.Append("<a href='?pIndex="+(pageIndex+1)+"'>下一页</a><a href='?pIndex="+pageCount+"'>末页</a>");
            }
            PagerBar = sb.ToString();
        }
    }
}