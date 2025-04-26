using Microsoft.EntityFrameworkCore;
using portfolioCore.Entities;
using PortfolioCore.Entities;

namespace portfolioCore.Context
{
    public class PortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KARLITEPE\\MSSQLSERVER79;initial Catalog =PortfolioNightDb;integrated security=true;");
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<WorkingArea> WorkingAreas { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Service> Services { get; set; }

    }
}
//Trusted_Connection=True;TrustServerCertificate=True        6.0 üstü olursa eklenmesi gerekiyor.