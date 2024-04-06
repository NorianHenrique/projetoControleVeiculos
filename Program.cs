using Projeto;
// Norian Henrique
class Program
{
    // Instanciando a Classe Revenda - De forma Static, assim todos os seus metodos sao statics
    static Revenda revenda = new Revenda();

    static void Main(string[] args)
    {
        bool sair = false;
        do
        {
            // Menu do Console
            Console.Clear();
            Console.WriteLine("Sistema de Gerenciamento de Veículos");
            Console.WriteLine("1. Cadastrar revenda");
            Console.WriteLine("2. Adicionar veículos");
            Console.WriteLine("3. Listar todos os veículos");
            Console.WriteLine("4. Listar veículos por tipo");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarRevenda();
                    break;
                case 2:
                    AdicionarVeiculos();
                    break;
                case 3:
                    revenda.ListarVeiculos();
                    break;
                case 4:
                    ListarVeiculosPorTipo();
                    break;
                case 0:
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        } while (!sair);
    }

    static void CadastrarRevenda()
    {
        Console.Write("Digite o nome da revenda: ");
        revenda.Nome = Console.ReadLine();
        Console.WriteLine("Revenda cadastrada com sucesso.");
    }

    static void AdicionarVeiculos()
    {
        Console.Write("Digite o tipo de veículo (Bicicleta, Automovel, Motocicleta, Caminhonete, Caminhao, Utilitario): ");
        string tipo = Console.ReadLine();
        Console.Write("Marca: ");
        string marca = Console.ReadLine();
        Console.Write("Modelo: ");
        string modelo = Console.ReadLine();
        Console.Write("Ano: ");
        int ano = int.Parse(Console.ReadLine());

        Veiculo veiculo = null;
        switch (tipo.ToLower())
        {
            case "bicicleta":
                veiculo = new Bicicleta(marca, modelo, ano);
                break;
            case "automovel":
                Console.Write("Capacidade de Passageiros: ");
                int capPassageiros = int.Parse(Console.ReadLine());
                veiculo = new Automovel(marca, modelo, ano, capPassageiros);
                break;
            case "motocicleta":
                veiculo = new Motocicleta(marca, modelo, ano);
                break;
            case "caminhonete":
                Console.Write("Capacidade de Carga (kg): ");
                double capCarga = double.Parse(Console.ReadLine());
                veiculo = new Caminhonete(marca, modelo, ano, capCarga);
                break;
            case "caminhao":
                Console.Write("Capacidade de Carga (kg): ");
                capCarga = double.Parse(Console.ReadLine());
                veiculo = new Caminhao(marca, modelo, ano, capCarga);
                break;
            case "utilitario":
                veiculo = new Utilitario(marca, modelo, ano);
                break;
            default:
                Console.WriteLine("Tipo de veículo inválido.");
                return;
        }

        revenda.AdicionarVeiculo(veiculo);
        Console.WriteLine("Veículo adicionado com sucesso.");
    }

    static void ListarVeiculosPorTipo()
    {
        Console.Write("Digite o tipo de veículo para listar (Bicicleta, Automovel, Motocicleta, Caminhonete, Caminhao, Utilitario): ");
        string tipo = Console.ReadLine();

        switch (tipo.ToLower())
        {
            case "bicicleta":
                revenda.ListarVeiculosPorTipo<Bicicleta>();
                break;
            case "automovel":
                revenda.ListarVeiculosPorTipo<Automovel>();
                break;
            case "motocicleta":
                revenda.ListarVeiculosPorTipo<Motocicleta>();
                break;
            case "caminhonete":
                revenda.ListarVeiculosPorTipo<Caminhonete>();
                break;
            case "caminhao":
                revenda.ListarVeiculosPorTipo<Caminhao>();
                break;
            case "utilitario":
                revenda.ListarVeiculosPorTipo<Utilitario>();
                break;
            default:
                Console.WriteLine("Tipo de veículo inválido.");
                break;
        }
    }
}