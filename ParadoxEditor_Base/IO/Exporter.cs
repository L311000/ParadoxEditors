using Mehlmann_Shared;
using ParadoxEditor_Base.Editor_Components;
using ParadoxEditor_Base.P_Shared_Components.Localisations;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Provider;

namespace ParadoxEditor_Base.IO
{
    public static class Exporter
    {
        
        public static void Export(LocalisationCollection c, string path)
        {
            string text = $"l_{c.Language.ToStringNN()}:";
            text += "\n";
            foreach (var loc in c.Localisations)
            {
                text += $" {loc.GetLoc()}\n";
            }
            File.WriteAllText(path, text);
        }
    }
}
