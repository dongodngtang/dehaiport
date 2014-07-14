using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using TomorrowSoft.DBUtility;
using TomorrowSoft.Model;

namespace TomorrowSoft.DAL
{
	/// <summary>
	/// 数据访问类:UserRepository
	/// </summary>
	public partial class UserRepository
	{
		public UserRepository()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from User");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Guid,16)			};
			parameters[0].Value = Id;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into User(");
			strSql.Append("Id,UserName,Password,Level,Remember)");
			strSql.Append(" values (");
			strSql.Append("@Id,@UserName,@Password,@Level,@Remember)");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Guid,16),
					new SQLiteParameter("@UserName", DbType.String,50),
					new SQLiteParameter("@Password", DbType.String,50),
					new SQLiteParameter("@Level", DbType.String,20),
					new SQLiteParameter("@Remember", DbType.Boolean ,1)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.UserName;
			parameters[2].Value = model.Password;
			parameters[3].Value = model.Level;
			parameters[4].Value = model.Remember;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			return rows > 0;
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update User set ");
			strSql.Append("UserName=@UserName,");
			strSql.Append("Password=@Password,");
			strSql.Append("Level=@Level,");
			strSql.Append("Remember=@Remember");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@UserName", DbType.String,50),
					new SQLiteParameter("@Password", DbType.String,50),
					new SQLiteParameter("@Level", DbType.String,20),
					new SQLiteParameter("@Remember", DbType.Boolean,1),
					new SQLiteParameter("@Id", DbType.Guid,16)};
			parameters[0].Value = model.UserName;
			parameters[1].Value = model.Password;
			parameters[2].Value = model.Level;
			parameters[3].Value = model.Remember;
			parameters[4].Value = model.Id;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			return rows > 0;
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from User ");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Guid,16)			};
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
			strSql.Append("delete from User ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
			return rows > 0;
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public User GetModel(Guid Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,UserName,Password,Level,Remember from User ");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Guid,16)			};
			parameters[0].Value = Id;
			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
                User model = new User();
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id=new Guid(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UserName"]!=null && ds.Tables[0].Rows[0]["UserName"].ToString()!="")
				{
					model.UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Password"]!=null && ds.Tables[0].Rows[0]["Password"].ToString()!="")
				{
					model.Password=ds.Tables[0].Rows[0]["Password"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Level"]!=null && ds.Tables[0].Rows[0]["Level"].ToString()!="")
				{
					model.Level=ds.Tables[0].Rows[0]["Level"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Remember"]!=null && ds.Tables[0].Rows[0]["Remember"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["Remember"].ToString()=="1")||(ds.Tables[0].Rows[0]["Remember"].ToString().ToLower()=="true"))
					{
						model.Remember=true;
					}
					else
					{
						model.Remember=false;
					}
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
			strSql.Append("select Id,UserName,Password,Level,Remember ");
			strSql.Append(" FROM User ");
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
			strSql.Append("select count(1) FROM User ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQLite.GetSingle(strSql.ToString());
			if (obj == null)
				return 0;
		    return Convert.ToInt32(obj);
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
			strSql.Append(")AS Row, T.*  from User T ");
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
			parameters[0].Value = "User";
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

