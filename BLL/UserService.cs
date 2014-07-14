using System;
using System.Data;
using System.Collections.Generic;
using TomorrowSoft.DAL;
using TomorrowSoft.Model;

namespace TomorrowSoft.BLL
{
	/// <summary>
	/// UserService
	/// </summary>
	public partial class UserService
	{
		private readonly UserRepository dal=new UserRepository();
		public UserService()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(Guid Id)
		{
			return dal.Exists(Id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(User model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(User model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(Guid Id)
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
		public User GetModel(Guid Id)
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
		public List<User> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<User> DataTableToList(DataTable dt)
		{
			List<User> modelList = new List<User>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				for (int n = 0; n < rowsCount; n++)
				{
                    User model = new User();
					if(dt.Rows[n]["Id"]!=null && dt.Rows[n]["Id"].ToString()!="")
					{
					model.Id=new Guid( dt.Rows[n]["Id"].ToString());
					}
					if(dt.Rows[n]["UserName"]!=null && dt.Rows[n]["UserName"].ToString()!="")
					{
					model.UserName=dt.Rows[n]["UserName"].ToString();
					}
					if(dt.Rows[n]["Password"]!=null && dt.Rows[n]["Password"].ToString()!="")
					{
					model.Password=dt.Rows[n]["Password"].ToString();
					}
					if(dt.Rows[n]["Level"]!=null && dt.Rows[n]["Level"].ToString()!="")
					{
					model.Level=dt.Rows[n]["Level"].ToString();
					}
					if(dt.Rows[n]["Remember"]!=null && dt.Rows[n]["Remember"].ToString()!="")
					{
						if((dt.Rows[n]["Remember"].ToString()=="1")||(dt.Rows[n]["Remember"].ToString().ToLower()=="true"))
						{
						model.Remember=true;
						}
						else
						{
							model.Remember=false;
						}
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

