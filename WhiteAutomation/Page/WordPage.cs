using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.TabItems;
using TestStack.White.UIItems.WindowItems;
using WhiteAutomation.TestCase;

namespace WhiteAutomation.Page
{
    public class WordPage
    {
        private Window wordWindow = BaseTestCase.Application.GetWindows()[0];

        public Window WordWindow
        {
            get { return this.wordWindow; }
        }

        public IUIItem ItemBlankDocument
        {
            get { return wordWindow.Get(SearchCriteria.ByAutomationId("AIOStartDocument")); }
        }

        public GroupBox GroupFont
        {
            get { return wordWindow.Get<GroupBox>(SearchCriteria.ByText("Font")); }
        }
        public ComboBox ComboBoxFontFamily
        {
            get
            {
                var item = GroupFont.AutomationElement.FindFirst(TreeScope.Descendants, new AndCondition(new PropertyCondition(AutomationElement.NameProperty, "Font:"), new PropertyCondition(AutomationElement.ClassNameProperty, "NetUIComboboxAnchor")));
                return new ComboBox(item, wordWindow);
            }
        }

        public ComboBox ComboBoxFontSize
        {
            get
            {
                var item = GroupFont.AutomationElement.FindFirst(TreeScope.Descendants, new AndCondition(new PropertyCondition(AutomationElement.NameProperty, "Font Size:"), new PropertyCondition(AutomationElement.ClassNameProperty, "NetUIComboboxAnchor")));
                return new ComboBox(item, wordWindow);
            }
        }

        public TextBox DocumentArea
        {
            get { return wordWindow.Get<TextBox>(SearchCriteria.ByText("Document1").AndByClassName("_WwG")); }
        }

        public Button ButtonFile
        {
            get { return wordWindow.Get<Button>(SearchCriteria.ByAutomationId("FileTabButton")); }
        }

        public IUIItem TabSaveAs
        {
            get { return wordWindow.Get(SearchCriteria.ByText("Save As")); }
        }

        public IUIItem TabSaveOnComputer
        {
            get { return wordWindow.Get(SearchCriteria.ByText("Computer")); }
        }

        public Button ButtonBrowse
        {
            get { return wordWindow.Get<Button>(SearchCriteria.ByText("Browse")); }
        }



    }
}
