using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.IDal
{
    public partial interface IBookType
    {

        int GetMaxId();
        bool Exists(int TypeId);
        int Add(shop.Model.BookType model);
        bool Update(shop.Model.BookType model);
        bool Delete(int TypeId);
        bool DeleteList(string TypeIdlist);
        shop.Model.BookType GetModel(int TypeId);
        shop.Model.BookType DataRowToModel(DataRow row);
        DataSet GetList(string strWhere);
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
    }
}
