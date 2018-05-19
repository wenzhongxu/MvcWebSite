using Apps.Common;
using Apps.Models;
using Apps.Models.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWebSite.Core
{
    public static class LogHandler
    {
        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="oper">操作人</param>
        /// <param name="mes">操作信息</param>
        /// <param name="result">结果</param>
        /// <param name="type">类型</param>
        /// <param name="module">操作模块</param>
        public static void WriteServiceLog(string oper, string mes, string result, string type, string module)
        {
            SysConfigModel siteConfig = new Apps.BLL.SysConfigBLL().LoadConfig(Utils.GetXmlMapPath("Configpath"));
            //后台管理日志开启
            if (siteConfig.Logstatus == 1)
            {
                ValidationErrors errors = new ValidationErrors();
                SysLog entity = new SysLog
                {
                    Id = ResultHelper.NewId,
                    Operator = oper,
                    Message = mes,
                    Result = result,
                    Type = type,
                    Module = module,
                    CreateTime = ResultHelper.NowTime
                };
                //using (SysLogRepository logRepository = new SysLogRepository(new DBContainer()))
                //{
                //    logRepository.Create(entity);
                //}
            }
            else
            {
                return;
            }
        }

    }
}