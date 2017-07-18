using System;
namespace shop.Model
{
	/// <summary>
	/// BookType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BookType
	{
		public BookType()
		{}
		#region Model
		private int _typeid;
		private string _typetitle;
		private int? _typeparentid;
		/// <summary>
		/// 
		/// </summary>
		public int TypeId
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TypeTitle
		{
			set{ _typetitle=value;}
			get{return _typetitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TypeParentId
		{
			set{ _typeparentid=value;}
			get{return _typeparentid;}
		}
		#endregion Model

	}
}

