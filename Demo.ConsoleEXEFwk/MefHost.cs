using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ConsoleEXEFwk
{
    public class MefHost
    {
        private string _dirPlugins;
        internal string _patternPluginDll = "*Demo*.dll";

        public MefHost(string dirPlugins)
        {
            System.Diagnostics.Trace.WriteLine("MefHost.ctor");
            this._dirPlugins = dirPlugins;
            
            List<DirectoryCatalog> lstAllSubfolders = new List<DirectoryCatalog>();
            string[] subfolders = System.IO.Directory.GetDirectories(dirPlugins);
            foreach(string subfolder in subfolders)
            {
                DirectoryCatalog catSubfolder = new DirectoryCatalog(subfolder, _patternPluginDll);
                lstAllSubfolders.Add(catSubfolder);
            }
            AggregateCatalog aggCat = new AggregateCatalog(lstAllSubfolders);
            CompositionContainer container = new CompositionContainer(aggCat);
            container.ComposeParts(this);
            System.Diagnostics.Trace.WriteLine("Mef discovery complete");
        }
        [ImportMany(typeof(Demo.Contracts.IPlugin))]
        public Lazy<Demo.Contracts.IPlugin, Dictionary<string, object>>[] AllPlugins { get; set; }
    }
}
