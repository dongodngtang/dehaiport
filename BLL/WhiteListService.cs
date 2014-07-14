using System;
using System.Data;
using System.Collections.Generic;
using Infrastructure;
using TomorrowSoft.DAL;
using TomorrowSoft.Model;

namespace TomorrowSoft.BLL
{
	/// <summary>
	/// WhiteListService
	/// </summary>
	public partial class WhiteListService
	{
		private readonly WhiteListRepository dal=new WhiteListRepository();
		public WhiteListService()
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
        /// Phone是否存在该记录
        /// </summary>
        public bool PhoneExists(string phone)
        {
            return dal.PhoneExists(phone);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WhiteList model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WhiteList model)
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
		public WhiteList GetModel(int Id)
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
		public List<WhiteList> GetModelList(string strWhere)
		{
			var ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}

        public List<WhiteList> GetModelList()
        {
            return GetModelList(string.Empty);
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		private List<WhiteList> DataTableToList(DataTable dt)
		{
			List<WhiteList> modelList = new List<WhiteList>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				for (int i = 0; i < rowsCount; i++)
				{
                    var model = new WhiteList();
				    var id = i+1;
                    var type = dt.Rows[i]["Type"];
                    var phone = dt.Rows[i]["PhoneNo"];

                    if (!id.IsNullOrEmpty())
                        model.Id = Convert.ToInt32(id);
                    if (!type.IsNullOrEmpty())
                        model.Type = Enum<WhiteListType>.Parse(type.ToString());
                    if (!phone.IsNullOrEmpty())
                        model.PhoneNo = phone.ToString();
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

