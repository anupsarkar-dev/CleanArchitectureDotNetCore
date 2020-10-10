using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CleanArchitecture.Infra.Data.Context
{
    public class PrimaryDBContext : DbContext
    {
        public PrimaryDBContext(DbContextOptions options) : base(options)  {   } 

        public DbSet<Books> Books { get; set; }

        public DbSet<UserAccount> UserAccounts { get; set; }
    }
}
