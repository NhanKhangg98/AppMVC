﻿using AppMVC.Net.Models.Contacts;
using Microsoft.EntityFrameworkCore;

namespace AppMVC.Net.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            //builder.UseSqlServer(@"Server=DESKTOP-D67BF1B\SQLEXPRESS;Database=appmvc;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            //{
            //    var tableName = entityType.GetTableName();
            //    if (tableName.StartsWith("AspNet"))
            //    {
            //        entityType.SetTableName(tableName.Substring(6));
            //    }
            //}

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
