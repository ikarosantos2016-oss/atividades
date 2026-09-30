using System.Text.Json;

public class ArquivoJson : Arquivo
{
    public override string Escrever()
    {
        Book book = new Book() { title = "Harry Potter 2" };

        //var options = new JsonSerializerOptions { WriteIndented = true };

        string jsonString = JsonSerializer.Serialize(book);

        Caminho = Environment.GetFolderPath
            (Environment.SpecialFolder.MyDocuments) +
            "\\book.json";

        File.WriteAllText(Caminho, jsonString);

        return Caminho;
    }

    public override void Ler()
    {
        Caminho = Environment.GetFolderPath
            (Environment.SpecialFolder.MyDocuments) +
            "\\book.json";

        string jsonString = File.ReadAllText(Caminho);

        var obj = JsonSerializer.Deserialize<Book>(jsonString);

        Console.WriteLine($"Book title: {obj.title}");
    }
}