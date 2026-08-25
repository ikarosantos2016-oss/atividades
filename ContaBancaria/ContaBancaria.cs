using System;
using System.Globalization;
public class ContaBancaria
{
    private decimal Saldo;
    public string NumeroConta;
    public string NomeTitular;

     public ContaBancaria()
    {
        
    }
    public ContaBancaria(decimal saldo, string numeroConta, string nomeTitular)
    {
        this.Saldo = saldo;
        this.NumeroConta = numeroConta;
        this.NomeTitular = nomeTitular;
    }

   

    public void Depositar(decimal valor)
    {
        if(valor > 0)
        {
            Saldo += valor;
            System.Console.WriteLine($"Sua conta esta com o saldo de: R$ {Saldo}");
        }
        else
        {
            System.Console.WriteLine("O valor informado não pode ser negativo");
        }
    }

    public void Sacar(decimal valor)
    {
        if(Saldo >= valor && valor > 0)
        {
            Saldo -= valor;
            System.Console.WriteLine($"Você sacou: R$ {valor}, seu saldo após saque é: R$ {Saldo}");
        }
        else
        {
            System.Console.WriteLine("O valor de saque precisa ser menor ou igual o valor da conta.");
        }
    }

    public void ConsultaSaldo()
    {
        System.Console.WriteLine($"Seu saldo atual é de: R$ {Saldo}");
    }

    public void ExibirExtrato()
    {
        System.Console.WriteLine($"Numero da conta: {NumeroConta}\n Nome titular: {NomeTitular}\n Saldo em conta: R$ {Saldo}");
    }

}
