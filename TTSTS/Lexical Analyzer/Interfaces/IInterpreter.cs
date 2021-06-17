using System;
using System.Collections.Generic;
using System.Text;

namespace TTSTS.Lexical_Analyzer.Interfaces
{
    interface IInterpreter
    {
        void RemoveNonEnglishValues(List<List<uint>> sourceLists, ref List<List<uint>> destinationLists);
    }
}
