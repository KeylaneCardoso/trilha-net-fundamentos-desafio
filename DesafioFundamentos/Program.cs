using DesafioFundamentos.Services;

Console.OutputEncoding = System.Text.Encoding.UTF8;

EstacionamentoImp es = new EstacionamentoImp(2, 2);


string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("\n---ESTACIONAMENTO---");
    Console.WriteLine("\nDigite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Visualizar dados do Estacionamento");
    Console.WriteLine("5 - Atualizar valores padrões");
    Console.WriteLine("6 - Encerrar\n");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("\nDigite a placa do veículo para estacionar:");
            string placaAdicionar = Console.ReadLine();
            es.AdicionarVeiculo(placaAdicionar);
            break;

        case "2":
            Console.WriteLine("\nDigite a placa do veículo para remover:");
            string placaRemover = Console.ReadLine();
            es.RemoverVeiculo(placaRemover);
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            Console.WriteLine(es);
            break;

        case "5":
            Console.WriteLine("Insira o preco inicial do estacionamento.:");
            decimal precoInicial = Convert.ToInt16(Console.ReadLine()); 

            Console.WriteLine("Insira o preco por hora do estacionamento:");
            decimal precoPorHora = Convert.ToInt16(Console.ReadLine()); 

            es.AtualizarValoresPadroes(precoInicial, precoPorHora);
            break;

        case "6":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar\n");
    Console.ReadLine();
}
Console.Clear();
Console.WriteLine("\nO programa se encerrou");