using JogoDaVelha.Domain.Models;

namespace JogoDaVelha.Domain.Interfaces.Repository
{
    public interface IJogadorRepository
    {
        Task<Jogador> BuscarJogador(Guid jogador);
    }
}
