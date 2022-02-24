// See https://aka.ms/new-console-template for more information
Console.WriteLine("Try to read someting!");

var path =Path.Combine( Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TestFile.txt");
var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read,FileShare.ReadWrite);
var reader = new StreamReader(fileStream);

while (!reader.EndOfStream)
{
    Console.WriteLine(reader.ReadLine());
    await Task.Delay(1000);
}
