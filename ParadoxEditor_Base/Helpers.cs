using Mehlmann_Shared;
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
