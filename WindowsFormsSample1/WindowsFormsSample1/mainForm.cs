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
       private bool m_firstStart = true;


        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (m_firstStart)
            {
                InitForm();
                m_firstStart = false;
            }
        }

        private void InitForm()
        {
            UpdateMenuButtons();
            FillButtonsListBox();
        }

        /// <summary>
        /// Menu buttons
        /// </summary>
        public List<AdvancedButton> GetMenuButtons

        {
            get
            {
                var buttons = new List<AdvancedButton>();
                AddMenuButtonsToList(GetMenuPanel, buttons);
                buttons.Reverse();
                return buttons;
            }
        }

        /// <summary>
        /// Adds control as AdvancedButton to List<AdvancedButton>
        /// or loops through controls in control to define it within
        /// </summary>
        /// <param name="control"></param>
        /// <param name="list"></param>
        private void AddMenuButtonsToList(Control control, List<AdvancedButton> list)
        {
            if (control is AdvancedButton) list.Add((AdvancedButton)control);
            else if (control.Controls.Count > 0)
                foreach (Control ctrl in control.Controls) AddMenuButtonsToList(ctrl, list);
        }

        private AdvancedButton FindNestedMenuButtonById(Control control, string ID)
        {
            if (control == null) return null;
            var advButton = control as AdvancedButton;
            if (advButton != null && advButton.Id == ID)
                return (AdvancedButton)control;
            else if (control.Controls.Count > 0)
                foreach (Control ctrl in control.Controls)
                {
                    advButton = ctrl as AdvancedButton;
                    if (advButton != null && advButton.Id == ID) return (AdvancedButton)ctrl;
                }

            return null;
        }
        /// <summary>
        /// Panel with menu buttons
        /// </summary>
        public Panel GetMenuPanel => m_panelMenuButtons;

        /// <summary>
        /// Update menu buttons visibility and position
        /// </summary>
        public void UpdateMenuButtons()
        {
            // TODO implement logic for sorting menuButtons and setting of its visibility

            // use m_runtimeButtonsOrder or VALUE_DEFAULT_MENU_BUTTONS_ORDER for 
            // getting information in which order the buttons should be displayed
            // and visible or not the button should be

            // create a list from items of string mentioned above;
            // loop through all items of list and set proper order and visibility of menu buttons

            // the width of m_panelMenuButtons should be also update according to visibility of button
            // the width of panel is a sum of width of all visible buttons

            //---------------------
            // CODE goes here
            //---------------------


        }

        /// <summary>
        /// Fill items in CheckedListBox
        /// </summary>
        private void FillButtonsListBox()
        {
            // TODO fill up the m_checkedListBoxMenuButtons

            // here should goes a code block with logic
            // that adds an items to the list box
            // the type of data that is stored in item of m_checkedListBoxMenuButtons
            // is MenuButtonListBoxItem

            var mainForm = this;

            //---------------------
            // CODE goes here
            //---------------------


            SetMenuButtonsTranslation();

        }
        /// <summary>
        /// Set translation of items in the CheckListBox
        /// </summary>
	    private void SetMenuButtonsTranslation()
        {
            // TODO add captions (DisplayName) to the items of m_checkedListBoxMenuButtons.
            // use property Id of AdvancedButton to define which value
            // will be used as DisplayName for m_checkedListBoxMenuButtons.Items[i]
            // type of m_checkedListBoxMenuButtons.Items[i] is MenuButtonListBoxItem
            // values NEW_PROJECT, SAVE_PROJECT, OPEN_PROJECT, UNDO, REDO, MESSAGE_CENTER, UPDATES_MANAGER
            // are used as DisplayName

            //---------------------
            // CODE goes here
            //---------------------

        }

        /// <summary>
        /// Occurs when on buttons up or down was clicked
        /// </summary>
	    private void OnMenuButtonsListMoveItem(object sender, EventArgs e)
        {
            var button = m_checkedListBoxMenuButtons.SelectedItem as MenuButtonListBoxItem;
            if (button == null)
                return;

            if (sender == m_buttonMoveUp)
                MoveItemUp(button);
            else if (sender == m_buttonMoveDown)
                MoveItemDown(button);


        }

        /// <summary>
        /// Moves item up
        /// </summary>
        private void MoveItemUp(MenuButtonListBoxItem btn)
        {
            // TODO implement logic of changing the order of items m_checkedListBoxMenuButtons

            // after pressing m_buttonMoveDown the items goes down

            //---------------------
            // CODE goes here
            //---------------------
        }
        /// <summary>
        /// Moves item down
        /// </summary>
        private void MoveItemDown(MenuButtonListBoxItem btn)
        {
            // TODO implement logic of changing the order of items m_checkedListBoxMenuButtons

            // after pressing m_buttonMoveDown the items goes down
            
            //---------------------
            // CODE goes here
            //---------------------
        }

        private void ReorderMenuButtons()
        {
            // TODO get actual order of items in checkedListBox and reorder menuButtons and visibility
            // 

            // save actual order of menu buttons to the runtime variable;
            // the Checked property defines visibility of menuButton
            // the format of string should be like variable VALUE_DEFAULT_MENU_BUTTONS_ORDER
            // this m_runtimeButtonsOrder is used for sorting menuButtons
            // type of m_checkedListBoxMenuButtons.Items[i] is MenuButtonListBoxItem

            //---------------------
            // CODE goes here
            //---------------------

            // TODO here goes logic of changing order of menu buttons
            UpdateMenuButtons();
        }

        // Names of buttons in the listbox
        public static string NEW_PROJECT = "New project file";
        public static string SAVE_PROJECT = "Save project";
        public static string OPEN_PROJECT = "Open project";
        public static string UNDO = "Undo";
        public static string REDO = "Redo";
        public static string MESSAGE_CENTER = "Message Center";
        public static string UPDATES_MANAGER = "Updates Manager";

        private void OnButtonReorder_Click(object sender, EventArgs e)
        {
            ReorderMenuButtons();
        }

        private string BuildStringOfList(List<string> list, char splitter)
        {
            var builder = new StringBuilder();

            for (var i = 0; i < list.Count; i++)
            {
                builder.Append(list[i]);

                if (i < list.Count - 1)
                    builder.Append(splitter);
            }

            return builder.ToString();
        }


        private const char SPLITTER_FOR_BUTTONS_ORDER = ';';
        private const string VALUE_DEFAULT_MENU_BUTTONS_ORDER = "New,True;Open,True;Undo,True;Redo,True;Save,True;Message,True";
        private string m_runtimeButtonsOrder = string.Empty;

    }
}
