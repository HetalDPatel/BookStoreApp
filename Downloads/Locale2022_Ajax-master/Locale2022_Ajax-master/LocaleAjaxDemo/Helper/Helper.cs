using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace LocaleAjaxDemo.Helper
{
    public class Helper
    {
        protected static CultureInfo En = new CultureInfo("en-US");
        protected static CultureInfo Fr = new CultureInfo("fr-CA");
        public static CultureInfo Culture;


        Helper()
        {

        }

        public static int Lang
        {
            get
            {
                if (Culture != null)
                {
                    switch (Culture.Name.ToLower())
                    {
                        case "fr-ca":
                            return 1;
                        default:
                            return 0;
                    }
                }

                return 0;
            }
        }

        public static CultureInfo LangCultureInfo
        {
            get
            {
                switch (Thread.CurrentThread.CurrentCulture.Name.ToLower())
                {
                    case "fr-ca":
                        return Fr;
                    default:
                        return En;
                }
            }
        }

        public static int CurrentCulture
        {
            set
            {
                switch (value)
                {
                    case 1:
                        Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = Culture = Fr;
                        break;
                    default:
                        Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = Culture = En;
                        break;
                }
            }
        }

    }
}