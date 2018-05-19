using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apps.Models.Sys;
using Apps.Common;

namespace Apps.DAL
{
    /// <summary>
    /// 数据访问类:站点配置
    /// </summary>
    public partial class SysConfigRepository
    {
        private static object lockHelper = new object();

        /// <summary>
        ///  读取站点配置文件
        /// </summary>
        public SysConfigModel LoadConfig(string configFilePath)
        {
            return (SysConfigModel)SerializationHelper.Load(typeof(SysConfigModel), configFilePath);
        }

        /// <summary>
        /// 写入站点配置文件
        /// </summary>
        public SysConfigModel SaveConifg(SysConfigModel model, string configFilePath)
        {
            lock (lockHelper)
            {
                SerializationHelper.Save(model, configFilePath);
            }
            return model;
        }

    }
}
