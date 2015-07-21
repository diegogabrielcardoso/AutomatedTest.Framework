using Automation.AcceptanceTest.Framework.WindowsApp.Elements;

namespace Automation.AcceptanceTest.Framework.WindowsApp.BaseTest
{    
    public class StepBase
    {
        private string _stepName;
        public string StepName
        {
            get { return this._stepName; }
            set
            {
                this._stepName = value;                
            }
        }

        public Navigator Navigator { get; set; }

        /// <summary>
        ///     Initialize a test step for the executable
        /// </summary>
        /// <param name="applicationExecutable"></param>
        public StepBase(string applicationExecutable)
        {
            Navigator = new Navigator(applicationExecutable);
        }
    }
}
