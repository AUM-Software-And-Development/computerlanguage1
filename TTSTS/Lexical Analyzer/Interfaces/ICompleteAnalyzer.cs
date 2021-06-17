using System;
using System.Collections.Generic;
using System.Text;

namespace TTSTS
{
    public interface ICompleteAnalyzer
    {
        string GetInput(string userInputString);
        List<uint> ConvertStringToASCIIList(string stringToConvert);
        List<List<uint>> ConvertStringListToASCIILists(List<string> stringsToConvert);
        uint SumOfAllParts(List<uint> decimalsToCount);
        void RemoveNonEnglishValues(List<List<uint>> sourceLists, ref List<List<uint>> destinationLists);
    }
}
