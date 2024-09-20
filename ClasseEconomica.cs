namespace CompraDePassagem
{
    internal class ClasseEconomica : PassagemAerea
    {
        public bool ClienteFrequente { get; set; }

        public ClasseEconomica(string origem, string destino, string dataviagem, double preco, bool clientefrequente)
            : base(origem, destino, dataviagem, preco, clientefrequente)
        {
            ClienteFrequente = clientefrequente;
        }

        public override double CalcularPreco()
        {
            double preco = PrecoBase;

            if (ClienteFrequente)
            {
                preco *= 0.90;
            }
            return preco;
        }

    }
}
