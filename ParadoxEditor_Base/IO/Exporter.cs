using ParadoxEditor_Base.Editor_Components;
using ParadoxEditor_Base.P_Shared_Components.Localisations;
using System;
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

        public static void Export(object o, string path)
        {
            string text = Interpret(o, null,0);
            File.WriteAllText (path, text);
        }

        private static string Interpret(object o,string propertyName, int tab)
        {
            string text = "";
            text = text.InsertFront('\t',tab);

            if (string.IsNullOrWhiteSpace(propertyName))
            {
                text += o.GetType().ToStringNN() + "= {";
            }
            else
            {
                text += propertyName + "= {";
            }
            text += "\n";
            tab++;
            text = text.InsertFront('\t', tab);

            if (o is Localisation || o is LocalisationCollection)
            {
            }
            else
            {
                if (o.GetType().IsByRef)
                {
                    var props = o.GetType().GetProperties();
                    foreach (var p in props)
                    {
                        var val = o.GetType().GetProperty(p.Name).GetValue(o);
                        text += Interpret(val, p.Name, tab + 1);
                    }
                }
                else if (o.GetType().IsPrimitive)
                {
                    text += o;
                }
            }
            tab--;
            text = text.InsertFront('\t', tab) + "}";
            text += "\n";
            return text;
        }
    }
}
