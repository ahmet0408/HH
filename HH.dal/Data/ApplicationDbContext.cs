using HH.dal.Models.AboutUs;
using HH.dal.Models.Banner;
using HH.dal.Models.Client;
using HH.dal.Models.Company;
using HH.dal.Models.Contact;
using HH.dal.Models.Language;
using HH.dal.Models.Mission;
using HH.dal.Models.Product;
using HH.dal.Models.Project;
using HH.dal.Models.Service;
using HH.dal.Models.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<AboutUsTranslate> AboutUsTranslates { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<BannerTranslate> BannerTranslates { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsTranslate> NewsTranslates { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Mission> Mission { get; set; }
        public DbSet<MissionTranslate> MissionTranslates { get; set; }
        public DbSet<Option> Option { get; set; }
        public DbSet<OptionContent> OptionContent { get; set; }
        public DbSet<OptionContentTranslate> OptionContentTranslates { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductTranslate> ProductTranslates { get; set; }
        public DbSet<ProductOption> ProductOption { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<LocationTranslate> LocationTranslates { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectTranslate> ProjectTranslates { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<StatusTranslate> StatusTranslates { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceTranslate> ServiceTranslates { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Применение всех конфигурация в сборке
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            base.OnModelCreating(builder);
        }
    }
}
