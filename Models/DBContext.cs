using System;
using Microsoft.EntityFrameworkCore;


namespace ActivityCenter.Models
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get;set;}
        public DbSet<Party> Partys {get;set;}
        public DbSet<Join> Joins {get;set;}
    }
}