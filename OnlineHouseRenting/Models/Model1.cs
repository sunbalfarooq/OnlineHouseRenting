using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OnlineHouseRenting.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tbl_about_us> tbl_about_us { get; set; }
        public virtual DbSet<tbl_admin> tbl_admin { get; set; }
        public virtual DbSet<tbl_category> tbl_category { get; set; }
        public virtual DbSet<tbl_contact> tbl_contact { get; set; }
        public virtual DbSet<tbl_house_detail> tbl_house_detail { get; set; }
        public virtual DbSet<tbl_order> tbl_order { get; set; }
        public virtual DbSet<tbl_order_detail> tbl_order_detail { get; set; }
        public virtual DbSet<tbl_tenant> tbl_tenant { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_about_us>()
                .Property(e => e.COMPANY_NAME)
                .IsFixedLength();

            modelBuilder.Entity<tbl_about_us>()
                .Property(e => e.COMPANY_LOGO)
                .IsFixedLength();

            modelBuilder.Entity<tbl_about_us>()
                .Property(e => e.COMPANY_CONTACT)
                .IsFixedLength();

            modelBuilder.Entity<tbl_about_us>()
                .Property(e => e.COMPANY_EMAIL)
                .IsFixedLength();

            modelBuilder.Entity<tbl_about_us>()
                .Property(e => e.COMPANY_ADDRESS)
                .IsFixedLength();

            modelBuilder.Entity<tbl_category>()
                .HasMany(e => e.tbl_house_detail)
                .WithOptional(e => e.tbl_category)
                .HasForeignKey(e => e.HOUSE_CATEGORY_FID);

            modelBuilder.Entity<tbl_house_detail>()
                .HasMany(e => e.tbl_order_detail)
                .WithRequired(e => e.tbl_house_detail)
                .HasForeignKey(e => e.HOUSE_DETAIL_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_house_detail>()
                .HasMany(e => e.tbl_order)
                .WithRequired(e => e.tbl_house_detail)
                .HasForeignKey(e => e.HOUSE_DETAIL_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_order>()
                .HasMany(e => e.tbl_order_detail)
                .WithRequired(e => e.tbl_order)
                .HasForeignKey(e => e.ORDER_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_tenant>()
                .HasMany(e => e.tbl_order)
                .WithRequired(e => e.tbl_tenant)
                .HasForeignKey(e => e.TENANT_FID)
                .WillCascadeOnDelete(false);
        }
    }
}
