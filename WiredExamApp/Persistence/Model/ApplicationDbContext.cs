using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using WiredExamApp.Core.Models;

namespace WiredExamApp.Persistence.Model
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Selection> Selections { get; set; }
        public DbSet<Exam> Exams { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}