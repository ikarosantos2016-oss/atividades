using System.Xml.Serialization;
using System.IO;
using System.Xml.Serialization;
public class ArquivoXML : Arquivo
{
    public override string Escrever()
    {
        Caminho = "book.xml";

        XmlSerializer writer = new XmlSerializer(typeof(Book));

        using (FileStream arquivoXML = File.Create(Caminho))
        {
            writer.Serialize(arquivoXML, new Book {title = "Harry Potter"});
        }
        return Caminho;
    }

    public override void Ler()
    {
        try
        {
            
            XmlSerializer reader = new XmlSerializer(typeof(Book));

            using (StreamReader arquivoXML = new StreamReader(Caminho))
            {
                Book book = (Book)reader.Deserialize(arquivoXML);
                Console.WriteLine($"Livro: {book.title}");
            }
        }
        catch (FileNotFoundException)
        {
            System.Console.WriteLine("Arquivo não encontrado");
        }
        catch (Exception)
        {
            System.Console.WriteLine("Ocorreu um erro ao ler o arquivo");
        }
    }
}