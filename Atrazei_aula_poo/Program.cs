try
{
    int a = int.Parse("2");
    System.Console.WriteLine("Digite um valor de preferencia invalido para teste: ");
    int idade = int.Parse(System.Console.ReadLine());

    if (idade < 0)
    {
        throw new IdadeInvalidaException("Idade não pode ser negativa");
    }
}
catch (IdadeInvalidaException ex)
{
    System.Console.WriteLine(ex.Message);
}
catch (FormatException )
{
    System.Console.WriteLine("Erro de formato!");   
}
catch (Exception )
{
    System.Console.WriteLine("Erro genérico:");
}
finally
{
    System.Console.WriteLine("teste de finally");
}