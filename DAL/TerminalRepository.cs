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
	/// 数据访问类:TerminalRepository
	/// </summary>
	public partial class TerminalRepository
	{
		public TerminalRepository()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("Id", "Terminal"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Terminal");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id",  DbType.Int32)			};
			parameters[0].Value = Id;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// Phone是否存在该记录
        /// </summary>
        public bool PhoneExists(string phone)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Terminal");
            strSql.Append(" where PhoneNo=@phone ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@phone",  DbType.String)			};
            parameters[0].Value = phone;

            return DbHelperSQLite.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// GroupNo是否存在该记录
        /// </summary>
        public Terminal GroupNoExists(string grouping)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from Terminal ");
            strSql.Append(" where Grouping=@Grouping ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@Grouping",  DbType.String)			};
            parameters[0].Value = grouping;
            DataSet ds = DbHelperSQLite.Query(strSql.ToString(), parameters);
            Terminal terminal1;
            
              if (ToTerminal(ds, out terminal1)) return terminal1;
        
            return null;
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Terminal model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Terminal(");
            strSql.Append("Address,PhoneNo,Grouping,GroupPhone,AllPhone,Name)");
			strSql.Append(" values (");
            strSql.Append("@Address,@PhoneNo,@Grouping,@GroupPhone,@AllPhone,@Name)");
			SQLiteParameter[] parameters = {
	
					new SQLiteParameter("@Address", DbType.String),
                    new SQLiteParameter("@Grouping",DbType.String), 
					new SQLiteParameter("@PhoneNo", DbType.String),
                    new SQLiteParameter("@GroupPhone",DbType.String),
                    new SQLiteParameter("@AllPhone",DbType.String),
                    new SQLiteParameter("@Name",DbType.String)};
		    
	
			parameters[0].Value = model.Address;
            parameters[1].Value = model.Grouping;
		    parameters[2].Value = model.PhoneNo;
            parameters[3].Value = model.GroupPhone;
            parameters[4].Value = model.AllPhone;
            parameters[5].Value = model.Name;
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			return rows > 0;
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Terminal model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Terminal set ");
			strSql.Append("Address=@Address,");
            strSql.Append("GroupPhone=@GroupPhone,");
		    strSql.Append("Grouping=@Grouping,");
			strSql.Append("PhoneNo=@PhoneNo,");
            strSql.Append("AllPhone=@AllPhone,");
            strSql.Append("Name=@Name");
			strSql.Append(" where Id=@Id ");
		    SQLiteParameter[] parameters =
		        {
		            new SQLiteParameter("@Address", DbType.String),
		            new SQLiteParameter("@PhoneNo", DbType.String),
		            new SQLiteParameter("@Id", DbType.Int32),
		            new SQLiteParameter("@Grouping", DbType.String),
                   new SQLiteParameter("@GroupPhone", DbType.String),
                    new SQLiteParameter("@AllPhone", DbType.String),
                    new SQLiteParameter("@Name", DbType.String)
		        };
					
			parameters[0].Value = model.Address;
			parameters[1].Value = model.PhoneNo;
			parameters[2].Value = model.Id;
		    parameters[3].Value = model.Grouping;
            parameters[4].Value = model.GroupPhone;
            parameters[5].Value = model.AllPhone;
            parameters[6].Value = model.Name;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			return rows > 0;
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Terminal ");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id",  DbType.Int32)			};
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
			strSql.Append("delete from Terminal ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
			return rows > 0;
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Terminal GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select * from Terminal ");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id",  DbType.Int32)			};
			parameters[0].Value = Id;

			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
		    Terminal terminal1;
		    if (ToTerminal(ds, out terminal1)) return terminal1;
		    return null;
		}

	    private static bool ToTerminal(DataSet ds, out Terminal terminal1)
	    {
	        if (ds.Tables[0].Rows.Count > 0)
	        {
	            Terminal model = new Terminal();
	            if (ds.Tables[0].Rows[0]["Id"] != null && ds.Tables[0].Rows[0]["Id"].ToString() != "")
	            {
	                model.Id = Convert.ToInt32(ds.Tables[0].Rows[0]["Id"]);
	            }
	            if (ds.Tables[0].Rows[0]["Address"] != null && ds.Tables[0].Rows[0]["Address"].ToString() != "")
	            {
	                model.Address = ds.Tables[0].Rows[0]["Address"].ToString();
	            }
	            if (ds.Tables[0].Rows[0]["PhoneNo"] != null && ds.Tables[0].Rows[0]["PhoneNo"].ToString() != "")
	            {
	                model.PhoneNo = ds.Tables[0].Rows[0]["PhoneNo"].ToString();
	            }
	            if (ds.Tables[0].Rows[0]["Grouping"] != null && ds.Tables[0].Rows[0]["Grouping"].ToString() != "")
	            {
	                model.PhoneNo = ds.Tables[0].Rows[0]["Grouping"].ToString();
	            }
	            if (ds.Tables[0].Rows[0]["GroupPhone"] != null && ds.Tables[0].Rows[0]["GroupPhone"].ToString() != "")
	            {
	                model.GroupPhone = ds.Tables[0].Rows[0]["GroupPhone"].ToString();
	            }
	            if (ds.Tables[0].Rows[0]["AllPhone"] != null && ds.Tables[0].Rows[0]["AllPhone"].ToString() != "")
	            {
	                model.AllPhone = ds.Tables[0].Rows[0]["AllPhone"].ToString();
	            }
	            if (ds.Tables[0].Rows[0]["Name"] != null && ds.Tables[0].Rows[0]["Name"].ToString() != "")
	            {
                    model.Name = ds.Tables[0].Rows[0]["Name"].ToString();
	            }
	            {
	                terminal1 = model;
	                return true;
	            }
	        }
	        terminal1 = null;
	        return false;
	    }

	    /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select *");
			strSql.Append(" FROM Terminal ");
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
			strSql.Append("select count(1) FROM Terminal ");
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
			strSql.Append(")AS Row, T.*  from Terminal T ");
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
			parameters[0].Value = "Terminal";
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

