using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Data
{
    public class ToDoStoreContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ToDoItem> ToDoItems { get; set; }

        public ToDoStoreContext()
            : base("name=ToDoStoreContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasKey(e => e.Id);

            modelBuilder.Entity<ToDoItem>().HasKey(e => e.Id);
            modelBuilder.Entity<ToDoItem>().HasRequired(i => i.User)
                                           .WithMany(p => p.ToDoItems)
                                           .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<ToDoItem>().Property(p => p.Latitude).HasPrecision(12, 10);
            modelBuilder.Entity<ToDoItem>().Property(p => p.Longitude).HasPrecision(12, 10);
        }
    }
}
