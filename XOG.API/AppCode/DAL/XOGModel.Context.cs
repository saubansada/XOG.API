﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XOG.AppCode.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class XOGEntities : DbContext
    {
        public XOGEntities()
            : base("name=XOGEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AdSenseAd> AdSenseAds { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<ProductGroup> ProductGroups { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductVariant> ProductVariants { get; set; }
        public virtual DbSet<QuantityMeasure> QuantityMeasures { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<WishList> WishLists { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ReturnOrderDetail> ReturnOrderDetails { get; set; }
        public virtual DbSet<ReturnOrder> ReturnOrders { get; set; }
        public virtual DbSet<UserWallet> UserWallets { get; set; }
        public virtual DbSet<UsersWalletVW> UsersWalletVWs { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<OrderVW> OrderVWs { get; set; }
    }
}
