using System;
using System.Collections.Generic;
using System.Data;

namespace TomorrowSoft.BLL
{
    /// <summary>
    ///     RegularPlayService
    /// </summary>
    public class RegularPlayService
    {
        private readonly DAL.RegularPlayRepository dal = new DAL.RegularPlayRepository();

        #region  BasicMethod

        /// <summary>
        ///     增加一条数据
        /// </summary>
        public bool Add(TomorrowSoft.Model.RegularPlay model)
        {
            return dal.Add(model);
        }

        /// <summary>
        ///     更新一条数据
        /// </summary>
        public bool Update(TomorrowSoft.Model.RegularPlay model)
        {
            return dal.Update(model);
        }

        /// <summary>
        ///     删除一条数据
        /// </summary>
        public bool Delete(int id)
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.Delete(id);
        }

        /// <summary>
        ///     得到一个对象实体
        /// </summary>
        public TomorrowSoft.Model.RegularPlay GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.GetModel();
        }


        /// <summary>
        ///     获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        ///     获得数据列表
        /// </summary>
        public List<TomorrowSoft.Model.RegularPlay> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        ///     获得数据列表
        /// </summary>
        public List<TomorrowSoft.Model.RegularPlay> DataTableToList(DataTable dt)
        {
            var modelList = new List<TomorrowSoft.Model.RegularPlay>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                TomorrowSoft.Model.RegularPlay model;
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
        ///     获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        ///     分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }

        /// <summary>
        ///     分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
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
    }
}