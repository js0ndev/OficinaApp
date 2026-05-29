using Microsoft.AspNetCore.Mvc.RazorPages;
using OficinaApp.Application.Interfaces;
using OficinaApp.Domain.Entities;

namespace OficinaApp.Web.Pages.Clientes;

public class IndexModel : PageModel
{
    private readonly IClienteService _clienteService;
    public IndexModel(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }
    public List<Cliente> Clientes{get; set;} = new();

    public async Task OnGetAsync()
    {
        Clientes = await _clienteService.ObterTodosAsync();
    }
}