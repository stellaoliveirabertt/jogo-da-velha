using JogoDaVelha.Domain.Interfaces.Repository;

namespace JogoDaVelha.Service
{
    public class TabuleiroService
    {

        public ITabuleiroRepository _tabuleiroRepository { get; set; }
        public IJogadorRepository _jogadorRepository { get; set; }

        public TabuleiroService(ITabuleiroRepository tabuleiroRepository, IJogadorRepository jogadorRepository)
        {
            _tabuleiroRepository = tabuleiroRepository;
            _jogadorRepository = jogadorRepository;
        }

        /*
             1 | 2 | 3  
             4 | 5 | 6 
             7 | 8 | 9  
         */

        public async Task RealizarUmaJogada(int posicao, Guid jogador, Guid tabuleiro)
        {
            var _tabuleiro = await _tabuleiroRepository.BuscarTabuleiro(tabuleiro);
            var _jogador = await _jogadorRepository.BuscarJogador(jogador);

            if (!_tabuleiro.Posicoes.ContainsKey(posicao))
            {
                _tabuleiro.Posicoes[posicao] = "";
            }
        }
    }
}