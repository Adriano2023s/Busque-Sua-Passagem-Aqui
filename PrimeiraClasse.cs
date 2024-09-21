namespace CompraDePassagem
{
    internal class PrimeiraClasse : PassagemAerea
    {
        public PrimeiraClasse(string origem, string destino, string dataviagem, double preco)
            : base(origem, destino, dataviagem, preco)
        {

        }

        public override double CalcularPreco()
        {
            return PrecoBase * 1.50;
        }

        public string Servico()
        {
            return "Muito bem, por optar por viajar na primeira classe, você como passageiro premium, ganhará alguns mimos. Wifi a bordo para está sempre conectado, sistema de intetrenimento para sua diversão! E a melhor comida. Muito obrigado por viajar na TPM ARLINES.";
        }
    }
}
