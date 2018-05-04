using Apps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.IBLL
{
    public interface ISysSampleBLL
    {
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="queryStr">搜索条件</param>
        /// <returns>数据列表</returns>
        List<SysSample> GetList(string queryStr);

        /// <summary>
        /// 创建一个实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Create(SysSample entity);

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(string id);

        /// <summary>
        /// 修改实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Edit(SysSample entity);

        /// <summary>
        /// 判断实体是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool IsExists(string id);

        /// <summary>
        /// 根据id获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        SysSample GetById(string id);

        /// <summary>
        /// 判断实体是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool IsExit(string id);
    }
}
