using Apps.IBLL;
using Apps.IDAL;
using Apps.Models;
using Unity.Attributes;

namespace Apps.BLL
{
    public class AccountBLL:IAccountBLL
    {
        [Dependency]
        public IAccountRepository AccountRepository { get; set; }

        public SysUser Login(string username, string pwd)
        {
            return AccountRepository.Login(username, pwd);

        }
    }
}
