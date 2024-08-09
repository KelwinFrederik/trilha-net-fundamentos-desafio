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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var placa = Console.ReadLine();

            if(!veiculos.Contains(placa))
                veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            var placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToLower() == placa.ToLower()))
            {
                int horas = Utils.GetIntValueFromUser("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                decimal valorTotal = precoInicial + (precoPorHora * Convert.ToDecimal(horas)); 

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} está de saída. O preço total a pagar é de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }

            Utils.ShowWaitMessageAndClearConsole();
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.Clear();
                Console.WriteLine("VEÍCULOS ESTACIONADOS: ");

                veiculos.ForEach(veiculo => {
                    Console.WriteLine(veiculo);
                });
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }

            Utils.ShowWaitMessageAndClearConsole();
        }
    }
}
