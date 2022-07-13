using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Studywithzk.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studywithzk.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>
    {
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleClaim> RoleClaim { get; set; }

        public DbSet<Countrys> Countrys { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<Boards> Boards { get; set; }
        public DbSet<ExamClass> ExamClass { get; set; }
        public DbSet<ExamYear> ExamYear { get; set; }
        public DbSet<ExamSubject> ExamSubject { get; set; }
        //Unsolved Papers
        public DbSet<UnsolvedPaper> UnsolvedPaper { get; set; }
        public DbSet<PapersExtraLink> PapersExtraLink { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
