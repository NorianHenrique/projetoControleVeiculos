using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
// Norian Henrique
{
    // Classe Bicicleta herda de Passageiros.
    public class Bicicleta : Passageiros
    {
        // Constructor da Class Bicicleta com a superclasse Passageiros que esta herdando da Class Veiculo
        public Bicicleta(string marca, string modelo, int ano) : base(marca, modelo, ano, 1) { }

        // Reescrevendo o metodo ExibirInformacoes - Usando Polimorfismo
        public override string ExibirInformacoes()
        {
            return base.ExibirInformacoes() + " - Bicicleta";
        }
    }
}
