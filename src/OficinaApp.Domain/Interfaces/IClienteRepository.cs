using OficinaApp.Domain.Entities;

namespace OficinaApp.Domain.Interfaces;

public interface IClienteRepository
{
    Task<List<Cliente>> ObterTodosAsync();
    Task<Cliente?> ObterPorIdAsync(Guid id);
    Task AdicionarAsync(Cliente cliente);
    Task AtualizarAsync(Cliente cliente);
    Task RemoverAsync(Guid id);
}