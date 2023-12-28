namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("\nDigite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Este veiculo já está estacionado. Confira se digitou a placa corretamente\n");
            }
            else
            {
                veiculos.Add(placa);
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("\nDigite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Insira a quantidade de horas que o veiculo permaneceu estacionado:");
                int horas = Convert.ToInt16(Console.ReadLine()); 
                decimal valorTotal = precoInicial + (precoPorHora * horas); 
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}\n");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente\n");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("\nOs veículos estacionados são:");
                Console.WriteLine($"Quantidade total............: {veiculos.Count}");

                for(int i = 0; i < veiculos.Count; i++){
                    Console.WriteLine($"{i + 1} | {veiculos[i]}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.\n");
            }
        }
    }
}