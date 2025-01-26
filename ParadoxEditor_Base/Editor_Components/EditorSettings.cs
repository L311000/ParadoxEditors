using ParadoxEditor_Base.P_Shared_Components;
using ParadoxEditor_Base.P_Shared_Components.Localisations;
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
        public EditorSetting ShowSavePrompt { get; set; }

        public void SetDefault_Language()
        {
            Language = new()
            {
                Name = "Language",
                ValueType = typeof(P_Language),
                Value = P_Language.english,

                Localisation = new Localisation()
            };
            Language.Localisation.Name = "Language";
            Language.Localisation.Priority = 0;
            Language.Localisation.Language = P_Language.english;
            Language.Localisation.Text = "Language:";
        }

        public void SetDefault_AutoCreateLocalisation()
        {
            AutoCreateLocalisation = new()
            {
                Name = "AutoCreateLocalisation",
                ValueType = typeof(bool),
                Value = true,

                Localisation = new Localisation()
            };
            AutoCreateLocalisation.Localisation.Name = "AutoCreateLocalisation";
            AutoCreateLocalisation.Localisation.Priority = 0;
            AutoCreateLocalisation.Localisation.Language = P_Language.english;
            AutoCreateLocalisation.Localisation.Text = "Automatic creation of localisations enabled:";
        }

        public void SetDefault_ShowSavePrompt()
        {
            ShowSavePrompt = new()
            {
                Name = "ShowSavePrompt",
                ValueType = typeof(bool),
                Value = true,

                Localisation = new Localisation()
            };
            ShowSavePrompt.Localisation.Name = "ShowSavePrompt";
            ShowSavePrompt.Localisation.Priority = 0;
            ShowSavePrompt.Localisation.Language = P_Language.english;
            ShowSavePrompt.Localisation.Text = "Show save prompt if unsaved changes are detected:";
        }
    }
}
