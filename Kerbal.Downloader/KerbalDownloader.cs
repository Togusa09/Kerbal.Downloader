using HtmlAgilityPack;
using NuGet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Kerbal.Downloader
{
    public class KerbalDownloader
    {
        public List<KerbalMod> Search(string searchString)
        {

       

            //var test = new NuGet.ZipPackage("");
            //test.GetFiles().First().


            //var modList = new List<KerbalMod>();
            ////http://kerbalspaceport.com/?s=+&file_types=plugin&orderby=meta_value_num&meta_key=realstars

            //var kerbalURL = @"http://kerbalspaceport.com/?s=+" + searchString + "+";
            //using (var webClient = new WebClient())
            //{
            //    var pageContent = webClient.DownloadString(kerbalURL);

            //    HtmlDocument doc = new HtmlDocument();
            //    doc.LoadHtml(pageContent);
            //    var mods = doc.DocumentNode.Descendants().Where(n => n.Attributes.Where(a => a.Name == "class").Where(a => a.Value.Contains("search_item")).Any())
            //        //.Select(n => n.Attributes.Select(a => a.Value).ToList())
            //        .ToList();
            //    foreach (var mod in mods)
            //    {
            //        var id = mod.Attributes["id"].Value;
            //        var modNameNode = mod.SelectSingleNode("h5//a");
            //        var imageNode = mod.SelectSingleNode("a/img");
            //        var modPathNode = mod.SelectSingleNode("a");
            //        modList.Add(new KerbalMod
            //        {
            //            Id = int.Parse(id),
            //            Name = modNameNode.InnerText,
            //            ImagePath = imageNode.Attributes["src"].Value,
            //            Link = modPathNode.Attributes["href"].Value
            //        });
            //    }
            //}
            //return modList;\
            return new List<KerbalMod>();
        }

        //http://www.aaron-powell.com/posts/2011-02-20-creating-a-nuget-plugin-engine.html

        public void Download(int modId)
        {
            
        }
    }
}
