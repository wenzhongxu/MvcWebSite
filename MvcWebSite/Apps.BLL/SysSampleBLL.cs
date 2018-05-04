using Apps.IBLL;
using Apps.DAL;
using Apps.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apps.Models;
using Apps.Models.Sys;
using Unity.Attributes;

namespace Apps.BLL
{
    public class SysSampleBLL : ISysSampleBLL
    {
        DBContainer db = new DBContainer();

        [Dependency]
        public ISysSampleRepository Rep { get; set; }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="queryStr">搜索条件</param>
        /// <returns>数据列表</returns>
        public List<SysSampleModel> GetList(string queryStr)
        {
            IQueryable<SysSample> queryData = null;
            queryData = Rep.GetList(db);
            return CreateModelList(ref queryData);
        }
        private List<SysSampleModel> CreateModelList(ref IQueryable<SysSample> queryData)
        {
            List<SysSampleModel> modelList = (from r in queryData
                                              select new SysSampleModel
                                              {
                                                  Id = r.Id,
                                                  Name = r.Name,
                                                  Age = r.Age,
                                                  Bir = r.Bir,
                                                  Photo = r.Photo,
                                                  Note = r.Note,
                                                  CreateTime = r.CreateTime
                                              }).ToList();
            return modelList;
        }

        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Create(SysSampleModel entity)
        {
            try
            {
                SysSample sample = Rep.GetById(entity.Id);
                if (sample != null)
                {
                    return false;
                }
                sample = new SysSample
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Age = entity.Age,
                    Bir = entity.Bir,
                    Photo = entity.Photo,
                    Note = entity.Note,
                    CreateTime = entity.CreateTime
                };
                if (Rep.Create(sample) == 1)
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
                if (Rep.Delete(id) == 1)
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
        public bool Edit(SysSampleModel entity)
        {
            try
            {
                SysSample sample = Rep.GetById(entity.Id);
                if (sample == null)
                {
                    return false;
                }
                sample.Name = entity.Name;
                sample.Age = entity.Age;
                sample.Bir = entity.Bir;
                sample.Photo = entity.Photo;
                sample.Note = entity.Note;

                if (Rep.Edit(sample) == 1)
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
        public SysSampleModel GetById(string id)
        {
            if (IsExist(id))
            {
                SysSample entity = Rep.GetById(id);
                SysSampleModel model = new SysSampleModel
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Age = entity.Age,
                    Bir = entity.Bir,
                    Photo = entity.Photo,
                    Note = entity.Note,
                    CreateTime = entity.CreateTime
                };
                return model;
            }
            else
            {
                return new SysSampleModel();
            }
        }

        /// <summary>
        /// 判断实体是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsExist(string id)
        {
            return Rep.IsExist(id);
        }
    }
}
