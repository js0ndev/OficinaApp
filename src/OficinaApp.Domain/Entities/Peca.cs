namespace OficinaApp.Domain.Entities;

public class Peca
{
    public Guid Id {get;set;} = Guid.NewGuid();
    public string Nome {get;set;} = string.Empty;
    public string Fornecedor {get;set;} = string.Empty;
    public int QtdEstoque {get;set;}
    public decimal ValorUnitario {get;set;}

    // Propiedade de Navegação

    public List<OrdemServicoPeca> OrdemServicoPecas {get;set;} = new();
}