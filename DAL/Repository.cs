using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SQLite;
using System.Reflection;
using System.Text;
using Infrastructure;
using TomorrowSoft.DBUtility;

namespace TomorrowSoft.DAL
{
    public class Repository<T> where T : new()
    {
        #region  Method

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQLite.GetMaxID("Id", typeof(T).Name);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1)");
            strSql.Append("from ");
            strSql.Append(typeof(T).Name);
            strSql.Append(" where Id=@Id ");
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@Id",  DbType.Int32)			};
            parameters[0].Value = Id;

            return DbHelperSQLite.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(T model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into " + typeof(T).Name + "(");
            strSql.Append("Address,PhoneNo,Grouping,GroupPhone,AllPhone)");
            strSql.Append(" values (");
            strSql.Append("@Address,@PhoneNo,@Grouping,@GroupPhone,@AllPhone)");
            SQLiteParameter[] parameters = {
	
                new SQLiteParameter("@Address", DbType.String),
                new SQLiteParameter("@Grouping",DbType.String), 
                new SQLiteParameter("@PhoneNo", DbType.String),
                new SQLiteParameter("@GroupPhone",DbType.String),
                new SQLiteParameter("@AllPhone",DbType.String)};


           
            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
            return rows > 0;
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(T model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update "+typeof(T).Name+" set ");
            strSql.Append(" where Id=@Id ");

            var parameters2 = new Collection<SQLiteParameter>();
            foreach (var info in model.GetType().GetProperties())
            {
                var value = info.GetValue(model, null);
                if(!value.IsNullOrEmpty())
                {
                    var param = "@" + info.Name;
                    strSql.Append(info.Name + "=" + param + ",");
                    parameters2.Add(new SQLiteParameter(param,info.GetValue(model, null)));
                }
            }

            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters2);
            return rows > 0;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + typeof(T).Name);
            strSql.Append(" where Id=@Id ");
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@Id",  DbType.Int32)			};
            parameters[0].Value = Id;

            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
            return rows > 0;
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + typeof(T).Name);
            strSql.Append(" where Id in (" + Idlist + ")  ");
            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString());
            return rows > 0;
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public T GetModel(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from " + typeof(T).Name);
            strSql.Append(" where Id=@Id ");
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@Id",  DbType.Int32)			};
            parameters[0].Value = Id;

            var ds = DbHelperSQLite.Query(strSql.ToString(), parameters);
            var model = new T();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (var p in typeof(T).GetProperties())
                {
                    var newValue = ds.Tables[0].Rows[0][p.Name];
                    if (!newValue.IsNullOrEmpty())
                    {
                        p.SetValue(model, newValue, null);
                    }
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *");
            strSql.Append(" FROM "+typeof(T).Name);
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQLite.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM " + typeof(T).Name);
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQLite.GetSingle(strSql.ToString());
            if (obj == null)
                return 0;
            return Convert.ToInt32(obj);
        }

        #endregion  Method
    }
}