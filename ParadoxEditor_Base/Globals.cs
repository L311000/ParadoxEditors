using ParadoxEditor_Base.P_Shared_Components;
using ParadoxEditor_Base.P_Shared_Components.Localisations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ParadoxEditor_Base
{
    public static class Globals
    {
        public static Window WindowRef { get; set; }
        public static void CreateLanguageDirectories(string basePath)
        {
            P_Language[] values = Enum.GetValues<P_Language>();
            foreach (P_Language l in values)
            {
                if (l != P_Language.none)
                {
                    string path = basePath + $@"\{l.ToString()}";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                }
            }
        }

        public static Localisation GetLocalisation(bool isEditor)
        {
            Localisation loc = null;
            return loc;
        }
    }
}
