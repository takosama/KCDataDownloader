using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;

namespace KCDataDownloader
{
    class Program
    {
        static void Main(string[] args)
        {



        }


    }

    static public class Downloader
    {
        readonly static string urlbase = "https://github.com/KC3Kai/kancolle-replay/tree/master/js/";
        static public void DownloadShipData()
        {
            string urlTeel = "kcSHIPDATA.js";
            string url = urlbase + urlTeel;
            string path = "ShipData.js";
            DownloadData(url, path);
        }

        static void DownloadData(string url, string path)
        {
            Console.WriteLine($"Start Download {url}");

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    WebClient wc = new WebClient();
                    wc.DownloadFile(url, path);
                    Console.WriteLine("Download 成功");
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("Download 失敗");
                    Thread.Sleep(5);
                    Console.WriteLine($"リトライします {i + 1}/5");

                }
            }
            Console.WriteLine("Download 失敗");
        }
      
        static public void DownloadItemDatas()
        {

        }
    }

}
