using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ConsoleEXEFwk
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Trace.Listeners.Add(new System.Diagnostics.ConsoleTraceListener());
                Trace.WriteLine("Start");
                WhatIsMyDOTNETRuntime();
                string dirExe = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string dirPlugins = System.IO.Path.Combine(dirExe, "Plugins");
                MefHost host = new MefHost(dirPlugins);
                Trace.WriteLine($"Discovered '{host.AllPlugins.Length}' plugins");
                for(int index=0;index<host.AllPlugins.Length;index++)
                {
                    var lazy = host.AllPlugins[index];
                    System.Diagnostics.Trace.WriteLine($"\tPlugin name={lazy.Metadata["name"]}      Index={index}");
                }
                Trace.WriteLine("Select the index of the plugin which you want to execute");
                string sIndexDesired = Console.ReadLine();
                Trace.WriteLine($"You selected index={sIndexDesired}");
                int iIndexDesired = int.Parse(sIndexDesired);
                var lazyPlugin = host.AllPlugins[iIndexDesired];
                Trace.WriteLine($"Going to execute plugin:{lazyPlugin.Metadata["name"]}");
                Demo.Contracts.IPlugin iPlugin = lazyPlugin.Value;
                iPlugin.DoWork(dirExe);
                Trace.WriteLine("Completed without errors");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.ToString());
            }
        }
        public static void WhatIsMyDOTNETRuntime()
        {
            //string ver = AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName;

            string ver = Assembly.GetEntryAssembly()?.GetCustomAttribute<System.Runtime.Versioning.TargetFrameworkAttribute>()?.FrameworkName;
            Console.WriteLine($"NET CORE RUNTIME={ver}");


        }
    }

}
