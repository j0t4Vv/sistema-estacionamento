using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JVLocadora
{
    internal class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculos = new List<string>();

        //ctor
        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo");
            string placa = Console.ReadLine().ToUpper();

            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Já existe um veículo com essa placa");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículo cadastrado com sucesso");
            }

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa de veículo");
            string placa = Console.ReadLine().ToUpper();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo ficou no estacionamento");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal precoTotal = precoInicial + precoHora * horas;
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo de placa {placa} e deve pagar R${precoTotal:F2}");

            }
            else
            {
                Console.WriteLine("O veículo não foi encontrado em nosso pátio");
            }
        }

        public void ListarVeiculo()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículo estacionados são");
                foreach (var v in veiculos)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos em nosso pátio");
            }
        }
    }
}
