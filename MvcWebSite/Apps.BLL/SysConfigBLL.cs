using Apps.Common;
using Apps.DAL;
using Apps.Models.Sys;

namespace Apps.BLL
{
    public partial class SysConfigBLL
    {
        private readonly SysConfigRepository dal = new SysConfigRepository();

        /// <summary>
        ///  读取配置文件
        /// </summary>
        public SysConfigModel LoadConfig(string configFilePath)
        {
            SysConfigModel model = CacheHelper.Get<SysConfigModel>(ContextKeys.CACHE_SITE_CONFIG);
            if (model == null)
            {
                CacheHelper.Insert(ContextKeys.CACHE_SITE_CONFIG, dal.LoadConfig(configFilePath), configFilePath);
                model = CacheHelper.Get<SysConfigModel>(ContextKeys.CACHE_SITE_CONFIG);
            }
            return model;
        }
        /// <summary>
        /// 读取客户端站点配置信息
        /// </summary>
        public SysConfigModel LoadConfig(string configFilePath, bool isClient)
        {
            SysConfigModel model = CacheHelper.Get<SysConfigModel>(ContextKeys.CACHE_SITE_CONFIG_CLIENT);
            if (model == null)
            {
                model = dal.LoadConfig(configFilePath);
                model.Templateskin = model.Webpath + "templates/" + model.Templateskin;
                CacheHelper.Insert(ContextKeys.CACHE_SITE_CONFIG_CLIENT, model, configFilePath);
            }
            return model;
        }

        /// <summary>
        ///  保存配置文件
        /// </summary>
        public SysConfigModel SaveConifg(SysConfigModel model, string configFilePath)
        {
            return dal.SaveConifg(model, configFilePath);
        }

    }
}
