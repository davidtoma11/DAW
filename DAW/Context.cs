public class BibliotecaContext : DbContext
{
    public DbSet<Autor> Autori { get; set; }
    public DbSet<Carte> Carti { get; set; }
    public DbSet<Editura> Edituri { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autor>()
            .HasMany(a => a.Carti)
            .WithMany(c => c.Autori)
            .UsingEntity(j => j.ToTable("AutorCarte"));

        base.OnModelCreating(modelBuilder);
    }
}
