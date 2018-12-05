using System;
using System.IO;
using System.Threading;
using NUnit.Framework;
using WhiteAutomation.Actions;

namespace WhiteAutomation.TestCase
{
    public class WordTestCase : BaseTestCase
    {
        [Test]
        public void EditAndSaveFile()
        {
            BaseTestCase.LaunchApplication("winword.exe");
            string text = "Some Text";
            string font = "Times New Roman";
            string fontSize = "22";
            string fileName = $"WhiteDocument{new Random().Next(100).ToString()}";
            string path = $@"F:\{fileName}.docx";

            TestStepActions<WordActions>.Instance
                .ClickBlankDocument()
                .SetFontFamily(font)
                .SetFontSize(fontSize)
                .SetDocumentText(text)

                .VerifyTextCorrect(text)
                .VerifyFontCorrect(font)
                .VerifyFontSize(fontSize)

                .SaveAsDocument()
                .SelectDirectoryInTree("Desktop", "This PC", "Local Disk (F:)")
                .SetFileName(fileName)
                .ClickButtonSave();
                Thread.Sleep(1000);
            Assert.IsTrue(File.Exists(path));
        }
    }
}
