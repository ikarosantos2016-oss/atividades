public abstract class Veiculo
{
    public string marca {get; set;}
    public string modelo {get; set;}
    public int ano {get; set;}
    public string combustivel{get; set;}

    public Veiculo(string marca, string modelo, int ano, string combustivel)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.ano = ano;
        this.combustivel = combustivel;
    }

    public abstract double CalcularConsumo(double distancia);
    

    public virtual void ExibirInformacoes()
    {
        System.Console.WriteLine($"Marca: {marca}");
        System.Console.WriteLine($"Modelo: {modelo}");
        System.Console.WriteLine($"Ano: {ano}");
        System.Console.WriteLine($"Combustivel: {combustivel}");
        System.Console.WriteLine("-----------------------------");
    }

    public void Acelerar()
    {
        System.Console.WriteLine("Acelerando...");
    }
}