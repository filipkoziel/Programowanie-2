using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;
using DayPlannerRepositoryClassLibrary.models;


namespace DayPlannerRepositoryClassLibrary;

public partial class PlanDBContext : DbContext
{
    public PlanDBContext()
    {
    }

    public PlanDBContext(DbContextOptions<PlanDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Plan> Plans { get; set; }

    public virtual DbSet<Plannerday> Plannerdays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;database=plan4d2026;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.32-mariadb"));

}
