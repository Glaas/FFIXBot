using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


//File[] files = Directory.GetFiles(@"C:\Users\glaas\Repositories\Web\RockPaperScissorsBot\SS", "*.jpg", SearchOption.AllDirectories);

List<string> files = Directory.GetFiles(@"C:\Users\glaas\Repositories\Web\RockPaperScissorsBot\SS", "*.jpg", SearchOption.AllDirectories).ToList();

for (int i = 0; i < files.Count; i++)
{
    System.IO.File.Move(files[i], i + ".jpg");

}