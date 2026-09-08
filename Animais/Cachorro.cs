internal class Cachorro : Animais{

public override void FazerSom()

{
    System.Console.WriteLine($"{Nome} faz: Au au!");
}

public override void Mover()
{
    System.Console.WriteLine($"{Nome} corre com quatro patas");
}

}