using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using NUnit.Framework;
using TestStack.White.InputDevices;
using TestStack.White.WindowsAPI;
using WhiteAutomation.Page;

namespace WhiteAutomation.Actions
{
    public class WordActions
    {
        private static WordPage wordPage = new WordPage();

        public static WordPage WordPage
        {
            get { return wordPage; }
        }

        public WordActions SetFontFamily(string fontFamily)
        {
            try
            {
                wordPage.ComboBoxFontFamily.Select(fontFamily);
            }
            catch (Exception e){}
            
            return TestStepActions<WordActions>.Instance;
        }

        public WordActions ClickBlankDocument()
        {
            wordPage.ItemBlankDocument.Click();
            return TestStepActions<WordActions>.Instance;
        }

        public WordActions SetFontSize(string fontSize)
        {
            try
            {
                wordPage.ComboBoxFontSize.Select(fontSize);
            }
            catch (Exception e){}
            
            return TestStepActions<WordActions>.Instance;
        }

        public WordActions SetDocumentText(string text)
        {
            wordPage.DocumentArea.SetValue(text);
            return TestStepActions<WordActions>.Instance;
        }

        public WordActions VerifyTextCorrect(string text)
        {
            Assert.AreEqual(text, wordPage.DocumentArea.BulkText);
            return TestStepActions<WordActions>.Instance;
        }

        public WordActions VerifyFontCorrect(string font)
        {
            var pattern = wordPage.DocumentArea.GetPattern<TextPattern>();
            string actualFont = pattern.DocumentRange.GetAttributeValue(TextPattern.FontNameAttribute).ToString();
            Assert.AreEqual(font, actualFont);
            return TestStepActions<WordActions>.Instance;
        }

        public WordActions VerifyFontSize(string fontSize)
        {
            var pattern = wordPage.DocumentArea.GetPattern<TextPattern>();
            string actualFont = pattern.DocumentRange.GetAttributeValue(TextPattern.FontSizeAttribute).ToString();
            Assert.AreEqual(fontSize, actualFont);
            return TestStepActions<WordActions>.Instance;
        }

        public SaveAsActions SaveAsDocument()
        {
            wordPage.ButtonFile.Click();
            wordPage.TabSaveAs.Click();
            wordPage.TabSaveOnComputer.Click();
            wordPage.ButtonBrowse.Click();
            return TestStepActions<SaveAsActions>.Instance;
        }
    }
}
