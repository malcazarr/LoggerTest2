using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTest2.Class
{
    interface ILogger
    {
        void write(string message, string type);
    }
}
