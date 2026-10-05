public class FuncionarioPJ : Funcionario
{
    public override void CalcularBonus(double salario){
        double bonus = salario* 1.5;
        System.Console.WriteLine($"Seu salario é: {salario}.\nCom bonus fica: {bonus}\nSomente o bonus: "+ {bonus}-{salario}".");
        System.Console.WriteLine("Meu queridinho!");
    }
}