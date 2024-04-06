using Projeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto;
// Norian Henrique

// Classe Automovel herda de Passageiros.
public class Automovel : Passageiros
{
    // Constructor da Class Automovel com a superclasse Passageiros que esta herdando da Class Veiculo
    public Automovel(string marca, string modelo, int ano, int capacidadePassageiros)
        : base(marca, modelo, ano, capacidadePassageiros) { }

    // Reescrevendo o metodo ExibirInformacoes - Usando Polimorfismo
    public override string ExibirInformacoes()
    {
        return base.ExibirInformacoes() + " - Automóvel";
    }
}
