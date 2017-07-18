using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shop.IDal;

namespace shop.DalFactory
{
    public partial class SimpleFactory
    {
        public static IBookType GetBookTypeDal()
        {
            return new shop.DAL.BookType();
        }
    }
}
