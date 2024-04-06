using Projeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto;
// Norian Henrique

// Classe Caminhao herda de Carga.
public class Caminhao : Carga
{
    // Constructor da Class Caminhao com a superclasse Carga que esta herdando da Class Veiculo
    public Caminhao(string marca, string modelo, int ano, double capacidadeCarga)
        : base(marca, modelo, ano, capacidadeCarga) { }


    // Reescrevendo o metodo ExibirInformacoes - Usando Polimorfismo
    public override string ExibirInformacoes()
    {
        return base.ExibirInformacoes() + " - Caminhão";
    }
}
