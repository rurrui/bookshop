using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace shop.DAL
{
	/// <summary>
	/// 数据访问类:BookShop
	/// </summary>
	public partial class BookShop
	{
		public BookShop()
		{}
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Bid", "BookShop");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Bid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from BookShop");
            strSql.Append(" where Bid=@Bid");
            SqlParameter[] parameters = {
                    new SqlParameter("@Bid", SqlDbType.Int,4)
            };
            parameters[0].Value = Bid;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(shop.Model.BookShop model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BookShop(");
			strSql.Append("Title,TitleHot,PriceOld,PriceNew,Author,Publisher,PublishDate,OnSaleDate,ISBN,TypeId,Details,ImgTitle)");
			strSql.Append(" values (");
			strSql.Append("@Title,@TitleHot,@PriceOld,@PriceNew,@Author,@Publisher,@PublishDate,@OnSaleDate,@ISBN,@TypeId,@Details,@ImgTitle)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.NVarChar,50),
					new SqlParameter("@TitleHot", SqlDbType.NVarChar,100),
					new SqlParameter("@PriceOld", SqlDbType.Decimal,5),
					new SqlParameter("@PriceNew", SqlDbType.Decimal,5),
					new SqlParameter("@Author", SqlDbType.NVarChar,50),
					new SqlParameter("@Publisher", SqlDbType.NVarChar,50),
					new SqlParameter("@PublishDate", SqlDbType.Date,3),
					new SqlParameter("@OnSaleDate", SqlDbType.Date,3),
					new SqlParameter("@ISBN", SqlDbType.NVarChar,50),
					new SqlParameter("@TypeId", SqlDbType.NVarChar,50),
					new SqlParameter("@Details", SqlDbType.NVarChar,-1),
					new SqlParameter("@ImgTitle", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.TitleHot;
			parameters[2].Value = model.PriceOld;
			parameters[3].Value = model.PriceNew;
			parameters[4].Value = model.Author;
			parameters[5].Value = model.Publisher;
			parameters[6].Value = model.PublishDate;
			parameters[7].Value = model.OnSaleDate;
			parameters[8].Value = model.ISBN;
			parameters[9].Value = model.TypeId;
			parameters[10].Value = model.Details;
			parameters[11].Value = model.ImgTitle;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(shop.Model.BookShop model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BookShop set ");
			strSql.Append("Title=@Title,");
			strSql.Append("TitleHot=@TitleHot,");
			strSql.Append("PriceOld=@PriceOld,");
			strSql.Append("PriceNew=@PriceNew,");
			strSql.Append("Author=@Author,");
			strSql.Append("Publisher=@Publisher,");
			strSql.Append("PublishDate=@PublishDate,");
			strSql.Append("OnSaleDate=@OnSaleDate,");
			strSql.Append("ISBN=@ISBN,");
			strSql.Append("TypeId=@TypeId,");
			strSql.Append("Details=@Details,");
			strSql.Append("ImgTitle=@ImgTitle");
			strSql.Append(" where Bid=@Bid");
			SqlParameter[] parameters = {
					new SqlParameter("@Title", SqlDbType.NVarChar,50),
					new SqlParameter("@TitleHot", SqlDbType.NVarChar,100),
					new SqlParameter("@PriceOld", SqlDbType.Decimal,5),
					new SqlParameter("@PriceNew", SqlDbType.Decimal,5),
					new SqlParameter("@Author", SqlDbType.NVarChar,50),
					new SqlParameter("@Publisher", SqlDbType.NVarChar,50),
					new SqlParameter("@PublishDate", SqlDbType.Date,3),
					new SqlParameter("@OnSaleDate", SqlDbType.Date,3),
					new SqlParameter("@ISBN", SqlDbType.NVarChar,50),
					new SqlParameter("@TypeId", SqlDbType.NVarChar,50),
					new SqlParameter("@Details", SqlDbType.NVarChar,-1),
					new SqlParameter("@ImgTitle", SqlDbType.NVarChar,50),
					new SqlParameter("@Bid", SqlDbType.Int,4)};
			parameters[0].Value = model.Title;
			parameters[1].Value = model.TitleHot;
			parameters[2].Value = model.PriceOld;
			parameters[3].Value = model.PriceNew;
			parameters[4].Value = model.Author;
			parameters[5].Value = model.Publisher;
			parameters[6].Value = model.PublishDate;
			parameters[7].Value = model.OnSaleDate;
			parameters[8].Value = model.ISBN;
			parameters[9].Value = model.TypeId;
			parameters[10].Value = model.Details;
			parameters[11].Value = model.ImgTitle;
			parameters[12].Value = model.Bid;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Bid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BookShop ");
			strSql.Append(" where Bid=@Bid");
			SqlParameter[] parameters = {
					new SqlParameter("@Bid", SqlDbType.Int,4)
			};
			parameters[0].Value = Bid;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Bidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BookShop ");
			strSql.Append(" where Bid in ("+Bidlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public shop.Model.BookShop GetModel(int Bid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Bid,Title,TitleHot,PriceOld,PriceNew,Author,Publisher,PublishDate,OnSaleDate,ISBN,TypeId,Details,ImgTitle from BookShop ");
			strSql.Append(" where Bid=@Bid");
			SqlParameter[] parameters = {
					new SqlParameter("@Bid", SqlDbType.Int,4)
			};
			parameters[0].Value = Bid;

			shop.Model.BookShop model=new shop.Model.BookShop();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public shop.Model.BookShop DataRowToModel(DataRow row)
		{
			shop.Model.BookShop model=new shop.Model.BookShop();
			if (row != null)
			{
				if(row["Bid"]!=null && row["Bid"].ToString()!="")
				{
					model.Bid=int.Parse(row["Bid"].ToString());
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["TitleHot"]!=null)
				{
					model.TitleHot=row["TitleHot"].ToString();
				}
				if(row["PriceOld"]!=null && row["PriceOld"].ToString()!="")
				{
					model.PriceOld=decimal.Parse(row["PriceOld"].ToString());
				}
				if(row["PriceNew"]!=null && row["PriceNew"].ToString()!="")
				{
					model.PriceNew=decimal.Parse(row["PriceNew"].ToString());
				}
				if(row["Author"]!=null)
				{
					model.Author=row["Author"].ToString();
				}
				if(row["Publisher"]!=null)
				{
					model.Publisher=row["Publisher"].ToString();
				}
				if(row["PublishDate"]!=null && row["PublishDate"].ToString()!="")
				{
					model.PublishDate=DateTime.Parse(row["PublishDate"].ToString());
				}
				if(row["OnSaleDate"]!=null && row["OnSaleDate"].ToString()!="")
				{
					model.OnSaleDate=DateTime.Parse(row["OnSaleDate"].ToString());
				}
				if(row["ISBN"]!=null)
				{
					model.ISBN=row["ISBN"].ToString();
				}
				if(row["TypeId"]!=null)
				{
					model.TypeId=row["TypeId"].ToString();
				}
				if(row["Details"]!=null)
				{
					model.Details=row["Details"].ToString();
				}
				if(row["ImgTitle"]!=null)
				{
					model.ImgTitle=row["ImgTitle"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Bid,Title,TitleHot,PriceOld,PriceNew,Author,Publisher,PublishDate,OnSaleDate,ISBN,TypeId,Details,ImgTitle ");
			strSql.Append(" FROM BookShop ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Bid,Title,TitleHot,PriceOld,PriceNew,Author,Publisher,PublishDate,OnSaleDate,ISBN,TypeId,Details,ImgTitle ");
			strSql.Append(" FROM BookShop ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM BookShop ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Bid desc");
			}
			strSql.Append(")AS Row, T.*  from BookShop T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "BookShop";
			parameters[1].Value = "Bid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

