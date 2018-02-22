using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace hackingion.Models
{
    public class ModelsDb : IdentityDbContext<AppUser>
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<IdentityRole> IdentityRoles { get; set; }
        public DbSet<FileModel> Files { get; set; }
        public DbSet<Cats> Cats { get; set; }




        public ModelsDb(DbContextOptions<ModelsDb> options)
            : base(options)
        {

        }
       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UsersInRole>()
                .HasKey(c => new { c.RoleId, c.Id });*/
        }
    }

