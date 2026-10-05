public class FuncionarioCLT : Funcionario
{
    public override void CalcularBonus(double salario){
        double bonus = salario* 1.1;
        System.Console.WriteLine($"Seu salario é: {salario}.\nCom bonus fica: {bonus}\nSomente o bonus: "+ {bonus}-{salario}".");
        System.Console.WriteLine("Meu escravinho!");
    }
}