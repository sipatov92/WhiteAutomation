using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using TestStack.White;

namespace WhiteAutomation.TestCase
{
    public class BaseTestCase
    {
        private static Application application;

        public static Application LaunchApplication(string path)
        {
            ProcessStartInfo psi = new ProcessStartInfo(path);
            application = Application.AttachOrLaunch(psi);
            application.WaitWhileBusy();
            Thread.Sleep(3000);
            return application;
        }

        public static Application Application
        {
            get { return application; }
        }
        [SetUp]
        public void SetUp() { }

        [TearDown]
        public void ShutDown()
        {
            Application.Kill();
        }


    }
}
