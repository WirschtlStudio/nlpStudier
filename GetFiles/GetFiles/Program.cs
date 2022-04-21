using GetFiles;
using System.Text.Json;
const string JSON_DATA_PATH = "data.json";

// Create Subjects - input from chatbot
var swp = new Subject("Softwareentwicklung", "C:/Users/Stephan/OneDrive - HTL Neufelden/SWP");
var spanish = new Subject("Spanisch", "C:/Users/Stephan/OneDrive - HTL Neufelden/Spanisch");

// save "favorite" subjects to json file, in order to spare repeated input of same subject
var subjectFavorites = new List<Subject>();
subjectFavorites.Add(swp);
subjectFavorites.Add(spanish);
subjectFavorites.Add(new Subject("Labor", "C:/Users/Stephan/OneDrive - HTL Neufelden/Labor"));

// Save Favorites into json-file 
var serializedFavorites = JsonSerializer.Serialize<Subject[]>(subjectFavorites.ToArray());
await File.WriteAllTextAsync("C:/Users/Stephan/data.json", serializedFavorites);

// Get Favorites from json-file
var readData = await File.ReadAllTextAsync(JSON_DATA_PATH);
var readSubjectFavorites = JsonSerializer.Deserialize<Subject[]>(readData);

// find files within a specific name criteria
// forexample, to find jpg -> criteria is "*.jpg"
var files = SubjectFilesFinder.GetAllFiles(subjectFavorites[0].Path, "").ToArray();
foreach(var s in files)
{
    Console.WriteLine(s);
}
