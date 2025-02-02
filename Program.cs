// See https://aka.ms/new-console-template for more information
using System.IO;


Console.WriteLine("Hello, World!");
Console.WriteLine("Type something in for me to write to a file:");
string input = Console.ReadLine();



string path = "output.txt";

File.WriteAllText(path, input);

Console.WriteLine("In the file: " + path + " you wrote " + input + "!");