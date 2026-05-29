namespace OficinaApp.Domain.Entities;
public class Veiculo
{
    public Guid Id {get; set;} = Guid.NewGuid();
    public Guid ClienteId {get; set;}
    public string Marca { get; set; } = string.Empty;

    public string Modelo { get; set; } = string.Empty;

    public int Ano { get; set; }

    public string Placa { get; set; } = string.Empty;

    public string Cor { get; set; } = string.Empty;

    public int Quilometragem { get; set; }

    // Propiedades de Navegação
    public Cliente? Cliente {get; set;}
    public List<OrdemServico> OrdensServico {get; set;} = new();

}