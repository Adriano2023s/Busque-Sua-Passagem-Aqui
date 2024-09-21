namespace CompraDePassagem
{
    internal class PassagemAerea
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string DataViagem { get; set; }
        public double PrecoBase { get; set; }

        public PassagemAerea(string origem, string destino, string dataviagem, double preco)
        {
            Origem = origem;
            Destino = destino;
            DataViagem = dataviagem;
            PrecoBase = preco;
        }

        public virtual double CalcularPreco()
        {
            return PrecoBase;
        }
    }
}
