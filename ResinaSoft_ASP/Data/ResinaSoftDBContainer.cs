using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResinaSoft_ASP.Models
{
    public partial class ResinaSoftDBContainer : DbContext
    //public partial class ResinaSoftDBContainer : IdentityDbContext<Ap/*p*/User, AppRole, int>
    {
        public ResinaSoftDBContainer(DbContextOptions<ResinaSoftDBContainer> options): base(options)
        {

        }

        //public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonAddresses> PersonAddresses { get; set; }
        public virtual DbSet<PersonTask> PersonTask { get; set; }
        //public virtual DbSet<Task> Task { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Task> Tasks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonTask>().HasKey(pt => new { pt.PersonID, pt.TaskID });
            modelBuilder.Entity<PersonTask>().HasOne(pt => pt.Person).WithMany(pt => pt.PersonTasks).HasForeignKey(p => p.PersonID);
            modelBuilder.Entity<PersonTask>().HasOne(pt => pt.Task).WithMany(pt => pt.PersonTasks).HasForeignKey(p => p.TaskID);
        }
    }
}
