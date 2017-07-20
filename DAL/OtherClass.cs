﻿using Maticsoft.DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.DAL
{
    //针对生成的文件，需要使用部分类，在另一个物理文件中进行代码的扩展
   public partial class BookType : shop.IDal.IBookType
    {

    }
    public partial class UserManager
    {
        /// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(shop.Model.UserManager model,bool isPwdEdit)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update UserManager set ");
            strSql.Append("UserName=@UserName");
            if (isPwdEdit)
            {
                strSql.Append(",UserPwd=@UserPwd");
            }
            strSql.Append(" where UserId=@UserId");
            List<SqlParameter> parameters = new List<SqlParameter>() {
                    new SqlParameter("@UserName", SqlDbType.NVarChar,50){
                        Value=model.UserName
                    },
                    
                    new SqlParameter("@UserId", SqlDbType.Int,4){
                        Value=model.UserId
                    } };
            if (isPwdEdit)
            {
                parameters.Add(new SqlParameter("@UserPwd", SqlDbType.NVarChar, 50)
                {
                    Value = model.UserPwd
                });
            }
          

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters.ToArray());
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
        /// 是否存在该记录
        /// </summary>
        public bool Exists(shop.Model.UserManager model,out int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from UserManager");
            strSql.Append(" where UserName=@name and UserPwd=@pwd");
            SqlParameter[] parameters = {
                    new SqlParameter("@name", SqlDbType.NVarChar, 50)
                    {
                        Value=model.UserName
                    },
                    new SqlParameter("@pwd",model.UserPwd)

            };
            strSql = new StringBuilder("");
            strSql.Append("select UserId from UserManager where UserName=@name and UserPwd=@pwd");
            id=Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString(), parameters));
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
    }
}
