using ParadoxEditor_Base.P_Shared_Components.Localisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxEditor_Base.Editor_Components
{
    public class EditorSetting
    {
        public string Name { get; set; }
        public Localisation Localisation { get; set; }
        public Type ValueType { get; set; }
        public object Value { get; set; }
    }
}
