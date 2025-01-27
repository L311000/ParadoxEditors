using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxEditor_Base.Editor_Components
{
    public static class Extensions
    {
        public static string ToStringNN(this object o)
        {
            string newText = "";
            try
            {
                newText = o.ToString();
            }
            catch (Exception)
            {
            }
            return newText;
        }

        public static int ToIntNN(this object o)
        {
            int value = 0;
            try
            {
                value = int.Parse(o.ToStringNN());
            }
            catch (Exception)
            {
            }
            return value;
        }
    }
}
