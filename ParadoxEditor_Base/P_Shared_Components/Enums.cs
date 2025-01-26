using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxEditor_Base.P_Shared_Components
{
    public enum Language
    {
        none, english, german
    }

    public enum LanguageTag
    {
        NONE, ENG, GER
    }

    public static class EnumConversions
    {
        public static Language ToLanguage(this string text)
        {
            Language language = Language.none;
            try
            {
                language = Enum.Parse<Language>(text);
            }
            catch (Exception)
            {
            }
            return language;
        }

        public static LanguageTag ToLanguageTag(this string text)
        {
            Language l = Language.none;
            LanguageTag tag = LanguageTag.NONE;
            try
            {
                l = Enum.Parse<Language>(text);
                if (l == Language.english)
                {
                    tag = LanguageTag.ENG;
                }
                else if (l == Language.german)
                {
                    tag = LanguageTag.GER;
                }
            }
            catch (Exception)
            {
            }
            return tag;
        }
    }

}
