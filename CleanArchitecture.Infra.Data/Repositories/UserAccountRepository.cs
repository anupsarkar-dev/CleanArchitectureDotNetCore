using CleanArchitecture.App.Services;
using CleanArchitecture.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Domain.Inferfaces;
using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infra.Data.Repositories
{
   public  class UserAccountRepository: IUserAccountRepository
    {
        public PrimaryDBContext _context;

        public UserAccountRepository(PrimaryDBContext context)
        {
            _context = context;
        }

        //public bool DeleteUser(string uid,bool action)
        //{
        //    var localUser = new UserAccount { Uid = uid  , IsDelete = action };

        //    _context.Entry(localUser).Property(s => s.IsDelete).IsModified = action;
        //    _context.SaveChanges();

        //    // Only downside of restricting EF Core from tracking object that we cannot know  
        //    //if Entity is updated or not  without checking it again from DB. Previously can be done easily like this
            
        //    //return _context.Entry(localUser).State == EntityState.Unchanged ? false : true;
        //    return _context.UserAccounts.Find(uid).IsDelete == action;
        //}

        public bool DeleteUser(string uid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserAccount> GetUserAccounts() { return _context.UserAccounts; }
    }
}
