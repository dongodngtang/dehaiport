using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SQLite;
using Infrastructure;
using TomorrowSoft.DBUtility;
using TomorrowSoft.Model;

namespace TomorrowSoft.DAL
{
	public class LongSmsRepository
	{
		#region  Method

		/// <summary>
		/// 增加一条数据
		/// </summary>
        public bool Add(LongSms model)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("insert into LongSms(");
			strSql.Append("Content,Current,Identifier,Phone,Time,Total)");
			strSql.Append("values (");
            strSql.Append("@Content,@Current,@Identifier,@Phone,@Time,@Total)");
			SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Content",DbType.String), 
					new SQLiteParameter("@Current", DbType.Int32),
					new SQLiteParameter("@Identifier", DbType.String),
					new SQLiteParameter("@Phone", DbType.String),
					new SQLiteParameter("@Time", DbType.DateTime),
					new SQLiteParameter("@Total", DbType.Int32)
                                           };
		    parameters[0].Value = model.Content;
			parameters[1].Value = model.Current;
			parameters[2].Value = model.Identifier;
			parameters[3].Value = model.Phone;
			parameters[4].Value = model.Time;
			parameters[5].Value = model.Total;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			return rows > 0;
		}


		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			var strSql=new StringBuilder();
			strSql.Append("select *");
			strSql.Append(" FROM WhiteList ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		#endregion  Method

	    public IList<LongSms> GetBy(string phone, string identifier, DateTime time)
	    {
            var strSql = new StringBuilder();
            strSql.Append("select *");
            strSql.Append(" FROM LongSms ");
            strSql.Append(" where Phone=@Phone and Identifier=@Identifier and datetime([Time]) >= datetime('" + time.AddMinutes(-15).ToString("yyyy-MM-dd HH:mm:ss") + "') and datetime([Time]) <= datetime('" + time.AddMinutes(15).ToString("yyyy-MM-dd HH:mm:ss") + "') ORDER BY Current ASC ");//, dtpEnd.Value.ToString("yyyy-MM-dd HH:mm")");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Phone",DbType.String), 
					new SQLiteParameter("@Identifier", DbType.String)
                                           };
            parameters[0].Value = phone;
            parameters[1].Value = identifier;
            var dt=DbHelperSQLite.Query(strSql.ToString(),parameters).Tables[0];
            var modelList = new List<LongSms>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                for (int n = 0; n < rowsCount; n++)
                {
                    var model = new LongSms();
                    if (!dt.Rows[n]["Id"].IsNullOrEmpty())
                    {
                        model.Id = Convert.ToInt32(dt.Rows[n]["Id"]);
                    }
                    if (!dt.Rows[n]["Phone"].IsNullOrEmpty())
                    {
                        model.Phone = dt.Rows[n]["Phone"].ToString();
                    }
                    if (!dt.Rows[n]["Content"].IsNullOrEmpty())
                    {
                        model.Content = dt.Rows[n]["Content"].ToString();
                    }
                    if (!dt.Rows[n]["Current"].IsNullOrEmpty())
                    {
                        model.Current = Convert.ToInt32(dt.Rows[n]["Current"]);
                    }
                    if (!dt.Rows[n]["Total"].IsNullOrEmpty())
                    {
                        model.Total = Convert.ToInt32(dt.Rows[n]["Total"]);
                    }
                    if (!dt.Rows[n]["Identifier"].IsNullOrEmpty())
                    {
                        model.Identifier = dt.Rows[n]["Identifier"].ToString();
                    }
                    if (!dt.Rows[n]["Time"].IsNullOrEmpty())
                    {
                        model.Time = DateTime.Parse(dt.Rows[n]["Time"].ToString());
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }
	}
}

