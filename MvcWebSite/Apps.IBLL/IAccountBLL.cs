using Apps.Models;

namespace Apps.IBLL
{
    public partial interface IAccountBLL
    {
        SysUser Login(string username, string pwd);
    }
}
