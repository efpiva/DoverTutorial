using System;
using System.Collections.Generic;
using System.Xml;
using SAPbouiCOM.Framework;
using SAPbouiCOM;
using Dover.Framework.Attribute;
using Dover.Framework.Form;

namespace DoverTutorial
{
    [MenuEvent(UniqueUID ="doverTutForm")]
    [FormAttribute("QuickStart.Form1", "Form1.b1f")]
    public class Form1 : DoverUserFormBase
    {
        public Form1()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("1").Specific));
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("2").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private Button Button0;

        private void OnCustomInitialize()
        {

        }

        private Button Button1;
    }
}