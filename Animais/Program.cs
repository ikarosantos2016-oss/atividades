public class Program{
    public static void Main(){
        Animais rex = new Cachorro();
        rex.Nome = "Rex";
        Animais pinto = new Passaro();
        pinto.Nome = "pinto";

        rex.FazerSom();
        rex.Mover();

        pinto.FazerSom();
        pinto.Mover();
    }
}