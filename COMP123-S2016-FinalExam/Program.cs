using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public static class Program
    {
        public static SplashForm splashForm;
        public static GenerateNameForm generateNameForm;
        public static AbilityGeneratorForm abilityGeneratorForm;
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // create
            splashForm = new SplashForm();
            generateNameForm = new GenerateNameForm();
            abilityGeneratorForm = new AbilityGeneratorForm();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //start with SplashForm
            Application.Run(splashForm);
        }
    }
}
