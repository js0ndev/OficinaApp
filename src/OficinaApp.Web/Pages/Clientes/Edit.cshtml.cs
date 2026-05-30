using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OficinaApp.Application.DTOs;
using OficinaApp.Application.Interfaces;

namespace OficinaApp.Web.Pages.Clientes;

public class EditModel : PageModel
{
    private readonly IClienteService _clienteService;

    public EditModel(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }
    [BindProperty]
    public UpdateClienteDto Cliente{get;set;} = new();

    public async Task<IActionResult> OnGetAsync(Guid id)
    {
        var cliente = await _clienteService.ObterPorIdAsync( id);
        if(cliente is null) return NotFound();
        
        Cliente = new UpdateClienteDto
        {
            Id = cliente.Id,
            Nome = cliente.Nome,
            Telefone = cliente.Telefone,
            Email = cliente.Email,
            CPF = cliente.CPF
        };
        return Page();
    }
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
            return Page();

        await _clienteService.AtualizarAsync(Cliente);

        return RedirectToPage("Index");
    }
}