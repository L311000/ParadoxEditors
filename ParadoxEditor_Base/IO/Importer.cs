using ParadoxEditor_Base.Editor_Components;
using ParadoxEditor_Base.P_Shared_Components;
using ParadoxEditor_Base.P_Shared_Components.Localisations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

        public static T Import<T>(string path)
        {
            var fileContent = File.ReadAllLines(path);
            Type t;
            char startChar = ']';
            char endChar = '=';

            object prevCurrent = null;
            object current = null;
            object obj = null;
            foreach (var l in fileContent)
            {
                if (!string.IsNullOrWhiteSpace(l))
                {
                    if (l.Contains("[Type]"))
                    {
                        t = Type.GetType(l.Extract(l.IndexOf(startChar) +1,l.IndexOf(endChar)));
                        obj = Activator.CreateInstance(t);
                        current = obj;
                        prevCurrent = obj;
                    }
                    else if (l.Contains("[Property]"))
                    {

                    }
                    else if (l.Contains("[Value]"))
                    {

                    }
                }
            }
            return (T)obj;
        }
    }
}
