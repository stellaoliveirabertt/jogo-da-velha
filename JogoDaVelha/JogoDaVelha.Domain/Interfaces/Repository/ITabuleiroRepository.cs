namespace JogoDaVelha.Domain.Interfaces.Repository
{
    public interface ITabuleiroRepository
    {
        Task<Tabuleiro> BuscarTabuleiro(Guid tabuleiro);
    }
}
