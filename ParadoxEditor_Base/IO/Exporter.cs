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

        public static void Export(object o, string path)
        {
            string text = Interpret(o, null, 0, string.Empty);
            File.WriteAllText(path, text);
        }

        private static string Interpret(object o, string propertyName, int tab, string prevText)
        {
            string text = prevText;
            if (o.GetType() != typeof(Localisation))
            {

                if (string.IsNullOrWhiteSpace(propertyName))
                {
                    text += "[Type]" + o.GetType().ToStringNN() + "= {";
                }
                else
                {
                    text = text.Append('\t', tab) + "[Property]" + propertyName + "= {";
                }
                text += "\n";
                tab++;


                if (o.GetType().IsPrimitive || o.GetType() == typeof(string) || o is Type || o is Enum)
                {
                    tab++;
                    text = text.Append('\t', tab);
                    if (o is Enum)
                    {
                        var e = (Enum) o;
                        text += $"[Value]{e.ToStringNN()}";
                    }
                    else
                    {
                        text += $"[Value]{o.ToStringNN()}";
                    }
                }
                else if (!o.GetType().IsValueType)
                {
                    var props = o.GetType().GetProperties();
                    foreach (var p in props)
                    {
                        var val = o.GetType().GetProperty(p.Name).GetValue(o);
                        text = Interpret(val, p.Name, tab, text);
                    }
                }
                text += "\n";
                text = text.Append('\t', tab) + "}";
                text += "\n";
            }
            return text;
        }
    }
}
