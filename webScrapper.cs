// See https://aka.ms/new-console-template for more information

// ______________________________________________________________________________________________

// USEFUL link for scrapper

// To add text to file
// https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-write-text-to-a-file

// to scrape data of web
// https://learn.microsoft.com/en-us/dotnet/api/system.net.webclient.downloadstring?view=net-9.0

// ______________________________________________________________________________________________
using System.Net;

Console.WriteLine("Give me Website URL:");

string WebURL = Console.ReadLine();

Console.WriteLine("Now give the file Name: ");

string fileName = Console.ReadLine();

WebClient client = new WebClient();
string reply = client.DownloadString(WebURL);

Console.WriteLine(reply);


// Set a variable to the Documents path.
string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

// Write the text to a new file named "WriteFile.txt".
File.WriteAllText(Path.Combine(docPath, $"webs/{fileName}"), reply);
