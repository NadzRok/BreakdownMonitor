using System;
using System.Collections.Generic;
using BreakdownMonitor.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace BreakdownMonitor.Server.Context;

public partial class BreakdownDbContext : DbContext
{
    public BreakdownDbContext()
    {
    }

    public BreakdownDbContext(DbContextOptions<BreakdownDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Breakdown> Breakdowns { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Breakdown>(entity =>
        {
            entity.ToTable("Breakdown");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BreakdownDate).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
