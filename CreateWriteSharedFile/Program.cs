// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TestFile.txt");
var fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
StreamWriter sw = new StreamWriter(fileStream);
int cout = 0;
while (true)
{
    for (var i = 0; i < 10; i++)
    {
        sw.WriteLine(cout++);
        Console.WriteLine(cout);
    }
    sw.Flush();
    await Task.Delay(1000);
}