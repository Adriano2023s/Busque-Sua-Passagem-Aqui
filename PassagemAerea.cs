namespace CompraDePassagem
{
    internal class PassagemAerea
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string DataViagem { get; set; }
        public double Preco { get; set; }

        public PassagemAerea(string origem, string destino, string dataviagem, double preco)
        {
            Origem = origem;
            Destino = destino;
            DataViagem = dataviagem;
            Preco = preco;
        }

        public double CalcularPreco()
        {
            double horaDeVou = CalcularDistancia(Origem, destino);
            double precoDaHora = 0.5;
            return horaDeVou * precoDaHora;
            }
    }
}
