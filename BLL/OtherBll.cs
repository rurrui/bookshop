using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using shop.IDal;
using shop.DalFactory;

namespace shop.BLL
{
   public partial class BookType
    {
        //简单工厂
        // private readonly IBookType dal = SimpleFactory.GetBookTypeDal();
        //抽象工厂
        private readonly IBookType dal = AbstractFactory.GetBookType();
        public bool Delete(shop.Model.BookType booktype)
        {
            return Delete(booktype.TypeId);
        }
    }
    public partial class UserManager
    {
        //更新数据
        public bool Update(shop.Model.UserManager model,bool isPwdEdit)
        {
            return dal.Update(model,isPwdEdit);
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(shop.Model.UserManager model,out int id)
        {
            return dal.Exists(model,out id);
        }
    }
}
