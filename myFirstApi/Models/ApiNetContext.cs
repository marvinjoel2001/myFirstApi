using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using myFirstApi.Models;

namespace myFirstApi.Models;

public partial class ApiNetContext : DbContext
{
    public ApiNetContext()
    {
    }
    public DbSet<Products> Products { get; set; }
    public ApiNetContext(DbContextOptions<ApiNetContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
        }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//       => optionsBuilder.UseMySql("server=localhost;port=3306;database=api.net;uid=root;password=sistemas123", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql"));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");
        modelBuilder.Entity<Inventory>()
            .HasOne(p => p.Products)
            .WithMany(c => c.Inventory)
            .HasForeignKey(p => p.ProductId);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<myFirstApi.Models.Inventory>? Inventory { get; set; }
}
