using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sawon.Models;

public partial class BulkyContext : DbContext
{
    public BulkyContext()
    {
    }

    public BulkyContext(DbContextOptions<BulkyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Table1> Table1s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Table1>(entity =>
        {
            entity.ToTable("Table_1");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
