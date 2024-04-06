using System;

// Definição abstrata da classe Veiculo representando os atributos e métodos comuns a todos os veículos.
// Norian Henrique

namespace Projeto;

// Class Abstract
public abstract class Veiculo
{
    // Atributos da Class com Encapsulamento
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    // Constructor da Class com protected
    protected Veiculo(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    // Método abstrato para retorno de informações do veículo.
    public abstract string ExibirInformacoes();
}

