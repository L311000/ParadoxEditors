using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxEditor_Base.P_Shared_Components
{
    public enum P_Language
    {
        none, english, german
    }

    public enum P_LanguageTag
    {
        NONE, ENG, GER
    }

    public static class EnumConversions
    {
        public static P_Language ToLanguage(this string text)
        {
            P_Language language = P_Language.none;
            try
            {
                language = Enum.Parse<P_Language>(text);
            }
            catch (Exception)
            {
            }
            return language;
        }

        public static P_LanguageTag ToLanguageTag(this string text)
        {
            P_Language l = P_Language.none;
            P_LanguageTag tag = P_LanguageTag.NONE;
            try
            {
                l = Enum.Parse<P_Language>(text);
                if (l == P_Language.english)
                {
                    tag = P_LanguageTag.ENG;
                }
                else if (l == P_Language.german)
                {
                    tag = P_LanguageTag.GER;
                }
            }
            catch (Exception)
            {
            }
            return tag;
        }
    }

}
