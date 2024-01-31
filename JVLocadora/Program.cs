//Declarando variáveis

using JVLocadora;

decimal precoInicial = 0;
decimal precoHora  = 0;

//Iniciar o sistema

Console.WriteLine("Seja bem vindo ao estacionamento do JV");
Console.WriteLine("---------------------------------------");

Console.WriteLine("Digite o preço inicial");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora");
precoHora = Convert.ToDecimal(Console.ReadLine());

//Instancia à classe estacionamento

Estacionamento es = new Estacionamento(precoInicial, precoHora);

//Loop

bool menu = true;

while (menu)
{
    Console.Clear();
    Console.WriteLine("Escolha uma opção");
    Console.WriteLine("1 - Adicionar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículo");
    Console.WriteLine("4 - Encerrar sistema");

    switch(Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;
        case "2":
            es.RemoverVeiculo();
            break;
        case "3":
            es.ListarVeiculo();
            break;
        case "4":
            menu = false;
            break;
        default:
            Console.WriteLine("Digite uma opção válida");
            break;
    }
    Console.WriteLine("Digite uma tecla para confirmar");
    Console.ReadLine();

}

Console.WriteLine("O programa encerrou! ");