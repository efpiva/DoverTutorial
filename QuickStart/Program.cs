using System;
using System.Collections.Generic;
using Dover.Framework;
using Dover.Framework.Attribute;
using SAPbouiCOM;

namespace DoverTutorial
{
    [Menu(String="DoverTutorial", Type=BoMenuType.mt_POPUP, UniqueID="doverTut", FatherUID="43520")]
    [Menu(String="My Form", Type=BoMenuType.mt_STRING, UniqueID="doverTutForm", FatherUID="doverTut")]
    [AddIn(Description="My Test App", B1SResource="DoverTutorial.DoverTutorial.b1s")]
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try 
            {
                Dover.Framework.Application app = new Dover.Framework.Application();
                app.Run();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
