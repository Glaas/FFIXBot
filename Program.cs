using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


Console.WriteLine("Hey!");
Console.WriteLine("G to generate text, R to rename file");
string answer = Console.ReadLine().ToUpper();
const string prefix = "{\n\"origin\": [\"#alternatives#\"],\n\"alternatives\" : [" + "\"" + "{img https://raw.githubusercontent.com/Glaas/RockPaperScissorsBot/main/SS/1.jpg}\",";
const string suffix = "]/}";
switch (answer)
{
    case "G":
        GenerateText();
        break;
    case "R":
        RenameFiles();
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}

void GenerateText()
{
    //create new TXT file
    string path = @"C:\Users\glaas\Repositories\Web\RockPaperScissorsBot";
    string fileName = "output.txt";
    string fullPath = Path.Combine(path, fileName);


    using (FileStream fs = File.Create(fullPath))
    {

    }

    //write in file
    using (StreamWriter sw = File.AppendText(fullPath))
    {
        sw.WriteLine(prefix);
        var listOfFiles = Directory.GetFiles(@"C:\Users\glaas\Repositories\Web\RockPaperScissorsBot\SS", "*.jpg", SearchOption.AllDirectories).ToList();
        for (int i = 2; i < listOfFiles.Count; i++)
        {
            if (i == listOfFiles.Count - 1)
            {
                sw.WriteLine("\"{img https://raw.githubusercontent.com/Glaas/RockPaperScissorsBot/main/SS/" + i + ".jpg" + "}\"]\n}");
                break;
            }
            sw.WriteLine("\"{img https://raw.githubusercontent.com/Glaas/RockPaperScissorsBot/main/SS/" + i + ".jpg" + "} \",");
        }

        Console.WriteLine("Done!");
    }
}

void RenameFiles()
{
    List<string> files = Directory.GetFiles(@"C:\Users\glaas\Repositories\Web\RockPaperScissorsBot\SS", "*.jpg", SearchOption.AllDirectories).ToList();

    for (int i = 0; i < files.Count; i++)
    {
        System.IO.File.Move(files[i], i + ".jpg");
        System.Console.WriteLine("Renamed " + files[i] + " to " + i + ".jpg");
    }
}