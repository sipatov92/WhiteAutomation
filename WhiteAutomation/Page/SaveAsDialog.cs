using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;
using WhiteAutomation.Actions;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.TreeItems;

namespace WhiteAutomation.Page
{
    public class SaveAsDialog
    {
        private Window saveAsDialogWindow = WordActions.WordPage.WordWindow.ModalWindow("Save As");

        public TextBox EditBoxFileName
        {
            get { return saveAsDialogWindow.Get<TextBox>(SearchCriteria.ByAutomationId("1001")); }
        }

        public Button ButtonSave
        {
            get { return saveAsDialogWindow.Get<Button>(SearchCriteria.ByAutomationId("1")); }
        }

        public Tree TreeFileSystem
        {
            get { return saveAsDialogWindow.Get<Tree>(SearchCriteria.ByAutomationId("100")); }
        }


    }
}
