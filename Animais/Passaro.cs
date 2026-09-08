
internal class Passaro : Animais{

    public override void FazerSom()

    {
        System.Console.WriteLine($"{Nome} faz: piu piu!");
    }

    public override void Mover()
    {
        System.Console.WriteLine($"{Nome} voa com as assas");
    }

}