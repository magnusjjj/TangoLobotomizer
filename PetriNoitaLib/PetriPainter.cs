using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Xml;

namespace PetriNoitaLib
{
    public class PetriPainter
    {
        public static Dictionary<string, string> colors = new Dictionary<string, string>();

        // Todo: Thread safety
        public void LoadMaterialColors()
        {
            lock (colors) { 
                if(colors.Count == 0)
                { 
                    XmlDocument materialsxml = new XmlDocument();
                    materialsxml.Load("C:\\Users\\slightlytango\\AppData\\LocalLow\\Nolla_Games_Noita\\data\\materials.xml");
                    var cells = materialsxml.DocumentElement.SelectNodes("CellData");

                    foreach (XmlNode cell in cells)
                    {
                        try
                        {
                            colors.Add(cell.Attributes["name"].Value, cell.Attributes["wang_color"].Value);
                        }
                        catch
                        {

                        }
                    }

                    cells = materialsxml.DocumentElement.SelectNodes("CellDataChild");

                    foreach (XmlNode cell in cells)
                    {
                        try
                        {
                            colors.Add(cell.Attributes["name"].Value, cell.Attributes["wang_color"].Value);
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }

        public Bitmap LoadImage(string filename)
        {
            LoadMaterialColors();

            try
            {

                PngPetri hello = PngPetri.Load(filename);
                int width = 512;
                int height = 512;

                Bitmap bm = new Bitmap(width, height, PixelFormat.Format32bppArgb);

                int custom_color_i = 0;

                for (int x = 0; x < width; x++)
                {
                    for(int y = 0; y < height; y++)
                    {
                        byte material = hello.materials[(y * width) + x]; // TODO: Custom colors.
                        bool is_custom_material = (material & 0b10000000) > 0;

                        Color? outcolor = null;

                        if (is_custom_material)
                        {
                            UInt32 the_custom_color = (UInt32)hello.custom_colors.values[custom_color_i].value;
                            var r = the_custom_color & 0xFF;
                            var g = (the_custom_color & 0xFF00) >> 8;
                            var b = (the_custom_color & 0xFF0000) >> 16;
                            var a = (the_custom_color & 0xFF000000) >> 24;
                            outcolor = Color.FromArgb((int)a, (int)r, (int)g, (int)b);
                            custom_color_i++;
                        } else {
                            material = (byte)(material & 0b01111111);
                            string material_name = hello.material_names.values[material].value;

                            if (colors.ContainsKey(material_name))
                            {
                                string material_color_string = colors[material_name];
                                byte[] color_bytes = Convert.FromHexString(material_color_string);
                                outcolor =  Color.FromArgb(color_bytes[0], color_bytes[1], color_bytes[2], color_bytes[3]);
                            }
                            else
                            {
                                outcolor = Color.FromArgb(0, 0, 0xFF, 0xFF);
                            }

                        }

                        bm.SetPixel(x, y, (Color)outcolor);
                    }
                }

                return bm;
            }
            catch (FileNotFoundException e)
            {
                return null;
            }

        }
    }
}
