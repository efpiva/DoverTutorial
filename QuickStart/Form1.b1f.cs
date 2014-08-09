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
    [FormAttribute("DoverTutorial.Form1", "Form1.b1f")]
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
        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }
    }
}