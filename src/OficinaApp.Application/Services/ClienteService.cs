using OficinaApp.Application.DTOs;
using OficinaApp.Application.Interfaces;
using OficinaApp.Domain.Entities;
using OficinaApp.Domain.Interfaces;

namespace OficinaApp.Application.Services;

public class ClienteService : IClienteService
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }
    public async Task<List<Cliente>> ObterTodosAsync()
    {
        return await _clienteRepository.ObterTodosAsync();
    }
    public async Task<Cliente?> ObterPorIdAsync(Guid id)
    {
        return await _clienteRepository.ObterPorIdAsync(id);
    }
    public async Task CriarAsync(CreateClienteDto dto)
    {
        var cliente = new Cliente
        {
            Id = Guid.NewGuid(),
            Nome = dto.Nome,
            Telefone = dto.Telefone,
            Email = dto.Email,
            CPF = dto.CPF
        };
        await _clienteRepository.AdicionarAsync(cliente);
    }
    public async Task RemoveAsync(Guid id)
    {
        await _clienteRepository.RemoverAsync(id);
    }
}