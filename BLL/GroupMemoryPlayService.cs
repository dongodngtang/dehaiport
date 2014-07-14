using System;
using System.Data;
using System.Collections.Generic;
using TomorrowSoft.DAL;

namespace TomorrowSoft.BLL
{
	/// <summary>
	/// GroupMemoryPlayService
	/// </summary>
	public partial class GroupMemoryPlayService
	{
		private readonly GroupMemoryPlayRepository dal=new GroupMemoryPlayRepository();
		public GroupMemoryPlayService()
		{}
		#region  BasicMethod

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
		public bool Add(TomorrowSoft.Model.GroupMemoryPlay model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(TomorrowSoft.Model.GroupMemoryPlay model)
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
		public TomorrowSoft.Model.GroupMemoryPlay GetModel(int Id)
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
		public List<TomorrowSoft.Model.GroupMemoryPlay> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<TomorrowSoft.Model.GroupMemoryPlay> DataTableToList(DataTable dt)
		{
			List<TomorrowSoft.Model.GroupMemoryPlay> modelList = new List<TomorrowSoft.Model.GroupMemoryPlay>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TomorrowSoft.Model.GroupMemoryPlay model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
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

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod

	    public DataSet GetGroupList()
		{
		    return dal.GetGroupList();
		}

	    public void DeleteGroup(string group)
	    {
	        dal.DeletGroup(group);
	    }
	}
}

