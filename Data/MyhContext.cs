using Microsoft.EntityFrameworkCore;
using MYH_Reports.Models;


namespace MYH_Reports.Data
{
    public class MyhContext : DbContext
    {
        protected readonly IConfiguration Configuration;


        //public MyhContext(DbContextOptions<MyhContext> options) : base(options)
        //{
        //}

        public MyhContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("MyhContext"));
        }

        public DbSet<AccountsModel> Accounts { get; set; }
        public DbSet<AddressesModel> Addresses { get; set; }
        public DbSet<ContactsModel> Contacts { get; set; }
        public DbSet<EstimatesModel> Estimates { get; set; }
        public DbSet<InvoicesModel> Invoices { get; set; }
        public DbSet<JobDetailsModel> JobDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountsModel>().HasKey(x => x.AccountId);
            modelBuilder.Entity<AddressesModel>().HasKey(x => x.AddressId);
            modelBuilder.Entity<ContactsModel>().HasKey(x => x.ContactId);
            modelBuilder.Entity<EstimatesModel>().HasKey(x => x.JobId);
            modelBuilder.Entity<InvoicesModel>().HasKey(x => x.JobId);
            modelBuilder.Entity<JobDetailsModel>().HasKey(x => x.JobDetailId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
