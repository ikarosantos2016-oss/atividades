using System;

public class Program
{
    public static void Main(string[] args)
    {
        ContaBancaria contaIkaro = new ContaBancaria(1000, "10636615448", "José Íkaro Santos Fernandes");

        contaIkaro.Depositar(500);
        contaIkaro.Depositar(-500);

        contaIkaro.Sacar(200);
        contaIkaro.Sacar(3000);
    }
}
