using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class IdentifyTheme
    {
        public int IdentifyThemeNumber(ComboBox cb)
        {
            var CBSelectedItem = cb.SelectedItem;

            var StringTheme = CBSelectedItem.ToString();

            using (var context = new Context())
            {
                var ThemeID = from s in context.Theme
                              where s.ThemeName == StringTheme
                              select s.ID;

                int ID = 1;
                var LIST = ThemeID.ToString();
                int.TryParse(LIST, out ID);
                return ID;
                
            }

            
        }
    }
}
