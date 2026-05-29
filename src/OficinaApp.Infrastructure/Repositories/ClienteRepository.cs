using Microsoft.EntityFrameworkCore;
using OficinaApp.Domain.Entities;
using OficinaApp.Domain.Interfaces;
using OficinaApp.Infrastructure.Data;

namespace OficinaApp.Infrastructure.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly AppDbContext _context;
    
    public ClienteRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Cliente>> ObterTodosAsync()
    {
        return await _context.Clientes.ToListAsync();
    }
    public async Task<Cliente?> ObterPorIdAsync(Guid id)
    {
        return await _context.Clientes.FirstOrDefaultAsync(c => c.Id == id);
    }
    public async Task AdicionarAsync(Cliente cliente)
    {
        await _context.Clientes.AddAsync(cliente);
        await _context.SaveChangesAsync();
    }
    public async Task AtualizarAsync(Cliente cliente)
    { 
        _context.Clientes.Update(cliente);
        await _context.SaveChangesAsync();
    }
    public async Task RemoverAsync(Guid id)
    {
        var cliente = await ObterPorIdAsync(id);
        if(cliente is null) return;
        _context.Clientes.Remove(cliente);
        await _context.SaveChangesAsync();
    }
}