using System;

namespace CompraDePassagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Adriano");

            ClasseEconomica classeEconomica = new ClasseEconomica("Fortaleza", "São Paulo", "2024-09-07", 735.58, true);
            ClasseExecutiva executiva = new ClasseExecutiva("Fortaleza", "Portugal", "24-11-13", 1555.33);

            cliente.Reservar(classeEconomica);
            cliente.Reservar(executiva);
            Console.WriteLine("Bem vindo a TPM ARLINES!");
            Console.WriteLine($"Senhor: {cliente.NomeCliente}");
            Console.WriteLine();
            Console.WriteLine($"O valor da sua passagem é de: {cliente.CalcularPassagem()}");
        }
    }
}