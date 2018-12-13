using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSample1
{
    public partial class MainForm : Form
    {
        static SettingsForm m_settingsForm = new SettingsForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnButtonSettings_Click(object sender, EventArgs e)
        {
            m_settingsForm.Show();
        }
    }
}
