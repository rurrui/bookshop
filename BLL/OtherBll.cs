using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shop.BLL
{
   public partial class BookType
    {
        public bool Delete(shop.Model.BookType booktype)
        {
            return Delete(booktype.TypeId);
        }
    }
}
