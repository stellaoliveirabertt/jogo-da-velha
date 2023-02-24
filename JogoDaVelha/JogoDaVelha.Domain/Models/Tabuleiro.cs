namespace JogoDaVelha.Domain
{
    public class Tabuleiro
    {
        public Dictionary<int, string> Posicoes { get; set; }

        public Tabuleiro()
        {
            Posicoes = new Dictionary<int, string>();

            for (int index = Constants.ValorTabuleiroInicial; index <= Constants.ValorTabuleiroFinal; index++)
            {
                Posicoes.Add(index, string.Empty);
            }
        }
    }
}
