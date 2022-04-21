using GetFiles;
using System.Text.Json;

var swp = new Subject("Softwareentwicklung", "C:/Users/Stephan/OneDrive - HTL Neufelden");

var strJson = JsonSerializer.Serialize<Subject>(swp);
Console.WriteLine(strJson);

var nonJson = JsonSerializer.Deserialize<Subject>(strJson);
Console.WriteLine(nonJson.GetType());
Console.WriteLine(nonJson.Name);