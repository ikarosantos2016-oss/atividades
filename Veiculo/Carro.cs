public class Carro : Veiculo, ISeguranca, IManutencao
{
    public double Consumo = 12;

    public Carro(string marca, string modelo, int ano, string combustivel) : base(marca, modelo, ano, combustivel)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.ano = ano;
        this.combustivel = combustivel;
    }

    public override double CalcularConsumo(double distancia)
    {
        this.Consumo = distancia / this.Consumo;
        return this.Consumo;
    }

    public override void ExibirInformacoes()
    {
        System.Console.WriteLine($"Consumo do carro: {Consumo} km/l");
        base.ExibirInformacoes();
    }

    public void TrancarPortas()
    {
        System.Console.WriteLine("Portas trancadas.");
    }
    public void AtivarAlarme()
    {
        System.Console.WriteLine("Alarme ativado.");
    }
    public void TrocarOleo()
    {
        System.Console.WriteLine("Óleo trocado.");
    }
    public void TrocarPneus()
    {
        System.Console.WriteLine("Pneus trocados.");
    }
}