using System.Collections.Generic;
using System.Data;
using TomorrowSoft.DAL;

namespace TomorrowSoft.BLL
{
    public class Service<T> where T : new()
    {
        private readonly Repository<T> _repository = new Repository<T>();

        #region  Method

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return _repository.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            return _repository.Exists(Id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(T model)
        {
            return _repository.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(T model)
        {
            return _repository.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {

            return _repository.Delete(Id);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            return _repository.DeleteList(Idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public T GetModel(int Id)
        {

            return _repository.GetModel(Id);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return _repository.GetList(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<T> GetModelList(string strWhere)
        {
            DataSet ds = _repository.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<T> DataTableToList(DataTable dt)
        {
            List<T> modelList = new List<T>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                for (int n = 0; n < rowsCount; n++)
                {
                    T model = new T();
                    
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
            return _repository.GetRecordCount(strWhere);
        }

        #endregion  Method 
    }
}