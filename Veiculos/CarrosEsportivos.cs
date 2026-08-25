using System;
using Carro;

public class CarrosEsportivos : Carro
{
    private bool NoS = false;
    private bool Turbo = false;

    public CarrosEsportivos(bool nos, bool turbo) : base (){
        this.NoS = nos;
        this.Turbo = turbo;
    }
}
