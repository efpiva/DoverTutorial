using System;
using System.Collections.Generic;
using Dover.Framework;
using Dover.Framework.Attribute;
using SAPbouiCOM;

namespace I18NExample
{

    [ResourceBOM("I18NExample.UDO.xml", ResourceType.UDO)]
    [ResourceBOM("I18NExample.UDF.xml", ResourceType.UserField)]
    [ResourceBOM("I18NExample.UDT.xml", ResourceType.UserTable)]
    [Menu(String="DoverTutorial", Type=BoMenuType.mt_POPUP, UniqueID="doverTut", FatherUID="43520")]
    [Menu(String="My Form", Type=BoMenuType.mt_STRING, UniqueID="doverTutForm", FatherUID="doverTut")]
    [AddIn(Name="I18NExample", Description="My Test App", Namespace="DOVER_WL", LicenseFile="I18NExample.publicKey.xml")]
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
