using Apps.IDAL;
using Apps.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.DAL
{
    public class SysSampleRepository : ISysSampleRepository, IDisposable
    {
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="db">数据库上下文</param>
        /// <returns>数据列表</returns>
        public IQueryable<SysSample> GetList(DBContainer db)
        {
            IQueryable<SysSample> list = db.SysSample.AsQueryable();
            return list;
        }

        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Create(SysSample entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.Set<SysSample>().Add(entity);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns></returns>
        public int Delete(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysSample entity = db.SysSample.SingleOrDefault(p => p.Id == id);
                db.Set<SysSample>().Remove(entity);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 修改实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Edit(SysSample entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.Set<SysSample>().Attach(entity);
                db.Entry<SysSample>(entity).State = EntityState.Modified;
                return db.SaveChanges();
            }

        }

        /// <summary>
        /// 根据id获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SysSample GetById(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.SysSample.SingleOrDefault(p => p.Id == id);
            }
        }

        /// <summary>
        /// 判断实体是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsExist(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysSample entity = GetById(id);
                if (entity != null)
                {
                    return true;
                }
                return false;
            }
        }

        public void Dispose()
        {

        }
    }
}
