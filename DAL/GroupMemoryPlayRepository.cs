using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using TomorrowSoft.DBUtility;

//Please add references
namespace TomorrowSoft.DAL
{
	/// <summary>
	/// 数据访问类:GroupMemoryPlay
	/// </summary>
	public partial class GroupMemoryPlayRepository
	{
		public GroupMemoryPlayRepository()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("Id", "GroupMemoryPlay"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from GroupMemoryPlay");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,8)			};
			parameters[0].Value = Id;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(TomorrowSoft.Model.GroupMemoryPlay model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into GroupMemoryPlay(");
			strSql.Append("GroupName,TerminalName,TerminalNo,PlayDelay,PlayTimes,Music,PlayStyle,PlayMinute)");
			strSql.Append(" values (");
			strSql.Append("@GroupName,@TerminalName,@TerminalNo,@PlayDelay,@PlayTimes,@Music,@PlayStyle, @PlayMinute)");
		    SQLiteParameter[] parameters =
		        {

		            new SQLiteParameter("@GroupName", DbType.String, 50),
		            new SQLiteParameter("@TerminalName", DbType.String, 50),
		            new SQLiteParameter("@TerminalNo", DbType.String, 50),
		            new SQLiteParameter("@PlayDelay", DbType.Int32, 4),
		            new SQLiteParameter("@PlayTimes", DbType.Int32, 4),
		            new SQLiteParameter("@Music", DbType.String),
		            new SQLiteParameter("@PlayStyle", DbType.String),
		            new SQLiteParameter("@PlayMinute", DbType.String)
		        };
			
			parameters[0].Value = model.GroupName;
			parameters[1].Value = model.TerminalName;
			parameters[2].Value = model.TerminalNo;
			parameters[3].Value = model.PlayDelay;
			parameters[4].Value = model.PlayTimes;
            parameters[5].Value = model.Music;
            parameters[6].Value = model.PlayStyle;
		    parameters[7].Value = model.PlayMinute;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(TomorrowSoft.Model.GroupMemoryPlay model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update GroupMemoryPlayRepository set ");
			strSql.Append("GroupName=@GroupName,");
			strSql.Append("TerminalName=@TerminalName,");
			strSql.Append("TerminalNo=@TerminalNo,");
			strSql.Append("PlayDelay=@PlayDelay,");
			strSql.Append("PlayTimes=@PlayTimes");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@GroupName", DbType.String,50),
					new SQLiteParameter("@TerminalName", DbType.String,50),
					new SQLiteParameter("@TerminalNo", DbType.String,50),
					new SQLiteParameter("@PlayDelay", DbType.Int32,4),
					new SQLiteParameter("@PlayTimes", DbType.Int32,4),
					new SQLiteParameter("@Id", DbType.Int32,8)};
			parameters[0].Value = model.GroupName;
			parameters[1].Value = model.TerminalName;
			parameters[2].Value = model.TerminalNo;
			parameters[3].Value = model.PlayDelay;
			parameters[4].Value = model.PlayTimes;
			parameters[5].Value = model.Id;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GroupMemoryPlay ");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,8)			};
			parameters[0].Value = Id;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GroupMemoryPlay ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
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
		/// 得到一个对象实体
		/// </summary>
		public TomorrowSoft.Model.GroupMemoryPlay GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,GroupName,TerminalName,TerminalNo,PlayDelay,PlayTimes from GroupMemoryPlay ");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32,8)			};
			parameters[0].Value = Id;

			TomorrowSoft.Model.GroupMemoryPlay model=new TomorrowSoft.Model.GroupMemoryPlay();
			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public TomorrowSoft.Model.GroupMemoryPlay DataRowToModel(DataRow row)
		{
			TomorrowSoft.Model.GroupMemoryPlay model=new TomorrowSoft.Model.GroupMemoryPlay();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["GroupName"]!=null)
				{
					model.GroupName=row["GroupName"].ToString();
				}
				if(row["TerminalName"]!=null)
				{
					model.TerminalName=row["TerminalName"].ToString();
				}
				if(row["TerminalNo"]!=null)
				{
					model.TerminalNo=row["TerminalNo"].ToString();
				}
				if(row["PlayDelay"]!=null && row["PlayDelay"].ToString()!="")
				{
					model.PlayDelay= double.Parse(row["PlayDelay"].ToString());
				}
				if(row["PlayTimes"]!=null && row["PlayTimes"].ToString()!="")
				{
					model.PlayTimes=int.Parse(row["PlayTimes"].ToString());
				}
                if (row["TerminalName"] != null)
                {
                    model.TerminalName = row["TerminalName"].ToString();
                }
                if (row["PlayStyle"] != null)
                {
                    model.PlayStyle = row["PlayStyle"].ToString();
                }
                if (row["PlayMinute"] != null)
                {
                    model.PlayMinute = row["PlayMinute"].ToString();
                }
                if (row["Music"] != null)
                {
                    model.Music = row["Music"].ToString();
                }
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,GroupName,TerminalName,TerminalNo,PlayDelay,PlayTimes,PlayStyle,PlayMinute,Music ");
			strSql.Append(" FROM GroupMemoryPlay ");
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
			strSql.Append("select count(1) FROM GroupMemoryPlay ");
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
			strSql.Append(")AS Row, T.*  from GroupMemoryPlay T ");
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
			parameters[0].Value = "GroupMemoryPlay";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQLite.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod

	    public DataSet GetGroupList()
	    {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct GroupName");
            strSql.Append(" FROM GroupMemoryPlay ");
            return DbHelperSQLite.Query(strSql.ToString());
	    }

	    public bool DeletGroup(string group)
	    {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from GroupMemoryPlay ");
            strSql.Append(" where GroupName=@GroupName ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@GroupName",  DbType.String)			};
            parameters[0].Value = group;

            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
            return rows > 0;
	    }
	}
}

