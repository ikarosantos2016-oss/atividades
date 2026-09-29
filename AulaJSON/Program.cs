using System.Text.Json;

string WriteJson()
{
    var weatherforecast = new WeatherForecast
    {
        Date = DateTime.Parse("2019-08-01"),
        TemperatureCelsius = 25,
        Summary = "Hot"
    };
    var options = new JsonSerializerOptions {WriteIndented = true};
    //string jsonString = JsonSerializer.Serialize(weatherforecast);
    byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(weatherforecast, options);

    var path = Environment.GetFolderPath
            (Environment.SpecialFolder.MyDocuments) + "\\weatherforecastUtf8.json";
    File.WriteAllBytes(path, jsonUtf8Bytes);

    return path;
}

void ReadJson(){
    var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\weatherforecastUtf8.json";
    string jsonString = File.ReadAllText(path);
    var obj = JsonSerializer.Deserialize<WeatherForecast>(jsonString);
    System.Console.WriteLine($"Date: {obj.Date}");
    System.Console.WriteLine($"TemperatureCelsius: {obj.TemperatureCelsius}");
    System.Console.WriteLine($"Summary: {obj.Summary}");
}

ReadJson();

//Console.WriteLine($"O aquivo JSON salvo e: {WriteJson()}");



