using Apps.IBLL;
using Apps.DAL;
using Apps.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apps.Models;

namespace Apps.BLL
{
    public class SysSampleBLL : ISysSampleBLL
    {
        DBContainer db = new DBContainer();

        ISysSampleRepository rep = new SysSampleRepository();

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="queryStr">搜索条件</param>
        /// <returns>数据列表</returns>
        public List<SysSample> GetList(string queryStr)
        {
            IQueryable<SysSample> queryData = rep.GetList(db);
            return queryData.ToList();
        }

        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Create(SysSample entity)
        {
            try
            {
                if (rep.Create(entity) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            try
            {
                if (rep.Delete(id) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 修改实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Edit(SysSample entity)
        {
            try
            {
                if (rep.Edit(entity) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 判断实体是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsExists(string id)
        {
            if (db.SysSample.SingleOrDefault(p => p.Id == id) != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 根据id获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SysSample GetById(string id)
        {
            if (rep.IsExist(id))
            {
                SysSample entity = rep.GetById(id);
                return entity;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 判断实体是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsExit(string id)
        {
            return rep.IsExist(id);
        }
    }
}
