
using AngleSharp.Html.Dom;
using AngleSharp;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using AngleSharp.Dom;
using System.IO;
using AngleSharp.Html.Parser;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using System;

namespace ImgParse

{
    public class Program
    {
        static async Task Main(string[] args)

        {





            var config = Configuration.Default.WithDefaultLoader().WithLocaleBasedEncoding();
            var context = BrowsingContext.New(config);
            string catalogRef =
                "https://tula.nix.ru/price.html?section=cpu_all#c_id=161&fn=161&g_id=7&page=1&sort=%2Bp8175%2B1605%2B7287%2B766%2B2326&spoiler=&store=region-1483_0&thumbnail_view=2";
            var document = await context.OpenAsync(catalogRef);
            var selector = "a.t";

            var cells = document.QuerySelectorAll(selector).OfType<IHtmlAnchorElement>();
            var titles = cells.Select(m => m.Href).ToList();




            //var dbContext = new ProductDbContext();
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Производитель\tМодель\tСокет\tЯдра\tЧастота\tПотоки\tЯдра\tЦена\tСсылка");

            foreach (var title in titles)
            {



                var doc = await BrowsingContext.New(config).OpenAsync(title);


                //var manufacturer = doc.QuerySelector("td#tdsa2943").TextContent ?? "n/a";

                //var model = doc.QuerySelector("td#tdsa2944 ").TextContent ?? "n/a";
                //var cores = doc.QuerySelector("td#tdsa2557 ").TextContent ?? "n/a";
                //var _freq = doc.QuerySelector("td#tdsa2943").FirstChild.TextContent ?? "n/a";
                //var freq = Regex.Replace(_freq, @"\D+.{4}", "", RegexOptions.ECMAScript);

                //var threads = doc.QuerySelector("td#tdsa23450").FirstChild.TextContent ?? "n/a";
                //var socket = doc.QuerySelector("td#tdsa1307").FirstChild.TextContent ?? "n/a";

                //var _power = doc.QuerySelector("td#tdsa893").FirstChild.TextContent;
                //var power = ushort.Parse(Regex.Replace(_power, @"\D+", "", RegexOptions.ECMAScript));

                //var _mass = doc.QuerySelector("td#tdsa1672").TextContent;
                //float mass = float.Parse(Regex.Replace(_mass, @"\D+", "", RegexOptions.ECMAScript));

                //var price = Decimal.Parse(doc.QuerySelector("meta[itemprop=price]").GetAttribute("content"));
                //var img  = doc.GetElementById("goods_photo").GetAttribute("href").ToString();

                //var processor = new Cpu()
                //{
                //    Manufacture = manufacturer,
                //    Model = model,
                //    Socket = socket,
                //    Cores = cores,
                //    Frequency = freq,
                //    Threads = threads,
                //    //Power = power,
                //    Price = price,
                //    Image = img

                //};






                //Console.WriteLine(processor.Manufacture);
                //Console.WriteLine(processor.Model);
                //Console.WriteLine(processor.Socket);
                //Console.WriteLine(processor.Cores);
                //Console.WriteLine(processor.Frequency);
                //Console.WriteLine(processor.Threads);
                //Console.WriteLine(processor.Price);
                //Console.WriteLine(processor.Image);







                //await _dbContext.Processors.AddAsync(processor);
                //await _dbContext.SaveChangesAsync();






                //var price = Decimal.Parse(doc.QuerySelector("meta[itemprop=price]").GetAttribute("content"));
                var img = doc.GetElementById("goods_photo").GetAttribute("href").ToString();

                Console.WriteLine(img);



            }







            
          

           
            

            
           

            

            Console.WriteLine("Parsing completed.");
        }
    }
}

 