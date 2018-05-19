using Apps.IDAL;
using Apps.Models;
using System;
using System.Linq;

namespace Apps.DAL
{
    public class AccountRepository : IAccountRepository,IDisposable
    {
        readonly DBContainer db;

        public AccountRepository(DBContainer context)
        {
            this.db = context;
        }

        public DBContainer Context
        {
            get { return db; }
        }

        public SysUser Login(string username, string pwd)
        {
            SysUser user = Context.SysUser.SingleOrDefault(p => p.UserName == username && p.Password == pwd);
            return user;
        }

        public void Dispose()
        {
        }
    }
}
