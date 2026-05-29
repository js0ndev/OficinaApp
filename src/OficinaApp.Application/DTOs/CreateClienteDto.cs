using System.ComponentModel.DataAnnotations;

namespace OficinaApp.Application.DTOs;

public class CreateClienteDto
{
    public string Nome {get;set;} = string.Empty;
    public string Telefone {get;set;} = string.Empty;
    [EmailAddress]
    public string Email {get;set;} = string.Empty;
    public string CPF {get;set;} = string.Empty;
}