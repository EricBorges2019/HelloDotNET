// See https://aka.ms/new-console-template for more information
using System.IO;


Console.WriteLine("Hello, World!");
Console.WriteLine("Type in a key corresponding to something you want me to do:");
Console.WriteLine("F to write something to a file;");
Console.WriteLine("Q to quit.");

string conInput = Console.ReadLine();
//conInput is the console input at the start of the program

while (conInput != "q" && conInput != "Q")


{
    if (conInput == "f" || conInput == "F")
    {
        Console.WriteLine("Type something in for me to write to a file:");
        string fileInput = Console.ReadLine();



        string path = "output.txt";

        File.WriteAllText(path, fileInput);

        Console.WriteLine("In the file: " + path + " you wrote " + fileInput + "!");
        
    }



}
return 0;
