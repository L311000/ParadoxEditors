using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxEditor_Base.Editor_Components
{
    public class EditorSettings
    {
        public EditorSetting Language { get; set; }
        public EditorSetting AutoCreateLocalisation { get; set; }
        public EditorSettings ShowSavePrompt { get; set; }
    }
}
