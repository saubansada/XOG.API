﻿using System;
using System.Web.UI;

namespace XOG.Models
{
    [Serializable]
    public class PrintSettings
    {
        public Control ControlToPrint
        {
            get;
            set;
        }

        public bool HtmlPrintEnabled
        {
            get;
            set;
        }

        public string HtmlToPrint
        {
            get;
            set;
        }

        public int PrintCount
        {
            get;
            set;
        }
    }
}
