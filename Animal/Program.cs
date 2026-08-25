using System;

public class Program
{
    public static void Main(string[] args)
    {
        Animal Mimi = new Animal("Mimi", "Felino", 3);
        Animal Rex = new Animal("Rex", "Canino", 5);
        Animal Piu = new Animal("Piu", "Ave", 1);

        Mimi.ApresentarSer();
        Mimi.Acordar();
        Mimi.FazerSom();
    }
}