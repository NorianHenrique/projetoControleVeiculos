using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto;

using Projeto;
using System.Collections.Generic;

// Classe principal para gerenciar revenda e veículos.
public class Revenda
{
    // Atributo da Class com Encapsulamento
    public string Nome { get; set; }

    // Uma List da Class Veiculo com Encapsulamento - Pode apenas se defenida dentro da Class, somente sua leitura e publica
    public List<Veiculo> Veiculos { get; private set; }

    // Constructor da Class Revenda - Instanciando a Class Veiculo
    public Revenda()
    {
        Veiculos = new List<Veiculo>();
    }

    // Metodo para adicionar os veiculos
    public void AdicionarVeiculo(Veiculo veiculo)
    {
        Veiculos.Add(veiculo);
    }

    // Metodo para listar os veiculos
    public void ListarVeiculos()
    {
        Console.WriteLine("Listagem de Veículos:");
        foreach (Veiculo veiculo in Veiculos)
        {
            Console.WriteLine(veiculo.ExibirInformacoes());
        }
    }

    // Metodo para listar os tipos de veiculos 
    public void ListarVeiculosPorTipo<T>() where T : Veiculo
    {
        Console.WriteLine($"Listagem de Veículos do tipo {typeof(T).Name}:");
        foreach (Veiculo veiculo in Veiculos)
        {
            if (veiculo is T)
            {
                Console.WriteLine(veiculo.ExibirInformacoes());
            }
        }
    }
}
