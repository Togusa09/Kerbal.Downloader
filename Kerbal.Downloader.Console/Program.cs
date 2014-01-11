using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerbal.Downloader.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var kerbal = new KerbalDownloader();
            kerbal.Download(0);

            //var mods = kerbal.Search("space");
            //foreach (var mod in mods)
            //{
            //    Console.WriteLine("Mod:\t{0}", mod.Name);
            //    Console.WriteLine("Id:\t{0}", mod.Id);
            //    Console.WriteLine("Link:\t{0}", mod.Link);
            //    Console.WriteLine("Image:\t{0}/n", mod.ImagePath);
            //}
            //Console.ReadLine();
            
        }



        
    }
}
