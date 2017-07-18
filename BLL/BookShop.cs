using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using shop.Model;
namespace shop.BLL
{
	/// <summary>
	/// BookShop
	/// </summary>
	public partial class BookShop
	{
		private readonly shop.DAL.BookShop dal=new shop.DAL.BookShop();
		public BookShop()
		{}
        #region  BasicMethod
        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Bid)
        {
            return dal.Exists(Bid);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int  Add(shop.Model.BookShop model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(shop.Model.BookShop model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Bid)
		{
			
			return dal.Delete(Bid);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Bidlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(Bidlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public shop.Model.BookShop GetModel(int Bid)
		{
			
			return dal.GetModel(Bid);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public shop.Model.BookShop GetModelByCache(int Bid)
		{
			
			string CacheKey = "BookShopModel-" + Bid;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Bid);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (shop.Model.BookShop)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<shop.Model.BookShop> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<shop.Model.BookShop> DataTableToList(DataTable dt)
		{
			List<shop.Model.BookShop> modelList = new List<shop.Model.BookShop>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				shop.Model.BookShop model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

