using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OficinaApp.Application.DTOs;
using OficinaApp.Application.Interfaces;

namespace OficinaApp.Web.Pages.Clientes;

public class CreateModel : PageModel
{
    private readonly IClienteService _clienteService;

    public CreateModel(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }
    [BindProperty]
    public CreateClienteDto Cliente {get;set;} = new();
    public void OnGet()
    {
        
    }
    public async Task<IActionResult> OnPostAsync()
    {
        if(!ModelState.IsValid) return Page();

        await _clienteService.CriarAsync(Cliente);

        return RedirectToPage("Index");
    }
}