using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using TomorrowSoft.DBUtility;
//Please add references
using TomorrowSoft.Model;

namespace TomorrowSoft.DAL
{
	/// <summary>
	/// 数据访问类:HistoryRecordRepository
	/// </summary>
	public partial class HistoryRecordRepository
	{
		public HistoryRecordRepository()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("Id", "HistoryRecord"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from HistoryRecord");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id",  DbType.Int32)			};
			parameters[0].Value = Id;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HistoryRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HistoryRecord(");
			strSql.Append("Handler,PhoneNo,HandlerTime,Context)");
			strSql.Append(" values (");
			strSql.Append("@Handler,@PhoneNo,@HandlerTime,@Context)");
			SQLiteParameter[] parameters = {
				
					new SQLiteParameter("@Handler", DbType.String),
					new SQLiteParameter("@PhoneNo", DbType.String),
					new SQLiteParameter("@HandlerTime", DbType.Date),
					new SQLiteParameter("@Context", DbType.String)};
			
			parameters[0].Value = model.Handler;
			parameters[1].Value = model.PhoneNo;
			parameters[2].Value = model.HandlerTime;
			parameters[3].Value = model.Context;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			return rows > 0;
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HistoryRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update HistoryRecord set ");
			strSql.Append("Handler=@Handler,");
			strSql.Append("PhoneNo=@PhoneNo,");
			strSql.Append("HandlerTime=@HandlerTime,");
			strSql.Append("Context=@Context");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Handler", DbType.String),
					new SQLiteParameter("@PhoneNo", DbType.String),
					new SQLiteParameter("@HandlerTime", DbType.Date),
					new SQLiteParameter("@Context", DbType.String),
					new SQLiteParameter("@Id",  DbType.Guid,16)};
			parameters[0].Value = model.Handler;
			parameters[1].Value = model.PhoneNo;
			parameters[2].Value = model.HandlerTime;
			parameters[3].Value = model.Context;
			parameters[4].Value = model.Id;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			return rows > 0;
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HistoryRecord ");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id",  DbType.Int32,16)			};
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
			strSql.Append("delete from HistoryRecord ");
//			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
			return rows > 0;
		}

       

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public HistoryRecord GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Handler,PhoneNo,HandlerTime,Context from HistoryRecord ");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id",  DbType.Guid,16)			};
			parameters[0].Value = Id;

			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
                HistoryRecord model = new HistoryRecord();
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
                    model.Id=int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Handler"]!=null && ds.Tables[0].Rows[0]["Handler"].ToString()!="")
				{
					model.Handler=ds.Tables[0].Rows[0]["Handler"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PhoneNo"]!=null && ds.Tables[0].Rows[0]["PhoneNo"].ToString()!="")
				{
					model.PhoneNo=ds.Tables[0].Rows[0]["PhoneNo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["HandlerTime"]!=null && ds.Tables[0].Rows[0]["HandlerTime"].ToString()!="")
				{
				    model.HandlerTime = DateTime.Parse(ds.Tables[0].Rows[0]["HandlerTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Context"]!=null && ds.Tables[0].Rows[0]["Context"].ToString()!="")
				{
					model.Context=ds.Tables[0].Rows[0]["Context"].ToString();
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
			strSql.Append("select Id,Handler,PhoneNo,HandlerTime,Context ");
			strSql.Append(" FROM HistoryRecord ");
			if(strWhere.Trim()=="")
			{
                strSql.Append(" order by Id DESC");
			}
            else
            {
                strSql.Append(" where " + strWhere + " order by Id desc ");

            }
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM HistoryRecord ");
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
			strSql.Append(")AS Row, T.*  from HistoryRecord T ");
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
			parameters[0].Value = "HistoryRecord";
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

