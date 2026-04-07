using IgniteView.Core;
using IgniteView.Desktop;
using System.Drawing;
using System.Text.RegularExpressions;

public class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        var pp = new PetriNoitaLib.PetriPainter();
        DesktopPlatformManager.Activate();
        var app = new ViteAppManager();
        var tileregex = new Regex("/tiles/([\\d-]*)/([\\d-]*)/([\\d-]*)");
        var noitasavepath = "C:\\Users\\slightlytango\\Desktop\\petri_fying\\save00\\world\\";
        app.CurrentServerManager.CurrentServer.Routes.PreAuthentication.Dynamic.Add(WatsonWebserver.Core.HttpMethod.GET,
                                                                                    tileregex, 
                                                                                    async (context) => {
                                                                                        var match = tileregex.Match(context.Request.Url.RawWithoutQuery);
                                                                                        int zoom = int.Parse(match.Groups[1].Value);
                                                                                        int x = int.Parse(match.Groups[2].Value);
                                                                                        int y = int.Parse(match.Groups[3].Value);
                                                                                        string imagepath = noitasavepath + "world_" + x + "_" + y + ".png_petri";

                                                                                        var bm = pp.LoadImage(imagepath);
                                                                                        if(bm == null)
                                                                                        {
                                                                                            context.Response.StatusCode = 404;
                                                                                            await context.Response.Send();
                                                                                            return;
                                                                                        }
                                                                                        context.Response.Headers["Content-Type"] = "image/png";
                                                                                        MemoryStream ms = new MemoryStream();
                                                                                        bm.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                                                                        ms.Seek(0, SeekOrigin.Begin);
                                                                                        await context.Response.Send(ms.Length, ms);
                                                                                        //bm.Save()

                                                                                        /*List<string> files = Directory.EnumerateFiles("C:\\Users\\slightlytango\\Desktop\\petri_fying\\save00\\world\\").ToList();

                                                                                        Directory.CreateDirectory("tiles");

                                                                                        foreach (string file in files)
                                                                                        {
                                                                                            Match match = Regex.Match(file, @"world_([0-9-]*)_([0-9-]*).png_petri$");// \\world_9728_2048.png_petri
                                                                                            if (match.Success)
                                                                                            {
                                                                                                Console.WriteLine(file);

                                                                                                Bitmap bm = pp.LoadImage("C:\\Users\\slightlytango\\Desktop\\petri_fying\\save00\\world\\" + match.Groups[0]);
                                                                                                bm.Save("tiles/" + match.Groups[1] + "_" + match.Groups[2] + ".png", System.Drawing.Imaging.ImageFormat.Png);
                                                                                            }
                                                                                        }*/


                                                                                        },
                                                                                    async (context, except) => { });

        var mainWindow =
            WebWindow.Create()
            .WithTitle("Hello, world")
            .Show();

        app.Run();
    }
}