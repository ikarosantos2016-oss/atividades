using System;
using Veiculos;

public class Carros : Veiculos
{
    protected string Modelo;
    protected int QuantidadeLugares;

    public Carros (string nome, int velocidade, int aceleracao, string modelo, int quantidadeLugares) : base (nome, velocidade, aceleracao){
        this.Nome = nome;
        this.Modelo = modelo;
        this.QuantidadeLugares = quantidadeLugares;
    }
}
