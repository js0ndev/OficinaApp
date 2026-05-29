using OficinaApp.Domain.Enums;
namespace OficinaApp.Domain.Entities;
public class OrdemServico
{
    public Guid Id {get; set;} = Guid.NewGuid();
    public Guid ClienteId {get; set;}
    public Guid VeiculoId {get; set;}
    public DateTime DataEntrada {get; set;} = DateTime.UtcNow;
    public DateTime? DataSaida {get; set;}
    public string DescicaoProblema {get; set;} = string.Empty;
    public string Observacoes {get; set;} = string.Empty;
    public StatusOrdemServico Status {get; set;} = StatusOrdemServico.Aberta;
    public decimal ValorPecas {get; set;}
    public decimal ValorMaoDeObra {get; set;}
    public decimal ValorTotal {get; set;}

    // Propiedades de Navegação

    public Cliente? Cliente {get; set;}
    public Veiculo? Veiculo {get; set;}

    public List<OrdemServicoPeca> OrdemServicoPecas {get; set;} = new();
}