using System;
using System.Data;
using System.Data.SQLite;
using System.Text;
using TomorrowSoft.DBUtility;

//Please add references

namespace TomorrowSoft.DAL
{
    /// <summary>
    ///     数据访问类:RegularPlayRepository
    /// </summary>
    public class RegularPlayRepository
    {
        #region  BasicMethod

        /// <summary>
        ///     增加一条数据
        /// </summary>
        public bool Add(TomorrowSoft.Model.RegularPlay model)
        {
            var strSql = new StringBuilder();
            strSql.Append("insert into RegularPlay(");
            strSql.Append("RegularType,Time,Music,PlayType,Status,Phone,PlayTimes,TerminalName)");
            strSql.Append(" values (");
            strSql.Append("@RegularType,@Time,@Music,@PlayType,@Status,@Phone,@PlayTimes,@TerminalName )");
            SQLiteParameter[] parameters =
                {
                    new SQLiteParameter("@RegularType", DbType.String, 50),
                    new SQLiteParameter("@Time", DbType.String),
                    new SQLiteParameter("@Music", DbType.String, 50),
                    new SQLiteParameter("@PlayType", DbType.String, 50),
                    new SQLiteParameter("@Status", DbType.Int32),
                     new SQLiteParameter("@Phone", DbType.String, 50),
                     new SQLiteParameter("@PlayTimes", DbType.String, 50),
                     new SQLiteParameter( "@TerminalName",DbType.String)
                };
    
            parameters[0].Value = model.RegularType;
            parameters[1].Value = model.Time;
            parameters[2].Value = model.Music;
            parameters[3].Value = model.PlayType;
            parameters[4].Value = model.Status;
            parameters[5].Value = model.Phone;
            parameters[6].Value = model.PlayTimes;
            parameters[7].Value = model.TerminalName;

            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
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
        ///     更新一条数据
        /// </summary>
        public bool Update(TomorrowSoft.Model.RegularPlay model)
        {
            var strSql = new StringBuilder();
            strSql.Append("update RegularPlay set ");
            strSql.Append("Id=@Id,");
            strSql.Append("RegularType=@RegularType,");
            strSql.Append("Time=@Time,");
            strSql.Append("Music=@Music,");
            strSql.Append("PlayType=@PlayType,");
            strSql.Append("Status=@Status,");
            strSql.Append("Phone=@Phone,");
            strSql.Append("PlayTimes=@PlayTimes  ");
            strSql.Append(" where Id=@Id ");
         
            SQLiteParameter[] parameters =
                {
                    new SQLiteParameter("@Id", DbType.Int32, 8),
                    new SQLiteParameter("@RegularType", DbType.String, 50),
                    new SQLiteParameter("@Time", DbType.String),
                    new SQLiteParameter("@Music", DbType.String, 50),
                    new SQLiteParameter("@PlayType", DbType.String, 50),
                    new SQLiteParameter("@Status", DbType.Int32),
                    new SQLiteParameter("@Phone", DbType.String),
                    new SQLiteParameter("@PlayTimes", DbType.String),
                };
            parameters[0].Value = model.Id;
            parameters[1].Value = model.RegularType;
            parameters[2].Value = model.Time;
            parameters[3].Value = model.Music;
            parameters[4].Value = model.PlayType;
            parameters[5].Value = model.Status;
            parameters[6].Value = model.Phone;
            parameters[7].Value = model.PlayTimes;


            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
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
        ///     删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            //该表无主键信息，请自定义主键/条件字段
            var strSql = new StringBuilder();
            strSql.Append("delete from RegularPlay ");
            strSql.Append(" where Id=@Id ");
            SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id",  DbType.Int32,16)			};
            parameters[0].Value = id;

            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
            return rows > 0;
        }


        /// <summary>
        ///     得到一个对象实体
        /// </summary>
        public TomorrowSoft.Model.RegularPlay GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            var strSql = new StringBuilder();
            strSql.Append("select Id,RegularType,Time,Music,PlayType,Status from RegularPlay ");
            strSql.Append(" where ");
            SQLiteParameter[] parameters =
                {
                };

            var model = new TomorrowSoft.Model.RegularPlay();
            DataSet ds = DbHelperSQLite.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        ///     得到一个对象实体
        /// </summary>
        public TomorrowSoft.Model.RegularPlay DataRowToModel(DataRow row)
        {
            var model = new TomorrowSoft.Model.RegularPlay();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["RegularType"] != null)
                {
                    model.RegularType = row["RegularType"].ToString();
                }
                if (row["Time"] != null && row["Time"].ToString() != "")
                {
                    model.Time = row["Time"].ToString();
                }
                if (row["Music"] != null)
                {
                    model.Music = row["Music"].ToString();
                }
                if (row["PlayType"] != null)
                {
                    model.PlayType = row["PlayType"].ToString();
                }
                if (row["Status"] != null)
                {
                    model.Status = int .Parse( row["Status"].ToString());
                }
                if (row["Phone"] != null)
                {
                    model.Phone = row["Phone"].ToString();
                }
                if (row["PlayTimes"] != null)
                {
                    model.PlayTimes = row["PlayTimes"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        ///     获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append("select Id,RegularType,Time,Music,PlayType,Status,Phone,PlayTimes,TerminalName ");
            strSql.Append(" FROM RegularPlay");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQLite.Query(strSql.ToString());
        }

        /// <summary>
        ///     获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            var strSql = new StringBuilder();
            strSql.Append("select count(1) FROM RegularPlay ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
        ///     分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            var strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T. desc");
            }
            strSql.Append(")AS Row, T.*  from RegularPlay T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQLite.Query(strSql.ToString());
        }

     
        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}