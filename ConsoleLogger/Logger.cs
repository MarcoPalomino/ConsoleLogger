using System;

namespace ConsoleLogger
{
    public class Logger: ILogger
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logType"></param>
        /// <param name="logMessage"></param>
        /// <returns></returns>
        public bool DoLog(string logType, string logMessage)
        {
            try
            {
                var strLog = string.Empty;
                var creationDate = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() ;

                strLog = string.Format("Time: {0} / Type: {1} / Message: {2} ", creationDate, logType, logMessage);
                Console.WriteLine(strLog);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
