using Projeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
// Norian Henrique
{
    // Classe Caminhonete herda de Carga.
    public class Caminhonete : Carga
    {
        // Constructor da Class Caminhonete com a superclasse Carga que esta herdando da Class Veiculo
        public Caminhonete(string marca, string modelo, int ano, double capacidadeCarga)
            : base(marca, modelo, ano, capacidadeCarga) { }

        // Reescrevendo o metodo ExibirInformacoes - Usando Polimorfismo
        public override string ExibirInformacoes()
        {
            return base.ExibirInformacoes() + " - Caminhonete";
        }
    }
}
