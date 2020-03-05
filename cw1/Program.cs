using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cw1
{
    class Program
    {
        public static async Task  Main(string[] args)
        {
            String url = args[0];
            var client =new HttpClient();
            var page =await client.GetAsync(url);

            if (!page.IsSuccessStatusCode) return;

            String pageString = await page.Content.ReadAsStringAsync();
            Regex reg = new Regex(@"\b\w*[0-9]*@\b[\w,\.]*");
            MatchCollection mc= reg.Matches(pageString);

           
            
            foreach(Match math in mc)
            {
                Console.WriteLine(math);
            }


        }
    }
}
