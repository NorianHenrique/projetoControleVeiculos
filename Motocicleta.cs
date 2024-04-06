using Projeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto;
// Norian Henrique

// Classe Motocicleta herda de Passageiros.
public class Motocicleta : Passageiros
{
    // Constructor da Class Motocicleta com a superclasse Passageiros que esta herdando da Class Veiculo
    public Motocicleta(string marca, string modelo, int ano)
        : base(marca, modelo, ano, 2) { }

    // Reescrevendo o metodo ExibirInformacoes - Usando Polimorfismo
    public override string ExibirInformacoes()
    {
        return base.ExibirInformacoes() + " - Motocicleta";
    }
}
