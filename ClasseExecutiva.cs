namespace CompraDePassagem
{
    internal class ClasseExecutiva : PassagemAerea
    {
        public ClasseExecutiva(string origem, string destino, string dataviagem, double preco)
            : base(origem, destino, dataviagem, preco)
        {

        }

        public override double CalcularPreco()
        {
            return PrecoBase * 1.30;
        }
    }
}
