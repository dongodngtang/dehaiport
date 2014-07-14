using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Infrastructure;
using TomorrowSoft.DBUtility;
using TomorrowSoft.Model;

namespace TomorrowSoft.DAL
{
	/// <summary>
	/// 数据访问类:WhiteListRepository
	/// </summary>
	public class WhiteListRepository
	{
		public WhiteListRepository()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
            return DbHelperSQLite.GetMaxID("Id", "WhiteList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WhiteList");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id",  DbType.Int32)			};
			parameters[0].Value = Id;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool PhoneExists(string phoneNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from WhiteList");
            strSql.Append(" where PhoneNo=@phoneNo ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@phoneNo",  DbType.String)			};
            parameters[0].Value = phoneNo;

            return DbHelperSQLite.Exists(strSql.ToString(), parameters);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WhiteList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WhiteList(");
			strSql.Append("Type,PhoneNo)");
			strSql.Append(" values (");
			strSql.Append("@Type,@PhoneNo)");
			SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Type",DbType.String), 
					new SQLiteParameter("@PhoneNo", DbType.String)};
		    parameters[0].Value = model.Type;
			parameters[1].Value = model.PhoneNo;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			return rows > 0;
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WhiteList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WhiteList set ");
		    strSql.Append("Type=@Type,");
			strSql.Append("PhoneNo=@PhoneNo");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Type",DbType.String), 
					new SQLiteParameter("@PhoneNo", DbType.String),
					new SQLiteParameter("@Id",  DbType.Int32)};
		    parameters[0].Value = model.Type;
			parameters[1].Value = model.PhoneNo;
			parameters[2].Value = model.Id;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			return rows > 0;
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WhiteList ");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id",  DbType.Int32)};
			parameters[0].Value = Id;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			return rows > 0;
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WhiteList ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
			return rows > 0;
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WhiteList GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Type,PhoneNo from WhiteList");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id",  DbType.Int32)			};
			parameters[0].Value = Id;

			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
                WhiteList model = new WhiteList();
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
                    model.Id=Convert.ToInt32(ds.Tables[0].Rows[0]["Id"]);
				}
                if (ds.Tables[0].Rows[0]["Type"] != null && ds.Tables[0].Rows[0]["Type"].ToString() != "")
			    {
                    model.Type = Enum<WhiteListType>.Parse(ds.Tables[0].Rows[0]["Type"].ToString());
			    }
				if(ds.Tables[0].Rows[0]["PhoneNo"]!=null && ds.Tables[0].Rows[0]["PhoneNo"].ToString()!="")
				{
					model.PhoneNo=ds.Tables[0].Rows[0]["PhoneNo"].ToString();
				}
				return model;
			}
		    return null;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select *");
			strSql.Append(" FROM WhiteList");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM WhiteList");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            object obj = DbHelperSQLite.GetSingle(strSql.ToString());
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
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from WhiteList T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tblName", DbType.VarChar, 255),
					new SQLiteParameter("@fldName", DbType.VarChar, 255),
					new SQLiteParameter("@PageSize", DbType.Int32),
					new SQLiteParameter("@PageIndex", DbType.Int32),
					new SQLiteParameter("@IsReCount", DbType.bit),
					new SQLiteParameter("@OrderType", DbType.bit),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "WhiteList";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQLite.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

