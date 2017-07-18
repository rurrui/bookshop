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
        private readonly IBookType dal = SimpleFactory.GetBookTypeDal();
        public bool Delete(shop.Model.BookType booktype)
        {
            return Delete(booktype.TypeId);
        }
    }
}
