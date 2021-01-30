using Microsoft.EntityFrameworkCore;
using ProjectSignalR.Models.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSignalR.Models.ORM.Context
{
    public class ChatContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=localhost\SQLEXPRESS;database=ChatDB;trusted_connection=true;");
        }

        public DbSet<AdminUser> AdminUsers { get; set; }
    }
}
