using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace HaiAdmin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OpenBrowser("http://localhost:9100");
            CreateHostBuilder(args).Build().Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls("http://*:9100");
                    webBuilder.UseStartup<Startup>();
                });

        private static void OpenBrowser(string url)
        {
            System.Threading.Tasks.Task.Run(() =>
            {
                try
                {
                    if (System.Diagnostics.Process.Start("chrome.exe", url) == null)
                    {
                        var key = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(@"http\shell\open\command");
                        var s = key.GetValue("").ToString();
                        var lastIndex = s.IndexOf(".exe", System.StringComparison.OrdinalIgnoreCase);
                        var path = s.Substring(1, lastIndex + 3);
                        System.Diagnostics.Process.Start(path, url);
                    }
                }
                catch
                {
                    System.Diagnostics.Process.Start("explorer", url);
                }
            });            
        }
    }
}
