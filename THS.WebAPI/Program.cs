using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI
{
    class Program
    {
       static void Main(string[] args)
        {
            string baseAddress = ConfigurationManager.AppSettings["baseAddress"];
            try
            {
                var assemblies = AppDomain.CurrentDomain.GetAssemblies();
                LoadAssembliesInExecutingDirtory();
                WebApp.Start<Startup>(url: baseAddress);

               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + e.StackTrace);
            }

            Console.WriteLine(string.Format("Server started,monitored at {0}", baseAddress));

            Console.ReadLine(); 

        }
        static void LoadAssembliesInExecutingDirtory()
        {
            try
            {
                var assemblies = AppDomain.CurrentDomain.GetAssemblies();
                foreach (var path in Directory.GetFiles(AppDomain.CurrentDomain.SetupInformation.ApplicationBase))
                {
                    if (Path.GetExtension(path).Equals(".dll", StringComparison.CurrentCultureIgnoreCase)
                        && !path.Contains("Microsoft"))
                    {
                        if (!assemblies.Any(ass => ass.GetName().Name == Path.GetFileNameWithoutExtension(path)))
                            try
                            {
                                //Assembly.LoadFile(path);
                            }
                            catch { Debug.Fail("loaded an unknown dll"); }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error");
                Console.WriteLine(ex.Message + ex.StackTrace);
            }
        }    

    }
}
