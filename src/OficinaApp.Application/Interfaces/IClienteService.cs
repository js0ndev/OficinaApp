using OficinaApp.Application.DTOs;
using OficinaApp.Domain.Entities;

namespace OficinaApp.Application.Interfaces;

public interface IClienteService
{
    Task<List<Cliente>> ObterTodosAsync();
    Task<Cliente?> ObterPorIdAsync(Guid id);
    Task CriarAsync(CreateClienteDto dto);
    Task RemoveAsync(Guid id);
}