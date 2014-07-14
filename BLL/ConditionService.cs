using System;
using System.Data;
using System.Collections.Generic;
using TomorrowSoft.Model;
namespace TomorrowSoft.BLL
{
	/// <summary>
	/// Condition
	/// </summary>
	public partial class ConditionService
	{
		private readonly TomorrowSoft.DAL.ConditionRepository dal=new TomorrowSoft.DAL.ConditionRepository();
		public ConditionService()
		{}
		#region  Method
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
		public bool Add(TomorrowSoft.Model.Condition model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(TomorrowSoft.Model.Condition model)
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
		public TomorrowSoft.Model.Condition GetModel(int Id)
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
		public List<TomorrowSoft.Model.Condition> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<TomorrowSoft.Model.Condition> DataTableToList(DataTable dt)
		{
			List<TomorrowSoft.Model.Condition> modelList = new List<TomorrowSoft.Model.Condition>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TomorrowSoft.Model.Condition model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new TomorrowSoft.Model.Condition();
					if(dt.Rows[n]["Id"]!=null && dt.Rows[n]["Id"].ToString()!="")
					{
						model.Id=int.Parse(dt.Rows[n]["Id"].ToString());
					}
                    if (dt.Rows[n]["PhoneNo"] != null && dt.Rows[n]["PhoneNo"].ToString() != "")
                    {
                        model.PhoneNo = dt.Rows[n]["PhoneNo"].ToString();
                    }
					if(dt.Rows[n]["Photovoltaic"]!=null && dt.Rows[n]["Photovoltaic"].ToString()!="")
					{
					model.Photovoltaic=dt.Rows[n]["Photovoltaic"].ToString();
					}
					if(dt.Rows[n]["Battery"]!=null && dt.Rows[n]["Battery"].ToString()!="")
					{
					model.Battery=dt.Rows[n]["Battery"].ToString();
					}
					if(dt.Rows[n]["PowerSource"]!=null && dt.Rows[n]["PowerSource"].ToString()!="")
					{
					model.PowerSource=dt.Rows[n]["PowerSource"].ToString();
					}
					
					if(dt.Rows[n]["QS"]!=null && dt.Rows[n]["QS"].ToString()!="")
					{
					model.QS=dt.Rows[n]["QS"].ToString();
					}
					if(dt.Rows[n]["Horn"]!=null && dt.Rows[n]["Horn"].ToString()!="")
					{
					model.Horn1=dt.Rows[n]["Horn"].ToString();
					}
					if(dt.Rows[n]["Charge"]!=null && dt.Rows[n]["Charge"].ToString()!="")
					{
                        model.Horn2= dt.Rows[n]["Charge"].ToString();
					}
					if(dt.Rows[n]["DisCharge"]!=null && dt.Rows[n]["DisCharge"].ToString()!="")
					{
                        model.Horn3= dt.Rows[n]["DisCharge"].ToString();
					}
					if(dt.Rows[n]["Volume"]!=null && dt.Rows[n]["Volume"].ToString()!="")
					{
                        model.Horn4= dt.Rows[n]["Volume"].ToString();
					}
                    if (dt.Rows[n]["HandlerTime"] != null && dt.Rows[n]["HandlerTime"].ToString() != "")
                    {
                        model.HandlerTime = DateTime .Parse(dt.Rows[n]["HandlerTime"].ToString());
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

