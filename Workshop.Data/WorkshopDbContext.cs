using Microsoft.EntityFrameworkCore;
using Workshop.Data.Entities;

namespace Workshop.Data;

public class WorkshopDbContext : DbContext {
    public WorkshopDbContext(DbContextOptions<WorkshopDbContext> options)
        : base(options) {
    }

    public virtual DbSet<Artist> Artists => Set<Artist>();

    protected override void OnModelCreating(ModelBuilder builder) {
        builder.UseCollation("Latin1_General_CI_AI");

        builder.Entity<Artist>(entity => { entity.Property(e => e.Id).HasDefaultValueSql("NEWSEQUENTIALID()"); });
    }
}