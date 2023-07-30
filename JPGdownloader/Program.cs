// See https://aka.ms/new-console-template for more information


using System.Text.RegularExpressions;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using Flurl.Http;
using Flurl;
using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

internal class Program
{
     
    public static async Task Main(string[] args)
    {
            //Console.ForegroundColor == ConsoleColor.DarkCyan;


            
            var config = Configuration.Default.WithDefaultLoader().WithLocaleBasedEncoding();
            var context = BrowsingContext.New(config);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Введите ссылку на каталог\r\n");
            Console.ForegroundColor = ConsoleColor.Blue;

            string catalogRef = Console.ReadLine();
            var document = await context.OpenAsync(catalogRef);
            var selector = "a.t";

            var cells = document.QuerySelectorAll(selector).OfType<IHtmlAnchorElement>();
            var titles = cells.Select(m => m.Href).ToList();
            string date = DateTime.Now.Date.ToShortDateString();
            string imgRef = "";
            string voidUrl = "https://static.nix.ru/art/picture_coming_soon.gif";
            //string model = "";


        foreach (var title in titles)
            {
                
                var doc = await BrowsingContext.New(config).OpenAsync(title);

                try
                {

                     imgRef = doc.GetElementById("goods_photo").GetAttribute("href");
                     if (imgRef == voidUrl)
                     {
                         throw new Exception();
                     }



                }

                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Нет ссылки на фото! {title}");
                    continue;

                }
    
                
                

                 
                string model = doc.QuerySelector("td#tdsa2944 ").FirstChild.TextContent ?? "n/a"; 
   
                 


                Match match = Regex.Match(catalogRef, @"(?<=section=)(.*?)(?=#c_id)");

                if (match.Success)
                {
                    string dirAutoValue = match.Groups[1].Value;
                    string path = $@"E:\Products\Images\{dirAutoValue}\";
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Начало загрузки!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(model);


                // https://devkazakov.com/ru/blog/csharp-obrabotka-oshibok/
                //using (var flurlClient = new FlurlClient())
                {

                    try
                    {
                        var jpeg = await imgRef.DownloadFileAsync(path, model + "(" + date + ")" + ".jpg");
                        Thread.Sleep(300);

                    }
                    catch (Exception e)
                    {
                        
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"ОШИБКА ЗАПИСИ В ФАЙЛ {imgRef}");
                        continue; ;
                    }
                     
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Обьект загружен!\r\n");

                

                }

                else
                {
                    Console.WriteLine("Секция не найдена");
                }

                
                
            }
            Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine($"Загрузка завершена. Все файлов в каталоге : {titles.Count}");

    }
}





            