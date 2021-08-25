using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationProblem
{
    class Cannon : IPrintScanSegregated
    {
       
        public bool PhotoCopy(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool ScanContent(string content)
        {
            throw new NotImplementedException();
        }
    }
}
