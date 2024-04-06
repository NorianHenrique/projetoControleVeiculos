using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
// Norian Henrique
{
    // Classe Misto herda de Veiculo.
    public class Misto : Veiculo
    {
        // Constructor da Class Misto com a superclasse Veiculo
        public Misto(string marca, string modelo, int ano)
            : base(marca, modelo, ano) { }

        // Reescrevendo o metodo ExibirInformacoes - Usando Polimorfismo
        public override string ExibirInformacoes()
        {
            return $"Misto: {Marca} {Modelo} - Ano: {Ano}";
        }
    }
}
