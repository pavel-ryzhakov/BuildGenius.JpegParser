using AngleSharp;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ImgParse
{
    internal class Parser
    {


        //    private readonly ProductDbContext _dbContext;

        //    public Parser(ProductDbContext dbContext)
        //    {
        //        _dbContext = dbContext;
        //    }

        //    public async Task ParseProcessorsAsync(List<string> processorUrls)
        //    {
        //        var config = Configuration.Default.WithDefaultLoader();
        //        var context = BrowsingContext.New(config);

        //        foreach (var url in processorUrls)
        //        {
        //            var doc = await context.OpenAsync(url);

        //            var manufacturer = doc.QuerySelector("td#tdsa2943").FirstChild.TextContent ?? "n/a";

        //            var model = doc.QuerySelector("td#tdsa2944 ").FirstChild.TextContent ?? "n/a";
        //            var cores = Int32.Parse(doc.QuerySelector("td#tdsa2557 ").FirstChild.TextContent);
        //            var _freq = doc.QuerySelector("td#tdsa2943").FirstChild.TextContent ?? "n/a";
        //            var freq = Regex.Replace(_freq, @"\D+.{4}", "", RegexOptions.ECMAScript);

        //            var threads = doc.QuerySelector("td#tdsa23450").FirstChild.TextContent ?? "n/a";
        //            var socket = doc.QuerySelector("td#tdsa1307").FirstChild.TextContent ?? "n/a";

        //            //var _power = doc.QuerySelector("td#tdsa893").FirstChild.TextContent;
        //            //var power = ushort.Parse(Regex.Replace(_power, @"\D+", "", RegexOptions.ECMAScript));

        //            var _mass = doc.QuerySelector("td#tdsa1672").FirstChild.TextContent;
        //            float mass = float.Parse(Regex.Replace(_mass, @"\D+", "", RegexOptions.ECMAScript));

        //            var price = Decimal.Parse(doc.QuerySelector("meta[itemprop=price]").GetAttribute("content"));


        //            var processor = new Cpu()
        //            {
        //                Manufacture = manufacturer,
        //                Model = model,
        //                Socket = socket,
        //                Cores = cores,
        //                Frequency = freq,
        //                Threads = threads,
        //                //Power = power,
        //                Price = price,
        //                Image = freq

        //            };

        //             Console.WriteLine(processor.Manufacture, processor.Model, processor.Socket);

        //            //var table = new Table(); 
        //            //table.SetHeaders("Производитель", "Модель", "Сокет", "Ядра", "Частота", "Потоки", "Ядра", "Цена", "Ссылка");
        //            //table.AddRow(processor.Manufacture, processor.Model, processor.Socket,processor.Cores.ToString(),processor.Frequency,processor.Threads,processor.Price.ToString(),processor.Image);
        //            //Console.WriteLine(table.ToString());



        //            await _dbContext.Processors.AddAsync(processor);
        //            await _dbContext.SaveChangesAsync();


        //        }
        //    }
        //}
    }
}
    

