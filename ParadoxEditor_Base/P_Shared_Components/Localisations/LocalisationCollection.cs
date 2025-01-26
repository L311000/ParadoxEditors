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
        public Language Language { get; set; }
    }
}
