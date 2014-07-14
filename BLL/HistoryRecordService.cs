using System;
using System.Data;
using System.Collections.Generic;
using TomorrowSoft.DAL;
using TomorrowSoft.Model;

namespace TomorrowSoft.BLL
{
	/// <summary>
	/// HistoryRecordService
	/// </summary>
	public partial class HistoryRecordService
	{
		private readonly HistoryRecordRepository dal=new HistoryRecordRepository();
		public HistoryRecordService()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			return dal.Exists(Id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(HistoryRecord model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(HistoryRecord model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
        public bool Delete(int Id)
		{
			
			return dal.Delete(Id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return dal.DeleteList(Idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
        public HistoryRecord GetModel(int Id)
		{
			return dal.GetModel(Id);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HistoryRecord> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<HistoryRecord> DataTableToList(DataTable dt)
		{
			List<HistoryRecord> modelList = new List<HistoryRecord>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				for (int n = 0; n < rowsCount; n++)
				{
                    HistoryRecord model = new HistoryRecord();
					if(dt.Rows[n]["Id"]!=null && dt.Rows[n]["Id"].ToString()!="")
					{
                      model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
					}
					if(dt.Rows[n]["Handler"]!=null && dt.Rows[n]["Handler"].ToString()!="")
					{
					model.Handler=dt.Rows[n]["Handler"].ToString();
					}
					if(dt.Rows[n]["PhoneNo"]!=null && dt.Rows[n]["PhoneNo"].ToString()!="")
					{
					model.PhoneNo=dt.Rows[n]["PhoneNo"].ToString();
					}
					if(dt.Rows[n]["HandlerTime"]!=null && dt.Rows[n]["HandlerTime"].ToString()!="")
					{
						model.HandlerTime=DateTime .Parse(dt.Rows[n]["HandlerTime"].ToString());
					}
					if(dt.Rows[n]["Context"]!=null && dt.Rows[n]["Context"].ToString()!="")
					{
					model.Context=dt.Rows[n]["Context"].ToString();
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method

	    
	}
}

