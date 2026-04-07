// See https://aka.ms/new-console-template for more information

using PetriNoitaLib;
using System.Data.Common;
using System.Drawing;
using System.Text.RegularExpressions;

/*var pp = new PetriNoitaLib.PetriPainter();

List<string> files = Directory.EnumerateFiles("C:\\Users\\slightlytango\\Desktop\\petri_fying\\save00\\world\\").ToList();

Directory.CreateDirectory("tiles");

foreach (string file in files)
{
    Match match = Regex.Match(file, @"world_([0-9-]*)_([0-9-]*).png_petri$");// \\world_9728_2048.png_petri
    if(match.Success)
    { 
        Console.WriteLine(file);

        Bitmap bm = pp.LoadImage("C:\\Users\\slightlytango\\Desktop\\petri_fying\\save00\\world\\" + match.Groups[0]);
        bm.Save("tiles/" + match.Groups[1] + "_" +  match.Groups[2]+".png", System.Drawing.Imaging.ImageFormat.Png);
    }
}

*/


string testfile = "C:\\Users\\slightlytango\\Desktop\\petri_fying\\save00\\world\\entities_0.bin";
PetriNoitaLib.V2.EntityFile ef = PetriNoitaLib.V2.EntityFile.Read(testfile);
PetriNoitaLib.V2.NoitaStream test = new PetriNoitaLib.V2.NoitaStream();
