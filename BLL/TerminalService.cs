using System;
using System.Data;
using System.Collections.Generic;
using TomorrowSoft.DAL;
using TomorrowSoft.Model;

namespace TomorrowSoft.BLL
{
    /// <summary>
    /// TerminalService
    /// </summary>
    public partial class TerminalService
    {
        private readonly TerminalRepository dal = new TerminalRepository();

        public TerminalService()
        {
        }

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
        /// Group是否存在该记录
        /// </summary>
        public Terminal  GroupNoExists(string groupNo)
        {
            return dal.GroupNoExists(groupNo);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Terminal model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Terminal model)
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
		public Terminal GetModel(int Id)
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
		public List<Terminal> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Terminal> DataTableToList(DataTable dt)
		{
			List<Terminal> modelList = new List<Terminal>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				for (int n = 0; n < rowsCount; n++)
				{
                    Terminal model = new Terminal();
					if(dt.Rows[n]["Id"]!=null && dt.Rows[n]["Id"].ToString()!="")
					{
                        model.Id = Convert.ToInt32(dt.Rows[n]["Id"]);
					}
					if(dt.Rows[n]["Address"]!=null && dt.Rows[n]["Address"].ToString()!="")
					{
					model.Address=dt.Rows[n]["Address"].ToString();
					}
					if(dt.Rows[n]["PhoneNo"]!=null && dt.Rows[n]["PhoneNo"].ToString()!="")
					{
					model.PhoneNo=dt.Rows[n]["PhoneNo"].ToString();
					}
                    if (dt.Rows[n]["Grouping"] != null && dt.Rows[n]["Grouping"].ToString() != "")
                    {
                        model.Grouping = dt.Rows[n]["Grouping"].ToString();
                    }
                    if (dt.Rows[n]["GroupPhone"] != null && dt.Rows[n]["GroupPhone"].ToString() != "")
                    {
                        model.GroupPhone = dt.Rows[n]["GroupPhone"].ToString();
                    }
                    if (dt.Rows[n]["AllPhone"] != null && dt.Rows[n]["AllPhone"].ToString() != "")
                    {
                        model.AllPhone = dt.Rows[n]["AllPhone"].ToString();
                    }
                    if (dt.Rows[n]["Name"] != null && dt.Rows[n]["Name"].ToString() != "")
                    {
                        model.Name = dt.Rows[n]["Name"].ToString();
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

