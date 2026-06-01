using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using OficinaApp.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using OficinaApp.Domain.Entities;

namespace OficinaApp.Infrastructure.Data;
public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<Veiculo> Veiculos => Set<Veiculo>();
    public DbSet<OrdemServico> OrdensServico => Set<OrdemServico>();
    public DbSet<Peca> Pecas => Set<Peca>();
    public DbSet<OrdemServicoPeca> OrdemServicoPecas => Set<OrdemServicoPeca>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Cliente
        modelBuilder.Entity<Cliente>().HasKey(c =>c.Id);

        //Veiculo
        modelBuilder.Entity<Veiculo>().HasKey(v => v.Id);
        modelBuilder.Entity<Veiculo>().HasOne(v => v.Cliente).WithMany(c => c.Veiculos).HasForeignKey(v => v.ClienteId);
        
        //Ordem Servico
        modelBuilder.Entity<OrdemServico>().HasKey(os => os.Id);
        modelBuilder.Entity<OrdemServico>().HasOne(os => os.Cliente).WithMany().HasForeignKey(os => os.ClienteId);
        modelBuilder.Entity<OrdemServico>().HasOne(os => os.Veiculo).WithMany(v => v.OrdensServico).HasForeignKey(os => os.VeiculoId);

        // Peça
        modelBuilder.Entity<Peca>().HasKey(p => p.Id);

        //Ordem Servico Peça
        modelBuilder.Entity<OrdemServicoPeca>().HasKey(osp => new
        {
            osp.OrdemServicoId,
            osp.PecaId
        });
        modelBuilder.Entity<OrdemServicoPeca>().HasOne(osp => osp.OrdemServico).WithMany(os => os.OrdemServicoPecas).HasForeignKey(ops => ops.OrdemServicoId);
        modelBuilder.Entity<OrdemServicoPeca>().HasOne(osp => osp.Peca).WithMany(p => p.OrdemServicoPecas).HasForeignKey(ops => ops.PecaId);
    }
}