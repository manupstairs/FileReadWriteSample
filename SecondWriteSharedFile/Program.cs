// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Shared File!");

var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "TestFile.txt");
var fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
StreamWriter sw = new StreamWriter(fileStream);

while (true)
{
    for (var i = 0; i < 10; i++)
    {
        sw.WriteLine("A".PadRight(i,'A'));
        Console.WriteLine("A".PadRight(i, 'A'));
    }

    sw.Flush();
    await Task.Delay(1000);
}