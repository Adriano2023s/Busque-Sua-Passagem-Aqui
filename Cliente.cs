using System.Collections.Generic;

namespace CompraDePassagem
{
    internal class Cliente
    {
        public string NomeCliente { get; set; }
        public List <PassagemAerea> Reservas {  get; set; }

        public Cliente(string nome)
        {
            NomeCliente = nome;
            Reservas = new List<PassagemAerea>();
        }

        public void Reservar(PassagemAerea passagem)
        {
            Reservas.Add(passagem);
        }

        public double CalcularPassagem()
        {
            double total = 0;

            foreach (PassagemAerea passagem in Reservas)
            {
                total += passagem.CalcularPreco();
            }
            return total;
        }
    }
}
