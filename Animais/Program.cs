void FazerAnimalAgir(Animais animais)
{
        animais.FazerSom();
        animais.Mover();
}

void Main(){
        Animais[] bixos = 
        {
                new Cachorro {Nome = "Rex"},
                new Passaro {Nome = "Golinha"},
                new Cachorro {Nome = "Brabão"}
        };

        foreach (var animais in bixos)
        {
                FazerAnimalAgir(animais);
                Console.WriteLine("---");
        }

        // FazerAnimalAgir(new Passaro{ Nome = "Golinha"});

        // Cachorro cachorro = new Cachorro();
        // cachorro.Nome="rex";
        // FazerAnimalAgir(cachorro);
        

        // Animais rex = new Cachorro();
        // rex.Nome = "Rex";
        // Animais pinto = new Passaro();
        // pinto.Nome = "pinto";

        // rex.FazerSom();
        // pinto.FazerSom();
        
}

Main();