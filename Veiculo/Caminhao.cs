public class Caminhao : Veiculo
{
    public double Consumo = 6;

    public Caminhao(string marca, string modelo, int ano, string combustivel) : base(marca, modelo, ano, combustivel)
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
        System.Console.WriteLine($"Consumo do caminhão: {Consumo} km/l");
        base.ExibirInformacoes();
        
    }
}