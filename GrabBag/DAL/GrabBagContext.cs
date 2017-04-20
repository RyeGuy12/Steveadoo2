using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GrabBag.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GrabBag.DAL
{
    public class GrabBagContext : DbContext
    {
        public GrabBagContext() : base("GrabBagContext")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Bookmark> Bookmarks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}