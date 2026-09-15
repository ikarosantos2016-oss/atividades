void UsarFrota(Veiculo[] frota)
{
    foreach (var veiculo in frota)
    {
        veiculo.ExibirInformacoes();
        double distancia = 100;
        double consumo = veiculo.CalcularConsumo(distancia);
        Console.WriteLine($"Consumo para {distancia} km: {consumo} litros");
    }
}

void Main()
{
    Veiculo[] frota =
    {
        new Carro("Fiat", "Uno", 2020, "Pinga 51"),
        new Moto("Suzuki", "GSX-R1000", 2021, "Red Bull"),
        new Caminhao("Volvo", "FH16", 2022, "Diesel")
    };
    UsarFrota(frota);
}

Main();
