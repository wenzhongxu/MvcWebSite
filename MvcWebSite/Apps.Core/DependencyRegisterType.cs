using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Apps.BLL;
using Apps.DAL;
using Apps.IBLL;
using Apps.IDAL;

namespace Apps.Core
{
    public class DependencyRegisterType
    {
        // 系统注入
        public static void Container_Sys(ref UnityContainer container)
        {
            container.RegisterType<ISysSampleBLL, SysSampleBLL>(); // 样例
            container.RegisterType<ISysSampleRepository, SysSampleRepository>();
        }
    }
}
