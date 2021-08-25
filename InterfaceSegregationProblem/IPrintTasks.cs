using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationProblem
{
    public interface IPrintTasks
    {
         bool PrintContent(string content);
        bool ScanContent(string content);
        bool FaxContent(string content);
        bool PhotoCopyContent(string content);


    }
}
