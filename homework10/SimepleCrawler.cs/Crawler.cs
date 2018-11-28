using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Collections;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimepleCrawler.cs
{
    class Crawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        static void Main(string[] args)
        {
            Crawler myCrawler = new Crawler();
            string startUrl = "http://www.baidu.com";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false);
            myCrawler.Crawl();
            //new Thread(myCrawler.Crawl).Start();
            //Task[] tasks =
            //{
            //    Task.Run(()=>myCrawler.Crawl()),
            //    Task.Run(()=>myCrawler.Crawl()),
            //};
            //Task t1 = new Task(()=>myCrawler.Crawl());
            //Task t2 = new Task(()=>myCrawler.Crawl());
            //Thread.Sleep(1);
        }
        private void Crawl()
        {
            Console.WriteLine("开始爬行");
            Parallel.For(0, 100, count =>
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }             
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current);
                urls[current] = true;
                count++;
                Parse(html);
            });
            Console.WriteLine("爬行结束");
        }
        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }
        public void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach(Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"','\"','#', ' ','>');
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
                
            }
        }
    }
}
