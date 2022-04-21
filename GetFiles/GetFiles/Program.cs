using GetFiles;
using System.Text.Json;

var swp = new Subject("Softwareentwicklung", "C:/Users/Stephan/OneDrive - HTL Neufelden/SWP");
var testSubj = new Subject("testSubj", "C:/Users/Stephan/OneDrive - HTL Neufelden/KU/3AHWII/Proj3-3DDruck");

//var strJson = JsonSerializer.Serialize<Subject>(swp);
//Console.WriteLine(strJson);

//var nonJson = JsonSerializer.Deserialize<Subject>(strJson);
//Console.WriteLine(nonJson.GetType());
//Console.WriteLine(nonJson.Name);

var subjectList = new List<Subject>();
subjectList.Add(swp);
subjectList.Add(new Subject("Labor", "C:/Users/Stephan/OneDrive - HTL Neufelden"));

var serializedSubjectList = JsonSerializer.Serialize<Subject[]>(subjectList.ToArray());
var deserializedSubjList = JsonSerializer.Deserialize<Subject[]>(serializedSubjectList);
//Console.WriteLine(deserializedSubjList[1].Name);

await File.WriteAllTextAsync("C:/Users/Stephan/data.json", serializedSubjectList);
var readData = await File.ReadAllTextAsync("C:/Users/Stephan/data.json");
var NonJsonReadData = JsonSerializer.Deserialize<Subject[]>(readData);
//Console.WriteLine(NonJsonReadData[1].Name);
//Console.WriteLine(NonJsonReadData[0].Name);

//foreach(var s in SubjectLocationFinder.ListFiles(testSubj.Path))
//{
//    Console.WriteLine(s);
//}
//Console.WriteLine("----------------------------------");
//foreach (var s in SubjectLocationFinder.ListFiles(testSubj.Path, "*keil*"))
//{
//    Console.WriteLine(s);
//}

