using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxEditor_Base.P_Shared_Components.Localisations
{
    public class LocalisationCollection
    {
        public List<Localisation> Localisations { get; set; } = new();
        public P_Language Language { get; set; }

        public void Add(Localisation l)
        {
            Localisations.Add(l);
        }

        public void Remove(Localisation l)
        {
            Localisations.Remove(l);
        }
    }
}
