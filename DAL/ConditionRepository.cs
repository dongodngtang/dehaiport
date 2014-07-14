using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using TomorrowSoft.DBUtility;
using TomorrowSoft.Model;

namespace TomorrowSoft.DAL
{
	/// <summary>
	/// 数据访问类:Condition
	/// </summary>
	public partial class ConditionRepository
	{
		public ConditionRepository()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Condition");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32)			};
			parameters[0].Value = Id;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Condition model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Condition(");
			strSql.Append("Photovoltaic,Battery,PowerSource,QS,Horn,Charge,Discharge,Volume,HandlerTime,PhoneNo)");
			strSql.Append(" values (");
            strSql.Append("@Photovoltaic,@Battery,@PowerSource,@QS,@Horn,@Charge,@Discharge,@Volume,@HandlerTime,@PhoneNo)");
			SQLiteParameter[] parameters = {

					new SQLiteParameter("@Photovoltaic", DbType.String),
					new SQLiteParameter("@Battery", DbType.String),
					new SQLiteParameter("@PowerSource", DbType.String),
	
					new SQLiteParameter("@QS", DbType.String),
					new SQLiteParameter("@Horn", DbType.String),
					new SQLiteParameter("@Charge", DbType.String),				
                    new SQLiteParameter("@Discharge",DbType.String), 
                    new SQLiteParameter("@Volume", DbType.String),
                    new SQLiteParameter( "@HandlerTime",DbType.DateTime),
                     new SQLiteParameter("@PhoneNo",DbType.String)};
		
			parameters[0].Value = model.Photovoltaic;
			parameters[1].Value = model.Battery;
			parameters[2].Value = model.PowerSource;
	
			parameters[3].Value = model.QS;
			parameters[4].Value = model.Horn1;
            parameters[5].Value = model.Horn2;
            parameters[6].Value = model.Horn3;
            parameters[7].Value = model.Horn4;
            parameters[8].Value = model.HandlerTime;
            parameters[9].Value = model.PhoneNo;

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
		public bool Update(TomorrowSoft.Model.Condition model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Condition set ");
			strSql.Append("Photovoltaic=@Photovoltaic,");
			strSql.Append("Battery=@Battery,");
			strSql.Append("PowerSource=@PowerSource,");
			strSql.Append("QS=@QS,");
			strSql.Append("Horn=@Horn,");
			strSql.Append("Charge=@Charge,");
			strSql.Append("Discharge=@Discharge,");		  
			strSql.Append("Volume=@Volume");
            strSql.Append("HandlerTime=@HandlerTime");
            strSql.Append("PhoneNo=@PhoneNo");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Photovoltaic", DbType.String),
					new SQLiteParameter("@Battery", DbType.String),
					new SQLiteParameter("@PowerSource", DbType.String),
					new SQLiteParameter("@QS", DbType.String),
					new SQLiteParameter("@Horn", DbType.String),
					new SQLiteParameter("@Charge", DbType.String),
                    new SQLiteParameter("@Discharge",DbType.String), 
					new SQLiteParameter("@Volume", DbType.String),
                    new SQLiteParameter("@HandlerTime", DbType.String),
                    new SQLiteParameter("@PhoneNo", DbType.String),
					new SQLiteParameter("@Id", DbType.Int32)};
			parameters[0].Value = model.Photovoltaic;
			parameters[1].Value = model.Battery;
			parameters[2].Value = model.PowerSource;

			parameters[3].Value = model.QS;
			parameters[4].Value = model.Horn1;
            parameters[5].Value = model.Horn2;
            parameters[6].Value = model.Horn3;
            parameters[7].Value = model.Horn4;
            parameters[8].Value = model.HandlerTime;
            parameters[9].Value = model.PhoneNo;
			parameters[10].Value = model.Id;
		 

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
			strSql.Append("delete from Condition ");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32)			};
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
			strSql.Append("delete from Condition ");
//			strSql.Append(" where Id in ("+Idlist + ")  ");
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
		public TomorrowSoft.Model.Condition GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Photovoltaic,Battery,PowerSource,RDS,QS,Horn,Charge,Discharge,Volume,HandlerTime,PhoneNo from Condition ");
			strSql.Append(" where Id=@Id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@Id", DbType.Int32)			};
			parameters[0].Value = Id;

			TomorrowSoft.Model.Condition model=new TomorrowSoft.Model.Condition();
			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					model.Id= int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
                if (ds.Tables[0].Rows[0]["PhoneNo"] != null && ds.Tables[0].Rows[0]["PhoneNo"].ToString() != "")
                {
                    model.PhoneNo = ds.Tables[0].Rows[0]["PhoneNo"].ToString();
                }
				if(ds.Tables[0].Rows[0]["Photovoltaic"]!=null && ds.Tables[0].Rows[0]["Photovoltaic"].ToString()!="")
				{
					model.Photovoltaic=ds.Tables[0].Rows[0]["Photovoltaic"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Battery"]!=null && ds.Tables[0].Rows[0]["Battery"].ToString()!="")
				{
					model.Battery=ds.Tables[0].Rows[0]["Battery"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PowerSource"]!=null && ds.Tables[0].Rows[0]["PowerSource"].ToString()!="")
				{
					model.PowerSource=ds.Tables[0].Rows[0]["PowerSource"].ToString();
				}
				if(ds.Tables[0].Rows[0]["QS"]!=null && ds.Tables[0].Rows[0]["QS"].ToString()!="")
				{
					model.QS=ds.Tables[0].Rows[0]["QS"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Horn"]!=null && ds.Tables[0].Rows[0]["Horn"].ToString()!="")
				{
					model.Horn1=ds.Tables[0].Rows[0]["Horn"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Charge"]!=null && ds.Tables[0].Rows[0]["Charge"].ToString()!="")
				{
                    model.Horn2= ds.Tables[0].Rows[0]["Charge"].ToString();
				}
             
				if(ds.Tables[0].Rows[0]["Discharge"]!=null && ds.Tables[0].Rows[0]["DisCharge"].ToString()!="")
				{
                    model.Horn3= ds.Tables[0].Rows[0]["Discharge"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Volume"]!=null && ds.Tables[0].Rows[0]["Volume"].ToString()!="")
				{
                    model.Horn4= ds.Tables[0].Rows[0]["Volume"].ToString();
				}
                if (ds.Tables[0].Rows[0]["HandlerTime"] != null && ds.Tables[0].Rows[0]["HandlerTime"].ToString() != "")
                {
                    model.HandlerTime = DateTime .Parse(ds.Tables[0].Rows[0]["HandlerTime"].ToString());
                }
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select Id,Photovoltaic,Battery,PowerSource,QS,Horn,Charge,DisCharge,Volume,HandlerTime,PhoneNo ");
			strSql.Append(" FROM Condition ");
		    if (strWhere.Trim() == "")
		    {
		        strSql.Append(" order by Id desc ");
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
			strSql.Append("select count(1) FROM Condition ");
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
			strSql.Append(")AS Row, T.*  from Condition T ");
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
			parameters[0].Value = "Condition";
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

