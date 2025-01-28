using ParadoxEditor_Base.Editor_Components;
using ParadoxEditor_Base.P_Shared_Components;
using ParadoxEditor_Base.P_Shared_Components.Localisations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ParadoxEditor_Base.IO
{
    public static class Importer
    {
        public static LocalisationCollection ImportLocalisations(string path)
        {
            LocalisationCollection c = new LocalisationCollection();
            var content = File.ReadAllLines(path);
            bool languageFound = false;
            try
            {
                foreach (var line in content)
                {
                    if(line.Contains("l_") && languageFound == false)
                    {
                        var lang = line.Extract(line.IndexOf('_') + 1, line.IndexOf(':'));
                        c.Language = lang.ToLanguage();
                        languageFound = true;
                    }
                    else
                    {
                        var loc = line.ToLocalisation();
                        if (loc != null)
                        {
                            loc.Language = c.Language;
                            c.Add(loc);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return c;
        }

        public static EditorSettings ImportSettings(string path)
        {
            EditorSettings settings = new EditorSettings();
            var fileContent = File.ReadAllLines(path);
            return settings;
        }
    }
}
