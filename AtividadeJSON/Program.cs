
using System.IO;
using System.Xml.Serialization;

string writeXML()
{
    try
    {
        List<Book> livros = new List<Book>()
    {
        new Book(){title = "Harry Potter 1"},
        new Book(){title = "Harry Potter 2"},
        new Book(){title = "Harry Potter 3"}
    };
        // Book livro = new Book();
        // livro.title = "Harry Potter 1 - A Pedra Filosofal";
        // Prepara objeto serializador:
        XmlSerializer writer = new XmlSerializer(typeof(List<Book>));
        //Prepara o arquivo XML para gravar no disco:
        var path = Environment.GetFolderPath
        (Environment.SpecialFolder.MyDocuments) + "\\livros.xml";
        using (FileStream arquivoXML = File.Create(path))
        {
            // Realiza a serialização e gravação no disco:
            writer.Serialize(arquivoXML, livros);
            return path;
        }

    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Um erro aconteceu: {ex.Message}");
    }
}

// string caminhoDoArquivo = writeXML();
// Console.WriteLine($"Caminho: {caminhoDoArquivo}");

void ReadXML()
{
    try
    {
        XmlSerializer reader = new XmlSerializer(typeof(List<Book>));

        var path = Path.Combine(Environment.GetFolderPath
            (Environment.SpecialFolder.MyDocuments) + "\\livros2.xml");

        using (StreamReader arquivoXML = new StreamReader(path))
        {

            List<Book> livros = (List<Book>)reader.Deserialize(arquivoXML);

            foreach (var livro in livros)
            {
                System.Console.WriteLine($"Livro: {livro.title}");
            }
        }
    }
    catch (FileNotFoundException)
    {
        System.Console.WriteLine("Livro não encontrado!");
    }
    catch (InvalidOperationException)
    {
        System.Console.WriteLine("XML encontrado mas esta em formato invalido ou comrrompido");
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Occorreu um erro inesperado ao tentar acessar o arquivo XML: {ex.Message}");
    }
}
ReadXML();