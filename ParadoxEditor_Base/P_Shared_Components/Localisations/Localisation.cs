using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxEditor_Base.P_Shared_Components.Localisations
{
    public class Localisation
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public string Text { get; set; }
        public P_Language Language { get; set; }
    }
}
