using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationProblem
{
    interface IPrintScanSegregated
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopy(string content);
    }
    
    interface IFaxContent
    {
        bool FaxContent(string content);
    }
    
}
