using log4net.Config;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin;
using Microsoft.Owin.Hosting;
using AngularJsWebApi.Frontend;

namespace AngularJsWebApi.Development
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            var url = ConfigurationManager.AppSettings["hostUrl"];

            using (WebApp.Start<Startup>(url))
            {
                Console.Title = "TopologyBarPOC Agent";
                Console.ReadKey();
            }
        }
    }
}
