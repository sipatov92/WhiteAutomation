using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.InputDevices;
using TestStack.White.WindowsAPI;
using WhiteAutomation.Page;

namespace WhiteAutomation.Actions
{
    public class SaveAsActions
    {
        private static SaveAsDialog saveAsDialog = new SaveAsDialog();

        public static SaveAsDialog SaveAsDialog
        {
            get { return saveAsDialog; }
        }

        public SaveAsActions SetFileName(string path)
        {
            saveAsDialog.EditBoxFileName.Click();
            Keyboard.Instance.HoldKey(KeyboardInput.SpecialKeys.CONTROL);
            Keyboard.Instance.Enter("a");
            Keyboard.Instance.LeaveAllKeys();
            Keyboard.Instance.PressSpecialKey(KeyboardInput.SpecialKeys.BACKSPACE);
            Keyboard.Instance.Send(path, saveAsDialog.EditBoxFileName);
            return TestStepActions<SaveAsActions>.Instance;
        }

        public WordActions ClickButtonSave()
        {
            saveAsDialog.ButtonSave.Click();
            return TestStepActions<WordActions>.Instance;
        }

        public SaveAsActions SelectDirectoryInTree(params string[] directory)
        {
            saveAsDialog.TreeFileSystem.Nodes.GetItem(directory).Click();
            return TestStepActions<SaveAsActions>.Instance;
        }
    }
}
