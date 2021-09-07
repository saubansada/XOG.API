//using Microsoft.AspNet.Identity.EntityFramework;
//using MySql.Data.EntityFramework; 
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity.Migrations.History;
//using System.Linq;
//using System.Web;
//using XOG.Factories;
//using XOG.Models.EntityModels;

//namespace XOG.Models.ApplicationDbContext
//{ 
//    public class ApplicationDbContext : AppDbContext //IdentityDbContext<ApplicationUser>
//    {
//        //public ApplicationDbContext()
//        //    : base("DefaultConnection", throwIfV1Schema: false)
//        //{
//        //}

//        //public static ApplicationDbContext XOG.()
//        //{
//        //    return new ApplicationDbContext();
//        //}

//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);

//            modelBuilder.Entity<ApplicationUser>().Property(m => m.Email).HasMaxLength(127);
//            modelBuilder.Entity<ApplicationUser>().Property(m => m.PhoneNumber).HasMaxLength(127);
//            modelBuilder.Entity<ApplicationUser>().Property(m => m.UserName).HasMaxLength(127);
//            modelBuilder.Entity<ApplicationUser>().Property(m => m.UserName).HasMaxLength(127);

//            modelBuilder.Entity<IdentityRole>().Property(m => m.Name).HasMaxLength(127); 

//            //modelBuilder.Entity<IdentityUserLogin<string>>().Property(m => m.LoginProvider).HasMaxLength(127);
//            //modelBuilder.Entity<IdentityUserLogin<string>>().Property(m => m.ProviderKey).HasMaxLength(127);
        
//            //modelBuilder.Entity<IdentityUserRole<string>>().Property(m => m.UserId).HasMaxLength(127);
//            //modelBuilder.Entity<IdentityUserRole<string>>().Property(m => m.RoleId).HasMaxLength(127); 

//            modelBuilder.Entity<HistoryRow>().HasKey(t => t.MigrationId);
//            modelBuilder.Entity<HistoryRow>().Property(h => h.MigrationId).HasMaxLength(127).IsRequired();
//            modelBuilder.Entity<HistoryRow>().Property(h => h.ContextKey).HasMaxLength(127).IsRequired();

//            //modelBuilder.Entity<Post>()
//            //            .HasMany<HashTag>(p => p.HashTags)
//            //            .WithMany(h => h.Posts)
//            //            .Map(cs =>
//            //            {
//            //                cs.MapLeftKey("PostId");
//            //                cs.MapRightKey("HashTagId");
//            //                cs.ToTable("PostHashTags");
//            //            });

//        }
         
//        public DbSet<Category> Categories { get; set; }
//        public DbSet<Product> Products { get; set; }
//        public DbSet<Stock> Stocks { get; set; }
//        public DbSet<StockDetail> StockDetails { get; set; }
//        public DbSet<Invoice> Invoices { get; set; }
//        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
//        public DbSet<Customer> Customers { get; set; } 
//        public DbSet<Supplier> Suppliers { get; set; }
//        public DbSet<Payment> Payments { get; set; }
//        public DbSet<Expense> Expenses { get; set; }


//    }

//    public interface IRepository<T>
//    {
//        T GetById(int id);
//    }

//    public class Repository<T> : IRepository<T>
//    {
//        public T GetById(int id)
//        {
//            Console.WriteLine("Type: " + GetType());
//            return default(T);
//        }
//    }
//}