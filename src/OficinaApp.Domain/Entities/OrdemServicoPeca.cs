namespace OficinaApp.Domain.Entities;

public class OrdemServicoPeca
{
    public Guid OrdemServicoId {get;set;}
    public Guid PecaId {get;set;}
    public int Qtd {get;set;}
    public decimal ValorUnitario {get;set;}

    // Propiedade de navegação
    public OrdemServico? OrdemServico {get;set;}
    public Peca? Peca {get;set;}
}