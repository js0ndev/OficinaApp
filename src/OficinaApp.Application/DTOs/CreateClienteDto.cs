using System.ComponentModel.DataAnnotations;

namespace OficinaApp.Application.DTOs;

public class CreateClienteDto
{
    [Required(ErrorMessage ="O nome é obrigatório")]
    [MaxLength(100)]
    public string Nome {get;set;} = string.Empty;
    [Required(ErrorMessage ="O telefone é obrigatório")]
    [Phone(ErrorMessage ="Telefone inválido")]
    public string Telefone {get;set;} = string.Empty;
    [Required(ErrorMessage ="O email é obrigatório")]
    [EmailAddress(ErrorMessage ="Email inválido")]
    public string Email {get;set;} = string.Empty;
    [Required(ErrorMessage ="O CPF é obrigatório")]
    [MaxLength(14)]
    public string CPF {get;set;} = string.Empty;
}