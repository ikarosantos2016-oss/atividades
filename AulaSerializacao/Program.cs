using System.Xml.Serialization;
string writeXML()
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
    FileStream arquivoXML = File.Create(path);
    // Realiza a serialização e gravação no disco:
    writer.Serialize(arquivoXML, livros);
    arquivoXML.Close();
    return path;

}

// string caminhoDoArquivo = writeXML();
// Console.WriteLine($"Caminho: {caminhoDoArquivo}");

void ReadXML()
{
     try
    {
        XmlSerializer reader = new XmlSerializer(typeof(List<Book>));
        var path = Environment.GetFolderPath
            (Environment.SpecialFolder.MyDocuments) + "\\livros2.xml";
        StreamReader arquivoXML = new StreamReader(path);
   
        List<Book> livros = (List<Book>)reader.Deserialize(arquivoXML);
        
        foreach (var livro in livros)
        {
            System.Console.WriteLine($"Livro: {livro.title}");
        }

        arquivoXML.Close();
    }
    catch (System.IO.FileNotFoundException)
    {
        System.Console.WriteLine("Livro não encontrado!");
    }
    catch(Exception){
        System.Console.WriteLine("Ocorreu um erro inesperado ao tentar acessar o arquivo XML");
    }
}
ReadXML();