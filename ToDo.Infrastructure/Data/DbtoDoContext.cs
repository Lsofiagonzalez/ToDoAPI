using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ToDoAPI.Core.Entitities;

namespace ToDoAPI.Infrastructure.Data;

public partial class DbtoDoContext : DbContext
{
    public DbtoDoContext()
    {
    }

    public DbtoDoContext(DbContextOptions<DbtoDoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ToDo> ToDo { get; set; }

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ToDo>(entity =>
        {
            entity
                //.HasNoKey()
                .ToTable("T_ToDo");

            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Titulo).IsRequired();
        });

    }

}
