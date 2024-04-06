using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
// Norian Henrique

{
    // Classe Passageiros herda de Veiculo.
    public class Passageiros : Veiculo
    {
        // Atributo da Class com Encapsulamento
        public int CapacidadePassageiros { get; set; }

        // Constructor da Class Passageiros com a superclasse Veiculo
        public Passageiros(string marca, string modelo, int ano, int capacidadePassageiros)
            : base(marca, modelo, ano)
        {
            CapacidadePassageiros = capacidadePassageiros;
        }

        // Reescrevendo o metodo ExibirInformacoes - Usando Polimorfismo
        public override string ExibirInformacoes()
        {
            return $"Passageiros: {Marca} {Modelo} - Ano: {Ano} - Capacidade: {CapacidadePassageiros}";
        }
    }
}
