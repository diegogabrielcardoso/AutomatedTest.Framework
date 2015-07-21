using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Automation.AcceptanceTest.Framework.WindowsApp.BaseTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.WindowsAPI;

namespace Automation.AcceptanceTest.Framework.WindowsApp.UnitTest
{

    [TestClass]
    public class RDMSampleTest
    {

        [TestMethod]
        public void OpenRDMAndFillServer()
        {
            var step = new StepBase(@"C:\Users\dcardoso\RDM.exe");
            step.Navigator.UseWindow(0);
            step.Navigator.TextBox().GetById("txtServerName").SetText("aw-pvmqatdb-02");
            step.Navigator.Button().GetById("btnOK").Click();
            step.Navigator.RadioButton().GetById("rdoFOF").Check();
            step.Navigator.Button().GetById("Next").Click();
            step.Navigator.RadioButton().GetById("GeneralDeal").Check();
            step.Navigator.Button().GetById("btnNext").Click();            
            step.Navigator.Tab().GetByIndex(2).Click();            
            step.Navigator.TreeView().GetByIndex(1).SelectCheckBoxInNodeByText("555 West Monroe Street Investor Corp.");
            step.Navigator.RadioButton().GetByIndex(0).Check();
            step.Navigator.TextBox().GetByIndex(0).SetText("Smoke Test");
            step.Navigator.TextBox().GetByIndex(0).SendSpecialKey(KeyboardInput.SpecialKeys.TAB);
        }

    }
}
