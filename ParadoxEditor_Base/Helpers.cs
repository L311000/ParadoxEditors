using ParadoxEditor_Base.Editor_Components;
using ParadoxEditor_Base.P_Shared_Components.Localisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxEditor_Base
{
    public static class Helpers
    {
        public static string Extract(this string t, int start, int end)
        {
            string newText = "";
            try
            {
                for (int i = start; i < end; i++)
                {
                    newText += t[i];
                }
            }
            catch (Exception)
            {
            }
            return newText;
        }

        public static int GetFirstIndexNotWhitespace(this string t)
        {
            try
            {
                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] != ' ')
                    {
                        return i;
                    }
                }
            }
            catch (Exception)
            {
            }
            return 0;
        }
        public static char GetFirstCharacterNotWhitespace(this string t)
        {
            try
            {
                foreach (char c in t)
                {
                    if (c != ' ')
                    {
                        return c;
                    }
                }
            }
            catch (Exception)
            {
            }
            return ' ';
        }

        public static string InsertFront(this string t, char c, int amount)
        {
            string text = "";
            try
            {
                for (int i = 0; i < amount; i++)
                {
                    text += c;
                }
                return text;
            }
            catch (Exception)
            {
                return t;
            }
        }

        public static Localisation ToLocalisation(this string t)
        {
            Localisation loc = null;
            try
            {
                if (t.GetFirstCharacterNotWhitespace() != '#')
                {
                    loc = new Localisation();
                    loc.Name = t.Extract(t.GetFirstIndexNotWhitespace(),t.IndexOf(':'));
                    loc.Priority = t.Extract(t.IndexOf(':')+1, t.IndexOf('"')).ToIntNN();
                    loc.Text = t.Extract(t.IndexOf('"')+1,t.LastIndexOf('"'));
                }
            }
            catch (Exception)
            {
            }
            return loc;
            
        }
    }
}
