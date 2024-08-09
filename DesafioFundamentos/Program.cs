using DesafioFundamentos;
using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Clear();
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
decimal precoInicial = Utils.GetDecimalValueFromUser("Digite o preço da taxa de Entrada:");
decimal precoPorHora = Utils.GetDecimalValueFromUser("Digite o preço da permanência por hora: ");

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

do{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Entrada de veículo");
    Console.WriteLine("2 - Saida de veículo");
    Console.WriteLine("3 - Veículos estacionados");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            goto exit_loop;

        default:
            Console.Write("Opção inválida!");
            Utils.ShowWaitMessageAndClearConsole();
            break;
    }
}while(true);

exit_loop:;
Console.WriteLine("Obrigado por usar o sistema de estacionamento!");
Utils.ShowWaitMessageAndClearConsole();