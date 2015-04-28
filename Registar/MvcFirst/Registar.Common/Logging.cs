using log4net;
using log4net.Config;
using Registar.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registar.Common
{
    /// <summary>
    /// class that is used for logging errors or warnings using log4net
    /// </summary>
   public static class Logging
    {

       private static ILog theLogger =LogManager.GetLogger(typeof(Logging));

       static Logging()
       {
           XmlConfigurator.Configure();
       }
        public static void LogError(string message, Exception e = null, params object[] formatParams)
        {
            string tmp = string.Format(message, formatParams);

            theLogger.Error(tmp,e);
        }

        public static void LogWarn(string message)
        {
            theLogger.Warn(message);
        }
    }
}
