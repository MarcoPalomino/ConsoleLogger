using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogger
{
    interface ILogger
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logType"></param>
        /// <param name="logMessage"></param>
        /// <returns></returns>
        bool DoLog(string logType, string logMessage);
    }
}
