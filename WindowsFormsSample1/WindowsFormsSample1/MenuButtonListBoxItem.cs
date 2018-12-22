using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSample1
{
    /// <summary>
    /// MenuButtonListBoxItem
    /// </summary>
    public class MenuButtonListBoxItem
    {
        public MenuButtonListBoxItem(AdvancedButton control)
        {
            this.ButtonСontrol = control;
            this.DisplayName = control.Description != string.Empty ? control.Description : control.Id;
        }

        public AdvancedButton ButtonСontrol { get; set; }

        public string DisplayName { get; set; }

        public override string ToString()
        {

            return this.DisplayName;
        }
    }
}
