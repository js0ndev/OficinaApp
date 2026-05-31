using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OficinaApp.Application.Interfaces;
using OficinaApp.Domain.Entities;

namespace OficinaApp.Web.Pages.Clientes;

public class DeleteModel : PageModel
{
    private readonly IClienteService _clienteService;

    public DeleteModel(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }
    [BindProperty]
    public Cliente Cliente {get;set;} = new();
    public async Task <IActionResult> OnGetAsync(Guid id)
    {
        var cliente = await _clienteService.ObterPorIdAsync(id);
        if(cliente is null) return NotFound();
        Cliente = cliente;
        return Page();
    }
    public async Task <IActionResult> OnPostAsync(Guid id)
    {
        await _clienteService.RemoveAsync(id);

        return RedirectToPage("Index");
    }
}