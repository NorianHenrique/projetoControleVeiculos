using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
// Norian Henrique
{
    // Classe Carga herda de Veiculo.
    public class Carga : Veiculo
    {
        // Atributo da Class com Encapsulamento
        public double CapacidadeCarga { get; set; }

        // Constructor da Class Marca com a superclasse Veiculo
        public Carga(string marca, string modelo, int ano, double capacidadeCarga)
            : base(marca, modelo, ano)
        {
            CapacidadeCarga = capacidadeCarga;
        }

        // Reescrevendo o metodo ExibirInformacoes - Usando Polimorfismo
        public override string ExibirInformacoes()
        {
            return $"Carga: {Marca} {Modelo} - Ano: {Ano} - Capacidade: {CapacidadeCarga} kg";
        }
    }

}
