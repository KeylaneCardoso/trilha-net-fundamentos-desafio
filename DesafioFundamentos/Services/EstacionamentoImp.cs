using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Services
{
    public class EstacionamentoImp
    {
        private decimal precoInicial { get; set; }
        private decimal precoPorHora { get; set; }
        private List<string> veiculos = new List<string>();

        internal decimal PrecoInicialParaTeste => precoInicial;
        internal decimal PrecoPorHoraParaTeste => precoPorHora;

        
        public List<string> Veiculos
        {
            get { return veiculos; }
            set { veiculos = value; }
        }

        public EstacionamentoImp(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(string placa)
        {
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("[ERRO] Este veiculo já está estacionado. Confira se digitou a placa corretamente\n");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veiculo adicionado com sucesso!");
            }
        }

        public void RemoverVeiculo(string placa)
        {
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Insira a quantidade de horas que o veiculo permaneceu estacionado:");
                int horas = Convert.ToInt16(Console.ReadLine()); 
                decimal valorTotal = this.precoInicial + (this.precoPorHora * horas); 
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}\n");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente\n");
            }
        }

        // public void ListarVeiculos()
        // {
        //     if (veiculos.Any())
        //     {
        //         Console.WriteLine("\nVEÍCULOS ESTACIONADOS");
        //         Console.WriteLine($"Quantidade total.....: {veiculos.Count}\n");

        //         for(int i = 0; i < veiculos.Count; i++){
        //             Console.WriteLine($"{i + 1} | {veiculos[i]}");
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine("Não há veículos estacionados.\n");
        //     }
        // }
        public string ListarVeiculos()
        {
            if (veiculos.Count > 0)
            {
                string output = "\nVEÍCULOS ESTACIONADOS\n";
                output += $"Quantidade total.....: {veiculos.Count}\n";

                for (int i = 0; i < veiculos.Count; i++)
                {
                    output += $"{i + 1} | {veiculos[i]}\n";
                }

                return output;
            }
            else
            {
                return "Não há veículos estacionados.\n";
            }
        }

        public void AtualizarValoresPadroes(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public override string ToString()
        {
            return $"----------DADOS ESTACIONAMENTO----------\n" +
                $"Preço inicial.................: {this.precoInicial}\n" +
                $"Preço por hora................: {this.precoPorHora}\n" +
                $"Total de veiculos estacionados: {veiculos.Count}";
        }
    }
}