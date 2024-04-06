using Projeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto;
// Norian Henrique

// Classe Utilitario herda de Misto.
public class Utilitario : Misto
{
    // Constructor da Class Utilitario com a superclasse Misto que esta herdando da Class Veiculo
    public Utilitario(string marca, string modelo, int ano)
        : base(marca, modelo, ano) { }


    // Reescrevendo o metodo ExibirInformacoes - Usando Polimorfismo
    public override string ExibirInformacoes()
    {
        return base.ExibirInformacoes() + " - Utilitário";
    }
}
