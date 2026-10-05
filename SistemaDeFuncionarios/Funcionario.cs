public abstract class Funcionario{
    protected string Nome{get; set;}
    protected double Salario{get; set;}

    public Funcionario(string nome, double salario)
    {
        Nome = nome;
        Salario = salario;
    }

    public abstract void CalcularBonus(double salario);
}