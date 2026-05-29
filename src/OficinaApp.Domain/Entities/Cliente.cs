using System.ComponentModel.DataAnnotations;

namespace OficinaApp.Domain.Entities;
public class Cliente
{
    public Guid Id {get; set;} = Guid.NewGuid();
    public string Nome {get; set;} = string.Empty;
    public string Telefone {get; set;} = string.Empty;

    [EmailAddress]
    public string Email {get; set;} = string.Empty;
    public string CPF {get; set;} = string.Empty;
    public DateTime Data {get; set;} = DateTime.UtcNow;

    //Propiedade Navegação
    public List<Veiculo> Veiculos {get; set;} = new();


}