using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
//using System.Windows.Forms;

namespace BlackJackMVC
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            //Application.EnableVisualStyles();
            //Application.Run(new StartForm());
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
